package javatutorials;

import java.util.Arrays;
import java.util.Scanner;

public class PaaOhjelma {

    public static void main(String[] args) throws Exception {

        int montako = Integer.parseInt(args[0]);
        int valinta = Integer.parseInt(args[1]);

        int[] a = new int[montako];

        for (int i = 0; i < montako; i++) {
            a[i] = (montako - i);
        }

        //System.out.println(Arrays.toString(a));
        if (valinta == 0) {
            Arrays.sort(a);
        } else {
            heapSort(a, a.length);
        }
        System.out.println("sorted!");
    }

    public static void heapSort(int[] a, int count) {
        heapify(a, count);

        int end = count - 1;

        while (end > 0) {
            swap(a, end, 0);
            end--;
            siftD(a, 0, end);
        }
    }

    private static void heapify(int[] a, int count) {

        int start = (count - 2) / 2;

        while (start >= 0) {
            siftD(a, start, count - 1);
            start--;
        }

    }

    private static void siftD(int[] a, int start, int end) {
        int root = start;

        while (root * 2 + 1 <= end) {
            int child = root * 2 + 1;

            if (child + 1 <= end && a[child] < a[child + 1]) {
                child++;
            }
            if (a[root] < a[child]) {
                swap(a, root, child);
                root = child;
            } else {
                return;
            }
        }
    }

    private static void swap(int[] a, int root, int child) {
        int valueOfRoot = a[root];
        a[root] = a[child];
        a[child] = valueOfRoot;
    }

}
