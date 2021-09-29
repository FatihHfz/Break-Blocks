using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloklar : MonoBehaviour
{
    public static int kirilabilirBlokSayisi = 0;
    private int VurulmaSayisi;
    bool KirilabilirMi;
    private SahneKontrolu sahneYoneticisi;
    public Sprite[] blokGorunumleri; //sprite dizisi 
    
    void Start()
    {
        KirilabilirMi = (this.tag == "kirilabilir"); 
        if(KirilabilirMi)
        {
            kirilabilirBlokSayisi++;
        }
        VurulmaSayisi = 0;
        sahneYoneticisi = GameObject.FindObjectOfType<SahneKontrolu>();
    }
     private void OnCollisionEnter2D(Collision2D collision) 
     {
        
        if(KirilabilirMi)
        {
            VurulmaKontrolu();
        }
        
     }
    public void VurulmaKontrolu()
    {
        int can;
        can = blokGorunumleri.Length+1;
        VurulmaSayisi++;    
        
        if (VurulmaSayisi >= can)
        {
            kirilabilirBlokSayisi--;
            Destroy(gameObject);
            sahneYoneticisi.BloklarinYokOlmasi();
        }
        else
        {
           // BlokGoruntusunuDegistir();
        }
    }
   
   public void BlokGoruntusunuDegistir()
   {
       this.GetComponent<SpriteRenderer>().sprite = blokGorunumleri[VurulmaSayisi-1];
   }

   public void SonrakiSahne()
   {
       sahneYoneticisi.SonrakıSahne();
   }
}
