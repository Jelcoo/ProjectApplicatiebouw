using ChapeauModel;
using ChapeauService;
using ChapeauUI.Helpers;

namespace ChapeauUI
{
    internal static class Program
    {
        private static Restaurant _restaurant;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _restaurant = Restaurant.GetInstance();

            MenuService menuService = new MenuService();
            List<Menu> menuList = menuService.GetMenus();
            _restaurant.SetMenus(menuList);
            _restaurant.SetSelectedTable(new Table(1, false));
            _restaurant.SetLoggedInEmployee(new Employee(1, "John Doe", "1234", DateTime.Now, ChapeauModel.Enums.ERole.Manager));

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new TableUI.TableHome());
        }
    }
}
