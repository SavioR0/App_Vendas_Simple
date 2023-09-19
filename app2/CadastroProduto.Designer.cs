
namespace app2
{
    partial class CadastroProduto
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
            this.cadastroButton = new DevExpress.XtraEditors.SimpleButton();
            this.nameLabel = new DevExpress.XtraEditors.LabelControl();
            this.descricaoLabel = new DevExpress.XtraEditors.LabelControl();
            this.valorLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.nameValue = new DevExpress.XtraEditors.TextEdit();
            this.valueValue = new DevExpress.XtraEditors.TextEdit();
            this.descriptionValue = new DevExpress.XtraEditors.TextEdit();
            this.stockValue = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nameValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockValue.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastroButton
            // 
            this.cadastroButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cadastroButton.Location = new System.Drawing.Point(78, 100);
            this.cadastroButton.Name = "cadastroButton";
            this.cadastroButton.Size = new System.Drawing.Size(193, 23);
            this.cadastroButton.TabIndex = 5;
            this.cadastroButton.Text = "Cadastrar";
            this.cadastroButton.Click += new System.EventHandler(this.cadastroButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.Location = new System.Drawing.Point(25, 14);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(34, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Nome :";
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descricaoLabel.Location = new System.Drawing.Point(6, 40);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(56, 13);
            this.descricaoLabel.TabIndex = 7;
            this.descricaoLabel.Text = "Descrição : ";
            // 
            // valorLabel
            // 
            this.valorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valorLabel.Location = new System.Drawing.Point(28, 66);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(34, 13);
            this.valorLabel.TabIndex = 8;
            this.valorLabel.Text = "Valor : ";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(140, 66);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Estoque : ";
            // 
            // nameValue
            // 
            this.nameValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameValue.Location = new System.Drawing.Point(65, 11);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(250, 20);
            this.nameValue.TabIndex = 1;
            // 
            // valueValue
            // 
            this.valueValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.valueValue.Location = new System.Drawing.Point(65, 63);
            this.valueValue.Name = "valueValue";
            this.valueValue.Properties.BeepOnError = false;
            this.valueValue.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.valueValue.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.valueValue.Properties.MaskSettings.Set("mask", "c");
            this.valueValue.Properties.MaskSettings.Set("culture", "pt-BR");
            this.valueValue.Properties.MaskSettings.Set("autoHideDecimalSeparator", true);
            this.valueValue.Properties.UseMaskAsDisplayFormat = true;
            this.valueValue.Size = new System.Drawing.Size(66, 20);
            this.valueValue.TabIndex = 3;
            // 
            // descriptionValue
            // 
            this.descriptionValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionValue.Location = new System.Drawing.Point(65, 37);
            this.descriptionValue.Name = "descriptionValue";
            this.descriptionValue.Size = new System.Drawing.Size(250, 20);
            this.descriptionValue.TabIndex = 2;
            // 
            // stockValue
            // 
            this.stockValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockValue.Location = new System.Drawing.Point(195, 63);
            this.stockValue.Name = "stockValue";
            this.stockValue.Properties.BeepOnError = false;
            this.stockValue.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.stockValue.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.stockValue.Properties.MaskSettings.Set("mask", "d");
            this.stockValue.Size = new System.Drawing.Size(120, 20);
            this.stockValue.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nameValue);
            this.panel1.Controls.Add(this.stockValue);
            this.panel1.Controls.Add(this.cadastroButton);
            this.panel1.Controls.Add(this.descriptionValue);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.valueValue);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.valorLabel);
            this.panel1.Controls.Add(this.descricaoLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 156);
            this.panel1.TabIndex = 16;
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 156);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "CadastroProduto";
            this.Text = "cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.nameValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockValue.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cadastroButton;
        private DevExpress.XtraEditors.LabelControl nameLabel;
        private DevExpress.XtraEditors.LabelControl descricaoLabel;
        private DevExpress.XtraEditors.LabelControl valorLabel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit nameValue;
        public DevExpress.XtraEditors.TextEdit valueValue;
        private DevExpress.XtraEditors.TextEdit descriptionValue;
        public DevExpress.XtraEditors.TextEdit stockValue;
        private System.Windows.Forms.Panel panel1;
    }
}