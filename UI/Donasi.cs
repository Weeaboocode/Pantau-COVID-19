using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4.UI
{
    public partial class Donasi : Form
    {
        public Donasi()
        {
            InitializeComponent();
        }
        //NOTIFICATION
        public void Notification(string pesan, ModernNotification.NotifTypeEnum tipe)
        {
            ModernNotification baru = new ModernNotification();
            baru.setNotif(pesan, tipe);
        }
        private void Donasi_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void TombolKitabisa_Click(object sender, EventArgs e)
        {
            Notification("Kamu mengunjungi website Kitabisa", ModernNotification.NotifTypeEnum.Default);
            System.Diagnostics.Process.Start("https://kitabisa.com/campaign/melawancoronavirus");
        }

        private void TombolPMI_Click(object sender, EventArgs e)
        {
            Notification("Kamu mengunjungi website PMI (Palang Merah Indonesai)", ModernNotification.NotifTypeEnum.Default);
            System.Diagnostics.Process.Start("http://donasi.pmi.or.id/donations/bersamacegahcovid-19/");
        }

        private void TombolDompetDhuafa_Click(object sender, EventArgs e)
        {
            Notification("Kamu mengunjungi website Dompet Dhuafa", ModernNotification.NotifTypeEnum.Default);
            System.Diagnostics.Process.Start("https://donasi.dompetdhuafa.org/bersamalawancorona/");
        }
    }
}
