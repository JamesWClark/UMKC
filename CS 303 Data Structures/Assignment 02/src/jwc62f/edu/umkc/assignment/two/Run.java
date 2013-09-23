package jwc62f.edu.umkc.assignment.two;

import java.io.*;
import java.util.Arrays;
import java.util.Vector;

public class Run {
	
	private static Vector<Integer> vector = new Vector<Integer>();
	
	
	int[] sample = { 44, 75, 23, 43, 55, 12, 64, 77, 33 };

	private static int[] numbers_nearlysorted = null;
	private static int[] numbers_reverse = null;
	private static int[] numbers_random = null;

	public static void main(String[] args) {
		
		
		try {
			numbers_nearlysorted = Generator.GetNearlySortedArray(1000);
			numbers_reverse = Generator.GetReverseArray(1000);
			numbers_random = Generator.GetRandomArray(1000);
			//System.out.println("selection sort vs nearly sorted data:  " + Sort.Selection(numbers_nearlysorted) + " milliseconds");
			//System.out.println("selection sort vs reverse sorted data: " + Sort.Bubble(numbers_reverse) + " milliseconds");
			System.out.println("selection sort vs random sorted data:  " + Sort.Selection(numbers_random) + " milliseconds");
		} catch(Exception e) {
			
		} finally {
			Print(numbers_random);
		}
	}
	private static void Util_Print(Vector<Integer> v) {
		for(int i = 0; i < v.size(); i++) {
			System.out.println(v.get(i));
		}
	}
	public static void SortCountTime() {
		System.out.println("Going!");
		
		for(int i = 0; i < 3; i++) {
			try {
				switch(i) {
					case 0: //selection sort
						numbers_nearlysorted = Generator.GetNearlySortedArray(1000);
						numbers_reverse = Generator.GetReverseArray(1000);
						numbers_random = Generator.GetRandomArray(1000);
						//System.out.println("selection sort vs nearly sorted data:  " + Sort.Selection(numbers_nearlysorted) + " milliseconds");
						//System.out.println("selection sort vs reverse sorted data: " + Sort.Selection(numbers_reverse) + " milliseconds");
						//System.out.println("selection sort vs random sorted data:  " + Sort.Selection(numbers_random) + " milliseconds");
						break;
					case 1: //bubble sort
						numbers_nearlysorted = Generator.GetNearlySortedArray(1000);
						numbers_reverse = Generator.GetReverseArray(1000);
						numbers_random = Generator.GetRandomArray(1000);
						System.out.println("bubble sort vs nearly sorted data:     " + Sort.Bubble(numbers_nearlysorted) + " milliseconds");
						System.out.println("bubble sort vs reverse sorted data:    " + Sort.Bubble(numbers_reverse) + " milliseconds");
						System.out.println("bubble sort vs random sorted data:     " + Sort.Bubble(numbers_random) + " milliseconds");
						break;
					case 2: //insertion sort
						numbers_nearlysorted = Generator.GetNearlySortedArray(1000);
						numbers_reverse = Generator.GetReverseArray(1000);
						numbers_random = Generator.GetRandomArray(1000);
						System.out.println("insertion sort vs nearly sorted data:  " + Sort.Insertion(numbers_nearlysorted) + " milliseconds");
						System.out.println("insertion sort vs reverse sorted data: " + Sort.Insertion(numbers_reverse) + " milliseconds");
						System.out.println("insertion sort vs random sorted data:  " + Sort.Insertion(numbers_random) + " milliseconds");
						break;
				}
			} catch(Exception e) {
				
			} finally {
				
			}
		}
	}

	
	
	public static void Print(int[] v) {
		for(int i = 0; i < v.length; i++){
			System.out.println(v[i]);
		}
	}
}
