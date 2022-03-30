using System;

namespace Statistics.Helper
{
    public static partial class ArgumentCheckExtension
    {
        public static T Null<T>(this IArgumentCheck check, T input, string parameterName, string message = null)
        {
            if(input is null)
            {
                if(!string.IsNullOrEmpty(message))
                {
                    throw new ArgumentNullException(message);
                }
                throw new ArgumentNullException(parameterName);
            }

            return input;
        }
    }
}