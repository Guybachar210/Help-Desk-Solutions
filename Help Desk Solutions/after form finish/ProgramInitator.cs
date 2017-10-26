using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Help_Desk_Solutions.tools;

namespace Help_Desk_Solutions.brain
{
    internal class ProgramInitator
    {
        public void OnFormSendClicked(bool isPaperJam, bool isPrinterError, bool isTonerLow, bool isDrumLow,
            string printerName, string ITNotes)
        {
            if (!AppTools.CheckForInternetConnection())
            {
                MessageBox.Show(PopUpMessagesBank.NO_INTERENT_MSG + PopUpMessagesBank.CONTACT_IT);
                return;
            }

            OutlookManager outlookManager = new OutlookManager();
            outlookManager.SendMsg(isPaperJam, isPrinterError, isTonerLow, isDrumLow, printerName, ITNotes);

        }
        //
        //            
        //            


    }



}








