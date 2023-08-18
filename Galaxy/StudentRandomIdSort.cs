using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy
{
    internal class StudentRandomIdSort
    {
        Random objRandom = new Random();

        public List<int> GetRandomNumber()
        {
            List<int> result = new List<int>();
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    result.Add(objRandom.Next(10));
                }
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}
