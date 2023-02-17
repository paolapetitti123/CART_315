using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vinyl_spin : MonoBehaviour
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
        if(player.count >= 1)
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
            if (rotate && player.count >= 1 && this.GetComponent<AudioSource>().isPlaying == false)
            {
                //this.GetComponent<Transform>().Rotate(0, 0, rSpeed);
                transform.Rotate(new Vector3(0, 0, -60 * Time.deltaTime));

                this.GetComponent<AudioSource>().Play();
            }
            else
            {
                transform.Rotate(new Vector3(0, 0, -60 * Time.deltaTime));
            }
        }
    }
}
