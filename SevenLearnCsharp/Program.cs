﻿using System;
using Entity;


namespace SevenLearnCsharp
{
    class Program
    {


        static void Main(string[] args)
        {
            #region 值的值传递和引用  之前作业完结

            //int a = 18;

            //HomeWork person = new HomeWork();//值的值传递
            //person.ValuePass(a);
            //Console.WriteLine(a);
            //Console.WriteLine("------------------------");

            //HomeWork otherPerson = new HomeWork();//值的引用传递
            //otherPerson.ReferencePass(ref a);
            //Console.WriteLine(a);
            //Console.WriteLine("--------------------------");

            //HomeWork name = new HomeWork { _name = "王月半子" };//引用类型的值传递
            //ChangeName(name);
            //Console.WriteLine(name._name);
            //Console.WriteLine("--------------------------");

            //HomeWork newName = new HomeWork { _name = "王月半子" };//引用类型的引用传递
            //ChangeingName(ref newName);
            //Console.WriteLine(newName._name);



            #endregion

            #region 第一天作业 观察“一起帮”的： 功能作业https://zhuanlan.zhihu.com/p/92362781
            //User of class method. 
            //Entity.User User = new Entity.User();
            //User.Register();
            //User.Login();

            ////problem of class method ( inside null)
            //Entity.Problem Problem = new Entity.Problem();
            //Problem.Publish();

            ////HeloMoney of call method (inside null)

            //Entity.HelpMoney Helomoney = new Entity.HelpMoney();
            //Helomoney.BodyShow();

            #endregion

            #region Secend Day Homework. https://zhuanlan.zhihu.com/p/92470130
            //1.user.Password在类的外部只能改不能读
            //Entity.User Password = new Entity.User();
            //Password.Password = "123456";

            //2.如果user.Name为“admin”，输入时修改为“系统管理员”
            //Entity.User user = new Entity.User();
            //user.UserName = "admin";

            //3.problem.Reward不能为负数
            //Entity.Problem problem = new Entity.Problem();
            //problem.Reward = -1;


            //调用这些类的有参/无参构造函数，生成这些类的对象，调用他们的方法

            //3. 一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写
            //Entity.Problem problem = new Entity.Problem();
            //Console.WriteLine(problem[52]);

            //设计一种方式，保证：每一个Problem对象一定有Body赋值每一个User对象一定有Name和Password赋值
            //Go to (Problem Page) OR (User Page )watch.

            #endregion



        }
    }



}

