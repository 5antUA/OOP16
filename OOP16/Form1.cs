using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP16
{
    public partial class Form1 : Form
    {
        VectorInt Vector;


        public Form1()
        {
            InitializeComponent();
        }

        private void capButton_Click(object sender, EventArgs e)
        {
            try
            {
                int capacity = Convert.ToInt32(capacityBox.Text);
                Vector = new VectorInt(capacity);

                labelInfo1.Text = $"Список елементів {Vector.Length}";
                labelList.Text = string.Empty;
            }
            catch (FormatException) { }
        }

        private void addElemButton_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(valueBox.Text);
                Vector.Add(value);
                labelList.Text = Vector.PrintVector();

                labelInfo1.Text = $"Список елементів {Vector.Length} (add {value})";
            }
            catch (FormatException) { }
            catch (NullReferenceException) { }
            catch (IndexOutOfRangeException) { }
        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            try
            {
                int skalar = Convert.ToInt32(skalarBox.Text);
                VectorInt result = Vector.Multiply(skalar);

                skalarLabel.ForeColor = Color.Black;
                labelResult.Text = result.PrintVector();
            }
            catch (FormatException) { }
            catch (NullReferenceException) { }
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            try
            {
                int skalar = Convert.ToInt32(skalarBox.Text);
                VectorInt result = Vector.Divide(skalar);

                skalarLabel.ForeColor = Color.Black;
                labelResult.Text = result.PrintVector();
            }
            catch (FormatException) { }
            catch (NullReferenceException) { }
            catch (ArgumentException)
            {
                labelResult.Text = string.Empty;
                skalarLabel.ForeColor = Color.Red;
            }
        }
    }
}
