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
    public partial class CadastroCliente : Form
    {
        private menu _menu;
        private Cliente _clientEdited;
        public CadastroCliente(menu menu, Cliente cliente)
        {
            InitializeComponent();
            _menu = menu;
            SetFields(cliente);
        }
        private void SetFields(Cliente cliente)
        {
            if (cliente == null) return;
            _clientEdited = cliente;
            nameValue.Text = _clientEdited.Name;
            cpfValue.Text = _clientEdited.Cpf;
            telValue.Text = _clientEdited.Tel;
        }

        private bool ValidateFields()
        {
            Dictionary<TextEdit, string> fields = new Dictionary<TextEdit, string> {
                { nameValue, "Campo nome está vazio"},
                { cpfValue, "Campo cpf está vazio"},
                { telValue, "Campo telefone está vazio"},
            };
            foreach (KeyValuePair<TextEdit, string> field in fields)
            {
                if (string.IsNullOrEmpty(field.Key.Text))
                {
                    MessageBox.Show(field.Value, "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (!Validations.ValidateCPF(cpfValue.Text))
            {
                MessageBox.Show(" CPF " + cpfValue.Text + " inválido", "CPF inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (telValue.Text.Length < 15)
            {
                MessageBox.Show(" Telefone " + telValue.Text + " inválido", "Telefone inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            return true;
        }

        private void CadastroButton_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                var cliente = new Cliente(){
                    Name = nameValue.Text,
                    Cpf = cpfValue.Text.Replace("-", "").Replace(".",""),
                    Tel = telValue.Text.Replace("(", "").Replace(")","").Replace(" ",""),
                };

                if (_clientEdited == null)_menu.SetValuesAsyncClient(cliente);
                else
                {
                    cliente.Id = _clientEdited.Id;
                    _menu.UpdateClient(cliente);
                }
                Close();
            }
        }
    }
}
