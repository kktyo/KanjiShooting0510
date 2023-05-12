using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;


public class AircraftController : MonoBehaviour
{
    private Vector2 prevPos,screenPos;
    public GameObject bulletPrefab;
    public void Update()
    {
        screenPos = Input.mousePosition;
        prevPos = Camera.main.ScreenToWorldPoint(screenPos);
        prevPos.y = -4;
        //Debug.Log(screenPos.y);
        if (Input.GetMouseButton(0)) OnClick();//クリックしたとき、場所を移動
        if (Input.GetMouseButtonUp(0)) onReleased();//離したとき、銃を発射
  
    }


    public void OnClick()
    {
    //クリックしているとき、ロケットを移動させる
        transform.position = prevPos;
        //Debug.Log("Laoded");
    }
    public void onReleased()
    {
        //離した瞬間に弾を発射する
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);   
    }

}