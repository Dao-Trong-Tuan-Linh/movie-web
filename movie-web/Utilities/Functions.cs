namespace movie_web.Utilities
{
    public class Functions
    {
        public static string TitleslugGeneration(string type,string title,long id)
        {
            string sTitle = type + "-" + SlugGenerator.SlugGenerator.GenerateSlug(title) + "-" + id.ToString() + ".html";
            return sTitle;
        }
    }
}
