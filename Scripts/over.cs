using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class over : MonoBehaviour
{
    [SerializeField] GameObject feedbackmenu;
    [SerializeField] GameObject gameendmenu;

    
    public void tamam()
    {

        feedbackmenu.SetActive(false);    
        gameendmenu.SetActive(true);

  
    }
    
}
