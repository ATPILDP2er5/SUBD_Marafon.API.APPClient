using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marofon.com
{
    public partial class Zriteli : Form
    {

        string i_Zritel;
        public string uri;
        HttpClient client = new HttpClient();
        public List<Marafons> Marafonser;
        public Zriteli(datacert.LoginUser user)
        {

            InitializeComponent();
            i_Zritel = $@"Информация о зрителе

ФИО зрителя: {user.fam} {user.name} {user.otch}

Контактная информация
e-mail: {user.e_mail}
Номер телефона: {Convert.ToString(user.number_phone)}";
            label_Who.Text = i_Zritel;


        }
        async void ShowAll()
        {
            dGV_Marafon.Rows.Clear();
            var con = await client.GetAsync(uri + "spectators/marathons");
            string sorce = await con.Content.ReadAsStringAsync();
            try
            { Marafonser = JsonConvert.DeserializeObject<List<Marafons>>(sorce); }
            catch
            {
                MessageBox.Show("Проблемы с сетью!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
            }
            foreach (Marafons agent in Marafonser)
            {
                dGV_Marafon.Rows.Add(agent.UID, agent.NAME, agent.DLINA, agent.DATE_START, agent.VZNOS);
            }
        }
        async void ShowAllU(int UID)
        {
            foreach (Marafons agent1 in Marafonser)
            {
                if (agent1.UID == UID)
                {

                    label_Who.Text = $@"Информация о Марафоне

Название марафона: {agent1.NAME}

Взнос за участие: {agent1.VZNOS}";
                    if (agent1.Athletes != null)
                    {
                        foreach (Athlete sPORTMENS in agent1.Athletes)
                        {
                            string f;
                            if (sPORTMENS.pol)
                            { f = "Женский"; }
                            else
                            {
                                f = "Мужской";
                            }
                            dGV_Uchastniki.Rows.Add(sPORTMENS.fam, sPORTMENS.name, sPORTMENS.otch, f, sPORTMENS.bday, sPORTMENS.strana);
                        }
                    }
                    break;
                }
            }
        }
        public class Marafons
        {
            public int UID { get; set; }
            public string NAME { get; set; }
            public float DLINA { get; set; }
            public DateTime DATE_START { get; set; }
            public float VZNOS { get; set; }
            public Athlete[] Athletes { get; set; }
        }





        private void dGV_Marafon_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dGV_Uchastniki.Rows.Clear();
            int uid = Convert.ToInt32(dGV_Marafon.CurrentRow.Cells[0].Value);
            button1.Visible = false;
            dGV_Marafon.Visible = false;
            dGV_Uchastniki.Visible = true;
            StepAhed.Visible = true;
            ShowAllU(uid);

        }

        private void StepAhed_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            label_Who.Text = i_Zritel;
            StepAhed.Visible = false;
            dGV_Marafon.Visible = true;
            dGV_Uchastniki.Visible = false;
        }

        private void Zriteli_Load(object sender, EventArgs e)
        {
            ShowAll();
            dGV_Uchastniki.Visible = false;
        }

        private void Zriteli_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public class Athlete
        {
            public string fam { get; set; }
            public string name { get; set; }
            public string otch { get; set; }
            public bool pol { get; set; }
            public DateTime bday { get; set; }
            public string strana { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAll();
        }
    }
}
