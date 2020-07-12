namespace WindowsFormsApp4.UI
{
    partial class Map
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
            this.TopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Maximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Mapss = new GMap.NET.WindowsForms.GMapControl();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.Transparent;
            this.TopBar.Controls.Add(this.label11);
            this.TopBar.Controls.Add(this.Minimize);
            this.TopBar.Controls.Add(this.Maximize);
            this.TopBar.Controls.Add(this.Close);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.ShadowDecoration.Parent = this.TopBar;
            this.TopBar.Size = new System.Drawing.Size(1397, 51);
            this.TopBar.TabIndex = 1;
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
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize.FillColor = System.Drawing.Color.Transparent;
            this.Minimize.HoverState.Parent = this.Minimize;
            this.Minimize.IconColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(1187, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.ShadowDecoration.Parent = this.Minimize;
            this.Minimize.Size = new System.Drawing.Size(70, 51);
            this.Minimize.TabIndex = 2;
            // 
            // Maximize
            // 
            this.Maximize.BackColor = System.Drawing.Color.Transparent;
            this.Maximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.Maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Maximize.FillColor = System.Drawing.Color.Transparent;
            this.Maximize.HoverState.Parent = this.Maximize;
            this.Maximize.IconColor = System.Drawing.Color.White;
            this.Maximize.Location = new System.Drawing.Point(1257, 0);
            this.Maximize.Name = "Maximize";
            this.Maximize.ShadowDecoration.Parent = this.Maximize;
            this.Maximize.Size = new System.Drawing.Size(70, 51);
            this.Maximize.TabIndex = 1;
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
            // Mapss
            // 
            this.Mapss.Bearing = 0F;
            this.Mapss.CanDragMap = true;
            this.Mapss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mapss.EmptyTileColor = System.Drawing.Color.Navy;
            this.Mapss.GrayScaleMode = false;
            this.Mapss.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Mapss.LevelsKeepInMemory = 5;
            this.Mapss.Location = new System.Drawing.Point(0, 51);
            this.Mapss.MarkersEnabled = true;
            this.Mapss.MaxZoom = 2;
            this.Mapss.MinZoom = 2;
            this.Mapss.MouseWheelZoomEnabled = true;
            this.Mapss.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Mapss.Name = "Mapss";
            this.Mapss.NegativeMode = false;
            this.Mapss.PolygonsEnabled = true;
            this.Mapss.RetryLoadTile = 0;
            this.Mapss.RoutesEnabled = true;
            this.Mapss.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Mapss.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Mapss.ShowTileGridLines = false;
            this.Mapss.Size = new System.Drawing.Size(1397, 720);
            this.Mapss.TabIndex = 2;
            this.Mapss.Zoom = 0D;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.TopBar;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1397, 771);
            this.Controls.Add(this.Mapss);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Map";
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Map_Load);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel TopBar;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ControlBox Minimize;
        private Guna.UI2.WinForms.Guna2ControlBox Maximize;
        private Guna.UI2.WinForms.Guna2ControlBox Close;
        private GMap.NET.WindowsForms.GMapControl Mapss;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}