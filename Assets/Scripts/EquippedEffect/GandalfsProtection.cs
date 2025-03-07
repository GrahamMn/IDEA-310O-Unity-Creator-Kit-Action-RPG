using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class GandalfsProtection : EquipmentItem.EquippedEffect
{
     public override void Equipped(CharacterData user)
     {
          user.Stats.stats.strength = user.Stats.stats.strength + 3;
     }
     
     public override void Removed(CharacterData user)
     {
          user.Stats.stats.strength = user.Stats.stats.strength - 3;
     }
}
