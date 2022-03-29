using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour
{
    public GameObject[] wastes;
    public GameObject feedback;
    public GameObject instructýon;
    public Button Next;
    public Button kontrol;
    public GameObject gameover;
    int correctcount = 0;
    int falsecount = 0;

    void Start()
    {
        StartCoroutine(Sonraac());
        feedback.SetActive(false);
                   
    }
    public void controlet()
    {
        //Debug.Log("okey");
        //Debug.Log("mathcing : " + wastes[0].GetComponent<Drag>().iscorrectmatch);
        
        foreach(GameObject waste in wastes)
        {
            //Debug.Log("matching foreach :" + waste.GetComponent<Drag>().iscorrectmatch);
            if (waste.GetComponent<Drag>().iscorrectmatch)
            {
                correctcount++;
            }
            else
            {
                if (waste.GetComponent<Drag>().isinsýde)
                {
                    falsecount++;
                    waste.GetComponent<Drag>().backtostart();
                }
            }
        }
        string message ="";
        if (correctcount == wastes.Length)
        {
            message=" Süper! Tamamýný doðru yaptýn! 6 adet atýðý türlerine göre ayýrýp, doðru çöp kutularýna yerleþtirebildin ";
            
            
                    
        }
        else
        {
            
            message =" Hay aksi! " +correctcount+ " adet doðru "+falsecount+ " adet yanlýþýn var. Atýklarýn özelliklerini yeniden düþünmelisin. ";
        }
        feedback.transform.GetChild(0).GetComponent<Text>().text = message;
        feedback.SetActive(true);
        kontrol.gameObject.SetActive(false);
        Next.gameObject.SetActive(false);

 
        
    }
    IEnumerator Sonraac()
    {
        yield return new WaitForSeconds(1.5f);
        instructýon.SetActive(false);
    }
    public void Replay()
    {
        SceneManager.LoadScene("SampleScene");
    }
    



}
