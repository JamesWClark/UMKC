//1000 strings file is from http://www.census.gov/genealogy/www/data/2000surnames/Top1000.xls
//http://www.mkyong.com/java/how-to-read-file-from-java-bufferedreader-example/
//http://www.mkyong.com/java/how-to-write-to-file-in-java-bufferedwriter-example/

package jwc62f.edu.umkc.assignment.two;

import java.util.Collections;
import java.util.Calendar;
import java.util.Vector;

public class Sort {
	
	public static long Bubble(Vector<Integer> v) {
		long start = Calendar.getInstance().getTimeInMillis();
		int last = v.size();
		for(int pass = 1; pass < last; pass++) {
			for(int first_of_pair = 0; first_of_pair != last - pass; ++first_of_pair) {
				int second_of_pair = first_of_pair + 1;
				if(v.get(second_of_pair) < v.get(first_of_pair)){
					Collections.swap(v, second_of_pair, first_of_pair);
				}
			}
		}
		long finish = Calendar.getInstance().getTimeInMillis();
		return (finish - start);
	}
	public static long Selection(Vector<Integer> v) {
		long start = Calendar.getInstance().getTimeInMillis();
		int size = v.size();
		for(int fill = 0; fill != size - 1; ++fill) {
			int pos_min = fill;
			for(int next = fill + 1; next != size; ++next) {
				if(v.get(next) < v.get(pos_min)) {
					pos_min = next;
				}
			}
			if (fill != pos_min) { 
				Collections.swap(v, fill, pos_min);
			}
		}
		long finish = Calendar.getInstance().getTimeInMillis();
		return (finish - start);
	}
	public static long Insertion(Vector<Integer> v) {
		long start = Calendar.getInstance().getTimeInMillis();
		int first = 0;
		int last = v.size();
		for(int next_pos = first + 1; next_pos != last; ++next_pos) {
			int next_val = v.get(next_pos);
			while(next_pos != first && next_val < v.get(next_pos-1)) {
				Collections.swap(v, next_pos-1, next_pos--);
			}
			v.setElementAt(next_val, next_pos);
		}
		long finish = Calendar.getInstance().getTimeInMillis();
		return (finish - start);
	}
	public static void Shell(Vector<Integer> v) {
		int first = 0;
		int last = v.size() - 1;
		int gap = (last - first) / 2; //what about 9/2 ? integers round where? this is 4, right?
		while(gap > 0) {
			for(int next_pos = first + gap; next_pos != last; ++next_pos) {
				Util_Insert(first, next_pos, gap);
			}
			if(gap == 2){
				gap = 1;
			} else {
				gap = (int)(gap / 2.2);
			}
		}
		/*
		 void shell_sort(RI first, RI last) {
		// Set initial gap between adjacent elements.
		int gap = (last - first) / 2;
		while (gap > 0) {
		for (RI next_pos = first + gap;	next_pos != last; ++next_pos) {
			// Insert element at next_pos in its subarray.
			KW::insert(first, next_pos, gap);
		}  // End for.
		// Reset gap for next pass.
		if (gap == 2) {
		gap = 1;
		} else {
		gap = int(gap / 2.2);
		}

		 */
	}
	public static void Quick() {
		
	}
	/*

		template<typename RI>
		void quick_sort(RI first, RI last) {
		if (last - first > 1) {  // There is data to be sorted.
		// Partition the table.
		RI pivot = partition(first, last);
		// Sort the left half.
		KW::quick_sort(first, pivot);


	 */
	private static void Util_Insert(int first, int next_pos, int gap) {
		int next_val = next_pos;
		while((next_pos > (first + gap - 1) && (next_val < next_pos - gap))) {
			next_pos = next_pos - gap;
			next_pos -= gap;
		}
		next_pos = next_val;
	}
	/*
	void insert(RI first, RI next_pos, 
			int gap) {
			typename std::iterator_traits<RI>::value_type next_val = *next_pos;
			// Shift all values > next_val in subarray down by gap.
			while ((next_pos > first + gap - 1)  // First element not shifted.
			&& (next_val < *(next_pos - gap))) {
			*next_pos = *(next_pos - gap);   // Shift down.
			next_pos -= gap;     // Check next position in subarray.

			
			}
			*next_pos = next_val;
			}
			} // End namespace KW
*/
}
