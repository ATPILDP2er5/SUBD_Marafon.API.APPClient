using Marofon.com.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL_ChekPass;
using Newtonsoft.Json;
using static Marofon.com.FormAvtorizate;
using System.Net.Http;
using DLLCheckMail;
namespace Marofon.com
{
    public partial class Regestration : Form
    {
        bool s = true;
        bool bb = false;
        char cNet;
        static public string uri = "http://localhost:60776/api/data/";
        public string Info;
        public HttpClient client = new HttpClient();
        Color err;
        int etap = 0;
        int StartX;

        public class USER_Zritel
        {
            public string Login { get; set; }
            public string Password { get; set; }
            public int Type { get; set; }
            public string Fam { get; set; }
            public string Name { get; set; }
            public string Otch { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
        }
        public USER_Zritel User = new USER_Zritel();
        public Regestration()
        {
            InitializeComponent();
            cNet = textBox1.PasswordChar;
            textBox1.PasswordChar = '*';
            But_Next.Enabled = false;
            err = But_Next.BackColor;
            But_Next.BackColor = panel1.BackColor;
            gBox_Sport.Location = new System.Drawing.Point(gBox_LData.Location.X, gBox_LData.Location.Y);
            gBox_Vizitor.Location = new System.Drawing.Point(gBox_LData.Location.X, gBox_LData.Location.Y);
            StartX = gBox_Reg.Location.X;
            button1.Visible = false;
        }

        private void pBoxVizitor_Click(object sender, EventArgs e)
        {
            if (s)
            {
                s = false;
                tBox_Pass.PasswordChar = cNet;
                textBox1.PasswordChar = cNet;
                pBoxVizitor.Image = Resources.Видит;
            }
            else
            {
                s = true;
                tBox_Pass.PasswordChar = '*';
                textBox1.PasswordChar = '*';
                pBoxVizitor.Image = Resources.Невидит;
            }
        }

        private void tBox_Pass_TextChanged(object sender, EventArgs e)
        {
            CheckList checkList = new CheckList();
            checkList = ChekcPass.Check(tBox_Pass.Text);
            if (checkList.a)
                label7.ForeColor = Color.Green;
            else
                label7.ForeColor = Color.Red;
            if (checkList.b)
                label6.ForeColor = Color.Green;
            else
                label6.ForeColor = Color.Red;
            if (checkList.c)
                label8.ForeColor = Color.Green;
            else
                label8.ForeColor = Color.Red;
            if (checkList.d)
                label9.ForeColor = Color.Green;
            else
                label9.ForeColor = Color.Red;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == tBox_Pass.Text)
                bb = true;
            else
                bb = false;
        }

        private void but_Check_Click(object sender, EventArgs e)
        {
            if (label7.ForeColor ==  Color.Green && label6.ForeColor == Color.Green && label8.ForeColor == Color.Green && label9.ForeColor == Color.Green && bb )
            {
                User.Login = tBox_Login.Text;
                User.Email = tBox_e_mail.Text;
                User.Password = tBox_Pass.Text;
                User.Phone = tBox_NumbrPhone.Text;
                User.Otch = tBox_otch.Text;
                User.Name = tBox_Ima.Text;
                User.Fam = tBox_fam.Text;
                User.Type = 2;
                string txt = JsonConvert.SerializeObject(User);
                var content = new StringContent(txt, Encoding.UTF8, "application/json");
                string zapros = "EstChel";
                var respone = client.PostAsync(uri + zapros, content);
                if (respone.Result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Такой пользователь уже есть", "Проверка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    But_Next.Enabled = true;
                    But_Next.BackColor = err;
                }
            }
            
        }

        private void But_Next_Click(object sender, EventArgs e)
        {
            if(etap == 2)
            {
           
                string txt = JsonConvert.SerializeObject(User);
                var content = new StringContent(txt, Encoding.UTF8, "application/json");
                string zapros = "register";
                var respone = client.PostAsync(uri + zapros, content);
                if (respone.Result.StatusCode == System.Net.HttpStatusCode.OK)
                    DialogResult = DialogResult.OK;
            }
            else 
            {
                timer1.Start();
            }
        }
            


        private void button1_Click(object sender, EventArgs e)
        {
            if(etap == 0)
                DialogResult = DialogResult.Cancel;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (etap == 0)
            {
                while (gBox_LData.Location.X >= StartX)
                {
                    gBox_LData.Location = new Point(gBox_LData.Location.X - 5, gBox_LData.Location.Y);
                    gBox_Reg.Location = new Point(gBox_Reg.Location.X - 5, gBox_Reg.Location.Y);
                }
                    
                    etap++;
                    timer1.Stop();
            }
            else if (etap == 1)
            {
                if (cBox_Kto.SelectedIndex == 0)
                {
                    while (gBox_Sport.Location.X >= StartX)
                    {
                        gBox_Sport.Location = new Point(gBox_LData.Location.X - 5, gBox_LData.Location.Y);
                        gBox_LData.Location = new Point(gBox_Reg.Location.X - 5, gBox_Reg.Location.Y);
                    }
                    
                    {
                        etap++;
                        timer1.Stop(); 
                    }
                }
                else if (cBox_Kto.SelectedIndex == 1)
                {
                    while (gBox_Vizitor.Location.X >= StartX)
                    {
                        gBox_Vizitor.Location = new Point(gBox_LData.Location.X - 5, gBox_LData.Location.Y);
                        gBox_LData.Location = new Point(gBox_Reg.Location.X - 5, gBox_Reg.Location.Y);
                    }
                   
                    { 
                        etap++;
                        timer1.Stop(); 
                    }
                }
                else timer1.Stop();
            }
            else { timer1.Stop(); }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (etap == 2)
            {
                if (cBox_Kto.SelectedIndex == 0)
                {
                    while (gBox_LData.Location.X <= StartX)
                    {
                        gBox_LData.Location = new Point(gBox_LData.Location.X + 5, gBox_LData.Location.Y);
                        gBox_Sport.Location = new Point(gBox_Reg.Location.X + 5, gBox_Reg.Location.Y);
                    }
                    {
                        etap++;
                        timer1.Stop();
                    }
                }
                else if (cBox_Kto.SelectedIndex == 1)
                {
                    if (gBox_Vizitor.Location.X <= StartX)
                    {
                        gBox_Vizitor.Location = new Point(gBox_LData.Location.X - 5, gBox_LData.Location.Y);
                        gBox_LData.Location = new Point(gBox_Reg.Location.X - 5, gBox_Reg.Location.Y);
                    }
                    {
                        etap++;
                        timer1.Stop();
                    }
                }
                else timer1.Stop();
            }
            else if (etap == 1)
            {
                while (gBox_Reg.Location.X <= StartX)
                {
                    gBox_Reg.Location = new Point(gBox_LData.Location.X + 5, gBox_LData.Location.Y);
                    gBox_LData.Location = new Point(gBox_Reg.Location.X + 5, gBox_Reg.Location.Y);
                }
                    etap++;
                timer1.Stop();
            }
            else { timer1.Stop(); }
        }
    }
}
