using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class TwoZeroFourEightScoreView : Form, View
    {
        public void Notify(Model m)
        {
            label1.Text = ((TwoZeroFourEightModel)m).Score.ToString();
        } 

        public TwoZeroFourEightScoreView()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
