using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class BulletController : MonoBehaviour
{
    private float fallspeed = 0.1f;
    private GameObject enemy;
    void Update()
    {
        //fallspeed=GetFallSpeed();
        transform.Translate(0, fallspeed, 0);

        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }

    //void OnTriggerEnter2D(Collider2D coll)
    //{
    //    //bulletがあたったときの処理
    //    //this.enemy = coll.gameObject;
    //    //if (enemy == )
    //    //{
    //    //    GameObject.Find("Aircraft").GetComponent<LifeController>().HeartDamaged();
    //    //}
    //    //EnemyDisposal(this.enemy);
    //    BulletDisposal();
    //}

    // public float GetFallSpeed(){
    //fallspeedを取得するメソッド(後で実装)
    //     this.fallspeed=Global.fallspeed;
    // }
    //private void EnemyDisposal()
    //{
    //    //bulletがあたったときのenemy側の処理
    //    /*
    //    1.テキストをmade漢字に変化させる
    //    2.数秒待つ
    //    3.消す
    //    */
    //    Destroy(this.enemy);
    //}

    private void BulletDisposal()
    {
        //銃があたったときのBullet側の処理
        /*
        1.エフェクトを出す
        2.bulletを消す
        */
        Destroy(gameObject);
    }

}