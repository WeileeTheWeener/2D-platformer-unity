using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//todo: rename this to coin disable object
public class CoinCollectDisableObjectComponent : MonoBehaviour
{  
    [SerializeField] private int coinsToDisableObject;
    public int CoinsToDisableObject { get => coinsToDisableObject; set => coinsToDisableObject = value; }

    public void DisableThisObject(int coinsCollected)
    {    
        if (coinsCollected == CoinsToDisableObject)
        {
            gameObject.SetActive(false);
        }
    }
}
