namespace JSON
{
    partial class Form1
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lb_nome = new System.Windows.Forms.Label();
            this.dgv_json = new System.Windows.Forms.DataGridView();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_idade = new System.Windows.Forms.Label();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_obter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_json)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(149, 38);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 0;
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_nome.Location = new System.Drawing.Point(108, 42);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(38, 13);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.Text = "Nome:";
            // 
            // dgv_json
            // 
            this.dgv_json.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_json.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_json.Location = new System.Drawing.Point(111, 158);
            this.dgv_json.Name = "dgv_json";
            this.dgv_json.Size = new System.Drawing.Size(564, 181);
            this.dgv_json.TabIndex = 2;
            this.dgv_json.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_json_CellContentClick);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(111, 385);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(564, 30);
            this.btn_deletar.TabIndex = 5;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(363, 38);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 6;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_email.Location = new System.Drawing.Point(322, 41);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(38, 13);
            this.lb_email.TabIndex = 7;
            this.lb_email.Text = "E-mail:";
            // 
            // lb_idade
            // 
            this.lb_idade.AutoSize = true;
            this.lb_idade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_idade.Location = new System.Drawing.Point(534, 42);
            this.lb_idade.Name = "lb_idade";
            this.lb_idade.Size = new System.Drawing.Size(37, 13);
            this.lb_idade.TabIndex = 8;
            this.lb_idade.Text = "Idade:";
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(575, 38);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(100, 20);
            this.txt_idade.TabIndex = 9;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(111, 122);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(564, 30);
            this.btn_atualizar.TabIndex = 10;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(111, 86);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(564, 30);
            this.btn_salvar.TabIndex = 11;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_obter
            // 
            this.btn_obter.Location = new System.Drawing.Point(111, 349);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(564, 30);
            this.btn_obter.TabIndex = 12;
            this.btn_obter.Text = "Obter";
            this.btn_obter.UseVisualStyleBackColor = true;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.lb_idade);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.dgv_json);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.txt_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_json)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.DataGridView dgv_json;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_idade;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_obter;
    }
}

