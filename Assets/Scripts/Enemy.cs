using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] private int whitchGroup;
    [SerializeField] public int damageEnemy = 1;
    private Transform target;
    [SerializeField] private float stopDistance = 0.5f;
    [SerializeField] private GameObject death;

    // Start is called before the first frame update
    void Start()
    {
        
            target = GameObject.FindWithTag("Player").GetComponent<Transform>();

        
        
    }

    // Update is called once per frame
    void Update()
    {
      if (target != null)
        {
            transform.LookAt(target);
            float distance = Vector3.Distance(transform.position, target.position);
            //print(distance);
            if (distance < 15f)
            {
                transform.position += transform.forward * 7f * Time.deltaTime;
            }
        }

        
     // Count.text = kacEnemy.ToString();

        
        

    }

    public void OnCollisionEnter(Collision collision)
    {

        switch (whitchGroup)
        {
            case 1:
                FindObjectOfType<PlayerCount>().kacPlayer = FindObjectOfType<PlayerCount>().kacPlayer - damageEnemy;

                GameObject.Find("Groupenemycount").GetComponent<TextMesh>().text = (int.Parse(GameObject.Find("Groupenemycount").GetComponent<TextMesh>().text) - 1).ToString();

                if (FindObjectOfType<PlayerCount>().kacPlayer >= damageEnemy)
                {
                    Destroy(gameObject);
                }
                if (GameObject.Find("Groupenemycount").GetComponent<TextMesh>().text == "0")
                {
                    Destroy(GameObject.Find("Groupenemy1"));
                }
                break;

            case 2:
                FindObjectOfType<PlayerCount>().kacPlayer = FindObjectOfType<PlayerCount>().kacPlayer - damageEnemy;

                GameObject.Find("Groupenemycount2").GetComponent<TextMesh>().text = (int.Parse(GameObject.Find("Groupenemycount2").GetComponent<TextMesh>().text) - 1).ToString();

                if (FindObjectOfType<PlayerCount>().kacPlayer >= damageEnemy)
                {
                    Destroy(gameObject);
                }
                if (GameObject.Find("Groupenemycount2").GetComponent<TextMesh>().text == "0")
                {
                    Destroy(GameObject.Find("Groupenemy2"));
                }
                break;

            case 3:
                FindObjectOfType<PlayerCount>().kacPlayer = FindObjectOfType<PlayerCount>().kacPlayer - damageEnemy;

                GameObject.Find("Groupenemycount3").GetComponent<TextMesh>().text = (int.Parse(GameObject.Find("Groupenemycount3").GetComponent<TextMesh>().text) - 1).ToString();

                if (FindObjectOfType<PlayerCount>().kacPlayer >= damageEnemy)
                {
                    Destroy(gameObject);
                }
                if (GameObject.Find("Groupenemycount3").GetComponent<TextMesh>().text == "0")
                {
                    Destroy(GameObject.Find("Groupenemy3"));
                }
                break;
        }
       
    }

    private void OnDisable()
    {
        Instantiate(death, transform.position, transform.rotation);
    }

}
