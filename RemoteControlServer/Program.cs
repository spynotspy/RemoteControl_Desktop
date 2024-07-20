using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using InputSimulator = WindowsInput.InputSimulator;


namespace ServerApplication
{
    class Program
    {
        public static Bitmap BM = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        private const string serverDirectory = @"C:\Users\Dima\OneDrive\Desktop\"; // рабочий стол пользователя

        static void Main(string[] args)
        {
            TcpListener server = null;

            try
            {
                Int32 port = 0000;
                IPAddress localAddr = IPAddress.Parse("Ваш IP");
                server = new TcpListener(localAddr, port);
                server.Start();

                while (true)
                {
                    Console.Write("Waiting for a connection... ");

                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");

                    Thread clientThread = new Thread(() =>
                    {
                        HandleClient(client);
                    });
                    clientThread.Start();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                server.Stop();
            }
        }

        private static void HandleClient(TcpClient client)
        {
            Byte[] bytes = new Byte[1024 * 1024];
            NetworkStream stream = client.GetStream();
            String data;

            int bytesRead = 0;

            while (true)
            {
                bytesRead = stream.Read(bytes, 0, bytes.Length);
                if (bytesRead <= 0)
                {
                    break;
                }

                data = Encoding.UTF8.GetString(bytes, 0, bytesRead);
                Console.WriteLine("Получено: {0}", data);

                Thread commandThread = new Thread(() =>
                {
                    ProcessCommand(data, stream, bytes, bytesRead);
                });
                commandThread.Start();
            }

            client.Close();
        }

        private static void ProcessCommand(string data, NetworkStream stream, Byte[] bytes, int bytesRead)
        {
            string[] commandParts = data.Split(';');
            if (commandParts.Length >= 2 && commandParts[0] == "change-position")
            {
                // Извлечение и разбор значений x и y
                string[] coordinates = commandParts[1].Split(',');
                if (coordinates.Length == 2 &&
                    decimal.TryParse(coordinates[0], out decimal x) &&
                    decimal.TryParse(coordinates[1], out decimal y))
                {
                    // Калибровка курсора для перемещения в указанную позицию
                    MoveCursorOnPosition(x, y);
                    // Отправка подтверждающего сообщения обратно клиенту
                    byte[] response = Encoding.ASCII.GetBytes("Позиция курсора изменена");
                    stream.Write(response, 0, response.Length);
                }
                else
                {
                    // Недопустимый формат координат
                    byte[] response = Encoding.ASCII.GetBytes("Недопустимый формат координат");
                    stream.Write(response, 0, response.Length);
                }
            }
            else if (commandParts.Length >= 2 && commandParts[0] == "console-command")
            {
                // Извлекаем команду из полученных данных
                string consoleCommand = commandParts[1];

                // Выполнить консольную команду с помощью процесса оболочки
                string commandResult = ExecuteConsoleCommand(consoleCommand);

                // Отправить результат клиенту
                byte[] resultBytes = Encoding.UTF8.GetBytes(commandResult);
                stream.Write(resultBytes, 0, resultBytes.Length);
            }
            else if (commandParts[0] == "take-screenshot")
            {
                // Захват скриншота
                Bitmap screenshot = CaptureScreen();
                using (MemoryStream ms = new MemoryStream())
                {
                    screenshot.Save(ms, ImageFormat.Png);
                    stream.Write(ms.GetBuffer(), 0, Convert.ToInt32(ms.Length));
                }
            }
            else
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    while ((bytesRead = stream.Read(bytes, 0, bytes.Length)) > 0)
                    {
                        ms.Write(bytes, 0, bytesRead);
                    }

                    byte[] fileData = ms.ToArray();

                    string desktopPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                    string filePath = Path.Combine(desktopPath, "received_file.txt");
                    File.WriteAllBytes(filePath, fileData);

                    Console.WriteLine("Файл успешно принят и сохранен на рабочем столе: " + filePath);
                }

            }

            bytes = new byte[1024 * 1024];
        }



        private static Bitmap CaptureScreen()
        {
            Graphics GH = Graphics.FromImage(BM as Image);
            GH.CopyFromScreen(0, 0, 0, 0, BM.Size);
            return BM;
        }


        private static void MoveCursorOnPosition(decimal x, decimal y)
        {
            // Инициализация экземпляра InputSimulator
            InputSimulator s = new InputSimulator();

            // Перемещение курсора на указанную позицию
            s.Mouse.MoveMouseTo((float)x * 100, (float)y * 100);
        }

        private static string ExecuteConsoleCommand(string command)
        {
            try
            {
                // Выполнение консольной команды на сервере
                System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", $"/c {command}");
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;

                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                string result = proc.StandardOutput.ReadToEnd();

                return result;
            }
            catch (Exception ex)
            {
                return "Произошла ошибка при выполнении команды: " + ex.Message;
            }
        }
    }
}