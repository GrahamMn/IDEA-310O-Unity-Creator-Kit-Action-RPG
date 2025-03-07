using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class GandalfsStrength : Weapon.WeaponAttackEffect
{
    public override void OnAttack(CharacterData target, CharacterData user, ref Weapon.AttackData attackData)
    {
        target.Stats.ChangeHealth(-3);
    }
    
    public override void OnPostAttack(CharacterData target, CharacterData user, Weapon.AttackData data)
    {
        user.Stats.ChangeHealth(1);
    }
}
