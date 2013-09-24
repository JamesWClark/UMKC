package jwc62f.edu.umkc.assignment.two;

import java.util.Calendar;
import java.util.Vector;

public class Run {
	
	private static int[] numbers_nearlysorted = null;
	private static int[] numbers_reverse = null;
	private static int[] numbers_random = null;

	public static void main(String[] args) {
		Vector<Integer> vector = Generator.GetReverseVector(10);
		Sort.Bubble(vector);
		for(int i = 0; i < vector.size(); i++) {
			System.out.println(vector.elementAt(i));
		}
		//SortCountTime();
	}
	public static void SortCountTime() {
		
		for(int i = 0; i < 5; i++) {
			numbers_nearlysorted = Generator.GetNearlySortedArray(1000);
			numbers_reverse = Generator.GetReverseArray(1000);
			numbers_random = Generator.GetRandomArray(1000);
			try {
				switch(i) {
					case 0: //selection sort
						Object[] stats = Sort.Selection(numbers_nearlysorted);
						System.out.println("selection sort vs nearly sorted data:  " + stats[0] + " milliseconds\t" + stats[1] + " iterations\t" + stats[2] + " swaps");
						stats = Sort.Selection(numbers_reverse);
						System.out.println("selection sort vs reverse sorted data: " + stats[0] + " milliseconds\t" + stats[1] + " iterations\t" + stats[2] + " swaps");
						stats = Sort.Selection(numbers_random);
						System.out.println("selection sort vs random sorted data:  " + stats[0] + " milliseconds\t" + stats[1] + " iterations\t" + stats[2] + " swaps");
						break;
					case 1: //bubble sort
						stats = Sort.Bubble(numbers_nearlysorted);
						System.out.println("bubble sort vs nearly sorted data:     " + stats[0] + " milliseconds\t" + stats[1] + " iterations\t" + stats[2] + " swaps");
						stats = Sort.Bubble(numbers_reverse);
						System.out.println("bubble sort vs reverse sorted data:    " + stats[0] + " milliseconds\t" + stats[1] + " iterations\t" + stats[2] + " swaps");
						stats = Sort.Bubble(numbers_random);
						System.out.println("bubble sort vs random sorted data:     " + stats[0] + " milliseconds\t" + stats[1] + " iterations\t" + stats[2] + " swaps");
						break;
					case 2: //insertion sort
						stats = Sort.Insertion(numbers_nearlysorted);
						System.out.println("insertion sort vs nearly sorted data:  " + stats[0] + " milliseconds\t" + stats[1] + " iterations\t" + stats[2] + " swaps");
						stats = Sort.Insertion(numbers_reverse);
						System.out.println("insertion sort vs reverse sorted data: " + stats[0] + " milliseconds\t" + stats[1] + " iterations\t" + stats[2] + " swaps");
						stats = Sort.Insertion(numbers_random);
						System.out.println("insertion sort vs random sorted data:  " + stats[0] + " milliseconds\t" + stats[1] + " iterations\t" + stats[2] + " swaps");
						break;
					case 3: //shell
						stats = Sort.Shell(numbers_nearlysorted);
						System.out.println("shell sort vs nearly sorted data:      " + stats[0] + " milliseconds\t" + stats[1] + " iterations\t" + stats[2] + " swaps");
						stats = Sort.Shell(numbers_reverse);
						System.out.println("shell sort vs reverse sorted data:     " + stats[0] + " milliseconds\t" + stats[1] + " iterations\t" + stats[2] + " swaps");
						stats = Sort.Shell(numbers_random);
						System.out.println("shell sort vs random sorted data:      " + stats[0] + " milliseconds\t" + stats[1] + " iterations\t" + stats[2] + " swaps");
						break;
					case 4: //quick
						long start = Calendar.getInstance().getTimeInMillis();
						int[] quick_stats = Sort.Quick(numbers_nearlysorted, 0, numbers_nearlysorted.length);
						long duration = Calendar.getInstance().getTimeInMillis() - start;
						System.out.println("quick sort vs nearly sorted data:      " + duration + " milliseconds");
						
						start = Calendar.getInstance().getTimeInMillis();
						quick_stats = Sort.Quick(numbers_reverse, 0, numbers_reverse.length);
						duration = Calendar.getInstance().getTimeInMillis() - start;
						System.out.println("quick sort vs reverse sorted data:     " + duration + " milliseconds");
						
						start = Calendar.getInstance().getTimeInMillis();
						quick_stats = Sort.Quick(numbers_random, 0, numbers_random.length);
						duration = Calendar.getInstance().getTimeInMillis() - start;
						System.out.println("quick sort vs random sorted data:      " + duration + " milliseconds");
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
