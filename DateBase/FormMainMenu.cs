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
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void buttonOceans_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormOceans Reg = new FormOceans();
            Reg.ShowDialog();
        }

        private void buttonSeas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormSeas Reg = new FormSeas();
            Reg.ShowDialog();

        }

        private void buttonCurrents_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormCurrents Reg = new FormCurrents();
            Reg.ShowDialog();

        }

        private void buttonLithosphericPlates_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormLithosphericPlates Reg = new FormLithosphericPlates();
            Reg.ShowDialog();

        }

        private void buttonMountainRanges_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormMountainRanges Reg = new FormMountainRanges();
            Reg.ShowDialog();
        }

        private void buttonVolcanoes_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormVolcanoes Reg = new FormVolcanoes();
            Reg.ShowDialog();

        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button_Roll_up_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void buttonClouse_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
