using System;
using Microsoft.EntityFrameworkCore.Query.ExpressionTranslators.Internal;

namespace Greeting_Website
{
    public interface TimeGetterInterface
    {
        DateTime GetDateTime();
    }
}