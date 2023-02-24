using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetHit : MonoBehaviour
{
    public int count;
    public GameObject[] targetPrefabs;

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
        
        if (collision.collider.gameObject.CompareTag("targetHit"))
        {
            int targetIndex = Random.Range(0,2);
            count +=1;
            GameObject.Destroy(collision.collider.gameObject);
            GameObject.Destroy(gameObject);

            Instantiate(targetPrefabs[targetIndex], new Vector3(-17.81f, 5.21f, 2.87f), Quaternion.Euler(0,90,90));
            Debug.Log(count);
        }
        else if (collision.collider.gameObject.CompareTag("floor"))
        {
            GameObject.Destroy(gameObject);
        }
    }
}
