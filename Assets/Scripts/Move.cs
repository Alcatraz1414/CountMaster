using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] public float hiz=1f;
    [SerializeField] private GameObject death;
    

    [SerializeField] private Transform[] rayStartPoint;

    private GameFinish gameFinish;
    

    void Start()
    {
        gameFinish = FindObjectOfType<GameFinish>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(gameFinish.gameFinish == false && onGroundCheck())
        {
            float x = Input.GetAxis("Horizontal") * 0.04f;
            Vector3 hareket = new Vector3(x, 0f, hiz * Time.deltaTime);
            transform.position = hareket + transform.position;
        }

        
        
    }

    private void OnDisable()
    {
        Instantiate(death, transform.position, transform.rotation);
        gameFinish.gameOver =true;
        gameFinish.gameFinish = false;

    }

    private bool onGroundCheck()
    {
        bool hit=false;
        RaycastHit target;

        for (int i = 0; i < rayStartPoint.Length; i++)
        {
            if(Physics.Raycast(rayStartPoint[i].position, -rayStartPoint[i].transform.up, out target, 8f))
            {
                 if (target.collider.tag == "Enemies" || target.collider.tag == "Boss")
                 {
                     hit = true;
                 }
                print(target.collider.tag);
            }

                Debug.DrawRay(rayStartPoint[i].position, -rayStartPoint[i].transform.up * 8f, Color.red);
                

        }


        if (hit == true)
        {
            return false;
        }  
        else
        {
            return true;
        }

        

        

    }

}
