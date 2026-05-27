using AutoUpdaterDotNET;
using HtmlAgilityPack;
using Microsoft.Win32;
using Microsoft.Win32.TaskScheduler;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;



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
            comboBox1.Text = Settings1.Default.ComboBoxSet;
            newPassAcc.Text = Settings1.Default.newPassAcc;
            textTimeOn.Text = Settings1.Default.textTimeOn;
            textTimeOff.Text = Settings1.Default.textTimeOff;
            this.textTimeOn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTimeOn_KeyPress);
            this.textTimeOff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTimeOff_KeyPress);
            panelMain.Visible = false;
            panelSettings.Visible = false;
            panelAbout.Visible = true;
            panelMenu.Visible = false;
        }
        private void textTimeOn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем: цифры (char.IsDigit),
            // двоеточие (e.KeyChar == ':'),
            // и управляющие клавиши (Backspace, Delete, стрелки) (char.IsControl)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ':' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Запрещаем ввод символа
            }
        }
        private void textTimeOff_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем: цифры (char.IsDigit),
            // двоеточие (e.KeyChar == ':'),
            // и управляющие клавиши (Backspace, Delete, стрелки) (char.IsControl)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ':' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Запрещаем ввод символа
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ChangePass()
        {


            DirectoryEntry user = new DirectoryEntry("WinNT://./" + nameAccount.Text + ",user");
            // Вызываем метод SetPassword
            user.Invoke("SetPassword", new object[] { newPassAcc.Text });
            user.CommitChanges();


        }

        private void TaskOnCreate()
        {
            string textTimeOnString = textTimeOn.Text;
            string format = "HH:mm";
            DateTime textTimeOnParse = DateTime.ParseExact(textTimeOnString, format, System.Globalization.CultureInfo.InvariantCulture);
            // 1. Подключение к планировщику задач
            using (TaskService ts = new TaskService())
            {
                // 2. Создание новой задачи
                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = "Включение пк в определенное время";

                // 3. Установка времени (например, берется из textTimeOn)
                DailyTrigger dt = new DailyTrigger { StartBoundary = textTimeOnParse };
                td.Triggers.Add(dt);

                // 4. Действие: запуск программы (можно создать пустой .bat файл, если цель - только пробуждение)
                td.Actions.Add(new ExecAction("cmd.exe", "/c echo wake", null));

                // 5. ВАЖНО: Разрешить пробуждение компьютера
                td.Settings.WakeToRun = true;
                td.Settings.DisallowStartIfOnBatteries = false;
                td.Settings.StopIfGoingOnBatteries = false;

                // 6. Регистрация задачи
                ts.RootFolder.RegisterTaskDefinition("WakeUpTask", td);
            }
        }

        private void TaskOnDelete()
        {
            using (TaskService ts = new TaskService())
            {
                // Удаление задачи по имени из корневой папки
                ts.RootFolder.DeleteTask("WakeUpTask", false);
            }
        }

        private void Updater()
        {
            string addressversion = "https://raw.githubusercontent.com/civicml/ParentalControl/refs/heads/master/AppBaranov/version.txt";
            string currentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();


            WebClient client = new WebClient();
            string latestVersion = client.DownloadString(addressversion);

            if (latestVersion.Equals(currentVersion))
            {
                System.Windows.Forms.MessageBox.Show("Ваша версия последняя, а именно " + currentVersion);
            }
            else
            {

                string addressapp = "https://github.com/civicml/ParentalControl/releases/download/Test/AppBaranov.exe";
                System.Windows.Forms.MessageBox.Show("Доступна новая версия " + latestVersion + " на замену " + currentVersion);
                DialogResult result = System.Windows.Forms.MessageBox.Show(
                 "Вы уверены, что хотите скачать новую версию?",
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
            //M,T,W,Th,Sa,Su
            string timesMo = "M," + comboBoxOffMo.Text + "-" + comboBoxOnMo.Text;
            string timesTu = "T," + comboBoxOffTu.Text + "-" + comboBoxOnTu.Text;
            string timesWe = "W," + comboBoxOffWe.Text + "-" + comboBoxOnWe.Text;
            string timesTh = "Th," + comboBoxOffTh.Text + "-" + comboBoxOnTh.Text;
            string timesFr = "F," + comboBoxOffFr.Text + "-" + comboBoxOnFr.Text;
            string timesSa = "S," + comboBoxOffSa.Text + "-" + comboBoxOnSa.Text;
            string timesSu = "Su," + comboBoxOffSu.Text + "-" + comboBoxOnSu.Text;

            string times = timesMo + ";" + timesTu + ";" + timesWe + ";" + timesTh
                + ";" + timesFr + ";" + timesSa + ";" + timesSu;
            ProcessStartInfo psi = new ProcessStartInfo("net", $"user {nameAccount.Text} /times:{times}")

            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            Process.Start(psi);
        }
        /* static void Reestr()
         {
             try
             {
                 // Указываем путь к разделу (без HKCU, так как используем Registry.CurrentUser)
                 string keyPath = @"Software\Microsoft\Windows\CurrentVersion\Policies\System";

                 // Создаем или открываем раздел для записи
                 using (RegistryKey key = Registry.CurrentUser.CreateSubKey(keyPath))
                 {
                     if (key != null)
                     {
                         // Устанавливаем значение LogonHoursAction (1 = Lock)
                         // RegistryValueKind.DWord соответствует ключу /t REG_DWORD
                         key.SetValue("LogonHoursAction", 1, RegistryValueKind.DWord);

                         Console.WriteLine("Параметр успешно добавлен в реестр.");
                     }
                 }
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Ошибка при записи в реестр: {ex.Message}");
             }
         }*/


        private void button1_Click(object sender, EventArgs e)
        {

            DefaultSettingNetUsersTime();



        }


        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Settings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*Settings.LinkClicked += (sender, e) =>
            {
                panelMain.Visible = false;
                panelAbout.Visible = false;
                panelSettings.Visible = true;

            };*/


        }

        private void About_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            About.LinkClicked += (sender, e) =>
            {
                panelMain.Visible = false;
                panelSettings.Visible = false;
                panelAbout.Visible = true;

            };
        }

        private void OffOnLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*Main.LinkClicked += (sender, e) =>
            {
                panelAbout.Visible = false;
                panelSettings.Visible = false;
                panelMain.Visible = true;

            };*/
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




            Settings1.Default.textTimeOn = textTimeOn.Text;
            Settings1.Default.textTimeOff = textTimeOff.Text;
            Settings1.Default.nameAccount = nameAccount.Text;
            Settings1.Default.newPassAcc = newPassAcc.Text;
            Settings1.Default.ComboBoxSet = comboBox1.Text;
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Updater();
        }
    }
}
