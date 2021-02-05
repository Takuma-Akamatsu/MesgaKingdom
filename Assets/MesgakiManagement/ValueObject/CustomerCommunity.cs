using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MesgakiManagement.ValueObject
{
    public class CustomerCommunity : ValueObjectBase
    {
        public CustomerCommunity(string communityName)
        {
            Value = communityName;
        }

        public string Value { get; }
    }
}
