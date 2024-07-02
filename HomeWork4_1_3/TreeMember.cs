namespace HomeWork4_1_3;

public class TreeMember {
    public string Name { get; set; }
    public int YearBorn { get; set; }
    public TreeMember Father { get; set; }
    public TreeMember Mother { get; set;}
    public List<TreeMember> Children { get; set; }

    public void AddChild(TreeMember child) {
        if (Children == null) {
            Children = new List<TreeMember>();
        }
        Children.Add(child);
    }

    public void RemoveChild(TreeMember child) {
        if (Children?.Contains(child) ?? false) {
            Children.Remove(child);
        }
    }

}
