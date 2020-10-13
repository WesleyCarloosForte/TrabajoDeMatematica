namespace Vista
{
    partial class Biseccion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtecuacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.dtresultado = new System.Windows.Forms.DataGridView();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txterrorminimo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkintervalos = new System.Windows.Forms.CheckBox();
            this.pnlintervalos = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lbliteraciones = new System.Windows.Forms.Label();
            this.Intervalos = new System.Windows.Forms.GroupBox();
            this.lblb = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtresultado)).BeginInit();
            this.pnlintervalos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Intervalos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtecuacion
            // 
            this.txtecuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtecuacion.Location = new System.Drawing.Point(13, 41);
            this.txtecuacion.Name = "txtecuacion";
            this.txtecuacion.Size = new System.Drawing.Size(242, 30);
            this.txtecuacion.TabIndex = 0;
            this.txtecuacion.TextChanged += new System.EventHandler(this.txtecuacion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ecuacion :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.btncalcular.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.ForeColor = System.Drawing.Color.White;
            this.btncalcular.Location = new System.Drawing.Point(29, 59);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(132, 65);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Caclcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // dtresultado
            // 
            this.dtresultado.AllowUserToAddRows = false;
            this.dtresultado.BackgroundColor = System.Drawing.Color.White;
            this.dtresultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtresultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtresultado.GridColor = System.Drawing.Color.White;
            this.dtresultado.Location = new System.Drawing.Point(0, 0);
            this.dtresultado.Name = "dtresultado";
            this.dtresultado.RowHeadersVisible = false;
            this.dtresultado.RowHeadersWidth = 51;
            this.dtresultado.RowTemplate.Height = 24;
            this.dtresultado.Size = new System.Drawing.Size(1119, 459);
            this.dtresultado.TabIndex = 5;
            // 
            // txta
            // 
            this.txta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txta.Location = new System.Drawing.Point(59, 11);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(164, 30);
            this.txta.TabIndex = 6;
            // 
            // txtb
            // 
            this.txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb.Location = new System.Drawing.Point(300, 11);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(136, 30);
            this.txtb.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "B:";
            // 
            // txterrorminimo
            // 
            this.txterrorminimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txterrorminimo.Location = new System.Drawing.Point(291, 41);
            this.txterrorminimo.Name = "txterrorminimo";
            this.txterrorminimo.Size = new System.Drawing.Size(158, 30);
            this.txterrorminimo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Error Minimo:";
            // 
            // chkintervalos
            // 
            this.chkintervalos.AutoSize = true;
            this.chkintervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkintervalos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(193)))));
            this.chkintervalos.Location = new System.Drawing.Point(50, 100);
            this.chkintervalos.Name = "chkintervalos";
            this.chkintervalos.Size = new System.Drawing.Size(299, 24);
            this.chkintervalos.TabIndex = 12;
            this.chkintervalos.Text = "Deseas ingresar los intervalos?";
            this.chkintervalos.UseVisualStyleBackColor = true;
            this.chkintervalos.CheckedChanged += new System.EventHandler(this.chkintervalos_CheckedChanged);
            // 
            // pnlintervalos
            // 
            this.pnlintervalos.Controls.Add(this.txta);
            this.pnlintervalos.Controls.Add(this.txtb);
            this.pnlintervalos.Controls.Add(this.label2);
            this.pnlintervalos.Controls.Add(this.label3);
            this.pnlintervalos.Location = new System.Drawing.Point(13, 141);
            this.pnlintervalos.Name = "pnlintervalos";
            this.pnlintervalos.Size = new System.Drawing.Size(464, 53);
            this.pnlintervalos.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlintervalos);
            this.panel1.Controls.Add(this.chkintervalos);
            this.panel1.Controls.Add(this.txtecuacion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txterrorminimo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 226);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btncalcular);
            this.panel2.Location = new System.Drawing.Point(570, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 139);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(99)))), ((int)(((byte)(138)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1119, 41);
            this.panel3.TabIndex = 15;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Metodo de la biseccion";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1082, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(37, 41);
            this.panel4.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(67)))), ((int)(((byte)(56)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(7, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtresultado);
            this.panel5.Location = new System.Drawing.Point(0, 267);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1119, 459);
            this.panel5.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Controls.Add(this.Intervalos);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 605);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1119, 211);
            this.panel6.TabIndex = 17;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblerror);
            this.groupBox2.Controls.Add(this.lblX);
            this.groupBox2.Controls.Add(this.lbliteraciones);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(530, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 168);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado Final";
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.Location = new System.Drawing.Point(47, 38);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            this.lblerror.TabIndex = 8;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(47, 114);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(0, 17);
            this.lblX.TabIndex = 5;
            this.lblX.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbliteraciones
            // 
            this.lbliteraciones.AutoSize = true;
            this.lbliteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliteraciones.Location = new System.Drawing.Point(47, 77);
            this.lbliteraciones.Name = "lbliteraciones";
            this.lbliteraciones.Size = new System.Drawing.Size(0, 17);
            this.lbliteraciones.TabIndex = 4;
            this.lbliteraciones.Click += new System.EventHandler(this.label7_Click);
            // 
            // Intervalos
            // 
            this.Intervalos.Controls.Add(this.lblb);
            this.Intervalos.Controls.Add(this.lbla);
            this.Intervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intervalos.Location = new System.Drawing.Point(30, 31);
            this.Intervalos.Name = "Intervalos";
            this.Intervalos.Size = new System.Drawing.Size(389, 168);
            this.Intervalos.TabIndex = 9;
            this.Intervalos.TabStop = false;
            this.Intervalos.Text = "Intervalos";
            this.Intervalos.Enter += new System.EventHandler(this.Intervalos_Enter);
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.Location = new System.Drawing.Point(59, 90);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(0, 17);
            this.lblb.TabIndex = 7;
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.Location = new System.Drawing.Point(59, 47);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(0, 17);
            this.lbla.TabIndex = 6;
            // 
            // Biseccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 816);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Biseccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtresultado)).EndInit();
            this.pnlintervalos.ResumeLayout(false);
            this.pnlintervalos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Intervalos.ResumeLayout(false);
            this.Intervalos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtecuacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.DataGridView dtresultado;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txterrorminimo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkintervalos;
        private System.Windows.Forms.Panel pnlintervalos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lbliteraciones;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.GroupBox Intervalos;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

