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
    public partial class FormMountainRanges_ocean_ : Form
    {
        public FormMountainRanges_ocean_()
        {
            InitializeComponent();
            textBoxName.Text = "";
            textBoxNotes.Text = "";
            textBoxLength.Text = "";

        }

        private void FormMountainRanges_ocean__Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "geoDataSet._Mountain_ranges_ocean_". При необходимости она может быть перемещена или удалена.
            this.mountain_ranges_ocean_TableAdapter.Fill(this.geoDataSet._Mountain_ranges_ocean_);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            mountainrangesoceanBindingSource.AddNew();
            groupBoxMROcean.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            mountainrangesoceanBindingSource.EndEdit();
            mountain_ranges_ocean_TableAdapter.Update(geoDataSet._Mountain_ranges_ocean_);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            mountainrangesoceanBindingSource.RemoveCurrent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormMainMenu backToMenu = new FormMainMenu();
            backToMenu.ShowDialog();

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Roll_up_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
