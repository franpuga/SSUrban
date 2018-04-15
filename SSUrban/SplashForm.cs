using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSUrban
{
    public partial class SplashForm : Form
    {
        public string LabelInfo
        {
            get
            {
                return this.lblLoadInfo.Text;
            }
            set
            {
                this.lblLoadInfo.Text = value;
            }

        }
        public SplashForm()
        {
            InitializeComponent();
        }
    }
}
