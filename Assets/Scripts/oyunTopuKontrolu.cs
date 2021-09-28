using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunTopuKontrolu : MonoBehaviour
{
    public oyunBarıKontrolu oyunBari;
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
    }
}
