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
    public partial class FormMountainRanges_land_ : Form
    {
        public FormMountainRanges_land_()
        {
            InitializeComponent();

        }

        private void FormMountainRanges_land__Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "geoDataSet._Mountain_ranges_land_". При необходимости она может быть перемещена или удалена.
            this.mountain_ranges_land_TableAdapter.Fill(this.geoDataSet._Mountain_ranges_land_);
            textBoxName.Text = "";
            textBoxLength.Text = "";
            textBoxHightPointName.Text = "";
            textBoxHight.Text = "";
            textBoxNotes.Text = "";

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            mountainrangeslandBindingSource.AddNew();
            groupBoxMRLand.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            mountainrangeslandBindingSource.EndEdit();
            mountain_ranges_land_TableAdapter.Update(geoDataSet._Mountain_ranges_land_);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            mountainrangeslandBindingSource.RemoveCurrent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormMainMenu backToMenu = new FormMainMenu();
            backToMenu.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Roll_up_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {

                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch.Text))
                        {
                            dataGridView1.Rows[i].Cells[j].Selected = true;
                            count++;
                            break;

                        }
                    }
                }
            }

            if (count == 0)
            {
                MessageBox.Show("No concidences found,please, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
