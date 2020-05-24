using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // 인스턴스화
    public Transform spawnPosition;
    public Rigidbody target;
    //public GameObject target;
    void Start()
    {
        Rigidbody instance = Instantiate(target,spawnPosition.position,spawnPosition.rotation);

        instance.AddForce(0, 1000, 0);
        Debug.Log(instance.name);


        //GameObject instance = Instantiate(target, spawnPosition.position, spawnPosition.rotation);
        //instance.GetComponent<Rigidbody>().AddForce(0, 1000, 0);
    }
}
