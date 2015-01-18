package kertausta;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashSet;
import java.util.TreeSet;

public class Kertausta {

    public static void main(String[] args) {
//        char c[] = Character.toChars(220);
//        System.out.println("char[]: " + Arrays.toString(c));
//        //System.out.println(h(""));
//        //System.out.println(h("|"));
//       // System.out.println(h("bb"));
//       // System.out.println(h("⽸"));
//        System.out.println(h("abba"));
//        System.out.println(h("abaÜ"));
      //  lask7_13();
        lask7_14();
    }

    public static int h(String s) {
        int x = 0;
        for (int i = 0; i < s.length(); i++) {
            x = x * 123 + s.charAt(i);
        }
        return x;
    }

    public static void lask7_13() {

        int n = 10000000;
        int[] array = new int[n];

        for (int i = n; i > 0; i--) {
            array[i - 1] = n - i;
        }

        //System.out.println(Arrays.toString(array));

        

        HashSetilla(array);

    }

    private static void HashSetilla(int[] a) {
        //HashSet<Integer> ts = new HashSet<Integer>();
        TreeSet<Integer> ts = new TreeSet<Integer>();
        
        for(int i:a){
            ts.add(i);
        }
        
        boolean loydetty = false;
        
        
        
        for(int i:a){
            loydetty = ts.contains(i);
        }
        
        for(int i:a){
            ts.remove(i);
        }
        
        System.out.println(ts.isEmpty());
    }

    private static void lask7_14() {

        HashSet<Piste> pisteet = new HashSet<>();
        
        int n = 1000000;
        
        for(int i=0;i<n;i++){
            Piste p = new Piste(i, i);
            pisteet.add(p);
        }
        
        System.out.println("koko oli: "+pisteet.size());
    
    }

}
