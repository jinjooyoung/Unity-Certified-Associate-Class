using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    public int love = 100;                      // 엔딩 변수
    public int age = 11;

    // Start is called before the first frame update
    void Start()
    {
        if (age > 7 && age < 18)                        // 7 초과 18 미만 두 조건을 만족할 경우
        {
            Debug.Log("의무 교육을 받고 있습니다.");
        }

        if (age < 13 || age > 70)                       // 13 미만이거나 70 초과 일 경우
        {
            Debug.Log("일을 할 수 없는 나이입니다.");
        }



        // Ctrl + K + C 전체 주석 | Ctrl + K + U 전체 주석 해제
        //if (love == 100)                   // love 수치가 100일 경우
        //{
        //    Debug.Log("숨겨진 엔딩");      // 100
        //}
        //else if (love >= 80)               // love 수치가 80 이상 일 경우
        //{
        //    Debug.Log("굿 엔딩");          // 80 ~ 99
        //}
        //else if (love > 50 && love < 80)
        //{
        //    Debug.Log("일반 엔딩");        // 51 ~ 79
        //}
        //if (love <= 50)                    // love 수치가 50 미만 일 경우
        //{
        //    Debug.Log("배드 엔딩");        // 0 ~ 50
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
