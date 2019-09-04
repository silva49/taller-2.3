namespace taller2._3
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
            this.btnazul = new System.Windows.Forms.Button();
            this.btnrojo = new System.Windows.Forms.Button();
            this.btnverde = new System.Windows.Forms.Button();
            this.btnamarillo = new System.Windows.Forms.Button();
            this.btnsalmon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnazul
            // 
            this.btnazul.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnazul.Location = new System.Drawing.Point(76, 65);
            this.btnazul.Name = "btnazul";
            this.btnazul.Size = new System.Drawing.Size(102, 51);
            this.btnazul.TabIndex = 0;
            this.btnazul.Text = "azul";
            this.btnazul.UseVisualStyleBackColor = true;
            this.btnazul.Click += new System.EventHandler(this.btnazul_Click);
            // 
            // btnrojo
            // 
            this.btnrojo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrojo.Location = new System.Drawing.Point(322, 76);
            this.btnrojo.Name = "btnrojo";
            this.btnrojo.Size = new System.Drawing.Size(102, 46);
            this.btnrojo.TabIndex = 1;
            this.btnrojo.Text = "rojo";
            this.btnrojo.UseVisualStyleBackColor = true;
            this.btnrojo.Click += new System.EventHandler(this.btnrojo_Click);
            // 
            // btnverde
            // 
            this.btnverde.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverde.Location = new System.Drawing.Point(617, 74);
            this.btnverde.Name = "btnverde";
            this.btnverde.Size = new System.Drawing.Size(101, 48);
            this.btnverde.TabIndex = 2;
            this.btnverde.Text = "verde";
            this.btnverde.UseVisualStyleBackColor = true;
            this.btnverde.Click += new System.EventHandler(this.btnverde_Click);
            // 
            // btnamarillo
            // 
            this.btnamarillo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnamarillo.Location = new System.Drawing.Point(199, 274);
            this.btnamarillo.Name = "btnamarillo";
            this.btnamarillo.Size = new System.Drawing.Size(119, 47);
            this.btnamarillo.TabIndex = 3;
            this.btnamarillo.Text = "amarillo";
            this.btnamarillo.UseVisualStyleBackColor = true;
            this.btnamarillo.Click += new System.EventHandler(this.btnamarillo_Click);
            // 
            // btnsalmon
            // 
            this.btnsalmon.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalmon.Location = new System.Drawing.Point(491, 267);
            this.btnsalmon.Name = "btnsalmon";
            this.btnsalmon.Size = new System.Drawing.Size(133, 54);
            this.btnsalmon.TabIndex = 4;
            this.btnsalmon.Text = "salmon";
            this.btnsalmon.UseVisualStyleBackColor = true;
            this.btnsalmon.Click += new System.EventHandler(this.btncafe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalmon);
            this.Controls.Add(this.btnamarillo);
            this.Controls.Add(this.btnverde);
            this.Controls.Add(this.btnrojo);
            this.Controls.Add(this.btnazul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnazul;
        private System.Windows.Forms.Button btnrojo;
        private System.Windows.Forms.Button btnverde;
        private System.Windows.Forms.Button btnamarillo;
        private System.Windows.Forms.Button btnsalmon;
    }
}

