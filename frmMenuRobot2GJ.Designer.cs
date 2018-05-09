namespace Robot2GJBA11w
{
    partial class frmMenuRobot2GJ
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
            this.groupMenuDesarrollo = new System.Windows.Forms.GroupBox();
            this.btoMenuModeloDeDatos = new System.Windows.Forms.Button();
            this.groupMenuDesarrollo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMenuDesarrollo
            // 
            this.groupMenuDesarrollo.Controls.Add(this.btoMenuModeloDeDatos);
            this.groupMenuDesarrollo.ForeColor = System.Drawing.SystemColors.Control;
            this.groupMenuDesarrollo.Location = new System.Drawing.Point(12, 12);
            this.groupMenuDesarrollo.Name = "groupMenuDesarrollo";
            this.groupMenuDesarrollo.Size = new System.Drawing.Size(247, 509);
            this.groupMenuDesarrollo.TabIndex = 0;
            this.groupMenuDesarrollo.TabStop = false;
            this.groupMenuDesarrollo.Text = "Desarrollo";
            // 
            // btoMenuModeloDeDatos
            // 
            this.btoMenuModeloDeDatos.BackColor = System.Drawing.Color.DimGray;
            this.btoMenuModeloDeDatos.Location = new System.Drawing.Point(6, 19);
            this.btoMenuModeloDeDatos.Name = "btoMenuModeloDeDatos";
            this.btoMenuModeloDeDatos.Size = new System.Drawing.Size(235, 39);
            this.btoMenuModeloDeDatos.TabIndex = 0;
            this.btoMenuModeloDeDatos.Text = "Modelo De Datos";
            this.btoMenuModeloDeDatos.UseVisualStyleBackColor = false;
            this.btoMenuModeloDeDatos.Click += new System.EventHandler(this.btoMenuModeloDeDatos_Click);
            // 
            // frmMenuRobot2GJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(271, 533);
            this.Controls.Add(this.groupMenuDesarrollo);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMenuRobot2GJ";
            this.Text = "Menu";
            this.groupMenuDesarrollo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMenuDesarrollo;
        private System.Windows.Forms.Button btoMenuModeloDeDatos;
    }
}

