using System.Collections;

namespace HomeWork4_1_4;

public class Translater : IEnumerable<TranslationItem>{
    private Dictionary<string, TranslationItem> innerList = new Dictionary<string, TranslationItem>(); 

    public void Add(string ukr, string rus, string eng) {
        if (innerList.ContainsKey(ukr)) {
            throw new Exception("Таке слово вже є в перекладачу");
        }
        var item = new TranslationItem { 
             Eng = eng,
             Rus = rus,
             Ukr = ukr
        };
        innerList.Add(ukr, item);
    }

    public string TranslateToEng(string ukr) {
        if (innerList.ContainsKey(ukr)) {
            return innerList[ukr].Eng;
        }else {
            throw new Exception("Немає перекладу для цього слова");
        }

    }

    public string TranslateToRus(string ukr) {
        if (innerList.ContainsKey(ukr)) {
            return innerList[ukr].Rus;
        } else {
            throw new Exception("Немає перекладу для цього слова");
        }

    }

    public IEnumerator<TranslationItem> GetEnumerator() {
        return innerList.Values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }
        
}
