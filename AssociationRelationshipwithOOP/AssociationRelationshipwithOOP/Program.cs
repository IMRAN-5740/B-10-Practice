
using AssociationRelationshipwithOOP.CarEngineModule;


Console.WriteLine("Car and Engine Mechanism is describe below : ");

Engine anEngine = new Engine("S001", "Sifing16", 16);


Car aCar = new Car(anEngine);
aCar.ModelNo = "C001";
aCar.ChasisNo = "CC00141P<M4";
aCar.Color = "Black and White";
Console.WriteLine(aCar.GetCarInformation());

aCar.Start();
aCar.Accelarate();
aCar.Stop();
Console.WriteLine("The End!");


