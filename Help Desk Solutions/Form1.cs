using System;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Windows.Forms;


namespace Help_Desk_Solutions
{


    public partial class Helper : Form
    {
        private object reportViewer;

        public Helper()
        {
            InitializeComponent();
        }

  

        private void Form1_Load(object sender, EventArgs e)
        {
            SetDefaultPrinter();

        }

        private void SetDefaultPrinter()
        {
            PrinterSettings settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;
                if (settings.IsDefaultPrinter)
                    printerTB.Text = printer;
            }
           
        }
    }
}








