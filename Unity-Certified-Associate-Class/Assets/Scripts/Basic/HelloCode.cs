using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    public int love = 100;                      // ���� ����
    public int age = 11;

    // Start is called before the first frame update
    void Start()
    {
        if (age > 7 && age < 18)                        // 7 �ʰ� 18 �̸� �� ������ ������ ���
        {
            Debug.Log("�ǹ� ������ �ް� �ֽ��ϴ�.");
        }

        if (age < 13 || age > 70)                       // 13 �̸��̰ų� 70 �ʰ� �� ���
        {
            Debug.Log("���� �� �� ���� �����Դϴ�.");
        }



        // Ctrl + K + C ��ü �ּ� | Ctrl + K + U ��ü �ּ� ����
        //if (love == 100)                   // love ��ġ�� 100�� ���
        //{
        //    Debug.Log("������ ����");      // 100
        //}
        //else if (love >= 80)               // love ��ġ�� 80 �̻� �� ���
        //{
        //    Debug.Log("�� ����");          // 80 ~ 99
        //}
        //else if (love > 50 && love < 80)
        //{
        //    Debug.Log("�Ϲ� ����");        // 51 ~ 79
        //}
        //if (love <= 50)                    // love ��ġ�� 50 �̸� �� ���
        //{
        //    Debug.Log("��� ����");        // 0 ~ 50
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
