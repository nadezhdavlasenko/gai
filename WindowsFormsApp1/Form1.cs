﻿using System;
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
    }
}
