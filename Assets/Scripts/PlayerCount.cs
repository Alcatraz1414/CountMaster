using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCount : MonoBehaviour
{
   
    [SerializeField]public int kacPlayer = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("Player") != null)
        {
            // Scale(); sonra bak1
            GameObject.FindWithTag("PlayerCount").GetComponent<TextMesh>().text = kacPlayer.ToString();

            
           

        }
       

        if (kacPlayer <=0)
        {
            Destroy( GameObject.Find("Player") );
        }




    }

    

 
   
}
