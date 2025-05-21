using System;
using System.Globalization; // Para CultureInfo

public enum ItemType
{
    Hardware,
    Software,
    Service // Para itens como treinamento, suporte, etc.
}

public enum CostCategory
{
    CAPEX,
    OPEX
}

public class InventoryItem
{
    public string Name { get; set; }
    public ItemType Type { get; set; }
    public CostCategory Category { get; set; }
    public decimal Cost { get; set; } // Custo unitário para CAPEX, Anual para OPEX
    public string CostPeriod { get; set; } // Ex: "unitário", "anual"
    public int Quantity { get; set; } // Opcional, para itens como laptops
    public string UseDescription { get; set; }
    public string SourceDocumentReference { get; set; } // Para citar o documento PDF

    public InventoryItem() // Construtor padrão
    {
        Name = string.Empty;
        CostPeriod = string.Empty;
        UseDescription = string.Empty;
        SourceDocumentReference = string.Empty;
        Type = ItemType.Hardware; // Valor padrão
        Category = CostCategory.OPEX; // Valor padrão
    }

    public override string ToString()
    {
        CultureInfo brCulture = new CultureInfo("pt-BR");
        string formattedCost = Cost.ToString("C", brCulture);

        return $"Nome: {Name}\n" +
               $"  Tipo: {Type}\n" +
               $"  Categoria Custo: {Category}\n" +
               $"  Custo: {formattedCost} ({CostPeriod})\n" +
               $"  Quantidade: {(Quantity > 0 ? Quantity.ToString() : "N/A")}\n" +
               $"  Uso/Descrição: {UseDescription}\n" +
               $"  Fonte: {SourceDocumentReference}\n" +
               $"--------------------------------------------------";
    }

    // Propriedades para exibição no DataGridView
    public string DisplayName => Name;
    public string DisplayType => Type.ToString();
    public string DisplayCategory => Category.ToString();
    public string DisplayCost => $"{Cost.ToString("C", new CultureInfo("pt-BR"))} ({CostPeriod})";
    public string DisplayQuantity => (Quantity > 0 ? Quantity.ToString() : "N/A");
    public string DisplayUseDescription => UseDescription;
}