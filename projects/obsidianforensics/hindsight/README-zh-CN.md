<img src="https://raw.githubusercontent.com/obsidianforensics/hindsight/main/./pyhindsight/static/h.png" height="100px"/> Hindsight
=========

Google Chrome/Chromium 的互联网历史取证工具

Hindsight 是一个用于分析网页痕迹的免费工具。它最初针对谷歌浏览器的浏览历史开发，现已扩展支持其他基于 Chromium 的应用程序（未来还会支持更多！）。Hindsight 能解析多种网页痕迹类型，包括 URL、下载历史、缓存记录、书签、自动填充记录、已保存密码、偏好设置、浏览器扩展、HTTP Cookies 以及本地存储记录（HTML5 Cookies）。数据从各个文件中提取后，会与其他历史文件中的数据进行关联，并放入时间线上。

它有一个简单的网页用户界面——启动方法是运行 “hindsight_gui.py”（Windows 系统可运行打包好的 “hindsight_gui.exe”），然后在浏览器中访问 http://localhost:8080 ：  

<img src="https://raw.githubusercontent.com/obsidianforensics/hindsight/main/documentation/interface-v2.gif"/>

唯一必须填写的字段是 “Profile Path”。这是你想分析的 Chrome 配置文件的位置（不同操作系统的默认配置文件路径列在本页底部）。点击 “Run”，你将进入结果页面，可以将结果保存为电子表格（或其他格式）。

## 手动安装

要安装 Hindsight（包括命令行工具和网页界面），请执行：
```sh
pip install pyhindsight
pip install git+https://github.com/cclgroupltd/ccl_chromium_reader.git
```
如果您想在 Hindsight 网页界面中使用“在浏览器中查看 SQLite 数据库”功能，您需要运行另一个安装命令：

```sh
curl -sSL https://raw.githubusercontent.com/obsidianforensics/hindsight/master/install-js.sh | sh
```
## 命令行

Hindsight 还有命令行版本 - hindsight.py 或 hindsight.exe。文档文件夹中的用户指南涵盖了许多主题，以下信息应能帮助您开始使用命令行版本：

示例用法：  \> C:\\hindsight.py -i "C:\Users\Ryan\AppData\Local\Google\Chrome\User Data\Default" -o test_case

命令行选项：

| 选项           | 说明                                                     |
| -------------- | ------------------------------------------------------- |
| -i 或 --input  | Chrome(ium) “Default” 目录的路径                        |
| -o 或 --output | 输出文件名（不含扩展名）                                 |
| -f 或 --format | 输出格式（默认是 XLSX，其他选项为 SQLite 和 JSONL）     |
| -c 或 --cache  | 缓存目录路径；仅当目录在指定的 “input” 目录之外时需要。Mac 系统默认如此设置。 |
| -b 或 --browser_type | 输入文件所属浏览器类型。支持的选项有 Chrome（默认）和 Brave。 |
| -l 或 --log	 | Hindsight 日志记录位置（如果存在则追加）                |
| -h 或 --help   | 显示这些选项和默认的 Chrome 数据位置                    |
| -t 或 --timezone | 在 XLSX 输出中显示时间戳的时区                           |

## 默认配置文件路径

Chrome 默认配置文件夹的默认位置为：
* WinXP:   \[userdir\]\Local Settings\Application Data\Google\Chrome\User Data\Default
* Vista/7/8/10: \[userdir\]\AppData\Local\Google\Chrome\User Data\Default
* Linux:   \[userdir\]/.config/google-chrome/Default
* OS X:    \[userdir\]/Library/Application Support/Google/Chrome/Default
* iOS:   \Applications\com.google.chrome.ios\Library\Application Support\Google\Chrome\Default
* Android: /userdata/data/com.android.chrome/app_chrome/Default
* CrOS: \home\user\\<GUID\>

## 功能请求

如果您有新功能的想法（或发现某些功能有问题），请[提交问题](https://github.com/obsidianforensics/hindsight/issues/new/choose)。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---