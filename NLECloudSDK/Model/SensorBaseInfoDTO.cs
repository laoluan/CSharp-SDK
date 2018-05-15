﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/************************************************************
*CLR版本:4.0.30319.42000
*命名空间:NLECloudSDK.Model
*文件名:SensorBaseInfoDTO
*创建时间:2018/5/3 16:58:36
==============================================================
*修改人:
*修改时间:2018/5/3 16:58:36
*修改描述:

************************************************************/
namespace NLECloudSDK.Model
{
    public class SensorBaseInfoDTO
    {
        /// <summary>
        /// 传感标识名（设备范围内唯一）
        /// </summary>
        public String ApiTag { get; set; }

        /// <summary>
        /// 传感组别 1：传感器 2：执行器 3：摄像头 4：LED 
        /// </summary>
        public byte Groups { get; set; }

        /// <summary>
        /// 通信协议 0:Unknown 1：Modbus 2：Zigbee 3：Tcp 4：Udp 
        /// </summary>
        public byte Protocol { get; set; }

        /// <summary>
        /// 传感名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreateDate { get; set; }

        /// <summary>
        /// 传输类型，0：只上报 1：上报和下发 2：报警 3：故障 
        /// </summary>
        public byte TransType { get; set; }

        /// <summary>
        /// 数据类型，0：整数型 1：浮点型 2：布尔型 3：字符型 4：枚举型 5：二进制型 
        /// </summary>
        public byte DataType { get; set; }

        /// <summary>
        /// 附加属性，如枚举型(各个枚举以半角逗号分隔)：可爱，有在，装备，蜗牛 
        /// </summary>
        public Object TypeAttrs { get; set; }

        /// <summary>
        /// 所属设备ID
        /// </summary>
        public int DeviceID { get; set; }

        /// <summary>
        /// 传感器类型（如temperature、humidity、light之类的）
        /// </summary>
        public string SensorType { get; set; }

        /// <summary>
        /// 传感的最新值（有引号是字符串或枚举，无引号是整数型或浮点型，true|false是布尔值，其它为二进制型） 
        /// </summary>
        public Object Value { get; set; }

        /// <summary>
        /// 值最新上传时间（格式：YYYY-MM-DD HH:mm）
        /// </summary>
        public string RecordTime { get; set; }
    }
}
