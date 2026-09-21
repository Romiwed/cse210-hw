// First order - customer in the USA
Address address1 = new Address(
    "123 Main Street",
    "Dallas",
    "Texas",
    "USA"
);

Customer customer1 = new Customer("John Smith", address1);

Order order1 = new Order(customer1);
order1.AddProduct(new Product("Laptop Stand", "P001", 25.00, 2));
order1.AddProduct(new Product("Wireless Mouse", "P002", 20.00, 1));
order1.AddProduct(new Product("USB Cable", "P003", 8.00, 3));


// Second order - customer outside the USA
Address address2 = new Address(
    "45 Via Roma",
    "Milan",
    "Lombardy",
    "Italy"
);

Customer customer2 = new Customer("Maria Rossi", address2);

Order order2 = new Order(customer2);
order2.AddProduct(new Product("Keyboard", "P004", 30.00, 1));
order2.AddProduct(new Product("Headphones", "P005", 40.00, 2));


// Put the orders in a list
List<Order> orders = new List<Order>();
orders.Add(order1);
orders.Add(order2);


// Display each order
int orderNumber = 1;

foreach (Order order in orders)
{
    Console.WriteLine($"ORDER {orderNumber}");
    Console.WriteLine();

    Console.WriteLine("Packing Label:");
    Console.WriteLine(order.GetPackingLabel());

    Console.WriteLine("Shipping Label:");
    Console.WriteLine(order.GetShippingLabel());

    Console.WriteLine();
    Console.WriteLine($"Total Price: ${order.GetTotalPrice():F2}");
    Console.WriteLine();
    Console.WriteLine("------------------------------");
    Console.WriteLine();

    orderNumber++;
}