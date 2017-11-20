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
            public static string sBotName = "Sammy";
            public static int iCitNum = 318855;
            public static string sPassword = "password";
            public static string sWorld = "powergod";
            public static int iXPos = 0;
            public static int iYPos = 690;
            public static int iZPos = 500;
            public static int iYaw = 0;
            public static int iAV = 1;

            public static bool iInUniv = false;
            public static bool iInWorld = false;
        }

        // Form starting point
        private void Form1_Load(object sender, EventArgs e)
        {
            Status("Ready to log into universe.");
            textBotname.Text = Globals.sBotName;
            textCitnum.Text = Convert.ToString(Globals.iCitNum);
            textPrivPass.Text = Globals.sPassword;
            textWorld.Text = Globals.sWorld;
            //textXPos.Text = Convert.ToString(Globals.iXPos);
            //txtYPos.Text = Convert.ToString(Globals.iYPos);
            //txtZPos.Text = Convert.ToString(Globals.iZPos);
            //txtYaw.Text = Convert.ToString(Globals.iYaw);
            textAvatar.Text = Convert.ToString(Globals.iAV);

            aTimer = new Timer();
            aTimer.Tick += new EventHandler(aTimer_Tick);
            aTimer.Interval = 100;
            aTimer.Start();
        }




        // Timer function for the AW Wait function
        private void aTimer_Tick(object source, EventArgs e)
        {
            Utility.Wait(0);
        }



        // The status update member
        private void Status(string sText)
        {
            lisStatus.Items.Add(sText);
        }



    }
}
