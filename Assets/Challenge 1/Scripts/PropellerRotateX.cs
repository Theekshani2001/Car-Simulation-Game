using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotateX : MonoBehaviour
{

    private float rotationSpeed=1500.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.forward*Time.deltaTime*rotationSpeed);

        //transform.localEulerAngles=new Vector3(0,0,1)*Time.deltaTime*rotationSpeed;
        
    }
}
