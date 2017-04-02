namespace InlasoftWeb.Helpers
{
    public static class TabNavigationHelper
    {
        public static string SetActiveTab(string tab, string thistab)
        {
            if (tab == null) tab = "";
            if (tab == thistab)
                return "active";
            else
                return string.Empty;
        }
    }
}
