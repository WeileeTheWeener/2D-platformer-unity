using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public int coinsToDisableObject;

    public void DisableObjectOnCoinCollected()
    {
      
        gameObject.SetActive(false);
        
        
    }
}
