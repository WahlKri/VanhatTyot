package tira10laskari4;

import java.util.ArrayList;


public class Tira10Laskari4 {

    static boolean[] kayty;
    static ArrayList<Integer>[] verkko;

    public static void main(String[] args) {

        int solmuja = 9;
        verkko = new ArrayList[solmuja + 1];
        kayty = new boolean[solmuja + 1];

        luoVerkko(verkko, solmuja);
        haku(1,-2);
    }

    static void haku(int s, int q) {
        if (kayty[s]) {
            System.out.println("sykli löytyi!");
            return;
        }
        kayty[s] = true;
        for(int i=0;i<verkko[s].size();i++){
            if(verkko[s].get(i) == q) continue;
            haku(verkko[s].get(i),s);
        }
  
    }

    private static void luoVerkko(ArrayList<Integer>[] verkko, int solmuja) {

        for (int i = 1; i <= solmuja; i++) {
            verkko[i] = new ArrayList<>();
        }

        verkko[1].add(2);
        verkko[1].add(3);
        verkko[2].add(1);
        verkko[3].add(1);
        //verkko[3].add(2);
        //verkko[2].add(3);

    }

}
