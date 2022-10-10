using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkTools3._0
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            if (File.Exists("settings.szomoroggyameg"))
            {
                string[] beolvas = File.ReadAllLines("settings.szomoroggyameg");
                TXTPath.Text = beolvas[1];
                TXTID.Text = beolvas[0];
            }            
        }

        private void BTNSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TXTPath.Text = diag.SelectedPath;
            }
            else
            {
                MessageBox.Show("You didn't selected the folder!");
            }
        }

        private void SteamIdConverter_Click(object sender, EventArgs e)
        {
            if (TXTSteamId.Text == null)
            {
                MessageBox.Show("No Steam Id Found, Its WIP!");
                return;
            }
            WebClient wc = new WebClient();
            string url = "https://steamid.io/lookup/" + TXTSteamId.Text;
            string html = wc.DownloadString(url);
            string[] split = html.Split('\n');
            string[] masiksplit = split[14].Split(',');
            string[] useridszar = masiksplit[2].Split(':');
            string[] userid = useridszar[2].Split(']');
            TXTID.Text = userid[0];
            /*
            MessageBox.Show(html);
            MessageBox.Show(split[14]);
            MessageBox.Show(masiksplit[2]);
            MessageBox.Show(useridszar[2]);
            MessageBox.Show("User id: " + userid[0]);
            */
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            if (File.Exists("settings.szomoroggyameg"))
            {
                bool kellekiirni = false;
                string[] beolvas = File.ReadAllLines("settings.szomoroggyameg");
                for (int i = 0; i < beolvas.Length; i++)
                {
                    //MessageBox.Show(beolvas[i]);
                }
                if (!beolvas[0].Contains(TXTID.Text))
                {
                    beolvas[0] = TXTID.Text;
                    kellekiirni = true;
                }
                if (!beolvas[1].Contains(TXTPath.Text))
                {
                    beolvas[1] = TXTPath.Text;
                    kellekiirni = true;
                }
                if (kellekiirni)
                {
                    File.WriteAllLines("settings.szomoroggyameg", beolvas);
                }
                
            }
            else
            {
                string[] kiir = new string[2] { TXTID.Text, TXTPath.Text};
                File.WriteAllLines("settings.szomoroggyameg", kiir);
            }
        }
    }
}
