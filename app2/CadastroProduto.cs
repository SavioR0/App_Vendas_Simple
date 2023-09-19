using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace app2
{
    public partial class CadastroProduto : Form
    {
        private menu _menu;
        private Produto _productEdited;

        public CadastroProduto(menu menu, Produto product)
        {
            InitializeComponent();
            _menu = menu;
            SetFields(product);
        }

        private void SetFields(Produto product) {
            if (product == null) return;
            _productEdited = product;
            nameValue.Text = _productEdited.Name;
            descriptionValue.Text = _productEdited.Description;
            stockValue.Text = _productEdited.Stock.ToString();
            valueValue.Text = _productEdited.Value.ToString();

        }

        private bool ValidateFields() {
            Dictionary<TextEdit, string> fields = new Dictionary<TextEdit, string> {
                { nameValue, "Campo nome está vazio"},
                { descriptionValue, "Campo descrição está vazio"},
                { stockValue, "Campo estoque está vazio"},
                { valueValue, "Campo valor está vazio"},
            };
            foreach (KeyValuePair<TextEdit, string> field in fields)
            {
                if (string.IsNullOrEmpty(field.Key.Text))
                {
                    MessageBox.Show(field.Value, "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void cadastroButton_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                var produto = new Produto(){
                    Name = nameValue.Text,
                    Value = double.Parse(valueValue.Text.Replace("R$", "")),
                    Description = descriptionValue.Text,
                    Stock = int.Parse(stockValue.Text)
                };
                if (_productEdited == null)
                    _menu.SetValuesAsyncProduct(produto);
                else{
                    produto.Id = _productEdited.Id;
                    _menu.UpdateProduct(produto);
                }
                Close();
            }
        }
    }
}
