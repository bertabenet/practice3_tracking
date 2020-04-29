using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handle : MonoBehaviour
{

    private Color grayColor;
    private Color normalColor;

    void Start()
    {
        normalColor = gameObject.GetComponent<MeshRenderer>().material.color;
        grayColor = new Color(50, 200, 150);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(gameObject.tag))
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.gray;
            CounterManager.Instance.IncreaseCounter();

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(gameObject.tag))
        {
            gameObject.GetComponent<MeshRenderer>().material.color = normalColor;
            CounterManager.Instance.DecreaseCounter();
        }

    }

}
