namespace Lucky_ticket
{
    class Process
    {
        public static bool GetLucky(string inputString)
        {
            var left = 0;
            var right = 0;
            for (var i = 0; i < inputString.Length / 2; i++)
            {
                left += int.Parse(inputString[i].ToString());
                right += int.Parse(inputString[inputString.Length - 1 - i].ToString()); 
            }
            return (left == right);
        }
    }
}