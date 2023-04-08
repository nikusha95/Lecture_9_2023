namespace Exceptions;

public class Subject
{
    private readonly string _name;
    private readonly int _credit;
    private readonly int _numOfHours;
    private readonly int _maxNumberOfStudents;
    private int _point;
    private const int MaxPoint = 100;
    private readonly Subject?[] _prerequisites;

    public Subject(string name, int credit, int numOfHours, Subject[]? prerequisites, int maxNumberOfStudents)
    {
        _name = name;
        _credit = credit;
        _numOfHours = numOfHours;
        _prerequisites = prerequisites;
        _maxNumberOfStudents = maxNumberOfStudents;
    }

    public void AddPrerequisites()
    {
        //not implemented yet;
    }

    public void SetPoint(int point)
    {
        if (point > MaxPoint)
        {
            throw new SubjectException("InvalidPoint", $"point {point} is invalid");
        }

        _point = point;
    }

    public override string ToString()
    {
        return $"{_name} credit:{_credit}, hours: {_numOfHours} max students:{_maxNumberOfStudents}";
    }
}