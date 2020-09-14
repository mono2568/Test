using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    public float speed = 1f;
    public GameObject mainCamera;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0, speed * Time.deltaTime, 0);
            mainCamera.transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0, -speed * Time.deltaTime, 0);
            mainCamera.transform.Translate(0, -speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-speed * Time.deltaTime, 0, 0);
            mainCamera.transform.Translate(-speed * Time.deltaTime, 0, 0);
            this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0);
            this.transform.localScale = new Vector3(0.1f, 0.1f, 1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(speed * Time.deltaTime, 0, 0);
            mainCamera.transform.Translate(speed * Time.deltaTime, 0, 0);
            this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0);
            this.transform.localScale = new Vector3(-0.1f,0.1f,1);
        }
    }
}
