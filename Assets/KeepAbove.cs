using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepAbove : MonoBehaviour
{
    [SerializeField] private Transform rotato;
    [SerializeField] private float height = 4;

    void Update() => this.transform.position = new Vector3(rotato.position.x, rotato.position.y + height, rotato.position.z);
}
