using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColorSprite : MonoBehaviour
{
    [SerializeField] private List<Color> listColor;

    [SerializeField] private SpriteRenderer render;

    [SerializeField] private List<GameObject> listPoint;

    public int index = -1;
    // Start is called before the first frame update
    public void SetData(int number)
    {
        render.color = listColor[number];
        listPoint[number].SetActive(true);
        index = number;
    }

    public void Reset()
    {
        index = -1;
        foreach (var p in listPoint)
        {
            p.SetActive(false);
        }
    }
}
