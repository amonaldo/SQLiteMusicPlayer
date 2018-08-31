using System;
using System.Windows.Forms;
using NAudio.Wave;
using System.IO;

namespace SQLiteMusicPlayer
{
    public partial class Audio : UserControl
    {
        BlockAlignReductionStream stream = null;
        DirectSoundOut output = null;

        public Audio()
        {
            InitializeComponent();
        }

        public void playSong(String artist, String song, byte[] audio)
        {
            dispose();
            this.artist.Text = truncate(artist, 15); ;
            this.song.Text = truncate(song, 15);
            try
            {
                WaveStream pcm = new WaveChannel32(new NAudio.Wave.WaveFileReader(new MemoryStream(audio)));
                stream = new BlockAlignReductionStream(pcm);
            }
            catch (Exception)
            {
                WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(new MemoryStream(audio)));
                stream = new BlockAlignReductionStream(pcm);
            }
            output = new NAudio.Wave.DirectSoundOut();
            output.Init(stream);
            output.Play();
        }

        private void dispose()
        {
            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing)
                {
                    output.Stop();
                }
                output.Dispose();
                output = null;
            }
            if (stream != null)
            {
                stream.Dispose();
                stream = null;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing)
                {
                    output.Pause();
                }
                else if (output.PlaybackState == PlaybackState.Paused)
                {
                    output.Play();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing)
                {
                    output.Pause();
                }
                else if (output.PlaybackState == PlaybackState.Paused)
                {
                    output.Play();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (output != null)
            {
                output.Stop();
            }
        }

        private string truncate(string value, int maxChars)
        {
            return value.Length <= maxChars ? value : value.Substring(0, maxChars) + "...";
        }
    }
}
