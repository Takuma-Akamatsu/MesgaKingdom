using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MesgakiManagement.ValueObject
{
    public class MesgakiAttackPoint : ValueObjectBase
    {
        public MesgakiAttackPoint(int pointMax)
        {
            Value = pointMax;
        }

        public int Value { get; }
    }
}
