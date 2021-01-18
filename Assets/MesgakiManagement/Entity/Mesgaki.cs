using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MesgakiManagement.ValueObject;

namespace MesgakiManagement.Entity
{    
    public class Mesgaki : EntityBase
    {
        // 名前
        public CharacterName name;
        // 搾精力（基礎攻撃力）
        public MesgakiAttackPoint attackPoint;
        // 体力（HP）
        public HitPoint hitPoint;
        // 魅力（集客力）
        public AppealPoint appealPoint;
        // 容姿タイプ
        public List<AppearanceType> appearanceTypes;
        // メスガキ属性
        public List<MesgakiType> types;
        // 所持スキル
        public List<MesgakiSkill> skills;
    }
}
