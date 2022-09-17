using System;
using System.IO;
using System.IO.Compression;
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
    public partial class Starter : Form
    {
        public Starter()
        {
            InitializeComponent();
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void BTNFaTorzs_CheckedChanged(object sender, EventArgs e)
        {
            if (BTNFaTorzs.Checked)
            {
                BTNFaLomb.Checked = true;
            }
            else
            {
                BTNFaLomb.Checked = false;
            }
        }

        private void BTNCreate_Click(object sender, EventArgs e)
        {
            string alma = "[Startup]" + Environment.NewLine;
            string[] beolvas = File.ReadAllLines("settings.szomoroggyameg");
            if (BTNFaLomb.Checked == true)
            {
                alma += "foliage.UseOcclusionType=0" + Environment.NewLine;
            }
            if (BTNFaTorzs.Checked == true)
            {
                alma += "foliage.CullAll=1" + Environment.NewLine;
            }
            alma += "ShowFlag.Fog=1" + Environment.NewLine;
            if (BTNPlayerEffect.Checked == true)
            {
                alma += "ShowFlag.Materials=0" + Environment.NewLine;
            }
            if (BTNArnyek.Checked == true)
            {
                alma += "ShowFlag.LevelColoration=0" + Environment.NewLine + "ShowFlag.LightComplexity=0" + Environment.NewLine + "ShowFlag.LightInfluences=0" + Environment.NewLine + "ShowFlag.LightMapDensity=0" + Environment.NewLine + "ShowFlag.LightRadius=0" + Environment.NewLine + "ShowFlag.LightShafts=0" + Environment.NewLine + "ShowFlag.PreviewShadowsIndicator=0" + Environment.NewLine;
            }
            if (BTNNonPlayerEffect.Checked == true)
            {
                alma += "ShowFlag.GameplayDebug=0" + Environment.NewLine;
            }
            if (BTNKod.Checked == true)
            {
                alma += "ShowFlag.DynamicShadows=1" + Environment.NewLine;
            }
            if (BTNMaxFPS.Checked == true)
            {
                alma += "t.maxfps=" + NUMInputMaxFps.Value + Environment.NewLine;
            }
            string path = beolvas[1] + @"\Engine\Config\ConsoleVariables.ini";
            File.WriteAllText(path, alma);
            
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            clicker clicker = new clicker();
            clicker.Show();
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            string[] beolvas = File.ReadAllLines("settings.szomoroggyameg");
            string path = beolvas[1] + @"\ShooterGame\Saved\LocalProfiles\PlayerLocalData.arkprofile";
            if (File.Exists(path))
            {
                File.Delete(path);
                File.Copy("PlayerLocalData.arkprofile", path);

            }
            else
            {
                File.Copy("PlayerLocalData.arkprofile", path);
            }
            
        }

        private void BTNCharacterek_Click(object sender, EventArgs e)
        {
            string[] beolvas = File.ReadAllLines("settings.szomoroggyameg");
            string path = beolvas[1] + @"\ShooterGame\Content\Localization\Game\global";
            string[] files = new string[8] { "HandwritingDistanceField.uasset", "Roboto18.uasset", "Roboto51.uasset", "Roboto51SlateFont.uasset", "RobotoDistanceField.uasset", "SansationBold18.uasset", "ShooterGame.archive", "ShooterGame.locres" };

            for (int i = 0; i < files.Length; i++)
            {
                string from = "Chars/" + files[i];
                string to = path + @"\" + files[i];                
                if (Directory.Exists(path))
                {
                    if (!File.Exists(to))
                    {
                        File.Copy(from, to);
                    }
                }
                else
                {
                    Directory.CreateDirectory(path);
                    if (!File.Exists(to))
                    {
                        File.Copy(from, to);
                    }
                }
                                
                System.Threading.Thread.Sleep(10);
            }
            MessageBox.Show("Done! Use -culture=global at steam!");

        }
    }
}
