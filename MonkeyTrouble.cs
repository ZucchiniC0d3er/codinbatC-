using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(monkeyTrouble(true, true));
	}
	public static bool monkeyTrouble(bool aSmile, bool bSmile) {
		if((aSmile && bSmile) || (!aSmile && !bSmile)){
			return true;
		}
		return false;
	}

}