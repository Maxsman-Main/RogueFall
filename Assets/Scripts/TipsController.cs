using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TipsController : MonoBehaviour
{
    [SerializeField] private Transform _place;
    [SerializeField] private Text _shopText;

    private bool _cashTipIsActive;

    private void Awake()
    {
        _cashTipIsActive = false;
    }

    public void ShowCashTip()
    {
        if (!_cashTipIsActive)
        {
            StartCoroutine(CashTip());
        }
    }

    private IEnumerator CashTip()
    {
        _cashTipIsActive = true;
        gameObject.GetComponent<Text>().text = "Вам не хватает валюты";
        
        yield return new WaitForSeconds(2);
        
        _cashTipIsActive = false;
        gameObject.GetComponent<Text>().text = "";
    }
}