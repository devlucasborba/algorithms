using System;
using System.Linq;

string p = Console.ReadLine().ToLower();
bool isPalindrome = true;

for (int i = 0; i < p.Length / 2; i++) 
{
	if (p[i] != p[p.Length - i -1]) 
	{
		isPalindrome = false;
		break;
	}
}

Console.WriteLine(isPalindrome);
