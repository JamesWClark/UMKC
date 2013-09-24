package jwc62f.edu.umkc.assignment.two;

import static org.junit.Assert.*;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;

import java.util.Vector;

public class Test_Generator {

	@Before
	public void setUp() throws Exception {
	}

	@After
	public void tearDown() throws Exception {
	}

	//////////////////////////////////// VECTOR
	@Test
	public void testGetNearlySortedVector() {
		int[] array = {1,0,2,3,4,5,6,7,8,9,11,10,12,13,14,15,16,17,18,19,21,20,22,23};
		Vector<Integer> vector = new Vector<Integer>(array.length);
		for(int i = 0; i < array.length; i++) {
			vector.add(i, array[i]);
		}
		
		Vector<Integer> result = Generator.GetNearlySortedVector(24);
		for(int i = 0; i < vector.size(); i++) {
			if(vector.get(i) != result.get(i)) {
				fail("the arrays did not match");
			}
		}
	}
	@Test
	public void testGetRandomVector() {
		int[] array = {0,1,2,3,4,5,6,7,8,9};
		Vector<Integer> vector = new Vector<Integer>(array.length);
		for(int i:array) {
			vector.add(i, array[i]);
		}
		Vector<Integer> result = Generator.GetRandomVector(10);
		Sort.Bubble(result);
		for(int i = 0; i < array.length; i++) {
			if(result.get(i) != vector.get(i)) {
				fail("the arrays did not match");
			}
		}
	}

	@Test
	public void testGetReverseVector() {
		int[] array = {9,8,7,6,5,4,3,2,1,0};
		Vector<Integer> vector = new Vector<Integer>(array.length);
		for(int i = 0; i < array.length; i++) {
			vector.add(array[i]);
		}
		Vector<Integer> result = Generator.GetReverseVector(array.length);
		for(int i = 0; i < array.length; i++) {
			if(result.get(i) != vector.get(i)) {
				fail("the arrays did not match");
			}
		}
	}

	@Test
	public void testGetVector() {
		int[] array = {0,1,2,3,4,5,6,7,8,9};
		Vector<Integer> vector = new Vector<Integer>(array.length);
		for(int i:array) {
			vector.add(i, array[i]);
		}
		Vector<Integer> result = Generator.GetVector(array.length);
		for(int i = 0; i < array.length; i++) {
			if(result.get(i) != vector.get(i)) {
				fail("the arrays did not match");
			}
		}
	}
	
	//////////////////////// INTEGER
	@Test
	public void testGetNearlySortedArray() {
		int[] array = {1,0,2,3,4,5,6,7,8,9,11,10,12,13,14,15,16,17,18,19,21,20,22,23};
		int[] result = Generator.GetNearlySortedArray(24);
		for(int i = 0; i < array.length; i++) {
			if(result[i] != array[i]) {
				fail("the arrays did not match");
			}
		}
	}

	@Test
	public void testGetRandomArray() {
		int[] array = {0,1,2,3,4,5,6,7,8,9};
		int[] result = Generator.GetRandomArray(10);
		Sort.Bubble(result);
		for(int i = 0; i < array.length; i++) {
			if(result[i] != array[i]) {
				fail("the arrays did not match");
			}
		}
	}

	@Test
	public void testGetReverseArray() {
		int[] array = {5,4,3,2,1,0};
		int[] result = Generator.GetReverseArray(array.length);
		for(int i = 0; i < array.length; i++) {
			if(result[i] != array[i]) {
				fail("the arrays did not match");
			}
		}
	}

	@Test
	public void testGetArray() {
		int[] array = {0,1,2,3,4,5,6,7,8,9};
		int[] result = Generator.GetArray(array.length);
		for(int i = 0; i < array.length; i++) {
			if(result[i] != array[i]) {
				fail("the arrays did not match");
			}
		}
	}

}
