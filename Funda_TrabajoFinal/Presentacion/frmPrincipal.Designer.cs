namespace Presentacion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnRegObjEncontrado = new System.Windows.Forms.Button();
            this.btnRegDatosPropietario = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegObjEncontrado
            // 
            this.btnRegObjEncontrado.BackColor = System.Drawing.Color.Red;
            this.btnRegObjEncontrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegObjEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegObjEncontrado.ForeColor = System.Drawing.Color.White;
            this.btnRegObjEncontrado.Location = new System.Drawing.Point(122, 33);
            this.btnRegObjEncontrado.Name = "btnRegObjEncontrado";
            this.btnRegObjEncontrado.Size = new System.Drawing.Size(195, 31);
            this.btnRegObjEncontrado.TabIndex = 0;
            this.btnRegObjEncontrado.Text = "Personal de seguridad";
            this.btnRegObjEncontrado.UseVisualStyleBackColor = false;
            this.btnRegObjEncontrado.Click += new System.EventHandler(this.btnRegObjEncontrado_Click);
            // 
            // btnRegDatosPropietario
            // 
            this.btnRegDatosPropietario.BackColor = System.Drawing.Color.Red;
            this.btnRegDatosPropietario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegDatosPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegDatosPropietario.ForeColor = System.Drawing.Color.White;
            this.btnRegDatosPropietario.Location = new System.Drawing.Point(122, 71);
            this.btnRegDatosPropietario.Name = "btnRegDatosPropietario";
            this.btnRegDatosPropietario.Size = new System.Drawing.Size(195, 31);
            this.btnRegDatosPropietario.TabIndex = 1;
            this.btnRegDatosPropietario.Text = "Personal administrativo";
            this.btnRegDatosPropietario.UseVisualStyleBackColor = false;
            this.btnRegDatosPropietario.Click += new System.EventHandler(this.btnRegDatosPropietario_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnRegObjEncontrado);
            this.groupBox1.Controls.Add(this.btnRegDatosPropietario);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 124);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione tipo de usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.database1;
            this.pictureBox1.Location = new System.Drawing.Point(31, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(373, 143);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Gestión de objetos perdidos";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegObjEncontrado;
        private System.Windows.Forms.Button btnRegDatosPropietario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}