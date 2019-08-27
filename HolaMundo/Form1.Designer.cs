namespace HolaMundo
{
    partial class Form1
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnsuma = new System.Windows.Forms.Button();
            this.bntresta = new System.Windows.Forms.Button();
            this.bntmultiplicacion = new System.Windows.Forms.Button();
            this.bntdivision = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(245, 79);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(148, 20);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.label2.Location = new System.Drawing.Point(57, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Escriba su nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.label4.Location = new System.Drawing.Point(57, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Escriba un numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.label3.Location = new System.Drawing.Point(57, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Escriba un numero:";
            // 
            // txtnumero1
            // 
            this.txtnumero1.Location = new System.Drawing.Point(246, 144);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(148, 20);
            this.txtnumero1.TabIndex = 6;
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(246, 206);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(148, 20);
            this.txtnumero2.TabIndex = 7;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lbltotal.Location = new System.Drawing.Point(169, 288);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(68, 29);
            this.lbltotal.TabIndex = 8;
            this.lbltotal.Text = "Total";
            // 
            // btnsuma
            // 
            this.btnsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuma.Location = new System.Drawing.Point(432, 133);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(64, 64);
            this.btnsuma.TabIndex = 9;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.Btnsuma_Click);
            // 
            // bntresta
            // 
            this.bntresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntresta.Location = new System.Drawing.Point(512, 133);
            this.bntresta.Name = "bntresta";
            this.bntresta.Size = new System.Drawing.Size(64, 64);
            this.bntresta.TabIndex = 10;
            this.bntresta.Text = "-";
            this.bntresta.UseVisualStyleBackColor = true;
            this.bntresta.Click += new System.EventHandler(this.Bntresta_Click);
            // 
            // bntmultiplicacion
            // 
            this.bntmultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntmultiplicacion.Location = new System.Drawing.Point(432, 206);
            this.bntmultiplicacion.Name = "bntmultiplicacion";
            this.bntmultiplicacion.Size = new System.Drawing.Size(64, 64);
            this.bntmultiplicacion.TabIndex = 11;
            this.bntmultiplicacion.Text = "x";
            this.bntmultiplicacion.UseVisualStyleBackColor = true;
            this.bntmultiplicacion.Click += new System.EventHandler(this.Button3_Click);
            // 
            // bntdivision
            // 
            this.bntdivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntdivision.Location = new System.Drawing.Point(512, 206);
            this.bntdivision.Name = "bntdivision";
            this.bntdivision.Size = new System.Drawing.Size(64, 64);
            this.bntdivision.TabIndex = 12;
            this.bntdivision.Text = "/";
            this.bntdivision.UseVisualStyleBackColor = true;
            this.bntdivision.Click += new System.EventHandler(this.Bntdivision_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.button1.Location = new System.Drawing.Point(405, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Presioname";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bntdivision);
            this.Controls.Add(this.bntmultiplicacion);
            this.Controls.Add(this.bntresta);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button bntresta;
        private System.Windows.Forms.Button bntmultiplicacion;
        private System.Windows.Forms.Button bntdivision;
        private System.Windows.Forms.Button button1;
    }
}

