namespace Microsoft.HockeyApp.DataContracts
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// This exception is used to notify the user that the set of inner exceptions has been trimmed because it exceeded our allowed send limit.
    /// </summary>
    internal class InnerExceptionCountExceededException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InnerExceptionCountExceededException"/> class.
        /// </summary>
        public InnerExceptionCountExceededException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InnerExceptionCountExceededException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error. </param>
        public InnerExceptionCountExceededException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InnerExceptionCountExceededException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception. </param><param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified. </param>
        public InnerExceptionCountExceededException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}