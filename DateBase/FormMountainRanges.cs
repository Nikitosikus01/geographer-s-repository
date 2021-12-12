using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateBase
{
    public partial class FormMountainRanges : Form
    {
        public FormMountainRanges()
        {
            InitializeComponent();
        }

        private void buttonLand_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormMountainRanges_land_ Reg = new FormMountainRanges_land_();
            Reg.ShowDialog();

        }

        private void buttonOceans_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormMountainRanges_ocean_ Reg = new FormMountainRanges_ocean_();
            Reg.ShowDialog();

        }
    }
}
