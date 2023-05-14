namespace FPTBookManagement.Models.ViewModels
{
	public class ProductAdminEditorViewModel
	{
		
		
		public Book Product { get; set; } = new Book();

		public List<Category> Categories { get; set; }

		public ProductAdminEditorViewModel() { }

		public ProductAdminEditorViewModel(Book product, List<Category> categories)
		{
			Product = product;
			Categories = categories;
		}
		public ProductAdminEditorViewModel(List<Category> categories)
		{
			Categories = categories;
		}
	}
}
