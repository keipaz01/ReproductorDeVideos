using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjtReproductor
{
    public partial class frmReproductor : Form
    {
        public frmReproductor()
        {
            InitializeComponent();
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "WMV|*.wmv|WAV|*.wav|MP3|*.mp3|MP4|*.mp4|MKV|*.mkv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    List<pjtReproductor> files = new List<pjtReproductor>();
                    foreach(string fileName in ofd.FileNames)
                    {
                        FileInfo fi = new FileInfo(fileName);
                        files.Add(new pjtReproductor() { FileName = Path.GetFileNameWithoutExtension(fi.FullName), Path = fi.FullName });
                    }
                    lstLista.DataSource = files;
                    
                }
            }
        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            pjtReproductor file = lstLista.SelectedItem as pjtReproductor;
            if (file != null)
            {
                wmpVideos.URL = file.Path;
                wmpVideos.Ctlcontrols.play();
            }
        }

        private void frmReproductor_Load(object sender, EventArgs e)
        {
            lstLista.ValueMember = "Path";
            lstLista.DisplayMember = "FileName";
        }

        private void btnSube_Click(object sender, EventArgs e)
        {
            lstLista.SelectedIndex--;
            return;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            lstLista.SelectedIndex++;
            return;
        }
    }
}
