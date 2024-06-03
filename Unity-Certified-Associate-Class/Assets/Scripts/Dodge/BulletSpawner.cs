using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefabs;                    // ������ ź���� ���� ������
    public float spawnRateMin = 0.5f;                   // ź�� �ּ� ���� �ֱ�
    public float spawnRateMax = 3.0f;                   // ź�� �ִ� ���� �ֱ�
    // ���� �����ؾ��ϴ�, �ۿ��� ������ �����ؾ��ϴ� ���� public

    private Transform target;                           // �߻��� ��� (Transform)
    // ���ӿ�����Ʈ�� �޾ƿ͵� ������ ���� ������Ʈ�� �� ������Ʈ�� ������Ʈ��, Ŭ���� �� ������ �ҷ����� ������ ��ġ, ȸ������ �������� Ʈ������ ��� ����
    private float spawnRate;                            // ���� �ֱ� (�������� ������ ����)
    private float timeAfterSpawn;                       // �ֱ� ���� �������� ���� �ð� (Ÿ�̸Ӹ� ǥ���ϴ� ����)
    // ����Ǹ� ������ ����ų� �������� �ʾƵ� �Ǵ� ���� private

    public float findTargetTime;                        // Ÿ���� ã�� �ð�

    // Start is called before the first frame update
    void Start()
    {
        // �ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0f;
        // ź�� ���� ������ spawnRateMin�� spawnRateMax ���̿� ���� ����
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        // PlayerController ������Ʈ�� ���� ���� ������Ʈ�� ã�Ƽ� ���� ������� ����
        target = FindObjectOfType<PlayerController>().transform;    // target�� (Transform), FindObjectOfType<PlayerController>()(GameObject)�̱� ������
                                                                    // .transform ���� ���� ������ ������ ����� �ش�.

        // ���� ������Ʈ�� ã�� ��� (Scene)
        // FindObjectOfType : ������Ʈ�� ã�´�.
        // FindWithTag : Tag�� ���� ������Ʈ�� ã�´�. -> GameObject.FindWithTag("Respawn");

    }

    // Update is called once per frame
    void Update()
    {
        if (findTargetTime >= 1.0f)                             // Ÿ���� ���� �ð��� 1�ʰ� �Ѿ�� ��
        {
            GameObject findTarget = GameObject.FindWithTag("Player");
            if (findTarget != null)
            {
                target = findTarget.transform;
            }
            findTargetTime = 0.0f;                              // ã�� �ð��� �ʱ�ȭ �����ش�.
        }

        if (target == null)                                     // Ÿ���� ���� ���
        {
            findTargetTime += Time.deltaTime;                   // Ÿ���� ���� ��� ���� �ð��� ����ؼ� 
            return;                                             // Update�� ����������.
        }


        // timerAfterSpawn ����
        timeAfterSpawn += Time.deltaTime;                       // �ش� ������ �ʸ� �׾Ƽ� timeAfterSpawn�� �ݿ��Ѵ�.

        // �ֱ� ���� �������κ��� ������ �ð��� ���� �ֱ⺸�� ũ��
        if (timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0f;

            // bulletPrefab�� �������� ����
            // transform.position ��ġ�� transform.rotation ȸ������ ����
            GameObject bullet = Instantiate(bulletPrefabs, transform.position, transform.rotation);

            // ������ bullet ���� ������Ʈ�� ���� ������ target�� ���ϵ��� ȸ��
            bullet.transform.LookAt(target, Vector3.up);        // up��. �� y���� �������θ� ȸ����

            // ������ ���� ������ spawnRateMin, spawnRateMax ���̿��� �������� ����
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
