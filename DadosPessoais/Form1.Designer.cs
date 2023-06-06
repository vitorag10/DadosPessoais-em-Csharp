namespace DadosPessoais
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.cmdcadastrar = new System.Windows.Forms.Button();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.lblendereco = new System.Windows.Forms.Label();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.txtcadastradas = new System.Windows.Forms.TextBox();
            this.lblcadastradas = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcadastradas);
            this.groupBox1.Controls.Add(this.lblcadastradas);
            this.groupBox1.Controls.Add(this.txtendereco);
            this.groupBox1.Controls.Add(this.lblendereco);
            this.groupBox1.Controls.Add(this.cmdcadastrar);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.lblnome);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 415);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(6, 61);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(69, 28);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(6, 97);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(534, 34);
            this.txtnome.TabIndex = 1;
            // 
            // cmdcadastrar
            // 
            this.cmdcadastrar.Location = new System.Drawing.Point(109, 242);
            this.cmdcadastrar.Name = "cmdcadastrar";
            this.cmdcadastrar.Size = new System.Drawing.Size(365, 32);
            this.cmdcadastrar.TabIndex = 2;
            this.cmdcadastrar.Text = "Cadastrar";
            this.cmdcadastrar.UseVisualStyleBackColor = true;
            this.cmdcadastrar.Click += new System.EventHandler(this.cmdcadastrar_Click);
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(0, 186);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(264, 34);
            this.txtendereco.TabIndex = 4;
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Location = new System.Drawing.Point(0, 150);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(99, 28);
            this.lblendereco.TabIndex = 3;
            this.lblendereco.Text = "Endereço";
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(308, 198);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(244, 27);
            this.txttelefone.TabIndex = 6;
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltelefone.Location = new System.Drawing.Point(308, 162);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(93, 28);
            this.lbltelefone.TabIndex = 5;
            this.lbltelefone.Text = "Telefone";
            // 
            // txtcadastradas
            // 
            this.txtcadastradas.Location = new System.Drawing.Point(22, 338);
            this.txtcadastradas.Multiline = true;
            this.txtcadastradas.Name = "txtcadastradas";
            this.txtcadastradas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcadastradas.Size = new System.Drawing.Size(500, 58);
            this.txtcadastradas.TabIndex = 6;
            // 
            // lblcadastradas
            // 
            this.lblcadastradas.AutoSize = true;
            this.lblcadastradas.Location = new System.Drawing.Point(173, 307);
            this.lblcadastradas.Name = "lblcadastradas";
            this.lblcadastradas.Size = new System.Drawing.Size(204, 28);
            this.lblcadastradas.TabIndex = 5;
            this.lblcadastradas.Text = "Pessoas Cadastradas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.lbltelefone);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtcadastradas;
        private Label lblcadastradas;
        private TextBox txtendereco;
        private Label lblendereco;
        private Button cmdcadastrar;
        private TextBox txtnome;
        private Label lblnome;
        private TextBox txttelefone;
        private Label lbltelefone;
    }
}