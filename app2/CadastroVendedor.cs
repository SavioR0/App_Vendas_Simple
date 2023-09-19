using app2.Entity;
using app2.Shared;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app2
{
    public partial class CadastroVendedor : Form
    {
        private menu _menu;
        private Vendedor _sellerEdited; 
        public CadastroVendedor(menu menu,Vendedor seller)
        {
            InitializeComponent();
            _menu = menu;
            SetFields(seller);
        }

        private void SetFields(Vendedor product)
        {
            if (product == null) return;
            _sellerEdited = product;
            nameValue.Text = _sellerEdited.Name;
            dateValue.Text = _sellerEdited.DateOfBirth.ToString("dd/MM/yyyy");
            cpfValue.Text = _sellerEdited.Cpf;

        }

        private bool ValidateFields()
        {
            Dictionary<TextEdit, string> fields = new Dictionary<TextEdit, string> {
                { nameValue, "Campo nome está vazio"},
                { cpfValue, "Campo cpf está vazio"},
                { dateValue, "Campo data está vazio"},
            };
            foreach (KeyValuePair<TextEdit, string> field in fields)
            {
                if (string.IsNullOrEmpty(field.Key.Text))
                {
                    MessageBox.Show(field.Value, "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            //MessageBox.Show(Validations.ValidateCPF(cpfValue.Text).ToString());
            if (!Validations.ValidateCPF(cpfValue.Text))
            {
                MessageBox.Show(" CPF " + cpfValue.Text + " inválido", "CPF inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void CadastroButton_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                var vendedor = new Vendedor() { Name = nameValue.Text,Cpf = cpfValue.Text.Replace("-", "").Replace(".", ""), DateOfBirth = DateTime.Parse(dateValue.Text)};
                if (_sellerEdited == null) _menu.SetValuesAsyncVendedor(vendedor);
                else
                {
                    vendedor.Id = _sellerEdited.Id;
                    _menu.UpdateSeller(vendedor);
                }
                Close();
            }
        }
    }
}
