using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipeBook.Exceptions.ExceptionBase
{
    public class ErrorOnValidationException : MyRecipeBookException
    {
        public IList<string> ErrorMessages { get; set; }

        public ErrorOnValidationException(IList<string> errorMessages) 
        {
            ErrorMessages = errorMessages;
        }
    }
}
