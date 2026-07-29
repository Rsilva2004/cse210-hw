using System;


public class MathAssingment : Assingment
{
    private string _textBookSection;
    private string _problems;

    public MathAssingment(string studentName, string topic, string textBookSection, string problems)
    : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textBookSection}, Problem {_problems}";
    }
}