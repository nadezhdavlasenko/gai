using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void candidateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.candidateBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Position' table. You can move, or remove it, as needed.
            this.positionTableAdapter.Fill(this.dataSet1.Position);
            // TODO: This line of code loads data into the 'dataSet1.HiringContract' table. You can move, or remove it, as needed.
            this.hiringContractTableAdapter.Fill(this.dataSet1.HiringContract);
            // TODO: This line of code loads data into the 'dataSet1.Candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter.Fill(this.dataSet1.Candidate);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            candidateBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            candidateBindingSource.EndEdit();
            candidateTableAdapter.Update(dataSet1); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hiringContractBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hiringContractBindingSource.EndEdit();
            hiringContractTableAdapter.Update(dataSet1);
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            positionBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            positionBindingSource.EndEdit();
            positionTableAdapter.Update(dataSet1); 

        }

        private void delete_Click(object sender, EventArgs e)
        {
            candidateDataGridView.Rows.Remove(candidateDataGridView.SelectedRows[0]);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hiringContractDataGridView.Rows.Remove(hiringContractDataGridView.SelectedRows[0]);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            positionDataGridView.Rows.Remove(positionDataGridView.SelectedRows[0]);
        }

        private void MoveFirst_Click(object sender, EventArgs e)
        {
            candidateBindingSource.MoveFirst();

        }

        private void MoveLast_Click(object sender, EventArgs e)
        {
            candidateBindingSource.MoveLast();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            candidateBindingSource.MovePrevious();
        }

        private void MoveNext_Click(object sender, EventArgs e)
        {
            candidateBindingSource.MoveNext();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            int foundIndex = positionBindingSource.Find("name", name);
            if (foundIndex == -1)
            {
                MessageBox.Show("Not found");
                return;
            }
            this.positionBindingSource.Position = foundIndex;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            positionBindingSource.Sort = "numberOfVacancies ASC";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                positionBindingSource.Filter = "";
            }
            else
            {
                positionBindingSource.Filter = string.Format("name LIKE '{0}'", nameTextBox.Text);
            }
        }

       
    
    }
}
