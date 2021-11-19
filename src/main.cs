using yu;
using System;

class program {
    static void Main(string[] args) {
		int[] iarr = new int[]{0, 5, 6, 9, 1, 2, 4, 7, 3, 8};
		foreach(int i in iarr) {
			Console.Write(i);
		}
		Console.WriteLine("");
		yu.BubbleSort.sort(iarr);
		foreach(int i in iarr) {
			Console.Write(i);
		}
		Console.WriteLine("");
        Console.Read();
    }
}
