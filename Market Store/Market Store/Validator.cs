using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Market_Store
{
    public static class Validator
    {
        public static bool Validate(string input)
        {
            var isNumber = input.All<char>(a => char.IsNumber(a));
            return String.IsNullOrEmpty(input) && isNumber;
        }
    }
}
