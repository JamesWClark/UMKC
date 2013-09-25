package jwc62f.edu.umkc.assignment.two;

import java.util.Calendar;
import java.util.Collections;
import java.util.Vector;

public class Sort {
	
	///////////////////////////////////////////// VECTORS  SORTS //////////////////////////////////////////
	public static Object[] Bubble(Vector<Integer> vector) {
		int comparisons = 0;
		int exchanges = 0;
		long start = Calendar.getInstance().getTimeInMillis();
		int last = vector.size();
		for(int pass = 1; pass < last; pass++) {
			++comparisons;
			for(int first_of_pair = 0; first_of_pair != last - pass; ++first_of_pair) {
				++comparisons;
				int second_of_pair = first_of_pair + 1;
				if(vector.get(second_of_pair) < vector.get(first_of_pair)){
					Collections.swap(vector, second_of_pair, first_of_pair);
					++exchanges;
				}
			}
		}
		long finish = Calendar.getInstance().getTimeInMillis();
		Object[] stats = new Object[3];
		stats[0] = (finish - start);
		stats[1] = comparisons;
		stats[2] = exchanges;
		return stats;
	}
	public static Object[] Selection(Vector<Integer> vector) {
		int comparisons = 0;
		int exchanges = 0;
		long start = Calendar.getInstance().getTimeInMillis();
		int size = vector.size();
		for(int fill = 0; fill != size - 1; ++fill) {
			++comparisons;
			int pos_min = fill;
			for(int next = fill + 1; next != size; ++next) {
				++comparisons;
				if(vector.get(next) < vector.get(pos_min)) {
					pos_min = next;
				}
			}
			if (fill != pos_min) { 
				Collections.swap(vector, fill, pos_min);
				++exchanges;
			}
		}
		long finish = Calendar.getInstance().getTimeInMillis();
		Object[] stats = new Object[3];
		stats[0] = (finish - start);
		stats[1] = comparisons;
		stats[2] = exchanges;
		return stats;
	}
	public static Object[] Insertion(Vector<Integer> vector) {
		int comparisons = 0;
		int exchanges = 0;
		long start = Calendar.getInstance().getTimeInMillis();
		int first = 0;
		int last = vector.size();
		for(int next_pos = first + 1; next_pos != last; ++next_pos) {
			int next_val = vector.get(next_pos);
			while(next_pos != first && next_val < vector.get(next_pos-1)) {
				++comparisons;
				Collections.swap(vector, next_pos-1, next_pos--);
			}
			vector.setElementAt(next_val, next_pos);
			++exchanges;
		}
		long finish = Calendar.getInstance().getTimeInMillis();
		Object[] stats = new Object[3];
		stats[0] = (finish - start);
		stats[1] = comparisons;
		stats[2] = exchanges;
		return stats;
	}
	public static Object[] Shell(Vector<Integer> vector) {
		int comparisons = 0;
		int exchanges = 0;
		long start = Calendar.getInstance().getTimeInMillis();
        for (int gap = vector.size() / 2; gap > 0; gap = gap == 2 ? 1 : (int)( gap / 2.2 )) {
            for (int i = gap; i < vector.size(); i++) {
                int temp = vector.get(i);
                int j = i;
                for ( ; j >= gap && temp < vector.get(j - gap); j -= gap) {
                	++comparisons;
                	vector.setElementAt(vector.get(j - gap), j);
                }
                vector.setElementAt(temp, j);
                ++exchanges;
            }
        }
		long finish = Calendar.getInstance().getTimeInMillis();
		Object[] stats = new Object[3];
		stats[0] = (finish - start);
		stats[1] = comparisons;
		stats[2] = exchanges;
		return stats;
    }
	
	
	
