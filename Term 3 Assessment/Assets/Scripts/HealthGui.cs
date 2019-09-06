using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthGui : MonoBehaviour
{
    public Image healthHexagon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HealthDown()
    {
        healthHexagon.fillAmount -= 4;
    }
}
