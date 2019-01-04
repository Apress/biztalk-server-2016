using System;


namespace BooksOrderHelper
{
    [Serializable]
    public class BooksOrderHelper
    {
        public static int returnTotalAmount(int price, int units)
        {
            int _amount = 0;
            int iReturn = 0;
            try
            {
                _amount = price * units;
                iReturn = _amount;
                if (_amount >= 10000)
                
                {
                    throw new ArgumentException(_amount.ToString(), "amount not valid!");
                }

            }
            catch (Exception)
            {
                
                throw;
            }
           
            return iReturn;
        }
    }
}
