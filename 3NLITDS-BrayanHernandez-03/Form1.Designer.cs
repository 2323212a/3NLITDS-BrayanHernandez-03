namespace _3NLITDS_BrayanHernandez_03
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
            this.txtcelsius = new System.Windows.Forms.TextBox();
            this.txtfaren = new System.Windows.Forms.TextBox();
            this.txtkelvin = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.lblcelsius = new System.Windows.Forms.Label();
            this.lblfaren = new System.Windows.Forms.Label();
            this.lblkelvin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcelsius
            // 
            this.txtcelsius.Location = new System.Drawing.Point(98, 50);
            this.txtcelsius.Name = "txtcelsius";
            this.txtcelsius.Size = new System.Drawing.Size(100, 22);
            this.txtcelsius.TabIndex = 0;
            this.txtcelsius.TextChanged += new System.EventHandler(this.txtcelsius_TextChanged);
            // 
            // txtfaren
            // 
            this.txtfaren.Location = new System.Drawing.Point(321, 50);
            this.txtfaren.Name = "txtfaren";
            this.txtfaren.Size = new System.Drawing.Size(100, 22);
            this.txtfaren.TabIndex = 1;
            this.txtfaren.TextChanged += new System.EventHandler(this.txtfaren_TextChanged);
            // 
            // txtkelvin
            // 
            this.txtkelvin.Location = new System.Drawing.Point(557, 50);
            this.txtkelvin.Name = "txtkelvin";
            this.txtkelvin.Size = new System.Drawing.Size(100, 22);
            this.txtkelvin.TabIndex = 2;
            this.txtkelvin.TextChanged += new System.EventHandler(this.txtkelvin_TextChanged);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(51, 272);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(80, 44);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(214, 271);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(80, 45);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(685, 375);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(92, 46);
            this.btncerrar.TabIndex = 5;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // lblcelsius
            // 
            this.lblcelsius.AutoSize = true;
            this.lblcelsius.Location = new System.Drawing.Point(43, 53);
            this.lblcelsius.Name = "lblcelsius";
            this.lblcelsius.Size = new System.Drawing.Size(54, 16);
            this.lblcelsius.TabIndex = 6;
            this.lblcelsius.Text = "Celsius:";
            // 
            // lblfaren
            // 
            this.lblfaren.AutoSize = true;
            this.lblfaren.Location = new System.Drawing.Point(249, 53);
            this.lblfaren.Name = "lblfaren";
            this.lblfaren.Size = new System.Drawing.Size(66, 16);
            this.lblfaren.TabIndex = 7;
            this.lblfaren.Text = "Farenheit:";
            this.lblfaren.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblkelvin
            // 
            this.lblkelvin.AutoSize = true;
            this.lblkelvin.Location = new System.Drawing.Point(507, 56);
            this.lblkelvin.Name = "lblkelvin";
            this.lblkelvin.Size = new System.Drawing.Size(46, 16);
            this.lblkelvin.TabIndex = 8;
            this.lblkelvin.Text = "Kelvin:";
            this.lblkelvin.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblkelvin);
            this.Controls.Add(this.lblfaren);
            this.Controls.Add(this.lblcelsius);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtkelvin);
            this.Controls.Add(this.txtfaren);
            this.Controls.Add(this.txtcelsius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcelsius;
        private System.Windows.Forms.TextBox txtfaren;
        private System.Windows.Forms.TextBox txtkelvin;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Label lblcelsius;
        private System.Windows.Forms.Label lblfaren;
        private System.Windows.Forms.Label lblkelvin;
    }
}

