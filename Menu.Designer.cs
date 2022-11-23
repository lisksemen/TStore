namespace TStore
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.replenishButton = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.historyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter amount to replenish the balance";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(725, 33);
            this.amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(114, 27);
            this.amount.TabIndex = 1;
            // 
            // replenishButton
            // 
            this.replenishButton.Location = new System.Drawing.Point(740, 68);
            this.replenishButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.replenishButton.Name = "replenishButton";
            this.replenishButton.Size = new System.Drawing.Size(86, 31);
            this.replenishButton.TabIndex = 2;
            this.replenishButton.Text = "Replenish";
            this.replenishButton.UseVisualStyleBackColor = true;
            this.replenishButton.Click += new System.EventHandler(this.replenishButton_Click);
            // 
            // productsButton
            // 
            this.productsButton.Location = new System.Drawing.Point(384, 345);
            this.productsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(142, 31);
            this.productsButton.TabIndex = 3;
            this.productsButton.Text = "Open Products List";
            this.productsButton.UseVisualStyleBackColor = true;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(12, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(75, 20);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(12, 29);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(61, 20);
            this.balanceLabel.TabIndex = 5;
            this.balanceLabel.Text = "Balance";
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(7, 52);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(119, 29);
            this.historyButton.TabIndex = 6;
            this.historyButton.Text = "OpenHistory";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.productsButton);
            this.Controls.Add(this.replenishButton);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox amount;
        private Button replenishButton;
        private Button productsButton;
        private Label usernameLabel;
        private Label balanceLabel;
        private Button historyButton;
    }
}