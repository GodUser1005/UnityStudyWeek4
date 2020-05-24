using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // 리스트 배열과 달리 그때그때 방이 만들어 짐

    public List<int> scores = new List<int>();

    //[45][60][75]

    private void Start()
    {
        // 리스트의 트림 특징
        while (scores.Count > 0)
        {
            scores.RemoveAt(0);
        }

    }

    //void Update()
    //{
    //    if (Input.GetMouseButton(0))
    //    {
    //        int randomNumber = Random.Range(0, 100);
    //        scores.Add(randomNumber);
    //    }

    //    if (Input.GetMouseButton(1))
    //    {
    //        scores.RemoveAt(3);
    //    }
    //}
}
