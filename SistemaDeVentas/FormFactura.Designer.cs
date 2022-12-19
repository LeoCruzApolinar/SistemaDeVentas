namespace SistemaDeVentas
{
    partial class FormFactura
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.IDLbL = new System.Windows.Forms.Label();
            this.LbLN = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.IDLbL);
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 37);
            this.panel1.TabIndex = 2;
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID:";
            // 
            // IDLbL
            // 
            this.IDLbL.AutoSize = true;
            this.IDLbL.ForeColor = System.Drawing.Color.White;
            this.IDLbL.Location = new System.Drawing.Point(36, 7);
            this.IDLbL.Name = "IDLbL";
            this.IDLbL.Size = new System.Drawing.Size(50, 20);
            this.IDLbL.TabIndex = 4;
            this.IDLbL.Text = "label2";
            // 
            // LbLN
            // 
            this.LbLN.AutoSize = true;
            this.LbLN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbLN.ForeColor = System.Drawing.Color.White;
            this.LbLN.Location = new System.Drawing.Point(3, 13);
            this.LbLN.Name = "LbLN";
            this.LbLN.Size = new System.Drawing.Size(65, 28);
            this.LbLN.TabIndex = 3;
            this.LbLN.Text = "label1";
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LbLN);
            this.Controls.Add(this.panel1);
            this.Name = "FormFactura";
            this.Size = new System.Drawing.Size(182, 80);
            this.Load += new System.EventHandler(this.FormFactura_Load);
            this.DoubleClick += new System.EventHandler(this.FormFactura_DoubleClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label IDLbL;
        private Label LbLN;
    }
}
