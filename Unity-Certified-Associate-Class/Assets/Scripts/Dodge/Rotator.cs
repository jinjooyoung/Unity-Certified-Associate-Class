using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 60.0f;

    private void Awake()
    {
        Application.targetFrameRate = 200;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, rotationSpeed * Time.deltaTime, 0.0f);            // 프레임마다 Y축 기준 60도 회전한다.
    }
}
