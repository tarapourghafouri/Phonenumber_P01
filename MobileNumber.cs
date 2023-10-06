// See https://aka.ms/new-console-template for more information
const  string CountryIranCode= "0098";
const string MobileIranCode = "9";
const string USACode = "001";

Console.WriteLine("please enter your mobilenumber:");
string MobileNumber = Console.ReadLine();
Console.WriteLine(CheckNumber(MobileNumber));



static string CheckNumber(string number)
{
    static bool Isvalidmobilenumber(string number)
    {
        string pattern = @"^09\d{9}$";
        if (Regex.IsMatch(number, pattern))
        {
            return true;
        }
        else { return false; }

    }



    if (number.StartsWith(CountryIranCode + MobileIranCode))
                return number.Replace(CountryIranCode, "0");

            if (number.StartsWith(MobileIranCode))
                return number.Replace(MobileIranCode, "0" + MobileIranCode);

            return ("enter the correct persianphonenumber:");
        

    }


    
 }
    
