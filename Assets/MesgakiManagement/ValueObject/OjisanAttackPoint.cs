using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MesgakiManagement.ValueObject
{
    public class OjisanAttackPoint : ValueObjectBase
    {
        public OjisanAttackPoint(int pointMax)
        {
            Value = pointMax;
        }

        public int Value { get; }
    }
}
