namespace FPTBookManagement.Models
{
	public class Cart
	{
		public long? CartId { get; set; }
		public long PersonId { get; set; }
		public List<CartDetails> Carts { get; set; } = new List<CartDetails>();
		public void AddItem(Book book, int quantity)
		{
			CartDetails? cart = Carts.Where(b => b.Book.Id == book.Id).FirstOrDefault();

			if(cart == null)
			{
				Carts.Add(new CartDetails
				{
					Book = book,
					Quantity= quantity
				});
			}
			else
			{
				cart.Quantity += quantity;
			}
		}


		public void RemoveItem(Book book) => Carts.RemoveAll(l => l.Book.Id == book.Id);

		public decimal ComputeTotalValue() => Carts.Sum(e => e.Book.Price * e.Quantity);

		public void Clear() => Carts.Clear();
	}
	public class CartDetails
	{
		public int CartDetailsId { get; set; }
		public Book Book { get; set; } = new();
		public int Quantity { get; set; }



	}
}
