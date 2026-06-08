namespace AppBaranov
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            panelMenu = new Panel();
            Main = new LinkLabel();
            Settings = new LinkLabel();
            About = new LinkLabel();
            panelAbout = new Panel();
            checkBox1 = new CheckBox();
            OnButton = new Button();
            panelSettings = new Panel();
            comboBox1 = new ComboBox();
            newPassAcc = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textTimeOn = new TextBox();
            textTimeOff = new TextBox();
            panelMain = new Panel();
            comboBoxOnSu = new ComboBox();
            comboBoxOnSa = new ComboBox();
            nameAccount = new TextBox();
            comboBoxOnFr = new ComboBox();
            comboBoxOnTh = new ComboBox();
            textBox1 = new TextBox();
            comboBoxOnWe = new ComboBox();
            comboBoxOnTu = new ComboBox();
            comboBoxOnMo = new ComboBox();
            comboBoxOffSu = new ComboBox();
            comboBoxOffSa = new ComboBox();
            SaveSettings = new Button();
            comboBoxOffFr = new ComboBox();
            comboBoxOffTh = new ComboBox();
            comboBoxOffWe = new ComboBox();
            comboBoxOffTu = new ComboBox();
            comboBoxOffMo = new ComboBox();
            textBox14 = new TextBox();
            textBox13 = new TextBox();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            BtnUpdate = new Button();
            panelMenu.SuspendLayout();
            panelAbout.SuspendLayout();
            panelSettings.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(7, 285);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Default";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(Main);
            panelMenu.Controls.Add(Settings);
            panelMenu.Controls.Add(About);
            panelMenu.Location = new Point(7, 9);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(198, 224);
            panelMenu.TabIndex = 6;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // Main
            // 
            Main.AutoSize = true;
            Main.LinkColor = Color.Blue;
            Main.Location = new Point(3, 6);
            Main.Name = "Main";
            Main.Size = new Size(51, 15);
            Main.TabIndex = 2;
            Main.TabStop = true;
            Main.Text = "Главная";
            Main.LinkClicked += OffOnLabel_LinkClicked;
            // 
            // Settings
            // 
            Settings.AutoSize = true;
            Settings.LinkColor = Color.Red;
            Settings.Location = new Point(-1, 177);
            Settings.Name = "Settings";
            Settings.Size = new Size(199, 15);
            Settings.TabIndex = 1;
            Settings.TabStop = true;
            Settings.Text = "Правила выкл учетки( разработка)";
            Settings.LinkClicked += About_LinkClicked;
            // 
            // About
            // 
            About.AutoSize = true;
            About.LinkColor = Color.Red;
            About.Location = new Point(0, 196);
            About.Name = "About";
            About.Size = new Size(150, 15);
            About.TabIndex = 0;
            About.TabStop = true;
            About.Text = "Настройки (В разработке)";
            About.LinkClicked += Settings_LinkClicked;
            // 
            // panelAbout
            // 
            panelAbout.Controls.Add(checkBox1);
            panelAbout.Location = new Point(665, 13);
            panelAbout.Name = "panelAbout";
            panelAbout.Size = new Size(200, 225);
            panelAbout.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(52, 82);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // OnButton
            // 
            OnButton.Location = new Point(83, 37);
            OnButton.Name = "OnButton";
            OnButton.Size = new Size(123, 70);
            OnButton.TabIndex = 0;
            OnButton.Text = "Применить";
            OnButton.UseVisualStyleBackColor = true;
            OnButton.Click += OnButton_Click;
            // 
            // panelSettings
            // 
            panelSettings.Controls.Add(OnButton);
            panelSettings.Controls.Add(comboBox1);
            panelSettings.Controls.Add(newPassAcc);
            panelSettings.Controls.Add(textBox2);
            panelSettings.Controls.Add(textBox4);
            panelSettings.Controls.Add(textBox3);
            panelSettings.Controls.Add(textTimeOn);
            panelSettings.Controls.Add(textTimeOff);
            panelSettings.Location = new Point(433, 12);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(226, 296);
            panelSettings.TabIndex = 7;
            panelSettings.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Выключение", "Гибернация", "Выход из учетной записи" });
            comboBox1.Location = new Point(85, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // newPassAcc
            // 
            newPassAcc.Location = new Point(4, 232);
            newPassAcc.Name = "newPassAcc";
            newPassAcc.Size = new Size(80, 23);
            newPassAcc.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 203);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(81, 23);
            textBox2.TabIndex = 9;
            textBox2.Text = "Нов.пароль";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(125, 203);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(81, 23);
            textBox4.TabIndex = 7;
            textBox4.Text = "Время вкл";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(15, 116);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(78, 23);
            textBox3.TabIndex = 6;
            textBox3.Text = "Время выкл.";
            // 
            // textTimeOn
            // 
            textTimeOn.Location = new Point(113, 254);
            textTimeOn.MaxLength = 5;
            textTimeOn.Name = "textTimeOn";
            textTimeOn.Size = new Size(80, 23);
            textTimeOn.TabIndex = 5;
            // 
            // textTimeOff
            // 
            textTimeOff.AccessibleRole = AccessibleRole.None;
            textTimeOff.Location = new Point(14, 145);
            textTimeOff.MaxLength = 5;
            textTimeOff.Name = "textTimeOff";
            textTimeOff.Size = new Size(79, 23);
            textTimeOff.TabIndex = 4;
            textTimeOff.TextChanged += textTimeOff_TextChanged;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(comboBoxOnSu);
            panelMain.Controls.Add(comboBoxOnSa);
            panelMain.Controls.Add(nameAccount);
            panelMain.Controls.Add(comboBoxOnFr);
            panelMain.Controls.Add(comboBoxOnTh);
            panelMain.Controls.Add(textBox1);
            panelMain.Controls.Add(comboBoxOnWe);
            panelMain.Controls.Add(comboBoxOnTu);
            panelMain.Controls.Add(comboBoxOnMo);
            panelMain.Controls.Add(comboBoxOffSu);
            panelMain.Controls.Add(comboBoxOffSa);
            panelMain.Controls.Add(SaveSettings);
            panelMain.Controls.Add(comboBoxOffFr);
            panelMain.Controls.Add(comboBoxOffTh);
            panelMain.Controls.Add(comboBoxOffWe);
            panelMain.Controls.Add(comboBoxOffTu);
            panelMain.Controls.Add(comboBoxOffMo);
            panelMain.Controls.Add(textBox14);
            panelMain.Controls.Add(textBox13);
            panelMain.Controls.Add(textBox12);
            panelMain.Controls.Add(textBox11);
            panelMain.Controls.Add(textBox10);
            panelMain.Controls.Add(textBox9);
            panelMain.Controls.Add(textBox8);
            panelMain.Controls.Add(textBox7);
            panelMain.Controls.Add(textBox6);
            panelMain.Controls.Add(textBox5);
            panelMain.Location = new Point(211, 9);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(194, 302);
            panelMain.TabIndex = 3;
            panelMain.Visible = false;
            // 
            // comboBoxOnSu
            // 
            comboBoxOnSu.AutoCompleteCustomSource.AddRange(new string[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOnSu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOnSu.FormattingEnabled = true;
            comboBoxOnSu.Items.AddRange(new object[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOnSu.Location = new Point(109, 206);
            comboBoxOnSu.Name = "comboBoxOnSu";
            comboBoxOnSu.Size = new Size(74, 23);
            comboBoxOnSu.TabIndex = 23;
            // 
            // comboBoxOnSa
            // 
            comboBoxOnSa.AutoCompleteCustomSource.AddRange(new string[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOnSa.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOnSa.FormattingEnabled = true;
            comboBoxOnSa.Items.AddRange(new object[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOnSa.Location = new Point(109, 177);
            comboBoxOnSa.Name = "comboBoxOnSa";
            comboBoxOnSa.Size = new Size(74, 23);
            comboBoxOnSa.TabIndex = 22;
            // 
            // nameAccount
            // 
            nameAccount.Location = new Point(86, 235);
            nameAccount.Name = "nameAccount";
            nameAccount.Size = new Size(76, 23);
            nameAccount.TabIndex = 10;
            // 
            // comboBoxOnFr
            // 
            comboBoxOnFr.AutoCompleteCustomSource.AddRange(new string[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOnFr.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOnFr.FormattingEnabled = true;
            comboBoxOnFr.Items.AddRange(new object[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOnFr.Location = new Point(109, 148);
            comboBoxOnFr.Name = "comboBoxOnFr";
            comboBoxOnFr.Size = new Size(74, 23);
            comboBoxOnFr.TabIndex = 21;
            // 
            // comboBoxOnTh
            // 
            comboBoxOnTh.AutoCompleteCustomSource.AddRange(new string[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOnTh.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOnTh.FormattingEnabled = true;
            comboBoxOnTh.Items.AddRange(new object[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOnTh.Location = new Point(109, 119);
            comboBoxOnTh.Name = "comboBoxOnTh";
            comboBoxOnTh.Size = new Size(74, 23);
            comboBoxOnTh.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 235);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(77, 23);
            textBox1.TabIndex = 8;
            textBox1.Text = "Имя учетки";
            // 
            // comboBoxOnWe
            // 
            comboBoxOnWe.AutoCompleteCustomSource.AddRange(new string[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOnWe.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOnWe.FormattingEnabled = true;
            comboBoxOnWe.Items.AddRange(new object[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOnWe.Location = new Point(109, 90);
            comboBoxOnWe.Name = "comboBoxOnWe";
            comboBoxOnWe.Size = new Size(74, 23);
            comboBoxOnWe.TabIndex = 19;
            // 
            // comboBoxOnTu
            // 
            comboBoxOnTu.AutoCompleteCustomSource.AddRange(new string[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOnTu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOnTu.FormattingEnabled = true;
            comboBoxOnTu.Items.AddRange(new object[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOnTu.Location = new Point(109, 61);
            comboBoxOnTu.Name = "comboBoxOnTu";
            comboBoxOnTu.Size = new Size(74, 23);
            comboBoxOnTu.TabIndex = 18;
            // 
            // comboBoxOnMo
            // 
            comboBoxOnMo.AutoCompleteCustomSource.AddRange(new string[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOnMo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOnMo.FormattingEnabled = true;
            comboBoxOnMo.Items.AddRange(new object[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOnMo.Location = new Point(109, 32);
            comboBoxOnMo.Name = "comboBoxOnMo";
            comboBoxOnMo.Size = new Size(74, 23);
            comboBoxOnMo.TabIndex = 17;
            // 
            // comboBoxOffSu
            // 
            comboBoxOffSu.AutoCompleteCustomSource.AddRange(new string[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOffSu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOffSu.FormattingEnabled = true;
            comboBoxOffSu.Items.AddRange(new object[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOffSu.Location = new Point(38, 206);
            comboBoxOffSu.Name = "comboBoxOffSu";
            comboBoxOffSu.Size = new Size(74, 23);
            comboBoxOffSu.TabIndex = 16;
            // 
            // comboBoxOffSa
            // 
            comboBoxOffSa.AutoCompleteCustomSource.AddRange(new string[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOffSa.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOffSa.FormattingEnabled = true;
            comboBoxOffSa.Items.AddRange(new object[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOffSa.Location = new Point(38, 177);
            comboBoxOffSa.Name = "comboBoxOffSa";
            comboBoxOffSa.Size = new Size(74, 23);
            comboBoxOffSa.TabIndex = 15;
            // 
            // SaveSettings
            // 
            SaveSettings.Location = new Point(3, 276);
            SaveSettings.Name = "SaveSettings";
            SaveSettings.Size = new Size(188, 23);
            SaveSettings.TabIndex = 3;
            SaveSettings.Text = "Сохранить и применить";
            SaveSettings.UseVisualStyleBackColor = true;
            SaveSettings.Click += SaveSettings_Click;
            // 
            // comboBoxOffFr
            // 
            comboBoxOffFr.AutoCompleteCustomSource.AddRange(new string[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOffFr.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOffFr.FormattingEnabled = true;
            comboBoxOffFr.Items.AddRange(new object[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOffFr.Location = new Point(38, 148);
            comboBoxOffFr.Name = "comboBoxOffFr";
            comboBoxOffFr.Size = new Size(74, 23);
            comboBoxOffFr.TabIndex = 14;
            // 
            // comboBoxOffTh
            // 
            comboBoxOffTh.AutoCompleteCustomSource.AddRange(new string[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOffTh.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOffTh.FormattingEnabled = true;
            comboBoxOffTh.Items.AddRange(new object[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOffTh.Location = new Point(38, 119);
            comboBoxOffTh.Name = "comboBoxOffTh";
            comboBoxOffTh.Size = new Size(74, 23);
            comboBoxOffTh.TabIndex = 13;
            // 
            // comboBoxOffWe
            // 
            comboBoxOffWe.AutoCompleteCustomSource.AddRange(new string[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOffWe.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOffWe.FormattingEnabled = true;
            comboBoxOffWe.Items.AddRange(new object[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOffWe.Location = new Point(38, 90);
            comboBoxOffWe.Name = "comboBoxOffWe";
            comboBoxOffWe.Size = new Size(74, 23);
            comboBoxOffWe.TabIndex = 12;
            // 
            // comboBoxOffTu
            // 
            comboBoxOffTu.AutoCompleteCustomSource.AddRange(new string[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOffTu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOffTu.FormattingEnabled = true;
            comboBoxOffTu.Items.AddRange(new object[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOffTu.Location = new Point(38, 61);
            comboBoxOffTu.Name = "comboBoxOffTu";
            comboBoxOffTu.Size = new Size(74, 23);
            comboBoxOffTu.TabIndex = 11;
            // 
            // comboBoxOffMo
            // 
            comboBoxOffMo.AutoCompleteCustomSource.AddRange(new string[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOffMo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOffMo.FormattingEnabled = true;
            comboBoxOffMo.Items.AddRange(new object[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxOffMo.Location = new Point(38, 32);
            comboBoxOffMo.Name = "comboBoxOffMo";
            comboBoxOffMo.Size = new Size(74, 23);
            comboBoxOffMo.TabIndex = 10;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(3, 206);
            textBox14.Name = "textBox14";
            textBox14.ReadOnly = true;
            textBox14.Size = new Size(38, 23);
            textBox14.TabIndex = 9;
            textBox14.Text = "Вс";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(3, 177);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(38, 23);
            textBox13.TabIndex = 8;
            textBox13.Text = "Сб";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(3, 148);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(38, 23);
            textBox12.TabIndex = 7;
            textBox12.Text = "Пт";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(3, 119);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(38, 23);
            textBox11.TabIndex = 6;
            textBox11.Text = "Чт";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(3, 90);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(38, 23);
            textBox10.TabIndex = 5;
            textBox10.Text = "Ср";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(3, 61);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(38, 23);
            textBox9.TabIndex = 4;
            textBox9.Text = "Вт";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(3, 32);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(38, 23);
            textBox8.TabIndex = 3;
            textBox8.Text = "Пн";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(109, 3);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(79, 23);
            textBox7.TabIndex = 2;
            textBox7.Text = "Конец";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(38, 3);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(74, 23);
            textBox6.TabIndex = 1;
            textBox6.Text = "Начало";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(3, 3);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(38, 23);
            textBox5.TabIndex = 0;
            textBox5.Text = "День";
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(88, 285);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(94, 23);
            BtnUpdate.TabIndex = 8;
            BtnUpdate.Text = "Обновление";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 326);
            Controls.Add(panelAbout);
            Controls.Add(BtnUpdate);
            Controls.Add(panelMenu);
            Controls.Add(panelMain);
            Controls.Add(panelSettings);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Control";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelAbout.ResumeLayout(false);
            panelAbout.PerformLayout();
            panelSettings.ResumeLayout(false);
            panelSettings.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panelMenu;
        private Panel panelSettings;
        private LinkLabel About;
        private LinkLabel Settings;
        private Panel panelMain;
        private Button SaveSettings;
        private LinkLabel Main;
        private Panel panelAbout;
        private Button OnButton;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textTimeOn;
        private TextBox textTimeOff;
        private TextBox textBox1;
        private TextBox newPassAcc;
        private TextBox nameAccount;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox14;
        private TextBox textBox13;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private ComboBox comboBoxOffMo;
        private ComboBox comboBoxOffSu;
        private ComboBox comboBoxOffSa;
        private ComboBox comboBoxOffFr;
        private ComboBox comboBoxOffTh;
        private ComboBox comboBoxOffWe;
        private ComboBox comboBoxOffTu;
        private ComboBox comboBoxOnSu;
        private ComboBox comboBoxOnSa;
        private ComboBox comboBoxOnFr;
        private ComboBox comboBoxOnTh;
        private ComboBox comboBoxOnWe;
        private ComboBox comboBoxOnTu;
        private ComboBox comboBoxOnMo;
        private Button BtnUpdate;
        private CheckBox checkBox1;
    }
}
