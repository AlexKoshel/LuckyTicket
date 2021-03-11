namespace Lucky_ticket
{
    public static class Validation
    {
        private static bool CharCheck(string inputString)
        {
            for (var i = 0; i <= inputString.Length - 1; i++)
            {
                if (!char.IsDigit(inputString[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool LengthCheck(string inputString)
        {
            return ((inputString.Length >= 4) && (inputString.Length <= 8));            
        }        

        private static string OddNumber(string inputString)
        {
            if (inputString.Length % 2 == 0)
            {
                return inputString;
            }
            else
            {
                return inputString = '0' + inputString;
            }
        }

        public static string TicketValidation(string inputString)
        {
            if (!LengthCheck(inputString))
                return null;

            if (!CharCheck(inputString))
                return null;

            return OddNumber(inputString);            
        }
    }
}