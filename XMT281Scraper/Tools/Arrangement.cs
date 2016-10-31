using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMT281Scraper.Tools
{
    public class Arrangement<T> where T: class
    {
        //public Arrangement<T>

        public Arrangement(List<T> datasource)
        {
            data = datasource;
            Result = new List<T>();
        }
        private List<T> data { get; set; }
        public List<T> Result { get; set; }

        public List<List<T>> QueueAll(int queueLong,T seperater)
        {
            Queue<T>(data, queueLong, new List<T>(), Result, seperater);
            List<List<T>> res = new List<List<T>>();
            List<T> l1 = new List<T>();
            foreach (var item in Result)
            {
                if (item != seperater)
                {
                    l1.Add(item);
                }
                else
	            {                    
                    res.Add(l1);
                    l1 = new List<T>();

	            }
            }
            res.Add(l1);
            return res;
        }
        ///
        /// <summary>
        /// 来一个全排列
        /// </summary>
        /// <param name="list">要排列的可用对象源</param>
        /// <param name="queueLong">排列的长度</param>
        /// <param name="preObject">输入一个空的List</param>
        /// <param name="ouput">请输入一个空的List，并保留这个List的引用，执行完毕后它将是执行结果</param>
        /// <param name="seperater">是否在列表中包含一个特殊对象，用来分组每次产生队列的结果，如果为False，需要手动分组，每n个分组，n是队列长度queueLong</param>
        private void Queue<T>(List<T> list, int queueLong, List<T> preObject, List<T> ouput,T seperater) 
        {
            //StringBuilder sb = new StringBuilder();
            if (queueLong == 1)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    List<T> l = new List<T>();
                    l.AddRange(preObject);
                    l.Add(list[i]);
                    ouput.AddRange(l);
                    //if (seperater!=null)
                    //{
                        //添加分隔符
                        ouput.Add(seperater);
                    //}
                }
            }
            if (queueLong >= 2)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    List<T> k = new List<T>();
                    k.AddRange(preObject);
                    k.Add(list[i]);
                    Queue(list, queueLong - 1, k, ouput,seperater);
                }
            }
        }
        /// <summary>
        /// 分段输出一个列表
        /// </summary>
        /// <param name="input">输入要分段的列表</param>
        /// <param name="countInGroup">每多少个元素分成一组，要分段的列表总数要是他的整数倍</param>
        /// <param name="groupIndex">输出第几组数据</param>
        /// <returns></returns>
        private static List<T> GetQueue<T>(List<T> input,int countInGroup,int groupIndex)
        {
            List<T> list = new List<T>();
            //groupIndex
            //1 012
            //2 345

            for (int i = groupIndex * countInGroup; i < groupIndex * countInGroup + 3; i++)
            {
                list.Add(input[i]);
            }
            return list;


            //for (int i = 0; i < input.Count; i++)
            //{
            //    if (i % countInGroup == (countInGroup - 1))
            //    {
            //        Console.WriteLine(input[i].ToString());
            //    }
            //    else
            //    {
            //        Console.Write(input[i].ToString());
            //    }
            //}
        }
    }
}
