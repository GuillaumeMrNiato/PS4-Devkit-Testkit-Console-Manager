using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ORTMAPILib;

namespace PS4_Console_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static ORTMAPI TMAPI = new ORTMAPI();
        private static ITarget Target = null;

            public static void Init()
            {
                TMAPI.CheckCompatibility((uint)eCompatibleVersion.BuildVersion);
            }
            public static void AddTarget(string hostName)
            {
                TMAPI.AddTarget(hostName);
            }

            public static bool SelectTarget()
            {
                Target = TMAPI.ShowTargetPicker(0);
                if (Target == null)
                    return false;
                else
                    return true;
            }

            public static string GetSelectedTargetHostName()
            {
                return Target.HostName;
            }
            public static bool Connect()
            {
                if (Target == null)
                {
                    return false;
                }
                else
                {
                    if (Target.PowerStatus == ePowerStatus.POWER_STATUS_ON)
                    {
                        Target.Connect();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            public static string GetName()
            {
                return Target.Name;
            }
            public static string GetHostName()
            {
                return Target.HostName;
            }
            public static string GetFileServingRoot()
            {
                return Target.FileServingRoot;
            }
            public static string GetConnectionInfo()
            {
                return Target.ConnectionInfo;
            }
            public static uint GetConsoleCacheIndex()
            {
                return Target.ConsoleCacheIndex;
            }
            public static uint GetConsoleCacheSize()
            {
                return Target.ConsoleCacheSize;
            }
            public static uint GetExpiryTime()
            {
                return Target.ExpiryTime;
            }
            public static void PowerOn()
            {
                Target.PowerOn();
            }

            public static void PowerOff()
            {
                Target.PowerOff();
            }

            public static void Reboot()
            {
                Target.Reboot();
            }

            public static void DisconnectFromTarget()
            {
                Target.ForceDisconnect();
            }
            public static void ClearConsoleCache()
            {
                Target.ClearConsoleCache();
            }
            public static void ConnectForNotifications()
            {
                Target.ConnectForNotifications();
            }
            public static void DisconnectFromNotifications()
            {
                Target.DisconnectFromNotifications();
            }
            
        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void cButton1_Click(object sender, EventArgs e)
        {
            AddTarget(cTextBox1.Text);
            MessageBox.Show("Target " + cTextBox1.Text + " has been added");
            if (SelectTarget())
            {
                label4.Text = GetSelectedTargetHostName();
            }
            if (Connect())
            {
                MessageBox.Show("Connected to " + GetSelectedTargetHostName(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                label3.Text = GetName();
                label6.Text = GetHostName();
                label8.Text = GetFileServingRoot();
                label10.Text = GetConnectionInfo();
                numericUpDown1.Value = GetConsoleCacheIndex();
                numericUpDown2.Value = GetConsoleCacheSize();
                numericUpDown3.Value = GetExpiryTime();
                #region ShitPart
                if (Target.PowerStatus == ePowerStatus.POWER_STATUS_ON)
                {
                    label14.Text = "ON";
                }
                else
                {
                    label14.Text = "OFF";
                    
                }
                if (Target.CaseSensitiveFileServing == true)
                {
                    label18.Text = "ON";
                }
                else
                {
                    label18.Text = "OFF";

                }
                if (Target.Default == true)
                {
                    label16.Text = "ON";
                }
                else
                {
                    label16.Text = "OFF";

                }
                if (Target.IsBusy == true)
                {
                    label20.Text = "ON";
                }
                else
                {
                    label20.Text = "OFF";

                }
                #endregion
            }
            else
            {
                MessageBox.Show("Failed to Connect to " + GetSelectedTargetHostName(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cButton2_Click(object sender, EventArgs e)
        {
            PowerOff();

        }

        private void cButton3_Click(object sender, EventArgs e)
        {
            PowerOn();
        }

        private void cButton4_Click(object sender, EventArgs e)
        {
            Reboot();
            MessageBox.Show("Reboot done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cButton5_Click(object sender, EventArgs e)
        {
            DisconnectFromTarget();
            MessageBox.Show("PS4 Disconnected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cButton6_Click(object sender, EventArgs e)
        {
            ClearConsoleCache();
            MessageBox.Show("Clear Console Cache done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cButton7_Click(object sender, EventArgs e)
        {
            ConnectForNotifications();
            MessageBox.Show("Connect For Notifications done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cButton8_Click(object sender, EventArgs e)
        {
            DisconnectFromNotifications();
            MessageBox.Show("Disconnect from Notifications done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void cButton9_Click(object sender, EventArgs e)
        {
            Target.Delete();
            MessageBox.Show("Console Deleted From Neighboorhood !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
