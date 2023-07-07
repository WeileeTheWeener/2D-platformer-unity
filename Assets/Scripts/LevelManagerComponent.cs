using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class LevelManagerComponent : MonoBehaviour
{
    [SerializeField] private int coinsToCompleteTheLevel;
    [SerializeField] private string levelName;
    [SerializeField] private UnityEvent onLevelCompleted;
    [SerializeField] private CoinCollectDisableObjectComponent[] disableObjectList;

    // Update is called once per frame
    private void Start()
    {
        levelName = SceneManager.GetActiveScene().name;
        onLevelCompleted.AddListener(DisplayCompleteTimeUI);
        CollectibleUIComponent.instance.onCoinCollected.AddListener(OnCoinCollected);
    }
    void OnCoinCollected(int totalCoinsCollected)
    {
        if (totalCoinsCollected == coinsToCompleteTheLevel)
        {
            onLevelCompleted?.Invoke();
            Debug.Log("you have completed the level");
        }
        foreach(var objectToDisable in disableObjectList) 
        {
            objectToDisable.DisableThisObject(totalCoinsCollected);
        }
    }
    private void DisplayCompleteTimeUI()
    {
        //todo
        //open completed time ui
        //wait for seconds
        //close ui
    }

}
