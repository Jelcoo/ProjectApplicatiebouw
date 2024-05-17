using ChapeauModel.Enums;
using ChapeauService;

namespace ChapeauUI
{
    public partial class ChapeauPanel : Form
    {
        public ChapeauPanel()
        {
            InitializeComponent();
            KitchenBarService kitchenBarService = new KitchenBarService();
            kitchenBarService.GetPreviousCompletedOrders(EOrderDestination.Kitchen);
        }
    }
}
