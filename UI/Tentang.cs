using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Connection;
using WindowsFormsApp4.Url;

namespace WindowsFormsApp4.UI
{
    public partial class Tentang : Form
    {
        public Tentang()
        {
            InitializeComponent();
        }

        private void Tentang_Load(object sender, EventArgs e)
        {
            IRequestWeb httpWebRequestHandler = new RequestWeb();
            Tanggal.Text = DateTime.Now.ToString("dd MMMM yyyy");
            //DATA IN GLOBAL
            var respon = GetGlobal(httpWebRequestHandler);
            var negara = JsonConvert.DeserializeObject<List<Model.Attributess>>(respon);
            foreach (var release in negara)
            {
                System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                long date = long.Parse(release.attributess.Tanggal);
                Tanggal.Text = dtDateTime.AddMilliseconds(date).ToLocalTime().ToString("dddd, dd MMMM yyyy");
            }

            //SET SHADOW FORM
            guna2ShadowForm1.SetShadowForm(this);
        }
        private static string GetGlobal(IRequestWeb requestHandler)
        {
            return requestHandler.GetReleases(APIUrl.URLGlobal);
        }
    }
}
