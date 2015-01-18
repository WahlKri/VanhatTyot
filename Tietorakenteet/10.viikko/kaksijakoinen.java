package tira10laskari4;

import java.util.ArrayList;


public class Tira10Laskari4 {

    static int[] kayty;
    static ArrayList<Integer>[] verkko;

    public static void main(String[] args) {

        int solmuja = 9;
        verkko = new ArrayList[solmuja + 1];
        kayty = new int[solmuja + 1];

        luoVerkko(verkko, solmuja);
        haku(1,1);
    }

    static void haku(int s, int x) {
       
        if(kayty[s] == x) return;
        if(kayty[s] == 3-x){
            System.out.println("ei kaksijakoinen");
            return;
        }
        kayty[s] = x;
        for(int i=0;i<verkko[s].size();i++){
            haku(verkko[s].get(i), 3-x);
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
//        verkko[3].add(2);
//        verkko[2].add(3);

    }

}
