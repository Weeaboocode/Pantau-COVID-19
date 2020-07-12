using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
using WindowsFormsApp4.Url;

namespace WindowsFormsApp4.UI
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void Map_Load(object sender, EventArgs e)
        {
            IRequestWeb httpWebRequestHandler = new RequestWeb();
            //DATA IN GLOBAL
            var respon = GetGlobal(httpWebRequestHandler);
            var negara = JsonConvert.DeserializeObject<List<Model.Attributess>>(respon);
            Mapss.MapProvider = GMapProviders.GoogleMap;
            Mapss.DragButton = MouseButtons.Left;
            Mapss.ShowCenter = false;
            Mapss.Position = new PointLatLng(5.12596292, 114.18749839);
            Mapss.MinZoom = 1;
            Mapss.MaxZoom = 100;
            Mapss.Zoom = 4;
            foreach (var release in negara)
            {
                double lat = Convert.ToDouble(release.attributess.Latitude);
                double longtitude = Convert.ToDouble(release.attributess.Longitude);
                PointLatLng point = new PointLatLng(lat, longtitude);
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
                marker.ToolTipText = release.attributess.Negara;
                GMapOverlay gMap = new GMapOverlay("Markers");
                gMap.Markers.Add(marker);
                Mapss.Overlays.Add(gMap);
            }

            //SET SHADOW
            guna2ShadowForm1.SetShadowForm(this);
        }
        private static string GetGlobal(IRequestWeb requestHandler)
        {
            return requestHandler.GetReleases(APIUrl.URLGlobal);
        }
    }
}
