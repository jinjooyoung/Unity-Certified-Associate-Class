using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;                   // 이동에 사용할 리지드바디 컴포넌트
    public float speed = 8.0f;                          // 이동 속도 변수 선언 

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();    // 해당 오브젝트에 있는 Component 검색(Rigidbody) 해서 가져온다.
    }

    // Update is called once per frame
    void Update()
    {
        // 수평축과 수직축의 입력 값을 감지하여 저장
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // 실제 이동 속도를 입력 값과 이동 속력을 사용해서 결정
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 vector3f = Vector3.forward;                              // 앞으로 (z축 +로)
        Vector3 vector3b = Vector3.back;                                 // 뒤로 (z축 -로)
        Vector3 vector3o = Vector3.one;                                  // 1, 1, 1
        // 이외에도 up, down 등등 많은게 있음

        // Vector3 속도를 생성
        Vector3 newVelocity = new Vector3(xSpeed, 0.0f, zSpeed);

        // 리지드바디의 속도에 할당
        playerRigidbody.velocity = newVelocity;
    }

    public void Die()
    {
        // 씬에 존재하는 GameManager 타입의 오브젝트를 찾아서 가져오기
        GameManager gameManager = FindAnyObjectByType<GameManager>();

        // 가져온 GameManager 오브젝트의 EndGame() 메서드를 실행
        gameManager.EndGame();

        Destroy(gameObject);
    }
}
