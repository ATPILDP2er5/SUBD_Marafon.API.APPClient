using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Marofon.com.Zriteli;

namespace Marofon.com
{

    public partial class Sportsmeni : Form
    {
        public string i_Sportsmen;
        private datacert.LoginUser userYY;
        public string uri;
        HttpClient client = new HttpClient();

        public Sportsmeni(datacert.LoginUser user)
        {
            userYY = user;
            InitializeComponent();
            i_Sportsmen = $@"Информация о спортсмене

ФИО спортсмена: {user.fam} {user.name} {user.otch}

Год рождения: {user.bday.GetDateTimeFormats('d')[0]}";
            label_Who.Text = i_Sportsmen;
        }

        private void Sportsmeni_Load(object sender, EventArgs e)
        {
            ShowAll();
        }
        async void ShowAll()
        {
            dGV_Marafon.Rows.Clear();
            var con = await client.GetAsync(uri + "/athletes/" + userYY.UID);
            string sorce = await con.Content.ReadAsStringAsync();
            Uchastiewq = JsonConvert.DeserializeObject<int[]>(sorce);
            dGV_Marafon.Rows.Clear();
            con = await client.GetAsync(uri + "/marathons");
            sorce = await con.Content.ReadAsStringAsync();
            Marafonser = JsonConvert.DeserializeObject<List<Marafonsum>>(sorce);

            foreach (Marafonsum agent in Marafonser)
            {
                string ya;
                if (Uchastiewq.Any(u => u == agent.UID))
                    ya = "Да";
                else
                    ya = "Нет";
                dGV_Marafon.Rows.Add(agent.UID, agent.NAME, agent.DLINA, agent.DATE_START.GetDateTimeFormats('d')[0], agent.VZNOS, ya);
            }
        }
        List<Marafonsum> Marafonser = new List<Marafonsum>();
        public class Marafonsum
        {
            public int UID { get; set; }
            public string NAME { get; set; }
            public float DLINA { get; set; }
            public DateTime DATE_START { get; set; }
            public float VZNOS { get; set; }
        }



        public static int[] Uchastiewq { get; set; }

        private void dGV_Marafon_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGV_Marafon.CurrentRow.Cells[5].Value == "Да")
            {
                if (MessageBox.Show("Вы уже записаны на этот марафон. Желаете отписаться от участия?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DellitMe(userYY.UID, Convert.ToInt32(dGV_Marafon.CurrentRow.Cells[0].Value));
                }
            }
            else
            {
                if (MessageBox.Show("Вы не записаны на этот марафон. Желаете Подписаться на участие в нем?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ConnectMe(userYY.UID, Convert.ToInt32(dGV_Marafon.CurrentRow.Cells[0].Value));
                }
            }
        }
        async void DellitMe(int meID, int MID)
        {
            Otpravka otpravka = new Otpravka();
            otpravka.MarathonId = MID;
            otpravka.AthleteId = meID;
            string txt = JsonConvert.SerializeObject(otpravka);
            var content = new StringContent(txt, Encoding.UTF8, "application/json");
            var respone = await client.PostAsync(uri + "/athletes/unregisterM", content);
            respone.StatusCode.ToString();
            ShowAll();

        }
        async void ConnectMe(int meID, int MID)
        {
            Otpravka otpravka = new Otpravka();
            otpravka.MarathonId = MID;
            otpravka.AthleteId = meID;
            string txt = JsonConvert.SerializeObject(otpravka);
            var content = new StringContent(txt, Encoding.UTF8, "application/json");
            var respone = await client.PostAsync(uri + "/athletes/registerM", content);
            respone.StatusCode.ToString();
            ShowAll();
        }

        public class Otpravka
        {
            public int MarathonId { get; set; }
            public int AthleteId { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAll();
        }
    }
}
