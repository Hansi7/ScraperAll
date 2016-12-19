#define outputView
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace XMT281Scraper.Tools
{
    public static class ScraperWorker
    {
        static ScraperWorker()
        {
            getor = Tools.DownLoader.GetDocument;
        }

        static readonly GetDOCUMENT  getor;

        /**
         * 这两个函数还要重新写,目前有点复杂。逻辑还不够清晰。还可以再拆解。
         */
        /// <summary>
        /// 试图重构一下
        /// </summary>
        /// <param name="args"></param>
        public static void workWithTaskFile(string[] args)
        {
            
            List<List<string>> listlist = new List<List<string>>();
            //PrograssBar();
            try
            {
                string EXTRA_COLUMN1 = "未定义1";
                string EXTRA_COLUMN2 = "未定义2";
                string OUTPUT_FILENAME = "OUTPUT " + EXTRA_COLUMN1 + " " + EXTRA_COLUMN2 + ".xlsx";
                string taskJson = "";
#if isdebug
#else


                #region 可能需要的参数

                //args = new string[]{"爱奇艺网络剧.tsk"};
                var argument = CommandLineArgumentParser.Parse(args);

                if (args.Length == 1)
                {
                    taskJson = args[0];
                }
                if (argument.Has("-t"))
                {
                    taskJson = argument.Get("-t").Next;
                }
                else
                {
                    Console.WriteLine("必须指定任务文件的文件名，使用 -t (任务文件.tsk)");
                    return;
                }
                if (argument.Has("-ea"))
                {
                    EXTRA_COLUMN1 = argument.Get("-ea").Next;
                }
                if (argument.Has("-eb"))
                {
                    EXTRA_COLUMN2 = argument.Get("-eb").Next;
                }
                if (argument.Has("-o"))
                {
                    OUTPUT_FILENAME = argument.Get("-o").Next + ".xlsx";
                }
                else
                {
                    OUTPUT_FILENAME = "OUTPUT" + EXTRA_COLUMN1 + " " + EXTRA_COLUMN2 + ".xlsx";
                }
                //自定义的字段？比如爱奇艺.电影等等。

                #endregion
#endif
                //这些参数在任务文件里面写上？

#if isdebug
                taskJson = "text.txt";
#else

#endif
                var taskk = Tools.Serializer.DeSerializeTSK(taskJson);
#if outputView
                Console.WriteLine("读取正常任务文件...ok!");
#endif
                //几个提取器几个列表，先占位。
                //尽管先占位不可靠，因为有SubProcessor，但还是先扩好空间。
                for (int i = 0; i < taskk.Processor.Count; i++)
                {
                    listlist.Add(new List<string>());
                }

                bool firstRound = true;//记录第一轮是否完成，用来确定内存中列表的数量。



                for (int i = taskk.Current; i <= taskk.StarEnd; i= i+ taskk.StarGap)
                {

                    taskk.Current = i;
#if outputView
                    Console.WriteLine("当前进行到页码.............................." + i + "/" + taskk.StarEnd);
#endif
                    for (int j = 0; j < taskk.Processor.Count; j++)
                    {
#if outputView
                        Console.WriteLine("提取器位置..." + (j + 1).ToString() + "/" + taskk.Processor.Count);
#endif
                        //field1 每页的数量
                        var field0 = Tools.Scraper.Scrape(getor(taskk.CurrentURL), taskk.Processor[j]);
#if outputView
                        Console.WriteLine("提取到数据条数===" + field0.Count);
#endif
                        listlist[j].AddRange(field0);
                        //含有子处理器，将field0交给另外个函数处理。处理完毕后保证field0是处理后的结果。
                        if (taskk.Processor[j].SubProcessor!=null && taskk.Processor[j].SubProcessor.Count>0)
                        {

                            Console.WriteLine("发现此项为含有扩展任务...爬取扩展任务~");
                            int subPsrColumn = taskk.Processor.Count;//扩展的SubPsr结果从列序号开始。

                            List<List<string>> subResult = ProcessSub(taskk.Processor[j].SubProcessor, field0);
                            Console.WriteLine("扩展任务完成！");

                            if (firstRound)
                            {
                                //第一次可以这么加入，
                                listlist.AddRange(subResult);
                            }
                            else
                            {
                                //第二次以上的，就要找到那个list，然后续写列表。代码类似如下。
                                for (int k = 0; k < subResult.Count; k++)
                                {
                                    listlist[subPsrColumn++].AddRange(subResult[k]);
                                }
                            }
                        }
#if outputView
                        
                        Console.WriteLine("保存数据.............................OK!");
#endif
                    }
                    firstRound = false; //第一轮结束(此时所有的PSR都走过一遍了！)
                }


                string[] extra1 = new string[listlist[0].Count];
                for (int i = 0; i < extra1.Length; i++)
                {
                    extra1[i] = EXTRA_COLUMN1;
                }
                listlist.Add(extra1.ToList<string>());

                string[] extra2 = new string[listlist[0].Count];
                for (int i = 0; i < extra2.Length; i++)
                {
                    extra2[i] = EXTRA_COLUMN2;
                }
                listlist.Add(extra2.ToList<string>());

                var dt = outputDataTable(listlist);

                //var dtOutput = GenerateTransposedTable(dt);
                //Print(dt);
                Console.Write("保存文件...");
                //Print(dtOutput);
                Tools.ExcelOutput.DataTableToExcel(dt, OUTPUT_FILENAME);
                Console.WriteLine("...成功！");
                Console.WriteLine("=======正在打开文件=========");
                System.Diagnostics.Process.Start(OUTPUT_FILENAME);

            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                System.IO.File.WriteAllText("ERROR@" + DateTime.Now.ToString("yyyyMMdd HHmmss") + ".log", err.ToString());
            }
            Console.WriteLine("按任意键退出...");
            //Console.ReadKey();
        }

        private static List<List<string>> ProcessSub(List<Entities.Processor> prcList, List<string> field0)
        {
            //这个位置有问题呀。
            List<List<string>> llist = new List<List<string>>();

            for (int i = 0; i < prcList.Count; i++)
            {
                llist.Add(new List<string>());
            }
            for (int i = 0; i < field0.Count; i++)
            {
                for (int j = 0; j < prcList.Count; j++)
                {
                    var field1 = Scraper.Scrape(getor(field0[i]), prcList[j]);
                    Console.WriteLine(string.Format("扩展任务已完成：{0}/{1}  {2}/{3}",i+1,field0.Count,j+1,prcList.Count));
                    llist[j].Add(field1[0]);
                }
            }
            return llist;
        }
        public static DataTable outputDataTable(List<List<string>> listOfList)
        {
            var dt = new DataTable();
            for (int i = 0; i < listOfList.Count; i++)//i 列循环
            {
                dt.Columns.Add("C" + i.ToString());//新建一列
                for (int j = 0; j < listOfList[i].Count; j++)
                {
                    if (dt.Rows.Count - 1 < j)
                    {
                        dt.Rows.Add("R" + j.ToString());
                    }
                    dt.Rows[j][i] = listOfList[i][j];
                }
            }
            return dt;
        }

        public static void workWithListFile(string[] args)
        {
            


        }

        public static DataTable GenerateTransposedTable(DataTable inputTable)
        {
            DataTable outputTable = new DataTable();

            // Add columns by looping rows

            // Header row's first column is same as in inputTable
            outputTable.Columns.Add(inputTable.Columns[0].ColumnName.ToString());

            // Header row's second column onwards, 'inputTable's first column taken
            foreach (DataRow inRow in inputTable.Rows)
            {
                string newColName = inRow[0].ToString();
                outputTable.Columns.Add(newColName);
            }

            // Add rows by looping columns        
            for (int rCount = 1; rCount <= inputTable.Columns.Count - 1; rCount++)
            {
                DataRow newRow = outputTable.NewRow();

                // First column is inputTable's Header row's second column
                newRow[0] = inputTable.Columns[rCount].ColumnName.ToString();
                for (int cCount = 0; cCount <= inputTable.Rows.Count - 1; cCount++)
                {
                    string colValue = inputTable.Rows[cCount][rCount].ToString();
                    newRow[cCount + 1] = colValue;
                }
                outputTable.Rows.Add(newRow);
            }

            return outputTable;
        }
        public static void Print(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    Console.Write(row[column] + "\t");
                }
                Console.WriteLine();
            }

        }
        public static void PrograssBar()
        {
            bool isBreak = false;
            ConsoleColor colorBack = Console.BackgroundColor; ConsoleColor colorFore = Console.ForegroundColor;

            //第一行信息             
            Console.WriteLine("*********** jinjazz now working******");

            //第二行绘制进度条背景             
            Console.BackgroundColor = ConsoleColor.DarkCyan; for (int i = 0; ++i <= 25; ) { Console.Write(" "); } Console.WriteLine(" "); Console.BackgroundColor = colorBack;

            //第三行输出进度             
            Console.WriteLine("0%");
            //第四行输出提示,按下回车可以取消当前进度
            Console.WriteLine("<Press Enter To Break.>");

            //-----------------------上面绘制了一个完整的工作区域,下面开始工作

            //开始控制进度条和进度变化 
            for (int i = 0; ++i <= 100; )
            {
                //先检查是否有按键请求,如果有,判断是否为回车键,如果是则退出循环 
                if (Console.KeyAvailable && System.Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    isBreak = true;
                    break;
                }                 //绘制进度条进度                
                Console.BackgroundColor = ConsoleColor.Yellow;//设置进度条颜色                 
                Console.SetCursorPosition(i / 4, 1);
                //设置光标位置,参数为第几列和第几行                 
                Console.Write(" ");//移动进度条                 
                Console.BackgroundColor = colorBack;//恢复输出颜色
                //更新进度百分比,原理同上.                 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(0, 2);
                Console.Write("{0}%", i);
                Console.ForegroundColor = colorFore;
                //模拟实际工作中的延迟,否则进度太快                 
                System.Threading.Thread.Sleep(100);
            }
            //工作完成,根据实际情况输出信息,而且清楚提示退出的信息     
            Console.SetCursorPosition(0, 3);
            Console.Write(isBreak ? "break!!!" : "finished.");
            Console.WriteLine(" ");
            //等待退出             
            Console.ReadKey(true);
        }

        public static void DoWork(string[] args)
        {
            var argument = CommandLineArgumentParser.Parse(args);

            if (argument.Has("-t") && !argument.Has("-l"))
            {
                workWithTaskFile(args);
            }
            if (argument.Has("-l") && argument.Has("-t"))
            {
                workWithListFile(args);
            }
        }
    
    
    }


    delegate HtmlAgilityPack.HtmlDocument GetDOCUMENT(string url);
}
