using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyununBasarisizSonlanmasi : MonoBehaviour
{
    public SahneKontrolu yonetici;
    private void OnTriggerEnter2D(Collider2D other) //triger olduğunda Kaybetme sahnesine git
    {
        yonetici.SahneyeYonlen("Kaybetme");
    }
}
