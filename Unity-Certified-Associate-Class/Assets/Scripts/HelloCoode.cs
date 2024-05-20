using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCoode : MonoBehaviour
{
    public int amount = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)                        // i (0 ~ 9)
        {
            amount = amount + i;                            // 0 + 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9
        }

        Debug.Log(amount);      // 45

        for (int i = 1; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                Debug.Log(i + " x " + j + " = " + (i * j));             // 1 x 1 = 1 ~ 9 x 9 = 81
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
