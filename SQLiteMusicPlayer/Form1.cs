using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using System.Data.SQLite;
using MetroFramework;
using NAudio.Wave;

namespace SQLiteMusicPlayer
{
    public partial class Form1 : MetroForm
    {
        SQLiteConnection con = null;
        String file = "";

        public Form1()
        {
            InitializeComponent();
            if (!checkDatabase())
            {
                createDatabase();
            }
            else
            {
                loadSongs();
            }
        }

        private void loadSongs()
        {
            try
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("SELECT rowid,artist,title FROM song", con);
                SQLiteDataReader reader = cmd.ExecuteReader();
                listView1.Items.Clear();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    String artist = reader.GetString(1);
                    String title = reader.GetString(2);
                    ListViewItem item = new ListViewItem(new String[] { "" + id, artist, title });
                    listView1.Items.Add(item);
                } 
                con.Close();
            }
            catch (Exception)
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private bool checkDatabase()
        {
            try
            {
                con = new SQLiteConnection("Data Source=db.sqlite;Version=3;");
                con.Open();
                SQLiteCommand cmd1 = new SQLiteCommand("SELECT rowid,artist,title,data FROM song", con);
                SQLiteDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    String artist = reader.GetString(1);
                    String title = reader.GetString(2);
                    SQLiteCommand cmd2 = new SQLiteCommand("SELECT data FROM song WHERE rowid="+id, con);
                    byte[] data = (byte[])cmd2.ExecuteScalar();
                }
                reader.Close();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                if (con != null)
                {
                    con.Close();
                }
                return false;
            }
        }

        private void createDatabase()
        {
            try
            {
                SQLiteConnection.CreateFile("db.sqlite");
                SQLiteConnection con = new SQLiteConnection("Data Source=db.sqlite;Version=3;");
                con.Open();
                String query = "CREATE TABLE SONG(ARTIST VARCHAR(50),TITLE VARCHAR(50),DATA BLOB);";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
            }
        }

        private void browser_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Audio Files|*.mp3;*.wav;";
            dialog.Title = "Please select an audio file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                file = dialog.FileName;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                String ar = artist.Text;
                String tl = title.Text;
                if (ar.Trim().Equals("") || tl.Trim().Equals(""))
                {
                    MetroMessageBox.Show(this, "Some fields are missing", "Fields missing");
                }
                else if (!file.Trim().EndsWith("mp3") && !file.Trim().EndsWith("wav"))
                {
                    MetroMessageBox.Show(this, "Please select a valid audio file", "Invalid file");
                }
                else
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand("INSERT INTO song (artist,title,data) VALUES (@artist,@title,@data)", con);
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@artist", ar);
                    cmd.Parameters.AddWithValue("@title", tl);
                    cmd.Parameters.AddWithValue("@data", File.ReadAllBytes(file));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    loadSongs();
                    artist.Text = "";
                    title.Text = "";
                }
            }
            catch (Exception)
            {
                if(con!=null)
                {
                    con.Close();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    MetroMessageBox.Show(this, "Please select a song to play", "No song selected");
                }
                else
                {
                    int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                    String artist = listView1.SelectedItems[0].SubItems[1].Text;
                    String title = listView1.SelectedItems[0].SubItems[2].Text;
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT data FROM song WHERE rowid=" + id, con);
                    byte[] data = (byte[])cmd.ExecuteScalar();
                    con.Close();
                    audio1.playSong(artist, title, data);
                }
            }
            catch (Exception)
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    MetroMessageBox.Show(this, "Please select a song to delete", "No song selected");
                }
                else
                {
                    DialogResult dr = MetroMessageBox.Show(this, "Are you sure you want to delete the song?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                        con.Open();
                        SQLiteCommand cmd = new SQLiteCommand("DELETE FROM song WHERE rowid=" + id + ";" + "VACUUM", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        loadSongs();
                    }
                }
            }
            catch (Exception)
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
    }


}
