namespace ChapeauUI.PaymentUI
{
    partial class PaymentPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvAllOrderItems = new ListView();
            name = new ColumnHeader();
            price = new ColumnHeader();
            quantity = new ColumnHeader();
            totalPrice = new ColumnHeader();
            btnPay = new Button();
            lblAmountOfPeople = new Label();
            tbPriceWithTip = new TextBox();
            lblTip = new Label();
            lblPersonOne = new Label();
            tbPersonOnePercentage = new TextBox();
            lblPersonTwo = new Label();
            tbPersonTwoPercentage = new TextBox();
            lblPersonThree = new Label();
            tbPersonThreePercentage = new TextBox();
            lblPersonFour = new Label();
            tbPersonFourPercentage = new TextBox();
            cbPersonOne = new ComboBox();
            lblPercentage1 = new Label();
            cbPersonTwo = new ComboBox();
            cbPersonThree = new ComboBox();
            cbPersonFour = new ComboBox();
            lblPercentage2 = new Label();
            lblPercentage3 = new Label();
            lblPercentage4 = new Label();
            tbPeopleAmount = new TextBox();
            backButton = new Button();
            SuspendLayout();
            // 
            // lvAllOrderItems
            // 
            lvAllOrderItems.Columns.AddRange(new ColumnHeader[] { name, price, quantity, totalPrice });
            lvAllOrderItems.Dock = DockStyle.Fill;
            lvAllOrderItems.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvAllOrderItems.Location = new Point(0, 0);
            lvAllOrderItems.Margin = new Padding(2);
            lvAllOrderItems.MultiSelect = false;
            lvAllOrderItems.Name = "lvAllOrderItems";
            lvAllOrderItems.Size = new Size(957, 453);
            lvAllOrderItems.TabIndex = 0;
            lvAllOrderItems.UseCompatibleStateImageBehavior = false;
            lvAllOrderItems.View = View.Details;
            // 
            // name
            // 
            name.Tag = "name";
            name.Text = "Name";
            name.Width = 220;
            // 
            // price
            // 
            price.Tag = "price";
            price.Text = "Price";
            price.Width = 100;
            // 
            // quantity
            // 
            quantity.Tag = "quantity";
            quantity.Text = "Quantity";
            quantity.Width = 100;
            // 
            // totalPrice
            // 
            totalPrice.Tag = "totalPrice";
            totalPrice.Text = "Total Price";
            totalPrice.Width = 100;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(611, 143);
            btnPay.Margin = new Padding(2);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(323, 23);
            btnPay.TabIndex = 3;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // lblAmountOfPeople
            // 
            lblAmountOfPeople.AutoSize = true;
            lblAmountOfPeople.Location = new Point(500, 7);
            lblAmountOfPeople.Margin = new Padding(2, 0, 2, 0);
            lblAmountOfPeople.Name = "lblAmountOfPeople";
            lblAmountOfPeople.Size = new Size(43, 15);
            lblAmountOfPeople.TabIndex = 4;
            lblAmountOfPeople.Text = "People";
            lblAmountOfPeople.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbPriceWithTip
            // 
            tbPriceWithTip.Location = new Point(500, 143);
            tbPriceWithTip.Margin = new Padding(2);
            tbPriceWithTip.Name = "tbPriceWithTip";
            tbPriceWithTip.Size = new Size(106, 23);
            tbPriceWithTip.TabIndex = 5;
            tbPriceWithTip.TextAlign = HorizontalAlignment.Right;
            tbPriceWithTip.KeyPress += tbPriceWithTip_KeyPress;
            // 
            // lblTip
            // 
            lblTip.AutoSize = true;
            lblTip.Location = new Point(500, 126);
            lblTip.Margin = new Padding(2, 0, 2, 0);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(96, 15);
            lblTip.TabIndex = 6;
            lblTip.Text = "€ Tip (total price)";
            lblTip.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPersonOne
            // 
            lblPersonOne.AutoSize = true;
            lblPersonOne.Location = new Point(500, 57);
            lblPersonOne.Margin = new Padding(2, 0, 2, 0);
            lblPersonOne.Name = "lblPersonOne";
            lblPersonOne.Size = new Size(52, 15);
            lblPersonOne.TabIndex = 8;
            lblPersonOne.Text = "Person 1";
            lblPersonOne.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbPersonOnePercentage
            // 
            tbPersonOnePercentage.Location = new Point(500, 74);
            tbPersonOnePercentage.Margin = new Padding(2);
            tbPersonOnePercentage.Name = "tbPersonOnePercentage";
            tbPersonOnePercentage.Size = new Size(73, 23);
            tbPersonOnePercentage.TabIndex = 7;
            tbPersonOnePercentage.Text = "100";
            tbPersonOnePercentage.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPersonTwo
            // 
            lblPersonTwo.AutoSize = true;
            lblPersonTwo.Location = new Point(610, 57);
            lblPersonTwo.Margin = new Padding(2, 0, 2, 0);
            lblPersonTwo.Name = "lblPersonTwo";
            lblPersonTwo.Size = new Size(52, 15);
            lblPersonTwo.TabIndex = 10;
            lblPersonTwo.Text = "Person 2";
            lblPersonTwo.TextAlign = ContentAlignment.MiddleLeft;
            lblPersonTwo.Visible = false;
            // 
            // tbPersonTwoPercentage
            // 
            tbPersonTwoPercentage.Location = new Point(610, 74);
            tbPersonTwoPercentage.Margin = new Padding(2);
            tbPersonTwoPercentage.Name = "tbPersonTwoPercentage";
            tbPersonTwoPercentage.Size = new Size(73, 23);
            tbPersonTwoPercentage.TabIndex = 9;
            tbPersonTwoPercentage.TextAlign = HorizontalAlignment.Right;
            tbPersonTwoPercentage.Visible = false;
            // 
            // lblPersonThree
            // 
            lblPersonThree.AutoSize = true;
            lblPersonThree.Location = new Point(719, 57);
            lblPersonThree.Margin = new Padding(2, 0, 2, 0);
            lblPersonThree.Name = "lblPersonThree";
            lblPersonThree.Size = new Size(52, 15);
            lblPersonThree.TabIndex = 12;
            lblPersonThree.Text = "Person 3";
            lblPersonThree.TextAlign = ContentAlignment.MiddleLeft;
            lblPersonThree.Visible = false;
            // 
            // tbPersonThreePercentage
            // 
            tbPersonThreePercentage.Location = new Point(719, 74);
            tbPersonThreePercentage.Margin = new Padding(2);
            tbPersonThreePercentage.Name = "tbPersonThreePercentage";
            tbPersonThreePercentage.Size = new Size(73, 23);
            tbPersonThreePercentage.TabIndex = 11;
            tbPersonThreePercentage.TextAlign = HorizontalAlignment.Right;
            tbPersonThreePercentage.Visible = false;
            // 
            // lblPersonFour
            // 
            lblPersonFour.AutoSize = true;
            lblPersonFour.Location = new Point(828, 57);
            lblPersonFour.Margin = new Padding(2, 0, 2, 0);
            lblPersonFour.Name = "lblPersonFour";
            lblPersonFour.Size = new Size(52, 15);
            lblPersonFour.TabIndex = 14;
            lblPersonFour.Text = "Person 4";
            lblPersonFour.TextAlign = ContentAlignment.MiddleLeft;
            lblPersonFour.Visible = false;
            // 
            // tbPersonFourPercentage
            // 
            tbPersonFourPercentage.Location = new Point(828, 74);
            tbPersonFourPercentage.Margin = new Padding(2);
            tbPersonFourPercentage.Name = "tbPersonFourPercentage";
            tbPersonFourPercentage.Size = new Size(73, 23);
            tbPersonFourPercentage.TabIndex = 13;
            tbPersonFourPercentage.TextAlign = HorizontalAlignment.Right;
            tbPersonFourPercentage.Visible = false;
            // 
            // cbPersonOne
            // 
            cbPersonOne.FormattingEnabled = true;
            cbPersonOne.Location = new Point(500, 96);
            cbPersonOne.Margin = new Padding(2);
            cbPersonOne.Name = "cbPersonOne";
            cbPersonOne.Size = new Size(106, 23);
            cbPersonOne.TabIndex = 15;
            // 
            // lblPercentage1
            // 
            lblPercentage1.AutoSize = true;
            lblPercentage1.Location = new Point(577, 76);
            lblPercentage1.Margin = new Padding(2, 0, 2, 0);
            lblPercentage1.Name = "lblPercentage1";
            lblPercentage1.Size = new Size(17, 15);
            lblPercentage1.TabIndex = 16;
            lblPercentage1.Text = "%";
            lblPercentage1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbPersonTwo
            // 
            cbPersonTwo.FormattingEnabled = true;
            cbPersonTwo.Location = new Point(610, 96);
            cbPersonTwo.Margin = new Padding(2);
            cbPersonTwo.Name = "cbPersonTwo";
            cbPersonTwo.Size = new Size(106, 23);
            cbPersonTwo.TabIndex = 17;
            // 
            // cbPersonThree
            // 
            cbPersonThree.FormattingEnabled = true;
            cbPersonThree.Location = new Point(719, 96);
            cbPersonThree.Margin = new Padding(2);
            cbPersonThree.Name = "cbPersonThree";
            cbPersonThree.Size = new Size(106, 23);
            cbPersonThree.TabIndex = 18;
            // 
            // cbPersonFour
            // 
            cbPersonFour.FormattingEnabled = true;
            cbPersonFour.Location = new Point(828, 96);
            cbPersonFour.Margin = new Padding(2);
            cbPersonFour.Name = "cbPersonFour";
            cbPersonFour.Size = new Size(106, 23);
            cbPersonFour.TabIndex = 19;
            // 
            // lblPercentage2
            // 
            lblPercentage2.AutoSize = true;
            lblPercentage2.Location = new Point(686, 76);
            lblPercentage2.Margin = new Padding(2, 0, 2, 0);
            lblPercentage2.Name = "lblPercentage2";
            lblPercentage2.Size = new Size(17, 15);
            lblPercentage2.TabIndex = 20;
            lblPercentage2.Text = "%";
            lblPercentage2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPercentage3
            // 
            lblPercentage3.AutoSize = true;
            lblPercentage3.Location = new Point(795, 76);
            lblPercentage3.Margin = new Padding(2, 0, 2, 0);
            lblPercentage3.Name = "lblPercentage3";
            lblPercentage3.Size = new Size(17, 15);
            lblPercentage3.TabIndex = 21;
            lblPercentage3.Text = "%";
            lblPercentage3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPercentage4
            // 
            lblPercentage4.AutoSize = true;
            lblPercentage4.Location = new Point(904, 76);
            lblPercentage4.Margin = new Padding(2, 0, 2, 0);
            lblPercentage4.Name = "lblPercentage4";
            lblPercentage4.Size = new Size(17, 15);
            lblPercentage4.TabIndex = 22;
            lblPercentage4.Text = "%";
            lblPercentage4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbPeopleAmount
            // 
            tbPeopleAmount.Location = new Point(500, 24);
            tbPeopleAmount.Margin = new Padding(2);
            tbPeopleAmount.MaxLength = 1;
            tbPeopleAmount.Name = "tbPeopleAmount";
            tbPeopleAmount.Size = new Size(73, 23);
            tbPeopleAmount.TabIndex = 24;
            tbPeopleAmount.Text = "1";
            tbPeopleAmount.TextAlign = HorizontalAlignment.Right;
            tbPeopleAmount.TextChanged += tbPeopleAmount_TextChanged;
            // 
            // backButton
            // 
            backButton.Location = new Point(750, 24);
            backButton.Name = "backButton";
            backButton.Size = new Size(112, 34);
            backButton.TabIndex = 25;
            backButton.Text = "< Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // PaymentPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 453);
            Controls.Add(backButton);
            Controls.Add(tbPeopleAmount);
            Controls.Add(lblPercentage4);
            Controls.Add(lblPercentage3);
            Controls.Add(lblPercentage2);
            Controls.Add(cbPersonFour);
            Controls.Add(cbPersonThree);
            Controls.Add(cbPersonTwo);
            Controls.Add(lblPercentage1);
            Controls.Add(cbPersonOne);
            Controls.Add(lblPersonFour);
            Controls.Add(tbPersonFourPercentage);
            Controls.Add(lblPersonThree);
            Controls.Add(tbPersonThreePercentage);
            Controls.Add(lblPersonTwo);
            Controls.Add(tbPersonTwoPercentage);
            Controls.Add(lblPersonOne);
            Controls.Add(tbPersonOnePercentage);
            Controls.Add(lblTip);
            Controls.Add(tbPriceWithTip);
            Controls.Add(lblAmountOfPeople);
            Controls.Add(btnPay);
            Controls.Add(lvAllOrderItems);
            Margin = new Padding(2);
            Name = "PaymentPanel";
            Text = "PaymentPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvAllOrderItems;
        private ColumnHeader name;
        private ColumnHeader price;
        private ColumnHeader quantity;
        private ColumnHeader totalPrice;
        private Button btnPay;
        private Label lblAmountOfPeople;
        private TextBox tbPriceWithTip;
        private Label lblTip;
        private Label lblPersonOne;
        private TextBox tbPersonOnePercentage;
        private Label lblPersonTwo;
        private TextBox tbPersonTwoPercentage;
        private Label lblPersonThree;
        private TextBox tbPersonThreePercentage;
        private Label lblPersonFour;
        private TextBox tbPersonFourPercentage;
        private ComboBox cbPersonOne;
        private Label lblPercentage1;
        private ComboBox cbPersonTwo;
        private ComboBox cbPersonThree;
        private ComboBox cbPersonFour;
        private Label lblPercentage2;
        private Label lblPercentage3;
        private Label lblPercentage4;
        private TextBox tbPeopleAmount;
        private Button backButton;
    }
}