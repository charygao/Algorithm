﻿using System;

namespace Algorithm
{
    /// <summary>
    /// 排序算法汇总 模块
    /// 所有排序算法均是以从小到大为例的
    /// </summary>
    class SortProgram
    {
        public static void Test()
        {
            // new BubbleSort.Solution().Test();                                  // 冒泡排序
            // new QuickSort.Solution().Test();                                   // 冒泡排序
            // new SimpleInsertionSort.Solution().Test();                         // 简单插入排序
            new ShellSort.Solution().Test();                                   // 希尔排序
        }
    }
}
