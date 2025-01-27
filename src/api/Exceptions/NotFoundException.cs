using System;

namespace Boleyn.Service.Exceptions;

[Serializable]
public class NotFoundException : ArticlesException
{
    public NotFoundException(string title, string message) : base(nameof(NotFoundException), message)
    {
    }
}