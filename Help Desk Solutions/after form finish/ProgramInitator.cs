using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help_Desk_Solutions.brain
{
    internal class ProgramInitator
    {
        public void OnFormSendClicked(bool isPaperJam, bool isPrinterError, bool isTonerLow, bool isDrumLow, string printerName, string ITNotes)
        {
            //check if has internet
            if (!hasInternet())
            {
                //1) display error msg: "you dont have internet. Call IT: "

                return;

            }

        }

        private bool hasInternet()
        {
            return false;
        }
    }
}
