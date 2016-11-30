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
ScrapeWorker -l d:\urls.txt -p 优酷标题.psr 优酷导演.psr 优酷网址.psr -ea 优酷网 -eb 香港电影
