namespace WindowsFormsApp4.UI
{
    partial class VirusMap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VirusMap));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.TopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.Close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Mapsss = new GMap.NET.WindowsForms.GMapControl();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Panel1.SuspendLayout();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.Mapsss);
            this.guna2Panel1.Location = new System.Drawing.Point(18, 71);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1361, 679);
            this.guna2Panel1.TabIndex = 2;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.Transparent;
            this.TopBar.Controls.Add(this.label11);
            this.TopBar.Controls.Add(this.Close);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.ShadowDecoration.Parent = this.TopBar;
            this.TopBar.Size = new System.Drawing.Size(1397, 51);
            this.TopBar.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MADE Tommy Soft", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(11, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 30);
            this.label11.TabIndex = 5;
            this.label11.Text = "Map";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close.FillColor = System.Drawing.Color.Transparent;
            this.Close.HoverState.Parent = this.Close;
            this.Close.IconColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(1327, 0);
            this.Close.Name = "Close";
            this.Close.ShadowDecoration.Parent = this.Close;
            this.Close.Size = new System.Drawing.Size(70, 51);
            this.Close.TabIndex = 0;
            // 
            // Mapsss
            // 
            this.Mapsss.Bearing = 0F;
            this.Mapsss.CanDragMap = true;
            this.Mapsss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mapsss.EmptyTileColor = System.Drawing.Color.Navy;
            this.Mapsss.GrayScaleMode = false;
            this.Mapsss.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Mapsss.LevelsKeepInMemory = 5;
            this.Mapsss.Location = new System.Drawing.Point(0, 0);
            this.Mapsss.MarkersEnabled = true;
            this.Mapsss.MaxZoom = 2;
            this.Mapsss.MinZoom = 2;
            this.Mapsss.MouseWheelZoomEnabled = true;
            this.Mapsss.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Mapsss.Name = "Mapsss";
            this.Mapsss.NegativeMode = false;
            this.Mapsss.PolygonsEnabled = true;
            this.Mapsss.RetryLoadTile = 0;
            this.Mapsss.RoutesEnabled = true;
            this.Mapsss.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Mapsss.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Mapsss.ShowTileGridLines = false;
            this.Mapsss.Size = new System.Drawing.Size(1361, 679);
            this.Mapsss.TabIndex = 0;
            this.Mapsss.Zoom = 0D;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.TopBar;
            // 
            // VirusMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1397, 771);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VirusMap";
            this.Text = "Map";
            this.Load += new System.EventHandler(this.VirusMap_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel TopBar;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ControlBox Close;
        private GMap.NET.WindowsForms.GMapControl Mapsss;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}