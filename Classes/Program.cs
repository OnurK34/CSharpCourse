using Classes;

CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

Console.WriteLine();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

Console.WriteLine();

Customer customer = new Customer();
customer.City = "İstanbul";
customer.Id = 1;
customer.FirstName = "Onur";
customer.LastName = "Kınataş";

Customer customer2 = new Customer
{
    Id = 2, City = "İzmir", FirstName = "Adem", LastName = "Kınataş"
};

Console.WriteLine(customer2.FirstName);



