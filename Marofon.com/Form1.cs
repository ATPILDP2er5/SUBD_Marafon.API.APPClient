using Marofon.com.Properties;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marofon.com
{
    public partial class FormAvtorizate : Form
    {
        bool Closea = true;
        static public string sait_Api;
        static public string uri ;
        public HttpClient client = new HttpClient();
        public string ClientInfo;
        int popitcka = 0;


        public FormAvtorizate()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            popitcka++;
            if(popitcka == 7)
            {
                SIsmenenie sIsmenenie = new SIsmenenie();
                if(sIsmenenie.ShowDialog() == DialogResult.Yes)
                {
                    RegistryKey Key = new Registry.CurrentUser.CreateSubKey("SOFTWARE\\Iscluchenie.Marafon.Api.AppClient");
                    Key.SetValue("Iscluchenie.Marafon.Api.AppClient", sIsmenenie.textBox1);
                }
            }
        }
        char cNet;
        bool s = true;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (s)
            {
                s = false;
                tBox_Pass.PasswordChar = cNet;
                pBoxVizitor.Image = Resources.Видит;
            }
            else
            {
                s = true;
                tBox_Pass.PasswordChar = '*';
                pBoxVizitor.Image = Resources.Невидит;
            }

        }

        private void FormAvtorizate_Load(object sender, EventArgs e)
        {
            RegistryKey Key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Iscluchenie.Marafon.Api.AppClient");
            if(Key != null)
            {
                sait_Api = Key.GetValue("uriNew").ToString();
            }
            else
            {
                sait_Api = "http://localhost:60776";     
            }
            uri = sait_Api + "/api/";
            cNet = tBox_Pass.PasswordChar;
            tBox_Pass.PasswordChar = '*';
        }

        private async void But_Next_Click(object sender, EventArgs e)
        {
            But_Next.Enabled = false;
            REQUEST qwerty = new REQUEST();
            qwerty.Password = tBox_Pass.Text;
            qwerty.Login = tBox_Login.Text;
            string txt = JsonConvert.SerializeObject(qwerty);
            var content = new StringContent(txt, Encoding.UTF8, "application/json");
            string zapros = "data/getdata";
            try
            {var respone = await client.PostAsync(uri + "/" + zapros, content);
            ClientInfo = respone.StatusCode.ToString();
            if (ClientInfo == "OK")
            {
                Closea = false;
                string jsonRes = await respone.Content.ReadAsStringAsync();
                userLogin = JsonConvert.DeserializeObject<datacert.LoginUser>(jsonRes);
                Close();
                if (userLogin.UserType == 1)
                {
                    Sportsmeni sportsmeni = new Sportsmeni(userLogin);
                    sportsmeni.BackColor = BackColor;
                    sportsmeni.ShowDialog();
                    Closea = true;

                }
                else
                {
                    Zriteli zriteli = new Zriteli(userLogin);
                    zriteli.BackColor = BackColor;
                    zriteli.ShowDialog();
                    Closea = true;
                }
                Show();

            }
            else
            {
                MessageBox.Show("Проблемы с сетью, повторите попытку позже.", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                But_Next.Enabled = true; }
            catch
            {
                string Predpologaiy = "";
                if (await CheckICG())
                    Predpologaiy = "API сервер был отключен либо не доступен";
                else
                    Predpologaiy = "Возможно у вас нет подключения к глобальной сети / Возможно стоит межсетевой экран";
                MessageBox.Show($"Возникла ошибка подключения. Возможная причина: {Predpologaiy}", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public datacert.LoginUser userLogin = new datacert.LoginUser();


        public class REQUEST
        {
            public string Login { get; set; }
            public string Password { get; set; }
        }

        private void FormAvtorizate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Closea)
                e.Cancel = false;
            else
            {
                e.Cancel = true;
                this.Hide();
            }

        }

        private void link_Redactor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Regestration sport = new Regestration();
            sport.BackColor = BackColor; sport.Text = Text;
            Hide();
            if (sport.ShowDialog() == DialogResult.OK)
            {
                tBox_Login = sport.tBox_Login;
                tBox_Pass = sport.tBox_Pass;
            }
            else
            {

            }
            Show();
        }

public async Task<bool> CheckICG()
    {
        try
        {
            using (var client = new HttpClient())
            {
                // Установка таймаута на случай, если сервер недоступен
                client.Timeout = TimeSpan.FromSeconds(5);

                // Проверка подключения по надежному адресу
                var response = await client.GetAsync("https://www.google.com");

                // Вернуть true, если статус успешный (код 200)
                return response.IsSuccessStatusCode;
            }
        }
        catch
        {
            // Вернуть false, если возникло исключение
            return false;
        }
    }
}
}
