using app2.Entity;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app2
{
    public partial class CadastroVenda : Form
    {
        menu _menu;
        Venda _salesEdited; 
        public CadastroVenda(menu menu, Venda sale)
        {
            InitializeComponent();
            _menu = menu;
            SetFields(sale);
        }

        private void SetFields(Venda sale)
        {
            if (sale == null) return;
            _salesEdited = sale;
            sellerSale.Text = _menu._vendedores.Find(v=> v.Id == _salesEdited.SellerId).Name;
            clientSale.Text = _menu._clientes.Find(v => v.Id == _salesEdited.ClientId).Name;
            productSale.Text = _menu._produtos.Find(v => v.Id == _salesEdited.ProductId).Name;
        }

        private bool ValidateFields()
        {
            Dictionary<TextEdit, string> fields = new Dictionary<TextEdit, string> {
                { productSale, "Campo produto está vazio"},
                { sellerSale, "Campo vendedor está vazio"},
                { clientSale, "Campo comprador está vazio"},
            };
            foreach (KeyValuePair<TextEdit, string> field in fields)
            {
                if (string.IsNullOrEmpty(field.Key.Text))
                {
                    MessageBox.Show(field.Value, "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (field.Key == productSale && !_menu._produtos.Exists(p => p.Name == field.Key.Text)) {
                    MessageBox.Show("Produto inválido, não está cadastrado no sistema", "Produto não cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (field.Key == sellerSale && !_menu._vendedores.Exists(p => p.Name == field.Key.Text)) {
                    MessageBox.Show("Vendedor inválido, não está cadastrado no sistema", "Vendedor não cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;

                }
                if (field.Key == clientSale && !_menu._clientes.Exists(p => p.Name == field.Key.Text)) {
                    MessageBox.Show("Cliente inválido, não está cadastrado no sistema", "Cliente não cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            //TODO: Validar se id do vendedor e do comprador
            return true;
        }
        private void cadastroButton_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {


                if (_salesEdited == null)
                {
                    var venda = new Venda()
                    {
                        ProductId = (_menu._produtos.Find(p => p.Name == productSale.Text)).Id,
                        SellerId = (_menu._vendedores.Find(p => p.Name == sellerSale.Text)).Id,
                        ClientId = (_menu._clientes.Find(p => p.Name == clientSale.Text)).Id,
                    };
                    _menu.SetValuesAsyncSale(venda);
                }
                else
                {
                    Venda sale = new Venda { ProductId = _salesEdited.ProductId, SellerId= _salesEdited.SellerId ,ClientId = _salesEdited.ClientId};
                    _salesEdited.ProductId = (_menu._produtos.Find(p => p.Name == productSale.Text)).Id;
                    _salesEdited.SellerId = (_menu._vendedores.Find(p => p.Name == sellerSale.Text)).Id;
                    _salesEdited.ClientId = (_menu._clientes.Find(p => p.Name == clientSale.Text)).Id;
                    _menu.UpdateSale(_salesEdited, sale);
                }
                Close();
            }
        }

        private void CadastroVenda_Load(object sender, EventArgs e)
        {
            foreach (Produto produto in _menu._produtos) productSale.Properties.Items.Add(produto.Name);
            foreach (Cliente cliente in _menu._clientes) clientSale.Properties.Items.Add(cliente.Name);
            foreach (Vendedor vendedor in _menu._vendedores) sellerSale.Properties.Items.Add(vendedor.Name);
        }
    }
}
