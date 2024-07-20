using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        /*public string ipAddress = "172.20.10.7";*/
        public int port = 5354; // примерный порт
        private RemoteClient remoteClient = new RemoteClient();
        public static Bitmap image = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        private string sourceLocation = "";

        // Инициализация формы
        public Form1()
        {
            InitializeComponent();
        }



        // функция, которая делает скриншот с сервера по нажатию на кнопку и отображает в диалоговом окне
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string command = "take-screenshot"; // Команда для выполнения скриншота

                remoteClient.SendCommand(command);

                Image screenshot = remoteClient.ReceiveScreenshot();
                if (screenshot != null)
                {
                    Screenshot screenshotDialog = new Screenshot(screenshot);
                    screenshotDialog.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ошибка при получении скриншота", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // функция, которая выполняет выход из программы и разрыв соединения с сервером по нажатию кнопки
        private void metroButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        // функция, которая осуществляет подключение к серверу по указанному IP - адрессу
        private void MetroButton3_Click(object sender, EventArgs e)
        {
            bool isConnected = remoteClient.ConnectToServer(txtIP.Text, 5354);
            if (isConnected)
            {
                // Соединение успешно установлено
                MessageBox.Show("Соединение установлено");
            }
            else
            {
                // Обработка ошибки при установлении соединения
                MessageBox.Show("Ошибка при установлении соединения");
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            try
            {
                decimal x = numericUpDown_X.Value;
                decimal y = numericUpDown_Y.Value;

                // Формируем пользовательскую команду для обновления положения курсора
                string command = $"change-position;{x},{y}";
                remoteClient.SendCommand(command);
                              
                // Отображаем сообщение для подтверждения успешной отправки команды
                MessageBox.Show("Положение курсора успешно обновлено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // В случае возникновения исключения отображаем сообщение об ошибке
                MessageBox.Show("Произошла ошибка при обновлении положения курсора: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                string consoleCommand = txtConsoleCommand.Text;

                // Формируем консольную команду
                string command = $"console-command;{consoleCommand}";
                remoteClient.SendCommand(command);

                // Получаем результат выполнения команды
                string commandResult = remoteClient.GetCommandResult();

                // Отображаем результат выполнения команды на клиенте
                ShowConsoleCommandResult(commandResult);
            }
            catch (Exception ex)
            {
                // В случае возникновения исключения отображаем сообщение об ошибке
                MessageBox.Show("Произошла ошибка при отправке команды: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void ShowConsoleCommandResult(string commandResult)
        {
            MessageBox.Show("Результат выполнения команды: " + commandResult, "Результат выполнения команды", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            remoteClient.DisconnectFromServer();
            MessageBox.Show("Соединение разорвано");
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            string file_path = txtSourceLocation.Text;
            remoteClient.SendFile(file_path);
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                sourceLocation = openFileDialog.FileName;
                txtSourceLocation.Text = sourceLocation;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                remoteClient.SendFile(txtSourceLocation.Text);
                MessageBox.Show("Файл отправлен");
            }
            catch (Exception)
            {

                MessageBox.Show("Произошла ошибка при отправке команды: ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void numericUpDown_X_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}


