using HomeWork4_1_3;

var royalTree = new FamilyTree();

var elizabeth2 = royalTree.Add("Queen Elizabeth II", 1926);
var philip3 = royalTree.Add("Prince Philip", 1921);

var charles = royalTree.Add("Charles III", 1948, philip3, elizabeth2);
var diana = royalTree.Add("Diana, Princess of Wales", 1961);

var william = royalTree.Add("William, Prince of Wales", 1982, charles, diana);
var harry = royalTree.Add("Prince Harry, Duke of Sussex", 1984, charles, diana);

var catherine = royalTree.Add("Catherine, Princess of Wales", 1982);
var meghan = royalTree.Add("Meghan, Duchess of Sussex", 1981);

var george = royalTree.Add("Prince George of Wales", 2013, william, catherine);
var charlotte = royalTree.Add("Princess Charlotte of Wales", 2015, william, catherine);
var louis = royalTree.Add("Prince Louis of Wales", 2018, william, catherine);

var archie = royalTree.Add("Prince Archie of Sussex", 2019, harry, meghan);
var lilibet = royalTree.Add("Princess Lilibet of Sussex", 2021, harry, meghan);

Console.WriteLine("Successors of Elizabeth ||");
Console.WriteLine(new string('=', 30));
royalTree.DisplaySuccessors(elizabeth2);
Console.WriteLine();


Console.WriteLine("Successors of William");
Console.WriteLine(new string('=', 30));
royalTree.DisplaySuccessors(william);
Console.WriteLine();

Console.WriteLine("Born at 1982");
Console.WriteLine(new string('=', 30));
foreach (var member in royalTree.FindByBornYear(1982))
    Console.WriteLine($"{member.Name}");
Console.WriteLine();