using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MesgakiManagement.ValueObject
{
    /// <summary>
    /// 容姿タイプ（集客に影響）
    /// </summary>
    public class AppearanceType : ValueObjectBase
    {
        public AppearanceType(int typeId)
        {
            Value = typeId;
        }

        public int Value { get; }


        #region 髪色
        /// <summary>
        /// 黒
        /// </summary>
        public static readonly AppearanceType BLACK = new AppearanceType(1);
        /// <summary>
        /// 赤
        /// </summary>
        public static readonly AppearanceType RED = new AppearanceType(2);
        #endregion

        #region 胸サイズ
        /// <summary>
        /// 爆乳
        /// </summary>
        public static readonly AppearanceType DINAMAIT = new AppearanceType(100);
        /// <summary>
        /// 巨乳
        /// </summary>
        public static readonly AppearanceType BIG = new AppearanceType(200);
        /// <summary>
        /// 普通
        /// </summary>
        public static readonly AppearanceType NORMAL = new AppearanceType(300);
        /// <summary>
        /// 貧乳
        /// </summary>
        public static readonly AppearanceType SMALL = new AppearanceType(400);
        /// <summary>
        /// 壁
        /// </summary>
        public static readonly AppearanceType WALL = new AppearanceType(400);
        #endregion
    }
}