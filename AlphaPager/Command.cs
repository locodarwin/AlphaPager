using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AW;

namespace AlphaPager
{
    public partial class Form1
    {

        private void Commands(string sName, int iType, int iSession, string sMsg)
        {
            // Get first letter of what was said command; if not a command, abort command mode
            if (sMsg[0].ToString() != "/")
            {
                return;
            }

            // Strip all unneeded parts off the command and split into parameters
            string strip = sMsg.Substring(1);
            strip = strip.Trim();
            string[] cmd = strip.Split(' ');

            switch (cmd[0])
            {
                case "version":
                    DoVersion(sName, iType, iSession, cmd);
                    break;
                case "ver":
                    DoVersion(sName, iType, iSession, cmd);
                    break;


            }
            //Stat(1, "Test", cmd, "black");
        }

        // Method to respond back on the results of the command
        private void Response(int iSess, int iType, string sMsg)
        {
            if (iType == 2)
            {
                _instance.Whisper(iSess, sMsg);
                Status("(whispered): " + sMsg);
            }
            else
            {
                _instance.Say(sMsg);
                Status(sMsg);
            }

        }


        // Command VERSION
        private void DoVersion(string sName, int iType, int iSess, string[] cmd)
        {
            int iCitnum = GetCitnum(sName);
            Status("Command: version (requested by " + sName + " (" + iCitnum.ToString() + ")");

            // Check permissions
            //if (CheckPerms(iCitnum, cmd[0]) == false)
            //{
            //    Response(iSess, iType, "Sorry, " + sName + ", but you do not have permission to use the " + cmd[0] + " command.");
            //    return;
            //}
            Response(iSess, iType, Globals.sAppName + " " + Globals.sVersion + " - " + Globals.sByline);
        }


    }
}
