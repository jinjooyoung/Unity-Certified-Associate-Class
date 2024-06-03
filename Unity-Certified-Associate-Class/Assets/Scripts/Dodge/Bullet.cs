using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8.0f;                  // ź�� �̵� �ӷ�
    private Rigidbody bulletRigidbody;          // ź�� �̵��� ����� ������ٵ� ������Ʈ

    // Start is called before the first frame update
    void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�Ƽ� bulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();

        // ������ٵ��� �ӵ� = ���� ���� * �̵� �ӷ� transform.forward�� Z�� ���� ����(����)�� �̾߱��Ѵ�.
        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3.0f);              // 3�ʵڿ� �ı��ȴ�.
    }

     // Ʈ���� �浹 �� �ڵ����� ����Ǵ� �޼���
     private void OnTriggerEnter(Collider other)         // �浹�� ���� ������Ʈ �ݶ��̴� (other)
     {
         // �浹�� ���� ���� ������Ʈ�� Player �±׸� ���� ���
         if (other.tag == "Player")
         {
             PlayerController playerController = other.GetComponent<PlayerController>();

             // �������κ��� PlayerController ������Ʈ�� �������� �� �����ߴٸ�
             if (playerController != null)
             {
                 // ���� PlayerController ������Ʈ�� �޼��带 ����
                 playerController.Die();
             }
         }
     }

    /*private void OnCollisionEnter(Collision collision)
    {
        // �浹�� ���� ���� ������Ʈ�� Player �±׸� ���� ���
        if (collision.gameObject.tag == "Player")
        {
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();

            // �������κ��� PlayerController ������Ʈ�� �������� �� �����ߴٸ�
            if (playerController != null)
            {
                // ���� PlayerController ������Ʈ�� �޼��带 ����
                playerController.Die();
            }
        }
    }*/
}
