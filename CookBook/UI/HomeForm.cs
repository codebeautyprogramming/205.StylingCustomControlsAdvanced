using CookBook.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.UI
{
    public partial class HomeForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        DesktopFileWatcher _desktopFileWatcher;
        public HomeForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _desktopFileWatcher= _serviceProvider.GetRequiredService<DesktopFileWatcher>();
            _desktopFileWatcher.OnFileStatusChanged += OnFileStatusChanged;

            NotificationIcon.Visible = DesktopFileWatcher.CurrentFileStatus;
            ApplyStyles();
        }

        private void OnFileStatusChanged(bool fileExists)
        {
            Invoke(new Action(() =>
            {
                NotificationIcon.Visible = fileExists;
            }));
        }

        private void RecipesBtn_Click(object sender, EventArgs e)
        {
            RecipesForm form = _serviceProvider.GetRequiredService<RecipesForm>();
            ShowForm(form);
        }

        private void FridgeBtn_Click(object sender, EventArgs e)
        {
            IngredientsForm form = _serviceProvider.GetRequiredService<IngredientsForm>();
            ShowForm(form);
        }

        private void FoodManagerBtn_Click(object sender, EventArgs e)
        {
            //FoodManagerForm form = _serviceProvider.GetRequiredService<FoodManagerForm>();
            //ShowForm(form);

            ShowForm(_serviceProvider.GetRequiredService<FoodManagerForm>());
        }

        private void ShowForm(Form form)
        {
            //form.StartPosition = FormStartPosition.CenterScreen;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.ShowDialog();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.S)
            {
                SecretForm form = _serviceProvider.GetRequiredService<SecretForm>();
                ShowForm(form);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ApplyStyles()
        {
            this.MinimizeBox=false;
            this.MaximizeBox=false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Size = new System.Drawing.Size(360, 370);
            this.Text = "Home";
            this.BackColor = Color.FromArgb(45, 66, 91);
        }
    }
}
