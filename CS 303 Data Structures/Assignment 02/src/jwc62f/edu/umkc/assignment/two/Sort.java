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
	
	public static long Bubble(int[] array) {
		long start = Calendar.getInstance().getTimeInMillis();
		int last = array.length;
		for(int pass = 1; pass < last; pass++) {
			for(int first_of_pair = 0; first_of_pair != last - pass; ++first_of_pair) {
				int second_of_pair = first_of_pair + 1;
				if(array[second_of_pair] < array[first_of_pair]){
					Swap(array, second_of_pair, first_of_pair);
				}
			}
		}
		long finish = Calendar.getInstance().getTimeInMillis();
		return (finish - start);
	}
	/*
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
	*/

	public static long Selection(int[] array) {
		long start = Calendar.getInstance().getTimeInMillis();
		int size = array.length;
		for(int fill = 0; fill != size - 1; ++fill) {
			int pos_min = fill;
			for(int next = fill + 1; next != size; ++next) {
				if(array[next] < array[pos_min]) {
					pos_min = next;
				}
			}
			if (fill != pos_min) { 
				Swap(array, fill, pos_min);
			}
		}
		long finish = Calendar.getInstance().getTimeInMillis();
		return (finish - start);
	}

	private static void Swap(int[] array, int a, int b) {
		int temp = array[b];
		array[b] = array[a];
		array[a] = temp;
	}
	public static long Insertion(int[] array) {
		long start = Calendar.getInstance().getTimeInMillis();
		int first = 0;
		int last = array.length;
		for(int next_pos = first + 1; next_pos != last; ++next_pos) {
			int next_val = array[next_pos];
			while(next_pos != first && next_val < array[next_pos-1]) {
				Swap(array, next_pos-1, next_pos--);
			}
			array[next_val] = next_pos;
		}
		long finish = Calendar.getInstance().getTimeInMillis();
		return (finish - start);
	}
	public static long Shell(int[] array) {
		long start = Calendar.getInstance().getTimeInMillis();
		int first = 0;
		int last = array.length - 1;
		//set the initial value of gap = n/2
		int gap = (last - first) / 2; 
		while(gap > 0) {
			//for each element from position gap to the last element
			for(int next_pos = first + gap; next_pos != last; ++next_pos) {
				//insert this element where it belongs in the subarray
				
				int next_val = array[next_pos];
				while((next_pos > (first + gap - 1) && (next_val < next_pos - gap))) {
					next_pos = next_pos - gap;
					next_pos -= gap;
				}
				array[next_pos] = next_val;
				/*
				4.1 next_pos is an iterator to the element to insert.
					4.2 Save the value of the element to insert in next_val.
					4.3 while next_pos > first + gap and the element at next_pos – gap >
					next_val
					4.4 Shift the element at next_pos – gap to position next_pos.
					4.5 Decrement next_pos by gap.
 
				 */
			}
			//if gap is 2, set it to 1
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
	public static long Quick(int[] array, int from_index, int to_index) {
		long start = Calendar.getInstance().getTimeInMillis();
		if(to_index - from_index > 1) {
			int pivot_index = Util_Partition(array, from_index, to_index);
			Quick(array, from_index, pivot_index);
			Quick(array, pivot_index + 1, to_index);
		}
		long finish = Calendar.getInstance().getTimeInMillis();
		return (finish - start);
	}
	//select the pivot (can be any element)
	//find first value at left side > than pivot
	//find first value at right side <= pivot
	//exchange both, repeat search
	private static int Util_Partition(int[] array, int first, int last) {
		int up_index = first + 1;
		int down_index = last - 1;
		do {
			while((up_index != down_index) && !(array[first] < array[up_index])) {
				++up_index;
			}
			while(array[first] < array[down_index]) {
				--down_index;
			}
			if(up_index < down_index) { 
				Swap(array, up_index, down_index);
			}
		} while (up_index < down_index);
		
		Swap(array, first, down_index);
		return down_index;
	}
	//http://stackoverflow.com/questions/4833423/shell-sort-java-example
	public static long shellsort(int[] array)
    {
		long start = Calendar.getInstance().getTimeInMillis();
        for( int gap = array.length / 2; gap > 0;
                     gap = gap == 2 ? 1 : (int) ( gap / 2.2 ) )
            for( int i = gap; i < array.length; i++ )
            {
                int tmp = array[ i ];
                int j = i;

                for( ; j >= gap && tmp < array[ j - gap ]; j -= gap )
                	array[ j ] = array[ j - gap ];
                array[ j ] = tmp;
            }
		long finish = Calendar.getInstance().getTimeInMillis();
		return (finish - start);
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
