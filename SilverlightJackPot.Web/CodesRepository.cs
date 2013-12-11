using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverlightJackPot.Web
{
    public class CodesRepository
    {
        private List<string> winningCodes;
        
        public CodesRepository()
        {
            FillWinningCodes();
        }
        
        private void FillWinningCodes()
        {
            if (winningCodes == null)
            {
                winningCodes = new List<string>();
                winningCodes.Add("12345abc");
                winningCodes.Add("azertyse");
                winningCodes.Add("abcdefgh");
                winningCodes.Add("helloall");
                winningCodes.Add("ohnice11");
                winningCodes.Add("yesigot1");
                winningCodes.Add("superwin");
            }
        }
        public List<string> WinningCodes
        {
            get
            {
                return winningCodes;
            }
        }
    }
}