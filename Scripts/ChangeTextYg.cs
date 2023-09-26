using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeTextYg : MonoBehaviour
{
    
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text =  GetComponent<TextMesh>().text;
    }

    
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = GetComponent<TextMesh>().text;
    }
}
