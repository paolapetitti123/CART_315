using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeCoffee : MonoBehaviour
{
    private int foodValue = 0;
    private MeshRenderer coffeeMat;
    //private string stillPouring = "y";

    // Start is called before the first frame update
    void Start()
    {
        coffeeMat = GetComponent<MeshRenderer>();
        StartCoroutine(pourTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        GetComponent<Transform>().position = new Vector3(4.43f, 1.454f, 4.244f);
        Debug.Log("cafeee");
        gameFlow.plateValue += foodValue;
        //stillPouring = "n";
    }

    IEnumerator pourTimer()
    {
        yield return new WaitForSeconds(5);
        foodValue = 50;
    }

}
