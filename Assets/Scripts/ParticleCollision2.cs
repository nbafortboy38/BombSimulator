using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision2 : MonoBehaviour
{
    public Transform explosionPrefab;

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        Transform effect = Instantiate(explosionPrefab, pos, rot) as Transform;
    }
}
