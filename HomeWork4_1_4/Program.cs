using HomeWork4_1_4;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

var transleter = new Translater();

transleter.Add("Автомобіль", "ыёё", "Car");
transleter.Add("Літак", "ыуыф", "Plane");

Console.WriteLine("Словник:");

foreach (var trans in transleter) {
    Console.WriteLine($" {trans.Ukr} / {trans.Eng} / {trans.Rus}" );
}
Console.WriteLine();

Console.WriteLine($"Літак енгл. мовою: {transleter.TranslateToEng("Літак")}");
