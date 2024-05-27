using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;                   // �̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8.0f;                          // �̵� �ӵ� ���� ���� 

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();    // �ش� ������Ʈ�� �ִ� Component �˻�(Rigidbody) �ؼ� �����´�.
    }

    // Update is called once per frame
    void Update()
    {
        // ������� �������� �Է� ���� �����Ͽ� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // ���� �̵� �ӵ��� �Է� ���� �̵� �ӷ��� ����ؼ� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 vector3f = Vector3.forward;                              // ������ (z�� +��)
        Vector3 vector3b = Vector3.back;                                 // �ڷ� (z�� -��)
        Vector3 vector3o = Vector3.one;                                  // 1, 1, 1
        // �̿ܿ��� up, down ��� ������ ����

        // Vector3 �ӵ��� ����
        Vector3 newVelocity = new Vector3(xSpeed, 0.0f, zSpeed);

        // ������ٵ��� �ӵ��� �Ҵ�
        playerRigidbody.velocity = newVelocity;
    }
}
