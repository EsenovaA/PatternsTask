// See https://aka.ms/new-console-template for more information

using AbsractFactory;

Console.WriteLine("Welcome to the restaurant!");

var restaurant = new Restaurant();

restaurant.CookMasala(new Cooker(), Country.England, DateTime.Now);