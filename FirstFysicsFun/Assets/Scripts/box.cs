using UnityEngine;
using System.Collections;

public class box : MonoBehaviour {
    public Animator a;
    public int hp;
    public bool isTouched;
	void Start() {
        isTouched = false;
	}

    void OnCollisionExit2D(Collision2D col)
    {
        hp--;
        if (hp <= 0)
        {
            gameObject.SetActive(false);
            Instantiate(a, this.transform.position, Quaternion.identity);
        }
        //a.SetBool("isDead", true);
        //isTouched = true;

    }
}
