namespace aula12
{
    partial class Form_de_Cadastro
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
            txtNome = new TextBox();
            txtPreço = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(165, 32);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(330, 23);
            txtNome.TabIndex = 0;
            txtNome.Text = "Nome";
            // 
            // txtPreço
            // 
            txtPreço.Location = new Point(165, 100);
            txtPreço.Margin = new Padding(3, 2, 3, 2);
            txtPreço.Name = "txtPreço";
            txtPreço.Size = new Size(330, 23);
            txtPreço.TabIndex = 1;
            txtPreço.Text = "Preco";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(279, 168);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(82, 22);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Form_de_Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnSalvar);
            Controls.Add(txtPreço);
            Controls.Add(txtNome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_de_Cadastro";
            Text = "Form_de_Cadastro";
            Load += Form_de_Cadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtPreço;
        private Button btnSalvar;
    }
}