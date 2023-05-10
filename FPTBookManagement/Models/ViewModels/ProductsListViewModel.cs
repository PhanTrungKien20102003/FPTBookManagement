namespace FPTBookManagement.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Book> Books { get; set; } =Enumerable.Empty<Book>();
        public PagingInfo PagingInfo { get; set; } = new();
        public string? CurrentCategory { get; set; }
    }
}
