namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.txtIP = new MetroFramework.Controls.MetroTextBox();
            this.btnConnect = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.numericUpDown_X = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Y = new System.Windows.Forms.NumericUpDown();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.txtConsoleCommand = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.txtSourceLocation = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Y)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton1.Location = new System.Drawing.Point(76, 46);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(216, 46);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Cделать скриншот";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(638, 300);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(185, 45);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Выйти";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // txtIP
            // 
            // 
            // 
            // 
            this.txtIP.CustomButton.Image = null;
            this.txtIP.CustomButton.Location = new System.Drawing.Point(267, 1);
            this.txtIP.CustomButton.Name = "";
            this.txtIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIP.CustomButton.TabIndex = 1;
            this.txtIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIP.CustomButton.UseSelectable = true;
            this.txtIP.CustomButton.Visible = false;
            this.txtIP.Lines = new string[0];
            this.txtIP.Location = new System.Drawing.Point(3, 14);
            this.txtIP.MaxLength = 32767;
            this.txtIP.Name = "txtIP";
            this.txtIP.PasswordChar = '\0';
            this.txtIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIP.SelectedText = "";
            this.txtIP.SelectionLength = 0;
            this.txtIP.SelectionStart = 0;
            this.txtIP.ShortcutsEnabled = true;
            this.txtIP.Size = new System.Drawing.Size(289, 23);
            this.txtIP.TabIndex = 2;
            this.txtIP.UseSelectable = true;
            this.txtIP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIP.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(298, 14);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(90, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseSelectable = true;
            this.btnConnect.Click += new System.EventHandler(this.MetroButton3_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton3.Location = new System.Drawing.Point(7, 21);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(188, 61);
            this.metroButton3.TabIndex = 5;
            this.metroButton3.Text = "Изменить положение";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click_1);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(201, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(189, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Введите координаты курсора";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // numericUpDown_X
            // 
            this.numericUpDown_X.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_X.Location = new System.Drawing.Point(213, 62);
            this.numericUpDown_X.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.numericUpDown_X.Name = "numericUpDown_X";
            this.numericUpDown_X.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown_X.TabIndex = 7;
            this.numericUpDown_X.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_X.ValueChanged += new System.EventHandler(this.numericUpDown_X_ValueChanged);
            // 
            // numericUpDown_Y
            // 
            this.numericUpDown_Y.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Y.Location = new System.Drawing.Point(308, 62);
            this.numericUpDown_Y.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.numericUpDown_Y.Name = "numericUpDown_Y";
            this.numericUpDown_Y.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown_Y.TabIndex = 8;
            this.numericUpDown_Y.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(213, 40);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(24, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "X: ";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(308, 40);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(24, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Y: ";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroButton3);
            this.metroPanel1.Controls.Add(this.numericUpDown_Y);
            this.metroPanel1.Controls.Add(this.numericUpDown_X);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(425, 42);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(398, 106);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnConnect);
            this.metroPanel2.Controls.Add(this.txtIP);
            this.metroPanel2.Controls.Add(this.metroButton1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(21, 42);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(398, 106);
            this.metroPanel2.TabIndex = 12;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(425, 20);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(195, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Изменить положение курсора";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(21, 20);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 19);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Введите IP:";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.txtConsoleCommand);
            this.metroPanel3.Controls.Add(this.metroLabel7);
            this.metroPanel3.Controls.Add(this.metroButton4);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(425, 188);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(398, 106);
            this.metroPanel3.TabIndex = 12;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // txtConsoleCommand
            // 
            // 
            // 
            // 
            this.txtConsoleCommand.CustomButton.Image = null;
            this.txtConsoleCommand.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtConsoleCommand.CustomButton.Name = "";
            this.txtConsoleCommand.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConsoleCommand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsoleCommand.CustomButton.TabIndex = 1;
            this.txtConsoleCommand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsoleCommand.CustomButton.UseSelectable = true;
            this.txtConsoleCommand.CustomButton.Visible = false;
            this.txtConsoleCommand.Lines = new string[0];
            this.txtConsoleCommand.Location = new System.Drawing.Point(213, 59);
            this.txtConsoleCommand.MaxLength = 32767;
            this.txtConsoleCommand.Name = "txtConsoleCommand";
            this.txtConsoleCommand.PasswordChar = '\0';
            this.txtConsoleCommand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsoleCommand.SelectedText = "";
            this.txtConsoleCommand.SelectionLength = 0;
            this.txtConsoleCommand.SelectionStart = 0;
            this.txtConsoleCommand.ShortcutsEnabled = true;
            this.txtConsoleCommand.Size = new System.Drawing.Size(165, 23);
            this.txtConsoleCommand.TabIndex = 5;
            this.txtConsoleCommand.UseSelectable = true;
            this.txtConsoleCommand.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsoleCommand.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtConsoleCommand.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(213, 21);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(113, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Введите команду";
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton4.Location = new System.Drawing.Point(7, 21);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(188, 61);
            this.metroButton4.TabIndex = 5;
            this.metroButton4.Text = "Отправить команду";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(425, 166);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(183, 19);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "Ввести консольную команду";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(425, 300);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(195, 45);
            this.metroButton5.TabIndex = 5;
            this.metroButton5.Text = "Disconnect";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(21, 166);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(175, 19);
            this.metroLabel8.TabIndex = 16;
            this.metroLabel8.Text = "Отправить файл на сервер";
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroButton7);
            this.metroPanel4.Controls.Add(this.txtSourceLocation);
            this.metroPanel4.Controls.Add(this.metroLabel9);
            this.metroPanel4.Controls.Add(this.btnSend);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(21, 188);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(398, 157);
            this.metroPanel4.TabIndex = 15;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // metroButton7
            // 
            this.metroButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton7.Location = new System.Drawing.Point(264, 102);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(114, 40);
            this.metroButton7.TabIndex = 7;
            this.metroButton7.Text = "Browse";
            this.metroButton7.UseSelectable = true;
            this.metroButton7.Click += new System.EventHandler(this.metroButton7_Click);
            // 
            // txtSourceLocation
            // 
            // 
            // 
            // 
            this.txtSourceLocation.CustomButton.Image = null;
            this.txtSourceLocation.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtSourceLocation.CustomButton.Name = "";
            this.txtSourceLocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSourceLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSourceLocation.CustomButton.TabIndex = 1;
            this.txtSourceLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSourceLocation.CustomButton.UseSelectable = true;
            this.txtSourceLocation.CustomButton.Visible = false;
            this.txtSourceLocation.Lines = new string[0];
            this.txtSourceLocation.Location = new System.Drawing.Point(178, 59);
            this.txtSourceLocation.MaxLength = 32767;
            this.txtSourceLocation.Name = "txtSourceLocation";
            this.txtSourceLocation.PasswordChar = '\0';
            this.txtSourceLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSourceLocation.SelectedText = "";
            this.txtSourceLocation.SelectionLength = 0;
            this.txtSourceLocation.SelectionStart = 0;
            this.txtSourceLocation.ShortcutsEnabled = true;
            this.txtSourceLocation.Size = new System.Drawing.Size(200, 23);
            this.txtSourceLocation.TabIndex = 5;
            this.txtSourceLocation.UseSelectable = true;
            this.txtSourceLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSourceLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(8, 59);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(148, 19);
            this.metroLabel9.TabIndex = 6;
            this.metroLabel9.Text = "Введите путь до файла";
            // 
            // btnSend
            // 
            this.btnSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSend.Location = new System.Drawing.Point(178, 102);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(80, 40);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Отправить";
            this.btnSend.UseSelectable = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(841, 363);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroButton2);
            this.Name = "Form1";
            this.Text = "Remote";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Y)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox txtIP;
        private MetroFramework.Controls.MetroButton btnConnect;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.NumericUpDown numericUpDown_X;
        private System.Windows.Forms.NumericUpDown numericUpDown_Y;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroTextBox txtConsoleCommand;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroTextBox txtSourceLocation;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton btnSend;
        private MetroFramework.Controls.MetroButton metroButton7;
    }
}

