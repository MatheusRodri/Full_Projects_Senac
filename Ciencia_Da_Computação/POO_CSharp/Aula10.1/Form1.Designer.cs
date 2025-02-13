namespace Aula10
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
            label1 = new Label();
            cmbProdutos = new ComboBox();
            label2 = new Label();
            cmbFuncionarios = new ComboBox();
            label3 = new Label();
            txtKg = new TextBox();
            button1 = new Button();
            button2 = new Button();
            lstCarrinho = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 22);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Produtos";
            // 
            // cmbProdutos
            // 
            cmbProdutos.FormattingEnabled = true;
            cmbProdutos.Location = new Point(98, 22);
            cmbProdutos.Margin = new Padding(3, 2, 3, 2);
            cmbProdutos.Name = "cmbProdutos";
            cmbProdutos.Size = new Size(133, 23);
            cmbProdutos.TabIndex = 1;
            cmbProdutos.SelectedIndexChanged += cmbProdutos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 22);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Funcionario";
            // 
            // cmbFuncionarios
            // 
            cmbFuncionarios.FormattingEnabled = true;
            cmbFuncionarios.Location = new Point(339, 20);
            cmbFuncionarios.Margin = new Padding(3, 2, 3, 2);
            cmbFuncionarios.Name = "cmbFuncionarios";
            cmbFuncionarios.Size = new Size(133, 23);
            cmbFuncionarios.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 57);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 4;
            label3.Text = "Kg";
            // 
            // txtKg
            // 
            txtKg.Location = new Point(98, 57);
            txtKg.Margin = new Padding(3, 2, 3, 2);
            txtKg.Name = "txtKg";
            txtKg.Size = new Size(133, 23);
            txtKg.TabIndex = 5;
           
            // 
            // button1
            // 
            button1.Location = new Point(258, 56);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 6;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(388, 54);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 7;
            button2.Text = "Remover";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lstCarrinho
            // 
            lstCarrinho.FormattingEnabled = true;
            lstCarrinho.ItemHeight = 15;
            lstCarrinho.Location = new Point(19, 86);
            lstCarrinho.Margin = new Padding(3, 2, 3, 2);
            lstCarrinho.Name = "lstCarrinho";
            lstCarrinho.Size = new Size(452, 304);
            lstCarrinho.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 413);
            Controls.Add(lstCarrinho);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtKg);
            Controls.Add(label3);
            Controls.Add(cmbFuncionarios);
            Controls.Add(label2);
            Controls.Add(cmbProdutos);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbProdutos;
        private Label label2;
        private ComboBox cmbFuncionarios;
        private Label label3;
        private TextBox txtKg;
        private Button button1;
        private Button button2;
        private ListBox lstCarrinho;
    }
}