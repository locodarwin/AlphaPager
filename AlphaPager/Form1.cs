using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AW;

namespace AlphaPager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public IInstance _instance;
        public Timer aTimer;

        public static class Globals
        {
            public static string sUnivLogin = "auth.activeworlds.com";
            public static int iPort = 6670;
            public static string sBotName = "cSharpBot";
            public static string sBotDesc = "Bot Test";
            public static int iCitNum = 318855;
            public static string sPassword = "shamma11";
            public static string sWorld = "powergod";
            public static int iXPos = 0;
            public static int iYPos = 690;
            public static int iZPos = 500;
            public static int iYaw = 0;
            public static int iAV = 1;

            public static bool iInUniv = false;
            public static bool iInWorld = false;
        }




    }
}
