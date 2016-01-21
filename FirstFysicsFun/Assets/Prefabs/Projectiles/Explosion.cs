using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour
{
    public Object prefab;
    // Use this for initialization
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.layer == 10)
            return;
        else
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

