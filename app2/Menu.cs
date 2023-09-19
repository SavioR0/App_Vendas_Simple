using app2.data;
using app2.Entity;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace app2
{
    public partial class menu : Form
    {
        public List<Produto> _produtos = new List<Produto>();
        public List<Cliente> _clientes = new List<Cliente>();
        public List<Vendedor> _vendedores = new List<Vendedor>();
        public List<Venda> _vendas = new List<Venda>();
        public TreinamentoContext _dbContext;
        private bool _refreshed = false;

        public menu()
        {
            InitializeComponent();
            _dbContext = new TreinamentoContext();
        }

        private void RefreshGridSales() {
            var sales = _dbContext.Set<Venda>();
            gridSales.DataSource = null;
            gridSales.DataSource = sales.Local.ToBindingList();
            _vendas = sales.ToList();
        }
        private void RefreshGridSellers()
        {
            var seller = _dbContext.Set<Vendedor>();
            gridSellers.DataSource = null;
            gridSellers.DataSource = seller.Local.ToBindingList();
            _vendedores = seller.ToList();
        }
        private void RefreshGridClient()
        {
            var client = _dbContext.Set<Cliente>();
            gridClient.DataSource = null;
            gridClient.DataSource = client.Local.ToBindingList();
            _clientes = client.ToList();
        }
        private void RefreshGridProduct()
        {
            var product = _dbContext.Set<Produto>();
            gridProduct.DataSource = null;
            gridProduct.DataSource = product.Local.ToBindingList();
            _produtos = product.ToList();
        }

        private void RefreshTables_Click(object sender = null, EventArgs e = null)
        {
            RefreshGridProduct();
            RefreshGridClient();
            RefreshGridSellers();
            RefreshGridSales();
            EnableEditButtons();
            _refreshed = true;
        }
        private void EnableEditButtons(){btEdit.Enabled = true; btExclude.Enabled = true; }

        private void BtnRegister(object sender, EventArgs e)
        {
            if (!_refreshed) { RefreshTables_Click();}
            if (TabsNavigator.SelectedTabPage.Name == "Produtos")   { ResgisterProduct_Click();  return;}
            if (TabsNavigator.SelectedTabPage.Name == "Clientes")   { RegisterClient_Click_1();  return;}
            if (TabsNavigator.SelectedTabPage.Name == "Vendedores") { RegisterVendedor_Click();  return;}
            if (TabsNavigator.SelectedTabPage.Name == "Vendas")     { RegisterSale_Click();      return;}
        }
        private void BtnExclude(object sender, EventArgs e)
        {
            if (!_refreshed) { RefreshTables_Click(); }
            if (TabsNavigator.SelectedTabPage.Name == "Produtos")   { ExcludeProduct_Click();   return;}
            if (TabsNavigator.SelectedTabPage.Name == "Clientes")   { ExcludeClient_Click();    return;}
            if (TabsNavigator.SelectedTabPage.Name == "Vendedores") { ExcludeSeller_click();    return;}
            if (TabsNavigator.SelectedTabPage.Name == "Vendas")     { ExcludeSale();            return;}
        }
        private void BtnEdit(object sender, EventArgs e)
        {
            if (!_refreshed) { RefreshTables_Click(); }
            if (TabsNavigator.SelectedTabPage.Name == "Produtos")   { UpdateProduct_Click();   return; }
            if (TabsNavigator.SelectedTabPage.Name == "Clientes")   { UpdateClient_Click();    return; }
            if (TabsNavigator.SelectedTabPage.Name == "Vendedores") { UpdateSeller_Click();    return; }
            if (TabsNavigator.SelectedTabPage.Name == "Vendas")     { UpdateSale_Click_1();    return; }
        }

        // Produto
        private void ResgisterProduct_Click()
        {
            CadastroProduto cadastro = new CadastroProduto(this, null);
            cadastro.Show();
        }
        public void SetValuesAsyncProduct(Produto produto)
        {
            try
            {
                Produto produtoAdded = _dbContext.Produtos.Add(produto);
                _produtos.Add(produtoAdded);
                _dbContext.SaveChanges();
                RefreshGridProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu uma exceção: " + ex.Message + "\n Não é possível cadastrar o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateProduct_Click()
        {
            GridView gridView = gridProduct.FocusedView as GridView;
            Produto produto = gridView.GetRow(gridView.FocusedRowHandle) as Produto;
            CadastroProduto cadastro = new CadastroProduto(this, produto);
            cadastro.Show();
        }
        public void UpdateProduct(Produto produto)
        {
            try
            {
                var prod = _dbContext.Produtos.Find(produto.Id);
                prod.Name = produto.Name;
                prod.Stock = produto.Stock;
                prod.Value = produto.Value;
                prod.Description = produto.Description;
                _dbContext.SaveChanges();

                RefreshGridProduct();
                RefreshGridSales();

                MessageBox.Show("Produto foi atualizado com sucesso! Informações do produto:\n" +
                    "   - Id: " + produto.Id + "\n" +
                    "   - Nome:" + produto.Name + "\n" +
                    "   - Descrição :" + produto.Description + "\n" +
                    "   - Value:" + produto.Value + "\n" +
                    "   - Estoque: " + produto.Stock, "Produto Editado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu uma exceção: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExcludeProduct_Click()
        {
            if(_dbContext.Produtos.ToList().Count() == 0) { MessageBox.Show("Não existe produto selecionada.", "Remover produto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            if (MessageBox.Show("Deseja remover permanentemente o produto do sistema?", "Remover Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    GridView gridView = gridProduct.FocusedView as GridView;
                    int produtoId = (gridView.GetRow(gridView.FocusedRowHandle) as Produto).Id;
                    Produto product = _dbContext.Set<Produto>().Find(produtoId);

                    _dbContext.Produtos.Remove(product);
                    _dbContext.SaveChanges();
                    RefreshGridProduct();

                    MessageBox.Show("PRODUTO EXCLUÍDO COM SUCESSO!\n Produto de id " + product.Id + " foi excluído permanentemente.", " Produto Excluído!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (InvalidOperationException ex)
                {
                    var list = _dbContext.Produtos.ToList();
                    var listLocal = _dbContext.Produtos.Local.ToList();
                    _dbContext.ChangeTracker.Entries().ToList().ForEach(entry => entry.State = EntityState.Detached);
                    _dbContext.Entry(list.Except(listLocal).Union(listLocal.Except(list)).First()).State = EntityState.Unchanged;
                    RefreshTables_Click();
                    MessageBox.Show("Ocorreu uma exceção!\nCertifique-se de que o produto não está vinculado em algum relacionamento.\n", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex);
                }
                catch (Exception ex)
                {
                   MessageBox.Show("Ocorreu uma exceção: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Cliente
        private void RegisterClient_Click_1()
        {
            if (!_refreshed) { RefreshTables_Click(); }
            CadastroCliente cadastroCliente = new CadastroCliente(this, null);
            cadastroCliente.Show();
        }
        public void SetValuesAsyncClient(Cliente cliente)
        {
            try
            {
                Cliente clienteAdded = _dbContext.Clientes.Add(cliente);
                _clientes.Add(clienteAdded);
                _dbContext.SaveChanges();
                RefreshGridClient();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu uma exceção: " + ex.Message + "\n Não é possível cadastrar o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateClient_Click()
        {
            GridView gridView = gridClient.FocusedView as GridView;
            Cliente cliente = gridView.GetRow(gridView.FocusedRowHandle) as Cliente;
            CadastroCliente cadastro = new CadastroCliente(this, cliente);
            cadastro.Show();
        }
        public async void UpdateClient(Cliente cliente)
        {
            try
            {
                var clien = _dbContext.Clientes.Find(cliente.Id);
                clien.Name = cliente.Name;
                clien.Cpf = cliente.Cpf;
                clien.Tel = cliente.Tel;
                await _dbContext.Clientes.LoadAsync();
                _dbContext.SaveChanges();

                RefreshGridClient();
                RefreshGridSales();

                MessageBox.Show("Cliente foi atualizado com sucesso! Informações do cliente:\n" +
                    "   - Id: " + cliente.Id + "\n" +
                    "   - Nome:" + cliente.Name + "\n" +
                    "   - CPF :" + cliente.Cpf + "\n" +
                    "   - Telefone: " + cliente.Tel, "Cliente Editado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu uma exceção: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExcludeClient_Click()
        {
            if (_dbContext.Clientes.ToList().Count() == 0) { MessageBox.Show("Não existe cliente selecionada.", "Remover cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            if (MessageBox.Show("Deseja remover permanentemente o cliente do sistema?", "Remover Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    GridView gridView = gridClient.FocusedView as GridView;
                    int clienteId = (gridView.GetRow(gridView.FocusedRowHandle) as Cliente).Id;
                    Cliente client = _dbContext.Set<Cliente>().Find(clienteId);
                    _dbContext.Clientes.Remove(client);
                    _dbContext.SaveChanges();
                    MessageBox.Show("CLIENTE EXCLUÍDO COM SUCESSO!\n Cliente de id " + client.Id + " foi excluído permanentemente.", "Cliente Excluído!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                catch (InvalidOperationException ex)
                {
                    var list = _dbContext.Clientes.ToList();
                    var listLocal = _dbContext.Clientes.Local.ToList();
                    _dbContext.ChangeTracker.Entries().ToList().ForEach(entry => entry.State = EntityState.Detached);
                    _dbContext.Entry(list.Except(listLocal).Union(listLocal.Except(list)).First()).State = EntityState.Unchanged;
                    RefreshTables_Click();

                    MessageBox.Show("Ocorreu uma exceção! \nCertiique-se de que o cliente não está vinculado em algum relacionamento.\n ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu uma exceção: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); Console.Write(ex.Message);
                }
            }
        }

        // Vendedor
        private void RegisterVendedor_Click()
        {
            if (!_refreshed) { RefreshTables_Click(); }
            CadastroVendedor cadastroVendedor = new CadastroVendedor(this, null);
            cadastroVendedor.Show();
        }
        public void SetValuesAsyncVendedor(Vendedor vendedor)
        {
            try
            {
                Vendedor vendedorAdded = _dbContext.Vendedores.Add(vendedor);
                _vendedores.Add(vendedorAdded);
                _dbContext.SaveChanges();
                RefreshGridSellers();
            }
            catch (Exception ex){
                MessageBox.Show("Ocorreu uma exceção: " + ex.Message + "\n Não é possível cadastrar o Vendedor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async void UpdateSeller(Vendedor vendedor)
        {
            try
            {
                var seller = _dbContext.Vendedores.Find(vendedor.Id);
                seller.Name = vendedor.Name;
                seller.Cpf = vendedor.Cpf;
                seller.DateOfBirth = vendedor.DateOfBirth;
                await _dbContext.Vendedores.LoadAsync();
                _dbContext.SaveChanges();

                RefreshGridSellers();
                RefreshGridSales();

                MessageBox.Show("Vendedor foi atualizado com sucesso! Informações do vendedor:\n" +
                    "   - Id: " + vendedor.Id + "\n" +
                    "   - Nome:" + vendedor.Name + "\n" +
                    "   - CPF :" + vendedor.Cpf + "\n" +
                    "   - Data: " + vendedor.DateOfBirth.ToString("dd/MM/yyyy"), "Vendedor Editado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu uma exceção: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void UpdateSeller_Click()
        {
            GridView gridView = gridSellers.FocusedView as GridView;
            Vendedor vendedor = gridView.GetRow(gridView.FocusedRowHandle) as Vendedor;
            CadastroVendedor cadastro = new CadastroVendedor(this, vendedor);
            cadastro.Show();
        }
        private void ExcludeSeller_click()
        {
            if (_dbContext.Vendedores.ToList().Count() == 0) { MessageBox.Show("Não existe vendedor selecionado.", "Remover Vendedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            if (MessageBox.Show("Deseja remover permanentemente o vendedor do sistema?", "Remover Vendedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    GridView gridView = gridSellers.FocusedView as GridView;
                    int sellerId = (gridView.GetRow(gridView.FocusedRowHandle) as Vendedor).Id;
                    Vendedor seller = _dbContext.Set<Vendedor>().Find(sellerId);
                    _dbContext.Vendedores.Remove(seller);
                    _dbContext.SaveChanges();
                    RefreshGridSellers();
                    MessageBox.Show("VENDEDOR EXCLUÍDO COM SUCESSO!\n Vendedor de id " + seller.Id + " foi excluído permanentemente.", "Vendedor Excluído!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (InvalidOperationException ex)
                {
                    var list = _dbContext.Vendedores.ToList();
                    var listLocal = _dbContext.Vendedores.Local.ToList();
                    _dbContext.ChangeTracker.Entries().ToList().ForEach(entry => entry.State = EntityState.Detached);
                    _dbContext.Entry(list.Except(listLocal).Union(listLocal.Except(list)).First()).State = EntityState.Unchanged;
                    RefreshTables_Click();
                    MessageBox.Show("Ocorreu uma exceção! \nCertiique-se de que o vendedor não está vinculado em algum relacionamento.\n ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu uma exceção: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Vendas
        private void RegisterSale_Click(object sender = null, EventArgs e = null)
        {
            if (!_refreshed) { RefreshTables_Click(); }
            CadastroVenda cadastroVenda = new CadastroVenda(this, null);
            cadastroVenda.Show();
        }
        public void SetValuesAsyncSale(Venda venda)
        {
            try
            {
                _dbContext.Vendas.Local.Add(venda);
                _dbContext.SaveChanges();
                RefreshGridSales();

                var product = _dbContext.Set<Produto>().Where(p => p.Id == venda.ProductId).FirstOrDefault();
                product.Stock -= 1; 
                UpdateProduct(product);
            }
            catch (Exception ex) { MessageBox.Show("Ocorreu uma exceção: " + ex.Message + "\n Não é possível cadastrar o venda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }
        private void UpdateSale_Click_1()
        {
            GridView gridView = gridSales.FocusedView as GridView;
            int vendaId = (gridView.GetRow(gridView.FocusedRowHandle) as Venda).Id;
            Venda venda = _dbContext.Set<Venda>().Where(c => c.Id == vendaId).FirstOrDefault();
            CadastroVenda cadastro = new CadastroVenda(this, venda);
            cadastro.Show();
        }
        public void UpdateSale(Venda venda, Venda vendaAntiga = null)
        {
            try
            {
                var sale = _dbContext.Vendas.Find(venda.Id);

                sale.SellerId = venda.SellerId;
                sale.ClientId = venda.ClientId;
                if (vendaAntiga != null && sale.ProductId != vendaAntiga.ProductId) {
                    var lastProduct = _dbContext.Set<Produto>().Where(v => v.Id == vendaAntiga.ProductId).FirstOrDefault();
                    lastProduct.Stock += 1;
                    UpdateProduct(lastProduct);
                    sale.ProductId = venda.ProductId;
                    var newProduct = _dbContext.Set<Produto>().Where(v => v.Id == sale.ProductId).FirstOrDefault();
                    newProduct.Stock -= 1;
                    UpdateProduct(newProduct);
                }
               
                _dbContext.SaveChanges();
                RefreshGridSales();

                MessageBox.Show("Venda foi atualizado com sucesso! Informações do venda:\n" +
                    "   - Id: " + venda.Id + "\n" +
                    "   - Produto:" + venda.ProductId + "\n" +
                    "   - Vendedor :" + venda.SellerId + "\n" +
                    "   - Cliente: " + venda.ClientId, "Venda Editada!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu uma exceção: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExcludeSale(object sender = null, EventArgs e = null)
        {
            if(_dbContext.Vendas.ToList().Count() == 0) { MessageBox.Show("Não existe venda selecionada.", "Remover Venda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            if (MessageBox.Show("Deseja remover permanentemente a venda no sistema?", "Remover Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    GridView gridView = gridSales.FocusedView as GridView; ;
                    int saleId = (gridView.GetRow(gridView.FocusedRowHandle) as Venda).Id;
                    Venda sale = _dbContext.Set<Venda>().Find(saleId);
                    _dbContext.Vendas.Remove(sale);
                    _dbContext.SaveChanges();
                    RefreshGridSales();
                    MessageBox.Show("VENDA EXCLUÍDA COM SUCESSO!\n Venda de id " + sale.Id + " foi excluído permanentemente.", "Venda Excluída!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu uma exceção: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Filtros
        private void ComboBoxFilter_EditValueChanged(object sender, EventArgs e)
        {
            if (TabsNavigator.SelectedTabPage.Name == "Produtos")
            {
                textEditSearchProd.Text = "";
                if (!string.IsNullOrEmpty(comboBoxFilterProd.Text)) textEditSearchProd.Enabled = true;
                else { textEditSearchProd.Enabled = false; }
                return;
            }
            if (TabsNavigator.SelectedTabPage.Name == "Clientes")
            {
                textEditSearchClient.Text = "";
                if (!string.IsNullOrEmpty(comboBoxFilterClient.Text)) textEditSearchClient.Enabled = true;
                else { textEditSearchClient.Enabled = false; }
                return;
            }
            if (TabsNavigator.SelectedTabPage.Name == "Vendedores")
            {
                textEditSearchSeller.Text = "";
                if (!string.IsNullOrEmpty(comboBoxFilterSeller.Text)) textEditSearchSeller.Enabled = true;
                else { textEditSearchSeller.Enabled = false; }
                return;
            }
            if (TabsNavigator.SelectedTabPage.Name == "Vendas")
            {
                textEditSearchSale.Text = "";
                if (!string.IsNullOrEmpty(comboBoxFilterSale.Text)) textEditSearchSale.Enabled = true;
                else { textEditSearchSale.Enabled = false; }
                return;
            }
        }
        private  void BtnSearchProd_Click(object sender = null, EventArgs e = null)
        {
            if (_refreshed == false) { RefreshTables_Click();}
            if (TabsNavigator.SelectedTabPage.Name == "Produtos") { SearchProd(textEditSearchProd.Text); textEditSearchProd.Text = ""; };
            if (TabsNavigator.SelectedTabPage.Name == "Clientes") { SearchClient(textEditSearchClient.Text); textEditSearchClient.Text = ""; };
            if (TabsNavigator.SelectedTabPage.Name == "Vendedores") { SearchSeller(textEditSearchSeller.Text); textEditSearchSeller.Text = ""; };
            if (TabsNavigator.SelectedTabPage.Name == "Vendas") { SearchSale(textEditSearchSale.Text); textEditSearchSale.Text = ""; };
        }

        private void SearchProd(String filter)
        {
            //if (!comboBoxFilterProd.Properties.Items.Contains(comboBoxFilterProd.Text)) { comboBoxFilterProd.Text = ""; MessageBox.Show("Selecione um filtro válido!", "Filtro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);  return; }
            if (string.IsNullOrWhiteSpace(filter)) { gridProduct.DataSource = _dbContext.Produtos.Local.ToBindingList(); return; }
            if (comboBoxFilterProd.Text == "Id")
            {
                if (!int.TryParse(filter, out int idValue)) { textEditSearchProd.Text = ""; MessageBox.Show("Digite um id válido!", "Id Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);  return; }
                gridProduct.DataSource = null;
                gridProduct.DataSource = _produtos.Where(p => p.Id == idValue);
                return;
            }
            if (comboBoxFilterProd.Text == "Nome")
            {
                gridProduct.DataSource = null;
                gridProduct.DataSource = _produtos.Where(p => p.Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                return;
            }
        }
        private void SearchClient(String filter)
        {
            //if (!comboBoxFilterClient.Properties.Items.Contains(comboBoxFilterClient.Text)) { comboBoxFilterClient.Text = ""; MessageBox.Show("Selecione um filtro válido!", "Filtro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (string.IsNullOrWhiteSpace(filter)){gridClient.DataSource = _dbContext.Clientes.Local.ToBindingList();return;}
            if (comboBoxFilterClient.Text == "Id")
            {
                if (!int.TryParse(filter, out int idValue)) { textEditSearchClient.Text = ""; MessageBox.Show("Digite um id válido!", "Id Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);  return; }
                gridClient.DataSource = null;
                gridClient.DataSource = _clientes.Where(p => p.Id == idValue);
                return;
            }
            if (comboBoxFilterClient.Text == "Nome")
            {
                gridClient.DataSource = null;
                gridClient.DataSource = _clientes.Where(p => p.Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                return;
            }
        }
        private void SearchSeller(String filter)
        {
            //if (!comboBoxFilterSeller.Properties.Items.Contains(comboBoxFilterSeller.Text)) { comboBoxFilterSeller.Text = ""; MessageBox.Show("Selecione um filtro válido!", "Filtro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (string.IsNullOrWhiteSpace(filter)){gridSellers.DataSource = _dbContext.Vendedores.Local.ToBindingList();return;}
            if (comboBoxFilterSeller.Text == "Id")
            {
                if (!int.TryParse(filter, out int idValue)) { textEditSearchSeller.Text = ""; MessageBox.Show("Digite um id válido!", "Id Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                gridSellers.DataSource = null;
                gridSellers.DataSource = _vendedores.Where(p => p.Id == int.Parse(filter));
                return;
            }
            if (comboBoxFilterSeller.Text == "Nome")
            {
                gridSellers.DataSource = null;
                gridSellers.DataSource = _vendedores.Where(p => p.Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                return;
            }
        }
        private void SearchSale(String filter)
        {
            //if (!comboBoxFilterSale.Properties.Items.Contains(comboBoxFilterSale.Text)) { comboBoxFilterSale.Text = ""; MessageBox.Show("Selecione um filtro válido!", "Filtro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (string.IsNullOrWhiteSpace(filter)) { gridSales.DataSource = _dbContext.Vendas.Local.ToBindingList(); return; }
            if (comboBoxFilterSale.Text == "Id")
            {
                if (!int.TryParse(filter, out int idValue)) {  MessageBox.Show("Digite um id válido!", "Id Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                gridSales.DataSource = null;
                gridSales.DataSource = _vendas.Where(p => p.Id == idValue);
                return;
            }
            if (comboBoxFilterSale.Text == "Produto")
            {
                gridSales.DataSource = null;
                gridSales.DataSource = _vendas.Where(p => p.Produto.Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);
                return;
            }
            if (comboBoxFilterSale.Text == "Cliente")
            {
                gridSales.DataSource = null;
                gridSales.DataSource = _vendas.Where(p => p.Cliente.Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);
                return;
            }
            if (comboBoxFilterSale.Text == "Vendedor")
            {
                gridSales.DataSource = null;
                gridSales.DataSource = _vendas.Where(p => p.Vendedor.Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);
                return;
            }

        }
    }
}
