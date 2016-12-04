爬去网上数据并输出结果

用法一：
ScrapeWorker [-t takfile] [-ea 备注列] [-eb 备注列]

-t  takefile     指定一个任务文件进行爬取。
-ea 备注列a       备注列a将会出现在生成的列表的最后
-eb 备注列b       备注列b将会出现在生成的列表的最后

例如：
ScrapeWorker -t d:\youku.tsk -ea 优酷网 -eb 网络电影


用法二：
ScrapeWorker [-l listfile] [-p psr文件1 psr文件2 ...] [-ea 备注列] [-eb 备注列]

-l  listfile      指定一个URL列表文件进行爬取。
-p  psr文件       指定一个或者多个psr文件。

例如：
ScrapeWorker -l d:\urls.txt -t 优酷香港电影.tsk -ea 优酷网 -eb 香港电影



TODO:
1.本地一个Sqlite数据库
2.结果入表
3.输出结果就是查询

4.爬取得输出结果是一个DataTable对象最好。
5.当一个Processor的结果是一个网址且含有一个SubProcessor，那么继续执行SubProcessor，将结果命名为此Processor的结果。
【避免出现List<Processor>，但是会增加工作量】
