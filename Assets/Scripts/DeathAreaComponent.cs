using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DeathAreaComponent : MonoBehaviour
{
    public CollectibleFactory collectibleFactory;
    public GameObject resetPlayerPositionObject;
    public UnityEvent onPlayerDeath;
    

    private void Start()
    {
        onPlayerDeath.AddListener(ResetCoins);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            ResetPlayerLocation(collision);
            onPlayerDeath?.Invoke();
        }
    }
    private void ResetCoins()
    {
        foreach (GameObject collectibles in collectibleFactory.collectibleInstances)
        {
            collectibles.GetComponent<CollectibleComponent>().EnableObject();
        }
    }
    private void ResetPlayerLocation(Collider2D collision)
    {
        collision.gameObject.transform.position = resetPlayerPositionObject.transform.position;
    }
    

}
