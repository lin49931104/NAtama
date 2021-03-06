﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;

namespace Model.DBF
{        
    public class BuffEffectLib:DBFItemBase
    {    
        public class ItemInfo
        {
            public int ItemID = -1;
            public int Value = 0;
        }

        public int Lv;

        /// <summary>需求等級</summary>
        public int RequireLv;
        /// <summary>需求時間</summary>
        public int Time;
        /// <summary>類型</summary>
        public int Type;        
        /// <summary> 需求道具條件 </summary>
        public ItemInfo[] Require = null;
        /// <summary> 加速道具 </summary>
        public ItemInfo Immediate = null;
        /// <summary> Buff效果 </summary>
        public int BuffValue = 0;

        // ================================
        // 投資 Buff相關
        /// <summary> 金幣單位 </summary>
        public int Coin = 0;
        /// <summary> 可存放時間(分) </summary>
        public int SaveTime = 0;
    }
}
