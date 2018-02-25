using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double width;

        static double height;

        public void btncompare_Click(object sender, EventArgs e)
        {
            double currentms = Convert.ToDouble(currentmonitorsize.SelectedItem);
            double comparems = Convert.ToDouble(comparemonitorsize.SelectedItem);

            double currentd = Convert.ToDouble(currentmonitorsize.SelectedItem);
            double compared = Convert.ToDouble(comparemonitorsize.SelectedItem);

            double cssdcw;
            double cssdch;

            double cossdcw;
            double cossdch;

            screensizedata(currentd);
            cssdcw = width;
            cssdch = height;

            screensizedata(compared);
            cossdcw = width;
            cossdch = height;

            if (currentms > comparems)
            {
                double differential;
                differential = getdifferential(comparems, currentms);

                result.Text =
                    $"Current Monitor's Dimensions : " + "\n\n" +
                    $"W: {Convert.ToString((cssdcw))}" + " H: " + $"{ Convert.ToString((cssdch))} "
                    + "\n\n" + $"Compare Monitor's Dimensions :" + "\n\n" +
                    $"W: {Convert.ToString(cossdcw)}" + " H: " + $"{ Convert.ToString(cossdch)}"
                    + "\n\n" + $"Difference :" + "\n\n" +
                    $"W: {Convert.ToString((cssdcw - cossdcw))}" + $" H: {Convert.ToString((cssdch - cossdch))}"
                    + $" D: {Convert.ToString(differential)}";
            }
            else
            {
                double differential;
                differential = getdifferential(currentms, comparems);

                result.Text =
                    $"Current Monitor's Dimensions : " + "\n\n" +
                    $"W: {Convert.ToString((cssdcw))}" + " H: " + $"{ Convert.ToString((cssdch))} "
                    + "\n\n" + $"Compare Monitor's Dimensions :" + "\n\n" +
                    $"W: {Convert.ToString(cossdcw)}" + " H: " + $"{ Convert.ToString(cossdch)}"
                    + "\n\n" + $"Difference :" + "\n\n" +
                    $"W: {Convert.ToString((cossdcw - cssdcw))}" + $" H: {Convert.ToString((cossdch - cssdch))}" + $" D: {Convert.ToString(differential)}";
            }


        }

        public double getdifferential(double currentms, double comparems)
        {
            double s1ans;
            s1ans = comparems / currentms;
            currentms = s1ans;
            return currentms;
        }


        public static Tuple<double?, double?, double?> screensizedata(double data)
        {
            switch (data)
            {
                case 20:
                    width = 44.28;
                    height = 24.91;
                    break;

                case 21:
                    width = 47.60;
                    height = 26.77;
                    break;

                case 22:
                    width = 48.70;
                    height = 27.40;
                    break;

                case 23:
                    width = 50.92;
                    height = 28.64;
                    break;

                case 24:
                    width = 53.13;
                    height = 29.89;
                    break;

                case 27:
                    width = 59.77;
                    height = 33.62;
                    break;

            }

            return new Tuple<double?, double?, double?>(width, height, data);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentmonitorsize.SelectedIndex = 0;
            comparemonitorsize.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = @"Example:" + "\n" + @"27 / 20 = 1.35 (Your Differential)" + "\n" +
             "\n" + "1.35 * Your current screen's height/width to find your new" + "\n"
            + "screen's height/width.";
        }
    }
}
