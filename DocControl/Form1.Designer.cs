namespace DocControl
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNovoDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsProcDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSair = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAdduser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDelUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTutorial = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.pAddDoc = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.cbPara = new System.Windows.Forms.ComboBox();
            this.dtCheckin = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.pAddDoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.relatóriosToolStripMenuItem,
            this.administradorToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNovoDoc,
            this.tsProcDoc,
            this.toolStripSeparator1,
            this.tsSair});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Arquivo";
            // 
            // tsNovoDoc
            // 
            this.tsNovoDoc.Name = "tsNovoDoc";
            this.tsNovoDoc.Size = new System.Drawing.Size(185, 22);
            this.tsNovoDoc.Text = "Novo Documento";
            this.tsNovoDoc.Click += new System.EventHandler(this.tsNovoDoc_Click);
            // 
            // tsProcDoc
            // 
            this.tsProcDoc.Name = "tsProcDoc";
            this.tsProcDoc.Size = new System.Drawing.Size(185, 22);
            this.tsProcDoc.Text = "Procurar Documento";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // tsSair
            // 
            this.tsSair.Name = "tsSair";
            this.tsSair.Size = new System.Drawing.Size(185, 22);
            this.tsSair.Text = "Sair";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDoc,
            this.usuáriosToolStripMenuItem});
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // tsDoc
            // 
            this.tsDoc.Name = "tsDoc";
            this.tsDoc.Size = new System.Drawing.Size(152, 22);
            this.tsDoc.Text = "Documentos";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdduser,
            this.tsEditUser,
            this.tsDelUser});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // tsAdduser
            // 
            this.tsAdduser.Name = "tsAdduser";
            this.tsAdduser.Size = new System.Drawing.Size(152, 22);
            this.tsAdduser.Text = "Adicionar";
            // 
            // tsEditUser
            // 
            this.tsEditUser.Name = "tsEditUser";
            this.tsEditUser.Size = new System.Drawing.Size(152, 22);
            this.tsEditUser.Text = "Editar";
            // 
            // tsDelUser
            // 
            this.tsDelUser.Name = "tsDelUser";
            this.tsDelUser.Size = new System.Drawing.Size(152, 22);
            this.tsDelUser.Text = "Remover";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTutorial,
            this.tsSobre});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // tsTutorial
            // 
            this.tsTutorial.Name = "tsTutorial";
            this.tsTutorial.Size = new System.Drawing.Size(152, 22);
            this.tsTutorial.Text = "Tutorial";
            // 
            // tsSobre
            // 
            this.tsSobre.Name = "tsSobre";
            this.tsSobre.Size = new System.Drawing.Size(152, 22);
            this.tsSobre.Text = "Sobre";
            // 
            // pAddDoc
            // 
            this.pAddDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pAddDoc.BackColor = System.Drawing.SystemColors.Control;
            this.pAddDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pAddDoc.Controls.Add(this.dtCheckin);
            this.pAddDoc.Controls.Add(this.cbPara);
            this.pAddDoc.Controls.Add(this.txtEmpresa);
            this.pAddDoc.Controls.Add(this.txtNome);
            this.pAddDoc.Controls.Add(this.label4);
            this.pAddDoc.Controls.Add(this.label3);
            this.pAddDoc.Controls.Add(this.label2);
            this.pAddDoc.Controls.Add(this.label1);
            this.pAddDoc.Controls.Add(this.btnCancelar);
            this.pAddDoc.Controls.Add(this.btnSalvar);
            this.pAddDoc.Location = new System.Drawing.Point(12, 38);
            this.pAddDoc.Name = "pAddDoc";
            this.pAddDoc.Size = new System.Drawing.Size(927, 553);
            this.pAddDoc.TabIndex = 1;
            this.pAddDoc.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSalvar.Location = new System.Drawing.Point(814, 497);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(93, 41);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelar.Location = new System.Drawing.Point(715, 497);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 41);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(38, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(38, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Para:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(38, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Check in:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(135, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(726, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(135, 77);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(726, 20);
            this.txtEmpresa.TabIndex = 8;
            // 
            // cbPara
            // 
            this.cbPara.FormattingEnabled = true;
            this.cbPara.Location = new System.Drawing.Point(135, 115);
            this.cbPara.Name = "cbPara";
            this.cbPara.Size = new System.Drawing.Size(250, 21);
            this.cbPara.TabIndex = 9;
            // 
            // dtCheckin
            // 
            this.dtCheckin.Location = new System.Drawing.Point(135, 156);
            this.dtCheckin.Name = "dtCheckin";
            this.dtCheckin.Size = new System.Drawing.Size(200, 20);
            this.dtCheckin.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(956, 603);
            this.Controls.Add(this.pAddDoc);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DocControl";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pAddDoc.ResumeLayout(false);
            this.pAddDoc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsNovoDoc;
        private System.Windows.Forms.ToolStripMenuItem tsProcDoc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsSair;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsDoc;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsAdduser;
        private System.Windows.Forms.ToolStripMenuItem tsEditUser;
        private System.Windows.Forms.ToolStripMenuItem tsDelUser;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsTutorial;
        private System.Windows.Forms.ToolStripMenuItem tsSobre;
        private System.Windows.Forms.Panel pAddDoc;
        private System.Windows.Forms.DateTimePicker dtCheckin;
        private System.Windows.Forms.ComboBox cbPara;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}

