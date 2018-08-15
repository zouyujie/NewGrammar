/****************************************************************************
* Copyright (c) 2016Microsoft All Rights Reserved.
* CLR版本： 4.0.30319.18052
*机器名称：ZOUYUJIE-PC
*公司名称：Microsoft
*命名空间：NewGrammar
*文件名：  Class1
*版本号：  V1.0.0.0
*唯一标识：99d86ab8-2d91-4f21-a5ee-f7f3d6cbc7bc
*当前的用户域：ZOUYUJIE-PC
*创建人：  邹琼俊
*电子邮箱：zouqiongjun@kjy.com
*创建时间：2016/4/24 0:04:34

*描述：
*
*=====================================================================
*修改标记
*修改时间：2016/4/24 0:00:18
*修改人： Administrator
*版本号： V1.0.0.0
*描述：
*
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGrammar
{
    public class User
    {
        public int Id { get; set; } //自动属性
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        //private int id;
        //public int Id
        //{
        //    get
        //    {
        //        return id;
        //    }
        //    set
        //    {
        //        id = value;
        //    }
        //}
    }
    public class Address
    {
        public string Province { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Floor { get; set; }
    }
}
