using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MesgakiManagement.ValueObject
{
    public class AppealPoint : ValueObjectBase
    {
        public AppealPoint(int pointMax)
        {
            Value = pointMax;
        }

        public int Value { get; }
    }
}
