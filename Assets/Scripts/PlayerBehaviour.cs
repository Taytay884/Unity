using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public GameObject camera;
    CharacterController controller;
    float speed = 5;
    float angularSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float rotationY, rotationX;
        float dx, dz;

        rotationY = Input.GetAxis("Mouse X") * angularSpeed * Time.deltaTime;
        rotationX = -1 * Input.GetAxis("Mouse Y") * angularSpeed * Time.deltaTime;
        camera.transform.Rotate(new Vector3(rotationX, 0, 0));
        transform.Rotate(new Vector3(0, rotationY, 0));

        dx = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        dz = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Vector3 motion = transform.TransformDirection(new Vector3(dx, -1, dz));
        controller.Move(motion);
    }
}
