using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 25.0f;
    private float horizantalnput;
    private float forwardlnput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player Input'ları aldığımız yer
        horizantalnput = Input.GetAxis("Horizontal");
        forwardlnput = Input.GetAxis("Vertical");

        //İleri-geri yönde hareket
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardlnput);
        //Sağ-sol yönde dönme
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizantalnput);

    }
}