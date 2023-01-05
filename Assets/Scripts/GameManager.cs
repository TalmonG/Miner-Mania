using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;






public class GameManager : MonoBehaviour
{
    public float cash;
    public float earnings;
    public int multiplier;
    public int clickValue;
    

    public Text cashText;
    public Text earningsText;

    public float cashConverter;
    public float earningsConverter;

    public float earningsNewspaper;
    public Text earningsNewspaperText;

    public float cashIncreasedPerSecond;


    public void AutoIncrement()
    {
        cash += multiplier * Time.deltaTime;
        PlayerPrefs.SetFloat("cash", cash);
    }

    public void ManualIncrement()
    {
        cash += clickValue; 
    }

    public void Buy(int num)
    {
    // everytime you upgrade, it increases the price by 15%
    //from one upgrade to anopther, should be 166% price difference
        if (num == 1 && cash >= 4)
        {
            multiplier += 4;
            cash -= 4;
            PlayerPrefs.SetFloat("cash", cash);
            PlayerPrefs.SetInt("multiplier", multiplier);
            earningsNewspaper += 4;
        }

        if (num == 2 && cash >= 120)
        {
            multiplier += 120;
            cash -= 120;
            PlayerPrefs.SetFloat("cash", cash);
            PlayerPrefs.SetInt("multiplier", multiplier);
        }

        if (num == 3 && cash >= 2880)
        {
            multiplier += 2880;
            cash -= 2880;
            PlayerPrefs.SetFloat("cash", cash);
            PlayerPrefs.SetInt("multiplier", multiplier);
        }
    }

    public void Start()
    {
        multiplier = PlayerPrefs.GetInt("multiplier", 0);
        cash = PlayerPrefs.GetFloat("cash", 0);
        clickValue = PlayerPrefs.GetInt("clickValue", 1);
    }

    public void FixedUpdate() 
    {
       // cashText.text += multiplier * Time.fixedDeltaTime;
        //Debug.Log (cashText.text);
        AutoIncrement();
    }

    public void Update()
    {

        earnings = multiplier;

        CashConverterFunction();

        if (cash >= 1000)
        {
            cashText.text = "$ " + cashConverter.ToString("F2") + "K"; // Thousand
        }
        if (cash >= 10000)
        {
            cashText.text = "$ " + cashConverter.ToString("F2") + "K"; // Ten Thousand
        }
        if (cash >= 100000)
        {
            cashText.text = "$ " + cashConverter.ToString("F2") + "K"; // Hundred Thousand
        }
        if (cash >= 1000000)
        {
            cashText.text = "$ " + cashConverter.ToString("F2") + "M"; // Million
        }
        if (cash < 1000)
        {
            cashText.text = "$ " + cash;
        }


        EarningsConverterFunction();

        if (earnings >= 1000)
        {
            earningsText.text = "$ " + earningsConverter.ToString("F2") + "K"; // Thousand
        }
        if (earnings >= 10000)
        {
            earningsText.text = "$ " + earningsConverter.ToString("F2") + "K"; // Ten Thousand
        }
        if (earnings >= 100000)
        {
            earningsText.text = "$ " + earningsConverter.ToString("F2") + "K"; // Hundred Thousand
        }
        if (earnings >= 1000000)
        {
            earningsText.text = "$ " + earningsConverter.ToString("F2") + "M"; // Million
        }
        if (earnings < 1000)
        {
            earningsText.text = "$ " + earnings;
        }

    }

    public void CashConverterFunction()
    {
        if (cash >= 1000)
        {
            cashConverter = cash / 1000;
        }
        if (cash >= 10000)
        {
            cashConverter = cash / 1000;
        }
        if (cash >= 100000)
        {
            cashConverter = cash / 1000;
        }
        if (cash >= 1000000)
        {
            cashConverter = cash / 100000;
        }
    }


    public void EarningsConverterFunction()
    {
        if (earnings >= 1000)
        {
            earningsConverter = earnings / 1000;
        }
        if (earnings >= 10000)
        {
            earningsConverter = earnings / 1000;
        }
        if (earnings >= 100000)
        {
            earningsConverter = earnings / 1000;
        }
        if (earnings >= 1000000)
        {
            earningsConverter = earnings / 100000;
        }
    }




    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("Data has been erased!");
        cash = PlayerPrefs.GetFloat("cash", 0);
        multiplier = PlayerPrefs.GetInt("multiplier", 0);
        clickValue = PlayerPrefs.GetInt("clickValue", 1);
        
    }
}
