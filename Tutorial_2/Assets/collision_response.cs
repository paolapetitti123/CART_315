using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_response : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.collider.gameObject == player)
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 200.0f, 0));
        }
    }
}
