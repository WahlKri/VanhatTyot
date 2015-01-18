package kruskalvsprim;

import java.util.Arrays;

public class Prim {

    private static int[][] matrix;
    private static int[] mista;
    private static int[] mihin;
    private static int[] paino;
    private static int N;
    private static final int INF = 999999999;

    private static boolean[] Reached;
    private static int[] predNode;

    public static void main(String[] args) {

        N = 10000; //number of nodes
        matrix = new int[N][N];
        Reached = new boolean[N];
        predNode = new int[N];

        int n = 10000;
        mista = new int[n-1];
        mihin = new int[n-1];
        paino = new int[n-1];

        for (int i = 0; i < n-1; i++) {
            mista[i] = i + 1;
            mihin[i] = i + 2;
            paino[i] = i + 1;
        }


//        mista = new int[]{1, 1, 2, 3, 2, 5, 5, 6, 7, 7, 8}; //laskareiden mallin verkko
//        mihin = new int[]{2, 3, 3, 4, 5, 6, 7, 8, 8, 9, 9};
//        paino = new int[]{20, 30, 20, 70, 50, 10, 80, 10, 20, 50, 40};
        //alustus
        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix.length; j++) {
                matrix[i][j] = INF;
            }
        }

        for (int i = 0; i < mista.length; i++) {
            matrix[mista[i] - 1][mihin[i] - 1] = paino[i];
            matrix[mihin[i] - 1][mista[i] - 1] = paino[i];
        }
        


        Reached[0] = true;

        for (int i = 1; i < N; i++) {
            Reached[i] = false;
        }

        predNode[0] = 0;

        for (int k = 1; k < N; k++) {
            int x = 0, y = 0;

            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (Reached[i] && !Reached[j] && matrix[i][j] < matrix[x][y]) {
                        x = i;
                        y = j;
                    }
                }
            }
//            System.out.println("Min cost edge: ("
//                    + +(x + 1) + ","
//                    + +(y + 1) + ")"
//                    + "cost = " + matrix[x][y]);
//            System.out.println("");

            predNode[y] = x;
            Reached[y] = true;
            //printReachSet(Reached);
        }

    }

    static void printReachSet(boolean[] Reached) {
        System.out.print("ReachSet = ");
        for (int i = 0; i < Reached.length; i++) {
            if (Reached[i]) {
                System.out.print(i + " ");
            }
        }
        System.out.println();
    }

}
