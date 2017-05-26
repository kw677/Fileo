using Fileo.Common;
using System;

namespace Fileo.Import.Exceptions
{
    internal class IncorrectValueException : ApplicationException
    {
        private readonly int _rowIndex;
        private readonly int _columnIndex;
        private readonly string _columnName;

        public IncorrectValueException(int rowIndex, int columnIndex, string columnName)
        {
            _rowIndex = rowIndex;
            _columnIndex = columnIndex;
            _columnName = columnName;
        }
        

        public override string Message => string.Format(ErrorMessage.IncorrectValue, _rowIndex, _columnIndex, _columnName);
    }
}
