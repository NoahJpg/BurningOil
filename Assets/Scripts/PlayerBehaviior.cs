using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviior : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlayerTakeDmg(20);
            Debug.Log(GameManger.gameManger._playerHealth.Health);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            PlayerHeal(10);
            Debug.Log(GameManger.gameManger._playerHealth.Health);
        }
    }

    private void PlayerTakeDmg(int dmg)
    {
        GameManger.gameManger._playerHealth.DmgUnit(dmg);
    }

    private void PlayerHeal(int heal)
    {
        GameManger.gameManger._playerHealth.HealUnit(heal);
    }
}
