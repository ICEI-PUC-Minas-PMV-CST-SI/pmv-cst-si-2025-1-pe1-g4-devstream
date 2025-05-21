namespace DevStreamInventory // Certifique-se que este namespace é o mesmo do seu projeto
{
    partial class ItemEditorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.Label lblCostPeriod;
        private System.Windows.Forms.TextBox txtCostPeriod;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblUseDescription;
        private System.Windows.Forms.TextBox txtUseDescription;
        private System.Windows.Forms.Label lblSourceDocumentReference;
        private System.Windows.Forms.TextBox txtSourceDocumentReference;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.numCost = new System.Windows.Forms.NumericUpDown();
            this.lblCostPeriod = new System.Windows.Forms.Label();
            this.txtCostPeriod = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblUseDescription = new System.Windows.Forms.Label();
            this.txtUseDescription = new System.Windows.Forms.TextBox();
            this.lblSourceDocumentReference = new System.Windows.Forms.Label();
            this.txtSourceDocumentReference = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblName.Location = new System.Drawing.Point(17, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.Location = new System.Drawing.Point(137, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(285, 23);
            this.txtName.TabIndex = 1;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblType.Location = new System.Drawing.Point(17, 53);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(33, 15);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Tipo:";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(137, 50);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(180, 23);
            this.cmbType.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCategory.Location = new System.Drawing.Point(17, 83);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(94, 15);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Categoria Custo:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(137, 80);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(180, 23);
            this.cmbCategory.TabIndex = 5;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCost.Location = new System.Drawing.Point(17, 113);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(65, 15);
            this.lblCost.TabIndex = 6;
            this.lblCost.Text = "Custo (R$):";
            // 
            // numCost
            // 
            this.numCost.DecimalPlaces = 2;
            this.numCost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numCost.Location = new System.Drawing.Point(137, 111);
            this.numCost.Maximum = new decimal(new int[] {10000000, 0, 0, 0});
            this.numCost.Name = "numCost";
            this.numCost.Size = new System.Drawing.Size(120, 23);
            this.numCost.TabIndex = 7;
            this.numCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCostPeriod
            // 
            this.lblCostPeriod.AutoSize = true;
            this.lblCostPeriod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCostPeriod.Location = new System.Drawing.Point(17, 143);
            this.lblCostPeriod.Name = "lblCostPeriod";
            this.lblCostPeriod.Size = new System.Drawing.Size(85, 15);
            this.lblCostPeriod.TabIndex = 8;
            this.lblCostPeriod.Text = "Período Custo:";
            // 
            // txtCostPeriod
            // 
            this.txtCostPeriod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCostPeriod.Location = new System.Drawing.Point(137, 140);
            this.txtCostPeriod.Name = "txtCostPeriod";
            this.txtCostPeriod.Size = new System.Drawing.Size(180, 23);
            this.txtCostPeriod.TabIndex = 9;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQuantity.Location = new System.Drawing.Point(17, 173);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(72, 15);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantidade:";
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numQuantity.Location = new System.Drawing.Point(137, 171);
            this.numQuantity.Maximum = new decimal(new int[] {10000, 0, 0, 0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 23);
            this.numQuantity.TabIndex = 11;
            this.numQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblUseDescription
            // 
            this.lblUseDescription.AutoSize = true;
            this.lblUseDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUseDescription.Location = new System.Drawing.Point(17, 203);
            this.lblUseDescription.Name = "lblUseDescription";
            this.lblUseDescription.Size = new System.Drawing.Size(87, 15);
            this.lblUseDescription.TabIndex = 12;
            this.lblUseDescription.Text = "Uso/Descrição:";
            // 
            // txtUseDescription
            // 
            this.txtUseDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUseDescription.Location = new System.Drawing.Point(137, 200);
            this.txtUseDescription.Multiline = true;
            this.txtUseDescription.Name = "txtUseDescription";
            this.txtUseDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUseDescription.Size = new System.Drawing.Size(285, 75);
            this.txtUseDescription.TabIndex = 13;
            // 
            // lblSourceDocumentReference
            // 
            this.lblSourceDocumentReference.AutoSize = true;
            this.lblSourceDocumentReference.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSourceDocumentReference.Location = new System.Drawing.Point(17, 284);
            this.lblSourceDocumentReference.Name = "lblSourceDocumentReference";
            this.lblSourceDocumentReference.Size = new System.Drawing.Size(110, 15);
            this.lblSourceDocumentReference.TabIndex = 14;
            this.lblSourceDocumentReference.Text = "Fonte Documento:";
            // 
            // txtSourceDocumentReference
            // 
            this.txtSourceDocumentReference.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSourceDocumentReference.Location = new System.Drawing.Point(137, 281);
            this.txtSourceDocumentReference.Name = "txtSourceDocumentReference";
            this.txtSourceDocumentReference.Size = new System.Drawing.Size(285, 23);
            this.txtSourceDocumentReference.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(137, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.Location = new System.Drawing.Point(243, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ItemEditorForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(444, 371);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSourceDocumentReference);
            this.Controls.Add(this.lblSourceDocumentReference);
            this.Controls.Add(this.txtUseDescription);
            this.Controls.Add(this.lblUseDescription);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtCostPeriod);
            this.Controls.Add(this.lblCostPeriod);
            this.Controls.Add(this.numCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemEditorForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editor de Item";
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}