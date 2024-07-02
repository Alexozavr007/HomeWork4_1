using System.Collections;

namespace HomeWork4_1_3;

public class FamilyTree : ICollection<TreeMember> {
    private List<TreeMember> _members;

    public int Count => throw new NotImplementedException();

    public bool IsReadOnly => throw new NotImplementedException();

    public FamilyTree() {
        _members = new List<TreeMember>();
    }

    public void Add(TreeMember item) {
        _members.Add(item);
    }

    public TreeMember Add(string name, int bornYear, TreeMember father = null, TreeMember mother  = null) {
        var newMember = new TreeMember { 
            Name = name,
            YearBorn = bornYear,
            Father = father,
            Mother = mother,
            Children = new List<TreeMember>()
        };
        _members.Add(newMember);

        father?.AddChild(newMember);
        mother?.AddChild(newMember);

        return newMember;
    }

    public void Clear() {
        _members?.Clear();
    }

    public bool Contains(TreeMember item) {
        return _members.Contains(item);
    }

    public void CopyTo(TreeMember[] array, int arrayIndex) {
        _members.CopyTo(array, arrayIndex);
    }

    public IEnumerator<TreeMember> GetEnumerator() {
        return _members.GetEnumerator();
    }

    public bool Remove(TreeMember item) {
        item.Father?.RemoveChild(item);
        item.Mother?.RemoveChild(item);

        if (item.Children != null) {
            foreach(var subItem in item.Children) {
                Remove(subItem);
            }
        }
        return _members.Remove(item);
    }

    public IEnumerable<TreeMember> GetSuccessors(TreeMember member) {
        if (member.Children != null) {
            foreach(var item in member.Children) {
                yield return item;
                    
                foreach(var subChild in GetSuccessors(item)) {
                    yield return subChild;
                }
            }
        }
    }

    private void DisplayMember(TreeMember member, int level) {
        Console.WriteLine($"{new string('\t', level)}{member.Name} ({member.YearBorn})");
    }

    public void DisplaySuccessors(TreeMember member) {
        DisplaySuccessors(member, 0);
    }

    private void DisplaySuccessors(TreeMember member, int level) {
        if (member.Children != null) {
            foreach (var item in member.Children) {
                DisplayMember(item, level);

                if (item.Children != null) {
                    foreach (var subChild in item.Children) {
                        DisplayMember(subChild, level + 1);
                        DisplaySuccessors(subChild, level + 2);
                    }
                }
            }
        }
    }

    public IEnumerable<TreeMember> FindByBornYear(int year) {
        foreach (var member in _members)
            if (member.YearBorn == year)
                yield return member;
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }
}
