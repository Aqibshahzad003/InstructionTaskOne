using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instrctions1Script : MonoBehaviour
{
    public GameObject sphereobj;
    private Vector3 Scale = new Vector3(1, 1, 1);
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        //Expanding the scale of the sphere
        if (Input.GetKey(KeyCode.Space) && UIScript.IsGameStarted==true)
        {
            sphereobj.gameObject.transform.localScale += Scale * Time.deltaTime;
            Debug.Log("Space is being pressed");
        }

        
        //shrinking the sphere to its original size
        else if (sphereobj.transform.localScale.magnitude >= 2f) 
        {

            sphereobj.gameObject.transform.localScale -= Scale * Time.deltaTime;

                Debug.Log("Space is released");
            
        }
    }
}
