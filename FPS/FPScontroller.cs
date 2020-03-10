using UnityEngine;

public class FPScontroller : MonoBehaviour
{
    [SerializeField] GameObject mainCamera, player;
    [SerializeField] float speed = 2, sensitivity = 100;

    void Start() {
        mainCamera = Camera.main.gameObject;
    }
    void Update() {
        player.transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime, 0);
        mainCamera.transform.Rotate(Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime * -1, 0, 0);

        if (Input.GetKey(KeyCode.W)) player.transform.Translate(0, 0, speed* Time.deltaTime);
        if (Input.GetKey(KeyCode.S)) player.transform.Translate(0, 0, -1* speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D)) player.transform.Translate(speed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.A)) player.transform.Translate(-1* speed * Time.deltaTime, 0, 0);
    }
}