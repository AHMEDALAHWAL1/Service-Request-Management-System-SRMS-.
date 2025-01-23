using System.Windows.Forms;

internal static class Request_formHelpers
{


    static double Calc_price(string type, double price, int qty)
    {
        if (type == "A4bnw")
        {
            price = 0.8 * qty;
            if (qty > 100)
            {
                discount(price);

                return price;

            }
            else
            {
                return price;
            }
        }
        else if (type == "A4co")
        {
            price = 2.50 * qty;
            if (qty > 100)
            {
                discount(price);
                return price;
            }
            else
            {
                return price;
            }
        }
        else if (type == "A0po")
        {
            price = 6 * qty;
            if (qty > 100)
            {
                discount(price);
                return price;
            }
            else
            {
                return price;
            }
        }
        else if (type == "A2po")
        {
            price = 3 * qty;
            if (qty > 100)
            {
                discount(price);
                return price;
            }
            else
            {
                return price;
            }
        }
        else if (type == "HCbi")
        {
            price = 9.30 * qty;
            return price;
        }
        else if (type == "CObi")
        {
            price = 5.50 * qty;
            return price;
        }
        else
        {
            MessageBox.Show("ERRO PARSING VALUES THROUGH THE CALC PRICE METHOD");
            return 0;
        }



    }


    static double discount(double price)
    {
        price = price - ((price * 0.10));
        return price;
    }
}