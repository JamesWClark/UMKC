package jwc62f.edu.umkc.assignment.two;

import static org.junit.Assert.*;

import java.util.Vector;

import org.junit.Test;

public class Test_Sort {

	////////////////////////////////////////// TEST VECTOR OF INTEGER ////////////////////////////////////
	@Test
	public void testBubbleVectorOfInteger() {
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
	public void testSelectionVectorOfInteger() {
		int[] array = {0,1,2,3,4,5,6,7,8,9};
		Vector<Integer> vector = new Vector<Integer>(array.length);
		for(int i:array) {
			vector.add(i, array[i]);
		}
		Vector<Integer> result = Generator.GetRandomVector(10);
		Sort.Selection(result);
		for(int i = 0; i < array.length; i++) {
			if(result.get(i) != vector.get(i)) {
				fail("the arrays did not match");
			}
		}
	}

	@Test
	public void testInsertionVectorOfInteger() {
		int[] array = {0,1,2,3,4,5,6,7,8,9};
		Vector<Integer> vector = new Vector<Integer>(array.length);
		for(int i:array) {
			vector.add(i, array[i]);
		}
		Vector<Integer> result = Generator.GetRandomVector(10);
		Sort.Insertion(result);
		for(int i = 0; i < array.length; i++) {
			if(result.get(i) != vector.get(i)) {
				fail("the arrays did not match");
			}
		}
	}

	@Test
	public void testShellVectorOfInteger() {
		int[] array = {0,1,2,3,4,5,6,7,8,9};
		Vector<Integer> vector = new Vector<Integer>(array.length);
		for(int i:array) {
			vector.add(i, array[i]);
		}
		Vector<Integer> result = Generator.GetRandomVector(10);
		Sort.Shell(result);
		for(int i = 0; i < array.length; i++) {
			if(result.get(i) != vector.get(i)) {
				fail("the arrays did not match");
			}
		}
	}
	/////////////////////////// TEST COMPARABLE ///////////////////////////////////
	@Test
	public void testBubbleTArray() {
		String[] array = {"zz","aa","xx","bb","ww","uu","cc","dd","yy","ll"};
		String[] result = {"aa","bb","cc","dd","ll","uu","ww","xx","yy","zz"};
		Sort.Bubble(array);
		for(int i = 0; i < array.length; i++) {
			if(result[i] != array[i]) {
				fail("the arrays did not match");
			}
		}
	}

	@Test
	public void testSelectionTArray() {
		String[] array = {"zz","aa","xx","bb","ww","uu","cc","dd","yy","ll"};
		String[] result = {"aa","bb","cc","dd","ll","uu","ww","xx","yy","zz"};
		Sort.Selection(array);
		for(int i = 0; i < array.length; i++) {
			if(result[i] != array[i]) {
				fail("the arrays did not match");
			}
		}
	}

	@Test
	public void testInsertionTArray() {
		String[] array = {"zz","aa","xx","bb","ww","uu","cc","dd","yy","ll"};
		String[] result = {"aa","bb","cc","dd","ll","uu","ww","xx","yy","zz"};
		Sort.Insertion(array);
		for(int i = 0; i < array.length; i++) {
			if(result[i] != array[i]) {
				fail("the arrays did not match");
			}
		}
	}

	@Test
	public void testShellTArray() {
		String[] array = {"zz","aa","xx","bb","ww","uu","cc","dd","yy","ll"};
		String[] result = {"aa","bb","cc","dd","ll","uu","ww","xx","yy","zz"};
		Sort.Shell(array);
		for(int i = 0; i < array.length; i++) {
			if(result[i] != array[i]) {
				fail("the arrays did not match");
			}
		}
	}

	/////////////////////////////////////////// TEST INTEGER ////////////////////////////////////////////////
	@Test
	public void testBubbleIntArray() {
		int[] array = Generator.GetRandomArray(10);
		int[] sorted = {0,1,2,3,4,5,6,7,8,9};
		Sort.Bubble(array);
		for(int i = 0; i < array.length; i++) {
			if(sorted[i] != array[i]) {
				System.out.print(array[i]);
				fail("the arrays did not match");
			}
		}
	}

	@Test
	public void testSelectionIntArray() {
		int[] array = Generator.GetRandomArray(10);
		int[] sorted = {0,1,2,3,4,5,6,7,8,9};
		Sort.Selection(array);
		for(int i = 0; i < array.length; i++) {
			if(sorted[i] != array[i]) {
				System.out.print(array[i]);
				fail("the arrays did not match");
			}
		}
	}

	@Test
	public void testInsertionIntArray() {
		int[] array = Generator.GetRandomArray(10);
		int[] sorted = {0,1,2,3,4,5,6,7,8,9};
		Sort.Insertion(array);
		for(int i = 0; i < array.length; i++) {
			if(sorted[i] != array[i]) {
				System.out.print(array[i]);
				fail("the arrays did not match");
			}
		}
	}

	@Test
	public void testShellIntArray() {
		int[] array = Generator.GetRandomArray(10);
		int[] sorted = {0,1,2,3,4,5,6,7,8,9};
		Sort.Shell(array);
		for(int i = 0; i < array.length; i++) {
			if(sorted[i] != array[i]) {
				System.out.print(array[i]);
				fail("the arrays did not match");
			}
		}
	}

}
