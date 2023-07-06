using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollectibleComponent : MonoBehaviour
{
    // public delegate void OnColledted();
    // public event OnColledted onCollected;

    public UnityEvent<Vector2> onCollected;
    private void OnDisable()
    {
        // todo: collectible component is not concerned with what happens when the event triggers
        // onCollected += CollectibleUIComponent.GetInstance().UpdateCollectedCoinCount;
        // onCollected += CollectibleUIComponent.GetInstance().UpdateCollectedCoinsUI;
        CollectibleUIComponent.GetInstance().UpdateCollectedCoinCount();
        CollectibleUIComponent.GetInstance().UpdateCollectedCoinsUI();
        onCollected?.Invoke(transform.position);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DisableObject();
        }
    }

    private void DisableObject()
    {
        gameObject.SetActive(false);
    }
    public void EnableObject()
    {
        if(!gameObject.activeInHierarchy)
        {
            gameObject.SetActive(true);
        }
        
    }
}