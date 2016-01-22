using UnityEngine;
using System.Collections;

public class box : MonoBehaviour {
    private Animator anim;
    private int hp, impactDamage;
	void Start() {
        wood parent = transform.parent.GetComponent<wood>();
        anim = parent.a;
        hp = parent.hp;
        impactDamage = parent.impactDamage;
    }

    void CreateInstance()
    {
        Instantiate(anim, this.transform.position, Quaternion.identity);
    }

    void OnCollisionEnter2D(Collision2D col)
	{
        if (col.relativeVelocity.sqrMagnitude < (impactDamage * impactDamage)) return;

        hp--;
		if (hp <= 0)
		{
            Invoke("CreateInstance", 3);
            Destroy(gameObject, 3);
        }
	}
}
