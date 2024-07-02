static IEnumerable<int> GetOddSquares(IEnumerable<int> numbers) {
    foreach (var number in numbers) {
        if (number % 2 == 1) {
            yield return number * number;
        }
    }
}

var squares = GetOddSquares(new[] {10 ,23,123,578,451});

foreach (var square in squares) {
    Console.WriteLine(square);
}
