using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour
{
    public GameObject[] wastes;
    public GameObject feedback;
    public GameObject instruct�on;
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
                if (waste.GetComponent<Drag>().isins�de)
                {
                    falsecount++;
                    waste.GetComponent<Drag>().backtostart();
                }
            }
        }
        string message ="";
        if (correctcount == wastes.Length)
        {
            message=" S�per! Tamam�n� do�ru yapt�n! 6 adet at��� t�rlerine g�re ay�r�p, do�ru ��p kutular�na yerle�tirebildin ";
            
            
                    
        }
        else
        {
            
            message =" Hay aksi! " +correctcount+ " adet do�ru "+falsecount+ " adet yanl���n var. At�klar�n �zelliklerini yeniden d���nmelisin. ";
        }
        feedback.transform.GetChild(0).GetComponent<Text>().text = message;
        feedback.SetActive(true);
        kontrol.gameObject.SetActive(false);
        Next.gameObject.SetActive(false);

 
        
    }
    IEnumerator Sonraac()
    {
        yield return new WaitForSeconds(1.5f);
        instruct�on.SetActive(false);
    }
    public void Replay()
    {
        SceneManager.LoadScene("SampleScene");
    }
    



}
