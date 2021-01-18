using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MesgakiManagement.ValueObject
{
    public class CharacterName : ValueObjectBase
    {
        public CharacterName(string name)
        {
            Value = name;
        }

        public string Value { get; }
    }
}
