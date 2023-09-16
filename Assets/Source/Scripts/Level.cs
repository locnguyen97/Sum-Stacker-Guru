using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Level : MonoBehaviour
{
    [SerializeField] private List<DragAndDrop> listTop;
    [SerializeField] private List<DragAndDrop> listBot;

    private int sl = 0;
    private int countCheck = 0;
    private void OnEnable()
    {
        StartGame();
    }

    public void StartGame()
    {
        StartCoroutine(InitData());
    }

    public void CheckGame()
    {
        countCheck++;
        if(countCheck == sl)
            GameManager.Instance.CheckLevelUp();
    }

    IEnumerator InitData()
    {
        countCheck = 0;
        yield return new WaitForSeconds(0.5f);
        sl = GameManager.Instance.currentIndex + 2;
        List<int> listK = new List<int>(){1,2,3,4,5,6};
        List<DragAndDrop> listT = new List<DragAndDrop>(){};
        List<DragAndDrop> listB = new List<DragAndDrop>(){};
        for (int i = 0; i < sl; i++)
        {
            int solieu = listK[Random.Range(0, listK.Count)];
            listK.Remove(solieu);
            var k = listTop[Random.Range(0, listTop.Count)];
            while (listT.Exists(l=> l == k))
            {
                k = listTop[Random.Range(0, listTop.Count)];
                yield return new WaitForEndOfFrame();
            }
            k.GetComponent<RandomColorSprite>().SetData(solieu-1);
            listT.Add(k);
            k.gameObject.SetActive(true);
            var k2 = listBot[Random.Range(0, listBot.Count)];
            while (listB.Exists(l=> l == k2))
            {
                yield return new WaitForEndOfFrame();
                k2 = listBot[Random.Range(0, listBot.Count)];
            }
            k2.GetComponent<RandomColorSprite>().SetData(solieu-1);
            listB.Add(k2);
            k2.gameObject.SetActive(true);
        }
        
    }
}
