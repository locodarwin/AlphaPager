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

            //lisStatus.View = View.Details;
            //lisStatus.Columns.Add("Status", 180, HorizontalAlignment.Left);

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

        
        /*
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
        */

        private void butLogin_Click(object sender, EventArgs e)
        {
            UniverseLogin();
        }




        // The click event for Login to Universe
        private void UniverseLogin()
        {
            // Grab the contents of the controls and put them into the globals
            //Globals.sUnivLogin = txtHost.Text;
            //Globals.iPort = Convert.ToInt32(txtPort.Text);
            Globals.sBotName = textBotname.Text;
            //Globals.sBotDesc = txtDesc.Text;
            Globals.iCitNum = Convert.ToInt32(textCitnum.Text);
            Globals.sPassword = textPrivPass.Text;


            // Check universe login state and abort if we're already logged in
            if (Globals.iInUniv == true)
            {
                Status("Already logged into universe!");
                return;
            }

            // Initalize the AW API?
            Status("Initializing the API instance.");
            _instance = new Instance();

            // Install events & callbacks
            Status("Installing events and callbacks.");
            //_instance.EventAvatarAdd += OnEventAvatarAdd;
            //_instance.EventChat += OnEventChat;

            // Set universe login parameters
            _instance.Attributes.LoginName = Globals.sBotName;
            _instance.Attributes.LoginOwner = Globals.iCitNum;
            _instance.Attributes.LoginPrivilegePassword = Globals.sPassword;
            //_instance.Attributes.LoginApplication = Globals.sBotDesc;

            // Log into universe
            Status("Entering universe.");
            var rc = _instance.Login();
            if (rc != Result.Success)
            {
                Status("Failed to log in to universe (reason:" + rc + ").");
                return;
            }
            else
            {
                Status("Universe entry successful.");
                Globals.iInUniv = true;
            }
        }











        // Timer method for AW_WAIT()
        private void aTimer_Tick(object source, EventArgs e)
        {
            if(Globals.iInWorld)
            {
                Utility.Wait(0);
            }
            
        }



        // The status update member
        private void Status(string sText)
        {
            lisStatus.Items.Add(sText);
        }

        
    }
}
