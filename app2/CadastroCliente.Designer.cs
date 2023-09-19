
namespace app2
{
    partial class CadastroCliente
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
            this.nameValue = new DevExpress.XtraEditors.TextEdit();
            this.cadastroButton = new DevExpress.XtraEditors.SimpleButton();
            this.cpfValue = new DevExpress.XtraEditors.TextEdit();
            this.telValue = new DevExpress.XtraEditors.TextEdit();
            this.nameLabel = new DevExpress.XtraEditors.LabelControl();
            this.valorLabel = new DevExpress.XtraEditors.LabelControl();
            this.descricaoLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.nameValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpfValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nameValue
            // 
            this.nameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameValue.Location = new System.Drawing.Point(67, 12);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(253, 20);
            this.nameValue.TabIndex = 12;
            // 
            // cadastroButton
            // 
            this.cadastroButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cadastroButton.Location = new System.Drawing.Point(80, 101);
            this.cadastroButton.Name = "cadastroButton";
            this.cadastroButton.Size = new System.Drawing.Size(196, 23);
            this.cadastroButton.TabIndex = 16;
            this.cadastroButton.Text = "Cadastrar";
            this.cadastroButton.Click += new System.EventHandler(this.CadastroButton_Click);
            // 
            // cpfValue
            // 
            this.cpfValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cpfValue.Location = new System.Drawing.Point(67, 38);
            this.cpfValue.Name = "cpfValue";
            this.cpfValue.Properties.BeepOnError = false;
            this.cpfValue.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.cpfValue.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.cpfValue.Properties.MaskSettings.Set("mask", "000\\.000\\.000-00");
            this.cpfValue.Properties.MaskSettings.Set("hideInsignificantZeros", false);
            this.cpfValue.Properties.UseMaskAsDisplayFormat = true;
            this.cpfValue.Size = new System.Drawing.Size(253, 20);
            this.cpfValue.TabIndex = 13;
            // 
            // telValue
            // 
            this.telValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telValue.Location = new System.Drawing.Point(67, 64);
            this.telValue.Name = "telValue";
            this.telValue.Properties.BeepOnError = false;
            this.telValue.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.telValue.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.telValue.Properties.MaskSettings.Set("mask", "(##) # ########");
            this.telValue.Properties.UseMaskAsDisplayFormat = true;
            this.telValue.Size = new System.Drawing.Size(253, 20);
            this.telValue.TabIndex = 14;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.Location = new System.Drawing.Point(27, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(34, 13);
            this.nameLabel.TabIndex = 17;
            this.nameLabel.Text = "Nome :";
            // 
            // valorLabel
            // 
            this.valorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valorLabel.Location = new System.Drawing.Point(12, 67);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(52, 13);
            this.valorLabel.TabIndex = 19;
            this.valorLabel.Text = "Telefone : ";
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descricaoLabel.Location = new System.Drawing.Point(34, 41);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(29, 13);
            this.descricaoLabel.TabIndex = 18;
            this.descricaoLabel.Text = "CPF : ";
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 140);
            this.Controls.Add(this.nameValue);
            this.Controls.Add(this.cadastroButton);
            this.Controls.Add(this.cpfValue);
            this.Controls.Add(this.telValue);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.valorLabel);
            this.Controls.Add(this.descricaoLabel);
            this.Name = "CadastroCliente";
            this.Text = "CadastroCliente";
            ((System.ComponentModel.ISupportInitialize)(this.nameValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpfValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telValue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit nameValue;
        private DevExpress.XtraEditors.SimpleButton cadastroButton;
        private DevExpress.XtraEditors.TextEdit cpfValue;
        public DevExpress.XtraEditors.TextEdit telValue;
        private DevExpress.XtraEditors.LabelControl nameLabel;
        private DevExpress.XtraEditors.LabelControl valorLabel;
        private DevExpress.XtraEditors.LabelControl descricaoLabel;
    }
}