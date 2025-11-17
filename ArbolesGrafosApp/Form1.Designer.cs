namespace ArbolesGrafosApp
{
    partial class Form1
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAgregarEdificio = new System.Windows.Forms.TextBox();
            this.btnAgregarEdificio = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombreEdificio1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNombreEdificio2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDistancia = new System.Windows.Forms.TextBox();
            this.btnAgregarConexion = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCalcularDistancia1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCalcularDistancia2 = new System.Windows.Forms.TextBox();
            this.btnCalcularDistancia = new System.Windows.Forms.Button();
            this.lblCalcularDistancia = new System.Windows.Forms.Label();
            this.lblGrafo = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAgregarElemento = new System.Windows.Forms.TextBox();
            this.btnAgregarElemento = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblRamas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRecorrer = new System.Windows.Forms.ComboBox();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.lblRecorrer = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblGrafo);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnAgregarEdificio);
            this.tabPage2.Controls.Add(this.tbAgregarEdificio);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1334, 748);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rutas del Parque";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Agregar Edificio:";
            // 
            // tbAgregarEdificio
            // 
            this.tbAgregarEdificio.Location = new System.Drawing.Point(50, 71);
            this.tbAgregarEdificio.Name = "tbAgregarEdificio";
            this.tbAgregarEdificio.Size = new System.Drawing.Size(310, 31);
            this.tbAgregarEdificio.TabIndex = 1;
            // 
            // btnAgregarEdificio
            // 
            this.btnAgregarEdificio.Location = new System.Drawing.Point(380, 71);
            this.btnAgregarEdificio.Name = "btnAgregarEdificio";
            this.btnAgregarEdificio.Size = new System.Drawing.Size(150, 34);
            this.btnAgregarEdificio.TabIndex = 4;
            this.btnAgregarEdificio.Text = "Agregar";
            this.btnAgregarEdificio.UseVisualStyleBackColor = true;
            this.btnAgregarEdificio.Click += new System.EventHandler(this.btnAgregarEdificio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarConexion);
            this.groupBox1.Controls.Add(this.tbDistancia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbNombreEdificio2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbNombreEdificio1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(50, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 416);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Distancias";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nombre del edificio 1:";
            // 
            // tbNombreEdificio1
            // 
            this.tbNombreEdificio1.Location = new System.Drawing.Point(36, 77);
            this.tbNombreEdificio1.Name = "tbNombreEdificio1";
            this.tbNombreEdificio1.Size = new System.Drawing.Size(310, 31);
            this.tbNombreEdificio1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nombre del edificio 2:";
            // 
            // tbNombreEdificio2
            // 
            this.tbNombreEdificio2.Location = new System.Drawing.Point(36, 174);
            this.tbNombreEdificio2.Name = "tbNombreEdificio2";
            this.tbNombreEdificio2.Size = new System.Drawing.Size(310, 31);
            this.tbNombreEdificio2.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(396, 27);
            this.label7.TabIndex = 9;
            this.label7.Text = "Distancia entre edificios (mts):";
            // 
            // tbDistancia
            // 
            this.tbDistancia.Location = new System.Drawing.Point(36, 273);
            this.tbDistancia.Name = "tbDistancia";
            this.tbDistancia.Size = new System.Drawing.Size(310, 31);
            this.tbDistancia.TabIndex = 10;
            // 
            // btnAgregarConexion
            // 
            this.btnAgregarConexion.Location = new System.Drawing.Point(36, 350);
            this.btnAgregarConexion.Name = "btnAgregarConexion";
            this.btnAgregarConexion.Size = new System.Drawing.Size(310, 34);
            this.btnAgregarConexion.TabIndex = 11;
            this.btnAgregarConexion.Text = "Agregar Distancia";
            this.btnAgregarConexion.UseVisualStyleBackColor = true;
            this.btnAgregarConexion.Click += new System.EventHandler(this.btnAgregarConexion_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCalcularDistancia);
            this.groupBox2.Controls.Add(this.btnCalcularDistancia);
            this.groupBox2.Controls.Add(this.tbCalcularDistancia2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbCalcularDistancia1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(50, 567);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1240, 159);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calcular Distancia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 27);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nombre del edificio 1:";
            // 
            // tbCalcularDistancia1
            // 
            this.tbCalcularDistancia1.Location = new System.Drawing.Point(36, 84);
            this.tbCalcularDistancia1.Name = "tbCalcularDistancia1";
            this.tbCalcularDistancia1.Size = new System.Drawing.Size(271, 31);
            this.tbCalcularDistancia1.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(276, 27);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nombre del edificio 2:";
            // 
            // tbCalcularDistancia2
            // 
            this.tbCalcularDistancia2.Location = new System.Drawing.Point(364, 84);
            this.tbCalcularDistancia2.Name = "tbCalcularDistancia2";
            this.tbCalcularDistancia2.Size = new System.Drawing.Size(271, 31);
            this.tbCalcularDistancia2.TabIndex = 9;
            // 
            // btnCalcularDistancia
            // 
            this.btnCalcularDistancia.Location = new System.Drawing.Point(672, 54);
            this.btnCalcularDistancia.Name = "btnCalcularDistancia";
            this.btnCalcularDistancia.Size = new System.Drawing.Size(148, 72);
            this.btnCalcularDistancia.TabIndex = 10;
            this.btnCalcularDistancia.Text = "Calcular Distancia";
            this.btnCalcularDistancia.UseVisualStyleBackColor = true;
            this.btnCalcularDistancia.Click += new System.EventHandler(this.btnCalcularDistancia_Click);
            // 
            // lblCalcularDistancia
            // 
            this.lblCalcularDistancia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCalcularDistancia.Location = new System.Drawing.Point(845, 27);
            this.lblCalcularDistancia.Name = "lblCalcularDistancia";
            this.lblCalcularDistancia.Size = new System.Drawing.Size(372, 116);
            this.lblCalcularDistancia.TabIndex = 11;
            this.lblCalcularDistancia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrafo
            // 
            this.lblGrafo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrafo.Location = new System.Drawing.Point(579, 32);
            this.lblGrafo.Name = "lblGrafo";
            this.lblGrafo.Size = new System.Drawing.Size(711, 510);
            this.lblGrafo.TabIndex = 12;
            this.lblGrafo.Text = "Grafo";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblRecorrer);
            this.tabPage1.Controls.Add(this.btnRecorrer);
            this.tabPage1.Controls.Add(this.cbRecorrer);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblRamas);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.tbBuscar);
            this.tabPage1.Controls.Add(this.tbAgregarElemento);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnAgregarElemento);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tvArbol);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1334, 748);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Jerarquía Organizativa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(20, 19);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(461, 707);
            this.tvArbol.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregar elemento:";
            // 
            // tbAgregarElemento
            // 
            this.tbAgregarElemento.Location = new System.Drawing.Point(750, 28);
            this.tbAgregarElemento.Name = "tbAgregarElemento";
            this.tbAgregarElemento.Size = new System.Drawing.Size(372, 31);
            this.tbAgregarElemento.TabIndex = 2;
            // 
            // btnAgregarElemento
            // 
            this.btnAgregarElemento.Location = new System.Drawing.Point(1151, 28);
            this.btnAgregarElemento.Name = "btnAgregarElemento";
            this.btnAgregarElemento.Size = new System.Drawing.Size(150, 34);
            this.btnAgregarElemento.TabIndex = 3;
            this.btnAgregarElemento.Text = "Agregar";
            this.btnAgregarElemento.UseVisualStyleBackColor = true;
            this.btnAgregarElemento.Click += new System.EventHandler(this.btnAgregarElemento_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar elemento:";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(750, 130);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(372, 31);
            this.tbBuscar.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1151, 130);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 34);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1151, 188);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 34);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // lblRamas
            // 
            this.lblRamas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRamas.Location = new System.Drawing.Point(528, 257);
            this.lblRamas.Name = "lblRamas";
            this.lblRamas.Size = new System.Drawing.Size(773, 27);
            this.lblRamas.TabIndex = 8;
            this.lblRamas.Text = "Número de ramas:";
            this.lblRamas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Recorrer el arbol por:";
            // 
            // cbRecorrer
            // 
            this.cbRecorrer.FormattingEnabled = true;
            this.cbRecorrer.Items.AddRange(new object[] {
            "Pre-Orden",
            "Post-Orden",
            "Por Niveles"});
            this.cbRecorrer.Location = new System.Drawing.Point(824, 335);
            this.cbRecorrer.Name = "cbRecorrer";
            this.cbRecorrer.Size = new System.Drawing.Size(298, 35);
            this.cbRecorrer.TabIndex = 10;
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(1151, 339);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(150, 34);
            this.btnRecorrer.TabIndex = 11;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // lblRecorrer
            // 
            this.lblRecorrer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRecorrer.Location = new System.Drawing.Point(533, 422);
            this.lblRecorrer.Name = "lblRecorrer";
            this.lblRecorrer.Size = new System.Drawing.Size(768, 304);
            this.lblRecorrer.TabIndex = 12;
            this.lblRecorrer.Text = "Recorrido del arbol";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(22, 23);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1342, 788);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 839);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Innovatec";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblGrafo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCalcularDistancia;
        private System.Windows.Forms.Button btnCalcularDistancia;
        private System.Windows.Forms.TextBox tbCalcularDistancia2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCalcularDistancia1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarConexion;
        private System.Windows.Forms.TextBox tbDistancia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNombreEdificio2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNombreEdificio1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarEdificio;
        private System.Windows.Forms.TextBox tbAgregarEdificio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblRecorrer;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.ComboBox cbRecorrer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRamas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.TextBox tbAgregarElemento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarElemento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

