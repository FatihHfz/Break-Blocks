using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzikoynatma : MonoBehaviour
{
    static muzikoynatma TekMuzikOynatıcısı = null; //Geçici bellekte yer ayrılır ama olusmaz
    void Awake() 
    {
        if(TekMuzikOynatıcısı != null) //Muzik oynatıcısı varsa
        {
            Destroy(gameObject); //görünmeyen müzik objesi yok edildi
        }
        else
        {
            TekMuzikOynatıcısı = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }    
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
