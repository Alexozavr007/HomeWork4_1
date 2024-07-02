using HomeWork4_1_2;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

var year2024 = new CollectionOfMonths(false);
Console.WriteLine($@"
    count: {year2024.Count}
    1st mo: {year2024.GetByNumber(1)}");

Console.WriteLine();
Console.WriteLine("Місяці в яких 30 днів");
foreach(var item in year2024.GetByDaysCount(30)) {
    Console.WriteLine($"\t{item}");
}