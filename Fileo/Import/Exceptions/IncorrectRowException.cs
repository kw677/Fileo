using Fileo.Common;
using System;

namespace Fileo.Import.Exceptions
{
    internal class IncorrectRowException : ApplicationException
    {
        private readonly int _rowIndex;

        public IncorrectRowException(int rowIndex)
        {
            _rowIndex = rowIndex;
        }


        public override string Message => string.Format(ErrorMessage.IncorrectRow, _rowIndex);
    }
}
