using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cvManagement
{
    public partial class CvManagement : Form
    {
        public void noVisibleForm()
        {
            fName.Visible = false;
            lName.Visible = false;
            addEmail.Visible = false;
            addPhoneNumber.Visible = false;
            chooseSpeciality.Visible = false;
            male.Visible = false;
            female.Visible = false;
            searchCv.Visible = false;
            add.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
        }

        public void VisibleForm()
        {
            fName.Visible = true;
            lName.Visible = true;
            addEmail.Visible = true;
            addPhoneNumber.Visible = true;
            chooseSpeciality.Visible = true;
            male.Visible = true;
            female.Visible = true;
            searchCv.Visible = true;
            add.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
        }

        DataTable table = new DataTable("Table");

        public CvManagement()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginAndRegister loginAndRegister = new();
            this.Hide();
            loginAndRegister.Show();
        }

        private void CvManagement_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 6;
        }

        private void addCVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleForm();
        }

        private string GetSelectedItem()
        {
            if (male.Checked)
            {
                return "Male";
            }
            else if (female.Checked)
            {
                return "Female";
            }
            else
            {
                return "none";
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
            MessageBox.Show(path);
            table.Rows.Add(fName.Text, lName.Text, GetSelectedItem(), chooseSpeciality.SelectedItem.ToString(), addEmail.Text, addPhoneNumber.Text, "cv");
            noVisibleForm();
        }

        private void addPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        string path;
        private void searchCv_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Search for your CV";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                MessageBox.Show(fbd.SelectedPath);
                fbd.SelectedPath = path;
        }
    }
}

