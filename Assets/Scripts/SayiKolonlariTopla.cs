using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SayiKolonlariTopla : MonoBehaviour
{

    [SerializeField] public int kac;
    [SerializeField] private TextMesh sayi;

    // Start is called before the first frame update
    void Start()
    {
        sayi.GetComponent<TextMesh>().text="+"+kac.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       FindObjectOfType<PlayerCount>().kacPlayer+=kac;

        print(FindObjectOfType<PlayerCount>().kacPlayer);

        
     
    }

   /* private void OnTriggerExit(Collider other)
    {
        for (int i = 1; i < kac; i++)
        {
            Instantiate(player, player.position, player.rotation);
        }
        
    }
   */
}
