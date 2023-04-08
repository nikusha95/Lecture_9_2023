namespace Exceptions;

public class Person
{
    private readonly string _firstName;
    private readonly string _lastName;
    private readonly string _personalNumber;

    public Person(string firstName, string lastName, string personalNumber)
    {
        _firstName = firstName;
        _lastName = lastName;
        _personalNumber = personalNumber;
    }

    public override string ToString()
    {
        return $"{_firstName} {_lastName} {_personalNumber}";
    }
}