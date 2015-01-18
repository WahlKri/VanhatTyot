
import java.net.*;
import java.util.PriorityQueue;
import java.util.Random;
import java.util.TreeSet;
import java.util.Arrays;

public class treevsPQ2 {

    public static void main(String[] args) throws Exception {

        int n = Integer.parseInt(args[0]);
        int valinta = Integer.parseInt(args[1]);
        TreeSet<Integer> puu = new TreeSet<>();
        PriorityQueue<Integer> keko = new PriorityQueue<>();
		int[] taulu = new int[n];
        Random random = new Random();
        
        if (valinta == 0) {
            System.out.println("Lisätään puuhun...");
            for (int i = 0; i < n; i++) {
                int a = random.nextInt();
                puu.add(a);
            }
            System.out.println("lisätty!");
            System.out.println("...poistetaan...");
            for (int i = 0; i < n; i++) {
                puu.pollFirst();
            }
          	 System.out.println("Puun koko nyt: " + puu.size());
        }  else if (valinta == 1){
            System.out.println("Lisätään kekoon...");
            for (int i = 0; i < n; i++) {
                int a = random.nextInt();
                keko.add(a);
            }
            System.out.println("lisätty!");
            System.out.println("...poistetaan...");
            for (int i = 0; i < n; i++) {
                keko.poll();
            }
			System.out.println("Keon koko nyt: " + keko.size());
        }
		else{
			System.out.println("Lisätään taulukkoon...");
			for (int i = 0; i < n; i++) {
                taulu[i] = random.nextInt();
            }
			System.out.println("Järjestetään taulukko...");
			Arrays.sort(taulu);
			System.out.println("Käydään taulukko läpi...");
			for (int i = 0; i < taulu.length; i++) {
                
            }
		}
    }

}

