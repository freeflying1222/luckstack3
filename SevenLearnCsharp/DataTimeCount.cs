﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HomeWork
{
    public class DataTimeCount
    {
        ///栈的学费是按周计费的，所以请实现这两个功能：
        ///1.函数GetDate()，能计算一个日期若干（日/周/月）后的日期
        ///2.给定任意一个年份，就能按周排列显示每周的起始日期，如下图所示：

        //1.函数GetDate()，能计算一个日期若干（日/周/月）后的日期
        public static void GetDate
            (int year, int mouth, int day, int AddYear = 0, int AddMouth = 0, int AddDay = 0)
        {//我预感到了飞起来的一脚,,因为这个东西本身就不用这样做，不知道题目为啥这样。。。。估计又是我没读懂
            DateTime date = new DateTime(year, mouth, day);
            date = date.AddDays(AddDay);
            date = date.AddMonths(AddMouth);
            date = date.AddYears(AddYear);
            Console.WriteLine(date);
        }


        ///2.给定任意一个年份，就能按周排列显示每周的起始日期：

        /// <summary>
        /// 随便输入一个年份，就能按周排列显示每周的起始日期
        /// </summary>
        /// <param name="year">输入一个int类型的年份整数</param>
        public static void GetWeek(int year)
        {

            //这个地方借鉴了LJP大佬的作业，我比较认同这个地方，其他地方我不太想借鉴，不符合我的思路
            DateTime dateTime = new DateTime(year, 1, 1);
            while (dateTime.DayOfWeek == DayOfWeek.Monday)
            {
                dateTime = dateTime.AddDays(1);
            }
            getWeekBody(dateTime);
        }
        /// <summary>
        /// 为GetWeek提供服务，自动调用函数
        /// </summary>
        /// <param name="dateTime"></param>
        private static void getWeekBody(DateTime dateTime)
        {
            int i = 1,year = dateTime.Year;
            while (dateTime.Year == year)
            {
                Console.WriteLine($"第{i}周：{dateTime.ToString("yyyy年MM月dd日")} - {dateTime.AddDays(6).ToString("yyyy年MM月dd日")}\n");
                dateTime = dateTime.AddDays(7);
            }
        }
        
    }

}