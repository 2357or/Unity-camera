using UnityEngine;

public class TestCameraMover : MonoBehaviour
{
    float a = 1;

    void Update() {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) a = 2;
        else if (Input.GetKey(KeyCode.LeftControl)) a = 0.5f; else a = 1;

        if (Input.GetKey(KeyCode.W)) transform.Translate(0, 0, 10 * a * Time.deltaTime);
        if (Input.GetKey(KeyCode.S)) transform.Translate(0, 0, -10 * a * Time.deltaTime);
        if (Input.GetKey(KeyCode.D)) transform.Translate(10 * a * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.A)) transform.Translate(-10 * a * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.RightArrow)) transform.Rotate(0, 10 * a * Time.deltaTime, 0);

        if (Input.GetKey(KeyCode.LeftArrow)) transform.Rotate(0, -10 * a * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.DownArrow)) transform.Rotate(10 * a * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.UpArrow)) transform.Rotate(-10 * a * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.R)) this.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}