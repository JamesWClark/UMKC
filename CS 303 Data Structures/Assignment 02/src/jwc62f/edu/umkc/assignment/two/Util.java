package jwc62f.edu.umkc.assignment.two;

import java.io.*;
import java.util.ArrayList;

public class Util {
	public static <T extends Comparable<? super T>> void Swap(T[] array, int a, int b) {
		T temp = array[b];
		array[b] = array[a];
		array[a] = temp;
	}
	public static void Swap(int[] array, int a, int b) {
		int temp = array[b];
		array[b] = array[a];
		array[a] = temp;
	}
	public static String[] GetStringCSV(String fileName) throws IOException {
		ArrayList<String> list = new ArrayList<String>();
		BufferedReader br = null;
		try {
			String line;
			br = new BufferedReader(new FileReader(fileName));
			while ((line = br.readLine()) != null) {
			   String[] data = line.split(",");
			   for (String item:data) { 
			      try{
			    	  list.add(item);
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
		String[] array = new String[list.size()];
		array = list.toArray(array);
		return array;
	}
	public static void CreateStringCSV_NearlySorted(String filePath) {
		try {
			String[] array = GetStringCSV("1000strings_random.csv");
			Sort.Shell(array);
			WriteNearlySortedStrings(filePath, array);
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	public static void WriteNearlySortedStrings(String fileName, String[] array) {
		try {
			for(int i = 0; i < array.length; i += 2) {
				if(i % 5 == 0) {
					Util.Swap(array, i+1, i);
				}
			}

			File file = new File(fileName);

			if (!file.exists()) {
				file.createNewFile();
			}

			String s = "";
			for (int i = 0; i < array.length; i++) {
				s += array[i] + ",\n";
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
