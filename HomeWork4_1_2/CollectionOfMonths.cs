using System.Collections;

namespace HomeWork4_1_2;


public class CollectionOfMonths : ICollection {
    private object _ = new object();
    private MonthInfo[] innerList = null;

    public MonthInfo this[int monthIndex] {
        get {
            if (monthIndex < 0 || monthIndex > Count - 1) {
                throw new ArgumentOutOfRangeException("Некотректне значення індекса");
            }
            return innerList[monthIndex];
        }
    } 

    public bool IsLeapYear { get; private set; }

    public int Count => 12;

    public bool IsSynchronized => false;

    public object SyncRoot => _;

    public CollectionOfMonths(bool isLeapYear) {
        this.IsLeapYear = isLeapYear;

        innerList = new MonthInfo[] {
            new MonthInfo{ Number = 1, DaysCount = 31, Name = "Січень" },
            new MonthInfo{ Number = 2, DaysCount = isLeapYear ? 29 : 28, Name = "Лютий" },
            new MonthInfo{ Number = 3, DaysCount = 31, Name = "Березень" },
            new MonthInfo{ Number = 4, DaysCount = 30, Name = "Квітень" },
            new MonthInfo{ Number = 5, DaysCount = 31, Name = "Травень" },
            new MonthInfo{ Number = 6, DaysCount = 30, Name = "Червень" },
            new MonthInfo{ Number = 7, DaysCount = 31, Name = "Липень" },
            new MonthInfo{ Number = 8, DaysCount = 31, Name = "Серпень" },
            new MonthInfo{ Number = 9, DaysCount = 30, Name = "Вересень" },
            new MonthInfo{ Number = 10, DaysCount = 31, Name = "Жовтень" },
            new MonthInfo{ Number = 11, DaysCount = 30, Name = "Листопад" },
            new MonthInfo{ Number = 12, DaysCount = 31, Name = "Грудень" },
        };
    }

    public void CopyTo(Array array, int index) {
        if (index < 0 || index > Count - 1) {
            throw new ArgumentOutOfRangeException("Некотректне значення індекса");
        }

        innerList.CopyTo(array, index);
    }

    public IEnumerator GetEnumerator() {
        return innerList.GetEnumerator();
    }

    public MonthInfo GetByNumber(int number) {
        return this[number - 1];
    }

    public IEnumerable<MonthInfo> GetByDaysCount(int daysCount) {
        foreach (MonthInfo monthInfo in innerList) { 
            if (monthInfo.DaysCount == daysCount) {
                yield return monthInfo;
            }

        }
    }
}
