// See https://aka.ms/new-console-template for more information

using Factory;
using Factory.Factories;
using Factory.Models;

Console.WriteLine("Trades");
var trades = Helper.CreateTrades();

var barclaysBankFilterFactory = new BarclaysBankFilterFactory();

var usaBarclaysTrades = barclaysBankFilterFactory.Filter.FilterForBank(trades, Country.USA);
Console.WriteLine($"USA Barclays trades: {string.Join(';', usaBarclaysTrades.Select(t=>t.Name))}");

var englandBarclaysTrades = barclaysBankFilterFactory.Filter.FilterForBank(trades, Country.England);
Console.WriteLine($"England Barclays trades: {string.Join(';', englandBarclaysTrades.Select(t => t.Name))}");

