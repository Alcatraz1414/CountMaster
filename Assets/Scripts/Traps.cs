using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour
{

    [SerializeField] private Transform baslangic;
    [SerializeField] private Transform bitis;
    [SerializeField] private float trapSpeed = 3f;
    private bool basta;
    private bool sonda;

    // Start is called before the first frame update
    void Start()
    {
        basta = true;
        sonda = false;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0f, 3f, 0f);


        gitGel();
        

    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }

    private void gitGel()
    {
        if (basta == true && sonda==false)
        {
            transform.position = Vector3.MoveTowards(transform.position, bitis.position, trapSpeed * Time.deltaTime);
            if (transform.position == bitis.position)
            {
                basta = false;
                sonda=true;
            }
        }

        if(basta==false && sonda == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, baslangic.position, trapSpeed * Time.deltaTime);
            if (transform.position == baslangic.position)
            {
                basta = true;
                sonda = false;
            }
        }
    }

}
