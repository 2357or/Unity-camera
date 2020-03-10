using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Center_Camera : MonoBehaviour
{
    void Update()
    {
        //左に回転
        if (Input.GetKey(KeyCode.A))transform.Rotate(0, 1, 0);
        //右に回転
        if (Input.GetKey(KeyCode.D))transform.Rotate(0, -1, 0);
        //上に回転
        if (Input.GetKey(KeyCode.W))transform.Translate(0, 0.1f, 0);
        //下に回転
        if (Input.GetKey(KeyCode.S))transform.Translate(0, -0.1f, 0);
    }
}
