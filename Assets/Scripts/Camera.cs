using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    private Vector3 offset;
    [SerializeField]private Transform target;
    internal static Camera main;



    // Start is called before the first frame update
    void Start()
    {
        offset = FindOffset(target);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void LateUpdate()
    {
        if (target != null)
        {
            MoveCamera();
        }
    }



    private void MoveCamera()
    {
        Vector3 targetMove = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetMove, 10f*Time.deltaTime);

    }


    private Vector3 FindOffset(Transform newtarget)
    {
        return  transform.position- newtarget.position;
    }

}
