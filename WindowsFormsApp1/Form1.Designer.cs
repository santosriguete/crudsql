
namespace WindowsFormsApp1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btninserir = new System.Windows.Forms.Button();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblcelular = new System.Windows.Forms.Label();
            this.lblcidade = new System.Windows.Forms.Label();
            this.dgvplayer = new System.Windows.Forms.DataGridView();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btninserir
            // 
            this.btninserir.Location = new System.Drawing.Point(361, 23);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(75, 23);
            this.btninserir.TabIndex = 0;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            // 
            // btnatualizar
            // 
            this.btnatualizar.Location = new System.Drawing.Point(361, 64);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(75, 23);
            this.btnatualizar.TabIndex = 1;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = true;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(361, 100);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 2;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(361, 148);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 3;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(12, 26);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(35, 13);
            this.lblnome.TabIndex = 4;
            this.lblnome.Text = "Nome";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(12, 64);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(104, 13);
            this.lbldata.TabIndex = 5;
            this.lbldata.Text = "Data de Nascimento";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(12, 103);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(32, 13);
            this.lblemail.TabIndex = 6;
            this.lblemail.Text = "Email";
            // 
            // lblcelular
            // 
            this.lblcelular.AutoSize = true;
            this.lblcelular.Location = new System.Drawing.Point(12, 148);
            this.lblcelular.Name = "lblcelular";
            this.lblcelular.Size = new System.Drawing.Size(39, 13);
            this.lblcelular.TabIndex = 7;
            this.lblcelular.Text = "Celular";
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Location = new System.Drawing.Point(11, 200);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(40, 13);
            this.lblcidade.TabIndex = 8;
            this.lblcidade.Text = "Cidade";
            // 
            // dgvplayer
            // 
            this.dgvplayer.AllowUserToAddRows = false;
            this.dgvplayer.AllowUserToDeleteRows = false;
            this.dgvplayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvplayer.Location = new System.Drawing.Point(12, 303);
            this.dgvplayer.Name = "dgvplayer";
            this.dgvplayer.ReadOnly = true;
            this.dgvplayer.Size = new System.Drawing.Size(776, 150);
            this.dgvplayer.TabIndex = 9;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(53, 23);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(266, 20);
            this.txtnome.TabIndex = 10;
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(122, 61);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(197, 20);
            this.txtdata.TabIndex = 11;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(50, 100);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(266, 20);
            this.txtemail.TabIndex = 12;
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(52, 145);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(266, 20);
            this.txtcelular.TabIndex = 13;
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(57, 193);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(259, 20);
            this.txtcidade.TabIndex = 14;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 477);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.dgvplayer);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.lblcelular);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.btninserir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Aleatorio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblcelular;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.DataGridView dgvplayer;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.TextBox txtcidade;
    }
}

