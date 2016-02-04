using UnityEngine;
using System.Collections;

public class targetDmg: MonoBehaviour {
	public int hp;
	public float impactDamage;
	public Animator anim;
	public Sprite deathSprite;
	public SpriteRenderer sr;
    static bool levelDone;

    //private int curHp;
    private float dmgSqr;
	// Use this for initialization
	void Start () {
		//curHp = hp;
		dmgSqr = impactDamage * impactDamage;
        levelDone = false;
	}
	
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.relativeVelocity.sqrMagnitude < dmgSqr) {
			return;
		}
		
		hp--;
		if (hp <= 0) {
			//gameObject.SetActive(false);
			sr.sprite = deathSprite;
			Instantiate(anim, this.transform.position, Quaternion.identity);
            //Destroy(anim);
		}
	}
}
