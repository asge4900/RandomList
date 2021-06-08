using RandomListLibrary;
using System;
using System.Linq;

ListNumberService service = new();

var mylist = service.GetRandomList(2000);

foreach (var item in mylist)
{
    Console.WriteLine(item);
}

Console.WriteLine();
Console.WriteLine($"Sum: {mylist.Sum()}");