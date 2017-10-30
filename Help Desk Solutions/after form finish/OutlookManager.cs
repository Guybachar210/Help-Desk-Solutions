using System.Runtime.InteropServices;
using System.Windows.Forms;
using Help_Desk_Solutions.tools;
using System.Diagnostics;
using Microsoft.Office.Interop.Outlook;

namespace Help_Desk_Solutions.brain
{

    internal class OutlookManager
    {
        private Microsoft.Office.Interop.Outlook.Application outlookObj;

        private string CreateMsg(bool isPaperJam, bool isPrinterError, bool isTonerLow, bool isDrumLow, string printerName, string itNotes)
        {
            var msgContent = OutlookBank.CONTENT_PREFIX;
            if (isPaperJam) msgContent += OutlookBank.ISSUE_PAPER_JAM;
            if (isTonerLow) msgContent += OutlookBank.ISSUE_TONER;
            if (isDrumLow) msgContent += OutlookBank.ISSUE_DRUM;
            if (isPrinterError) msgContent += OutlookBank.ISSUE_WONT_PRINT;
            if (!itNotes.Equals("")) msgContent += OutlookBank.IT_NOTES_SUFIX + itNotes;
            msgContent += OutlookBank.CONTENT_SUFIX + printerName;

            return msgContent;
        }

        public void InitOutlook(bool isPaperJam, bool isPrinterError, bool isTonerLow, bool isDrumLow, string printerName, string itNotes)
        {
            string msgContent = CreateMsg(isPaperJam, isPrinterError, isTonerLow, isDrumLow, printerName, itNotes);
            SendMsg(msgContent);
        }

        private void SendMsg(string msgContent)
        {
            Microsoft.Office.Interop.Outlook.Application oApp = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook._MailItem oMailItem = (Microsoft.Office.Interop.Outlook._MailItem)oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
            oMailItem.To = OutlookBank.TO;
            oMailItem.Subject = OutlookBank.SUBJECT;


            //check if outlook is closed... and open it up
           bool outlookWasOpen = 
           AppTools.();

 
            oMailItem.Body = msgContent;
            oMailItem.Display(false);
            oMailItem.DeleteAfterSubmit = true;
            oMailItem.Send();

            MessageBox.Show(PopUpMessagesBank.SENT);
        }
    }
}