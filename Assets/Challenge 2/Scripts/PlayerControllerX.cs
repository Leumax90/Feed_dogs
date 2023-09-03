using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float horizontal;
    private float speed;


    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
        speed = 15.0f;
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.back * Time.deltaTime * horizontal * speed);

        if (transform.position.x > 17)
        {
            transform.position = new Vector3(17, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -33)
        {
            transform.position = new Vector3(-33, transform.position.y, transform.position.z);
        }
    }

}
                                   