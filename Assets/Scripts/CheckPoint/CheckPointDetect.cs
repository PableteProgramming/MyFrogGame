using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointDetect : MonoBehaviour
{
    public GameObject[] limits;
    public bool Passed;
    public GameObject SpawnPoint;
    public GameObject CheckpointsParent;
    // Start is called before the first frame update
    void Start()
    {
        Passed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Passed)
        {
            for (int i=0; i < limits.Length; i++)
            {
                if (limits[i].GetComponent<LimitPassed>().passed)
                {
                    Passed = true;
                    CheckpointsParent.GetComponent<ChooseCheckPoint>().currentCheckpoint = gameObject;
                }
            }
        }
    }
}
