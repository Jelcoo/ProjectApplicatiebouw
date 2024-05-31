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
        private EOrderTime _orderTime;

        public CompleteOrderTemplate(Order order, EOrderTime orderTime)
        {
            InitializeComponent();
            _order = order;
            _orderTime = orderTime;
            _kitchenBarService = new KitchenBarService();
        }

        private void CompleteOrderTemplate_Load(object sender, EventArgs e)
        {
            orderedAtLabel.Text = $"Ordered at: {_order.OrderedAt.ToString("t")}";
            _checklist = new MenuChecklist(_order.OrderLines, _orderTime);
            LayoutOrderPanel.Controls.Add(_checklist);
            if (_orderTime == EOrderTime.InThePast) 
            {
                StartPreparingBTN.Enabled = false;
                ReadyButton.Enabled = false;
            }
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            List<OrderLine> lines = _checklist.GetUpdatedOrderLines();
            if (lines.Count == 0) 
            {
                MessageBox.Show("Please select some items that are done!");
            }
            foreach (OrderLine line in lines)
            {
                line.OrderLineStatus = EOrderLineStatus.Ready;
            }
            _order.SetOrderLines(lines);
            _kitchenBarService.UpdateOrderLinesStatus(_order);
        }

        private void StartPreparingBTN_Click(object sender, EventArgs e)
        {
            List<OrderLine> lines = _order.OrderLines;
            foreach (OrderLine line in lines)
            {
                line.OrderLineStatus = EOrderLineStatus.Preparing;
            }
            _order.SetOrderLines(lines);
            _kitchenBarService.UpdateOrderLinesStatus(_order);
            StartPreparingBTN.Enabled = false;
        }
    }
}
