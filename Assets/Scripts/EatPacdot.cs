using UnityEngine;
using System.Collections;

public class EatPacdot : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "pacmann")
            Destroy(gameObject);
    }
}