﻿namespace ChapeauUI.MenuUI
{
    partial class MenuManagement
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
            lvMenu = new ListView();
            itemName = new ColumnHeader();
            itemDetailName = new ColumnHeader();
            itemMenu = new ColumnHeader();
            itemType = new ColumnHeader();
            itemPrice = new ColumnHeader();
            itemVATRate = new ColumnHeader();
            btnAddMenuItem = new Button();
            btnChangeMenuItem = new Button();
            SuspendLayout();
            // 
            // lvMenu
            // 
            lvMenu.Columns.AddRange(new ColumnHeader[] { itemName, itemDetailName, itemMenu, itemType, itemPrice, itemVATRate });
            lvMenu.FullRowSelect = true;
            lvMenu.Location = new Point(26, 53);
            lvMenu.MultiSelect = false;
            lvMenu.Name = "lvMenu";
            lvMenu.Size = new Size(586, 371);
            lvMenu.TabIndex = 0;
            lvMenu.UseCompatibleStateImageBehavior = false;
            lvMenu.View = View.Details;
            // 
            // itemName
            // 
            itemName.Text = "Name";
            // 
            // itemDetailName
            // 
            itemDetailName.Text = "Detail Name";
            itemDetailName.Width = 100;
            // 
            // itemMenu
            // 
            itemMenu.Text = "Menu";
            // 
            // itemType
            // 
            itemType.Text = "itemType";
            // 
            // itemPrice
            // 
            itemPrice.Text = "Price";
            // 
            // itemVATRate
            // 
            itemVATRate.Text = "VAT Rate";
            itemVATRate.Width = 80;
            // 
            // btnAddMenuItem
            // 
            btnAddMenuItem.Location = new Point(664, 105);
            btnAddMenuItem.Name = "btnAddMenuItem";
            btnAddMenuItem.Size = new Size(94, 29);
            btnAddMenuItem.TabIndex = 1;
            btnAddMenuItem.Text = "Add";
            btnAddMenuItem.UseVisualStyleBackColor = true;
            btnAddMenuItem.Click += btnAddMenuItem_Click;
            // 
            // btnChangeMenuItem
            // 
            btnChangeMenuItem.Location = new Point(664, 159);
            btnChangeMenuItem.Name = "btnChangeMenuItem";
            btnChangeMenuItem.Size = new Size(94, 29);
            btnChangeMenuItem.TabIndex = 1;
            btnChangeMenuItem.Text = "Change";
            btnChangeMenuItem.UseVisualStyleBackColor = true;
            btnChangeMenuItem.Click += btnChangeMenuItem_Click;
            // 
            // MenuManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChangeMenuItem);
            Controls.Add(btnAddMenuItem);
            Controls.Add(lvMenu);
            Name = "MenuManagement";
            Text = "MenuManagement";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvMenu;
        private ColumnHeader itemName;
        private ColumnHeader itemDetailName;
        private ColumnHeader itemPrice;
        private ColumnHeader itemVATRate;
        private ColumnHeader itemMenu;
        private ColumnHeader itemType;
        private Button btnAddMenuItem;
        private Button btnChangeMenuItem;
    }
}