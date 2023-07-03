using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleComponent : MonoBehaviour
{
    public delegate void OnColledted();
    public static event OnColledted onCollected;

    private void OnDisable()
    {
        //onCollected += CollectibleUIComponent.GetInstance().UpdateCollectedCoinCount;
        //onCollected += CollectibleUIComponent.GetInstance().UpdateCollectedCoinsUI;

        //onCollected?.Invoke();
        CollectibleUIComponent.GetInstance().UpdateCollectedCoinCount();
        Debug.Log(CollectibleUIComponent.GetInstance().coinsCollected);
        CollectibleUIComponent.GetInstance().UpdateCollectedCoinsUI();

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            DisableObject();
        }
    }
    private void DisableObject()
    {
        gameObject.SetActive(false);
    }
}
