using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneKontrolu : MonoBehaviour
{
   public void SonrakıSahne()
   {
       int mevcutsahIndex = SceneManager.GetActiveScene().buildIndex;
       SceneManager.LoadScene(mevcutsahIndex + 1);
   }
    public void SahneyeYonlen(string sahneIsmi)
    {
        SceneManager.LoadScene(sahneIsmi);
    }
   public void OyunSahnesineYonlen()
   {
       SceneManager.LoadScene(1);
   }

   public void OyundanCık()
   {
       Application.Quit();
   }

   public void MenuSahnesineYonlen()
   {
       SceneManager.LoadScene(0);
   }
}
