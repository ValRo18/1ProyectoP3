namespace _1ProyectoP3
{
    partial class EnvioYRePaquetes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Enviar = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.codUnidad = new System.Windows.Forms.ComboBox();
            this.codTerminal = new System.Windows.Forms.ComboBox();
            this.codEnco = new System.Windows.Forms.TextBox();
            this.dirigida = new System.Windows.Forms.TextBox();
            this.pago = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Recibidos = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.NumEncomienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Enviar.SuspendLayout();
            this.Recibidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Enviar);
            this.tabControl1.Controls.Add(this.Recibidos);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(728, 559);
            this.tabControl1.TabIndex = 0;
            // 
            // Enviar
            // 
            this.Enviar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Enviar.Controls.Add(this.button1);
            this.Enviar.Controls.Add(this.codUnidad);
            this.Enviar.Controls.Add(this.codTerminal);
            this.Enviar.Controls.Add(this.codEnco);
            this.Enviar.Controls.Add(this.dirigida);
            this.Enviar.Controls.Add(this.pago);
            this.Enviar.Controls.Add(this.label7);
            this.Enviar.Controls.Add(this.label6);
            this.Enviar.Controls.Add(this.label5);
            this.Enviar.Controls.Add(this.label4);
            this.Enviar.Controls.Add(this.label1);
            this.Enviar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Enviar.Location = new System.Drawing.Point(4, 25);
            this.Enviar.Name = "Enviar";
            this.Enviar.Padding = new System.Windows.Forms.Padding(3);
            this.Enviar.Size = new System.Drawing.Size(720, 530);
            this.Enviar.TabIndex = 0;
            this.Enviar.Text = "Enviar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(612, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // codUnidad
            // 
            this.codUnidad.FormattingEnabled = true;
            this.codUnidad.Location = new System.Drawing.Point(233, 277);
            this.codUnidad.Name = "codUnidad";
            this.codUnidad.Size = new System.Drawing.Size(157, 24);
            this.codUnidad.TabIndex = 13;
            // 
            // codTerminal
            // 
            this.codTerminal.FormattingEnabled = true;
            this.codTerminal.Location = new System.Drawing.Point(233, 222);
            this.codTerminal.Name = "codTerminal";
            this.codTerminal.Size = new System.Drawing.Size(157, 24);
            this.codTerminal.TabIndex = 12;
            // 
            // codEnco
            // 
            this.codEnco.Location = new System.Drawing.Point(233, 124);
            this.codEnco.Name = "codEnco";
            this.codEnco.Size = new System.Drawing.Size(157, 22);
            this.codEnco.TabIndex = 11;
            // 
            // dirigida
            // 
            this.dirigida.Location = new System.Drawing.Point(233, 179);
            this.dirigida.Name = "dirigida";
            this.dirigida.Size = new System.Drawing.Size(157, 22);
            this.dirigida.TabIndex = 10;
            // 
            // pago
            // 
            this.pago.Location = new System.Drawing.Point(233, 328);
            this.pago.Name = "pago";
            this.pago.Size = new System.Drawing.Size(157, 22);
            this.pago.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(23, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total a pagar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(23, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cod-Unidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(23, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cod-Terminal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(23, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Encomienda dirigida a # :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(23, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Encomienda:";
            // 
            // Recibidos
            // 
            this.Recibidos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Recibidos.Controls.Add(this.button4);
            this.Recibidos.Controls.Add(this.button3);
            this.Recibidos.Controls.Add(this.numCedula);
            this.Recibidos.Controls.Add(this.label2);
            this.Recibidos.Controls.Add(this.tabla);
            this.Recibidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recibidos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Recibidos.Location = new System.Drawing.Point(4, 25);
            this.Recibidos.Name = "Recibidos";
            this.Recibidos.Padding = new System.Windows.Forms.Padding(3);
            this.Recibidos.Size = new System.Drawing.Size(720, 530);
            this.Recibidos.TabIndex = 1;
            this.Recibidos.Text = "Recibidos";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(592, 488);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "Entregar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(500, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Buscar Paquete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // numCedula
            // 
            this.numCedula.Location = new System.Drawing.Point(500, 136);
            this.numCedula.Name = "numCedula";
            this.numCedula.Size = new System.Drawing.Size(175, 24);
            this.numCedula.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de cedula\r\n de la persona que retira:";
            // 
            // tabla
            // 
            this.tabla.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumEncomienda,
            this.Fecha,
            this.Persona,
            this.Estado});
            this.tabla.Location = new System.Drawing.Point(6, 51);
            this.tabla.Name = "tabla";
            this.tabla.RowHeadersWidth = 51;
            this.tabla.RowTemplate.Height = 24;
            this.tabla.Size = new System.Drawing.Size(471, 358);
            this.tabla.TabIndex = 0;
            // 
            // NumEncomienda
            // 
            this.NumEncomienda.HeaderText = "NumEncomienda";
            this.NumEncomienda.MinimumWidth = 6;
            this.NumEncomienda.Name = "NumEncomienda";
            this.NumEncomienda.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // Persona
            // 
            this.Persona.HeaderText = "Persona";
            this.Persona.MinimumWidth = 6;
            this.Persona.Name = "Persona";
            this.Persona.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(733, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // EnvioYRePaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Name = "EnvioYRePaquetes";
            this.Text = "EnvioYRePaquetes";
            this.tabControl1.ResumeLayout(false);
            this.Enviar.ResumeLayout(false);
            this.Enviar.PerformLayout();
            this.Recibidos.ResumeLayout(false);
            this.Recibidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Enviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Recibidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox codUnidad;
        private System.Windows.Forms.ComboBox codTerminal;
        private System.Windows.Forms.TextBox codEnco;
        private System.Windows.Forms.TextBox dirigida;
        private System.Windows.Forms.TextBox pago;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox numCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumEncomienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}