using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] private float waitTime = 3f;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(OpenTheDoor());
    }

    IEnumerator OpenTheDoor()
    {
        door.SetActive(false);
        yield return new WaitForSeconds(waitTime);
        door.SetActive(true);
    }
}
