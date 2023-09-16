using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class RandomColor : MonoBehaviour
{
    [SerializeField] private List<Color> listColor;
    [SerializeField] private List<Sprite> listVal;
    [SerializeField] private Image bg;
    [SerializeField] private Image icon;

    private void Start()
    {
        if (Random.value <= 0.35f)
        {
            gameObject.SetActive(true);
            Check();
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    private void Check()
    {
        bg.color = listColor[Random.Range(0, listColor.Count)];
        icon.sprite = listVal[Random.Range(0, listVal.Count)];
        icon.SetNativeSize();
    }
}
