namespace Help_Desk_Solutions.brain
{
    internal class OutlookManager
    {
        public void InitiateOutlookMsg(bool isPaperJam, bool isPrinterError, bool isTonerLow, bool isDrumLow, string printerName, string itNotes)
        {
         sendMsg(isPaperJam, isPrinterError, isTonerLow, isDrumLow, printerName, itNotes);
        }
    }
}