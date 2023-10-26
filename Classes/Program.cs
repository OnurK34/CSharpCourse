Classes.CustomerManager customerManager = new Classes.CustomerManager();
customerManager.Add();
customerManager.Update();

Console.WriteLine();

Classes.ProductManager productManager = new Classes.ProductManager();
productManager.Add();
productManager.Update();

Console.WriteLine();

Classes.Customer customer = new Classes.Customer();
customer.City = "İstanbul";
customer.Id = 1;
customer.FirstName = "Onur";
customer.LastName = "Kınataş";

Classes.Customer customer2 = new Classes.Customer
{
    Id = 2, City = "İzmir", FirstName = "Adem", LastName = "Kınataş"
};

Console.WriteLine(customer2.FirstName);



