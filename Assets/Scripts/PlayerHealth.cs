using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ReduceHitPointsPlayer(float amount)
    {
        hitPoints -= amount;
        if (hitPoints <= 0)
        {
            PlayerDie();
        }
    }

    private void PlayerDie()
    {
        //Destroy(gameObject);
        GetComponent<DeathHandeler>().HandelDeath();
        //Debug.Log("you dead");
    }
}
