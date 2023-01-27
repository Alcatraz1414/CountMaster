using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{

    private GameFinish gameFinish;

    // Start is called before the first frame update
    void Start()
    {
        gameFinish = FindObjectOfType<GameFinish>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
       // print("deðdi");
        gameFinish.gameFinish = true;
        gameFinish.gameOver = false;
    }
}
