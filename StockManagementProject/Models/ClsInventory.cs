namespace StockManagementProject.Models
{
    public class ClsInventory
    {
        public int SKU_Code { get; set; }
        public string? Product_Name { get; set; }
        public int Quantity { get; set; }
        public string? status { get; set; }
        public string? image { get; set; }
        public DateTime Date { get; set; }

    }
}
