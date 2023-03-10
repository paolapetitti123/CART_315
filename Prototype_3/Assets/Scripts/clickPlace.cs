using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickPlace : MonoBehaviour
{
    public Transform cloneObj;
    public int foodValue;

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
        
        if (gameObject.name == "CoffeePlate")
        {
            Instantiate(cloneObj, new Vector3(0, .10f, 0), cloneObj.rotation);
        }

        //gameFlow.plateValue += foodValue;
        Debug.Log(gameFlow.plateValue + " " + gameFlow.orderValue);
    }
}
