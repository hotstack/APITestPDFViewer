using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APITestPDFViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenPDF_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "PDF|*.pdf" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    
                    axAcroPDF1.src = ofd.FileName;
                    axAcroPDF1.setView("Fit");
                    axAcroPDF1.setShowToolbar(false);
                    axAcroPDF1.setLayoutMode("SinglePage");
                    axAcroPDF1.Show();
                    txtInputFile.Text = ofd.FileName;
                    txtOutputFile.Text = ofd.FileName.Replace(".pdf", "") + "_complete.pdf";
                }
            }

        }
    }
}
