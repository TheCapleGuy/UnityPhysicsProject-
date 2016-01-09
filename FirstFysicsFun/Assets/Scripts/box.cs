using UnityEngine;
using System.Collections;

public class box : MonoBehaviour {
    private Animator anim;
    private int hp;
	void Start() {
        wood parent = transform.parent.GetComponent<wood>();
        anim = parent.a;
        hp = parent.hp;
    }

    void OnCollisionExit2D(Collision2D col)
    {
        hp--;
        if (hp <= 0)
        {
            gameObject.SetActive(false);
            Instantiate(anim, this.transform.position, Quaternion.identity);
        }
        //a.SetBool("isDead", true);
        //isTouched = true;

    }
}
