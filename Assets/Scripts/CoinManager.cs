using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    public static CoinManager Instance { get; private set; }

    [SerializeField] private float _totalCoins;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        
    }
    
    public void AddCoinMount(float value)
    {
        _totalCoins += value;
    }

    public void LessCoinMount(float value)
    {
        _totalCoins -= value;
    }

    public float GetTotalCoins()
    {
        return _totalCoins;
    }
    
    public void DropCoin(Transform position, int value)
    {
        GameObject newCoin = Instantiate(coinPrefab, position.position, Quaternion.identity);
        Coin coin = newCoin.GetComponent<Coin>();
        coin.Initialize(value);
    }
}
