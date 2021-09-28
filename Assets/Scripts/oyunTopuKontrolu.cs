using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunTopuKontrolu : MonoBehaviour
{
    public oyunBarıKontrolu oyunBari; //oyunBarıKontrolu scriptine sahip bir nesne cagrıldı
    private bool oyunBasladiMi;
    private Vector3 TopIleBarArasindakiMesafe;
    void Start()
    {
        TopIleBarArasindakiMesafe = this.transform.position - oyunBari.transform.position;    
    }

    
    void Update()
    {
        if(!oyunBasladiMi)
        {
            this.transform.position = oyunBari.transform.position + TopIleBarArasindakiMesafe;
        }
        if(Input.GetMouseButtonDown(0))
        {
            oyunBasladiMi = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector3(3f,16f,0f);
            //oyuntop rigitboy çağırıldı ve istedimiz vectöre atadı
        }
    }
}
