using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xero.Api.Infrastructure.Exceptions
{
  public class ValidationExceptionWithApiException : ValidationException
  {
    public ApiException ApiException { get; private set; }

    public ValidationExceptionWithApiException(ApiException apiException) : base(apiException)
    {
      ApiException = apiException;
    }
  }
}
