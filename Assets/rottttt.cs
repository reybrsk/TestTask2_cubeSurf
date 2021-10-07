using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rottttt : MonoBehaviour
{

    public Transform go;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(go.position, Vector3.up, 10*Time.deltaTime);
        // transform.right = Vector3.Normalize(transform.position - go.position);
    }
}
