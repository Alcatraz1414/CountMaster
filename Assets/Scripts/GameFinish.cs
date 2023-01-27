using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinish : MonoBehaviour
{

    [SerializeField] private GameObject winPanel;
    [SerializeField] private GameObject losePanel;

    [SerializeField] public bool gameOver;
    [SerializeField] public bool gameFinish;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if(gameOver==true)
        {
            losePanel.SetActive(true);
            winPanel.SetActive(false);
            
            
        }

        if (gameFinish == true)
        {
            losePanel.SetActive(false);
            winPanel.SetActive(true);
        }

    }
}
