using ChapeauModel;
using ChapeauModel.Enums;
using ChapeauModel.Interfaces;
using ChapeauService;
using ChapeauUI.KitchenUI;

namespace ChapeauUI.Components
{
    public partial class CompleteOrderTemplate : UserControl
    {
        private Order _order;
        private KitchenBarService _kitchenBarService;
        private MenuChecklist _checklist;
        private EOrderTime _orderTime;
        private IKitchenBar _form;
        public int ChecklistCount { get; private set; }

        public CompleteOrderTemplate(Order order, EOrderTime orderTime, IKitchenBar form)
        {
            InitializeComponent();
            _order = order;
            _orderTime = orderTime;
            _kitchenBarService = new KitchenBarService();
            _form = form;
            _checklist = new MenuChecklist(_order.OrderLines, _orderTime);
            ChecklistCount = _checklist.ChecklistCount;
        }

        private void CompleteOrderTemplate_Load(object sender, EventArgs e)
        {
            orderedAtLabel.Text = $"Ordered at: {_order.OrderedAt.ToString("t")}";
            LayoutOrderPanel.Controls.Add(_checklist);
            if (_orderTime == EOrderTime.InThePast) 
            {
                StartPreparingBTN.Enabled = false;
                ReadyButton.Enabled = false;
            }
            if (CheckPreparingStatus())
            {
                StartPreparingBTN.Enabled = false;
            }
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            if (StartPreparingBTN.Enabled)
            {
                MessageBox.Show("Please click start preparing first");
                return;
            }
            List<OrderLine> lines = _checklist.GetUpdatedOrderLines();
            if (lines.Count == 0) 
            {
                MessageBox.Show("Please select some items that are done!");
                return;
            }
            foreach (OrderLine line in lines)
            {
                line.OrderLineStatus = EOrderLineStatus.Ready;
            }
            _order.SetOrderLines(lines);
            _kitchenBarService.UpdateOrderLinesStatus(_order);
            _form.Addpanel(EOrderTime.Current);
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
            _form.Addpanel(EOrderTime.Current);
        }
        private bool CheckPreparingStatus()
        {
            int preparing = 0;
            foreach (OrderLine line in _order.OrderLines)
            {
                if (line.OrderLineStatus == EOrderLineStatus.Preparing) preparing++;
            }
            return preparing > 0;
        }
    }
}
