using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class LevelManagerComponent : MonoBehaviour
{
    public int coinsToCompleteTheLevel;
    public string levelName;
    public UnityEvent onLevelCompleted;

    // Update is called once per frame
    private void Start()
    {
        levelName = SceneManager.GetActiveScene().name;
        onLevelCompleted.AddListener(DisplayCompleteTimeUI);
        CollectibleUIComponent.instance.onCoinCollected.AddListener(OnCoinCollected);
    }
    void LoadNextScene()
    {
        //load next scene
    }
    void OnCoinCollected(int totalCoinsCollected)
    {
        if (totalCoinsCollected == coinsToCompleteTheLevel)
        {
            onLevelCompleted?.Invoke();
            Debug.Log("you have completed the level");
        }
    }
    void Update()
    {
       
    }
    private void DisplayCompleteTimeUI()
    {
        //open completed time ui
        //wait for seconds
        //close ui
    }

}