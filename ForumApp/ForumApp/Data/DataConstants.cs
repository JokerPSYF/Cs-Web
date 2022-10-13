namespace ForumApp.Data
{
    public static class DataConstants
    {
        public static class Post
        {
            public const int TitleMin = 10;
            public const int ContentMin = 10;

            public const int TitleMax = 50;
            public const int ContentMax = 1500; 
        }

        public static class PostAnswer
        {
            public const int AnswerMax = 50;

            public const int AnswerMin = 2;
        }
    }
}
