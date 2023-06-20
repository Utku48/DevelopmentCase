using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class GemSettings : MonoBehaviour
{


    private Tween GemScaleTween;
    private void Start()
    {

        GemScaleTween = this.gameObject.transform.DOScale(Vector3.one * 1, 5);
        StartCoroutine(EnableCollider());
    }
    IEnumerator EnableCollider()
    {
        yield return new WaitForSeconds(1.25f);
        GetComponent<Collider>().enabled = true;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GemScaleTween.Pause();
        }
    }

    private void OnTweenPaused()
    {
        Debug.Log("Animasyon durdu");

    }



}
