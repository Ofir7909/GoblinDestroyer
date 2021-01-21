using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int speed;
    //public int mouseSensetivity;
    //public int distance;
    // Start is called before the first frame update
   // private Transform me;
    void Start()
    {
      //  me=new Transform.ge
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * Time.deltaTime * speed);
        //transform.position += Camera.main.transform.forward * distance * Time.deltaTime;
        // transform.rotation = transform.rotation+Camera.main.transform.rotation;
        //transform.Rotate(Input.GetAxis("Mouse X") * Vector3.up * Time.deltaTime*100);
    }
}
