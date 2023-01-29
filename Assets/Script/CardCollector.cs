using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCollector : MonoBehaviour
{
    public List<GameObject> inventory;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Card"))
        {
            Destroy(collision.gameObject);
            inventory.Add(collision.gameObject);
        }
    }
}
