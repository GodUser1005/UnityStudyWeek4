using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    // static 모든 객체가 공유 하는 단 하나의 변수 또는 함수

    public string nickName;

    public float weight;

    public static int count = 0;

    void Awake()
    {
        count += 1;
    }

    void Start()
    {
        Bark();
    }
    public void Bark()
    {
        Debug.Log("모든 개들의 수: " + count);
        Debug.Log(nickName + " Bark!");
    }

    public static void ShowAnimalType()
    {
        Debug.Log("이것은 개입니다.");
    }


}
