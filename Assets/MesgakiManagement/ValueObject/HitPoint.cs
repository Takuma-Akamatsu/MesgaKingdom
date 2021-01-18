using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MesgakiManagement.ValueObject
{
    public class HitPoint : ValueObjectBase
    {
        public HitPoint(int pointMax)
        {
            Value = pointMax;
        }

        public int Value { get; }
    }
}
