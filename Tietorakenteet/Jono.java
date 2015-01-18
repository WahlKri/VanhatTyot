/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pinojono;

import java.util.ArrayDeque;

/**
 *
 * @author kride
 */
public class Jono {

    private ArrayDeque<Integer> vasen, oikea;

    public Jono() {
        this.vasen = new ArrayDeque<>();
        this.oikea = new ArrayDeque<>();
    }

    public void lisaaJonoon(int lisattava) {
        vasen.push(lisattava);
    }

    public int poistaEnsimmainen() {

        if(vasen.isEmpty())
            return 0;
        
        while (!vasen.isEmpty()) {

            int poistettu = vasen.pop();
            oikea.push(poistettu);

        }

        int viimeinenOikealta = oikea.pop();
        
        while(!oikea.isEmpty()){
            
            int poistettu = oikea.pop();
            vasen.push(poistettu);
        }
        
        
        return viimeinenOikealta;
    }

    @Override
    public String toString() {
        return "vasen: " + vasen + "\noikea: " + oikea;
    }

}
