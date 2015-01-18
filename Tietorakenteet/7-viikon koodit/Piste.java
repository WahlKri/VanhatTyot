
package kertausta;

import java.util.Random;


public class Piste {
    private int x;
    private int y;

    public Piste(int x,int y){
        this.x = x;
        this.y = y;
    }

    @Override
    public int hashCode() {
        
        int m = 1000000;
        int p = 1000003;
        int a = 1+ new Random().nextInt(p-1);
        int b = new Random().nextInt(p-1);
        int hash = ((a*(x+y)+b) % p) % m;
        return hash;
    }

    
    
    

    
    
    
    
    
    
    
    
}
