using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playhead_rotate : MonoBehaviour
{
    public float rSpeed = 0.3f;
    public bool rotate;
    public pickup player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(this.GetComponent<Transform>().localRotation.eulerAngles.z != -60f)
        {
            rotate = true;
          
        }
        else
        {
            rotate = false;
        }
    }

    private void FixedUpdate()
    {
        if (player != null )
        {
            if (rotate && player.count >= 1)
            {
                //this.GetComponent<Transform>().Rotate(0, 0, rSpeed);
               
                transform.Rotate(new Vector3(0, 0, 60 * Time.deltaTime));

            }
        }
    }
}
