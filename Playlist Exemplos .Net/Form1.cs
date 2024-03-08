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
            listBox_Favorites.Items.Add(textBox1.Text);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // ver caminho do ficheiro: Gerenciador propiresdades- nome ficheiro - F4
            StreamWriter save = new StreamWriter(@"C:\Users\tozec\source\repos\Playlist Exemplos .Net\Playlist Exemplos .Net\Favorites.txt");
            foreach (var item in listBox_Favorites.Items)
            {
                save.WriteLine(item.ToString());
                this.Refresh();
            }
            MessageBox.Show("Playlist Gravada");
            save.Close();
            listBox_Favorites.Items.Clear();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            StreamReader read = new StreamReader(@"C:\Users\tozec\source\repos\Playlist Exemplos .Net\Playlist Exemplos .Net\Favorites.txt");
            string line;
            while ((line = read.ReadLine()) != null)
            {
                listBox_Favorites.Items.Add(line);

            }
        }

        private void listBox_Favorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox_Favorites.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox_Favorites.Items.Clear();
        }
    }
}
