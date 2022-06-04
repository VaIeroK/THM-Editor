using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThmEditor
{
    public partial class FlagsMenu : Form
    {
        private THM thm;
        private bool need_update = false;

        public FlagsMenu(THM cast_thm)
        {
            thm = cast_thm;
            InitializeComponent();
        }

        private void FlagsMenu_Load(object sender, EventArgs e)
        {
            need_update = false;

            checkBox1.Checked = thm.m_flags.Test((uint)THM.ETextureFlags.flGenerateMipMaps);
            checkBox2.Checked = thm.m_flags.Test((uint)THM.ETextureFlags.flBinaryAlpha);
            checkBox3.Checked = thm.m_flags.Test((uint)THM.ETextureFlags.flAlphaBorder);
            checkBox4.Checked = thm.m_flags.Test((uint)THM.ETextureFlags.flColorBorder);
            checkBox5.Checked = thm.m_flags.Test((uint)THM.ETextureFlags.flFadeToColor);
            checkBox6.Checked = thm.m_flags.Test((uint)THM.ETextureFlags.flFadeToAlpha);
            checkBox7.Checked = thm.m_flags.Test((uint)THM.ETextureFlags.flDitherColor);
            checkBox8.Checked = thm.m_flags.Test((uint)THM.ETextureFlags.flDitherEachMIPLevel);
            checkBox9.Checked = thm.m_flags.Test((uint)THM.ETextureFlags.flDiffuseDetail);
            checkBox10.Checked = thm.m_flags.Test((uint)THM.ETextureFlags.flImplicitLighted);
            checkBox11.Checked = thm.m_flags.Test((uint)THM.ETextureFlags.flHasAlpha);
            checkBox12.Checked = thm.m_flags.Test((uint)THM.ETextureFlags.flBumpDetail);

            need_update = true;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!need_update)
                return;

            thm.m_flags.Clear();
            thm.m_flags.Add((uint)THM.ETextureFlags.flGenerateMipMaps, checkBox1.Checked);
            thm.m_flags.Add((uint)THM.ETextureFlags.flBinaryAlpha, checkBox2.Checked);
            thm.m_flags.Add((uint)THM.ETextureFlags.flAlphaBorder, checkBox3.Checked);
            thm.m_flags.Add((uint)THM.ETextureFlags.flColorBorder, checkBox4.Checked);
            thm.m_flags.Add((uint)THM.ETextureFlags.flFadeToColor, checkBox5.Checked);
            thm.m_flags.Add((uint)THM.ETextureFlags.flFadeToAlpha, checkBox6.Checked);
            thm.m_flags.Add((uint)THM.ETextureFlags.flDitherColor, checkBox7.Checked);
            thm.m_flags.Add((uint)THM.ETextureFlags.flDitherEachMIPLevel, checkBox8.Checked);
            thm.m_flags.Add((uint)THM.ETextureFlags.flDiffuseDetail, checkBox9.Checked);
            thm.m_flags.Add((uint)THM.ETextureFlags.flImplicitLighted, checkBox10.Checked);
            thm.m_flags.Add((uint)THM.ETextureFlags.flHasAlpha, checkBox11.Checked);
            thm.m_flags.Add((uint)THM.ETextureFlags.flBumpDetail, checkBox12.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thm.m_flags.Clear();
            thm.m_flags.Add((uint)THM.ETextureFlags.flGenerateMipMaps, true);
            thm.m_flags.Add((uint)THM.ETextureFlags.flDitherColor, true);
            FlagsMenu_Load(null, null);
        }
    }
}
