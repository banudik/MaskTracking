using Business.Concrete;
using Entities.Concrete;

//string message = "Merhaba";
//double amount = 100000; //db den gelir
//int number = 100;
//bool login = false;

//string name = "Banu";
//string surname = "Dik";
//int birthYear = 1995;
//long idNo = 12345678910; //long cok daha kapsamlı int e göre


//Console.WriteLine(message);
//Console.WriteLine(amount * 1.18);

//Citizen citizen1 = new Citizen(); //instance oluşturduk
//citizen1.FirstName = "Test";

//SayHi(name:"Banu");
//SayHi(name:"Ali");
//SayHi();

//int result = Sum(6,58);

////Diziler / Arrays
////Array,class,interface,abstract referance type
//string student1 = "Banu";
//string student2 = "Ali";
//string student3 = "Saadet";

//Console.WriteLine(student1);
//Console.WriteLine(student2);
//Console.WriteLine(student3);

//string[] students = new string[3];
//students[0] = "Banu";
//students[1] = "Ali";
//students[2] = "Saadet";

//students = new string[4];
//students[3] = "Kadir";

//for (int i = 0; i < students.Length; i++)
//{
//    Console.WriteLine(students[i]);
//}

//string[] cities1 = new[] { "Ankara", "İstanbul", "İzmir" };
//string[] cities2 = new[] { "Bursa", "Ordu", "Diyarbakır" };

//cities2 = cities1;
//cities1[0] = "Adana";

//Console.WriteLine(cities2[0]);


//int,double,bool value(değer) type
//int number1 = 10;
//int number2 = 20;
//number2 = number1;
//number1 = 30;

//foreach (string city in cities1)
//{
//    Console.WriteLine(city);
//}

//List<string> newCities1= new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
//newCities1.Add("Adana 1");

//foreach (string city in newCities1)
//{
//    Console.WriteLine(city);
//}


//static void SayHi(string name="isimsiz")
//{
//    Console.WriteLine("Merhaba " + name);
//}


//static int Sum(int number1=5, int number2=10)
//{
//    int result = number1 + number2;
//    Console.WriteLine("Toplam: " + result);
//    return result;
//}

////pascal casing
//public class Citizen
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public int BirthYear { get; set; }
//    public long IdNo { get; set;}
//}

Citizen citizen1 = new Citizen();
citizen1.FirstName = "Banu";
citizen1.LastName = "Dik";
citizen1.DateOfBirthYear = 1995;
citizen1.NationalIdentity = 123;

Citizen citizen2 = new Citizen();
citizen2.FirstName = "Kadir";

PttManager pttManager = new PttManager(new CitizenManager());
pttManager.GiveMask(citizen1);

Console.ReadLine();