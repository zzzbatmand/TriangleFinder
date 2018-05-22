using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleFinder
{
    public partial class TriangleFinder : Form
    {
        //Test text
        private string lastChanged = "";
        List<TextBox> textList = new List<TextBox>();
        bool running = false;

        #region Main_functions
        public TriangleFinder()
        {
            InitializeComponent();
            //Create list of textboxes
            textList.Add(a1);
            textList.Add(b1);
            textList.Add(c1);
            textList.Add(a2);
            textList.Add(b2);
        }

        private void global_TextChanged(object sender, EventArgs e)
        {
            if (!running)
            {
                TextBox triggerBox = (sender as TextBox); //Get the triggered textbox.
                Console.WriteLine(triggerBox.Name); //Print name of the triggered textbox.
                lastChanged = lastChanged.Replace(triggerBox.Name, ""); //Remove old item, if triggered before.
                if (triggerBox.Text != "0" && triggerBox.Text != "") //If the triggered box isn't 0 or empty.
                {
                    lastChanged += triggerBox.Name; //Add triggered box to list.
                }
                Console.WriteLine(lastChanged); //Print changed order.
            }
        }

        private bool checkError()
        {
            if (lastChanged.Length < 4) //If there isn't 2 edited items.
                return true;
            /*if (a1.Text.Length == 0) { a1.Text = "0"; }
            if (b1.Text.Length == 0) { b1.Text = "0"; }
            if (c1.Text.Length == 0) { c1.Text = "0"; }
            if (a2.Text.Length == 0) { a2.Text = "0"; }
            if (b2.Text.Length == 0) { b2.Text = "0"; }*/
            foreach (TextBox tb in textList)
            {
                try
                {
                    Convert.ToDouble(tb.Text);  //Check for conversion falure, used to see if input contaisn a character wich isn't a number.
                }
                catch (Exception)
                {
                    return true;
                }

                if (double.IsNaN(Convert.ToDouble(tb.Text))) //If any of the inputs is Nor a Number.
                    return true;
            }

            return false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = "Find triangle info";
            methodBox.Text = "";
            foreach (TextBox tb in textList)
            {
                tb.Text = "0";
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            runCalculation();
        }
        #endregion

        #region calculate_functions
        private void prepareInputs()
        {
            foreach (TextBox tb in textList)
            {
                if (tb.Text.Contains("."))  //Check if used a dot instead of necessary comma.
                    tb.Text = tb.Text.Replace(".", ",");
                if (tb.Text.Contains(" "))  //Check and remove spaces.
                    tb.Text = tb.Text.Replace(" ", String.Empty);
                if (tb.Text.Length == 0)    //Make sure a textbox isn't empty. (Pure cosmetic)
                    tb.Text = "0";
            }
        }

        private string createOrder()
        {
            //Create order as int in what to calculate in.
            //There are 5 inp. 2 is always used = 3.

            string resultOrder = "";

            switch (lastChanged.Substring(lastChanged.Length - 4)) //Take the last 4 characters.
            {
                case "a1c1": //a&c
                case "c1a1":
                    resultOrder = "ac";
                    break;
                case "b1c1": //b&c
                case "c1b1":
                    resultOrder = "bc";
                    break;
                case "a1b1": //a&b
                case "b1a1":
                    resultOrder = "ab";
                    break;
                case "c1a2": //c&A
                case "a2c1":
                    resultOrder = "cA";
                    break;
                case "c1b2": //c&B
                case "b2c1":
                    resultOrder = "cB"; //Use same order as above for 1&2
                    break;
                case "a1b2": //a&B
                case "b2a1":
                    resultOrder = "aB";
                    break;
                case "b1a2": //b&A
                case "a2b1":
                    resultOrder = "bA";
                    break;
                case "a1a2": //a&A
                case "a2a1":
                    resultOrder = "aA";
                    break;
                case "b1b2": //b&B
                case "b2b1":
                    resultOrder = "bB";
                    break;

                default:
                    break;
            }

            return resultOrder;
        }

        private double[] calculate()
        {
            bool failed = false;
            string order = createOrder();
            string outputOrder = "1"; //Necessary since converting to double and forst int if 0 will be removed.
            double a, b, c, A, B; // Declare variables
            a = b = c = A = B = 0; // Set variables to 0;

            //for (int i = 0; i < order.ToString().Length; i++)
            foreach (char value in order) //Should set the neccesarry variables.
            {
                switch (value)
                {
                    case 'a':
                        a = Convert.ToDouble(a1.Text);
                        break;
                    case 'b':
                        b = Convert.ToDouble(b1.Text);
                        break;
                    case 'c':
                        c = Convert.ToDouble(c1.Text);
                        break;
                    case 'd':
                        A = Convert.ToDouble(a2.Text);
                        break;
                    case 'e':
                        B = Convert.ToDouble(b2.Text);
                        break;
                    default:
                        //Error
                        failed = true;
                        break;
                }
            }

            // Calculations start here, if there happen to be no errors.
            if (!failed)
            {
                // I take A and B first, to reduce possible calculation methods.
                if (!order.Contains('A')) //If a isn't in the order, get that first.
                {
                    if (!order.Contains('B'))
                    {
                        if (!order.Contains('a'))// Sets A, remember * (180 / pi) to convert to degree.
                        { A = Math.Acos(b / c) * (180 / Math.PI); outputOrder += "0"; }
                        else if (!order.Contains('b'))
                        { A = Math.Asin(a / c) * (180 / Math.PI); outputOrder += "1"; }
                        else if (!order.Contains('c'))
                        { A = Math.Atan(a / b) * (180 / Math.PI); outputOrder += "2"; }
                    }
                    else
                    {
                        A = 90 - B; // If B exists, then just use that.
                        outputOrder += "3";
                    }
                }
                if (!order.Contains('B')) // Just to make sure B is set, if A already exists.
                {
                    B = 90 - A;
                    outputOrder += "4";
                }
                // Next i take the smaller ones here. (a-c)
                if (!order.Contains('a')) // Take 'a' first and work from there.
                {
                    if (order.Contains('c'))
                    { a = c * Math.Sin(A * Math.PI / 180); Console.WriteLine(a); outputOrder += "5"; }
                    else // This means (b)
                    { a = b * Math.Tan(A * Math.PI / 180); outputOrder += "6"; }
                }
                if (!order.Contains('b')) // If it doesn't have 'b', yada yada...
                {
                    if (order.Contains('c'))
                    { b = c * Math.Cos(A * Math.PI / 180); outputOrder += "7"; }
                    else // This means (a)
                    { b = a * Math.Tan(B * Math.PI / 180); outputOrder += "8"; }
                }
                if (!order.Contains('c')) // Lastly we find 'c'
                {
                    c = Math.Sqrt((a * a) + (b * b)); // This is the only neccesarry way.
                    outputOrder += "9";
                }


                // Reduce decimal digits to 3, but it only works with decimal and not doubles, so convert a bit.
                a = Convert.ToDouble(Math.Truncate(Convert.ToDecimal(a) * 1000m) / 1000m);
                b = Convert.ToDouble(Math.Truncate(Convert.ToDecimal(b) * 1000m) / 1000m);
                c = Convert.ToDouble(Math.Truncate(Convert.ToDecimal(c) * 1000m) / 1000m);
                A = Convert.ToDouble(Math.Truncate(Convert.ToDecimal(A) * 1000m) / 1000m);
                B = Convert.ToDouble(Math.Truncate(Convert.ToDecimal(B) * 1000m) / 1000m);
            }
            else
            {
                MessageBox.Show("Opps. Something went wrong (calculate function)"); // Temp error message
            }

            // I'm just keeping the result as a variable, so it's not fixed.
            double[] result = { a, b, c, A, B, Convert.ToDouble(outputOrder) };
            return result; //First 2 outputs, then 3 unused inputs, for results.
        }

        private void printOutput(double[] results)
        {
            string output1 = ""; // Calc method using given values.
            string output2 = ""; // Calc methid using default letters.
            string inputs = results[5].ToString().Substring(1); //Removes the base int used for keeping first 0.
            Console.WriteLine("Inputs is : " + inputs);
            // Get inputs and use ifstatements to print order
            // If not contain then show how to calc.
            foreach (char value in inputs)
            {
                switch (value)
                {
                    case ('0'):
                        output1 += String.Format("A = cos^-1({0}/{1})\r\n", results[1], results[2]); // 1 = b & 2 = c
                        output2 += String.Format("A = cos^-1(b/c)\r\n");
                        break;
                    case ('1'):
                        output1 += String.Format("A = sin^-1({0}/{1})\r\n", results[0], results[2]); // 0 = a & 2 = c
                        output2 += String.Format("A = sin^-1(a/c)\r\n");
                        break;
                    case ('2'):
                        output1 += String.Format("A = tan^-1({0}/{1})\r\n", results[0], results[1]); // 0 = a & 1 = b
                        output2 += String.Format("A = tan^-1(a/b)\r\n");
                        break;
                    case ('3'):
                        output1 += String.Format("A = 90 - {0}\r\n", results[4]); // 4 = B
                        output2 += String.Format("A = 90(C) - B\r\n");
                        break;
                    case ('4'):
                        output1 += String.Format("B = 90 - {0}\r\n", results[3]); // 3 = A
                        output2 += String.Format("B = 90(C) - A\r\n");
                        break;
                    case ('5'):
                        output1 += String.Format("a = {0} * sin({1})\r\n", results[2], results[3]); // 2 = c & 3 = A
                        output2 += String.Format("a = c * sin(A)\r\n");
                        break;
                    case ('6'):
                        output1 += String.Format("a = {0} * tan({1})\r\n", results[1], results[3]); // 1 = b & 3 = A
                        output2 += String.Format("a = b * tan(A)\r\n");
                        break;
                    case ('7'):
                        output1 += String.Format("b = {0} * cos({1})\r\n", results[2], results[3]); // 2 = c & 3 = A
                        output2 += String.Format("b = c * cos(A)\r\n");
                        break;
                    case ('8'):
                        output1 += String.Format("b = {0} * tan({1})\r\n", results[0], results[4]); // 0 = a & 4 = B
                        output2 += String.Format("b = a * tan(B)\r\n");
                        break;
                    case ('9'):
                        output1 += String.Format("c = sqrt({0}^2 + {1}^2)\r\n", results[0], results[1]); // 0 = a & 1 = b
                        output2 += String.Format("c = sqrt(a^2 + b^2)\r\n");
                        break;
                }
            }

            resultBox.Text = output1;
            methodBox.Text = output2;
            foreach (TextBox tb in textList)
            {
                tb.Text = results[textList.IndexOf(tb)].ToString();
            }
        }

        private void runCalculation()
        {
            running = true;
            prepareInputs();
            if (checkError())
            {
                MessageBox.Show("There eather isn't enough inputs, or an input doesn't contain a number.", "An error occured");
                running = false;
            }
            else
            {
                double[] results = calculate();
                printOutput(results);
            }
            running = false;
        }
        #endregion
    }
}
