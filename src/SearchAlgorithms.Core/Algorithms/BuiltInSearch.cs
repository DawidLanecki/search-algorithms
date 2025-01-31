﻿using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SearchAlgorithms.Core.Algorithms
{
    public class BuiltInSearch : ISearchAlgorithm
    {
        public string Name()
        {
            return "C# built-in search";
        }

        public List<int> Search(in string lookingString, in string longString)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < longString.Length; i++)
            {
                if (i + lookingString.Length - 1 < longString.Length && lookingString[0] == longString[i])
                {
                    bool isFound = true;
                    for (int j = 1; j < lookingString.Length; j++)
                    {
                        if (lookingString[j] != longString[i + j])
                        {
                            isFound = false;
                            break;
                        }
                    }
                    if (isFound)
                    {
                        result.Add(i);
                    }
                }
            }
            return result;
        }
    }
}
