using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Help_Desk_Solutions.tools
{
    public class AppTools
    {

        public static string GetDefaultPrinter()
        { 
            PrinterSettings settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;
                if (settings.IsDefaultPrinter)
                    return printer;
            }

            PopMsg(PopUpMessagesBank.NO_DEFAULT_PRINTER + PopUpMessagesBank.CONTACT_IT);
            return "";
        }

        internal static void PopMsg(string msg)
        {
            MessageBox.Show(msg);

        }

       
    }
}