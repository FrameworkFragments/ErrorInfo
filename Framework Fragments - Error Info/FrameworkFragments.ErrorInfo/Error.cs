namespace FrameworkFragments.ErrorInfo
{
    internal class Error : IError
    {
        public string ErrorCode { get; }

        public Error(string errorCode)
        {
            ErrorCode = errorCode;
        }
    }
}
