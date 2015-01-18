package kruskalvsprim;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;

public class Kruskal {

    static int[] k, s;

    static boolean sama(int a, int b) {
        while (k[a] != a) {
            a = k[a];
        }
        while (k[b] != b) {
            b = k[b];
        }
        return a == b;
    }

    static void liita(int a, int b) {
        while (k[a] != a) {
            a = k[a];
        }
        while (k[b] != b) {
            b = k[b];
        }
        if (s[a] > s[b]) {
            k[b] = a;
            s[a] += s[b];
        } else {
            k[a] = b;
            s[b] += s[a];
        }
    }

    public static void main(String[] args) {

        int[] mista;
        int[] mihin;
        int[] paino;

        int n = 100;
        mista = new int[n];
        mihin = new int[n];
        paino = new int[n];
        
        for (int i = 0; i < n-1; i++) {
            mista[i] = i + 1;
            mihin[i] = i + 2;
            paino[i] = i + 1;
        }

        System.out.println(Arrays.toString(mista));
        System.out.println(Arrays.toString(mihin));
        
//        mista = new int[]{1, 1, 2, 3, 2, 5, 5, 6, 7, 7, 8}; //laskareiden mallin verkko
//        mihin = new int[]{2, 3, 3, 4, 5, 6, 7, 8, 8, 9, 9};
//        paino = new int[]{20, 30, 20, 70, 50, 10, 80, 10, 20, 50, 40};
        int N = mista.length;

        ArrayList<Solmu> verkko = new ArrayList<>();
        k = new int[N + 1];
        s = new int[N + 1]; // k = union-find-rakenteen viittaukset 
        // s = komponenttien koot

        // alustus
        for (int i = 1; i <= N; i++) {
            k[i] = i;
            s[i] = 1;
        }

        // verkon luominen
        for (int i = 0; i < mista.length; i++) {
            Solmu uusi = new Solmu(mista[i], mihin[i], paino[i]);
            verkko.add(uusi);
        }
        Collections.sort(verkko);
        //System.out.println(verkko);

        for (int i = 0; i < verkko.size(); i++) {
            Solmu s = verkko.get(i);
            int a = s.mista;
            int b = s.mihin;
            if (sama(a, b)) {
                continue;
            }
            liita(a, b);
            System.out.println("valitaan " + a + " - " + b);
        }

    }

}
