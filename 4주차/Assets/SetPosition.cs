using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);  // 글로벌 스페이스 (0,0,0)
        transform.localPosition = new Vector3(0, 0, 0); // 부모의 상대적 위치(0,0,0) 으로 위치하게됨

        //transform.lossyScale 은 글로벌 기준 스케일
        //transform.localScale 은 부모기준 스케일
    }

}
