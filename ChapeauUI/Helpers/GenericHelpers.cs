namespace ChapeauUI.Helpers
{
    public static class GenericHelpers
    {
        public static string FormatDateTime(DateTime dateTime)
        {
            // Format dateTime to <month> <day> (<day>) | <time>
            return dateTime.ToString("MMMM dd (ddd) | HH:mm");
        }
    }
}
