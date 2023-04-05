using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public static GameManger gameManger {  get; private set; }

    public UnitHealth _playerHealth = new UnitHealth(100, 100);
    void Awake()
    {
        if(gameManger != null && gameManger != this)
        {
            Destroy(this);
        }
        else
        {
            gameManger = this;
        }
    }

}