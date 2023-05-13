using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;//重要

public class StageInfo : MonoBehaviour
{
    List<string[]> csvDatas = new List<string[]>();// 格納用の二次元配列List
    void Start()
    {
        //Load the file under the "Resources" folder
        TextAsset csvFile = Resources.Load("proto") as TextAsset;
        StringReader reader = new StringReader(csvFile.text);//csv
                                                             // , で分割しつつ一行ずつ読み込み
                                                             // リストに追加していく
        while (reader.Peek() != -1) // reader.Peekが-1になるまで
        {
            string line = reader.ReadLine(); // 一行ずつ読み込み
            csvDatas.Add(line.Split('	')); // , 区切りでリストに追加
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