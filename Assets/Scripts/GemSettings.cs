using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class GemSettings : MonoBehaviour
{
    public GameObject player;

    private Tween GemScaleTween;
    private void Start()
    {
        player = GetComponent<GameObject>();
        GemScaleTween = this.gameObject.transform.DOScale(Vector3.one * 1, 5);
        //GemScaleTween.OnPause(OnTweenPaused);


    }

    //private void Update()
    //{
    //    if (PlayerMovement.isTouch == true)
    //    {
    //        GemScaleTween.Pause();
    //    }
    //}

    //private void OnTweenPaused()
    //{
    //    Debug.Log("Animasyon durdu");

    //}


   
}
