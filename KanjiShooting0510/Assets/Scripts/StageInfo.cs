using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;//�d�v

public class StageInfo : MonoBehaviour
{
    List<string[]> csvDatas = new List<string[]>();// �i�[�p�̓񎟌��z��List
    void Start()
    {
        //Load the file under the "Resources" folder
        TextAsset csvFile = Resources.Load("proto") as TextAsset;
        StringReader reader = new StringReader(csvFile.text);//csv
                                                             // , �ŕ�������s���ǂݍ���
                                                             // ���X�g�ɒǉ����Ă���
        while (reader.Peek() != -1) // reader.Peek��-1�ɂȂ�܂�
        {
            string line = reader.ReadLine(); // ��s���ǂݍ���
            csvDatas.Add(line.Split('	')); // , ��؂�Ń��X�g�ɒǉ�
        }

        for (var x = 0; x < csvDatas.Count; x++)
        {
            for (var y = 0; y < csvDatas[x].Length; y++)
            {
                if (x == 0)
                {

                }

                Debug.Log(csvDatas[x][y]);
            }
        }
    }
}