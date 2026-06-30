using System.Diagnostics;
using System.DirectoryServices;
using System.Net;
using System.Reflection;



namespace AppBaranov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBoxOffMo.Text = Settings1.Default.comboBoxOffMo;
            comboBoxOffTu.Text = Settings1.Default.comboBoxOffTu;
            comboBoxOffWe.Text = Settings1.Default.comboBoxOffWe;
            comboBoxOffTh.Text = Settings1.Default.comboBoxOffTh;
            comboBoxOffFr.Text = Settings1.Default.comboBoxOffFr;
            comboBoxOffSa.Text = Settings1.Default.comboBoxOffSa;
            comboBoxOffSu.Text = Settings1.Default.comboBoxOffSu;

            comboBoxOnMo.Text = Settings1.Default.comboBoxOnMo;
            comboBoxOnTu.Text = Settings1.Default.comboBoxOnTu;
            comboBoxOnWe.Text = Settings1.Default.comboBoxOnWe;
            comboBoxOnTh.Text = Settings1.Default.comboBoxOnTh;
            comboBoxOnFr.Text = Settings1.Default.comboBoxOnFr;
            comboBoxOnSa.Text = Settings1.Default.comboBoxOnSa;
            comboBoxOnSu.Text = Settings1.Default.comboBoxOnSu;


            nameAccount.Text = Settings1.Default.nameAccount;
           /* comboBox1.Text = Settings1.Default.ComboBoxSet;
            newPassAcc.Text = Settings1.Default.newPassAcc;
            textTimeOn.Text = Settings1.Default.textTimeOn;
            textTimeOff.Text = Settings1.Default.textTimeOff;
            this.textTimeOn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTimeOn_KeyPress);
            this.textTimeOff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTimeOff_KeyPress);*/
            panelAbout.Visible = false;
            panelSettings.Visible = false;
            panelMain.Visible = true;

            Updater();

        }
 
        private void CreateUsers()
        {
            string userName = NameNewAcc.Text;
            string password = PassNewAcc.Text;
            string groupName = "Администраторы"; // Например: "Guests" или "Administrators"

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                System.Windows.Forms.MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            
            try
            {
                // Подключение к локальной машине
                using (DirectoryEntry localMachine = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer"))
                {
                    // 1. Создание пользователя
                    using (DirectoryEntry newUser = localMachine.Children.Add(userName, "user"))
                    {
                        // Установка пароля и описания
                        newUser.Invoke("SetPassword", password);
                        newUser.Invoke("Put", new object[] { "Description", "Пользователь создан из C# WinForms" });
                        newUser.CommitChanges(); // Сохранение в системе
                    }

                    // 2. Поиск группы и добавление пользователя
                    using (DirectoryEntry groupEntry = localMachine.Children.Find(groupName, "group"))
                    {
                        // Формируем путь к пользователю (путь ADsPath)
                        string userPath = $"WinNT://{Environment.MachineName}/{userName},user";

                        // Добавление участника в группу
                        groupEntry.Invoke("Add", new object[] { userPath });
                        groupEntry.CommitChanges();
                    }
                }

                System.Windows.Forms.MessageBox.Show("Пользователь успешно создан и добавлен в группу!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Updater()
        {
            string addressversion = "https://raw.githubusercontent.com/civicml/ParentalControl/refs/heads/master/AppBaranov/version.txt";
            string currentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();


            WebClient client = new WebClient();
            string latestVersion = client.DownloadString(addressversion);

            if (latestVersion.Equals(currentVersion))
            {
                
            }
            else
            {

                string addressapp = "https://github.com/civicml/ParentalControl/releases/download/Test/AppBaranov.exe";

                System.Windows.Forms.MessageBox.Show("Доступна новая версия " + latestVersion + " на замену " + currentVersion);
                DialogResult result = System.Windows.Forms.MessageBox.Show(
                 "Хотите ли Вы скачать новую версию?",
                    "Подтверждение действия",
                    MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);

                // Проверяем, какую кнопку нажал пользователь
                if (result == DialogResult.Yes)
                {

                    System.Windows.Forms.MessageBox.Show("Програма зависнет на некоторое время, после окончания загрузки высветится окно. НУЖНО ПРОСТО ЖДАТЬ. Пользоваться компьютером можно :)");
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(addressapp, "AppBaranov(v." + latestVersion + ")" + ".exe");
                    System.Windows.Forms.MessageBox.Show("Файл скачан успешно, появился там же откуда запускалась программа.");
                }
                else if (result == DialogResult.No)
                {
                    // Код, если нажали "Нет"ds

                }



            }
        }



        private void DefaultSettingNetUsersTime()
        {
            string all = "all";
            ProcessStartInfo psi1 = new ProcessStartInfo("net", $"user {nameAccount.Text} /times:{all}")

            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            Process.Start(psi1);
        }

        private void BlockAccount()
        {
            string timesMo = null;
            string timesTu = null;
            string timesWe = null;
            string timesTh = null;
            string timesFr = null;
            string timesSa = null;
            string timesSu = null;
            //M,T,W,Th,Sa,Su
            if (string.IsNullOrEmpty(comboBoxOffMo.Text ?? comboBoxOnMo.Text))
            {

            }
            else
            {
                timesMo = "M," + comboBoxOffMo.Text + "-" + comboBoxOnMo.Text + ";";
            }
            if (string.IsNullOrEmpty(comboBoxOffTu.Text ?? comboBoxOnTu.Text))
            {

            }
            else
            {
                timesTu = "T," + comboBoxOffTu.Text + "-" + comboBoxOnTu.Text + ";";
            }
            if (string.IsNullOrEmpty(comboBoxOffWe.Text ?? comboBoxOnWe.Text))
            {

            }
            else
            {
                timesWe = "W," + comboBoxOffWe.Text + "-" + comboBoxOnWe.Text + ";";
            }
            if (string.IsNullOrEmpty(comboBoxOffTh.Text ?? comboBoxOnTh.Text))
            {

            }
            else
            {
                timesTh = "Th," + comboBoxOffTh.Text + "-" + comboBoxOnTh.Text + ";";
            }
            if (string.IsNullOrEmpty(comboBoxOffFr.Text ?? comboBoxOnFr.Text))
            {

            }
            else
            {
                timesFr = "F," + comboBoxOffFr.Text + "-" + comboBoxOnFr.Text + ";";
            }
            if (string.IsNullOrEmpty(comboBoxOffSa.Text ?? comboBoxOnSa.Text))
            {

            }
            else
            {
                timesSa = "S," + comboBoxOffSa.Text + "-" + comboBoxOnSa.Text + ";";
            }
            if (string.IsNullOrEmpty(comboBoxOffSu.Text ?? comboBoxOnSu.Text))
            {

            }
            else
            {
                timesSu = "Su," + comboBoxOffSu.Text + "-" + comboBoxOnSu.Text;
            }


            string times = timesMo + timesTu + timesWe + timesTh + timesFr + timesSa + timesSu;
            ProcessStartInfo psi = new ProcessStartInfo("net", $"user {nameAccount.Text} /times:{times}")

            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            Process.Start(psi);
        }


        private void button1_Click(object sender, EventArgs e)
        {

            DefaultSettingNetUsersTime();

        }


        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Settings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelSettings.Visible = false;
            panelMain.Visible = false;
            panelAbout.Visible = true;
           
           
        }

        private void About_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelAbout.Visible = false;
            panelSettings.Visible = true;
            panelMain.Visible = false;
           
        }

        private void OffOnLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelMain.Visible = true;
            panelSettings.Visible = false;
            panelAbout.Visible = false;
           
        }




        private void SaveSettings_Click(object sender, EventArgs e)
        {
            Settings1.Default.comboBoxOffMo = comboBoxOffMo.Text;
            Settings1.Default.comboBoxOffTu = comboBoxOffTu.Text;
            Settings1.Default.comboBoxOffWe = comboBoxOffWe.Text;
            Settings1.Default.comboBoxOffTh = comboBoxOffTh.Text;
            Settings1.Default.comboBoxOffFr = comboBoxOffFr.Text;
            Settings1.Default.comboBoxOffSa = comboBoxOffSa.Text;
            Settings1.Default.comboBoxOffSu = comboBoxOffSu.Text;

            Settings1.Default.comboBoxOnMo = comboBoxOnMo.Text;
            Settings1.Default.comboBoxOnTu = comboBoxOnTu.Text;
            Settings1.Default.comboBoxOnWe = comboBoxOnWe.Text;
            Settings1.Default.comboBoxOnTh = comboBoxOnTh.Text;
            Settings1.Default.comboBoxOnFr = comboBoxOnFr.Text;
            Settings1.Default.comboBoxOnSa = comboBoxOnSa.Text;
            Settings1.Default.comboBoxOnSu = comboBoxOnSu.Text;




            /*Settings1.Default.textTimeOn = textTimeOn.Text;
            Settings1.Default.textTimeOff = textTimeOff.Text;
            Settings1.Default.nameAccount = nameAccount.Text;
            Settings1.Default.newPassAcc = newPassAcc.Text;
            Settings1.Default.ComboBoxSet = comboBox1.Text;*/
            Settings1.Default.Save();
            System.Windows.Forms.MessageBox.Show("Настройки сохранены и применены к учетной записи " + nameAccount.Text);
            // Reestr();


            BlockAccount();

        }

        private async void OnButton_Click(object sender, EventArgs e)
        {

            /* // await System.Threading.Tasks.Task.Run(async() =>
              //{
                  while (true)
                  {

                      //парсер с ограничением вывода в 5 символов
                      var web = new HtmlWeb();
                      var doc = web.Load("https://time100.ru/Krasnodar");
                      var node = doc.DocumentNode.SelectSingleNode("//span[@class='time']");
                      int maxLength = 5;
                      //
                      string RealTime = node.InnerText; //вывод в стринговую переменну
                      string TimeInKrass = RealTime.Length <= maxLength ? RealTime : RealTime.Substring(0, maxLength); //вывод в стринговую переменную с ограничением


                      if (($"{TimeInKrass.ToString()}" == textTimeOff.Text.ToString()) && (comboBox1.Text == "Выход из учетной записи"))
                      {
                          try
                          {
                              ChangePass();
                              Process.Start("rundll32.exe", "user32.dll,LockWorkStation");
                              TaskOnCreate();
                          }
                          catch
                          {
                              MessageBox.Show("Учетная запись " + nameAccount.Text + " не найдена");

                          }

                      }
                      else if (($"{TimeInKrass.ToString()}" == textTimeOff.Text.ToString()) && (comboBox1.Text == "Выключение"))
                      {
                          try
                          {
                              ChangePass();
                              Process.Start("shutdown", "/s");
                              TaskOnCreate();
                          }
                          catch
                          {
                              MessageBox.Show("Учетная запись " + nameAccount.Text + " не найдена");

                          }
                      }
                      else if (($"{TimeInKrass.ToString()}" == textTimeOff.Text.ToString()) && (comboBox1.Text == "Гибернация"))
                      {
                          try
                          {
                              ChangePass();
                              Process.Start("shutdown", "/h");
                              TaskOnCreate();
                          }
                          catch
                          {
                              MessageBox.Show("Учетная запись " + nameAccount.Text + " не найдена");

                          }

                          if ($"{TimeInKrass.ToString()}" == textTimeOn.Text.ToString())
                          {
                              try
                              {
                                  TaskOnDelete();
                                  newPassAcc.Text = "";
                                  Settings1.Default.newPassAcc = newPassAcc.Text;
                                  Settings1.Default.Save();
                                  ChangePass();
                              }
                              catch
                              {
                                  MessageBox.Show("Учетная запись " + nameAccount.Text + " не найдена");

                              }

                          }

                      }

                      await System.Threading.Tasks.Task.Delay(15000);
                  }



              //}); */

        }

        private void textTimeOff_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateUsers();
        }
    }
}
