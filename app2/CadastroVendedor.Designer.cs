
namespace app2
{
    partial class CadastroVendedor
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
            this.nameLabel = new DevExpress.XtraEditors.LabelControl();
            this.valorLabel = new DevExpress.XtraEditors.LabelControl();
            this.descricaoLabel = new DevExpress.XtraEditors.LabelControl();
            this.dateValue = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.nameValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpfValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValue.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nameValue
            // 
            this.nameValue.Location = new System.Drawing.Point(61, 12);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(253, 20);
            this.nameValue.TabIndex = 1;
            // 
            // cadastroButton
            // 
            this.cadastroButton.Location = new System.Drawing.Point(74, 101);
            this.cadastroButton.Name = "cadastroButton";
            this.cadastroButton.Size = new System.Drawing.Size(196, 23);
            this.cadastroButton.TabIndex = 4;
            this.cadastroButton.Text = "Cadastrar";
            this.cadastroButton.Click += new System.EventHandler(this.CadastroButton_Click);
            // 
            // cpfValue
            // 
            this.cpfValue.Location = new System.Drawing.Point(61, 38);
            this.cpfValue.Name = "cpfValue";
            this.cpfValue.Properties.BeepOnError = false;
            this.cpfValue.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.cpfValue.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.cpfValue.Properties.MaskSettings.Set("mask", "000000000-00");
            this.cpfValue.Size = new System.Drawing.Size(253, 20);
            this.cpfValue.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(21, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(34, 13);
            this.nameLabel.TabIndex = 24;
            this.nameLabel.Text = "Nome :";
            // 
            // valorLabel
            // 
            this.valorLabel.Location = new System.Drawing.Point(21, 67);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(105, 13);
            this.valorLabel.TabIndex = 26;
            this.valorLabel.Text = "Data de nascimento : ";
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.Location = new System.Drawing.Point(28, 41);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(29, 13);
            this.descricaoLabel.TabIndex = 25;
            this.descricaoLabel.Text = "CPF : ";
            // 
            // dateValue
            // 
            this.dateValue.EditValue = null;
            this.dateValue.Location = new System.Drawing.Point(132, 64);
            this.dateValue.Name = "dateValue";
            this.dateValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateValue.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateValue.Size = new System.Drawing.Size(138, 20);
            this.dateValue.TabIndex = 3;
            // 
            // CadastroVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 155);
            this.Controls.Add(this.dateValue);
            this.Controls.Add(this.nameValue);
            this.Controls.Add(this.cadastroButton);
            this.Controls.Add(this.cpfValue);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.valorLabel);
            this.Controls.Add(this.descricaoLabel);
            this.Name = "CadastroVendedor";
            this.Text = "CadastroVendedor";
            ((System.ComponentModel.ISupportInitialize)(this.nameValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpfValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValue.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit nameValue;
        private DevExpress.XtraEditors.SimpleButton cadastroButton;
        private DevExpress.XtraEditors.TextEdit cpfValue;
        private DevExpress.XtraEditors.LabelControl nameLabel;
        private DevExpress.XtraEditors.LabelControl valorLabel;
        private DevExpress.XtraEditors.LabelControl descricaoLabel;
        private DevExpress.XtraEditors.DateEdit dateValue;
    }
}