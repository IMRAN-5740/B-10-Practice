
//using AssociationRelationshipwithOOP.CarEngineModule;


//Console.WriteLine("Car and Engine Mechanism is describe below : ");

//Engine anEngine = new Engine("S001", "Sifing16", 16);


//Car aCar = new Car(anEngine);
//aCar.ModelNo = "C001";
//aCar.ChasisNo = "CC00141P<M4";
//aCar.Color = "Black and White";
//Console.WriteLine(aCar.GetCarInformation());

//aCar.Start();
//aCar.Accelarate();
//aCar.Stop();
//Console.WriteLine("The End!");





using AssociationRelationshipwithOOP.UniversityExample;




Student studentObj = new Student("Mohammad Imran","18CSE067","imranbsmrstu@gmail.com","380992");

Student studentObj2 = new Student("Mohammad Sahin", "18CSE051", "sahincse051@gmail.com", "5674646");
Student studentObj3 = new Student("Mohammad Apu", "18CSE051", "apubiswas@gmail.com", "01481988");

Department departmentObj = new Department("Computer Science and Engineering","CSE");
//Department departmentObj = new Department(studentObj2);
//departmentObj;

//departmentObj.Students.Add(studentObj2);
departmentObj.AddStudent(studentObj2);
departmentObj.AddStudent(studentObj3);
departmentObj.AddStudent(studentObj);


Console.WriteLine("....Student List.......\n");
string departmentReport = departmentObj.GetStudentList();
Console.WriteLine(departmentReport);

