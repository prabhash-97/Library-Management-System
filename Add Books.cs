using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMALL_LIBRARY_MANAGEMENT_SYSTEM
{
    public partial class Add_Books : Form
    {
        public Add_Books()
        {
            InitializeComponent();
        }

        private void addBooksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addBooksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Add_Books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.AddBooks' table. You can move, or remove it, as needed.
            this.addBooksTableAdapter.Fill(this.libraryDataSet.AddBooks);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            addBooksBindingSource.CancelEdit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Do you want to exit?", this.Text,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
