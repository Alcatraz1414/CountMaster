using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class GateOpen : MonoBehaviour
{

    [SerializeField] private Transform left;
    [SerializeField] private Transform right;
    

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
        left.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 90f);
        

        right.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, -90f);
        
    }


    
    

}
