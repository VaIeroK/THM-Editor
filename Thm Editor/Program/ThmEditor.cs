using System;
using System.Windows.Forms;
using DDSReader;
using Pfim;
using System.IO;
using System.Text.RegularExpressions;

namespace ThmEditor
{
    public partial class ThmEditor : Form
    {
        private THM thm;
        private DDSImage dds_img;
        public string FILE_NAME = null;
        string number_mask = "";
        bool bKeyIsDown = false;
        object button_tag = null;

        public ThmEditor()
        {
            InitializeComponent();
            OpenFileThmDialog.Filter = SaveAsFileThmDialog.Filter = "THM file|*.thm";
            OpenFileDDSDialog.Filter = OpenFileDDSMapDialog.Filter = OpenFileGenerateTHMDialog.Filter = "DDS texture|*.dds";

            thm = new THM(this);
            thm.ResetValues();
            Form_Update();

            number_mask = @"^[0-9.]*$";
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            // Very dirty hack
            if (Environment.GetCommandLineArgs().Length > 1)
            {
                FILE_NAME = Environment.GetCommandLineArgs()[1];
                thm.Load(FILE_NAME);
            }
        }

        public void Form_Update()
        {
            comboBox1.SelectedIndex = (int)thm.type;
            comboBox2.SelectedIndex = (int)thm.fmt;
            comboBox3.SelectedIndex = (int)thm.bump_mode - 1;
            comboBox4.SelectedIndex = (int)thm.mip_filter;
            comboBox7.SelectedIndex = (int)thm.material;

            TextBoxDetail.Text = thm.detail_name;
            TextBoxBump.Text = thm.bump_name;
            TextBoxNMap.Text = thm.ext_normal_map_name;
            textBox1.Text = thm.detail_scale.ToString();
            textBox4.Text = thm.border_color.ToString();
            textBox5.Text = thm.fade_amount.ToString();
            textBox6.Text = thm.fade_color.ToString();
            textBox8.Text = thm.width.ToString();
            textBox9.Text = thm.height.ToString();
            textBox10.Text = thm.fade_delay.ToString();
            textBox11.Text = thm.material_weight.ToString();
            textBox12.Text = thm.bump_virtual_height.ToString();
            chbxShocFormat.Checked = thm.soc_repaired;
        }
        public void Values_Update()
        {
            thm.type = (THM.ETType)comboBox1.SelectedIndex;
            thm.fmt = (THM.ETFormat)comboBox2.SelectedIndex;
            thm.bump_mode = (THM.ETBumpMode)comboBox3.SelectedIndex + 1;
            thm.mip_filter = (THM.EMIPFilters)comboBox4.SelectedIndex;
            thm.material = (THM.ETMaterial)comboBox7.SelectedIndex;

            thm.detail_name = TextBoxDetail.Text;
            thm.bump_name = TextBoxBump.Text;
            thm.ext_normal_map_name = TextBoxNMap.Text;
            thm.detail_scale = Convert.ToSingle(textBox1.Text);
            thm.border_color = Convert.ToUInt32(textBox4.Text);
            thm.fade_amount = Convert.ToUInt32(textBox5.Text);
            thm.fade_color = Convert.ToUInt32(textBox6.Text);
            thm.width = Convert.ToUInt32(textBox8.Text);
            thm.height = Convert.ToUInt32(textBox9.Text);
            thm.fade_delay = Convert.ToByte(textBox10.Text);
            thm.material_weight = Convert.ToSingle(textBox11.Text);
            thm.bump_virtual_height = Convert.ToSingle(textBox12.Text);
        }

        private void OpenDialogTHM(object sender, EventArgs e)
        {
            OpenFileThmDialog.ShowDialog();
        }

        private void OpenTHM(object sender, System.ComponentModel.CancelEventArgs e)
        {
            FILE_NAME = (sender as OpenFileDialog).FileName;
            thm.Load(FILE_NAME);
        }

        private void SaveTHM(object sender, EventArgs e)
        {
            if (FILE_NAME != null)
            {
                thm.Save(FILE_NAME);
                AutoClosingMessageBox.Show("Saved!", "", 500, MessageBoxIcon.Information);
            }
        }

        private void SaveAsTHM(object sender, System.ComponentModel.CancelEventArgs e)
        {
            thm.Save((sender as SaveFileDialog).FileName);
        }

        private void SaveAsDialogTHM(object sender, EventArgs e)
        {
            SaveAsFileThmDialog.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FlagsMenu flagsmenu = new FlagsMenu(thm);
            flagsmenu.ShowDialog();
        }

