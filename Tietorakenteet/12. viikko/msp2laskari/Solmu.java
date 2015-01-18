/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package msp2laskari;

/**
 *
 * @author wakr
 */
public class Solmu implements Comparable<Solmu> {

    public int mista, mihin, paino;

    public Solmu(int mista, int mihin, int paino) {
        this.mista = mista;
        this.mihin = mihin;
        this.paino = paino;
    }

    @Override
    public String toString() {
        return mista + "-" + mihin + " paino: " + paino;
    }

    @Override
    public int compareTo(Solmu o) {
        if (this.paino < o.paino) {
            return -1;
        } else if (this.paino > o.paino) {
            return 1;
        } else {
            return 0;
        }
    }

}
