namespace TheStore.Models
{
	public class Product
	{
		public int ProductID { get; set; }
		public string? Name { get; set; }
		public decimal Price {  get; set; }

		//	We will be creating "easy URLs".
		//	This means that we will have a "-"
		//	instead of %20 for blank fields.
		public string? Slug => Name?.Replace(' ', '-');
	}
}
