using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlatformComponent : MonoBehaviour
{
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");

        player.GetComponent
            <MovementComponent>().onCollided.AddListener(player.GetComponent
            <MovementComponent>().ResetJumpCount);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player")) 
        {
            //todo: invoke collide event
            player.GetComponent<MovementComponent>().onCollided?.Invoke();
            Debug.Log(System.String.Format("{0} resetted players jump count",gameObject.name));
        }
    }

}
