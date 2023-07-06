using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorComponent : MonoBehaviour
{
    public bool canBeOpened;
    public Animator door;

    public void Open() 
    {
        door.Play("opendoor");
    }
    public void Close()
    {
        door.Play("closedoor");
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("Player") && canBeOpened)
        {
            Open();
            Debug.Log("open");
        }
    }
    //todo rename later
    public void EndingDoorCanBeOpened()
    {
        canBeOpened = true;
    }


}
