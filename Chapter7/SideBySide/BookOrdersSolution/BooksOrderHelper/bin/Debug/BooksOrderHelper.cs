using System;


namespace BooksOrderHelper
{
    [Serializable]
    public class BooksOrderHelper
    {
        public static int returnTotalAmmount(int price, int units)
        {
            int iReturn = 0;
            try
            {
                iReturn = price * units;

            }
            catch (Exception)
            {
                
                throw;
            }
            return iReturn;
        }
    }
}
