using System.Text.RegularExpressions;

namespace Exceptions;

public class SubjectException : Exception
{
    private string? _code;
    private string? _title;

    public SubjectException(string message) : base(message)
    {
    }

    public SubjectException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public SubjectException(string code, string title, string? message = null) : base(message)
    {
        _code = code;
        _title = title;
    }

    public override string ToString()
    {
        if (_code != null && _title != null)
        {
            return $"code:{_code}\ntitle:{_title}";
        }

        return base.ToString();
    }
}