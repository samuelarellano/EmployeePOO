namespace EmployeePOO.Exceptions
{
    public class EmployeeAddException : Exception
    {
        public EmployeeAddException() : base() { }

        public EmployeeAddException(string message) : base(message) { }

        public EmployeeAddException(string message, Exception innerException) : base(message, innerException) { }
    }
}
