//using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notification : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(300, 0, 0);
        Vector3[] paths = new Vector3[2];
        paths[0].x = 300;
        paths[1].x = -300;
        //this.transform.DOLocalPath(paths, 10).onComplete += tweenCallback;
    }

    private void tweenCallback()
    {
        this.transform.position = new Vector3(300, 0, 0);
        Vector3[] paths = new Vector3[2];
        paths[0].x = 300;
        paths[1].x = -300;
        //this.transform.DOLocalPath(paths, 10).onComplete += tweenCallback;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
