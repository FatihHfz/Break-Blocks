using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunBarıKontrolu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 oyunBariKonumu = new Vector3(0f,this.transform.position.y,0f); //bir vektör oluşturarak y ekseni sabitlendi

        float mouseKonumHerBlok = (Input.mousePosition.x / Screen.width)*16; // her blok için mouse pozisyonu,ekran genişline böldük
        oyunBariKonumu.x = Mathf.Clamp(mouseKonumHerBlok,-7f,7f);
        this.transform.position = oyunBariKonumu;
    }
}
