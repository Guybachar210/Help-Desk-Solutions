﻿namespace Help_Desk_Solutions.brain
{

    internal class OutlookManager
    {
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

        }
    }
}