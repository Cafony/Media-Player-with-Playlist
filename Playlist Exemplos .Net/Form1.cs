using AxWMPLib;
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

namespace Playlist_Exemplos.Net
{
    public partial class Form1 : Form
    {
        //==============Rohit Programming zone  ======================
        //======https://www.youtube.com/watch?v=tPCo5IC8mj8&t=1315s
        //=============================================================

        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";
        }

        OpenFileDialog ofd = new OpenFileDialog();
        List<string> str = new List<string>();

        private void buttonAddFiles_Click(object sender, EventArgs e)
        {
            ofd.Multiselect = true;
            ofd.Filter = "Media files|*.mp3;*.mp4";
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;


            foreach (string s in ofd.FileNames)
            {
                listBox_Playlist.Items.Add(Path.GetFullPath(s));
                str.Add(s);   // aqui adiciona á LIST str
            }
            
            

        }

        private void listBox_Playlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox_Playlist.Text;
            buttonAddFavorites.Enabled = true;            
            
        }

        private void buttonAddFavorites_Click(object sender, EventArgs e)
        {
            buttonAddFavorites.Enabled = true;
            if (listBox_Favorites.Items.Count >= 0)
            {
                listBox_Favorites.ForeColor = Color.Red;
            }
            listBox_Favorites.Items.Add(textBox1.Text);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // ver caminho do ficheiro: Gerenciador propiresdades- nome ficheiro - F4
             StreamWriter save = new StreamWriter(@"C:\Users\tozec\source\repos\Playlist Exemplos .Net\Playlist Exemplos .Net\Favorites.txt");
             foreach (var item in  listBox_Playlist.Items)
             {
             save.WriteLine(item.ToString());
             this.Refresh();
             
            }
            save.Close();
            MessageBox.Show("Playlist Gravada");
            //listBox_Favorites.Items.Clear();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {

        }

        private void listBox_Favorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox_Favorites.Text;          

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox_Playlist.Items.Clear();
            
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (listBox_Playlist.SelectedItems.Count != 0)
            {
                string file = listBox_Playlist.SelectedItem.ToString();
                axWindowsMediaPlayer1.URL = file;                
            }
            else
            {
                MessageBox.Show("Playlist Vazia");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) //Menu ABOUT
        {
            About form2 = new About();
            form2.ShowDialog();
        }

        private void radioButtonSave_CheckedChanged(object sender, EventArgs e) // Botao Save Playlist
        {
            StreamWriter save = new StreamWriter(@"C:\Users\tozec\source\repos\Playlist Exemplos .Net\Playlist Exemplos .Net\Playlist.txt");
            foreach (var item in listBox_Favorites.Items)
            {
                save.WriteLine(item.ToString());
                this.Refresh();
                save.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)  // Form Load executar inicio do programa
        {
            StreamReader read = new StreamReader(@"C:\Users\tozec\source\repos\Playlist Exemplos .Net\Playlist Exemplos .Net\Favorites.txt");
            string line;
            while ((line = read.ReadLine()) != null)
            {
                listBox_Playlist.Items.Add(line);
            }
            read.Close();
        }
    }
}
