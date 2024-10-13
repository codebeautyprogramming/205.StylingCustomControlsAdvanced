using CookBook.Services;
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
    public partial class SecretForm : Form
    {
        public SecretForm()
        {
            InitializeComponent();
            PreparedRecipesLbl.Text = "Prepared recipes counter: " + DesktopFileWatcher.Instance.PreparedRecipesCounter.ToString();
        }
    }
}
