namespace OS_19
{
    partial class FrmOS_usuario
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
            this.dgv_view = new System.Windows.Forms.DataGridView();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.lbl_tecnico = new System.Windows.Forms.Label();
            this.btn_criar = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.cbx_tecnico = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_view
            // 
            this.dgv_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_view.Location = new System.Drawing.Point(39, 24);
            this.dgv_view.Name = "dgv_view";
            this.dgv_view.Size = new System.Drawing.Size(607, 240);
            this.dgv_view.TabIndex = 0;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(96, 278);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(24, 18);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "ID";
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descricao.Location = new System.Drawing.Point(252, 278);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(85, 18);
            this.lbl_descricao.TabIndex = 2;
            this.lbl_descricao.Text = "Descrição";
            // 
            // lbl_tecnico
            // 
            this.lbl_tecnico.AutoSize = true;
            this.lbl_tecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tecnico.Location = new System.Drawing.Point(68, 347);
            this.lbl_tecnico.Name = "lbl_tecnico";
            this.lbl_tecnico.Size = new System.Drawing.Size(68, 18);
            this.lbl_tecnico.TabIndex = 3;
            this.lbl_tecnico.Text = "Técnico";
            // 
            // btn_criar
            // 
            this.btn_criar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_criar.Location = new System.Drawing.Point(124, 453);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(102, 43);
            this.btn_criar.TabIndex = 4;
            this.btn_criar.Text = "Criar OS";
            this.btn_criar.UseVisualStyleBackColor = true;
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // btn_listar
            // 
            this.btn_listar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listar.Location = new System.Drawing.Point(267, 453);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(101, 43);
            this.btn_listar.TabIndex = 5;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(409, 453);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(101, 43);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(35, 308);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(141, 20);
            this.txt_id.TabIndex = 7;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_tecnico_TextChanged);
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(242, 303);
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(257, 91);
            this.txt_descricao.TabIndex = 8;
            // 
            // cbx_tecnico
            // 
            this.cbx_tecnico.FormattingEnabled = true;
            this.cbx_tecnico.Location = new System.Drawing.Point(35, 373);
            this.cbx_tecnico.Name = "cbx_tecnico";
            this.cbx_tecnico.Size = new System.Drawing.Size(141, 21);
            this.cbx_tecnico.TabIndex = 9;
            // 
            // FrmOS_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 548);
            this.Controls.Add(this.cbx_tecnico);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.lbl_tecnico);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.dgv_view);
            this.Name = "FrmOS_usuario";
            this.Text = "FrmOS_usuario";
            this.Load += new System.EventHandler(this.FrmOS_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_view;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Label lbl_tecnico;
        private System.Windows.Forms.Button btn_criar;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.ComboBox cbx_tecnico;
    }
}