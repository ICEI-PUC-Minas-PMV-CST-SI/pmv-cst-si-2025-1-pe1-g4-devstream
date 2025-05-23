using System;
using System.Collections.Generic;
using System.ComponentModel; // Para BindingList
using System.IO; // Para operações de arquivo (StreamWriter)
using System.Linq; // Para consultas LINQ
using System.Windows.Forms;

namespace DevStreamInventory // Certifique-se que este namespace é o mesmo do seu projeto
{
    public partial class MainForm : Form
    {
        private BindingList<InventoryItem> allItemsBindingList;
        private User currentUser;

        public MainForm(User loggedInUser)
        {
            InitializeComponent();
            this.currentUser = loggedInUser;
            this.Text = $"Sistema de Inventário DevStream - Usuário: {currentUser.Username}";

            var initialItems = DataService.GetInventoryItems();
            allItemsBindingList = new BindingList<InventoryItem>(initialItems);

            SetupDataGridView();
            // DisplayInventory(allItemsBindingList.ToList()); // Já é feito pelo SetupDataGridView com BindingList
            toolStripStatusLabelCurrentUser.Text = $"Usuário Logado: {currentUser.Username}";
        }

        private void SetupDataGridView()
        {
            dataGridViewInventory.AutoGenerateColumns = false;
            dataGridViewInventory.Columns.Clear();

            dataGridViewInventory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DisplayName", HeaderText = "Nome", Name = "colName", Width = 250, Frozen=true });
            dataGridViewInventory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DisplayType", HeaderText = "Tipo", Name = "colType", Width = 80 });
            dataGridViewInventory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DisplayCategory", HeaderText = "Categoria Custo", Name = "colCategory", Width = 100 });
            dataGridViewInventory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DisplayCost", HeaderText = "Custo (Período)", Name = "colCost", Width = 120 });
            dataGridViewInventory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DisplayQuantity", HeaderText = "Qtde", Name = "colQuantity", Width = 50 });
            dataGridViewInventory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DisplayUseDescription", HeaderText = "Uso/Descrição", Name = "colUseDescription", Width = 300 });
            dataGridViewInventory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SourceDocumentReference", HeaderText = "Fonte Doc.", Name = "colSource", Width = 100 });
            
            dataGridViewInventory.DataSource = allItemsBindingList;
        }

        private void RefreshDataGridViewDisplay() // Usado após filtros
        {
            // Se o DataSource foi alterado para uma lista filtrada,
            // este método não é necessário, pois a nova atribuição atualiza.
            // Se o allItemsBindingList é sempre o DataSource e você usa
            // ICollectionView para filtrar, então você chamaria Refresh na view.
            // Para este exemplo, o filtro recria o DataSource.
        }


        // --- Handlers dos Botões CRUD ---
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            using (ItemEditorForm editorForm = new ItemEditorForm())
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    allItemsBindingList.Add(editorForm.CurrentItem);
                    // BindingList atualiza o DataGridView automaticamente
                }
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewInventory.CurrentRow != null && dataGridViewInventory.CurrentRow.DataBoundItem is InventoryItem selectedItem)
            {
                int selectedIndex = allItemsBindingList.IndexOf(selectedItem);

                using (ItemEditorForm editorForm = new ItemEditorForm(selectedItem))
                {
                    if (editorForm.ShowDialog(this) == DialogResult.OK)
                    {
                        // O objeto 'selectedItem' já foi modificado.
                        // Notificar o BindingList para atualizar a exibição.
                        if (selectedIndex >= 0)
                        {
                            allItemsBindingList.ResetItem(selectedIndex);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um item da lista para alterar.", "Nenhum Item Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewInventory.CurrentRow != null && dataGridViewInventory.CurrentRow.DataBoundItem is InventoryItem selectedItem)
            {
                if (MessageBox.Show($"Tem certeza que deseja excluir o item '{selectedItem.Name}'?",
                                     "Confirmar Exclusão",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    allItemsBindingList.Remove(selectedItem);
                    // BindingList atualiza o DataGridView automaticamente
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um item da lista para excluir.", "Nenhum Item Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // --- Handlers do Menu (filtros) ---
        private void viewHardwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var hardwareItems = new BindingList<InventoryItem>(allItemsBindingList.Where(item => item.Type == ItemType.Hardware).ToList());
            dataGridViewInventory.DataSource = hardwareItems; // Mostra apenas hardware
        }

        private void viewSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var softwareAndServices = new BindingList<InventoryItem>(allItemsBindingList.Where(item => item.Type == ItemType.Software || item.Type == ItemType.Service).ToList());
            dataGridViewInventory.DataSource = softwareAndServices; // Mostra software e serviços
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewInventory.DataSource = allItemsBindingList; // Mostra todos os itens da lista principal
        }

        private void exportToDATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Arquivo de Dados (*.dat)|*.dat|Todos os arquivos (*.*)|*.*";
                saveFileDialog.Title = "Salvar Inventário em Arquivo .DAT";
                saveFileDialog.FileName = "inventario_devstream.dat";
                saveFileDialog.DefaultExt = "dat";

                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                        {
                            sw.WriteLine($"--- Inventário DevStream Exportado em: {DateTime.Now} ---");
                            sw.WriteLine($"--- Usuário: {currentUser.Username} ---");
                            sw.WriteLine("---");

                            // Exporta os itens atualmente exibidos no DataGridView
                            // (que podem estar filtrados)
                            var itemsToExport = dataGridViewInventory.DataSource as IEnumerable<InventoryItem>;
                            
                            if (itemsToExport == null) // Fallback se DataSource não for IEnumerable<InventoryItem>
                            {
                                itemsToExport = allItemsBindingList;
                            }

                            if (itemsToExport != null)
                            {
                                foreach (var item in itemsToExport)
                                {
                                    sw.WriteLine(item.ToString()); // Usa o ToString() formatado
                                }
                            }
                            sw.WriteLine("--- Fim da Exportação ---");
                        }
                        MessageBox.Show("Inventário exportado com sucesso!", "Exportação Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao exportar arquivo: {ex.Message}", "Erro de Exportação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort; // Sinaliza para o LoginForm que foi logout
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Abort) // Logout
            {
                var loginForm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
                if (loginForm != null)
                {
                    loginForm.Show();
                }
                else 
                {
                    LoginForm newLoginForm = new LoginForm();
                    newLoginForm.Show();
                }
            }
            else if (e.CloseReason == CloseReason.UserClosing) // Se fechou pelo 'X' ou Alt+F4
            {
                // Pergunta se quer realmente sair
                if (MessageBox.Show("Tem certeza que deseja sair da aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true; // Cancela o fechamento
                }
                else
                {
                    Application.ExitThread(); // Garante que a aplicação feche
                }
            }
        }
    }
}