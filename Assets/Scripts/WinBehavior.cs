using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinBehavior : MonoBehaviour
{
    [SerializeField] public GameObject winMessage;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
            winMessage.SetActive(true);
    }
}
