using ChapeauModel;
using ChapeauModel.Enums;
using System.Windows.Forms;

namespace ChapeauUI.Components
{
    public partial class MenuChecklist : UserControl
    {
        public MenuChecklist(List<OrderLine> lines, EOrderTime orderTime)
        {
            InitializeComponent();
            InitializeChecklist(lines, orderTime);
        }

        private void InitializeChecklist(List<OrderLine> lines, EOrderTime orderTime)
        {
            checkedListBox1.Items.Clear();
            List<OrderLine> orderLinesStarters = MenuItemSeperator(EMenuType.Starter, lines);
            List<OrderLine> orderLinesIntermediates = MenuItemSeperator(EMenuType.Intermediate, lines);
            List<OrderLine> orderLinesMains = MenuItemSeperator(EMenuType.Main, lines);
            List<OrderLine> orderLinesDesserts = MenuItemSeperator(EMenuType.Dessert, lines);
            List<OrderLine> orderLinesDrinks = MenuItemSeperator(null, lines);

            AddItemsToList(orderLinesStarters, EMenuType.Starter);
            AddItemsToList(orderLinesIntermediates, EMenuType.Intermediate);
            AddItemsToList(orderLinesMains, EMenuType.Main);
            AddItemsToList(orderLinesDesserts, EMenuType.Dessert);
            AddItemsToList(orderLinesDrinks, null);
            if (orderTime == EOrderTime.InThePast) { CheckAllItems(); }
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            AdjustCheckedListBoxHeight();
        }
        private void AddItemsToList(List<OrderLine> lines, EMenuType? menuType)
        {
            if (lines.Count == 0) { return; }

            checkedListBox1.Items.Add(menuType == null ? "Drinks:" : $"{menuType}:");

            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].OrderNote != null)
                {
                    checkedListBox1.Items.Add(lines[i]);
                }
                else
                {
                    checkedListBox1.Items.Add(lines[i]);
                }
            }
        }
        private List<OrderLine> MenuItemSeperator(EMenuType? menuType, List<OrderLine> orderLines)
        {
            List<OrderLine> orderLinesFiltered = new List<OrderLine>();
            for (int i = 0; i < orderLines.Count; i++)
            {
                if ((orderLines[i].MenuItem.MenuType == menuType) && (orderLines[i].OrderLineStatus != EOrderLineStatus.Ready))
                {
                    orderLinesFiltered.Add(orderLines[i]);
                }
            }
            return orderLinesFiltered;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (IsMainItem(e.Index))
            {
                ToggleSubItems(e.Index, e.NewValue == CheckState.Checked);
            }
            else
            {
                UpdateMainItem(e.Index, e.NewValue == CheckState.Checked);
            }
        }

        private bool IsMainItem(int index)
        {
            return !checkedListBox1.Items[index].ToString().StartsWith("  ");
        }

        private void ToggleSubItems(int mainIndex, bool isChecked)
        {
            for (int i = mainIndex + 1; i < checkedListBox1.Items.Count; i++)
            {
                if (!IsSubItem(i)) break;
                SetItemCheckState(i, isChecked);
            }
        }

        private void UpdateMainItem(int subItemIndex, bool isChecked)
        {
            int mainItemIndex = FindMainItemIndex(subItemIndex);
            if (mainItemIndex == -1) return;

            if (!isChecked)
            {
                SetItemCheckState(mainItemIndex, false);
            }
            else if (AreAllSubItemsChecked(mainItemIndex, subItemIndex))
            {
                SetItemCheckState(mainItemIndex, true);
            }
        }

        private int FindMainItemIndex(int subItemIndex)
        {
            for (int i = subItemIndex - 1; i >= 0; i--)
            {
                if (IsMainItem(i)) return i;
            }
            return -1;
        }

        private bool AreAllSubItemsChecked(int mainItemIndex, int currentSubItemIndex)
        {
            for (int i = mainItemIndex + 1; i < checkedListBox1.Items.Count; i++)
            {
                if (!IsSubItem(i)) break;
                if (i != currentSubItemIndex && !checkedListBox1.GetItemChecked(i)) return false;
            }
            return true;
        }

        private bool IsSubItem(int index)
        {
            return checkedListBox1.Items[index].ToString().StartsWith("  ");
        }

        private void SetItemCheckState(int index, bool isChecked)
        {
            checkedListBox1.ItemCheck -= checkedListBox1_ItemCheck;
            checkedListBox1.SetItemChecked(index, isChecked);
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
        }
        private void AdjustCheckedListBoxHeight()
        {
            int itemHeight = checkedListBox1.ItemHeight;
            int itemCount = checkedListBox1.Items.Count;

            // Calculate the new height
            int newHeight = itemHeight * itemCount;

            // Add some padding if needed
            newHeight += 20;

            // Set the new height
            checkedListBox1.Height = newHeight;
        }

        public List<OrderLine> GetUpdatedOrderLines() {
            List<OrderLine> checkedOrderLines = new List<OrderLine>();

            foreach (object item in checkedListBox1.CheckedItems)
            {
                // Skip the string headers
                if (item is OrderLine orderLine)
                {
                    checkedOrderLines.Add(orderLine);
                }
            }
            return checkedOrderLines;
        }
        private void CheckAllItems()
        {
            // Check all items in the CheckedListBox
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }
    }
}
