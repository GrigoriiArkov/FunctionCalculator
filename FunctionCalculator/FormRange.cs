using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionCalculator
{
    public partial class FormRange : Form
    {
        public FormRange()
        {
            InitializeComponent();
        }

        private void FormRange_Load(object sender, EventArgs e)
        {

        }
        public double IntervalStart
        {
            get { return Convert.ToDouble(textBox1.Text); }
            set { textBox1.Text = value.ToString(); }
        }
        public double IntervalEnd
        {
            get { return Convert.ToDouble(textBox2.Text); }
            set { textBox2.Text = value.ToString(); }
        }
    }
}
