using FPTBookManagement.Models;

namespace FPTBookManagement.Models
{
	public class Cart
	{
		public List<CartLine> Lines { get; set; } = new List<CartLine>();

		public virtual void AddItem(Book book, int quantity)
		{
			CartLine? line = Lines.Where(p => p.Book.Id == book.Id).FirstOrDefault();
			if (line == null)
			{
				Lines.Add(new CartLine
				{
					Book = book,
					Quantity = quantity
				});
			}
			else
			{
				line.Quantity += quantity;
			}
		}

		public virtual void RemoveLine(Book book)
		{
			Lines.RemoveAll(l => l.Book.Id == book.Id);
		}

		public decimal ComputeTotalValue()
		{
			return Lines.Sum(e => e.Book.Price * e.Quantity);
		}

		public virtual void Clear() { Lines.Clear(); }



	}
	public class CartLine
	{
		public int CartLineId { get; set; }
		public Book Book { get; set; } = new();
		public int Quantity { get; set; }
	}
}
