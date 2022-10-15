namespace ForumApp.Data
{
    /// <summary>
    /// Data layer constants
    /// </summary>
    public static class DataConstants
    {
        /// <summary>
        /// Constants for class Post
        /// </summary>
        public static class Post
        {
            /// <summary>
            /// Minimum Length for the title
            /// </summary>
            public const int TitleMin = 10;

            /// <summary>
            /// Minimum Length for the content
            /// </summary>
            public const int ContentMin = 10;

            /// <summary>
            /// Maximum length for the title
            /// </summary>
            public const int TitleMax = 50;

            /// <summary>
            /// Maximum length for the content
            /// </summary>
            public const int ContentMax = 1500; 
        }
    }
}
