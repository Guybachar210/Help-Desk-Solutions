using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
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

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("http://clients3.google.com/generate_204"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }

        }
    }

}