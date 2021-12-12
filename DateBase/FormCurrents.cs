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
    public partial class FormCurrents : Form
    {
        public FormCurrents()
        {
            InitializeComponent();
        }

        private void FormCurrents_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "geoDataSet.Currents". При необходимости она может быть перемещена или удалена.
            this.currentsTableAdapter.Fill(this.geoDataSet.Currents);
            textBoxName.Text = "";
            textBoxTem.Text = "";
            textBoxNotes.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            currentsBindingSource.AddNew();
            groupBoxCurrents.Enabled = true;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            currentsBindingSource.EndEdit();
            currentsTableAdapter.Update(geoDataSet.Currents);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            currentsBindingSource.RemoveCurrent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormMainMenu backToMenu = new FormMainMenu();
            backToMenu.ShowDialog();

        }

        private void roll_up_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            

        }

        private void groupBoxCurrents_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

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

        private void textBoxSearch_TextChanged_1(object sender, EventArgs e)
        {
            

        }

        private void textBoxTem_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTem_Click(object sender, EventArgs e)
        {

        }
    }
}
