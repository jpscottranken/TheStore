namespace TheStore.Models
{
	public class DatabaseSimulator
	{
		//	Add the following methods:
		//	GetProducts	which will return all products
		//	GetProduct  which will return a single product needs an ID

		//	Return all products
		public static List<Product> GetProducts()
		{		//	This will be our list of products
			List<Product> products = new List<Product>()
			{	//	/Populate the list with seed data
				new Product
				{
					ProductID = 1,
					Name = "12 Pack Golf Balls",
					Price = (decimal) 24.99
				},
				new Product
				{
					ProductID = 2,
					Name = "3 Pack Tennis Balls",
					Price = (decimal) 17.99
				},
				new Product
				{
					ProductID= 3,
					Name = "MLB Baseball",
					Price = (decimal) 13.99
				},
				new Product
				{
					ProductID= 4,
					Name = "NFL Football",
					Price = (decimal) 39.99
				},
				new Product
				{
					ProductID = 5,
					Name = "MLS Soccer Ball",
					Price = (decimal) 29.99
				},
				new Product
				{
					ProductID = 6,
					Name = "NBA Basketball",
					Price = (decimal) 39.99
				},
				new Product
				{
					ProductID = 7,
					Name = "PBA Bowling Ball",
					Price = (decimal) 59.99
				},
				new Product
				{
					ProductID = 8,
					Name = "Official Softball",
					Price = (decimal) 16.99
				},
				new Product
				{
					ProductID = 9,
					Name = "PVA Volleyball",
					Price = (decimal) 23.99
				}
			};

			return products;
		}

		//	Return a single product based on the ProductID passed to it
		public static Product? GetProduct(string slug)
		{
			//	Get all products
			List<Product> products = DatabaseSimulator.GetProducts();

			//	Loop through all products looking for desired product
			foreach(Product p in products)
			{
				//	If there is a match, return the associated product
				if (p.Slug == slug)
				{
					return p;
				}
			}

			//	If no product match found, return null
			return null;
		}
	}
}
