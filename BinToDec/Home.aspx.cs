using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BinToDec
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button_Convert_Click(object sender, EventArgs e)
        {
            int dec;
            int.TryParse(TextBox_Decimal.Text, out dec);
            Label_Binary.Text = DecToBin(dec);
        }

        protected void Button_BinToDec_Click(object sender, EventArgs e)
        {
            if(BinToDec(TextBox_Binary.Text) == -1)
                Label_Decimal.Text = "You must write only \"1\" or \"0\"";
            else
                Label_Decimal.Text = BinToDec(TextBox_Binary.Text).ToString();
        }



        public static int BinToDec (string bin)
        {
            int j = bin.Length - 1;
            System.Diagnostics.Debug.WriteLine("binary length: " + bin.Length);
            int dec = 0;

            for(int i = 0; i < bin.Length; i++)
            {
                System.Diagnostics.Debug.WriteLine("[" + i + "]: " + bin.ElementAt(i));
                if (bin.ElementAt(i).Equals('1'))
                {
                    dec += (int)Math.Pow(2, j);
                    System.Diagnostics.Debug.WriteLine("2^" + j);
                }else if (!bin.ElementAt(i).Equals('0'))
                {
                    return -1;
                }
                j--;
            }
            return dec;
        }

        public static string DecToBin (int dec)
        {
            string bin = "";
            int aux;

            while (dec != 0)
            {
                aux = dec % 2;
                bin = aux.ToString() + bin;
                dec /= 2;
            }

            return bin;
        }


    }
}