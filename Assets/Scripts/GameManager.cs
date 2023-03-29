using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int coins = 0;

    public Text coin;
    
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void RewardUser()
    {
        coins = coins + 70;

        UpdateCoins();
    }

    public void UpdateCoins()
    {
        coin.text = coins.ToString();

    }
}
