# Letterboxd-to-IMDb

[![GitHub stars](https://img.shields.io/github/stars/TobiasPankner/Letterboxd-to-IMDb.svg?style=social&label=Star)](https://GitHub.com/TobiasPankner/Letterboxd-to-IMDb/stargazers/)
[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=3TU2XDBK2JFU4&source=url)

- [前提条件](#prerequisites)
- [运行脚本](#run-the-script)
- [获取 IMDb Cookie](#getting-the-imdb-cookie)
- [常见用例](#common-use-cases)
- [命令行选项](#command-line-options)

将您的 Letterboxd 电影导入 IMDb 的 Python 脚本。  

工作原理：  
脚本首先“访问”您压缩文件中的所有 Letterboxd 链接，并获取对应的 IMDb 页面。这样可以确保评分的是正确的电影。  
之后，使用您的 Cookie 认证对 IMDb 内部 GraphQL 评分 API 的请求。  

**视频教程** 如何使用此脚本：<https://www.youtube.com/watch?v=KF7cfdUTEgw>

## 在线运行此脚本（无需 Python）

[![运行脚本](https://simple-script.com/api/badge/letterboxd-to-imdb)](https://simple-script.com/app/letterboxd-to-imdb)

## 前提条件  
  
- Python 3 ([下载](https://www.python.org/downloads/))
- [Letterboxd](https://letterboxd.com/) 账户
- [IMDb](https://www.imdb.com/) 账户

## 运行脚本

 1. 导出您的 Letterboxd 评分和观看列表（[操作方法](https://listy.is/help/how-to-export-letterboxd-watchlists-reviews/)）
 2. [获取 IMDb Cookie](#getting-the-imdb-cookie) 并保存为脚本文件夹中的 "cookie.txt"
 3. 安装依赖项：`pip install -r requirements.txt`
 4. 运行 letterboxd2imdb.py：`python letterboxd2imdb.py -f <您的 ZIP 文件>.zip`

[常见用例](#common-use-cases)

## 获取 IMDb Cookie

**请像保护密码一样保护此 Cookie！**

  1. 登录您的 IMDb 账户
  2. 打开 Chrome 开发者工具 -> 网络 (Network)
  3. 筛选 Fetch/XHR
  4. 刷新页面
  5. 复制某个请求的 Cookie（右键 -> 复制值）
  
  ![示例](https://imgur.com/chRo9wj.jpg)  

## 常见用例

**转移您的评分和观看列表：**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -w`

**转移您评分为 5/10 的已观看电影：**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -r 5`

**为未评分的已观看电影创建 IMDb 列表：**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l`

**为未评分的已观看电影创建自定义名称的 IMDb 列表：**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l --list-name "My Letterboxd Movies"`

## 命令行选项

```
usage: letterboxd2imdb.py [-h] -f ZIPFILE [-p PARALLEL] [-c] [-r RATING] [-w] [-l] [--list-name LIST_NAME]

Imports your Letterboxd ratings and watchlist into IMDb. Can also create custom lists for unrated movies.

required arguments:
  -f ZIPFILE            The exported zip file from letterboxd

options:
  -h, --help            show this help message and exit
  -p PARALLEL           Urls to be processed in parallel (valid: 1 to 20)
  -c                    Add this flag to disable the history
  -r RATING             The rating to give watched but unrated movies. By default they are ignored (valid: 1 to 10)
  -w                    Add this flag to also transfer your watchlist
  -l                    Create an IMDb list for watched but unrated movies instead of rating them
  --list-name LIST_NAME Name for the IMDb list to create for unrated movies (default: 'Watched on Letterboxd - Unrated')
```
`-p`：如果想加快处理速度可以使用该参数，设置过高可能会导致速率限制。默认值：5  
`-c`：如果历史记录导致问题，可以添加此标志来禁用它。  
`-r`：用于给已观看但未评分的电影评分。由于 IMDb 没有“仅观看”选项，必须指定一个默认评分  
`-w`：用于同时传输你的观看列表  
`-l`：为已观看但未评分的电影创建 IMDb 列表，而不是赋予任意评分。这样可以保持评分数据的整洁，同时跟踪已观看电影。  
`--list-name`：指定使用 `-l` 选项创建的 IMDb 列表的自定义名称。默认值："Watched on Letterboxd - Unrated"  

**注意：** `-r` 和 `-l` 选项互斥。你只能给未评分电影赋默认评分（`-r`）或为它们创建列表（`-l`），不能同时使用。  
  
## 使用示例  
  
**基础导入（仅评分）：**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip`  
*仅从 Letterboxd 导入你的评分电影。未评分电影将被忽略。*  
  
**导入评分和观看列表：**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -w`  
*同时传输你的电影评分和观看列表到 IMDb。*  
  
**给未评分电影赋默认评分：**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -r 7`  
*导入你的评分并给所有已观看但未评分的电影赋默认评分 7/10。*  
  
**为未评分电影创建列表：**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l`  
*为你已观看但未评分的电影创建名为“Watched on Letterboxd - Unrated”的 IMDb 列表。*  
  
**为未评分电影创建自定义名称列表：**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l --list-name "My Letterboxd Backlog"`  
*为你的未评分已观看电影创建带自定义名称的 IMDb 列表。*  
  
**更高并行度的快速处理：**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 15`  
*并行处理 15 部电影以加快执行速度（注意速率限制）。*  
  
**自定义设置的完整传输：**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 10 -r 5 -w`  
*快速处理（10 并行），导入评分和观看列表，给未评分电影赋 5/10 评分。*  


**创建带有观影列表和快速处理的自定义列表：**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 10 -l --list-name "我的 Letterboxd 电影" -w`  
*处理速度快，导入观影列表，并为未评分电影创建自定义命名列表。*  
  
**禁用历史记录（故障排除）：**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -c`  
*运行时不使用历史记录功能，如果您在使用历史文件时遇到问题，此选项非常有用。*  
  
**保守方法（慢但安全）：**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 1 -w`  
*一次处理一部电影，避免在导入评分和观影列表时出现速率限制问题。*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---