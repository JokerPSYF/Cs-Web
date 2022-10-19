namespace Watchlist.Data.Constants
{
    public static class DataConstants
    {
        /// <summary>
        /// This is a default error message
        /// </summary>
        public const string ErrorMessage = "The length of {0} has to be between {2} and {1}";

        public static class UserConstants
        {
            /// <summary>
            /// UserName maximum length
            /// </summary>
            public const int MaxName = 20;
            
            /// <summary>
            /// UserName minimum length
            /// </summary>
            public const int MinName = 5;

            /// <summary>
            /// Email maximum length
            /// </summary>
            public const int MaxEmail = 60;

            /// <summary>
            /// Email minimum length
            /// </summary>
            public const int MinEmail= 10;

            /// <summary>
            /// Password manimum length
            /// </summary>
            public const int MaxPassword  = 20;

            /// <summary>
            /// Password maximum length
            /// </summary>
            public const int MinPassword = 5;

            /// <summary>
            /// User name error message
            /// </summary>
            //public const string NameErrorMsg = "The length of {0} has to be between {2} and {1}";

            ///// <summary>
            ///// Email error message
            ///// </summary>
            //public const string EmailErrorMsg = "The length of {0} has to be between {2} and {1}";

            ///// <summary>
            ///// Password error message
            ///// </summary>
            //public const string PasswordErrorMsg = "The length of {0} has to be between {2} and {1}";
        }

        public static class MovieConstants
        {
            /// <summary>
            /// Title maximum length
            /// </summary>
            public const int MaxTitle= 50;
            
            /// <summary>
            /// Title minimum length
            /// </summary>
            public const int MinTitle= 5;

            /// <summary>
            /// Director name maximum length
            /// </summary>
            public const int MaxDirector = 50;
            
            /// <summary>
            /// Director name minimum length
            /// </summary>
            public const int MinDirector = 5;

            /// <summary>
            /// Rate maximum length
            /// </summary>
            public const decimal MaxRate = 10.00m;
            
            /// <summary>
            /// Rate minimum length
            /// </summary>
            public const decimal MinRate = 00.00m;
        } 

        public static class GenreConstants
        {
            /// <summary>
            /// Name maximum length
            /// </summary>
            public const int MaxName = 50;

            /// <summary>
            /// Name minimum length
            /// </summary>
            public const int MinName = 5;
        }

    }
}
