using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MesgakiManagement.ValueObject
{
    public class MesgakiType : ValueObjectBase
    {
        public MesgakiType(int typeId)
        {
            Value = typeId;
        }

        public int Value { get; }


        #region 志向
        /// <summary>
        /// ガーリッシュ（少女趣味・乙女）
        /// </summary>
        public static readonly MesgakiType GIRLISH = new MesgakiType(1);
        /// <summary>
        /// ギャル
        /// </summary>
        public static readonly MesgakiType GIRL = new MesgakiType(2);
        /// <summary>
        /// ほんわか（癒し系）
        /// </summary>
        public static readonly MesgakiType HONWAKA = new MesgakiType(3);
        /// <summary>
        /// お嬢様
        /// </summary>
        public static readonly MesgakiType LADY = new MesgakiType(4);
        /// <summary>
        /// ポジティブ（スポーツ好き含む）
        /// </summary>
        public static readonly MesgakiType POSITIVE = new MesgakiType(5);
        /// <summary>
        /// 優等生
        /// </summary>
        public static readonly MesgakiType HONOR_STUDENT = new MesgakiType(6);
        /// <summary>
        /// 高飛車（ナルシスト）
        /// </summary>
        public static readonly MesgakiType NARCIST = new MesgakiType(7);
        /// <summary>
        /// クール（完璧主義・機械的）
        /// </summary>
        public static readonly MesgakiType COOL = new MesgakiType(8);
        /// <summary>
        /// 中二病
        /// </summary>
        public static readonly MesgakiType CHUNIBYO = new MesgakiType(9);
        /// <summary>
        /// オタク（婦女子）
        /// </summary>
        public static readonly MesgakiType OTAKU = new MesgakiType(10);
        /// <summary>
        /// 無気力
        /// </summary>
        public static readonly MesgakiType LETHARGY = new MesgakiType(11);
        #endregion

        #region 行動原理
        /// <summary>
        /// 幼げ
        /// </summary>
        public static readonly MesgakiType LOLITA = new MesgakiType(100);
        /// <summary>
        /// 母性的
        /// </summary>
        public static readonly MesgakiType MAMA = new MesgakiType(200);
        /// <summary>
        /// 正義感・人情家
        /// </summary>
        public static readonly MesgakiType HERO = new MesgakiType(300);
        /// <summary>
        /// 引きこもり
        /// </summary>
        public static readonly MesgakiType SOCIAL_WITHDRAWAL = new MesgakiType(400);
        /// <summary>
        /// 儚げ
        /// </summary>
        public static readonly MesgakiType TRANSIENT = new MesgakiType(500);
        /// <summary>
        /// ツンデレ
        /// </summary>
        public static readonly MesgakiType TSUNDERE = new MesgakiType(600);
        /// <summary>
        /// ヤンデレ
        /// </summary>
        public static readonly MesgakiType YANDERE = new MesgakiType(700);
        /// <summary>
        /// 独裁的（サド）
        /// </summary>
        public static readonly MesgakiType SADISTIC = new MesgakiType(800);
        /// <summary>
        /// 動物的（アホの子）
        /// </summary>
        public static readonly MesgakiType ANIMAL = new MesgakiType(900);
        /// <summary>
        /// ツッコミ
        /// </summary>
        public static readonly MesgakiType TSUKKOMI = new MesgakiType(1000);
        /// <summary>
        /// 変態
        /// </summary>
        public static readonly MesgakiType HENTAI = new MesgakiType(1100);
        /// <summary>
        /// 自由人・不思議ちゃん
        /// </summary>
        public static readonly MesgakiType FREEDOM = new MesgakiType(1200);
        /// <summary>
        /// ドジっ子
        /// </summary>
        public static readonly MesgakiType DOJI = new MesgakiType(1300);
        /// <summary>
        /// 妹
        /// </summary>
        public static readonly MesgakiType LITTLE_SISTER = new MesgakiType(1400);
        /// <summary>
        /// 姉
        /// </summary>
        public static readonly MesgakiType BIG_SISTER = new MesgakiType(1500);
        /// <summary>
        /// エム
        /// </summary>
        public static readonly MesgakiType MASOCHIST = new MesgakiType(1600);
        #endregion
    }
}