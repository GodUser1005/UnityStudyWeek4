using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRotation : MonoBehaviour
{

    // 쿼터니언 (x,y,z,w)
    // Start is called before the first frame update
    void Start()
    {
        // 회전은 나를 기준으로 회전
        transform.Rotate(new Vector3(30, 0, 0));

        // 1번째 방법 : 쿼터니언 합 = 쿼터니언 * 쿼터니언
        // 2번째 방법 : 벡터(쿼터니언 합) = 벡터(쿼터니언1) + 벡터(쿼터니언2)
        //            : => 쿼터니언 합


        //Quaternion targetRotation = Quaternion.Euler(new Vector3(45, 0, 0));

        //transform.rotation = targetRotation;

        //transform.Rotate(new Vector3(30, 0, 0));


        //Quaternion aRotation = Quaternion.Euler(new Vector3(30, 0, 0));

        //Quaternion bRotation = Quaternion.Euler(new Vector3(60, 0, 0));

        //// A       |        B
        //// 0      0.5       1
        //// Lerp는 퍼센티지 만큼은 중간값을 가져옴
        //Quaternion targetRotation = Quaternion.Lerp(aRotation, bRotation,0.5f);

    }

}
