namespace CookBook.UI
{
    partial class HomeForm
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
            FridgeBtn = new Button();
            RecipesBtn = new Button();
            FoodManagerBtn = new Button();
            NotificationIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)NotificationIcon).BeginInit();
            SuspendLayout();
            // 
            // FridgeBtn
            // 
            FridgeBtn.BackColor = Color.FromArgb(45, 66, 91);
            FridgeBtn.Dock = DockStyle.Top;
            FridgeBtn.FlatAppearance.BorderSize = 0;
            FridgeBtn.FlatStyle = FlatStyle.Flat;
            FridgeBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            FridgeBtn.ForeColor = Color.White;
            FridgeBtn.Image = Properties.Resources.fridge_icon;
            FridgeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            FridgeBtn.Location = new Point(0, 0);
            FridgeBtn.Margin = new Padding(3, 2, 3, 2);
            FridgeBtn.Name = "FridgeBtn";
            FridgeBtn.Size = new Size(373, 70);
            FridgeBtn.TabIndex = 0;
            FridgeBtn.Text = "Fridge";
            FridgeBtn.UseVisualStyleBackColor = false;
            FridgeBtn.Click += FridgeBtn_Click;
            // 
            // RecipesBtn
            // 
            RecipesBtn.BackColor = Color.FromArgb(45, 66, 91);
            RecipesBtn.Dock = DockStyle.Top;
            RecipesBtn.FlatAppearance.BorderSize = 0;
            RecipesBtn.FlatStyle = FlatStyle.Flat;
            RecipesBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            RecipesBtn.ForeColor = Color.White;
            RecipesBtn.Image = Properties.Resources.recipe;
            RecipesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            RecipesBtn.Location = new Point(0, 70);
            RecipesBtn.Margin = new Padding(3, 2, 3, 2);
            RecipesBtn.Name = "RecipesBtn";
            RecipesBtn.Size = new Size(373, 70);
            RecipesBtn.TabIndex = 1;
            RecipesBtn.Text = "Recipes";
            RecipesBtn.UseVisualStyleBackColor = false;
            RecipesBtn.Click += RecipesBtn_Click;
            // 
            // FoodManagerBtn
            // 
            FoodManagerBtn.BackColor = Color.FromArgb(45, 66, 91);
            FoodManagerBtn.Dock = DockStyle.Top;
            FoodManagerBtn.FlatAppearance.BorderSize = 0;
            FoodManagerBtn.FlatStyle = FlatStyle.Flat;
            FoodManagerBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            FoodManagerBtn.ForeColor = Color.White;
            FoodManagerBtn.Image = Properties.Resources.food;
            FoodManagerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            FoodManagerBtn.Location = new Point(0, 140);
            FoodManagerBtn.Margin = new Padding(3, 2, 3, 2);
            FoodManagerBtn.Name = "FoodManagerBtn";
            FoodManagerBtn.Size = new Size(373, 70);
            FoodManagerBtn.TabIndex = 2;
            FoodManagerBtn.Text = "Food manager";
            FoodManagerBtn.UseVisualStyleBackColor = false;
            FoodManagerBtn.Click += FoodManagerBtn_Click;
            // 
            // NotificationIcon
            // 
            NotificationIcon.Image = Properties.Resources.notification;
            NotificationIcon.Location = new Point(149, 241);
            NotificationIcon.Margin = new Padding(3, 2, 3, 2);
            NotificationIcon.Name = "NotificationIcon";
            NotificationIcon.Size = new Size(65, 54);
            NotificationIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            NotificationIcon.TabIndex = 3;
            NotificationIcon.TabStop = false;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(373, 331);
            Controls.Add(NotificationIcon);
            Controls.Add(FoodManagerBtn);
            Controls.Add(RecipesBtn);
            Controls.Add(FridgeBtn);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)NotificationIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button FridgeBtn;
        private Button RecipesBtn;
        private Button FoodManagerBtn;
        private PictureBox NotificationIcon;
    }
}