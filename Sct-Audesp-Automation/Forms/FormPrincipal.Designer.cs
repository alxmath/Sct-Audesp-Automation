namespace Sct_Audesp_Automation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabAjuste = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAjusteTransmitir = new System.Windows.Forms.Button();
            this.listBoxAjusteItensLicitacao = new System.Windows.Forms.ListBox();
            this.btnAjusteAdicionarLote = new System.Windows.Forms.Button();
            this.txtAjusteInserirLote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAjusteCodigoAudesp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAjusteLicitacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAjusteNumeroEmpenho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjusteImportarLotes = new System.Windows.Forms.Button();
            this.tabExecucao = new System.Windows.Forms.TabPage();
            this.statusStripPrincipal = new System.Windows.Forms.StatusStrip();
            this.tabControlAjusteFeedback = new System.Windows.Forms.TabControl();
            this.tabFeedback = new System.Windows.Forms.TabPage();
            this.tabXMLs = new System.Windows.Forms.TabPage();
            this.tabControlAjusteXML = new System.Windows.Forms.TabControl();
            this.tabXML = new System.Windows.Forms.TabPage();
            this.tabTransmissao = new System.Windows.Forms.TabPage();
            this.tabPacote = new System.Windows.Forms.TabPage();
            this.txtAjusteFeedback = new System.Windows.Forms.TextBox();
            this.txtAjusteStatus = new System.Windows.Forms.TextBox();
            this.progressBarAjuste = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.tabControlPrincipal.SuspendLayout();
            this.tabAjuste.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControlAjusteFeedback.SuspendLayout();
            this.tabFeedback.SuspendLayout();
            this.tabXMLs.SuspendLayout();
            this.tabControlAjusteXML.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlPrincipal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 562);
            this.panel1.TabIndex = 2;
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.tabAjuste);
            this.tabControlPrincipal.Controls.Add(this.tabExecucao);
            this.tabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(1184, 562);
            this.tabControlPrincipal.TabIndex = 0;
            // 
            // tabAjuste
            // 
            this.tabAjuste.Controls.Add(this.groupBox2);
            this.tabAjuste.Controls.Add(this.groupBox1);
            this.tabAjuste.Location = new System.Drawing.Point(4, 22);
            this.tabAjuste.Name = "tabAjuste";
            this.tabAjuste.Padding = new System.Windows.Forms.Padding(3);
            this.tabAjuste.Size = new System.Drawing.Size(1176, 536);
            this.tabAjuste.TabIndex = 0;
            this.tabAjuste.Text = "Ajuste";
            this.tabAjuste.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tabControlAjusteFeedback);
            this.groupBox2.Location = new System.Drawing.Point(268, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(902, 509);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "XML e Respostas";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnAjusteTransmitir);
            this.groupBox1.Controls.Add(this.listBoxAjusteItensLicitacao);
            this.groupBox1.Controls.Add(this.btnAjusteAdicionarLote);
            this.groupBox1.Controls.Add(this.txtAjusteInserirLote);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAjusteCodigoAudesp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAjusteLicitacao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAjusteNumeroEmpenho);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAjusteImportarLotes);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 509);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Ajuste";
            // 
            // btnAjusteTransmitir
            // 
            this.btnAjusteTransmitir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAjusteTransmitir.Location = new System.Drawing.Point(17, 471);
            this.btnAjusteTransmitir.Name = "btnAjusteTransmitir";
            this.btnAjusteTransmitir.Size = new System.Drawing.Size(219, 23);
            this.btnAjusteTransmitir.TabIndex = 6;
            this.btnAjusteTransmitir.Text = "Transmitir";
            this.btnAjusteTransmitir.UseVisualStyleBackColor = true;
            // 
            // listBoxAjusteItensLicitacao
            // 
            this.listBoxAjusteItensLicitacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listBoxAjusteItensLicitacao.FormattingEnabled = true;
            this.listBoxAjusteItensLicitacao.Location = new System.Drawing.Point(17, 260);
            this.listBoxAjusteItensLicitacao.Name = "listBoxAjusteItensLicitacao";
            this.listBoxAjusteItensLicitacao.Size = new System.Drawing.Size(219, 186);
            this.listBoxAjusteItensLicitacao.TabIndex = 7;
            // 
            // btnAjusteAdicionarLote
            // 
            this.btnAjusteAdicionarLote.Location = new System.Drawing.Point(161, 234);
            this.btnAjusteAdicionarLote.Name = "btnAjusteAdicionarLote";
            this.btnAjusteAdicionarLote.Size = new System.Drawing.Size(75, 23);
            this.btnAjusteAdicionarLote.TabIndex = 5;
            this.btnAjusteAdicionarLote.Text = "Adicionar";
            this.btnAjusteAdicionarLote.UseVisualStyleBackColor = true;
            // 
            // txtAjusteInserirLote
            // 
            this.txtAjusteInserirLote.Location = new System.Drawing.Point(17, 236);
            this.txtAjusteInserirLote.Name = "txtAjusteInserirLote";
            this.txtAjusteInserirLote.Size = new System.Drawing.Size(138, 20);
            this.txtAjusteInserirLote.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Inserir Lote";
            // 
            // txtAjusteCodigoAudesp
            // 
            this.txtAjusteCodigoAudesp.Location = new System.Drawing.Point(17, 179);
            this.txtAjusteCodigoAudesp.Name = "txtAjusteCodigoAudesp";
            this.txtAjusteCodigoAudesp.Size = new System.Drawing.Size(219, 20);
            this.txtAjusteCodigoAudesp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Código Audesp da Licitação*";
            // 
            // txtAjusteLicitacao
            // 
            this.txtAjusteLicitacao.Location = new System.Drawing.Point(17, 134);
            this.txtAjusteLicitacao.Name = "txtAjusteLicitacao";
            this.txtAjusteLicitacao.Size = new System.Drawing.Size(219, 20);
            this.txtAjusteLicitacao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Licitação (OC, DL, RP, IN)*";
            // 
            // txtAjusteNumeroEmpenho
            // 
            this.txtAjusteNumeroEmpenho.Location = new System.Drawing.Point(17, 87);
            this.txtAjusteNumeroEmpenho.Name = "txtAjusteNumeroEmpenho";
            this.txtAjusteNumeroEmpenho.Size = new System.Drawing.Size(219, 20);
            this.txtAjusteNumeroEmpenho.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Número do Empenho*";
            // 
            // btnAjusteImportarLotes
            // 
            this.btnAjusteImportarLotes.Location = new System.Drawing.Point(17, 34);
            this.btnAjusteImportarLotes.Name = "btnAjusteImportarLotes";
            this.btnAjusteImportarLotes.Size = new System.Drawing.Size(219, 23);
            this.btnAjusteImportarLotes.TabIndex = 0;
            this.btnAjusteImportarLotes.Text = "Importar Lotes";
            this.btnAjusteImportarLotes.UseVisualStyleBackColor = true;
            // 
            // tabExecucao
            // 
            this.tabExecucao.Location = new System.Drawing.Point(4, 22);
            this.tabExecucao.Name = "tabExecucao";
            this.tabExecucao.Padding = new System.Windows.Forms.Padding(3);
            this.tabExecucao.Size = new System.Drawing.Size(1176, 536);
            this.tabExecucao.TabIndex = 1;
            this.tabExecucao.Text = "Execução";
            this.tabExecucao.UseVisualStyleBackColor = true;
            // 
            // statusStripPrincipal
            // 
            this.statusStripPrincipal.Location = new System.Drawing.Point(0, 540);
            this.statusStripPrincipal.Name = "statusStripPrincipal";
            this.statusStripPrincipal.Size = new System.Drawing.Size(1184, 22);
            this.statusStripPrincipal.TabIndex = 3;
            this.statusStripPrincipal.Text = "statusStrip1";
            // 
            // tabControlAjusteFeedback
            // 
            this.tabControlAjusteFeedback.Controls.Add(this.tabFeedback);
            this.tabControlAjusteFeedback.Controls.Add(this.tabXMLs);
            this.tabControlAjusteFeedback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAjusteFeedback.Location = new System.Drawing.Point(3, 16);
            this.tabControlAjusteFeedback.Name = "tabControlAjusteFeedback";
            this.tabControlAjusteFeedback.SelectedIndex = 0;
            this.tabControlAjusteFeedback.Size = new System.Drawing.Size(896, 490);
            this.tabControlAjusteFeedback.TabIndex = 0;
            // 
            // tabFeedback
            // 
            this.tabFeedback.Controls.Add(this.txtAjusteFeedback);
            this.tabFeedback.Controls.Add(this.txtAjusteStatus);
            this.tabFeedback.Controls.Add(this.progressBarAjuste);
            this.tabFeedback.Location = new System.Drawing.Point(4, 22);
            this.tabFeedback.Name = "tabFeedback";
            this.tabFeedback.Padding = new System.Windows.Forms.Padding(3);
            this.tabFeedback.Size = new System.Drawing.Size(888, 464);
            this.tabFeedback.TabIndex = 0;
            this.tabFeedback.Text = "Feedback";
            this.tabFeedback.UseVisualStyleBackColor = true;
            // 
            // tabXMLs
            // 
            this.tabXMLs.Controls.Add(this.tabControlAjusteXML);
            this.tabXMLs.Location = new System.Drawing.Point(4, 22);
            this.tabXMLs.Name = "tabXMLs";
            this.tabXMLs.Padding = new System.Windows.Forms.Padding(3);
            this.tabXMLs.Size = new System.Drawing.Size(888, 464);
            this.tabXMLs.TabIndex = 1;
            this.tabXMLs.Text = "XML\'s";
            this.tabXMLs.UseVisualStyleBackColor = true;
            // 
            // tabControlAjusteXML
            // 
            this.tabControlAjusteXML.Controls.Add(this.tabXML);
            this.tabControlAjusteXML.Controls.Add(this.tabTransmissao);
            this.tabControlAjusteXML.Controls.Add(this.tabPacote);
            this.tabControlAjusteXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAjusteXML.Location = new System.Drawing.Point(3, 3);
            this.tabControlAjusteXML.Name = "tabControlAjusteXML";
            this.tabControlAjusteXML.SelectedIndex = 0;
            this.tabControlAjusteXML.Size = new System.Drawing.Size(882, 458);
            this.tabControlAjusteXML.TabIndex = 0;
            // 
            // tabXML
            // 
            this.tabXML.Location = new System.Drawing.Point(4, 22);
            this.tabXML.Name = "tabXML";
            this.tabXML.Padding = new System.Windows.Forms.Padding(3);
            this.tabXML.Size = new System.Drawing.Size(874, 432);
            this.tabXML.TabIndex = 0;
            this.tabXML.Text = "XML";
            this.tabXML.UseVisualStyleBackColor = true;
            // 
            // tabTransmissao
            // 
            this.tabTransmissao.Location = new System.Drawing.Point(4, 22);
            this.tabTransmissao.Name = "tabTransmissao";
            this.tabTransmissao.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransmissao.Size = new System.Drawing.Size(874, 432);
            this.tabTransmissao.TabIndex = 1;
            this.tabTransmissao.Text = "Transmissão";
            this.tabTransmissao.UseVisualStyleBackColor = true;
            // 
            // tabPacote
            // 
            this.tabPacote.Location = new System.Drawing.Point(4, 22);
            this.tabPacote.Name = "tabPacote";
            this.tabPacote.Padding = new System.Windows.Forms.Padding(3);
            this.tabPacote.Size = new System.Drawing.Size(874, 432);
            this.tabPacote.TabIndex = 2;
            this.tabPacote.Text = "Pacote";
            this.tabPacote.UseVisualStyleBackColor = true;
            // 
            // txtAjusteFeedback
            // 
            this.txtAjusteFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAjusteFeedback.BackColor = System.Drawing.Color.White;
            this.txtAjusteFeedback.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAjusteFeedback.Location = new System.Drawing.Point(162, 191);
            this.txtAjusteFeedback.Name = "txtAjusteFeedback";
            this.txtAjusteFeedback.ReadOnly = true;
            this.txtAjusteFeedback.Size = new System.Drawing.Size(565, 13);
            this.txtAjusteFeedback.TabIndex = 6;
            this.txtAjusteFeedback.Text = "Processando...";
            // 
            // txtAjusteStatus
            // 
            this.txtAjusteStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAjusteStatus.BackColor = System.Drawing.Color.White;
            this.txtAjusteStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAjusteStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAjusteStatus.Location = new System.Drawing.Point(43, 248);
            this.txtAjusteStatus.Name = "txtAjusteStatus";
            this.txtAjusteStatus.ReadOnly = true;
            this.txtAjusteStatus.Size = new System.Drawing.Size(802, 25);
            this.txtAjusteStatus.TabIndex = 5;
            this.txtAjusteStatus.Text = "Documento armazenado";
            this.txtAjusteStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBarAjuste
            // 
            this.progressBarAjuste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarAjuste.Location = new System.Drawing.Point(162, 210);
            this.progressBarAjuste.Name = "progressBarAjuste";
            this.progressBarAjuste.Size = new System.Drawing.Size(565, 23);
            this.progressBarAjuste.TabIndex = 4;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 562);
            this.Controls.Add(this.statusStripPrincipal);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCT-Audesp-Automation";
            this.panel1.ResumeLayout(false);
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabAjuste.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControlAjusteFeedback.ResumeLayout(false);
            this.tabFeedback.ResumeLayout(false);
            this.tabFeedback.PerformLayout();
            this.tabXMLs.ResumeLayout(false);
            this.tabControlAjusteXML.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tabAjuste;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAjusteTransmitir;
        private System.Windows.Forms.ListBox listBoxAjusteItensLicitacao;
        private System.Windows.Forms.Button btnAjusteAdicionarLote;
        private System.Windows.Forms.TextBox txtAjusteInserirLote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAjusteCodigoAudesp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAjusteLicitacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAjusteNumeroEmpenho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjusteImportarLotes;
        private System.Windows.Forms.TabPage tabExecucao;
        private System.Windows.Forms.StatusStrip statusStripPrincipal;
        private System.Windows.Forms.TabControl tabControlAjusteFeedback;
        private System.Windows.Forms.TabPage tabFeedback;
        private System.Windows.Forms.TextBox txtAjusteFeedback;
        private System.Windows.Forms.TextBox txtAjusteStatus;
        private System.Windows.Forms.ProgressBar progressBarAjuste;
        private System.Windows.Forms.TabPage tabXMLs;
        private System.Windows.Forms.TabControl tabControlAjusteXML;
        private System.Windows.Forms.TabPage tabXML;
        private System.Windows.Forms.TabPage tabTransmissao;
        private System.Windows.Forms.TabPage tabPacote;
    }
}

