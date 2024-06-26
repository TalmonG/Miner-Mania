using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickAnimation : MonoBehaviour
{
    public GameObject coin;
    public GameObject canvas;
    private int x,y;
    public int xBoundary;
    public int yBoundary;
    public float timer;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;

        canvas = GameObject.FindWithTag("Canvas");
        transform.SetParent(canvas.transform);

        x = Random.Range(-xBoundary, yBoundary);
        y = Random.Range(-xBoundary, yBoundary);

        transform.localPosition = new Vector3(x, y, 0);
        //Debug.Log("Hey1");    
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1f)
        {
            Destroy(this.gameObject);
        }
        transform.position = new Vector3(transform.position.x, transform.position.y + Time.deltaTime * speed, 0);



        //Debug.Log("Hey2");
    }

    // Update is called once per frame
    


    // Shoots a coin when click Fire1 (left click)
    /*public void ClickCoinAnimation()
    {
        Debug.Log("hi");
        GameObject newCoin = Instantiate (coin, transform.position, transform.rotation) as GameObject;
        newCoin.transform.SetParent(GameObject.FindGameObjectWithTag("CoinSpawner").transform,false);
        Destroy(newCoin, 5.0f);
        
    }*/

    
    
}
