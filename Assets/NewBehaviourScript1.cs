using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    
        public Transform bigCube;
    public Transform smallCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        smallCube.transform.position = Vector3.Normalize(bigCube.position);
        Debug.Log("BigCubeMagn=" + bigCube.position.magnitude);
    }
}
