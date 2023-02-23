using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonController : MonoBehaviour
{
    public float rotationSpeed = 1;
    public float blastPower = 5;

    public GameObject CannonBall;
    public Transform ShotPoint;


    
    //public GameObject Explosion;

    private void Update()
    {
        //float HorizontalRotation = Input.GetAxis("Horizontal");
        float VerticalRotation = -Input.GetAxis("Vertical");

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles +
            new Vector3(0, 0, VerticalRotation * rotationSpeed));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject CreatedCannonball = Instantiate(CannonBall, ShotPoint.position, ShotPoint.rotation);
            CreatedCannonball.GetComponent<Rigidbody>().velocity = ShotPoint.transform.up * blastPower;

            // explosion for added effect
            // Destroy(Instantiate(Explosion, ShotPoint.position, ShotPoint.rotation),2);

            // Shake added effect
             //Screenshake.ShakeAmount = 5;
        }

        
    }


}
