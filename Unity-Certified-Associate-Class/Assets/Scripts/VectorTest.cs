using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, 0, 10);
        transform.localScale = new Vector3(1, 1, 1);    // Vector3.one

        // rotation은 Vector3 타입이 아님
        // transform.rotation = new Vector3(30, 60, 90); 이라고 쓰면 오류가 발생함 

        transform.rotation = Quaternion.Euler(new Vector3(30, 60, 90));     // 오일러 각을 표현하는 Vector3 값에서 새로운 Quaternion 값을 생성

        // Quaternion 타입은 저장된 회전값을 Vector3 타입의 오일러 각으로 변환한 변수 eulerAngle을 제공
        Quaternion rotation = Quaternion.Euler(new Vector3(0, 60, 0));

        Vector3 eulerRotation = rotation.eulerAngles;       // Vector3 타입 값으로 (0,60,0)으로 출력

        Quaternion a = Quaternion.Euler(30, 0, 0);
        Quaternion b = Quaternion.Euler(0, 60, 0);

        Quaternion Qrotation = a * b;
    }
}
