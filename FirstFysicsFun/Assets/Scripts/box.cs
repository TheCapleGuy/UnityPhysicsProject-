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

    void CreateInstance()
    {
        Instantiate(anim, this.transform.position, Quaternion.identity);
    }

    void OnCollisionEnter2D(Collision2D col)
	{
		if (col.relativeVelocity.sqrMagnitude < 1) {
			return;
		}

		hp--;
		if (hp <= 0)
		{
            Invoke("CreateInstance", 3);
            Destroy(gameObject, 3);
        }
	}
}
