namespace Buscador3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResult01 = new System.Windows.Forms.Label();
            this.preview1 = new System.Windows.Forms.TextBox();
            this.clearResult01 = new System.Windows.Forms.Button();
            this.cargarCarpeta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResult02 = new System.Windows.Forms.Label();
            this.preview2 = new System.Windows.Forms.TextBox();
            this.clearResult02 = new System.Windows.Forms.Button();
            this.palabrasRepetidas = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblResult03 = new System.Windows.Forms.Label();
            this.lblPalabra = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.TextBox();
            this.preview3 = new System.Windows.Forms.TextBox();
            this.clearResult03 = new System.Windows.Forms.Button();
            this.buscarPalabra = new System.Windows.Forms.Button();
            this.WindowLoadFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResult01);
            this.groupBox1.Controls.Add(this.preview1);
            this.groupBox1.Controls.Add(this.clearResult01);
            this.groupBox1.Controls.Add(this.cargarCarpeta);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar etiquetas HTML";
            // 
            // lblResult01
            // 
            this.lblResult01.AutoSize = true;
            this.lblResult01.Location = new System.Drawing.Point(6, 60);
            this.lblResult01.Name = "lblResult01";
            this.lblResult01.Size = new System.Drawing.Size(64, 15);
            this.lblResult01.TabIndex = 3;
            this.lblResult01.Text = "Resultados";
            // 
            // preview1
            // 
            this.preview1.Location = new System.Drawing.Point(6, 78);
            this.preview1.Multiline = true;
            this.preview1.Name = "preview1";
            this.preview1.Size = new System.Drawing.Size(230, 264);
            this.preview1.TabIndex = 2;
            // 
            // clearResult01
            // 
            this.clearResult01.Location = new System.Drawing.Point(6, 348);
            this.clearResult01.Name = "clearResult01";
            this.clearResult01.Size = new System.Drawing.Size(230, 23);
            this.clearResult01.TabIndex = 1;
            this.clearResult01.Text = "Limpiar resultados";
            this.clearResult01.UseVisualStyleBackColor = true;
            this.clearResult01.Click += new System.EventHandler(this.clearResult01_Click);
            // 
            // cargarCarpeta
            // 
            this.cargarCarpeta.Location = new System.Drawing.Point(6, 22);
            this.cargarCarpeta.Name = "cargarCarpeta";
            this.cargarCarpeta.Size = new System.Drawing.Size(230, 23);
            this.cargarCarpeta.TabIndex = 0;
            this.cargarCarpeta.Text = "Cargar carpeta";
            this.cargarCarpeta.UseVisualStyleBackColor = true;
            this.cargarCarpeta.Click += new System.EventHandler(this.cargarCarpeta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblResult02);
            this.groupBox2.Controls.Add(this.preview2);
            this.groupBox2.Controls.Add(this.clearResult02);
            this.groupBox2.Controls.Add(this.palabrasRepetidas);
            this.groupBox2.Location = new System.Drawing.Point(278, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 386);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar palabras repetidas";
            // 
            // lblResult02
            // 
            this.lblResult02.AutoSize = true;
            this.lblResult02.Location = new System.Drawing.Point(6, 60);
            this.lblResult02.Name = "lblResult02";
            this.lblResult02.Size = new System.Drawing.Size(64, 15);
            this.lblResult02.TabIndex = 4;
            this.lblResult02.Text = "Resultados";
            // 
            // preview2
            // 
            this.preview2.Location = new System.Drawing.Point(6, 78);
            this.preview2.Multiline = true;
            this.preview2.Name = "preview2";
            this.preview2.Size = new System.Drawing.Size(230, 264);
            this.preview2.TabIndex = 3;
            // 
            // clearResult02
            // 
            this.clearResult02.Location = new System.Drawing.Point(6, 348);
            this.clearResult02.Name = "clearResult02";
            this.clearResult02.Size = new System.Drawing.Size(230, 23);
            this.clearResult02.TabIndex = 3;
            this.clearResult02.Text = "Limpiar resultados";
            this.clearResult02.UseVisualStyleBackColor = true;
            this.clearResult02.Click += new System.EventHandler(this.clearResult02_Click);
            // 
            // palabrasRepetidas
            // 
            this.palabrasRepetidas.Location = new System.Drawing.Point(6, 22);
            this.palabrasRepetidas.Name = "palabrasRepetidas";
            this.palabrasRepetidas.Size = new System.Drawing.Size(230, 23);
            this.palabrasRepetidas.TabIndex = 2;
            this.palabrasRepetidas.Text = "Buscar palabras repetidas";
            this.palabrasRepetidas.UseVisualStyleBackColor = true;
            this.palabrasRepetidas.Click += new System.EventHandler(this.palabrasRepetidas_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblResult03);
            this.groupBox3.Controls.Add(this.lblPalabra);
            this.groupBox3.Controls.Add(this.buscar);
            this.groupBox3.Controls.Add(this.preview3);
            this.groupBox3.Controls.Add(this.clearResult03);
            this.groupBox3.Controls.Add(this.buscarPalabra);
            this.groupBox3.Location = new System.Drawing.Point(546, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 386);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar palabra en archivos";
            // 
            // lblResult03
            // 
            this.lblResult03.AutoSize = true;
            this.lblResult03.Location = new System.Drawing.Point(6, 89);
            this.lblResult03.Name = "lblResult03";
            this.lblResult03.Size = new System.Drawing.Size(64, 15);
            this.lblResult03.TabIndex = 7;
            this.lblResult03.Text = "Resultados";
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Location = new System.Drawing.Point(6, 22);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(223, 15);
            this.lblPalabra.TabIndex = 5;
            this.lblPalabra.Text = "Escriba en el recuadro la palabra a buscar";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(6, 46);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(128, 23);
            this.buscar.TabIndex = 6;
            // 
            // preview3
            // 
            this.preview3.Location = new System.Drawing.Point(6, 107);
            this.preview3.Multiline = true;
            this.preview3.Name = "preview3";
            this.preview3.Size = new System.Drawing.Size(230, 232);
            this.preview3.TabIndex = 4;
            // 
            // clearResult03
            // 
            this.clearResult03.Location = new System.Drawing.Point(6, 348);
            this.clearResult03.Name = "clearResult03";
            this.clearResult03.Size = new System.Drawing.Size(230, 23);
            this.clearResult03.TabIndex = 5;
            this.clearResult03.Text = "Limpiar resultados";
            this.clearResult03.UseVisualStyleBackColor = true;
            this.clearResult03.Click += new System.EventHandler(this.clearResult03_Click);
            // 
            // buscarPalabra
            // 
            this.buscarPalabra.Location = new System.Drawing.Point(140, 46);
            this.buscarPalabra.Name = "buscarPalabra";
            this.buscarPalabra.Size = new System.Drawing.Size(96, 23);
            this.buscarPalabra.TabIndex = 4;
            this.buscarPalabra.Text = "Consultar";
            this.buscarPalabra.UseVisualStyleBackColor = true;
            this.buscarPalabra.Click += new System.EventHandler(this.buscarPalabra_Click);
            // 
            // WindowLoadFile
            // 
            this.WindowLoadFile.FileName = "WindowLoadFile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button clearResult01;
        private Button cargarCarpeta;
        private GroupBox groupBox2;
        private Button clearResult02;
        private Button palabrasRepetidas;
        private GroupBox groupBox3;
        private Button clearResult03;
        private Button buscarPalabra;
        private TextBox preview1;
        private TextBox preview2;
        private TextBox buscar;
        private TextBox preview3;
        private Label lblResult01;
        private Label lblResult02;
        private Label lblResult03;
        private Label lblPalabra;
        private OpenFileDialog WindowLoadFile;
    }
}