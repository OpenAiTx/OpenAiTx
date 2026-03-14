# BookBounty

![Build Status](https://github.com/TheWicklowWolf/BookBounty/actions/workflows/main.yml/badge.svg)
![Docker Pulls](https://img.shields.io/docker/pulls/thewicklowwolf/bookbounty.svg)

<img src="/src/static/bookbounty.png" alt="image">


BookBounty is a tool for finding missing Readarr books.


## Run using docker-compose

```yaml
services:
  bookbounty:
    image: thewicklowwolf/bookbounty:latest
    container_name: bookbounty
    ports:
      - 5000:5000
    volumes:
      - /path/to/config:/bookbounty/config
      - /path/to/downloads:/bookbounty/downloads
      - /etc/localtime:/etc/localtime:ro
    restart: unless-stopped

```
---

## 通过环境变量配置

某些值可以通过环境变量设置：

* __PUID__：运行应用程序的用户ID。默认值为 `1000`。
* __PGID__：运行应用程序的组ID。默认值为 `1000`。
* __readarr_address__：Readarr 的 URL。默认值为 `http://192.168.1.2:8787`。
* __readarr_api_key__：Readarr 的 API 密钥。默认值为空 ` `。
* __libgen_address__：Library Genesis 的 URL。目前唯一支持的 URL 是 `http://libgen.is`。
* __sleep_interval__：下载之间的休眠间隔（秒）。默认值为 `0`。
* __sync_schedule__：运行同步的计划小时，例如 14 表示下午2点（24小时制，逗号分隔）。默认值为空 ` `。
* __minimum_match_ratio__：匹配的最低百分比。默认值为 `90`。
* __selected_path_type__：选择下载结构（文件或文件夹）。默认值为 `file`。
* __search_type__：选择搜索类型（小说或非小说）。默认值为 `fiction`。
* __library_scan_on_completion__：完成后是否扫描 Readarr 库。默认值为 `True`。
* __request_timeout__：请求超时时间（秒）。默认值为 `120`。
* __thread_limit__：最大线程数。默认值为 `1`。
* __selected_language__：按语言过滤下载（特定语言或所有语言）。默认值为 `English`。当 BookBounty 无法从 Readarr 元数据配置文件获取语言时使用。
* __preferred_extensions_fiction__：按扩展名过滤小说下载（逗号分隔）。默认值为 `.epub, .mobi, .azw3, .djvu`。
* __preferred_extensions_non_fiction__：按扩展名过滤非小说下载（逗号分隔）。默认值为 `.pdf .epub, .mobi, .azw3, .djvu`。
* __search_last_name_only__：仅在搜索中使用作者的姓氏。默认值为 `False`。
* __search_shortened_title__：搜索时使用缩短标题（去除 `:` 后的所有内容）。默认值为 `False`。

## 同步计划

使用逗号分隔的小时列表来启动同步（例如 `2, 20` 表示在凌晨2点和晚上8点启动同步）。
> 注意：计划开始时间存在最多10分钟的死区。

## Readarr 集成

您有两种方式将 BookBounty 与 Readarr 集成：

1. 直接将 `/bookbounty/downloads` 映射到您的主要 Readarr 文件夹，并配置 `selected_path_type=folder`。  
   此方法会尝试创建正确的文件夹结构（`/author/book/filename.ext` 等），然后直接将文件下载到各自的文件夹中。

2. 或者，将 `/bookbounty/downloads` 映射到一个 `_unprocessed` 文件夹，并设置 `selected_path_type=file`。


   This method downloads all files into a single folder. After a library scan in Readarr, some files may remain unmapped and require manual import.  
   After importing, you can use the "**Rename Files**" function in Readarr to organize the files into the correct folders.

For both methods, setting `library_scan_on_completion=True` automates the import process in Readarr.

**Note:** Readarr does not automatically rename files upon import.


---


<img src="/src/static/dark.png" alt="image">


---


<img src="/src/static/light.png" alt="image">


---

https://hub.docker.com/r/thewicklowwolf/bookbounty



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-14

---