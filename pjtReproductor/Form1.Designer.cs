namespace pjtReproductor
{
    partial class frmReproductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReproductor));
            this.lstLista = new System.Windows.Forms.ListBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.wmpVideos = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnSube = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideos)).BeginInit();
            this.SuspendLayout();
            // 
            // lstLista
            // 
            this.lstLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(598, 105);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(202, 342);
            this.lstLista.TabIndex = 4;
            this.lstLista.SelectedIndexChanged += new System.EventHandler(this.lstLista_SelectedIndexChanged);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.Location = new System.Drawing.Point(608, 23);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(180, 23);
            this.btnSeleccionar.TabIndex = 0;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // wmpVideos
            // 
            this.wmpVideos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wmpVideos.Enabled = true;
            this.wmpVideos.Location = new System.Drawing.Point(12, 12);
            this.wmpVideos.Name = "wmpVideos";
            this.wmpVideos.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideos.OcxState")));
            this.wmpVideos.Size = new System.Drawing.Size(577, 435);
            this.wmpVideos.TabIndex = 10;
            // 
            // btnBaja
            // 
            this.btnBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaja.Image = ((System.Drawing.Image)(resources.GetObject("btnBaja.Image")));
            this.btnBaja.Location = new System.Drawing.Point(701, 52);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(58, 43);
            this.btnBaja.TabIndex = 2;
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnSube
            // 
            this.btnSube.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSube.Image = ((System.Drawing.Image)(resources.GetObject("btnSube.Image")));
            this.btnSube.Location = new System.Drawing.Point(637, 52);
            this.btnSube.Name = "btnSube";
            this.btnSube.Size = new System.Drawing.Size(58, 43);
            this.btnSube.TabIndex = 1;
            this.btnSube.UseVisualStyleBackColor = true;
            this.btnSube.Click += new System.EventHandler(this.btnSube_Click);
            // 
            // frmReproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 465);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnSube);
            this.Controls.Add(this.wmpVideos);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lstLista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReproductor";
            this.Text = "Videos";
            this.Load += new System.EventHandler(this.frmReproductor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.Button btnSeleccionar;
        private AxWMPLib.AxWindowsMediaPlayer wmpVideos;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnSube;
    }
}

