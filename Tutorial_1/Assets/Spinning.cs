using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning : MonoBehaviour
{
    public float rotationSpeed = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void FixedUpdate()
    {
        this.GetComponent<Transform>().Rotate(0, rotationSpeed, 0);
    }
}
