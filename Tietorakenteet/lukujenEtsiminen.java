import java.util.ArrayDeque;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.LinkedList;
import java.util.Random;
import java.util.TreeSet;


public class lukujenEtsiminen {

  
    public static void main(String[] args) {
        
        int n = Integer.parseInt(args[0]);
        int[] taulu1 = arvoSamat(n);
        int[] taulu2 = arvoSamatKaanteisesti(n);
        TreeSet<Integer> taulu1Tree = new TreeSet<>();
        for(int i:taulu1)
            taulu1Tree.add(i);
        
	String valittu = args[1];
        
	if(valittu.equals("tapa1")){
		System.out.println("Suoritetaan TreeSetin avulla...");
        	tapa1(taulu1Tree,taulu2);
	}
	else{	
		System.out.println("Suoritetaan taulukon avulla...");
        	tapa2(taulu1,taulu2);
      	}
    }


    private static void tapa1(TreeSet<Integer> taulu1Tree, int[] taulu2) {
        int samoja = 0;
       

        
        for(int i=0;i<taulu2.length;i++){
            int luku = taulu2[i];
            if(taulu1Tree.contains(luku))
                samoja++;
        }
        
        System.out.println("Löydettiin samoja: " + samoja);
    }

     private static void tapa2(int[] taulu1, int[] taulu2) {
         int samoja = 0;
         int[] yhdiste = new int[taulu1.length+taulu2.length];
         
         for(int i=0;i<taulu1.length;i++){
             yhdiste[i] = taulu1[i];
         }
         
         for(int j=0;j<taulu2.length;j++){
             yhdiste[j+taulu1.length] = taulu2[j];
         }
         
         Arrays.sort(yhdiste);
         
         for(int i=0;i<yhdiste.length-1;i++){
             int nykyinen = yhdiste[i];
             int seuraava = yhdiste[i+1];
             if(nykyinen == seuraava)
                 samoja++;
         }
         System.out.println("Löydettiin samoja: " + samoja);
    }
    
    private static int[] arvoSamat(int n) {
        int[] palautettava = new int[n];
        for(int i=0;i<n;i++)
            palautettava[i] = i;
        
        return palautettava;
    }

    private static int[] arvoSamatKaanteisesti(int n) {
        int[] palautettava = new int[n];
        
        for(int i=n;i>0;i--){
            palautettava[n-i] = i-1;
        }
        
        return palautettava;
    }

   

}
