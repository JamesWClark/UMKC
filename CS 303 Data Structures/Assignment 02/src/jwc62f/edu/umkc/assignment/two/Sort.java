//1000 strings file is from http://www.census.gov/genealogy/www/data/2000surnames/Top1000.xls
//http://www.mkyong.com/java/how-to-read-file-from-java-bufferedreader-example/
//http://www.mkyong.com/java/how-to-write-to-file-in-java-bufferedwriter-example/

package jwc62f.edu.umkc.assignment.two;

import java.util.Collections;
import java.util.Calendar;
import java.util.Vector;

/**
 * 
 * this comment
 * @author JWC
 *
 */
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
	public static long Shell(Vector<Integer> v) {
		long start = Calendar.getInstance().getTimeInMillis();
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
		long finish = Calendar.getInstance().getTimeInMillis();
		return (finish - start);
	}
	//select a pivot
	//lesser values left
	//greater values right
	//recursively repeat on sub-arrays
		//left-side: set pivot at position 0
		//everything right of new pivot becomes new subarray
		//this continues until only single elements are on the right and left of a pivot - that means they are sorted
	public static long Quick(Vector<Integer> v, int from_index, int to_index) {
		long start = Calendar.getInstance().getTimeInMillis();
		if(to_index - from_index > 1) {
			int pivot_index = Util_Partition(v, from_index, to_index);
			Quick(v, from_index, pivot_index);
			Quick(v, pivot_index + 1, to_index);
		}
		long finish = Calendar.getInstance().getTimeInMillis();
		return (finish - start);
	}
	//select the pivot (can be any element)
	//find first value at left side > than pivot
	//find first value at right side <= pivot
	//exchange both, repeat search
	private static int Util_Partition(Vector<Integer> v, int first, int last) {
		int up_index = first + 1;
		int down_index = last - 1;
		do {
			while((up_index != down_index) && !(v.get(first) < v.get(up_index))) {
				++up_index;
			}
			while(v.get(first) < v.get(down_index)) {
				--down_index;
			}
			if(up_index < down_index) { 
				Collections.swap(v, up_index, down_index);
			}
		} while (up_index < down_index);
		
		Collections.swap(v, first, down_index);
		return down_index;
		
	}
	private static void Util_Insert(int first, int next_pos, int gap) {
		int next_val = next_pos;
		while((next_pos > (first + gap - 1) && (next_val < next_pos - gap))) {
			next_pos = next_pos - gap;
			next_pos -= gap;
		}
		next_pos = next_val;
	}
	/*
		 4.1 next_pos is an iterator to the element to insert.
		4.2 Save the value of the element to insert in next_val.
		4.3 while next_pos > first + gap and the element at next_pos – gap >
		next_val
		4.4 Shift the element at next_pos – gap to position next_pos.
		4.5 Decrement next_pos by gap.
		4.6 Insert next_val at next_pos.

	 */
}
