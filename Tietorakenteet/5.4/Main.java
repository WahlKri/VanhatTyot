import java.util.List;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.HashSet;
import java.util.LinkedList;
import java.util.Random;
import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;


public class Main {

   
    public static void main(String[] args) {

        ArrayList<Integer> numerot = new ArrayList<>();

        taytaLista(numerot, kysyNumerotAsti());
        
        for(int i=0;i<10;i++){
        Collections.shuffle(numerot);

        Puu puu = new Puu();
        puu.root = new Solmu(numerot.get(0));
        taytaPuu(puu,numerot);
        
        System.out.println("lisättävät numerot olivat: " + numerot);
        BTreePrinter.printNode(puu.root);
        
 
        }
    }

    private static void taytaLista(ArrayList<Integer> numerot, int asti) {
        if(asti <1)
            return;
        for (int i = 1; i <= asti; i++) {
            numerot.add(i);
        }

    }

    private static void taytaPuu(Puu puu, ArrayList<Integer> numerot) {
        for(int arvo:numerot)
            puu.insert(arvo);
    }

    private static int kysyNumerotAsti() {
        System.out.print("Mihin asti: ");
        return Integer.parseInt(new Scanner(System.in).nextLine());
    }

}
