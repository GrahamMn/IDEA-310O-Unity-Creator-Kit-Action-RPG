using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class RemoveHealthEffect : UsableItem.UsageEffect
{
    public int HealthAmount;
    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(HealthAmount * -1);
        return true;
    }
}
