> [!WARNING]
> 目前在iOS上出现无法获取`refresh_token`的问题。这不是`colmsg`的问题，而是消息应用程序更新导致的影响。目前对此问题尚无完全解决方案。Android用户请继续参考[这里](https://github.com/proshunsuke/colmsg/blob/main/doc/how_to_get_refresh_token.md#android%E3%82%A2%E3%83%97%E3%83%AA%E3%81%AE%E5%A0%B4%E5%90%88)。

<div align="center">
  <h1><strong>colmsg</strong></h1>
  <img src="https://user-images.githubusercontent.com/3148511/158018437-09822a33-8767-4e03-ba90-e0f69594c493.jpeg" width="32px" alt="樱坂46消息的徽标"><img src="https://user-images.githubusercontent.com/3148511/158018441-dd7cb9eb-bf31-4938-830d-1ef293a2afba.jpg" width="32px" alt="日向坂46消息的徽标"><img src="https://user-images.githubusercontent.com/3148511/158018442-ae54e926-760d-4b47-b0a0-7255485e1f28.jpg" width="32px" alt="乃木坂46消息的徽标">

  保存“樱坂46消息”“日向坂46消息”“乃木坂46消息”“斋藤飞鸟消息”“白石麻衣消息”“yodel”应用的消息到电脑。

  ![demo](https://user-images.githubusercontent.com/3148511/158026220-90735546-2401-40ca-a9e6-89d2176ad3b4.gif)
</div>

## 概要

`colmsg` 的安装方法请参照[这里](#インストール)。

**首先**请获取refresh_token。获取方法请参照[这里](https://raw.githubusercontent.com/proshunsuke/colmsg/main/doc/how_to_get_refresh_token.md)。

获取后请执行以下操作。  
请将“樱坂46消息”“日向坂46消息”“乃木坂46消息”“斋藤飞鸟消息”“白石麻衣消息”“yodel”分别获取的refresh_token填入`<s_refresh_token>` , `<h_refresh_token>` , `<n_refresh_token>` , `<a_refresh_token>` , `<m_refresh_token>` , `<y_refresh_token>`。  
※ 只需指定您订阅的应用即可。

将保存您订阅的所有成员的所有期间的消息。  

```shell script
colmsg --s_refresh_token <s_refresh_token> --h_refresh_token <h_refresh_token> --n_refresh_token <n_refresh_token> --a_refresh_token <a_refresh_token> --m_refresh_token <m_refresh_token> --y_refresh_token <y_refresh_token>
```
Windows 的话请将可执行文件名替换为 `colmsg.exe`。

## 特点

* ✅ 无需对终端进行root
* ✅ 支持Android和iOS应用
* ✅ 可在Windows、macOS、Linux上运行
* ✅ 可选择多种保存方式
* ✅ 支持以下应用版本
  * 「樱坂46消息」: 版本1.12.01.169
  * 「日向坂46消息」: 版本2.13.01.169
  * 「乃木坂46消息」: 版本1.8.01.169
  * 「斋藤飞鸟消息」: 版本1.1.01.169
  * 「白石麻衣消息」: 版本3.4.3.426
  * 「yodel」: 版本4.1.1.455

## 使用方法

概要中已说明基本的使用方法。  
但是，refresh_token 是敏感信息，直接在终端输入并不太安全。  
因此，建议在 config 文件中设置默认选项。  
有关 config 文件，请参见[这里](#config文件)。  
以下假设 config 文件中已设置了 refresh_token。

`colmsg` 有多个选项，可选择多种保存方式。

如果想保存特定成员的消息


```shell script
colmsg -n 菅井友香 -n 佐々木久美
```
如果您想保存特定群组的消息


```shell script
colmsg -g sakurazaka
```

如果您想保存特定类型的消息

```shell script
colmsg -k picture -k video
```

如果想要保存特定日期之后的消息

```shell script
colmsg -F '2020/01/01 00:00:00'
```
选项可以组合使用。有关更详细的说明，请执行以下操作进行确认。


```shell script
colmsg --help
```

## 详细规格

* 如果已经保存了一些消息，再次执行命令时，会获取并保存最后保存的消息之后的消息  
* 保存的消息将按照以下目录结构保存
  * ```shell script
    colmsg/
    ├── 日向坂46 一期生
    │   └── 佐々木久美
    │       └── 1_0_20191231235959.txt
    ├── 乃木坂46
    │   └── 秋元真夏
    │       └── 2_1_20200101000000.jpg
    └── 櫻坂46 一期生
        └── 菅井友香
            ├── 3_2_20200101000001.mp4
            └── 4_3_20200101000002.mp4
    ```
* ファイル名の形式は `<シーケンス番号>_<種類>_<日付>.<拡張子>` となっています
  * シーケンス番号はメッセージの時系列を表す番号になっています。若い数字程昔のメッセージです。ファイルブラウザで辞書順に並べると保存したメッセージが時系列通りに並びます
  * 種類の数字は以下のように対応しています
    * 0: テキストメッセージ
    * 1: 画像
    * 2: 動画
    * 3: ボイス
    * 4: リンク
* 各環境毎のデフォルトの保存先は以下を実行することで確認することが出来ます
  * ```shell script
    colmsg --download-dir
    ```
* 已保存的消息不会被覆盖保存

## 配置文件

`colmsg` 可以通过配置文件预先指定选项。  
默认路径可以通过执行以下命令进行确认。

```shell script
colmsg --config-dir
```
此外，也可以在环境变量 `COLMSG_CONFIG_PATH` 中明确指定配置文件的位置。

```shell script
export COLMSG_CONFIG_PATH="/path/to/colmsg.conf"
```

### 格式

此配置文件是命令行参数的简单列表。使用 `colmsg --help` 可以查看可用选项及其值。还可以通过 `#` 添加注释。

配置文件示例:

```bash
# s_refresh_tokenを指定
--s_refresh_token s_refresh_token

# h_refresh_tokenを指定
--h_refresh_token h_refresh_token

# n_refresh_tokenを指定
--n_refresh_token n_refresh_token

# a_refresh_tokenを指定
--a_refresh_token a_refresh_token

# m_refresh_tokenを指定
--m_refresh_token m_refresh_token

# y_refresh_tokenを指定
--y_refresh_token y_refresh_token

# メディアファイルだけ保存するように設定
-k picture -k video -k voice
```

## 安装

### Windows

我们将为Windows构建的可执行文件压缩成zip文件并放置在[发布页面](https://github.com/proshunsuke/colmsg/releases)。  
请下载后使用[7-Zip](https://sevenzip.osdn.jp/)等解压软件进行解压。  
解压后可以获得可执行文件 `colmsg.exe`。  
请在[PowerShell](https://docs.microsoft.com/ja-jp/powershell/)等环境中运行。

### macOS

可以通过Homebrew进行安装。

```shell script
brew tap proshunsuke/colmsg
brew install colmsg
```

### Arch Linux

可以从[AUR](https://aur.archlinux.org/packages/colmsg/)安装。

```bash
yay -S colmsg
```

### 二进制文件

为不同架构的已构建可执行文件已放置在[发布页面](https://github.com/proshunsuke/colmsg/releases)。

## 开发

`colmsg` 会调用外部API。开发时可以使用OpenApi搭建模拟服务器。

```shell
make server/kh
make server/n46
```
通过指定环境变量 `S_BASE_URL`、`H_BASE_URL`、`N_BASE_URL`，可以向模拟服务器发送请求。


```shell script
S_BASE_URL=http://localhost:8003 H_BASE_URL=http://localhost:8003 N_BASE_URL=http://localhost:8006 cargo run -- -d ~/Downloads/temp/ --help
```

## TODO

* [ ] 通过 CI 进行自动测试
* [ ] 准备示例
* [ ] 消息保存处理的并行化
* [ ] 将 api client 制作成 crate

## 许可证

`colmsg` 在 MIT 许可证条款下分发。

有关许可证的详细信息，请参阅 [LICENSE](https://raw.githubusercontent.com/proshunsuke/colmsg/main/LICENSE.txt) 文件。

## 注意事项

应用程序使用条款第8条（禁止事项）包含以下内容，请注意。

* (16) 通过本公司指定的访问方法以外的手段访问或尝试访问本服务的行为
* (17) 使用自动化手段（包括爬虫及类似技术）访问或尝试访问本服务的行为 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---