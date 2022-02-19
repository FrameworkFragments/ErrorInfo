using System;

namespace FrameworkFragments.ErrorInfo
{
    public static class ErrorFactory
    {
        public static IError FromClassConstant(string classConstant)
        {
            return new Error(classConstant);
        }

        public static IError FromException(Exception exception)
        {
            return new Error(exception.Message);
        }
    }
}