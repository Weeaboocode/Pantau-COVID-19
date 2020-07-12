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
    public partial class ModernNotification : Form
    {
        public ModernNotification()
        {
            InitializeComponent();
        }
        private int x, y;
        public enum NotifTypeEnum
        {
            Default
        }
        public void setNotif(string pesan, ModernNotification.NotifTypeEnum tipe)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                ModernNotification f = (ModernNotification)Application.OpenForms[fname];

                if (f == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            switch (tipe)
            {
                case ModernNotification.NotifTypeEnum.Default:
                    this.BackColor = Color.FromArgb(47, 52, 56);
                    break;
            }
            this.label2.Text = pesan;
            this.Show();
            this.Show();
            this.action = actionEnum.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }
        public enum actionEnum
        {
            wait,
            start,
            close
        }
        private ModernNotification.actionEnum action;

        private void ModernNotification_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void IconClose_Click(object sender, EventArgs e)
        {
            this.timer1.Interval = 1;
            this.action = ModernNotification.actionEnum.close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case ModernNotification.actionEnum.wait:
                    this.timer1.Interval = 5000;
                    this.action = ModernNotification.actionEnum.close;
                    break;
                case ModernNotification.actionEnum.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            this.action = ModernNotification.actionEnum.wait;
                        }
                    }
                    break;
                case ModernNotification.actionEnum.close:
                    this.timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }
    }
}
