package jwc62f.edu.umkc.assignment.two;

import java.io.*;
import java.util.Arrays;
import java.util.Vector;

public class Run {
	
	private static int[] sample = { 44, 75, 23, 43, 55, 12, 64, 77, 33 };

	private static Vector<Integer> numbers_nearlysorted = null;
	private static Vector<Integer> numbers_reverse = null;
	private static Vector<Integer> numbers_random = null;

	public static void main(String[] args) {
		try {
			numbers_nearlysorted = GetVectorCSV("1000integers_nearlysorted.csv");
			numbers_reverse = GetVectorCSV("1000integers_reverse.csv");
			numbers_random = GetVectorCSV("1000integers_random.csv");
			System.out.println("selection sort vs nearly sorted data:  " + Sort.Shell(numbers_nearlysorted) + " milliseconds");
			System.out.println("selection sort vs reverse sorted data: " + Sort.Shell(numbers_reverse) + " milliseconds");
			System.out.println("selection sort vs random sorted data:  " + Sort.Shell(numbers_random) + " milliseconds");
		} catch(IOException e) {
			
		} finally {
			Util_Print(numbers_random);
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
						numbers_nearlysorted = GetVectorCSV("1000integers_nearlysorted.csv");
						numbers_reverse = GetVectorCSV("1000integers_reverse.csv");
						numbers_random = GetVectorCSV("1000integers_random.csv");
						System.out.println("selection sort vs nearly sorted data:  " + Sort.Selection(numbers_nearlysorted) + " milliseconds");
						System.out.println("selection sort vs reverse sorted data: " + Sort.Selection(numbers_reverse) + " milliseconds");
						System.out.println("selection sort vs random sorted data:  " + Sort.Selection(numbers_random) + " milliseconds");
						break;
					case 1: //bubble sort
						numbers_nearlysorted = GetVectorCSV("1000integers_nearlysorted.csv");
						numbers_reverse = GetVectorCSV("1000integers_reverse.csv");
						numbers_random = GetVectorCSV("1000integers_random.csv");
						System.out.println("bubble sort vs nearly sorted data:     " + Sort.Bubble(numbers_nearlysorted) + " milliseconds");
						System.out.println("bubble sort vs reverse sorted data:    " + Sort.Bubble(numbers_reverse) + " milliseconds");
						System.out.println("bubble sort vs random sorted data:     " + Sort.Bubble(numbers_random) + " milliseconds");
						break;
					case 2: //insertion sort
						numbers_nearlysorted = GetVectorCSV("1000integers_nearlysorted.csv");
						numbers_reverse = GetVectorCSV("1000integers_reverse.csv");
						numbers_random = GetVectorCSV("1000integers_random.csv");
						System.out.println("insertion sort vs nearly sorted data:  " + Sort.Insertion(numbers_nearlysorted) + " milliseconds");
						System.out.println("insertion sort vs reverse sorted data: " + Sort.Insertion(numbers_reverse) + " milliseconds");
						System.out.println("insertion sort vs random sorted data:  " + Sort.Insertion(numbers_random) + " milliseconds");
						break;
				}
			} catch(IOException e) {
				
			} finally {
				
			}
		}
	}
	public static Vector<Integer> GetVectorCSV(String fileName) throws IOException {

		Vector<Integer> v = new Vector<Integer>(1000);
		BufferedReader br = null;
		
		try {
		
			String sCurrentLine;
		
			br = new BufferedReader(new FileReader(fileName));
		
			while ((sCurrentLine = br.readLine()) != null) {
			   String[] data = sCurrentLine.split(",");
			   for (String item:data) { 
			      try{
			    	  v.add(Integer.parseInt(item));
			      } catch (Exception e){
			    	  
			      }
			   }
			}
		
		} catch (IOException e) {
			e.printStackTrace();
		} finally {
			try {
				if (br != null)br.close();
			} catch (IOException ex) {
				ex.printStackTrace();
			}
		}
		return v;
	}
	
	
	public static void Print(Vector<Integer> v) {
		for(int i = 0; i < v.size(); i++){
			System.out.println(v.get(i));
		}
	}
	public static void write1000nearlySortedIntegers() {
		try {

			String s = "";
			for(int i = 0; i < 1000; i += 2) {
				if(i % 5 == 0) {
					s += ((i+1) + ",\n");
					s += (i + ",\n");
				} else {
					s += (i + ",\n");
					s += ((i+1) + ",\n");
				}
				
			}

			File file = new File("filename.csv");

			// if file doesnt exists, then create it
			if (!file.exists()) {
				file.createNewFile();
			}

			FileWriter fw = new FileWriter(file.getAbsoluteFile());
			BufferedWriter bw = new BufferedWriter(fw);
			bw.write(s);
			bw.close();

			System.out.println("Done");

		} catch (IOException e) {
			e.printStackTrace();
		}
	}
}
