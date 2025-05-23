using System.Collections.Generic;

public static class DataService
{
    public static List<InventoryItem> GetInventoryItems()
    {
        var items = new List<InventoryItem>
        {
            // CAPEX (Etapa 3, p. 5)
            new InventoryItem {
                Name = "Laptops Dell XPS 15", Type = ItemType.Hardware, Category = CostCategory.CAPEX,
                Cost = 15000, CostPeriod = "unitário", Quantity = 50,
                UseDescription = "Máquinas de alto desempenho para desenvolvedores e equipe comercial.",
                SourceDocumentReference = "Etapa 3, p. 5"
            },
            new InventoryItem {
                Name = "Periféricos (Monitores, Docks, etc.)", Type = ItemType.Hardware, Category = CostCategory.CAPEX,
                Cost = 100000, CostPeriod = "total aquisição", Quantity = 0,
                UseDescription = "Configuração ergonômica para o trabalho remoto.",
                SourceDocumentReference = "Etapa 3, p. 5"
            },

            // OPEX (anual) - Infraestrutura Cloud (AWS) (Etapa 3, p. 5)
            new InventoryItem {
                Name = "AWS EC2 (instâncias t3.xlarge)", Type = ItemType.Hardware, Category = CostCategory.OPEX,
                Cost = 240000, CostPeriod = "anual", Quantity = 0,
                UseDescription = "Servidores virtuais para CI/CD, bancos de dados e aplicações críticas.",
                SourceDocumentReference = "Etapa 3, p. 5"
            },
            new InventoryItem {
                Name = "AWS RDS (PostgreSQL Managed)", Type = ItemType.Hardware, Category = CostCategory.OPEX,
                Cost = 60000, CostPeriod = "anual", Quantity = 0,
                UseDescription = "Banco de dados gerenciado para armazenar pedidos, contratos e cotações.",
                SourceDocumentReference = "Etapa 3, p. 5"
            },
            new InventoryItem {
                Name = "AWS S3 (Armazenamento)", Type = ItemType.Hardware, Category = CostCategory.OPEX,
                Cost = 30000, CostPeriod = "anual", Quantity = 0,
                UseDescription = "Armazenamento seguro para documentos (contratos, invoices).",
                SourceDocumentReference = "Etapa 3, p. 5"
            },
            new InventoryItem {
                Name = "AWS Lambda (Serverless)", Type = ItemType.Service, Category = CostCategory.OPEX,
                Cost = 15000, CostPeriod = "anual", Quantity = 0,
                UseDescription = "Automação de processos (ex.: geração de cotações).",
                SourceDocumentReference = "Etapa 3, p. 5"
            },

            // OPEX (anual) - Segurança (Etapa 3, p. 5-6)
            new InventoryItem {
                Name = "AWS Shield (Proteção DDoS)", Type = ItemType.Software, Category = CostCategory.OPEX,
                Cost = 45000, CostPeriod = "anual", Quantity = 0,
                UseDescription = "Proteção contra ataques às APIs de pagamento e autenticação.",
                SourceDocumentReference = "Etapa 3, p. 5"
            },
            new InventoryItem {
                Name = "AWS WAF (Firewall de Aplicação Web)", Type = ItemType.Software, Category = CostCategory.OPEX,
                Cost = 18000, CostPeriod = "anual", Quantity = 0,
                UseDescription = "Filtragem de tráfego malicioso.",
                SourceDocumentReference = "Etapa 3, p. 6"
            },

            // OPEX (anual) - Ferramentas SaaS (Etapa 3, p. 6)
            new InventoryItem {
                Name = "Licenças Zoom/Slack", Type = ItemType.Software, Category = CostCategory.OPEX,
                Cost = 60000, CostPeriod = "anual", Quantity = 0,
                UseDescription = "Comunicação assíncrona e síncrona para equipes remotas.",
                SourceDocumentReference = "Etapa 3, p. 6"
            },
            new InventoryItem {
                Name = "Salesforce (CRM)", Type = ItemType.Software, Category = CostCategory.OPEX,
                Cost = 90000, CostPeriod = "anual", Quantity = 0,
                UseDescription = "Gestão de clientes e pipeline de vendas.",
                SourceDocumentReference = "Etapa 3, p. 6"
            },

            // OPEX (anual) - Backup & Disaster Recovery (Etapa 3, p. 6)
            new InventoryItem {
                Name = "AWS Backup", Type = ItemType.Software, Category = CostCategory.OPEX,
                Cost = 24000, CostPeriod = "anual", Quantity = 0,
                UseDescription = "Backup automatizado de bancos de dados e documentos.",
                SourceDocumentReference = "Etapa 3, p. 6"
            },

            // OPEX (anual) - Suporte Cloud (Etapa 3, p. 6)
            new InventoryItem {
                Name = "Suporte AWS Enterprise", Type = ItemType.Service, Category = CostCategory.OPEX,
                Cost = 120000, CostPeriod = "anual", Quantity = 0,
                UseDescription = "Suporte 24/7 para incidentes críticos.",
                SourceDocumentReference = "Etapa 3, p. 6"
            },

            // OPEX (anual) - Treinamento (Etapa 3, p. 6)
            new InventoryItem {
                Name = "Certificações AWS/DevSecOps (Treinamento)", Type = ItemType.Service, Category = CostCategory.OPEX,
                Cost = 50000, CostPeriod = "anual", Quantity = 0,
                UseDescription = "Capacitação da equipe em cloud e segurança.",
                SourceDocumentReference = "Etapa 3, p. 6"
            }
        };
        return items;
    }
}