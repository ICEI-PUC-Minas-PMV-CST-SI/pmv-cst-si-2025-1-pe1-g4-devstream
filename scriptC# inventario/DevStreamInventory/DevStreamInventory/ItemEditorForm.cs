using System;
using System.Windows.Forms;

namespace DevStreamInventory // Certifique-se que este namespace é o mesmo do seu projeto
{
    public partial class ItemEditorForm : Form
    {
        public InventoryItem CurrentItem { get; private set; }
        // private bool isEditMode; // Não estritamente necessário fora do construtor aqui

        public ItemEditorForm(InventoryItem item = null)
        {
            InitializeComponent();
            LoadComboBoxes();

            if (item == null)
            {
                this.Text = "Incluir Novo Item no Inventário";
                CurrentItem = new InventoryItem(); // Cria um novo item
                // isEditMode = false;
            }
            else
            {
                this.Text = "Alterar Item do Inventário";
                CurrentItem = item; // Usa o item existente
                // isEditMode = true;
                PopulateFields();
            }
        }

        private void LoadComboBoxes()
        {
            cmbType.DataSource = Enum.GetValues(typeof(ItemType));
            cmbCategory.DataSource = Enum.GetValues(typeof(CostCategory));
        }

        private void PopulateFields()
        {
            txtName.Text = CurrentItem.Name;
            cmbType.SelectedItem = CurrentItem.Type;
            cmbCategory.SelectedItem = CurrentItem.Category;
            numCost.Value = CurrentItem.Cost;
            txtCostPeriod.Text = CurrentItem.CostPeriod;
            numQuantity.Value = CurrentItem.Quantity;
            txtUseDescription.Text = CurrentItem.UseDescription;
            txtSourceDocumentReference.Text = CurrentItem.SourceDocumentReference;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("O nome do item não pode estar vazio.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCostPeriod.Text))
            {
                MessageBox.Show("O período do custo não pode estar vazio (ex: 'anual', 'unitário').", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCostPeriod.Focus();
                return;
            }


            CurrentItem.Name = txtName.Text;
            CurrentItem.Type = (ItemType)cmbType.SelectedItem;
            CurrentItem.Category = (CostCategory)cmbCategory.SelectedItem;
            CurrentItem.Cost = numCost.Value;
            CurrentItem.CostPeriod = txtCostPeriod.Text;
            CurrentItem.Quantity = (int)numQuantity.Value;
            CurrentItem.UseDescription = txtUseDescription.Text;
            CurrentItem.SourceDocumentReference = txtSourceDocumentReference.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}