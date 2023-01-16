using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickAnimation : MonoBehaviour
{
    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Shoots a coin when click Fire1 (left click)
    public void ClickCoinAnimation()
    {
        Debug.Log("hi");
        GameObject newCoin = Instantiate (coin, transform.position, transform.rotation);
        newCoin.transform.SetParent(GameObject.FindGameObjectWithTag("CoinSpawner").transform,false);
        Destroy(newCoin, 5.0f);
        
    }

    
    
}
