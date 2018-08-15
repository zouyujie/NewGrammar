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
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGrammar
{
    public delegate void ConsoleWrite(string strMsg);
    delegate int AddDel(int a, int b); //定义一个委托

    class Program
    {
        static void Main(string[] args)
        {
            C2Class _C2Class = new C2Class();
            _C2Class.Interactive();
            Dog _dog = new Dog();
            _dog.Say();
            _dog.Say("haha");
            _dog.Say("wuwu", 2);
            //_dog.Say(age: 3); //输入结果：汪汪汪,3

            List<int> nums = new List<int>() { 1, 2, 3, 4, 6, 9, 12 };
            //使用委托的方式
            List<int> evenNums = nums.FindAll(GetEvenNum);
            foreach (var item in evenNums)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("使用lambda的方式");

            List<int> evenNumLamdas = nums.FindAll(n => n % 2 == 0);
            foreach (var item in evenNumLamdas)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            InitInfo();
        }

        static void InitInfo()
        {
            //隐式推断类型
            var customer = new User();

            //对象集合初始化器
            User user = new User { Id = 1, Name = "Zouqj", Age = 27 };

            List<Dog> dogs = new List<Dog>() { new Dog() { Name = "Tom", Age = 1 }, new Dog() { Name = "Lucy", Age = 3 } };

            //创建并初始化数组：
            string[] array = { "西施", "貂蝉" };

            //匿名类
            var p = new { Id = 1, Name = " Zouqj ", Age = 26 };//属性名字和顺序不同会生成不同类

            //匿名方法测试
            ConsoleWrite delCW1 = new ConsoleWrite(WriteMsg);
            delCW1("天下第一");

            ConsoleWrite delCW2 = delegate(string strMsg)
            {
                Console.WriteLine(strMsg);
            };
            delCW2("天下第二");

            //扩展方法
            string str = "冷水江";
            str.WriteSelf(2016);

            #region lambda

            AddDel fun = delegate(int a, int b) { return a + b; }; //匿名函数
            //Console.WriteLine(fun(1, 3));
            //lambda  参数类型可以进行隐式推断，可以省略类型 lambda本质就是匿名函数
            AddDel funLambda = (a, b) => a + b;
            List<string> strs = new List<string>() {     "1","2","3"
                                };

            var temp = strs.FindAll(s => int.Parse(s) > 1);
            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(funLambda(1,3));

            #endregion

            //LINQ
            IEnumerable<Dog> listDogs = from dog in dogs
                                        where dog.Age > 5
                                        //let d=new{Name=dog.Name}
                                        orderby dog.Age descending
                                        select dog;
            //select new{Name=dog.Name}
            //LINQ分组：
            IEnumerable<IGrouping<int, Dog>> listGroup = from dog in listDogs where dog.Age > 5 group dog by dog.Age;
            //遍历分组：
            foreach (IGrouping<int, Dog> group in listGroup)
            {
                Console.WriteLine(group.Key + "岁数：");
                foreach (Dog d in group)
                {
                    Console.WriteLine(d.Name + ",age=" + d.Age);
                }
            }

            //params
            ParamsMethod( 25, 24, 21,15);
            ParamsMethod(25, 24, 21, 15);

            //Dynamic
            dynamic Customer = new ExpandoObject();
            Customer.Name = "Zouqj";
            Customer.Age = 27;
            Customer.Male = true;
            Console.WriteLine(Customer.Name + Customer.Age + Customer.Male);
            Console.ReadKey();
        }
        static void WriteMsg(string strMsg)
        {
            Console.WriteLine("myMsg=" + strMsg);
        }
        static bool GetEvenNum(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }
        static void ParamsMethod(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadLine();
        }
    }

}
