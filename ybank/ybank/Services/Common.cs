using System.Globalization;

namespace ybank.Services
{
    public class Common
    {
        //Checking request number Vaid or Not Method
        public bool isNumber(string number)
        {
            try
            {
                Boolean isNumber = false;
                Double n = 0;

                if (number != null)
                {
                    number = number.Replace(" ", ""); // replaces spaces in between numbers if any
                    isNumber = Double.TryParse(number,out n);
                    return isNumber; // return all string value is number or not
                }
            }
            catch (Exception ex) {

                Console.WriteLine("Exception Occured" + ex.Message);
                return false;
            }
            return false;
        }
        //Checking Credit Card Vaid or Not Method
        public bool IsCreditCardValid(int[] digits)
        {
            try
            {
                //Initialize Sum
                int sum = 0;
                // Checking Luhn Algorithm
                for (int i = (digits.Length - 1); i >= 0; i--)
                {
                    int digit = digits[i];
                    if (i % 2 == 0)
                        digit = digit * 2;
                    if (digit > 9)
                        digit -= 9;
                    sum += digit;

                }
                // Checking Credit Card Valid Or Not
                if ((sum % 10) == 0)
                {
                    Console.WriteLine("Credit Card Digits are Valid ");
                    return true;
                }
                else
                {
                    Console.WriteLine("Credit Card Digits are Not Valid ");
                    return false;
                }
            }
            catch (Exception ex) {

                Console.WriteLine("Exception Occured" + ex.Message);
            
            }
            return false;
        }
    }
}
