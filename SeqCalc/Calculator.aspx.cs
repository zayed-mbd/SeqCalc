using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SeqCalc
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            ltrResult.Text = string.Empty;
            bool isValid = validateInput(input.Text);
            if (!isValid)
            {
                ltrResult.Text = "Not a valid input.";
            }
            else
            {
                int num = int.Parse(input.Text);
                string sequence1 = getS311(num);
                string sequence2 = getS312(num);
                string sequence3 = getS313(num);
                string sequence4 = getS314(num);
                string sequence5 = getS315(num);

                ltrResult.Text += sequence1 + "<br />";
                ltrResult.Text += sequence2 + "<br />";
                ltrResult.Text += sequence3 + "<br />";
                ltrResult.Text += sequence4 + "<br />";
                ltrResult.Text += sequence5 + "<br />";
            }
        }
        public bool validateInput(string n)
        {
            int myint;
            bool isValid = false;
            if ((int.TryParse(n, out myint)) && myint >= 0)
            {
                isValid = true;
            }
            return isValid;
        }

        public string getS311(int n)
        {
            string result = string.Empty;
            for (int i = 0; i <= n; i++)
            {
                result += i + ",";
            }
            return result.Remove(result.Length - 1, 1);
        }

        public string getS312(int n)
        {
            string result = string.Empty;
            for (int i = 0; i <= n; i++)
            {
                if ((i % 2) != 0)
                {
                    result += i + ",";
                }
            }
            return result.Remove(result.Length - 1, 1);
        }

        public string getS313(int n)
        {
            string result = string.Empty;
            for (int i = 0; i <= n; i++)
            {
                if ((i % 2) == 0)
                {
                    result += i + ",";
                }
            }
            return result.Remove(result.Length - 1, 1);
        }

        public string getS314(int n)
        {
            string result = string.Empty;
            for (int i = 0; i <= n; i++)
            {
                if (((i % 3) == 0) && ((i % 5) == 0))
                {
                    result += "Z,";
                }
                else if ((i % 3) == 0)
                {
                    result += "C,";
                }
                else if ((i % 5) == 0)
                {
                    result += "E,";
                }
                else
                {
                    result += i + ",";
                }
            }
            return result.Remove(result.Length - 1, 1);
        }

        public string getS315(int n)
        {
            string result = string.Empty;
            int a;
            int b;

            for (int i = 0; i <= n; i++)
            {
                a = 0;
                b = 1;

                for (int j = 0; j < i; j++)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                }

                result += a + ",";
            }
            return result.Remove(result.Length - 1, 1);
        }
    }
}