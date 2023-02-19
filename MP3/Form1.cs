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

namespace MP3
{
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
            track_volume.Value = 50;
        }

        string[] paths, files;

        private void Play_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player1.URL = paths[Play_list.SelectedIndex];
            Player1.Ctlcontrols.play();
        }

        private void p_bar_Click(object sender, EventArgs e)
        {

        }

        private void Player_Load(object sender, EventArgs e)
        {

        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            bt_pause.Enabled = false;
            Player1.Ctlcontrols.stop();
        }

        private void bt_pause_Click(object sender, EventArgs e)
        {
            Player1.Ctlcontrols.pause();
        }

        private void bt_play_Click(object sender, EventArgs e)
        {
            bt_pause.Enabled = true;
            Player1.Ctlcontrols.play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ( Player1.playState==WMPLib.WMPPlayState.wmppsPlaying)
            {
                p_bar.Maximum = (int)Player1.Ctlcontrols.currentItem.duration;
                p_bar.Value = (int)Player1.Ctlcontrols.currentPosition;
            }
            try
            {
                lb_start.Text = Player1.Ctlcontrols.currentPositionString;
                lb_end.Text = Player1.Ctlcontrols.currentItem.durationString.ToString();
            }
            catch 
            {

                
            }
            


        }

        private void track_volume_Scroll(object sender, EventArgs e)
        {
            Player1.settings.volume=track_volume.Value;
        }

        private void p_bar_MouseDown(object sender, MouseEventArgs e)
        {
            Player1.Ctlcontrols.currentPosition = Player1.currentMedia.duration * e.X / p_bar.Width;
        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect= true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (int x = 0; x < files.Length;x++)
                {
                    Play_list.Items.Add(files[x]);                
                }
            }
        }
    }
}
