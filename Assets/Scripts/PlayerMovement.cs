using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;


[RequireComponent(typeof(Rigidbody))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private FixedJoystick jys;
    [SerializeField] private Animator animator;
    [SerializeField] private ScoreManager _scoreManager;

    public List<GameObject> CollectGemList = new List<GameObject>();
    public List<GameObject> NewGemPrefab = new List<GameObject>();

    #region BaşlangıçFiyatlarıFiyatlandırma
    //Scale 0-0.5 arası Kelek
    //Scale 0.5-0.75 arası Büyümüş
    //Scale 0.75-1 arası Ergin
    int Kelek = 5;
    int Buyumus = 15;
    int Ergin = 25;


    #endregion

    public Transform bag;
    bool inSellArea;



    [SerializeField] private float moveSpeed;
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(jys.Horizontal * moveSpeed, rb.velocity.y, jys.Vertical * moveSpeed);//character movement (right-left) with jys
        if (jys.Horizontal != 0 || jys.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(rb.velocity * Time.deltaTime);//joystick'in yonune dogru karakteri dondurmek
            animator.SetBool("isWalking", true);

        }
        else
            animator.SetBool("isWalking", false);


    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("GemP") || other.gameObject.CompareTag("GemG") || other.gameObject.CompareTag("GemY"))
        {
            if (other.gameObject.transform.localScale.x > 0.25f)
            {
                other.transform.DOKill();
                other.GetComponent<Collider>().enabled = false;

                int n = Random.Range(0, NewGemPrefab.Count);
                Instantiate(NewGemPrefab[n], other.transform.position, NewGemPrefab[n].transform.rotation);

                other.transform.position = new Vector3(bag.transform.position.x, bag.transform.position.y, bag.transform.position.z);

                other.transform.SetParent(this.gameObject.transform);

                bag.transform.position += Vector3.up;
                CollectGemList.Add(other.gameObject);


            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("SellArea"))
        {

            DestroyNextObject();
            inSellArea = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {

        inSellArea = false;
    }

    void DestroyNextObject()
    {
        if (CollectGemList.Count > 0 && inSellArea == true)
        {

            GameObject gem = CollectGemList[CollectGemList.Count - 1]; // Listenin sonundaki objeyi al        
            CollectGemList.RemoveAt(CollectGemList.Count - 1); // Listenin sonundaki objeyi sil

            bag.transform.position -= Vector3.up;
            Destroy(gem); // Objeyi yok et

            Vector3 scale = gem.transform.localScale;
            Debug.Log(scale);


            float boyut = (float)scale.x;

            #region fiyat hesaplama
            if (scale.x > 0 && scale.x <= 0.5f)
            {
                Debug.Log("Kelek");
                _scoreManager.ScorePlus(Kelek + (boyut * 100));
            }
            if (scale.x > 0.5f && scale.x <= 0.75f)
            {
                Debug.Log("Buyumus");
                _scoreManager.ScorePlus(Buyumus + (boyut * 100));

            }
            if (scale.x > 0.75f && scale.x <= 1f)
            {
                Debug.Log("Ergin");
                _scoreManager.ScorePlus(Ergin + (boyut * 100));

            }
            #endregion

            #region panelSayısıControl
            if (gem.gameObject.CompareTag("GemG"))
            {
                PanelController.sellGreen += 1;
            }
            if (gem.gameObject.CompareTag("GemY"))
            {
                PanelController.sellYellow += 1;
            }
            if (gem.gameObject.CompareTag("GemP"))
            {
                PanelController.sellPurple += 1;
            }
            #endregion
        }
    }

}




