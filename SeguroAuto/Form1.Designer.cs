namespace SeguroAuto
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.tbPatente = new System.Windows.Forms.TextBox();
            this.rbDenuncia = new System.Windows.Forms.RadioButton();
            this.rbNCliente = new System.Windows.Forms.RadioButton();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnAtenderDenuncias = new System.Windows.Forms.Button();
            this.btnAtenderCliente = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxTurnos = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.tbPatente);
            this.groupBox1.Controls.Add(this.rbDenuncia);
            this.groupBox1.Controls.Add(this.rbNCliente);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "1- Auto",
            "2- Moto",
            "3- Equipo de trabajo",
            "4- Bicicleta"});
            this.cbTipo.Location = new System.Drawing.Point(129, 87);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(127, 21);
            this.cbTipo.TabIndex = 10;
            this.cbTipo.Text = "Tipo";
            // 
            // tbPatente
            // 
            this.tbPatente.Location = new System.Drawing.Point(129, 52);
            this.tbPatente.Name = "tbPatente";
            this.tbPatente.Size = new System.Drawing.Size(127, 21);
            this.tbPatente.TabIndex = 6;
            this.tbPatente.Text = "Patente";
            // 
            // rbDenuncia
            // 
            this.rbDenuncia.AutoSize = true;
            this.rbDenuncia.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDenuncia.Location = new System.Drawing.Point(12, 53);
            this.rbDenuncia.Name = "rbDenuncia";
            this.rbDenuncia.Size = new System.Drawing.Size(85, 17);
            this.rbDenuncia.TabIndex = 6;
            this.rbDenuncia.TabStop = true;
            this.rbDenuncia.Text = "Denuncia";
            this.rbDenuncia.UseVisualStyleBackColor = true;
            // 
            // rbNCliente
            // 
            this.rbNCliente.AutoSize = true;
            this.rbNCliente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNCliente.Location = new System.Drawing.Point(12, 87);
            this.rbNCliente.Name = "rbNCliente";
            this.rbNCliente.Size = new System.Drawing.Size(115, 17);
            this.rbNCliente.TabIndex = 7;
            this.rbNCliente.TabStop = true;
            this.rbNCliente.Text = "Nuevo Cliente";
            this.rbNCliente.UseVisualStyleBackColor = true;
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(360, 90);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(100, 90);
            this.btnTicket.TabIndex = 0;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnAtenderDenuncias
            // 
            this.btnAtenderDenuncias.Location = new System.Drawing.Point(127, 429);
            this.btnAtenderDenuncias.Name = "btnAtenderDenuncias";
            this.btnAtenderDenuncias.Size = new System.Drawing.Size(100, 90);
            this.btnAtenderDenuncias.TabIndex = 1;
            this.btnAtenderDenuncias.Text = "Atender Denuncias";
            this.btnAtenderDenuncias.UseVisualStyleBackColor = true;
            this.btnAtenderDenuncias.Click += new System.EventHandler(this.btnAtenderDenuncias_Click);
            // 
            // btnAtenderCliente
            // 
            this.btnAtenderCliente.Location = new System.Drawing.Point(15, 429);
            this.btnAtenderCliente.Name = "btnAtenderCliente";
            this.btnAtenderCliente.Size = new System.Drawing.Size(100, 90);
            this.btnAtenderCliente.TabIndex = 2;
            this.btnAtenderCliente.Text = "Atender Nuevo Cliente";
            this.btnAtenderCliente.UseVisualStyleBackColor = true;
            this.btnAtenderCliente.Click += new System.EventHandler(this.btnAtenderCliente_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(360, 237);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 90);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Exportar Tickets";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(360, 333);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(100, 90);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Importar vehiculos";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(59, 31);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(249, 21);
            this.tbDni.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Turnos";
            // 
            // lbxTurnos
            // 
            this.lbxTurnos.FormattingEnabled = true;
            this.lbxTurnos.Location = new System.Drawing.Point(15, 237);
            this.lbxTurnos.Name = "lbxTurnos";
            this.lbxTurnos.Size = new System.Drawing.Size(325, 186);
            this.lbxTurnos.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 534);
            this.Controls.Add(this.lbxTurnos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.btnAtenderDenuncias);
            this.Controls.Add(this.btnAtenderCliente);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Aseguradora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDenuncia;
        private System.Windows.Forms.RadioButton rbNCliente;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnAtenderDenuncias;
        private System.Windows.Forms.Button btnAtenderCliente;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox tbPatente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxTurnos;
    }
}

