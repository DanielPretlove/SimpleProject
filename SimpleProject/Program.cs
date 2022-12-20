// See https://aka.ms/new-console-template for more information

using SimpleProject.Entities;

var service = new AdderService();
var multiplier = new MultiplierService(service);

Console.WriteLine(multiplier.MultiplyTwoNumbers(3, 5));

