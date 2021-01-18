using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MesgakiManagement.ValueObject;

namespace MesgakiManagement.Entity
{
    public class Ojisan : EntityBase
    {
        // 名前
        public CharacterName name;
        // 搾精力（基礎攻撃力）
        public OjisanAttackPoint attackPoint;
        // 体力（HP）
        public HitPoint hitPoint;
        // 魅力（集客力）
        public AppealPoint appealPoint;
        // 弱点容姿属性
        public List<AppearanceType> appearanceTypes;
        // 弱点メスガキ属性
        public List<MesgakiType> weekTypes;
    }
}
