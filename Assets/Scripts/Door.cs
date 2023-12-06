using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject doorClosed, doorOpened, crosshair;
    public float openTime;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Main Camera"))
        {
            crosshair.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                crosshair.SetActive(false);
                doorClosed.SetActive(false);
                doorOpened.SetActive(true);
                StartCoroutine(closeDoor());
            }
        }
    }

    IEnumerator closeDoor()
    {
        yield return new WaitForSeconds(openTime);
        doorOpened.SetActive(false);
        doorClosed.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Main Camera"))
        {
            crosshair.SetActive(false);
        }
    }
}
