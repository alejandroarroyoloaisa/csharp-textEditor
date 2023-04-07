
namespace Alhambra_Text_Editor
{
    partial class Ayuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayuda));
            this.archivoBoton = new System.Windows.Forms.Button();
            this.editarBoton = new System.Windows.Forms.Button();
            this.herramientasBoton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textoAyuda = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // archivoBoton
            // 
            this.archivoBoton.Location = new System.Drawing.Point(30, 31);
            this.archivoBoton.Name = "archivoBoton";
            this.archivoBoton.Size = new System.Drawing.Size(116, 34);
            this.archivoBoton.TabIndex = 0;
            this.archivoBoton.Text = "Archivo";
            this.archivoBoton.UseVisualStyleBackColor = true;
            this.archivoBoton.Click += new System.EventHandler(this.archivoBoton_Click);
            // 
            // editarBoton
            // 
            this.editarBoton.Location = new System.Drawing.Point(290, 31);
            this.editarBoton.Name = "editarBoton";
            this.editarBoton.Size = new System.Drawing.Size(116, 34);
            this.editarBoton.TabIndex = 1;
            this.editarBoton.Text = "Editar";
            this.editarBoton.UseVisualStyleBackColor = true;
            this.editarBoton.Click += new System.EventHandler(this.editarBoton_Click);
            // 
            // herramientasBoton
            // 
            this.herramientasBoton.Location = new System.Drawing.Point(546, 31);
            this.herramientasBoton.Name = "herramientasBoton";
            this.herramientasBoton.Size = new System.Drawing.Size(116, 34);
            this.herramientasBoton.TabIndex = 2;
            this.herramientasBoton.Text = "Herramientas";
            this.herramientasBoton.UseVisualStyleBackColor = true;
            this.herramientasBoton.Click += new System.EventHandler(this.herramientasBoton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editarBoton);
            this.groupBox1.Controls.Add(this.herramientasBoton);
            this.groupBox1.Controls.Add(this.archivoBoton);
            this.groupBox1.Location = new System.Drawing.Point(23, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la funcionalidad sobre la que se requiere saber su funcionamiento:";
            // 
            // textoAyuda
            // 
            this.textoAyuda.AutoSize = true;
            this.textoAyuda.Location = new System.Drawing.Point(20, 131);
            this.textoAyuda.Name = "textoAyuda";
            this.textoAyuda.Size = new System.Drawing.Size(320, 17);
            this.textoAyuda.TabIndex = 4;
            this.textoAyuda.Text = "                                                                              ";
            // 
            // Ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 853);
            this.Controls.Add(this.textoAyuda);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(762, 900);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(762, 900);
            this.Name = "Ayuda";
            this.Text = "Ayuda | Información sobre la aplicación";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button archivoBoton;
        private System.Windows.Forms.Button editarBoton;
        private System.Windows.Forms.Button herramientasBoton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label textoAyuda;
    }
}