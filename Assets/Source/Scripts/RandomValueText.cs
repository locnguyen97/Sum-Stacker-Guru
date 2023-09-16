using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomValueText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = Random.Range(0, 11).ToString();
    }
}
