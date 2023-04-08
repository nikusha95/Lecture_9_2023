// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using Exceptions;


int x = 10;
var y = 0;


int? x1 = null;
int x2 = 0;
try
{
    Console.WriteLine(x/y);
}
catch (Exception e)
{
    Console.WriteLine("invalid data");
}

Console.WriteLine("next");


Subject subject = new Subject("C#",5,4,null,40);

try
{
    subject.SetPoint(200);
}
catch (SubjectException e)
{
    Console.WriteLine(e.ToString());
}
catch (OverflowException e)
{
    Console.WriteLine(e.ToString());
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("finally");
}