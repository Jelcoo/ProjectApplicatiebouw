using ChapeauModel;
using ChapeauModel.Enums;
using ChapeauService;

namespace ChapeauUI.Components
{
    public partial class CompleteOrderTemplate : UserControl
    {
        private Order _order;
        private KitchenBarService _kitchenBarService;
        private MenuChecklist _checklist;
        public CompleteOrderTemplate(Order order)
        {
            InitializeComponent();
            _order = order;
            _kitchenBarService = new KitchenBarService();
        }

        private void CompleteOrderTemplate_Load(object sender, EventArgs e)
        {
            orderedAtLabel.Text = $"Ordered at: {_order.OrderedAt.ToString("t")}";
            _checklist = new MenuChecklist(_order.OrderLines);
            LayoutOrderPanel.Controls.Add(_checklist);
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            List<OrderLine> lines = _checklist.GetUpdatedOrderLines();
            if (lines.Count == 0) return; 
            foreach (OrderLine line in lines) 
            {
                line.OrderLineStatus = EOrderLineStatus.Ready;
            }
            _order.SetOrderLines(lines);
            _kitchenBarService.UpdateOrderLinesStatus(_order);
        }
    }
}
