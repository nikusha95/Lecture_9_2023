namespace Exceptions;

public class Student : Person
{
   
    private int _currentCredit;
    private int _subjectNumber;
    private  Subject[] _subjects;
    private int _currSubject;
    public Student(string firstName, string lastName, string personalNumber, int currentCredit, int subjectNumber) 
        : base(firstName, lastName, personalNumber)
    {
        _currentCredit = currentCredit;
        _subjectNumber = subjectNumber;
        _subjects = new Subject[_subjectNumber];
    }

    public void AddSubject(Subject subject)
    {
        _currSubject++;
        if (_currSubject < _subjectNumber)
        {
            _subjects[_currSubject] = subject;
        }
    }

    public void PrintSubjects()
    {
        foreach (var subject in _subjects)
        {
            Console.WriteLine(subject);
        }
    }
    public override string ToString()
    {
        return $"{base.ToString()} _credits:{_currentCredit}";
    }
}