using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace Alhambra_Text_Editor
{
    public partial class Alhambra_Text_Editor : Form
    {
        string archivo;

        bool letras = true;
        bool palabras = false;
        bool parrafos = false;

        public Alhambra_Text_Editor()
        {
            InitializeComponent();
            fontSizeTextBox.Text = "8,25";

            int x = this.Size.Width-15;
            int y = this.Size.Height-115;
            mainTextBox.Size = new Size(x, y);
        }

        public void actualizarLetras()
        {

        }

        public void actualizarPalabras()
        {

        }

        public void actualizarParrafos()
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Texto (.txt)|*.txt";

            if ( openFile.ShowDialog() == DialogResult.OK )
            {
                archivo = openFile.FileName;
                //using (StreamReader sr = new StreamReader(archivo))
                //{
                //    mainTextBox.Text = sr.ReadToEnd();
                //    nameOpFile.Text = archivo;
                //}

                mainTextBox.LoadFile(archivo, RichTextBoxStreamType.RichText);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Texto (.txt)|*.txt";

            if ( archivo != null)
            {
                //using (StreamWriter sw = new StreamWriter(archivo))
                //{
                //    sw.Write(mainTextBox.Text);
                //}
                mainTextBox.SaveFile(saveFile.FileName, RichTextBoxStreamType.RichText);
            }
            else
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    archivo = saveFile.FileName;
                    nameOpFile.Text = archivo;

                    //using (StreamWriter sw = new StreamWriter(archivo))
                    //{
                    //    sw.Write(mainTextBox.Text);
                    //}
                    mainTextBox.SaveFile(archivo, RichTextBoxStreamType.RichText);
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

        private void toolStripNewButton_Click(object sender, EventArgs e)
        {
            nuevoToolStripMenuItem_Click(sender, e);
        }

        private void toolStripOpenButton_Click(object sender, EventArgs e)
        {
            abrirToolStripMenuItem_Click(sender, e);
        }

        private void toolStripSaveButton_Click(object sender, EventArgs e)
        {
            guardarToolStripMenuItem_Click(sender, e);
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Cut();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Paste();
        }

        private void toolStripCutButton_Click(object sender, EventArgs e)
        {
            cortarToolStripMenuItem_Click(sender, e);
        }

        private void toolStripCopyButton_Click(object sender, EventArgs e)
        {
            copiarToolStripMenuItem_Click(sender, e);
        }

        private void toolStripPasteButton_Click(object sender, EventArgs e)
        {
            pegarToolStripMenuItem_Click(sender, e);
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Undo();
        }

        private void rehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Redo();
        }

        private void toolStripUndoButton_Click(object sender, EventArgs e)
        {
            deshacerToolStripMenuItem_Click(sender, e);
        }

        private void toolStripRedoButton_Click(object sender, EventArgs e)
        {
            rehacerToolStripMenuItem_Click(sender, e);
        }


        private void negritaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( !mainTextBox.SelectionFont.Bold )
            {
                mainTextBox.SelectionFont = new Font(mainTextBox.SelectionFont.FontFamily, mainTextBox.SelectionFont.Size, mainTextBox.SelectionFont.Style | FontStyle.Bold);
            }
            else
            {
                mainTextBox.SelectionFont = new Font(mainTextBox.SelectionFont.FontFamily, mainTextBox.SelectionFont.Size, mainTextBox.SelectionFont.Style & ~FontStyle.Bold);
            }
        }

        private void cursivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!mainTextBox.SelectionFont.Italic)
            {
                mainTextBox.SelectionFont = new Font(mainTextBox.SelectionFont.FontFamily, mainTextBox.SelectionFont.Size, mainTextBox.SelectionFont.Style | FontStyle.Italic);
            }
            else
            {
                mainTextBox.SelectionFont = new Font(mainTextBox.SelectionFont.FontFamily, mainTextBox.SelectionFont.Size, mainTextBox.SelectionFont.Style & ~FontStyle.Italic);
            }
        }

        private void subrayadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!mainTextBox.SelectionFont.Underline)
            {
                mainTextBox.SelectionFont = new Font(mainTextBox.SelectionFont.FontFamily, mainTextBox.SelectionFont.Size, mainTextBox.SelectionFont.Style | FontStyle.Underline);
            }
            else
            {
                mainTextBox.SelectionFont = new Font(mainTextBox.SelectionFont.FontFamily, mainTextBox.SelectionFont.Size, mainTextBox.SelectionFont.Style & ~FontStyle.Underline);
            }
        }

        private void tachadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!mainTextBox.SelectionFont.Strikeout)
            {
                mainTextBox.SelectionFont = new Font(mainTextBox.SelectionFont.FontFamily, mainTextBox.SelectionFont.Size, mainTextBox.SelectionFont.Style | FontStyle.Strikeout);
            }
            else
            {
                mainTextBox.SelectionFont = new Font(mainTextBox.SelectionFont.FontFamily, mainTextBox.SelectionFont.Size, mainTextBox.SelectionFont.Style & ~FontStyle.Strikeout);
            }
        }

        private void toolStripBoldButton_Click(object sender, EventArgs e)
        {
            negritaToolStripMenuItem_Click(sender, e);
        }

        private void toolStripItalicButton_Click(object sender, EventArgs e)
        {
            cursivaToolStripMenuItem_Click(sender, e);
        }

        private void toolStripUnderlineButton_Click(object sender, EventArgs e)
        {
            subrayadoToolStripMenuItem_Click(sender, e);
        }

        private void toolStripStrikeButton_Click(object sender, EventArgs e)
        {
            tachadoToolStripMenuItem_Click(sender, e);
        }

        private void aumentarTamañoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.SelectionFont = new Font(mainTextBox.SelectionFont.FontFamily, mainTextBox.SelectionFont.Size + 1, mainTextBox.SelectionFont.Style);
            fontSizeTextBox.Text = mainTextBox.SelectionFont.Size.ToString();
        }

        private void disminuirTamañoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.SelectionFont = new Font(mainTextBox.SelectionFont.FontFamily, mainTextBox.SelectionFont.Size - 1, mainTextBox.SelectionFont.Style);
            fontSizeTextBox.Text = mainTextBox.SelectionFont.Size.ToString();
        }

        private void toolStripUpScaleButton_Click(object sender, EventArgs e)
        {
            aumentarTamañoToolStripMenuItem_Click(sender, e);
        }


        private void toolStripDownScaleButton_Click(object sender, EventArgs e)
        {
            disminuirTamañoToolStripMenuItem_Click(sender, e);
        }

        private void colorDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( fontColorDialog.ShowDialog() == DialogResult.OK)
            {
                mainTextBox.SelectionColor = fontColorDialog.Color;
            }
        }


        private void alinearALaIzquierdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void alinearALaDerechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripAlignLeftButton_Click(object sender, EventArgs e)
        {
            alinearALaIzquierdaToolStripMenuItem_Click(sender, e);
        }

        private void toolStripCenterTextButton_Click(object sender, EventArgs e)
        {
            centrarToolStripMenuItem_Click(sender, e);
        }

        private void toolStripAlignRightButton_Click(object sender, EventArgs e)
        {
            alinearALaDerechaToolStripMenuItem_Click(sender, e);
        }

        private void cambiarTipografíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fuenteDialogo = new FontDialog();

            fuenteDialogo.Font = mainTextBox.SelectionFont;

            if (fuenteDialogo.ShowDialog() != DialogResult.Cancel)
            {

                mainTextBox.SelectionFont = fuenteDialogo.Font;
            }
        }


        private void toolStripTypoButton_Click(object sender, EventArgs e)
        {
            cambiarTipografíaToolStripMenuItem_Click(sender, e);
        }

        private void toolStripColorButton_Click(object sender, EventArgs e)
        {
            colorDeFuenteToolStripMenuItem_Click(sender, e);
        }

        private void Alhambra_Text_Editor_Resize(object sender, EventArgs e)
        {

            int x = this.Size.Width-15;
            int y = this.Size.Height-115;
            mainTextBox.Size = new Size(x, y);
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.SelectAll();
        }


        private void letrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            palabrasToolStripMenuItem.Checked = false;
            párrafosToolStripMenuItem.Checked = false;
            textoContador.Text = "Letras";

            int contadorLetras = 0;
            for (int i = 0; i < mainTextBox.Text.Length; i++)
            {
                if (mainTextBox.Text[i] != ' ' && mainTextBox.Text[i] != '\n' && mainTextBox.Text[i] != '\r')
                {
                    contadorLetras++;
                }
            }

            contador.Text = "" + contadorLetras;
        }

        private void palabrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            letrasToolStripMenuItem.Checked = false;
            párrafosToolStripMenuItem.Checked = false;
            textoContador.Text = "Palabras";

            char[] delimiters = new char[] { ' ', '\r', '\n' };
            contador.Text = "" + mainTextBox.Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        private void párrafosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            palabrasToolStripMenuItem.Checked = false;
            letrasToolStripMenuItem.Checked = false;
            textoContador.Text = "Párrafos";


            char[] delimiters = new char[] { '\n' };
            contador.Text = "" + mainTextBox.Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        private void mainTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(textoContador.Text != "Letras" && textoContador.Text != "Palabras" && textoContador.Text != "Párrafos")
            {
                letrasToolStripMenuItem_Click(sender, e);
            }else if (textoContador.Text == "Letras")
            {
                letrasToolStripMenuItem_Click(sender, e);
            }
            else if (textoContador.Text == "Palabras")
            {
                palabrasToolStripMenuItem_Click(sender, e);
            }
            else if (textoContador.Text == "Párrafos")
            {
                párrafosToolStripMenuItem_Click(sender, e);
            }
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda ventanaAyuda = new Ayuda();
            ventanaAyuda.Show();
        }
    }
}
