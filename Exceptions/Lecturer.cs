using System.Globalization;

namespace Exceptions;

public class Lecturer : Person
{
    private readonly int _maxSubjectNumbers;
    private readonly Subject?[] _subjects;

    public Lecturer(string firstName, string lastName, string personalNumber) : base(firstName, lastName, personalNumber)
    {
    }
}