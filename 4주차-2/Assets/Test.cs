using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("TEST Dog의 총 갯수 : " + Dog.count);
        Dog.ShowAnimalType();
    }

}
