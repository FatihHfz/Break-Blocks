using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloklar : MonoBehaviour
{
    public int can;
    private int VurulmaSayisi;
    private SahneKontrolu sahneYoneticisi;
    
    void Start()
    {
        VurulmaSayisi = 0;
        sahneYoneticisi = GameObject.FindObjectOfType<SahneKontrolu>();
    }

   private void OnCollisionEnter2D(Collision2D collision) 
   {
        VurulmaSayisi++;    
        SonrakiSahne();
   }

   public void SonrakiSahne()
   {
       sahneYoneticisi.SonrakıSahne();
   }
}
