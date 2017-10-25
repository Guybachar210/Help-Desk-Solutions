using System;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Windows.Forms;
using Help_Desk_Solutions.brain;
using Help_Desk_Solutions.tools;


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
            ProgramInitator programInitator = new ProgramInitator();
            programInitator.OnFormSendClicked(paperJamCB.Checked, printerErrorCB.Checked, tonerLowCB.Checked, drumLowCB.Checked, printerTB.Text, notesTB.Text);
            

        }

        private void printerTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}








