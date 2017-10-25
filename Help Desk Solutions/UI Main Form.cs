using System;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Windows.Forms;


namespace Help_Desk_Solutions
{


    public partial class MainUIForm : Form
    {
        private object reportViewer;

        public MainUIForm()
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

        private void sendBtn_Click(object sender, EventArgs e)
        {

        }
    }
}








