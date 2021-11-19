using System;
namespace yu{
	class BubbleSort {
		public static int compare(int num1, int num2) {
			return (num1 > num2) ? 1 : ((num1 < num2) ? -1 : 0);
		}
		public static void sort(int[] datas) {
			for(int back = datas.Length - 1; back > 1; back--) {
				for(int i = 0; i < back; i++) {
					if(compare(datas[i], datas[i+1]) > 0) {
						int temp = datas[i];
						datas[i] = datas[i+1];
						datas[i+1] = temp;
					}
				}
			}
		}
	}
}
