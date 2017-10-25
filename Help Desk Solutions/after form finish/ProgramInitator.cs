using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Help_Desk_Solutions.tools;

namespace Help_Desk_Solutions.brain
{
    internal class ProgramInitator
    {
        public void OnFormSendClicked(bool isPaperJam, bool isPrinterError, bool isTonerLow, bool isDrumLow, string printerName, string ITNotes)
        {
            //todo: check if has inenet
            if (!AppTools.hasInternet())
            {
                AppTools.PopMsg(PopUpMessagesBank.NO_INTERENT_MSG + PopUpMessagesBank.CONTACT_IT);
                return;
            }

            OutlookManager outlookManager = new OutlookManager();
            outlookManager.InitiateOutlookMsg(isPaperJam, isPrinterError, isTonerLow, isDrumLow, printerName, ITNotes);

        }
        
    }
}
