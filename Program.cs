using ConsoleApp1;
using ConsoleApp1.EntityDataModel;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// test add person and view it
Console.WriteLine("I'm testing saving one person records!");
Test1DbContext ctx = new Test1DbContextFactory().CreateDbContext(new string[0]);

Person per1 = new Person { Name = "Anang", Age=13, Address="Sidoarjo", Profession="Programmer"};
ctx.Persons.Add(per1);
ctx.SaveChanges();
Console.WriteLine("Done saving one person records!");

Console.WriteLine("Now I'm gonna show it to you");
foreach (var person in ctx.Persons)
{
    Console.WriteLine("Id " + person.Id + " Name " + person.Name);
}