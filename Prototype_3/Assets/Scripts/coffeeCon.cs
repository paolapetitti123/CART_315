using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coffeeCon : MonoBehaviour
{
    public GameObject cloneObj;
    public Transform cloneObj2;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnMouseDown()
    {
        if(gameObject.name == "EspressoCup_Empty")
        {
            Debug.Log("cup has been clicked");
            GameObject clone = (GameObject)Instantiate(cloneObj, new Vector3(4.85f, 1.595f, 3.6362f), cloneObj.gameObject.transform.rotation);          
            audioSource.Play();
            StartCoroutine(pourTimer());
            Destroy(clone, 13.0f);
        }
    }

    IEnumerator pourTimer()
    {
        yield return new WaitForSeconds(13);
        
        Instantiate(cloneObj2, new Vector3(4.85f, 1.595f, 3.6362f), cloneObj2.rotation);
    }
}
