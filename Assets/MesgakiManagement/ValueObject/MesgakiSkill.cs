using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MesgakiManagement.ValueObject
{
    /// <summary>
    /// 容姿タイプ（集客に影響）
    /// </summary>
    public class MesgakiSkill : ValueObjectBase
    {
        public MesgakiSkill(int skillId)
        {
            Value = skillId;
        }

        public int Value { get; }


        #region アクションスキル
        /// <summary>
        /// スワッピング：プレイ中の相手を入れ替える
        /// </summary>
        public static readonly MesgakiSkill SWAPPING = new MesgakiSkill(1);
        #endregion

        #region パッシブスキル
        /// <summary>
        /// リカバリー：待機中の体力回復速度アップ
        /// </summary>
        public static readonly MesgakiSkill RECOVERY = new MesgakiSkill(1);
        #endregion
    }
}