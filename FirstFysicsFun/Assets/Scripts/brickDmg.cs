using UnityEngine;
using System.Collections;

public class brickDmg : MonoBehaviour {
    public int hp = 5;
    public int impactDamage = 1;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.relativeVelocity.sqrMagnitude < (impactDamage * impactDamage)) return;
        hp--;
        if (hp <= 0) Destroy(gameObject, 3);
    }
}
