using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    [SerializeField] public int damageEnemy = 150;
    private Transform target;
    [SerializeField] private float stopDistance = 0.5f;
    [SerializeField] private TextMesh Count;
    [SerializeField] private GameObject death;

    

    // Start is called before the first frame update
    void Start()
    {

        target = GameObject.FindWithTag("Player").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {


       /* if (target != null )
        {
            //transform.LookAt(target);
            float distance = Vector3.Distance(transform.position, target.position);
            if (distance < 15f)
            {
                transform.position += transform.forward * 7f * Time.deltaTime;
            }
        }
       */

        Count.text = damageEnemy.ToString();




    }

    public void OnCollisionEnter(Collision collision)
    {
        

        if (FindObjectOfType<PlayerCount>().kacPlayer >= damageEnemy)
        {
            Destroy(gameObject);
            FindObjectOfType<PlayerCount>().kacPlayer = FindObjectOfType<PlayerCount>().kacPlayer - damageEnemy;
        }
        else
        {
            Destroy(GameObject.Find("Player"));
            damageEnemy = damageEnemy - FindObjectOfType<PlayerCount>().kacPlayer;
        }
        

    }

    private void OnDisable()
    {
        Instantiate(death, transform.position, transform.rotation);
    }
}
