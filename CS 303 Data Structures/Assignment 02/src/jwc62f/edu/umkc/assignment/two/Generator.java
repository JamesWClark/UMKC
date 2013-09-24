package jwc62f.edu.umkc.assignment.two;

import java.util.LinkedList;
import java.util.Vector;

public class Generator {
	
	////////////////////////////// VECTORS ///////////////////////////////////////////
	//every 10th element will be swapped with its next, 0 to length-1
	public static Vector<Integer> GetNearlySortedVector(int length) { //bug: odd length throws index error
		Vector<Integer> vector = new Vector<Integer>(length);
		for(int i = 0; i < vector.capacity(); i += 2) {
			if(i % 5 == 0) {
				vector.add(i+1);
				vector.add(i);
			} else {
				vector.add(i);
				vector.add(i+1);
			}
		}
		return vector;
	}
	//random, 0 to length-1, no duplicates
	public static Vector<Integer> GetRandomVector(int length) {
		Vector<Integer> vector = new Vector<Integer>(length);
		LinkedList<Integer> list = new LinkedList<Integer>();
		for(int i = 0; i < length; i++) {
			list.add(i);
		}
		int count = 0;
		while(list.size() > 0) {
			int rand = (int)(Math.random() * (list.size() - 1));
			vector.add(count++, list.remove(rand));
		}
		return vector;
	}
	//length-1 to 0
	public static Vector<Integer> GetReverseVector(int length) {
		Vector<Integer> vector = new Vector<Integer>(length);
		for(int i = length-1; i > -1; i--) {
			vector.add(length-1 - i, i);
		}
		return vector;
	}
	//0 to length-1
	public static Vector<Integer> GetVector(int length) {
		Vector<Integer> vector = new Vector<Integer>(length);
		for(int i = 0; i < length; i++) {
			vector.add(i, i);
		}
		return vector;
	}
	
	////////////////////////////// INTEGER ARRAYS ////////////////////////////////////
	//every 10th element will be swapped with its next, 0 to length-1
	public static int[] GetNearlySortedArray(int length) { //bug: odd length throws index error
		int[] array = new int[length];
		for(int i = 0; i < length; i += 2) {
			if(i % 5 == 0) {
				array[i] = i + 1;
				array[i + 1] = i;
			} else {
				array[i + 1] = i + 1;
				array[i] = i;
			}
		}
		return array;
	}
	//random, 0 to length-1, no duplicates
	public static int[] GetRandomArray(int length) {
		int[] array = new int[length];
		LinkedList<Integer> list = new LinkedList<Integer>();
		for(int i = 0; i < length; i++) {
			list.add(i);
		}
		int count = 0;
		while(list.size() > 0) {
			int rand = (int)(Math.random() * (list.size() - 1));
			array[count++] = list.remove(rand);
		}
		return array;
	}
	//length-1 to 0
	public static int[] GetReverseArray(int length) {
		int[] array = new int[length];
		for(int i = length-1; i > 0; i--) {
			array[length-1 - i] = i;
		}
		return array;
	}
	//0 to length-1
	public static int[] GetArray(int length) {
		int[] array = new int[length];
		for(int i = 0; i < length; i++) {
			array[i] = i;
		}
		return array;
	}
	///////////////////////////////////////////////////////////////////////////////////
}
