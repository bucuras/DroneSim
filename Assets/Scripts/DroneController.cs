using UnityEngine;

public class DroneController : MonoBehaviour
{
    public float speed = 5f;
    public float rotateSpeed = 100f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 move = transform.forward * v + transform.right * h;
        transform.position += move * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.Q)) transform.position += Vector3.up * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.E)) transform.position -= Vector3.up * speed * Time.deltaTime;

        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up, mouseX * rotateSpeed * Time.deltaTime);
    }
}
