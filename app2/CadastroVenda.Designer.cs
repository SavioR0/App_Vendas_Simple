
namespace app2
{
    partial class CadastroVenda
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
            this.components = new System.ComponentModel.Container();
            this.cadastroButton = new DevExpress.XtraEditors.SimpleButton();
            this.idLabel = new DevExpress.XtraEditors.LabelControl();
            this.descricaoLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.productSale = new DevExpress.XtraEditors.ComboBoxEdit();
            this.sellerSale = new DevExpress.XtraEditors.ComboBoxEdit();
            this.clientSale = new DevExpress.XtraEditors.ComboBoxEdit();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productSale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerSale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientSale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastroButton
            // 
            this.cadastroButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cadastroButton.Location = new System.Drawing.Point(87, 103);
            this.cadastroButton.Name = "cadastroButton";
            this.cadastroButton.Size = new System.Drawing.Size(206, 23);
            this.cadastroButton.TabIndex = 23;
            this.cadastroButton.Text = "Cadastrar";
            this.cadastroButton.Click += new System.EventHandler(this.cadastroButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idLabel.Location = new System.Drawing.Point(5, 42);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(56, 13);
            this.idLabel.TabIndex = 26;
            this.idLabel.Text = "Vendedor : ";
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descricaoLabel.Location = new System.Drawing.Point(13, 16);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(48, 13);
            this.descricaoLabel.TabIndex = 25;
            this.descricaoLabel.Text = "Produto : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(15, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Cliente : ";
            // 
            // productSale
            // 
            this.productSale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productSale.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Produto", true));
            this.productSale.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vendaBindingSource, "Produto", true));
            this.productSale.EditValue = "";
            this.productSale.Location = new System.Drawing.Point(64, 13);
            this.productSale.Name = "productSale";
            this.productSale.Properties.BeepOnError = false;
            this.productSale.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.productSale.Size = new System.Drawing.Size(263, 20);
            this.productSale.TabIndex = 21;
            // 
            // sellerSale
            // 
            this.sellerSale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellerSale.Location = new System.Drawing.Point(64, 39);
            this.sellerSale.Name = "sellerSale";
            this.sellerSale.Properties.BeepOnError = false;
            this.sellerSale.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sellerSale.Size = new System.Drawing.Size(263, 20);
            this.sellerSale.TabIndex = 22;
            // 
            // clientSale
            // 
            this.clientSale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientSale.Location = new System.Drawing.Point(64, 65);
            this.clientSale.Name = "clientSale";
            this.clientSale.Properties.BeepOnError = false;
            this.clientSale.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.clientSale.Size = new System.Drawing.Size(263, 20);
            this.clientSale.TabIndex = 27;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(app2.Entity.Venda);
            // 
            // CadastroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 146);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cadastroButton);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.descricaoLabel);
            this.Controls.Add(this.productSale);
            this.Controls.Add(this.sellerSale);
            this.Controls.Add(this.clientSale);
            this.Name = "CadastroVenda";
            this.Text = "CadastroVendas";
            this.Load += new System.EventHandler(this.CadastroVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productSale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerSale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientSale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton cadastroButton;
        private DevExpress.XtraEditors.LabelControl idLabel;
        private DevExpress.XtraEditors.LabelControl descricaoLabel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private DevExpress.XtraEditors.ComboBoxEdit productSale;
        private DevExpress.XtraEditors.ComboBoxEdit sellerSale;
        private DevExpress.XtraEditors.ComboBoxEdit clientSale;
    }
}