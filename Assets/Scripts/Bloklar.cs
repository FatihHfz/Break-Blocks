using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloklar : MonoBehaviour
{
    public int can;
    private int VurulmaSayisi;
    
    void Start()
    {
        VurulmaSayisi = 0;
    }

   private void OnCollisionEnter2D(Collision2D collision) 
   {
        VurulmaSayisi++;    
   }
}
