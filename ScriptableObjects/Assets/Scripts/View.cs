using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class View : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coinNumberText;

    public void CoinUIUpdate(int coinNumber)
    {
        _coinNumberText.text = coinNumber.ToString();
    }
}
