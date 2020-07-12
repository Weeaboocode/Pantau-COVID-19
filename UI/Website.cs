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
    public partial class Website : Form
    {
        public Website()
        {
            InitializeComponent();
        }
        //NOTIFICATION
        public void Notification(string pesan, ModernNotification.NotifTypeEnum tipe)
        {
            ModernNotification baru = new ModernNotification();
            baru.setNotif(pesan, tipe);
        }
        private void TombolUNICEF_Click(object sender, EventArgs e)
        {
            Notification("Kamu mengunjungi website UNICEF Indonesia", ModernNotification.NotifTypeEnum.Default);
            System.Diagnostics.Process.Start("https://www.unicef.org/indonesia/id/coronavirus");
        }

        private void TombolKOMPAS_Click(object sender, EventArgs e)
        {
            Notification("Kamu mengunjungi website Kompas", ModernNotification.NotifTypeEnum.Default);
            System.Diagnostics.Process.Start("https://www.kompas.com/tren/read/2020/03/03/183500265/infografik-daftar-100-rumah-sakit-rujukan-penanganan-virus-corona");
        }

        private void TombolWHO_Click(object sender, EventArgs e)
        {
            Notification("Kamu mengunjungi website WHO", ModernNotification.NotifTypeEnum.Default);
            System.Diagnostics.Process.Start("https://www.who.int/emergencies/diseases/novel-coronavirus-2019/advice-for-public");
        }

        private void TombolKEMENKES_Click(object sender, EventArgs e)
        {
            Notification("Kamu mengunjungi website Kementrian Kesehatan Indonesia", ModernNotification.NotifTypeEnum.Default);
            System.Diagnostics.Process.Start("https://infeksiemerging.kemkes.go.id/");
        }

        private void Website_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }
    }
}
