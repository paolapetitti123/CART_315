using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    public float rotationSpeed = 0.3f;
    public bool rotate;
    public PickerUpper player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            rotate = true;
        }
        else
        {
            rotate = false;
        }
    }

    void FixedUpdate()
    {
        if (player != null)
        {
            if (rotate && player.count >= 3)
            {
                this.GetComponent<Transform>().Rotate(0, rotationSpeed, 0);
            }
        }
        else
        {
            this.GetComponent<Transform>().Rotate(0, rotationSpeed, 0);
        }
    }
}
