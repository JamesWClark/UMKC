package jwc62f.edu.umkc.assignment.two;

public class Run {
	
	private static int[] numbers_nearlysorted = null;
	private static int[] numbers_reverse = null;
	private static int[] numbers_random = null;

	public static void main(String[] args) {
		SortCountTime();
	}
	public static void SortCountTime() {
		
		for(int i = 0; i < 5; i++) {
			numbers_nearlysorted = Generator.GetNearlySortedArray(1000);
			numbers_reverse = Generator.GetReverseArray(1000);
			numbers_random = Generator.GetRandomArray(1000);
			try {
				switch(i) {
					case 0: //selection sort
						System.out.println("selection sort vs nearly sorted data:  " + Sort.Selection(numbers_nearlysorted) + " milliseconds");
						System.out.println("selection sort vs reverse sorted data: " + Sort.Selection(numbers_reverse) + " milliseconds");
						System.out.println("selection sort vs random sorted data:  " + Sort.Selection(numbers_random) + " milliseconds");
						break;
					case 1: //bubble sort
						System.out.println("bubble sort vs nearly sorted data:     " + Sort.Bubble(numbers_nearlysorted) + " milliseconds");
						System.out.println("bubble sort vs reverse sorted data:    " + Sort.Bubble(numbers_reverse) + " milliseconds");
						System.out.println("bubble sort vs random sorted data:     " + Sort.Bubble(numbers_random) + " milliseconds");
						break;
					case 2: //insertion sort
						System.out.println("insertion sort vs nearly sorted data:  " + Sort.Insertion(numbers_nearlysorted) + " milliseconds");
						System.out.println("insertion sort vs reverse sorted data: " + Sort.Insertion(numbers_reverse) + " milliseconds");
						System.out.println("insertion sort vs random sorted data:  " + Sort.Insertion(numbers_random) + " milliseconds");
						break;
					case 3: //shell
						System.out.println("shell sort vs nearly sorted data:      " + Sort.Shell(numbers_nearlysorted) + " milliseconds");
						System.out.println("shell sort vs reverse sorted data:     " + Sort.Shell(numbers_reverse) + " milliseconds");
						System.out.println("shell sort vs random sorted data:      " + Sort.Shell(numbers_random) + " milliseconds");
						break;
					case 4: //quick
						System.out.println("quick sort vs nearly sorted data:      " + Sort.Quick(numbers_nearlysorted, 0, numbers_nearlysorted.length) + " milliseconds");
						System.out.println("quick sort vs reverse sorted data:     " + Sort.Quick(numbers_reverse, 0, numbers_reverse.length) + " milliseconds");
						System.out.println("quick sort vs random sorted data:      " + Sort.Quick(numbers_random, 0, numbers_random.length) + " milliseconds");
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
