using ChapeauModel;
using ChapeauService;

namespace ChapeauUI.IncomeUI
{
    public partial class IncomeUI : Form
    {
        private IncomeService _incomeService;

        public IncomeUI()
        {
            InitializeComponent();
            _incomeService = new IncomeService();
            StartUpSets();
        }

        private void StartUpSets()
        {
            // Sets it to single day
            SetSingleDate();
            cbSingleDay.Checked = true;

            //Gets the totalIncome
            SetAllTimeIncome();
        }

        private void SetSingleDate()
        {
            //Sets startime to Today
            dtpStartDay.Value = DateTime.Today;

            //Hides EndDay
            dtpEndDay.Visible = false;
            lblSelectEndDateText.Visible = false;
            lblSelectDateText.Text = "Select Date:";
        }

        private void SetDoubleDate()
        {
            //Gets today
            DateTime today = DateTime.Today;

            //Sets EndDay to today
            dtpEndDay.Value = today;
            //Sets EndDay to yesterday
            dtpStartDay.Value = today.AddDays(-1);

            //Shows EndDay
            dtpEndDay.Visible = true;
            lblSelectEndDateText.Visible = true;
            lblSelectDateText.Text = "Select Start Date:";
        }

        private void SetAllTimeIncome()
        {
            // Sets AllTimeIncome in the label
            lblAllTimeIncome.Text = _incomeService.GetAllTimeIncome().ToString("€ 0.00");
        }

        private void ClearIncome()
        {
            // Clears income label
            lblIncomeByDate.Text = "€ 0.00";
        }

        private double GetIncome()
        {
            double income = 0;

            try
            {
                if (cbSingleDay.Checked) // Gets the income of SingleDay
                {
                    income = _incomeService.GetIncome(dtpStartDay.Value);
                }
                else if (!cbSingleDay.Checked) // Gets the income of DoubleDay
                {
                    income = _incomeService.GetIncome(dtpStartDay.Value, dtpEndDay.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return income;
        }

        private void SetIncome(double income)
        {
            // Sets income label
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
            //Back to ChapeauPanel
            ChapeauPanel chapeauPanel = new ChapeauPanel();
            chapeauPanel.Show();
            this.Hide();
        }
    }
}
