using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    public GameObject[] hearts = new GameObject[3];
    private bool[] heart_status = { true, true, true };//Array for debug
    private int heart_num;

    // Start is called before the first frame update
    void Start()
    {
        heart_num = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void HeartDamaged()
    {
        hearts[heart_num].SetActive(false);
        Debug.Log("Heart" + heart_num + ": set false");
        heart_status[heart_num] = false;
        heart_num++;
        if(hearts.Length < heart_num + 1)
        {
            Debug.Log("Game Over");
        }
    }
}
