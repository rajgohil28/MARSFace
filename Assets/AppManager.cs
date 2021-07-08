using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager : MonoBehaviour
{
    public GameObject[] hats;

    void Start()
    {
        Reset();
    }
    public void StrawhatButton()
    {
        Reset();
        hats[0].SetActive(true);
    }
    public void WinterhatButton()
    {
        Reset();
        hats[1].SetActive(true);
    }
    public void PiratehatButton()
    {
        Reset();
        hats[2].SetActive(true);
    }
    public void CrownButton()
    {
        Reset();
        hats[3].SetActive(true);
    }
    public void Reset()
    {
        for (int j=0 ; j <= hats.Length-1; j++)
            hats[j].SetActive(false);
    }
}
