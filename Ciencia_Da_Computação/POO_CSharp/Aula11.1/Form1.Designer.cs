namespace Aula11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbEstado = new ComboBox();
            cmbMunicipios = new ComboBox();
            SuspendLayout();
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(93, 89);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(210, 28);
            cmbEstado.TabIndex = 0;
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged;
            // 
            // cmbMunicipios
            // 
            cmbMunicipios.FormattingEnabled = true;
            cmbMunicipios.Location = new Point(460, 92);
            cmbMunicipios.Name = "cmbMunicipios";
            cmbMunicipios.Size = new Size(151, 28);
            cmbMunicipios.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbMunicipios);
            Controls.Add(cmbEstado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbEstado;
        private ComboBox cmbMunicipios;
    }
}