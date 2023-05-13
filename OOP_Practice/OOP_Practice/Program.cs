// See https://aka.ms/new-console-template for more information
using OOP_Practice.SalesModule;

Console.WriteLine("Welcome to Sales Screen");
Console.WriteLine("Please Provide a Sales Record....");

Sales salesObj = new Sales();


Console.WriteLine("Provide Sales num :....");
int salesNo = Convert.ToInt32(Console.ReadLine());
salesObj.SalesNum = salesNo;

Console.WriteLine("Provide Customer Name :....");
string  customerName =Console.ReadLine();
salesObj.CustomerName = customerName;

Console.WriteLine("Provide Customer Contact :....");
string customerContact =Console.ReadLine();
salesObj.CustomerContact = customerContact;
string dateTime=DateTime.Now.ToString("dd/MMM/yyyy/hh/mm/ss/tt");

salesObj.SalesDate = dateTime;
Console.WriteLine("Provide Product name :....");
string productName = Console.ReadLine();
salesObj.ProductName = productName;

Console.WriteLine("Provide Quantity Of a Product :....");
int quantity = Convert.ToInt32(Console.ReadLine());
salesObj.Quantity = quantity;

Console.WriteLine("Provide UnitPrice Of a Product :....");
decimal unitPrice = Convert.ToDecimal(Console.ReadLine());
salesObj.UnitPrice = unitPrice;





Console.WriteLine("Your Purchase Invoice is Show Below: .........");
Console.WriteLine(salesObj.GetInvoice());