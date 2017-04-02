using System.Collections.Generic;

namespace InlasoftWeb.Helpers
{
    public static class TabNavigationHelper
    {
        private static Dictionary<string, string> CasosGrids = new Dictionary<string, string>
        {
            {string.Empty, "_AudienciasList" },
            {"Gestiones", "_GestionesList" }

        };

        public static string SetActiveTab(string tab, string thistab)
        {
            if (tab == null) tab = "";
            if (tab == thistab)
                return "active";
            else
                return string.Empty;
        }

        public static string SetActiveGrid(string tab)
        {
            return CasosGrids[tab];
        }
    }
}
