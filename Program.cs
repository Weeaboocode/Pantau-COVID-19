using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.UI;

namespace WindowsFormsApp4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool connection = NetworkInterface.GetIsNetworkAvailable();
             void Notification(string pesan, ModernNotification.NotifTypeEnum tipe)
            {
                ModernNotification baru = new ModernNotification();
                baru.setNotif(pesan, tipe);
            }
            if (connection == true)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Notification("Selamat datang di Pantau COVID-19", ModernNotification.NotifTypeEnum.Default);
                Application.Run(new pantau());
            }
            else
            {
                MessageBox.Show("Kamu sedang tidak terkoneksi ke jaringan internet, silahkan periksa jaringan internet anda", "Pantau COVID-19 ingin mengatakan sesuatu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
