using System.IO;
using System.Net.Sockets;
using System.Text;
using System;
using System.Drawing;
using System.Net;

public class RemoteClient
{
    private TcpClient client;
    private NetworkStream stream;
    private static int screenshotPacketSize = 1920 * 1080 * 4;

    public bool ConnectToServer(string ipAddress, int port)
    {
        try
        {
            client = new TcpClient(ipAddress, port);
            stream = client.GetStream();
            return true; // Успешное установление соединения
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при установлении соединения: {ex.Message}");
            return false; // Ошибка при установлении соединения
        }
    }

    public bool SendCommand(string command)
    {
        try
        {
            byte[] data = Encoding.ASCII.GetBytes(command);
            stream.Write(data, 0, data.Length);
            return true; // Команда успешно отправлена
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при отправке команды: {ex.Message}");
            return false; // Ошибка при отправке команды
        }
    }

    public Image ReceiveScreenshot()
    {

        byte[] receivedPhotoBytes = new byte[client.ReceiveBufferSize = screenshotPacketSize];
        int bytesRead = stream.Read(receivedPhotoBytes, 0, receivedPhotoBytes.Length);

        // Создаем изображение из полученных байтов
        Image screenshot;
        using (MemoryStream ms = new MemoryStream(receivedPhotoBytes, 0, bytesRead))
        {
            screenshot = Image.FromStream(ms);
            return screenshot;
        }
    }

    public string GetCommandResult()
    {
        try
        {
            byte[] buffer = new byte[client.ReceiveBufferSize];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            return Encoding.UTF8.GetString(buffer, 0, bytesRead);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при получении результата выполнения команды: {ex.Message}");
            return null; // В случае ошибки возвращаем null
        }
    }

    public void SendFile(string filePath)
    {
        try
        {
            byte[] fileData = File.ReadAllBytes(filePath);

            stream.Write(fileData, 0, fileData.Length);
            Console.WriteLine("Файл успешно отправлен на сервер.");
        }

        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка при отправке файла: " + ex.Message);
        }
    }


    public void DisconnectFromServer()
    {
        stream.Close();
        client.Close();
    }
}
