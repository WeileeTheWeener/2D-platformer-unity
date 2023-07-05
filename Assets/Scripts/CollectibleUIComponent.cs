using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class CollectibleUIComponent : MonoBehaviour
{
    public static CollectibleUIComponent instance;
    private TextMeshProUGUI textMeshPro;
    public static int coinsCollected=0;
    public UnityEvent<int> onCoinCollected;

    public static CollectibleUIComponent GetInstance()
    {      
        return instance;
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        textMeshPro = gameObject.GetComponent<TextMeshProUGUI>();
    }
    public void UpdateCollectedCoinCount()
    {
        coinsCollected+=1;
        onCoinCollected?.Invoke(coinsCollected);

    }
    public void UpdateCollectedCoinsUI()
    {
        textMeshPro.text = String.Format("Coins Collected: {0}" ,coinsCollected.ToString());
    }


}