	/*#####################  EVERYTHING BELOW THIS LINE IS BEYOND THE SCOPE OF THIS ASSIGNMENT ##############*/
	/*#######################################################################################################*/
	
	
	///////////////////////////////////////////// GENERIC SORTS ///////////////////////////////////////////////
	//all of my Comparable method declarations are based on the example I found at 
	//http://stackoverflow.com/questions/4833423/shell-sort-java-example#answer-17543917
	public static <T extends Comparable<? super T>> Object[] Bubble(T[] array) {
		int comparisons = 0;
		int exchanges = 0;
		long start = Calendar.getInstance().getTimeInMillis();
		int last = array.length;
		for(int pass = 1; pass < last; pass++) {
			++comparisons;
			for(int first_of_pair = 0; first_of_pair != last - pass; ++first_of_pair) {
				++comparisons;
				int second_of_pair = first_of_pair + 1;
				if(array[second_of_pair].compareTo(array[first_of_pair]) < 0){
					Util.Swap(array, second_of_pair, first_of_pair);
					++exchanges;
				}
			}
		}
		long finish = Calendar.getInstance().getTimeInMillis();
		Object[] stats = new Object[3];
		stats[0] = (finish - start);
		stats[1] = comparisons;
		stats[2] = exchanges;
		return stats;
	}
	public static <T extends Comparable<? super T>> Object[] Selection(T[] array) {
		int comparisons = 0;
		int exchanges = 0;
		long start = Calendar.getInstance().getTimeInMillis();
		int size = array.length;
		for(int fill = 0; fill != size - 1; ++fill) {
			++comparisons;
			int pos_min = fill;
			for(int next = fill + 1; next != size; ++next) {
				++comparisons;
				if(array[next].compareTo(array[pos_min]) < 0) {
					pos_min = next;
				}
			}
			if (fill != pos_min) { 
				Util.Swap(array, fill, pos_min);
				++exchanges;
			}
		}
		long finish = Calendar.getInstance().getTimeInMillis();
		Object[] stats = new Object[3];
		stats[0] = (finish - start);
		stats[1] = comparisons;
		stats[2] = exchanges;
		return stats;
	}
	public static <T extends Comparable<? super T>> Object[] Insertion(T[] array) {
		int comparisons = 0;
		int exchanges = 0;
		long start = Calendar.getInstance().getTimeInMillis();
		int first = 0;
		int last = array.length;
		for(int next_pos = first + 1; next_pos != last; ++next_pos) {
			T next_val = array[next_pos];
			while(next_pos != first && next_val.compareTo(array[next_pos-1]) < 0) {
				++comparisons;
				Util.Swap(array, next_pos-1, next_pos--);
			}
			array[next_pos] = next_val;
			++exchanges;
		}
		long finish = Calendar.getInstance().getTimeInMillis();
		Object[] stats = new Object[3];
		stats[0] = (finish - start);
		stats[1] = comparisons;
		stats[2] = exchanges;
		return stats;
	}
	//http://stackoverflow.com/questions/4833423/shell-sort-java-example
	public static <T extends Comparable<? super T>> Object[] Shell(T[] array) {
		int comparisons = 0;
		int exchanges = 0;
		long start = Calendar.getInstance().getTimeInMillis();
        for (int gap = array.length / 2; gap > 0; gap = gap == 2 ? 1 : (int)( gap / 2.2 )) {
            for (int i = gap; i < array.length; i++) {
                T temp = array[i];
                int j = i;
                for ( ; j >= gap && temp.compareTo(array[j - gap]) < 0; j -= gap) {
                	++comparisons;
                	array[j] = array[j - gap];
                }
                array[j] = temp;
                ++exchanges;
            }
        }
		long finish = Calendar.getInstance().getTimeInMillis();
		Object[] stats = new Object[3];
		stats[0] = (finish - start);
		stats[1] = comparisons;
		stats[2] = exchanges;
		return stats;
    }
	///////////////////////////////////////////// INTEGER SORTS  ///////////////////////////////////////////
	public static Object[] Bubble(int[] array) {
		int comparisons = 0;
		int exchanges = 0;
		long start = Calendar.getInstance().getTimeInMillis();
		int last = array.length;
		for(int pass = 1; pass < last; pass++) {
			++comparisons;
			for(int first_of_pair = 0; first_of_pair != last - pass; ++first_of_pair) {
				++comparisons;
				int second_of_pair = first_of_pair + 1;
				if(array[second_of_pair] < array[first_of_pair]){
					Util.Swap(array, second_of_pair, first_of_pair);
					++exchanges;
				}
			}
		}
		long finish = Calendar.getInstance().getTimeInMillis();
		Object[] stats = new Object[3];
		stats[0] = (finish - start);
		stats[1] = comparisons;
		stats[2] = exchanges;
		return stats;
	}
	public static Object[] Selection(int[] array) {
		int comparisons = 0;
		int exchanges = 0;
		long start = Calendar.getInstance().getTimeInMillis();
		int size = array.length;
		for(int fill = 0; fill != size - 1; ++fill) {
			++comparisons;
			int pos_min = fill;
			for(int next = fill + 1; next != size; ++next) {
				++comparisons;
				if(array[next] < array[pos_min]) {
					pos_min = next;
				}
			}
			if (fill != pos_min) { 
				Util.Swap(array, fill, pos_min);
				++exchanges;
			}
		}
		long finish = Calendar.getInstance().getTimeInMillis();
		Object[] stats = new Object[3];
		stats[0] = (finish - start);
		stats[1] = comparisons;
		stats[2] = exchanges;
		return stats;
	}
	public static Object[] Insertion(int[] array) {
		int comparisons = 0;
		int exchanges = 0;
		long start = Calendar.getInstance().getTimeInMillis();
		int first = 0;
		int last = array.length;
		for(int next_pos = first + 1; next_pos != last; ++next_pos) {
			int next_val = array[next_pos];
			while(next_pos != first && next_val < array[next_pos-1]) {
				++comparisons;
				Util.Swap(array, next_pos-1, next_pos--);
			}
			array[next_pos] = next_val;
			++exchanges;
		}
		long finish = Calendar.getInstance().getTimeInMillis();
		Object[] stats = new Object[3];
		stats[0] = (finish - start);
		stats[1] = comparisons;
		stats[2] = exchanges;
		return stats;
	}
	//http://stackoverflow.com/questions/4833423/shell-sort-java-example
	public static Object[] Shell(int[] array) {
		int comparisons = 0;
		int exchanges = 0;
		long start = Calendar.getInstance().getTimeInMillis();
        for (int gap = array.length / 2; gap > 0; gap = gap == 2 ? 1 : (int)( gap / 2.2 )) {
            for (int i = gap; i < array.length; i++) {
                int temp = array[i];
                int j = i;
                for ( ; j >= gap && temp < array[j - gap]; j -= gap) {
                	++comparisons;
                	array[j] = array[j - gap];
                }
                array[j] = temp;
                ++exchanges;
            }
        }
		long finish = Calendar.getInstance().getTimeInMillis();
		Object[] stats = new Object[3];
		stats[0] = (finish - start);
		stats[1] = comparisons;
		stats[2] = exchanges;
		return stats;
    }

}