        private void ChangeTextureType(object sender, EventArgs e)
        {
            thm.type = (THM.ETType)comboBox1.SelectedIndex;
            thm.OnTypeChange();
        }

        private void ImportDDSDialog(object sender, EventArgs e)
        {
            OpenFileDDSDialog.ShowDialog();
        }

        private void ImportDDS(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string sFile = (sender as OpenFileDialog).FileName;
            string sFileBump = sFile.Substring(0, sFile.Length - 4) + "_bump.dds";

            dds_img = new DDSImage(sFile);

            if (dds_img != null)
            {
                thm.width = (uint)dds_img._image.Width;
                thm.height = (uint)dds_img._image.Height;

                switch (((Dds)dds_img._image).Header.PixelFormat.FourCC)
                {
                    case CompressionAlgorithm.D3DFMT_DXT1:
                        thm.fmt = THM.ETFormat.tfDXT1;
                        break;
                    case CompressionAlgorithm.D3DFMT_DXT3:
                        thm.fmt = THM.ETFormat.tfDXT3;
                        break;
                    case CompressionAlgorithm.D3DFMT_DXT5:
                        thm.fmt = THM.ETFormat.tfDXT5;
                        break;
                }

                if (((Dds)dds_img._image).Header.MipMapCount > 0)
                    thm.m_flags.Add((uint)THM.ETextureFlags.flGenerateMipMaps, true);

                if (File.Exists(sFileBump))
                {
                    if (!sFile.Contains("textures"))
                    {
                        AutoClosingMessageBox.Show("Please, open file in your textures foulder", "", 2000, MessageBoxIcon.Error);
                        return;
                    }

                    sFileBump = sFileBump.Substring(sFileBump.LastIndexOf("textures") + 9);
                    sFileBump = sFileBump.Substring(0, sFileBump.Length - 4);

                    thm.bump_mode = THM.ETBumpMode.tbmUse;
                    thm.bump_name = sFileBump;
                }

                Form_Update();
            }
            else
                AutoClosingMessageBox.Show("Can't load this dds format!", "", 1500, MessageBoxIcon.Error);
        }

