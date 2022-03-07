/*
    Partly based on this code (https://github.com/VitiaCatDragon/DiskHider)
    No License
*/

using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TweakUIX
{
    public partial class DriveLettersPageView : UserControl
    {
        //  decimal numbers that represents the drive letter
        [Flags]
        public enum VolumeId
        {
            Empty = 0,
            A = 1,
            B = 2,
            C = 4,
            D = 8,
            E = 16,
            F = 32,
            G = 64,
            H = 128,
            I = 256,
            J = 512,
            K = 1024,
            L = 2048,
            M = 4096,
            N = 8192,
            O = 16384,
            P = 32768,
            Q = 65536,
            R = 131072,
            S = 262144,
            T = 524288,
            U = 1048576,
            V = 2097152,
            W = 4194304,
            X = 8388608,
            Y = 16777216,
            Z = 33554432,
        }

        public DriveLettersPageView() => InitializeComponent();

        private void DriveLettersPageView_Load(object sender, EventArgs e)
        {
            try
            {
                RegistryKey keyName = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
                object value = keyName == null ? null : keyName.GetValue("NoDrives");
                VolumeId hiddenDrives = value == null ? VolumeId.Empty : (VolumeId)value;
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    string letter = drive.Name.Remove(1);
                    bool flag = hiddenDrives.HasFlag((VolumeId)Enum.Parse(hiddenDrives.GetType(), letter));
                    checkedListBox.Items.Add(letter, flag);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            RegistryKey keyName = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
            VolumeId drives = VolumeId.Empty;
            foreach (string letter in checkedListBox.CheckedItems)
            {
                drives |= (VolumeId)Enum.Parse(drives.GetType(), letter);
            }
            keyName.SetValue("NoDrives", (int)drives);
            if (MessageBox.Show("Do you want to apply changes to selected drives?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (Process p in Process.GetProcessesByName("explorer"))
                {
                    p.Kill();
                }
                Process.Start("explorer.exe");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<MainForm>().Single();
            mainForm.sc.Panel2.Controls.Clear();
            if (mainForm.INavPage != null) mainForm.sc.Panel2.Controls.Add(mainForm.INavPage);
        }
    }
}