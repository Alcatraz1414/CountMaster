using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalTraps : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(3f, 0f, 0f);
    }

    private void OnCollisionEnter(Collision player)
    {
        Destroy(GameObject.FindWithTag("Player"));
    }

}
