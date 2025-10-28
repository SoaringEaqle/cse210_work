public class MathAssignment : Assignment
{

    private string _textbook;
    private string _problems;
    public MathAssignment(string name, string topic, string textbook, string problems) : base(name, topic)
    {
        _textbook = textbook;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbook} Problems {_problems}";
    }
}