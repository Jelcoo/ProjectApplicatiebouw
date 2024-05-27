using ChapeauModel;
using ChapeauService;

namespace ChapeauUI
{
    internal static class Program
    {
        public static List<Menu> Menus;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MenuService menuService = new MenuService();
            Menus = menuService.GetMenus();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new OrderUI.OrderHome());
        }
    }
}
