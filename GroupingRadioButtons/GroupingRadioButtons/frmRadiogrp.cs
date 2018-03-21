using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupingRadioButtons
{
    public partial class frmRadiogrp : Form
    {
        public frmRadiogrp()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RdoRain_CheckedChanged(object sender, EventArgs e)
        {
            PicRain.Visible = true;
            PicSun.Visible = false;
            PicSnow.Visible = false;
        }

        private void RdoSun_CheckedChanged(object sender, EventArgs e)
        {
            PicSun.Visible = true;
            PicRain.Visible = false;
            PicSnow.Visible = false;
        }

        private void RdoSnow_CheckedChanged(object sender, EventArgs e)
        {
            PicSnow.Visible = true;
            PicRain.Visible = false;
            PicSun.Visible = false;
        }

        private void RdoCanada_CheckedChanged(object sender, EventArgs e)
        {
            PicCanada.Visible = true;
            PicItaly.Visible = false;
            PicUk.Visible = false;
        }

        private void RdoItaly_CheckedChanged(object sender, EventArgs e)
        {
            PicCanada.Visible = false;
            PicItaly.Visible = true;
            PicUk.Visible = false;
        }

        private void RdoUk_CheckedChanged(object sender, EventArgs e)
        {
            PicCanada.Visible = false;
            PicItaly.Visible = false;
            PicUk.Visible = true;
        }
    }
}
