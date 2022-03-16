using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth traget;
    [SerializeField] float damage = 40f;
    // Start is called before the first frame update
    void Start()
    {
        traget = FindObjectOfType < PlayerHealth > ();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AttackHitEvent()
    {
        if (traget == null) return;
        traget.ReduceHitPointsPlayer(damage);
        //Debug.Log("hit");
    }
}
