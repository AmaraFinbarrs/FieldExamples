class Sample
{
    static void Main()
        {
        //local constant
        const string developerName = "Amara Finbarrs";

        //create objects
        Product product1, product2, product3;

        //create objects
        product1 = new Product();
        Product.TotalNoProducts++; // 1
        product2 = new Product();
        Product.TotalNoProducts++; // 2
        product3 = new Product();
        Product.TotalNoProducts++; // 3

        //initialize fields
        //product1
        product1.productID = 1001;
        product1.productName = "Mobile";
        product1.cost = 20000;
        product1.quantityInStock = 1200;

        //product 2
        product2.productID = 1002;
        product2.productName = "Laptop";
        product2.cost = 45000;
        product2.quantityInStock = 3400;

        //product3
        product3.productID = 1003;
        product3.productName = "Speakers";
        product3.cost = 36000;
        product3.quantityInStock = 8000;

        //get values from fields
        //Developer name
        System.Console.WriteLine("Name of Developer: " + developerName);

        //product 1
        System.Console.WriteLine("\nProduct 1: ");
        System.Console.WriteLine("Product ID: " + product1.productID);
        System.Console.WriteLine("Product Name: " + product1.productName);
        System.Console.WriteLine("Cost: " + product1.cost);
        System.Console.WriteLine("Quantity  in Stock: " + product1.quantityInStock);
        System.Console.WriteLine("Date of Purchase: " + product1.dateOfPurchase);

        //product 2
        System.Console.WriteLine("\nProduct 2: ");
        System.Console.WriteLine("Product ID: " + product2.productID);
        System.Console.WriteLine("Product Name: " + product2.productName);
        System.Console.WriteLine("Cost: " + product2.cost);
        System.Console.WriteLine("Quantity  in Stock: " + product2.quantityInStock);
        System.Console.WriteLine("Date of Purchase: " + product2.dateOfPurchase);

        //product 3
        System.Console.WriteLine("\nProduct 3: ");
        System.Console.WriteLine("Product ID: " + product3.productID);
        System.Console.WriteLine("Product Name: " + product3.productName);
        System.Console.WriteLine("Cost: " + product3.cost);
        System.Console.WriteLine("Quantity  in Stock: " + product3.quantityInStock);
        System.Console.WriteLine("Date of Purchase: " + product3.dateOfPurchase);

        int totalQuantity = product1.quantityInStock + product2.quantityInStock + product3.quantityInStock;

        System.Console.WriteLine("\nTotal Quantity: " +  totalQuantity);
        System.Console.WriteLine("\nTotal no. of Products: " + Product.TotalNoProducts);
        System.Console.WriteLine("\nCategory of Products: " + Product.CategoryName);

        double p1 = product1.cost;
        double p2 = product2.cost;
        double p3 = product3.cost;

        //to find the highest cost of the three products
        if (p1 > p2 && p1 > p3)
        {
            System.Console.WriteLine("\nProduct 1 cost more");
        }
        else if (p2 > p1 && p2 > p3)
        {
            System.Console.WriteLine("\nProduct 2 cost more");
        }
        else
        {
            System.Console.WriteLine("\nProduct 3 cost more");
        }

        System.Console.ReadKey();

    }


}
