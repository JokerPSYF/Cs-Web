namespace TaskBoardApp.Data.Constants
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

            public const int MaxUsername = 50;

            /// <summary>
            /// Error message for the first name. It will appear when you put name bigger than {0} symbols
            /// </summary>
            public const string FNameErrorMessage = "The max length of the first name is {0} symbols";

            /// <summary>
            /// Error message for the last name. It will appear when you put name bigger than {0} symbols
            /// </summary>
            public const string LNameErrorMessage = "The max length of the last name is {0} symbols";
        }

        public static class Task
        {
            /// <summary>
            /// Maximum length of the task title
            /// </summary>
            public const int MaxTaskTitle = 70;

            /// <summary>
            /// Minimum length of the task title
            /// </summary>
            public const int MinTaskTitle = 5;

            /// <summary>
            /// Error message for the task title
            /// </summary>
            public const string ErrorMessageTaskTitle = "The length of the title has to be between {2} and {1}";

            /// <summary>
            /// Maximum length of the task description
            /// </summary>
            public const int MaxTaskDescription = 1000;

            /// <summary>
            /// Minimum length of the task description
            /// </summary>
            public const int MinTaskDescription = 10;

            /// <summary>
            /// Error message for the task title
            /// </summary>
            public const string ErrorMessageTaskDescription = "The length of the description has to be between {2} and {1}";
        }

        public static class Board
        {
            /// <summary>
            /// Maximum length of the board name
            /// </summary>
            public const int MaxBoardName = 30;

            /// <summary>
            /// Minimum length of the board name
            /// </summary>
            public const int MinBoardName = 3;

            /// <summary>
            /// Error message length of the board name
            /// </summary>
            public const string ErrorMessageBoardName = "The length of the board name has to be between {1} and {0}";
        }
    }
}
