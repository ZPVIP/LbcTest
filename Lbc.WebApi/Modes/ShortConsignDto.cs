﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lbc.WebApi.Modes {
    public class ShortConsignDto {
        /// <summary>
        /// 委托业务流水号
        /// </summary>
        public decimal ConsignId {
            get;
            set;
        }


        /// <summary>
        /// 委托人 
        /// </summary>
        public string ConsignerName {
            get;
            set;
        }


        /// <summary>
        /// 所属货代企业流水号,当值为0时所有企业可用
        /// </summary>
        public decimal FfId {
            get;
            set;
        }


        /// <summary>
        /// 业务委托号
        /// </summary>
        public string ConsignNo {
            get;
            set;
        }

        /// <summary>
        /// 委托日期
        /// </summary>
        public DateTime? ConsignDate {
            get;
            set;
        }

        /// <summary>
        /// 状态:业务状态
        ///-10历史
        ///0:客户草稿
        ///5:客户提交
        ///10;(业务)草稿
        ///15:(业务)客户确认
        ///16:(业务)客户异议
        ///99:(业务)提交
        ///101:(商务)接单
        ///102:(商务)审核中
        ///104:(商务)审核拒绝
        ///109:(商务)审核通过
        ///201:(订舱)接单
        ///204:(订舱)订舱失败
        ///299:(订舱)订舱成功
        ///301:(操作)接单
        ///310:(操作)拖车/报关已安排
        ///320:(操作)还柜中（第1个柜进码头）
        ///329:(操作)已还柜（最后一个柜进码头）
        ///331:衬料操作
        ///350:已装船
        ///351:已收单(从船东或同行处取得提单)
        ///352:已出提单(MB/HB)
        ///353:电放
        ///501:扣单中
        ///511:未应收放单
        ///512:未应收电放
        ///521:已放单(应收已清)
        ///522:已电放(应收已清)
        ///699:财务完成(提成已出)
        ///999:已完成
        /// </summary>
        public decimal Status {
            get;
            set;
        }

        /// <summary>
        /// 发货人ID
        /// </summary>
        public decimal? ConsignorId {
            get;
            set;
        }

        /// <summary>
        /// 发货人名称
        /// </summary>
        public string ConsignorName {
            get;
            set;
        }


        /// <summary>
        /// 装货港英文名称
        /// </summary>
        public string PolNameEn {
            get;
            set;
        }

        /// <summary>
        /// 装货港中文名称
        /// </summary>
        public string PolNameCn {
            get;
            set;
        }

        /// <summary>
        /// 卸货港英文名称
        /// </summary>
        public string PodNameEn {
            get;
            set;
        }

        /// <summary>
        /// 卸货港中文名称
        /// </summary>
        public string PodNameCn {
            get;
            set;
        }

        /// <summary>
        /// 目的地名称Destination  
        /// </summary>
        public string DestNameEn {
            get;
            set;
        }

        /// <summary>
        /// 目的地中文名称Destination  
        /// </summary>
        public string DestNameCn {
            get;
            set;
        }

        /// <summary>
        /// 收货地名称Place Of Receipt  
        /// </summary>
        public string PorNameEn {
            get;
            set;
        }

        /// <summary>
        /// 收货地中文名称Place Of Receipt  
        /// </summary>
        public string PorNameCn {
            get;
            set;
        }

    }
}
