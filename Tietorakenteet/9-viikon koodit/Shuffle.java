package javatutorials;

import java.util.Arrays;
import java.util.Random;
import java.util.Scanner;

public class Shuffle {

    public static void main(String[] args) throws Exception {

        int[] a = new int[]{1,2,3,5};

   
            for (int i = 0; i < a.length; i++) {

                int j = i + new Random().nextInt(a.length - i);
                swap(a, j, i);
            }

            System.out.println(Arrays.toString(a));
        
    }

    private static void swap(int[] a, int root, int child) {
        int valueOfRoot = a[root];
        a[root] = a[child];
        a[child] = valueOfRoot;
    }
}
