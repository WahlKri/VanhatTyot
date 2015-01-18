package tira11.pkg3;

import java.util.Arrays;

public class Tira113 {

    private static final long INF = 999L;

    private static void floydwarshall(long[][] v) {
        for (int k = 0; k < v.length; k++) {
            for (int i = 0; i < v.length; i++) {
                for (int j = 0; j < v.length; j++) {
                    v[i][j] = Math.min(v[i][j], v[i][k] + v[k][j]);
                }
            }
        }
    }

    public static void main(String[] args) {

        int N = 650;
        long[][] v = new long[N + 1][N + 1];
        alusta(v);
        int[] mista = new int[N];
        int[] minne = new int[N];
        alustaMistaMinne(mista, minne, v);
        floydwarshall(v);
//        for (long[] rivi : v) {
//           System.out.println(Arrays.toString(rivi));
//       }
        System.out.println("Lyhin matka 1 --> " + (N/2+1) + " = " + v[1][(N/2+1)]);
    }

    private static void alusta(long[][] v) {

        for (int i = 0; i < v.length; i++) {
            for (int j = 0; j < v[0].length; j++) {
                if (i == j && i != 0) {
                    v[i][j] = 0;
                    continue;
                }
                v[i][j] = INF; //INF
            }
        }

    }

    private static void alustaMistaMinne(int[] mista, int[] minne, long[][] v) {
        for (int i = 0; i < mista.length; i++) {
            mista[i] = i + 1;
        }

        for (int i = 0; i < mista.length; i++) {
            minne[i] = i + 2;
        }
        minne[minne.length - 1] = 1;

        for (int i = 0; i < mista.length; i++) {
            int vasen = mista[i];
            int yla = minne[i];

            v[vasen][yla] = 1;
            v[yla][vasen] = 1;
        }
    }

}
