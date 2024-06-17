using ChapeauModel;
using ChapeauService;

namespace ChapeauUI.IncomeUI
{
    public partial class IncomeUI : Form
    {
        public IncomeUI()
        {
            InitializeComponent();
            SetSingleDate();
            cbSingleDay.Checked = true;
            SetAllTimeIncome();
        }

        private void SetSingleDate()
        {
            dtpStartDay.Value = DateTime.Today;

            dtpEndDay.Visible = false;
            lblSelectEndDateText.Visible = false;
            lblSelectDateText.Text = "Select Date:";
        }

        private void SetDoubleDate()
        {
            DateTime today = DateTime.Today;
            dtpEndDay.Value = today;
            dtpStartDay.Value = today.AddDays(-1);

            dtpEndDay.Visible = true;
            lblSelectEndDateText.Visible = true;
            lblSelectDateText.Text = "Select Start Date:";
        }

        private void SetAllTimeIncome()
        {
            IncomeService incomeService = new IncomeService();
            lblAllTimeIncome.Text = incomeService.GetAllTimeIncome().ToString("€ 0.00");
        }

        private void ClearIncome()
        {
            lblIncomeByDate.Text = "€ 0.00";
        }

        private double GetIncome()
        {
            IncomeService incomeService = new IncomeService();
            double income = 0;

            if (cbSingleDay.Checked)
            {
                income = incomeService.GetIncome(dtpStartDay.Value);
            }
            else if (!cbSingleDay.Checked)
            {
                income = incomeService.GetIncome(dtpStartDay.Value, dtpEndDay.Value);
            }

            return income;
        }

        private void SetIncome(double income)
        {
            lblIncomeByDate.Text = income.ToString("€ 0.00");
        }

        private bool CheckIfInFuture(DateTime date)
        {
            if (date > DateTime.Today)
            {
                MessageBox.Show("Can't select date in future");
                return true;
            }
            return false;
        }

        private bool CheckIfEndDateIsBeforeStartDate()
        {
            if (dtpStartDay.Value > dtpEndDay.Value)
            {
                MessageBox.Show("End day can't be before start day");
                return true;
            }
            return false;
        }

        private void cbSingleDay_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbSingleDay.Checked)
            {
                SetDoubleDate();
            }
            else if (cbSingleDay.Checked)
            {
                SetSingleDate();
            }
        }

        private void dtpEndDay_ValueChanged(object sender, EventArgs e)
        {
            // Double Day Income
            ClearIncome();
            if (!cbSingleDay.Checked && !CheckIfEndDateIsBeforeStartDate())
            {
                GetIncome();
            }
        }

        private void dtpStartDay_ValueChanged(object sender, EventArgs e)
        {
            // Single Day Income
            if (cbSingleDay.Checked && !CheckIfInFuture(dtpStartDay.Value))
            {
                SetIncome(GetIncome());
            }
            // Double Day Income
            else if (!cbSingleDay.Checked && !CheckIfInFuture(dtpStartDay.Value) && !CheckIfEndDateIsBeforeStartDate())
            {
                SetIncome(GetIncome());
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ChapeauPanel chapeauPanel = new ChapeauPanel();
            chapeauPanel.Show();
            this.Hide();
        }
    }
}
