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
    //    //bullet�����������Ƃ��̏���
    //    //this.enemy = coll.gameObject;
    //    //if (enemy == )
    //    //{
    //    //    GameObject.Find("Aircraft").GetComponent<LifeController>().HeartDamaged();
    //    //}
    //    //EnemyDisposal(this.enemy);
    //    BulletDisposal();
    //}

    // public float GetFallSpeed(){
    //fallspeed���擾���郁�\�b�h(��Ŏ���)
    //     this.fallspeed=Global.fallspeed;
    // }
    //private void EnemyDisposal()
    //{
    //    //bullet�����������Ƃ���enemy���̏���
    //    /*
    //    1.�e�L�X�g��made�����ɕω�������
    //    2.���b�҂�
    //    3.����
    //    */
    //    Destroy(this.enemy);
    //}

    private void BulletDisposal()
    {
        //�e�����������Ƃ���Bullet���̏���
        /*
        1.�G�t�F�N�g���o��
        2.bullet������
        */
        Destroy(gameObject);
    }

}