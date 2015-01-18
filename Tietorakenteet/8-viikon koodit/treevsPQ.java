
import java.net.*;
import java.util.PriorityQueue;
import java.util.Random;
import java.util.TreeSet;

public class treevsPQ {

    public static void main(String[] args) throws Exception {

        int n = Integer.parseInt(args[0]);
        int valinta = Integer.parseInt(args[1]);
        TreeSet<Integer> puu = new TreeSet<>();
        PriorityQueue<Integer> keko = new PriorityQueue<>();
        Random random = new Random();
        
        if (valinta == 0) {
            System.out.println("Lisätään puuhun...");
            for (int i = 0; i < n; i++) {
                int a = random.nextInt();
                puu.add(a);
            }
            System.out.println("lisätty!");
            System.out.println("...poistetaan ja lisätään samalla uudestaan...");
            for (int i = 0; i < n; i++) {
                puu.pollFirst();
                int a = random.nextInt();
                puu.add(a);
            }
          	 System.out.println("Puun koko nyt: " + puu.size());
        }  else {
            System.out.println("Lisätään kekoon...");
            for (int i = 0; i < n; i++) {
                int a = random.nextInt();
                keko.add(a);
            }
            System.out.println("lisätty!");
            System.out.println("...poistetaan ja lisätään uudestaan...");
            for (int i = 0; i < n; i++) {
                keko.poll();
                int a = random.nextInt();
                keko.add(a);
            }
			System.out.println("Keon koko nyt: " + keko.size());
        }
    }

}

