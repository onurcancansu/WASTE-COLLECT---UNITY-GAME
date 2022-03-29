using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    Vector3 startpos;
    public bool isinsýde = false;
    public string hedeftag = "organik";
    public bool iscorrectmatch = false;
    // Start is called before the first frame update
    void Start()
    {
        startpos = this.transform.position;
    }

    void OnMouseDrag()
    {
        Vector3 newpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(newpos.x, newpos.y, 0);

    }

    void OnMouseUp()
    {
        if (!isinsýde)
            backtostart();
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Ýçeride");
        isinsýde = true;
        if (collision.gameObject.tag==hedeftag)
        {
            iscorrectmatch = true;
        }
        
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        iscorrectmatch = false;
        //Debug.Log("Ýçerden çýktý");
        isinsýde = false;
        
    }
    public void backtostart()
    {
        this.transform.position = startpos;

    }
}
