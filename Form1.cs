using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassOOP4;
using System.IO;
namespace OOP4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassGreed.CreatDateGreed(ClassGreed.KDisk(), dataGridViewDisks);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string k = textBoxDisk.Text;
            if (k.Length == 1)
            {
                k += ":\\";
            }
            ClassDiskInfo1.DataGrid(k, dataGridViewDiskInfo);
            ClassDiskInfo1.DiskInfo(k, dataGridViewDiskInfo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string k = textBoxCatalog.Text;
            ClassDiskInfo1.DataGrid(k, dataGridViewCatalogInfo);
            ClassDiskInfo1.DiskInfo(k, dataGridViewCatalogInfo);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonFileInfo_Click(object sender, EventArgs e)
        {
            string k = textBoxFile.Text;// @"C:\Users\cofee\OneDrive\Робочий стіл\лабки\12.doc";
            FileInfo fileInf1 = new FileInfo(k);
            long size = fileInf1.Length;
            labelLen.Text = size.ToString();
            labelDateCreate.Text = fileInf1.CreationTime.ToString();
            labelDateChange.Text = fileInf1.LastAccessTime.ToString();
        }
    }
}