        private void RepairShocThm(object sender, EventArgs e)
        {
            if (FILE_NAME != null)
            {
                thm.soc_repaired = true;
                thm.Save(FILE_NAME);
                AutoClosingMessageBox.Show("Repaired and saved!", "", 500, MessageBoxIcon.Information);
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "THM Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void TextBoxFilter(object sender, EventArgs e)
        {
            if (FILE_NAME == null) return;

            TextBox current = sender as TextBox;

            if (bKeyIsDown)
            {
                if (current.Text.Length == 0)
                    return;

                while (current.Text.Length >= 8)
                {
                    if (current.SelectionStart < 1)
                        current.SelectionStart = current.Text.Length;

                    int temp = current.SelectionStart;
                    current.Text = current.Text.Remove(current.Text.Length - 1, 1);
                    current.SelectionStart = temp;
                }

                string mask = number_mask;
                Match match = Regex.Match(current.Text, mask);
                if (!match.Success)
                {
                    if (current.SelectionStart < 1)
                        current.SelectionStart = current.Text.Length;

                    int temp = current.SelectionStart;
                    current.Text = current.Text.Remove(current.SelectionStart - 1, 1);
                    current.SelectionStart = temp - 1;
                }

                try
                {
                    Convert.ToSingle(current.Text);
                }
                catch (Exception)
                {
                    Form_Update();
                }

                Values_Update();
            }

            bKeyIsDown = false;
        }

        private void TextBoxKeyDown(object sender, KeyEventArgs e)
        {
            bKeyIsDown = true;
            Form1_KeyDown(sender, e);
        }

        private void LoadTextureMap(object sender, EventArgs e)
        {
            if (FILE_NAME != null);
            {
                Button current = sender as Button;
                button_tag = current.Tag;

                OpenFileDDSMapDialog.ShowDialog();
            }
        }

        private void LoadDDSMap(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string sFile = (sender as OpenFileDialog).FileName;

            if (!sFile.Contains("textures"))
            {
                AutoClosingMessageBox.Show("Please, open file in your textures foulder", "", 2000, MessageBoxIcon.Error);
                return;
            }

            sFile = sFile.Substring(sFile.LastIndexOf("textures") + 9);
            sFile = sFile.Substring(0, sFile.Length - 4);

            switch (button_tag.ToString())
            {
                case "Detail":
                    {
                        TextBoxDetail.Text = sFile;
                    }
                    break;
                case "Bump":
                    {
                        TextBoxBump.Text = sFile;
                    }
                    break;
                case "NMap":
                    {
                        TextBoxNMap.Text = sFile;
                    }
                    break;
                default: break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
                SaveTHM(null, null);

            switch (e.KeyData)
            {
                case Keys.F4: OpenDialogTHM(null, null); break;
                case Keys.F5: SaveTHM(null, null); break;
                case Keys.F6: SaveAsDialogTHM(null, null); break;
            }
        }

        public void UpdateFileName()
        {
            LabelStatusFile.Text = FILE_NAME.Substring(FILE_NAME.LastIndexOf('\\') + 1);
        }

        private void generateTHMForTextureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileGenerateTHMDialog.ShowDialog();
        }

        private void GenerateTHM(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string sFile = (sender as OpenFileDialog).FileName;
            string sFileBump = sFile.Substring(0, sFile.Length - 4) + "_bump.dds";
            string sMainTHM = sFile.Substring(0, sFile.Length - 4) + ".thm";
            string sBumpTHM = sFile.Substring(0, sFile.Length - 4) + "_bump.thm";

            THM main_thm = new THM(this);
            main_thm.ResetValues();
            main_thm.m_flags.Clear();
            main_thm.m_flags.Add((uint)THM.ETextureFlags.flDitherColor, true);

            dds_img = new DDSImage(sFile);
            if (dds_img != null)
            {
                main_thm.width = (uint)dds_img._image.Width;
                main_thm.height = (uint)dds_img._image.Height;

                switch (((Dds)dds_img._image).Header.PixelFormat.FourCC)
                {
                    case CompressionAlgorithm.D3DFMT_DXT1:
                        main_thm.fmt = THM.ETFormat.tfDXT1;
                        break;
                    case CompressionAlgorithm.D3DFMT_DXT3:
                        main_thm.fmt = THM.ETFormat.tfDXT3;
                        break;
                    case CompressionAlgorithm.D3DFMT_DXT5:
                        main_thm.fmt = THM.ETFormat.tfDXT5;
                        break;
                }

                if (((Dds)dds_img._image).Header.MipMapCount > 0)
                    main_thm.m_flags.Add((uint)THM.ETextureFlags.flGenerateMipMaps, true);
            }

            if (File.Exists(sFileBump))
            {
                if (!sFile.Contains("textures"))
                {
                    AutoClosingMessageBox.Show("Please, open file in your textures foulder", "", 2000, MessageBoxIcon.Error);
                    return;
                }

                sFileBump = sFileBump.Substring(sFileBump.LastIndexOf("textures") + 9);
                sFileBump = sFileBump.Substring(0, sFileBump.Length - 4);

                main_thm.bump_mode = THM.ETBumpMode.tbmUse;
                main_thm.bump_name = sFileBump;

                THM bump_thm = new THM(this);
                bump_thm.ResetValues();
                bump_thm.m_flags.Clear();
                bump_thm.m_flags.Add((uint)THM.ETextureFlags.flDitherColor, true);
                bump_thm.m_flags.Add((uint)THM.ETextureFlags.flHasAlpha, true);

                dds_img = new DDSImage(sFile);
                if (dds_img != null)
                {
                    bump_thm.width = (uint)dds_img._image.Width;
                    bump_thm.height = (uint)dds_img._image.Height;

                    switch (((Dds)dds_img._image).Header.PixelFormat.FourCC)
                    {
                        case CompressionAlgorithm.D3DFMT_DXT1:
                            bump_thm.fmt = THM.ETFormat.tfDXT1;
                            break;
                        case CompressionAlgorithm.D3DFMT_DXT3:
                            bump_thm.fmt = THM.ETFormat.tfDXT3;
                            break;
                        case CompressionAlgorithm.D3DFMT_DXT5:
                            bump_thm.fmt = THM.ETFormat.tfDXT5;
                            break;
                    }

                    if (((Dds)dds_img._image).Header.MipMapCount > 0)
                        bump_thm.m_flags.Add((uint)THM.ETextureFlags.flGenerateMipMaps, true);
                }
                bump_thm.Save(sBumpTHM);
            }

            main_thm.Save(sMainTHM);
            AutoClosingMessageBox.Show("Generated!", "", 500, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (thm != null)
                thm.soc_repaired = chbxShocFormat.Checked;
        }
    }
}
