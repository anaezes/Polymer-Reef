﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablePowerUp : Collectable
{
    public enum powerUpType { maxHealth, maxEnergy, speed }

    [SerializeField]
    private powerUpType type;

    [SerializeField]
    private float amount;

    public override void Interact()
    {
        PlayerController controller = player.GetComponent<PlayerController>();

        switch (type)
        {
            case powerUpType.maxEnergy:
                controller.changeMaxEnergy(amount);
                break;
            case powerUpType.maxHealth:
                controller.changeMaxHealth(amount);
                break;
            case powerUpType.speed:
                controller.changeSpeed(amount);
                break;
        }


        base.Interact();
    }
}
