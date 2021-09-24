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

   public void OyundanCık()
   {
       Application.Quit();
   }
}
