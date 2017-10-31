using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class Scene : MasujimaRyohei.SceneBase
{
    //[SerializeField]
    //private GameObject s;

    [SerializeField]
    private GameObject[] enableObjects;
    [SerializeField]
    private GameObject[] disableObjects;

    [SerializeField]
    private GameObject[] dangos;
    [SerializeField]
    private GameObject destroyableWalls;

    [SerializeField]
    private GameObject txtClear;

    // Use this for initialization
    void Start()
    {
        MasujimaRyohei.AudioManager.PlayBGM("Dango3Bro");

        foreach (var g in enableObjects)
            g.SetActive(true);
        foreach (var g in disableObjects)
            g.SetActive(false);
        //Observable
        //    .Interval(System.TimeSpan.FromSeconds(1.0f))
        //    .Subscribe(_ =>
        //    {
        //        var g = Instantiate(s, new Vector3(0, 100, 0), Quaternion.identity);
        //    });
    }

    // Update is called once per frame
    void Update()
    {
        int existCount = 0;
        foreach(var g in dangos)
        {
            if (g)
                existCount++;
        }
        if (destroyableWalls)
            if (existCount <= 1)
            {
                    Destroy(destroyableWalls);
            }

        if (existCount <= 0)
            txtClear.SetActive(true);
    }
}
