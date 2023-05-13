using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;


public class Drg_Drp : MonoBehaviour
{
    private Vector2 prevPos,screenPos;
    private bool trigger = false;
    public GameObject bulletPrefab;
    public void Update()
    {
        screenPos = Input.mousePosition;
        prevPos = Camera.main.ScreenToWorldPoint(screenPos);
        //prevPos.x = prevPos.x / 50;
        prevPos.y = 0;
        if (Input.GetMouseButton(0)) OnClick();
        if (Input.GetMouseButtonUp(0) && trigger == true)
        {
            onReleased();
            Debug.Log(trigger);
            trigger = false;
            Debug.Log(trigger);
        }
        
        //transform.position = prevPos;
        //Debug.Log(prevPos.x+"x??");
    }
    public void OnClick()
    {
        transform.position = prevPos;
        Invoke("bulletLoading", 3);
        Debug.Log("Laoded");
    }
    public void onReleased()
    {
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);   
    }
    public void bulletLoading()
    {
        trigger = true;
    }

}