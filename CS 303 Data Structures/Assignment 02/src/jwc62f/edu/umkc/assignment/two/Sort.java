package jwc62f.edu.umkc.assignment.two;

import java.util.Calendar;
import java.util.Collections;
import java.util.Vector;

public class Sort {
	
	///////////////////////////////////////////// INTEGER VECTORS //////////////////////////////////////////
	public static Object[] Bubble(Vector<Integer> vector) {
		int iterations = 0;
		int swaps = 0;
		long start = Calendar.getInstance().getTimeInMillis();
		int last = vector.size();
		for(int pass = 1; pass < last; pass++) {
			++iterations;
			for(int first_of_pair = 0; first_of_pair != last - pass; ++first_of_pair) {
				++iterations;
				int second_of_pair = first_of_pair + 1;
				if(vector.get(second_of_pair) < vector.get(first_of_pair)){
					Collections.swap(vector, second_of_pair, first_of_pair);
					++swaps;
				}
			}
		}
		long finish = Calendar.getInstance().getTimeInMillis();
		Object[] stats = new Object[3];
		stats[0] = (finish - start);
		stats[1] = iterations;
		stats[2] = swaps;
		return stats;
	}
	
	///////////////////////////////////////////// INTEGER ARRAYS ///////////////////////////////////////////
	public static Object[] Bubble(int[] array) {
		int iterations = 0;
		int swaps = 0;
		long start = Calendar.getInstance().getTimeInMillis();
		int last = array.length;
		for(int pass = 1; pass < last; pass++) {
			++iterations;
			for(int first_of_pair = 0; first_of_pair != last - pass; ++first_of_pair) {
				++iterations;
				int second_of_pair = first_of_pair + 1;
				if(array[second_of_pair] < array[first_of_pair]){
					Swap(array, second_of_pair, first_of_pair);
					++swaps;
				}
			}
		}
		long finish = Calendar.getInstance().getTimeInMillis();
		Object[] stats = new Object[3];
		stats[0] = (finish - start);
		stats[1] = iterations;
		stats[2] = swaps;
		return stats;
	}
	public static Object[] Selection(int[] array) {
		int iterations = 0;
		int swaps = 0;
		long start = Calendar.getInstance().getTimeInMillis();
		int size = array.length;
		for(int fill = 0; fill != size - 1; ++fill) {
			++iterations;
			int pos_min = fill;
			for(int next = fill + 1; next != size; ++next) {
				++iterations;
				if(array[next] < array[pos_min]) {
					pos_min = next;
				}
			}
			if (fill != pos_min) { 
				Swap(array, fill, pos_min);
				++swaps;
			}
		}
		long finish = Calendar.getInstance().getTimeInMillis();
		Object[] stats = new Object[3];
		stats[0] = (finish - start);
		stats[1] = iterations;
		stats[2] = swaps;
		return stats;
	}
	public static Object[] Insertion(int[] array) {
		int iterations = 0;
		int swaps = 0;
		long start = Calendar.getInstance().getTimeInMillis();
		int first = 0;
		int last = array.length;
		for(int next_pos = first + 1; next_pos != last; ++next_pos) {
			++iterations;
			int next_val = array[next_pos];
			while(next_pos != first && next_val < array[next_pos-1]) {
				++iterations;
				Swap(array, next_pos-1, next_pos--);
				++swaps;
			}
			array[next_val] = next_pos;
		}
		long finish = Calendar.getInstance().getTimeInMillis();
		Object[] stats = new Object[3];
		stats[0] = (finish - start);
		stats[1] = iterations;
		stats[2] = swaps;
		return stats;
	}
	//select a pivot
	//lesser values left
	//greater values right
	//recursively repeat on sub-arrays
		//left-side: set pivot at position 0
		//everything right of new pivot becomes new subarray
		//this continues until only single elements are on the right and left of a pivot - that means they are sorted
	
	private static int quick_iterations = 0;
	private static int quick_swaps = 0;
	public static int[] Quick(int[] array, int from_index, int to_index) {
		++quick_iterations;
		if(to_index - from_index > 1) {
			int pivot_index = Util_Partition(array, from_index, to_index);
			Quick(array, from_index, pivot_index);
			Quick(array, pivot_index + 1, to_index);
		}
		return new int[]{quick_iterations, quick_swaps};
	}
	//select the pivot (can be any element)
	//find first value at left side > than pivot
	//find first value at right side <= pivot
	//exchange both, repeat search
	private static int Util_Partition(int[] array, int first, int last) {
		int up_index = first + 1;
		int down_index = last - 1;
		do {
			++quick_iterations;
			while((up_index != down_index) && !(array[first] < array[up_index])) {
				++up_index;
			}
			while(array[first] < array[down_index]) {
				--down_index;
			}
			if(up_index < down_index) { 
				Swap(array, up_index, down_index);
				++quick_swaps;
			}
		} while (up_index < down_index);
		
		Swap(array, first, down_index);
		++quick_swaps;
		return down_index;
	}
	//http://stackoverflow.com/questions/4833423/shell-sort-java-example
	public static Object[] Shell(int[] array) {
		int iterations = 0;
		int swaps = 0;
		long start = Calendar.getInstance().getTimeInMillis();
        for (int gap = array.length / 2; gap > 0; gap = gap == 2 ? 1 : (int)( gap / 2.2 )) {
        	++iterations;
            for (int i = gap; i < array.length; i++) {
            	++iterations;
                int temp = array[i];
                int j = i;
                for ( ; j >= gap && temp < array[j - gap]; j -= gap) {
                	array[j] = array[j - gap];
                }
                array[j] = temp;
                ++swaps;
            }
        }
		long finish = Calendar.getInstance().getTimeInMillis();
		Object[] stats = new Object[3];
		stats[0] = (finish - start);
		stats[1] = iterations;
		stats[2] = swaps;
		return stats;
    }
	private static void Swap(int[] array, int a, int b) {
		int temp = array[b];
		array[b] = array[a];
		array[a] = temp;
	}
}
