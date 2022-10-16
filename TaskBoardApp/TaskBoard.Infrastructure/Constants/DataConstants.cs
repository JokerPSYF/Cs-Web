namespace TaskBoard.Infrastructure.Constants
{
    public static class DataConstants
    {
        public static class User
        {
            /// <summary>
            /// The maximum length of the first name
            /// </summary>
            public const int FNameMax = 15;

            /// <summary>
            /// The maximum length of the last name
            /// </summary>
            public const int LNameMax = 15;

            /// <summary>
            /// Error message for the first name. It will appear when you put name bigger than {0} symbols
            /// </summary>
            public const string FNameErrorMessage = "The max length of the first name is {0} symbols";

            /// <summary>
            /// Error message for the last name. It will appear when you put name bigger than {0} symbols
            /// </summary>
            public const string LNameErrorMessage = "The max length of the last name is {0} symbols";
        }
    }
}
