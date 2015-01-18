
import java.util.Arrays;
import java.util.Random;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
/**
 *
 * @author kride
 */
public class jarjestys {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        int[] taulukko = new int[Integer.parseInt(args[0])];

        for (int i = 0; i < taulukko.length; i++) {
            taulukko[i] = new Random().nextInt();
        }
	//insSort(taulukko);
	Arrays.sort(taulukko);
    }

    public static int[] insSort(int[] taulu) {

        for (int i = 1; i < taulu.length; i++) {
            int arvo = taulu[i];
            int j = i;
            while (j > 0 && taulu[j - 1] > arvo) {
                taulu[j] = taulu[j - 1];
                j = j - 1;
            }
            taulu[j] = arvo;
        }

        return taulu;
    }

}

