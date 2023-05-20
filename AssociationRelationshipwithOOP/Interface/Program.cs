
using InterfaceExample.FileSystems;
using File = InterfaceExample.FileSystems.File;


List<File> fileContainer = new List<File>();

var obj1 = new AccountOpeningFille();
obj1.FileNum = "File001";
obj1.FileName = "Bank Account File\n";
obj1.CreatedDate = DateTime.Now.ToString("dd:MMM:yyyy:hh::mm:tt");
obj1.CreatedBy = "Mohammad Imran";
obj1.AccountName = "Bank Account";
obj1.AccountNum = "BA001\n";
var  obj2=new CustomerFile();

obj2.FileNum = "CFile--001";
obj2.FileName = "Customr File";
obj2.CustomerName = "Mr Anik\n";
obj2.CustomerNo = "MRAnik--1\n";
obj2.ShippingAddress = "Bashundhara, Dhaka, Bangladesh";
fileContainer.Add(obj1);
fileContainer.Add(obj2);


foreach(IFileInfo fileInfo in fileContainer)
{
    Console.WriteLine(fileInfo.GetInfo());
}












