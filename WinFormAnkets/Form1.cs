using System;
using System.Text.Json;

namespace WinFormAnkets
{

    public partial class Form1 : Form
    {
        List<Anket> ankets = new List<Anket>();
        JsonSerializerOptions options = new JsonSerializerOptions();

        public Form1()
        {
            InitializeComponent();
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            if (SearchTb.Text != "")
            {
                Anket anket = new Anket(SearchTb.Text, AdTb.Text, SoyadTb.Text, EmailTb.Text, TelTb.Text, DogumTb.Text);
                ankets.Add(anket);

                string jsonstr = JsonSerializer.Serialize(ankets, options);
                File.WriteAllText("../../../ankett.json", jsonstr);
                listBox.Items.Add(SearchTb.Text);
                SearchTb.Text = default;
                AdTb.Text = default;
                SoyadTb.Text = default;
                EmailTb.Text = default;
                TelTb.Text = default;
                DogumTb.Text = default;

            }
            else
            {
                MessageBox.Show("Zehmet olmasa Failin adini qeyd edin");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            options.WriteIndented = true;
            string jsonAnket = File.ReadAllText("../../../ankett.json");
            ankets = JsonSerializer.Deserialize<List<Anket>>(jsonAnket);
            foreach (var item in ankets)
            {
                listBox.Items.Add(item.FailName);
            }
        }

        private void LoadBt_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (var item in ankets)
            {

                if (item.FailName == SearchTb.Text)
                {
                    count++;
                    AdTb.Text = item.Ad;
                    SoyadTb.Text = item.Soyad;
                    EmailTb.Text = item.Email;
                    TelTb.Text = item.Tel;
                    DogumTb.Text = item.Dogumili;
                    Deyismek.Visible = true;

                }
            }
            if (count == 0)
            {
                MessageBox.Show("Ele notepad yoxdur");
            }
        }



        private void YuklemekBt_Click(object sender, EventArgs e)
        {
            foreach (var item in ankets)
            {

                if (item.FailName == SearchTb.Text)
                {

                    item.Ad = AdTb.Text;
                    item.Soyad = SoyadTb.Text;
                    item.Email = EmailTb.Text;
                    item.Tel = TelTb.Text;
                    item.Dogumili = DogumTb.Text;


                }
            }
            YuklemekBt.Visible = false;
            SearchTb.Text = default;
            AdTb.Text = default;
            SoyadTb.Text = default;
            EmailTb.Text = default;
            TelTb.Text = default;
            DogumTb.Text = default;

        }

        private void Deyismek_Click_1(object sender, EventArgs e)
        {
            Deyismek.Visible = false;
            YuklemekBt.Visible = true;
        }


    }
}