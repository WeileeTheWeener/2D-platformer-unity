using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneChangerComponent : MonoBehaviour
{
    public Scene nextScene;
    public UnityEvent onChangeScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player")) 
        {
            ChangeToNextScene();
            onChangeScene?.Invoke();
            Debug.Log("changing to the next scene");
        }
    }
    private void ChangeToNextScene()
    {
        //todo: do this with dependancy injection
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
