using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HVP
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();

            StepViewPictureEdit.Image = Details.stepimage;
            this.Text = Details.imagelabel;
        }
    }
}
