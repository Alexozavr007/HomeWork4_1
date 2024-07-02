namespace HomeWork4_1_2;

public class MonthInfo {
    public int Number {  get; set; }
    public int DaysCount {  get; set; }
    public string Name { get; set; }

    public override string ToString() {
        return $"#{Number} {Name} ({DaysCount})";
    }
}
