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

namespace Alhambra_Text_Editor
{
    public partial class Alhambra_Text_Editor : Form
    {
        string archivo;

        public Alhambra_Text_Editor()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Texto (.txt)|*.txt";

            if ( openFile.ShowDialog() == DialogResult.OK )
            {
                archivo = openFile.FileName;
                using (StreamReader sr = new StreamReader(archivo))
                {
                    mainTextBox.Text = sr.ReadToEnd();
                    nameOpFile.Text = archivo;
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Texto (.txt)|*.txt";

            if ( archivo != null)
            {
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.Write(mainTextBox.Text);
                }
            }
            else
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    archivo = saveFile.FileName;
                    nameOpFile.Text = archivo;

                    using (StreamWriter sw = new StreamWriter(archivo))
                    {
                        sw.Write(mainTextBox.Text);
                    }
                }
            }

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Clear();
            nameOpFile.Text = null;
            archivo = null;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            this.Dispose();
        }
    }
}
