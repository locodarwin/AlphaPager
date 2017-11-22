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

        // Timer, BG worker, instance definitions
        public IInstance _instance;
        public Timer aTimer;
        BackgroundWorker m_Login;


        struct Coords 
        {
        public int x;
        public int y;
        public int z;
        public int yaw;
        };


        public Form1()
        {
            InitializeComponent();

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

            // Button starting configurations
            toolLoggedIn.BackColor = System.Drawing.Color.Green;
            butLogout.Enabled = false;

            // The AW message queue timer
            aTimer = new Timer();
            aTimer.Tick += new EventHandler(aTimer_Tick);
            aTimer.Interval = 50;
            aTimer.Start();

            // Background tasking definitions for the universe & world login
            m_Login = new BackgroundWorker();
            m_Login.DoWork += new DoWorkEventHandler(m_LoginDoWork);
            m_Login.ProgressChanged += new ProgressChangedEventHandler(m_LoginProgress);
            m_Login.RunWorkerCompleted += new RunWorkerCompletedEventHandler(m_LoginCompleted);
            m_Login.WorkerReportsProgress = true;

        }

        

        public static class Globals
        {
            public static string sAppName = "AlphaPager";
            public static string sVersion = "v1.0";
            public static string sByline = "Copyright © 2017 by Locodarwin";

            public static string sUnivLogin = "auth.activeworlds.com";
            public static int iPort = 6670;
            public static string sBotName = "Sammy";
            public static int iCitNum = 318855;
            public static string sPassword = "password";
            public static string sWorld = "Simulator";
            public static int iXPos = 0;
            public static int iYPos = 690;
            public static int iZPos = 500;
            public static int iYaw = 0;
            public static int iAV = 1;

            // Status and logging
            public static bool iChat2Stat = false;
            public static bool iCmd2Stat = true;
            public static bool iChat2Log = false;
            public static bool iCmd2Log = false;
            public static bool iStat2Log = false;

            // Universe/world login states
            public static bool iInUniv = false;
            public static bool iInWorld = false;
        }

        private void butLogin_Click(object sender, EventArgs e)
        {

            // Grab the contents of the controls and put them into the globals
            //Globals.sUnivLogin = txtHost.Text;
            //Globals.iPort = Convert.ToInt32(txtPort.Text);
            Globals.sBotName = textBotname.Text;
            //Globals.sBotDesc = txtDesc.Text;
            Globals.iCitNum = Convert.ToInt32(textCitnum.Text);
            Globals.sPassword = textPrivPass.Text;
            // Pull globals from controls for world entry and positioning
            Globals.sWorld = textWorld.Text;
            //Globals.iXPos = Convert.ToInt32(txtXPos.Text);
            //Globals.iYPos = Convert.ToInt32(txtYPos.Text);
            //Globals.iZPos = Convert.ToInt32(txtZPos.Text);
            //Globals.iYaw = Convert.ToInt32(txtYaw.Text);
            Globals.iXPos = 0;
            Globals.iYPos = 200;
            Globals.iZPos = 0;
            Globals.iYaw = 0;
            Globals.iAV = Convert.ToInt32(textAvatar.Text);

            toolLoggedIn.BackColor = System.Drawing.Color.Yellow;
            toolLoggedIn.Text = "Logging In";
            butLogin.Enabled = false;
            butConfig.Enabled = false;

            m_Login.RunWorkerAsync();

        }

        private void butLogout_Click(object sender, EventArgs e)
        {
            if (Globals.iInUniv == false)
            {
                Status("Not in universe. Aborted.");
                return;
            }
            _instance.Dispose();
            Status("Logged out.");
            toolLoggedIn.BackColor = System.Drawing.Color.Green;
            toolLoggedIn.Text = "Logged Out";
            butLogin.Enabled = true;
            butConfig.Enabled = true;
            Globals.iInUniv = false;
            Globals.iInWorld = false;
        }



        private void m_LoginDoWork(object sender, DoWorkEventArgs e)
        {

            // Check universe login state and abort if we're already logged in
            if (Globals.iInUniv == true)
            {
                m_Login.ReportProgress(0, "Already logged into universe!");
                return;
            }

            // Initalize the AW API?
            m_Login.ReportProgress(0, "Initializing the API instance.");
            _instance = new Instance();

            // Install events & callbacks
            m_Login.ReportProgress(0, "Installing events and callbacks.");
            //_instance.EventAvatarAdd += OnEventAvatarAdd;
            _instance.EventChat += OnEventChat;

            // Set universe login parameters
            _instance.Attributes.LoginName = Globals.sBotName;
            _instance.Attributes.LoginOwner = Globals.iCitNum;
            _instance.Attributes.LoginPrivilegePassword = Globals.sPassword;
            //_instance.Attributes.LoginApplication = Globals.sBotDesc;

            // Log into universe
            //m_Login.ReportProgress(0, "Entering universe.");
            var rc = _instance.Login();
            if (rc != Result.Success)
            {
                m_Login.ReportProgress(0, "Unable to log in to universe (reason:" + rc + ").");
                return;
            }
            else
            {
                m_Login.ReportProgress(0, "Universe entry successful.");
                Globals.iInUniv = true;
            }
 
            // Enter world
            //m_Login.ReportProgress(0, "Logging into world " + Globals.sWorld + ".");
            rc = _instance.Enter(Globals.sWorld);
            if (rc != Result.Success)
            {
                m_Login.ReportProgress(0, "Failed to log into world" + Globals.sWorld + " (reason:" + rc + ").");
                _instance.Dispose();
                Globals.iInUniv = false;
                return;
            }
            else
            {
                m_Login.ReportProgress(0, "Entered world " + Globals.sWorld + ".");
                Globals.iInWorld = true;
            }

            // Commit the positioning and become visible
            m_Login.ReportProgress(0, "Changing position in world.");
            _instance.Attributes.MyX = Globals.iXPos;
            _instance.Attributes.MyY = Globals.iYPos;
            _instance.Attributes.MyZ = Globals.iZPos;
            _instance.Attributes.MyYaw = Globals.iYaw;
            _instance.Attributes.MyType = Globals.iAV;


            rc = _instance.StateChange();
            if (rc == Result.Success)
            {
                m_Login.ReportProgress(0, "Movement successful.");
            }
            else
            {
                m_Login.ReportProgress(0, "Movement aborted (reason: " + rc + ").");
            }


        }

        private void m_LoginProgress(object serder, ProgressChangedEventArgs e)
        {
            Status(e.UserState.ToString());
        }


        private void m_LoginCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Status("Error while performing background operation!");
            }

            if (Globals.iInWorld == true)
            {
                toolLoggedIn.BackColor = System.Drawing.Color.Red;
                toolLoggedIn.Text = "Logged In";
                butLogout.Enabled = true;
                Status("Logged in");
            }
            else
            {
                toolLoggedIn.BackColor = System.Drawing.Color.Green;
                toolLoggedIn.Text = "Logged Out";
                butLogin.Enabled = true;
                butConfig.Enabled = true;
                Status("Failed to log in");
            }

        }



        // Timer fires this method to perform AW_WAIT()
        private void aTimer_Tick(object source, EventArgs e)
        {
            if(Globals.iInWorld)
            {
                Utility.Wait(0);
            }
            
        }


        // Dispose of the bot instance when exits the main application form
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _instance.Dispose();
        }




        // The status update member
        private void Status(string sText)
        {
            if (lisStatus.Items.Count > 500)
            {
                lisStatus.Items.RemoveAt(0);
            }
            lisStatus.Items.Add(sText);
            lisStatus.TopIndex = lisStatus.Items.Count - 1;
        }


    }
}
