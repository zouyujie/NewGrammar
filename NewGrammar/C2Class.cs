/****************************************************************************
* Copyright (c) 2016Microsoft All Rights Reserved.
* CLR版本： 4.0.30319.18052
*机器名称：ZOUYUJIE-PC
*公司名称：Microsoft
*命名空间：NewGrammar
*文件名：  C2Class
*版本号：  V1.0.0.0
*唯一标识：420d38b2-dc38-4268-baa4-4cf27669ffd0
*当前的用户域：ZOUYUJIE-PC
*创建人：  邹琼俊
*电子邮箱：zouqiongjun@kjy.com
*创建时间：2016/5/15 11:10:13

*描述：
*
*=====================================================================
*修改标记
*修改时间：2016/5/15 11:10:13
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
    public class C2Class
    {
        //泛型类
        List<string> lst = new List<string>();
        //泛型委托 
        public delegate void Del<T>(T item);
        public static void Notify(int i) { }
        Del<int> m1 = new Del<int>(Notify);
        //泛型接口 
        public class MyClass<T1, T2, T3> : MyInteface<T1, T2, T3> { public T1 Method1(T2 param1, T3 param2) { throw new NotImplementedException(); } }
        interface MyInteface<T1, T2, T3> { T1 Method1(T2 param1, T3 param2); }

        //泛型方法 
        static void Swap<T>(ref T t1, ref T t2) { T temp = t1; t1 = t2; t2 = temp; }
        public void Interactive()
        {
            string str1 = "a"; string str2 = "b";
            Swap<string>(ref str1, ref str2);
            Console.WriteLine(str1 + "," + str2);
        }
    }
    //泛型类
   //public class List<T> { }
}
