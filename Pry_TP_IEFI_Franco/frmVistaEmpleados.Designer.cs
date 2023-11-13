namespace Pry_TP_IEFI_Franco
{
    partial class frmVistaEmpleados
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
            this.tvEmpleados = new System.Windows.Forms.TreeView();
            this.rtbContenido = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tvEmpleados
            // 
            this.tvEmpleados.Location = new System.Drawing.Point(13, 13);
            this.tvEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.tvEmpleados.Name = "tvEmpleados";
            this.tvEmpleados.Size = new System.Drawing.Size(390, 196);
            this.tvEmpleados.TabIndex = 1;
            this.tvEmpleados.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvEmpleados_AfterSelect);
            // 
            // rtbContenido
            // 
            this.rtbContenido.Location = new System.Drawing.Point(13, 233);
            this.rtbContenido.Margin = new System.Windows.Forms.Padding(4);
            this.rtbContenido.Name = "rtbContenido";
            this.rtbContenido.ReadOnly = true;
            this.rtbContenido.Size = new System.Drawing.Size(774, 220);
            this.rtbContenido.TabIndex = 2;
            this.rtbContenido.Text = "";
            // 
            // frmVistaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.rtbContenido);
            this.Controls.Add(this.tvEmpleados);
            this.Name = "frmVistaEmpleados";
            this.Text = "Vista_Empleados";
            this.Load += new System.EventHandler(this.Vista_Empleados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvEmpleados;
        private System.Windows.Forms.RichTextBox rtbContenido;
    }
}