using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerCountText : MonoBehaviour
{
    private Vector3 offset;
    [SerializeField] private Transform countTarget;

    // Start is called before the first frame update
    void Start()
    {
        offset = FindOffset(countTarget);
    }

    // Update is called once per frame
    void Update()
    {
        if (countTarget!=null)
        {
            MoveCountText();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void MoveCountText()
    {
        Vector3 targetMove = countTarget.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetMove, 10f * Time.deltaTime);

    }

    private Vector3 FindOffset(Transform followplayer)
    {
        return transform.position - followplayer.position;
    }
}
