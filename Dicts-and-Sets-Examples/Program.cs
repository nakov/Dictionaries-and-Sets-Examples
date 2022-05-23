﻿HashSet<string> set = new HashSet<string>();
set.Add("Peter");
set.Add("Peter"); // Not added again
set.Add("George");
Console.WriteLine(string.Join(", ", set)); // Peter, George
Console.WriteLine(set.Contains("Maria")); // False
Console.WriteLine(set.Contains("Peter")); // True
set.Remove("Peter");
set.Remove("Peter");
set.Remove("Peter");
Console.WriteLine(set.Count); // 1
