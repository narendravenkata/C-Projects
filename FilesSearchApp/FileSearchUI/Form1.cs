using FileSearch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearchUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FileSearchMethod fileSearch = new FileSearchMethod();
            fileSearch.SendFileName += SendFileName;
           
            Thread thread = new Thread(() => fileSearch.Search(txtDir.Text));
            thread.Start();
        }
        private void SendFileName(string file)
        {
            listFiles.Items.Add(file);

        }
    }
}
