using UnityEngine;
using System.Collections;

//public class wait : MonoBehaviour
//{

//}
public class smoke : MonoBehaviour
{
    public Animator a;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //gameObject.transform.position = new Vector3(0, 0, 0);
            
            a.SetBool("isDead", true);
        }
    }

    
}
