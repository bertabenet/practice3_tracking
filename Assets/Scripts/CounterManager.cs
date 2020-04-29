using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterManager : MonoBehaviour
{
    public static CounterManager Instance;

    [HideInInspector]           // don't show the variable on the editor
    public int counter;

    public GameObject positionWristL;
    public GameObject positionWristR;
    public GameObject positionAnkleL;
    public GameObject positionAnkleR;

    public int total_triggers;

    private void Awake()
    {
        Instance = this;
    }

    public void IncreaseCounter()
    {
        counter++;
        if(counter == total_triggers)
        {
            GameOver();
        }
    }

    public void DecreaseCounter()
    {
        counter--;
    }

    private void GameOver()
    {
        UIManager.Instance.SetGameOverText();

        // stop collider
        positionWristL.GetComponent<Collider>().enabled = false;
        positionWristR.GetComponent<Collider>().enabled = false;
        positionAnkleL.GetComponent<Collider>().enabled = false;
        positionAnkleR.GetComponent<Collider>().enabled = false;

        // set color to gray forever
        positionWristL.GetComponent<MeshRenderer>().material.color = Color.gray;
        positionWristR.GetComponent<MeshRenderer>().material.color = Color.gray;
        positionAnkleL.GetComponent<MeshRenderer>().material.color = Color.gray;
        positionAnkleR.GetComponent<MeshRenderer>().material.color = Color.gray;
    }
     
}
