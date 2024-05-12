using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigimonDeckManager.UseCases
{
    public class IntOrNull
    {
        public static int? ConvertToNullableInt(string input)
        {
            if (int.TryParse(input, out int result))
                return result;
            else
                return null;
        }
    }
}
