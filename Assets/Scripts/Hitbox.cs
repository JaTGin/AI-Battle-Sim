using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The hitbox the soldier uses to deal damage
/// </summary>
public class Hitbox : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        // Determine that the collision is with an enemy
        if (other is CapsuleCollider)
        {
            if (other.gameObject.GetComponent<Soldier>().team != transform.parent.gameObject.GetComponent<Soldier>().team)
            {
                // Set that soldier's vendetta
                other.gameObject.GetComponent<ActionHandler>().SetVendetta(transform.parent.gameObject);
                // Make the soldier take damage
                other.gameObject.GetComponent<Soldier>().health -= Random.Range(5, 11);
                // Launch it backward
                other.gameObject.GetComponent<MovementHandler>().LaunchSoldier(Vector3.Scale(transform.forward, new Vector3(2.0f, 2.0f, 2.0f)), 2.0f);
            }

        }
    }
}
