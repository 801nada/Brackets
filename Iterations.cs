using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brackets
{
    public static class Iterations
    {
        public static bool HasMatchingBrace(string value)
        {
            var openCount = 0;
            for (int i = 0; i < value.Length; i++)
            {
                var current = value[i];
                if (current == '{')
                    openCount ++;
                else if (current == '}')
                { 
                    if (openCount <= 0)
                        return false;
                    openCount --;
                }  
            }
            return openCount == 0;
        }

        public static bool HasMatchingBrace2(string value)
        {
            var openCount = 0;
            
            foreach (char current in value)
            {
                var isOpen = openCount > 0;
                openCount += (current, isOpen) switch
                { 
                    ('{', _) => 1,
                    ('}', true) => -1,
                    ('}', false) => -int.MaxValue,
                    _ => 0
                };
            }
            return openCount == 0;
        }

        public static bool HasMatchingBrace3(string value)
        {
            var openCount = 0;
            try
            { 
                value.ToList().ForEach(c => {
                    openCount += c switch
                    {
                        '{' => 1,
                        '}' => -1,
                        _ => 0
                    };
                    if (openCount < 0)
                        throw new Exception("No open braket");
                });
            }
            catch (Exception)
            { 
                return false;
            }
            return openCount == 0;
        }
    }
}
