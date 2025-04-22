using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lavina_Lee_FinalProject
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            //TestPanel.Controls.Add(TestLabel1);
            //TestPanel.Controls.Add(TestLabel2);
            List<Label> labels = new List<Label>();

            for (int i = 0; i < 10; i++)
            {
                Label new_label = new Label();
                new_label.Text = "TestLabel" + (i).ToString();
                labels.Add(new_label);
                new_label.Location = new Point(0, i*30);
                Debug.WriteLine("Label no" + i.ToString() + " Added!");
            }

            foreach (Label label in labels)
            {
                TestPanel.Controls.Add(label);
            }
            Debug.WriteLine(labels.Count);
        }
    }
}
