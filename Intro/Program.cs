﻿using Intro.Business;
using Intro.Emtities;
using Intro.Entities;

Console.WriteLine("Hello, World!");


string message1 = "Krediler";
int term = 12;
double amount = 100000.5;

//variable -->camelCase
bool isAuthentiction = true;
Console.WriteLine(message1);

//condition
if (isAuthentiction)   //(isAuthentiction==true)
{
    Console.WriteLine("Buton--->Hoşgeldin Songül");
}
else
{
    Console.WriteLine("Buton--->Sisteme giriş yap");
}


string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" }; //dbden gelecek
//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";

      //start ;  condition      ; increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}


CourseManager courseManager = new CourseManager();
Course[] courses2 =courseManager.GetAll();

for (int i = 0;i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + "/" + courses2[i].Price);
}

Console.WriteLine("Kod bitti");

IndividualCustomer customer1 =new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "1234567890";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "12345678123";
customer2.FirstName = "özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123456";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "3214586";
customer3.TextNumber="1234567890";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "32145456";
customer4.TextNumber = "9874567890";

int number1 = 10;
int number2 = 20;
number1 = number2;
Console.WriteLine(number1);

string[] cities1 = { "Ankara", "İstanbul","İzmir"};
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

cities1= cities2;
cities1[0] = "Adana";

Console.WriteLine(cities2[0]);

//value type -->int,bool,double.....
//referance type -->array,class,interface....


BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}

