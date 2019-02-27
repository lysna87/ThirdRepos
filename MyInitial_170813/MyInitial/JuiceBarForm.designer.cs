namespace MyNameSpace
{
    partial class JuiceBarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuiceBarForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.twentyOunceRadioButton = new System.Windows.Forms.RadioButton();
            this.sixteenOunceRadioButton = new System.Windows.Forms.RadioButton();
            this.twelveOunceRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ladiesCheckBox = new System.Windows.Forms.CheckBox();
            this.energyBoosterCheckBox = new System.Windows.Forms.CheckBox();
            this.vitaminPackCheckBox = new System.Windows.Forms.CheckBox();
            this.summaryButton = new System.Windows.Forms.Button();
            this.orderCompleteButton = new System.Windows.Forms.Button();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderCompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.titleLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.drinkTypeComboBox = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noSizeRadioButton);
            this.groupBox1.Controls.Add(this.twentyOunceRadioButton);
            this.groupBox1.Controls.Add(this.sixteenOunceRadioButton);
            this.groupBox1.Controls.Add(this.twelveOunceRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(16, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(245, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // noSizeRadioButton
            // 
            this.noSizeRadioButton.AutoSize = true;
            this.noSizeRadioButton.Checked = true;
            this.noSizeRadioButton.Location = new System.Drawing.Point(132, 100);
            this.noSizeRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noSizeRadioButton.Name = "noSizeRadioButton";
            this.noSizeRadioButton.Size = new System.Drawing.Size(79, 21);
            this.noSizeRadioButton.TabIndex = 3;
            this.noSizeRadioButton.TabStop = true;
            this.noSizeRadioButton.Text = "invisible";
            this.noSizeRadioButton.UseVisualStyleBackColor = true;
            this.noSizeRadioButton.Visible = false;
            // 
            // twentyOunceRadioButton
            // Heather change # 1 20oz 4 to 6
            this.twentyOunceRadioButton.AutoSize = true;
            this.twentyOunceRadioButton.Location = new System.Drawing.Point(16, 81);
            this.twentyOunceRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.twentyOunceRadioButton.Name = "twentyOunceRadioButton";
            this.twentyOunceRadioButton.Size = new System.Drawing.Size(123, 21);
            this.twentyOunceRadioButton.TabIndex = 2;
            this.twentyOunceRadioButton.Text = "&20 Ounce 6.00";
            this.twentyOunceRadioButton.UseVisualStyleBackColor = true;
            this.twentyOunceRadioButton.CheckedChanged += new System.EventHandler(this.twelveOunceRadioButton_CheckedChanged);
            // 
            // sixteenOunceRadioButton
            // Heather change #1 16 oz 3.5 to 5.00
            this.sixteenOunceRadioButton.AutoSize = true;
            this.sixteenOunceRadioButton.Location = new System.Drawing.Point(16, 53);
            this.sixteenOunceRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sixteenOunceRadioButton.Name = "sixteenOunceRadioButton";
            this.sixteenOunceRadioButton.Size = new System.Drawing.Size(123, 21);
            this.sixteenOunceRadioButton.TabIndex = 1;
            this.sixteenOunceRadioButton.Text = "&16 Ounce 5.00";
            this.sixteenOunceRadioButton.UseVisualStyleBackColor = true;
            this.sixteenOunceRadioButton.CheckedChanged += new System.EventHandler(this.twelveOunceRadioButton_CheckedChanged);
            // 
            // twelveOunceRadioButton
            // 
            //Heather change #1 12 oz 3 to 4
            this.twelveOunceRadioButton.AutoSize = true;
            this.twelveOunceRadioButton.Location = new System.Drawing.Point(16, 23);
            this.twelveOunceRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.twelveOunceRadioButton.Name = "twelveOunceRadioButton";
            this.twelveOunceRadioButton.Size = new System.Drawing.Size(123, 21);
            this.twelveOunceRadioButton.TabIndex = 0;
            this.twelveOunceRadioButton.Text = "12 &Ounce 4.00";
            this.twelveOunceRadioButton.UseVisualStyleBackColor = true;
            this.twelveOunceRadioButton.CheckedChanged += new System.EventHandler(this.twelveOunceRadioButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ladiesCheckBox);
            this.groupBox3.Controls.Add(this.energyBoosterCheckBox);
            this.groupBox3.Controls.Add(this.vitaminPackCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(16, 217);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(245, 123);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extras - $0.50 each";
            // 
            // ladiesCheckBox
            // 
            this.ladiesCheckBox.AutoSize = true;
            this.ladiesCheckBox.Location = new System.Drawing.Point(16, 84);
            this.ladiesCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ladiesCheckBox.Name = "ladiesCheckBox";
            this.ladiesCheckBox.Size = new System.Drawing.Size(121, 21);
            this.ladiesCheckBox.TabIndex = 2;
            this.ladiesCheckBox.Text = "For the &Ladies";
            this.ladiesCheckBox.UseVisualStyleBackColor = true;
            this.ladiesCheckBox.CheckedChanged += new System.EventHandler(this.vitaminPackCheckBox_CheckedChanged);
            // 
            // energyBoosterCheckBox
            // 
            this.energyBoosterCheckBox.AutoSize = true;
            this.energyBoosterCheckBox.Location = new System.Drawing.Point(16, 55);
            this.energyBoosterCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.energyBoosterCheckBox.Name = "energyBoosterCheckBox";
            this.energyBoosterCheckBox.Size = new System.Drawing.Size(128, 21);
            this.energyBoosterCheckBox.TabIndex = 1;
            this.energyBoosterCheckBox.Text = "Energy &Booster";
            this.energyBoosterCheckBox.UseVisualStyleBackColor = true;
            this.energyBoosterCheckBox.CheckedChanged += new System.EventHandler(this.vitaminPackCheckBox_CheckedChanged);
            // 
            // vitaminPackCheckBox
            // 
            this.vitaminPackCheckBox.AutoSize = true;
            this.vitaminPackCheckBox.Location = new System.Drawing.Point(16, 27);
            this.vitaminPackCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vitaminPackCheckBox.Name = "vitaminPackCheckBox";
            this.vitaminPackCheckBox.Size = new System.Drawing.Size(111, 21);
            this.vitaminPackCheckBox.TabIndex = 0;
            this.vitaminPackCheckBox.Text = "&Vitamin Pack";
            this.vitaminPackCheckBox.UseVisualStyleBackColor = true;
            this.vitaminPackCheckBox.CheckedChanged += new System.EventHandler(this.vitaminPackCheckBox_CheckedChanged);
            // 
            // summaryButton
            // 
            this.summaryButton.Enabled = false;
            this.summaryButton.Location = new System.Drawing.Point(604, 258);
            this.summaryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(144, 34);
            this.summaryButton.TabIndex = 9;
            this.summaryButton.Text = "Summary &Report";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // orderCompleteButton
            // 
            this.orderCompleteButton.Enabled = false;
            this.orderCompleteButton.Location = new System.Drawing.Point(604, 217);
            this.orderCompleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderCompleteButton.Name = "orderCompleteButton";
            this.orderCompleteButton.Size = new System.Drawing.Size(144, 34);
            this.orderCompleteButton.TabIndex = 8;
            this.orderCompleteButton.Text = "Order &Complete";
            this.orderCompleteButton.UseVisualStyleBackColor = true;
            this.orderCompleteButton.Click += new System.EventHandler(this.orderCompleteButton_Click);
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.Location = new System.Drawing.Point(604, 176);
            this.addToOrderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(144, 34);
            this.addToOrderButton.TabIndex = 7;
            this.addToOrderButton.Text = "&Add to Order";
            this.addToOrderButton.UseVisualStyleBackColor = true;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(604, 300);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(144, 34);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item Price";
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Location = new System.Drawing.Point(615, 125);
            this.itemPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.ReadOnly = true;
            this.itemPriceTextBox.Size = new System.Drawing.Size(132, 22);
            this.itemPriceTextBox.TabIndex = 6;
            this.itemPriceTextBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "&Quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(615, 84);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(31, 22);
            this.quantityTextBox.TabIndex = 4;
            this.quantityTextBox.Text = "1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(781, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Enabled = false;
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.summaryToolStripMenuItem.Text = "&Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToOrderToolStripMenuItem,
            this.orderCompleteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // addToOrderToolStripMenuItem
            // 
            this.addToOrderToolStripMenuItem.Name = "addToOrderToolStripMenuItem";
            this.addToOrderToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.addToOrderToolStripMenuItem.Text = "&Add to Order";
            this.addToOrderToolStripMenuItem.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // orderCompleteToolStripMenuItem
            // 
            this.orderCompleteToolStripMenuItem.Enabled = false;
            this.orderCompleteToolStripMenuItem.Name = "orderCompleteToolStripMenuItem";
            this.orderCompleteToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.orderCompleteToolStripMenuItem.Text = "&Order Complete";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(182, 6);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.fontToolStripMenuItem.Text = "&Font...";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.colorToolStripMenuItem.Text = "&Color...";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(249, 46);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(270, 25);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "Look Sharp Fitness Center";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.drinkTypeComboBox);
            this.groupBox2.Location = new System.Drawing.Point(281, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(239, 256);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select the drink type";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // drinkTypeComboBox
            // 
            this.drinkTypeComboBox.FormattingEnabled = true;
            this.drinkTypeComboBox.Items.AddRange(new object[] {
            "Fruit juice",
            "Veggie juice",
            "Pomegranate smoothie",
            "Strawberry banana smoothie",
            "WheatBerry smoothie"});
            this.drinkTypeComboBox.Location = new System.Drawing.Point(9, 38);
            this.drinkTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drinkTypeComboBox.Name = "drinkTypeComboBox";
            this.drinkTypeComboBox.Size = new System.Drawing.Size(220, 24);
            this.drinkTypeComboBox.TabIndex = 0;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // JuiceBarForm
            // 
            this.AcceptButton = this.addToOrderButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(781, 369);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.orderCompleteButton);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "JuiceBarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juice Bar Orders";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton twentyOunceRadioButton;
        private System.Windows.Forms.RadioButton sixteenOunceRadioButton;
        private System.Windows.Forms.RadioButton twelveOunceRadioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ladiesCheckBox;
        private System.Windows.Forms.CheckBox energyBoosterCheckBox;
        private System.Windows.Forms.CheckBox vitaminPackCheckBox;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button orderCompleteButton;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.RadioButton noSizeRadioButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderCompleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox drinkTypeComboBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

