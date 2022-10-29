using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Entity : MonoBehaviour
{

    public virtual void GetDamage()
    { }

    public virtual void Die()

    {

        Destroy(this.gameObject);

    }
}
