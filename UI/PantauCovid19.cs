using Guna.UI2.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Connection;
using WindowsFormsApp4.UI;
using WindowsFormsApp4.Url;

namespace WindowsFormsApp4
{
    public partial class pantau : Form
    {
        public pantau()
        {
            InitializeComponent();
        }

        //NOTIFICATION
        public void Notification(string pesan, ModernNotification.NotifTypeEnum tipe)
        {
            ModernNotification baru = new ModernNotification();
            baru.setNotif(pesan, tipe);
        }

        //SCROLLBAR DATAGRIDVIEW
        private Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper IndoHelper;
        private Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper GlobalHelper;

        //FORM
        
        
        private void PantauCovid_Load(object sender, EventArgs e)
        {
            IRequestWeb httpWebRequestHandler = new RequestWeb();

            //SCROLLBAR
            IndoHelper = new Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper(DataIndonesia, VerticalDataProvinsi, true);
            GlobalHelper = new Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper(DataGlobal, VerticalDataGlobal, true);


            //DATA IN INDONESIA
            var Respon = GetIndonesia(httpWebRequestHandler);
            var indonesia = JsonConvert.DeserializeObject<List<Model.DataIndonesia>>(Respon);
            foreach (var release in indonesia)
            {
                label7.Text = release.Positif;
                label8.Text = release.Sembuh;
                label9.Text = release.Meninggal;
            }


            //DATA PROVINSI IN INDONESIA
            var response = GetProvinsi(httpWebRequestHandler);
            var propinsi = JsonConvert.DeserializeObject<List<Model.Attributes>>(response);
            int i = 1;
            foreach (var release in propinsi)
            {
                int index = DataIndonesia.Rows.Add();

                DataIndonesia.Rows[index].Cells[0].Value = i++.ToString();
                DataIndonesia.Rows[index].Cells[1].Value = release.attribute.Provinsi;
                DataIndonesia.Rows[index].Cells[2].Value = release.attribute.Positif;
                DataIndonesia.Rows[index].Cells[3].Value = release.attribute.Sembuh;
                DataIndonesia.Rows[index].Cells[4].Value = release.attribute.Meninggal;
            }

            //DATA IN GLOBAL
            var respon = GetGlobal(httpWebRequestHandler);
            var negara = JsonConvert.DeserializeObject<List<Model.Attributess>>(respon);
            int j = 1;
            foreach (var release in negara)
            {
                int outdex = DataGlobal.Rows.Add();

                DataGlobal.Rows[outdex].Cells[0].Value = j++.ToString();
                DataGlobal.Rows[outdex].Cells[1].Value = release.attributess.Negara;
                DataGlobal.Rows[outdex].Cells[2].Value = release.attributess.Positif;
                DataGlobal.Rows[outdex].Cells[3].Value = release.attributess.Sembuh;
                DataGlobal.Rows[outdex].Cells[4].Value = release.attributess.Meninggal;
            }

            //SETSHADOW FORM
            guna2ShadowForm1.SetShadowForm(this);
        }
        private static string GetIndonesia(IRequestWeb requestHandler)
        {
            return requestHandler.GetReleases(APIUrl.URLIndonesia);
        }
        private static string GetProvinsi(IRequestWeb requestHandler)
        {
            return requestHandler.GetReleases(APIUrl.URLProvinsi);
        }
        private static string GetGlobal(IRequestWeb requestHandler)
        {
            return requestHandler.GetReleases(APIUrl.URLGlobal);
        }

        private void TombolHotline_Click(object sender, EventArgs e)
        {
            Hotline UC = new Hotline();
            //CHECKING WHETHER THE FORM HAS BEEN OPENED OR NOT YET
            if (Application.OpenForms["Hotline"] == null)
            {
                Notification("Kamu membuka form Hotline Indonesia", ModernNotification.NotifTypeEnum.Default);
                UC.Show();
            }
            else
            {
                Notification("Form sudah terbuka, jangan dibuka lagi", ModernNotification.NotifTypeEnum.Default);
            }
        }

        private void TombolWebsite_Click(object sender, EventArgs e)
        {
            Website AC = new Website();
            //CHECKING WHETHER THE FORM HAS BEEN OPENED OR NOT YET
            if (Application.OpenForms["Website"] == null)
            {
                Notification("Kamu membuka form Kumpulan Website Tentang Covid-19", ModernNotification.NotifTypeEnum.Default);
                AC.Show();
            }
            else
            {
                Notification("Form sudah terbuka, jangan dibuka lagi", ModernNotification.NotifTypeEnum.Default);
            }
        }

        private void TombolDonasi_Click(object sender, EventArgs e)
        {
            Donasi EC = new Donasi();
            //CHECKING WHETHER THE FORM HAS BEEN OPENED OR NOT YET
            if (Application.OpenForms["Donasi"] == null)
            {
                Notification("Kamu membuka form Donasi", ModernNotification.NotifTypeEnum.Default);
                EC.Show();
            }
            else
            {
                Notification("Form sudah terbuka, jangan dibuka lagi", ModernNotification.NotifTypeEnum.Default);
            }
        }

        private void TombolAbout_Click(object sender, EventArgs e)
        {
            Tentang OC = new Tentang();
            //CHECKING WHETHER THE FORM HAS BEEN OPENED OR NOT YET
            if (Application.OpenForms["Tentang"] == null)
            {
                Notification("Kamu membuka form Tentang Aplikasi ini", ModernNotification.NotifTypeEnum.Default);
                OC.Show();
            }
            else
            {
                Notification("Form sudah terbuka, jangan dibuka lagi", ModernNotification.NotifTypeEnum.Default);
            }
        }

        private void TombolMap_Click(object sender, EventArgs e)
        {
            VirusMap IC = new VirusMap();
            //CHECKING WHETHER THE FORM HAS BEEN OPENED OR NOT YET
            if (Application.OpenForms["VirusMap"] == null)
            {
                Notification("Kamu membuka form Map", ModernNotification.NotifTypeEnum.Default);
                IC.Show();
            }
            else
            {
                Notification("Form sudah terbuka, jangan dibuka lagi", ModernNotification.NotifTypeEnum.Default);
            }
        }
    }
}
