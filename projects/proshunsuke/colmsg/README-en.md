> [!WARNING]
> Currently, there is an issue where `refresh_token` cannot be obtained on iOS. This is not a problem with `colmsg` but an effect caused by an update to the messaging app. At present, there is no complete solution for this issue. For Android, please continue to refer to [here](https://github.com/proshunsuke/colmsg/blob/main/doc/how_to_get_refresh_token.md#android%E3%82%A2%E3%83%97%E3%83%AA%E3%81%AE%E5%A0%B4%E5%90%88).

<div align="center">
  <h1><strong>colmsg</strong></h1>
  <img src="https://user-images.githubusercontent.com/3148511/158018437-09822a33-8767-4e03-ba90-e0f69594c493.jpeg" width="32px" alt="Sakurazaka46 Message Logo"><img src="https://user-images.githubusercontent.com/3148511/158018441-dd7cb9eb-bf31-4938-830d-1ef293a2afba.jpg" width="32px" alt="Hinatazaka46 Message Logo"><img src="https://user-images.githubusercontent.com/3148511/158018442-ae54e926-760d-4b47-b0a0-7255485e1f28.jpg" width="32px" alt="Nogizaka46 Message Logo">

  Saves messages from the "Sakurazaka46 Message," "Hinatazaka46 Message," "Nogizaka46 Message," "Asuka Saito Message," "Mai Shiraishi Message," and "yodel" apps to your PC.

  ![demo](https://user-images.githubusercontent.com/3148511/158026220-90735546-2401-40ca-a9e6-89d2176ad3b4.gif)
</div>

## Overview

For how to install `colmsg`, please refer to [here](#installation).

**First of all**, please obtain the refresh_token. For how to obtain it, please refer to [here](https://raw.githubusercontent.com/proshunsuke/colmsg/main/doc/how_to_get_refresh_token.md).

Once obtained, please execute the following.  
Please put the refresh_token obtained from "Sakurazaka46 Message," "Hinatazaka46 Message," "Nogizaka46 Message," "Asuka Saito Message," "Mai Shiraishi Message," and "yodel" into `<s_refresh_token>`, `<h_refresh_token>`, `<n_refresh_token>`, `<a_refresh_token>`, `<m_refresh_token>`, and `<y_refresh_token>`, respectively.  
*Note: You only need to specify the apps you are subscribed to.*

All messages for all time periods of all subscribed members will be saved.  

```shell script
colmsg --s_refresh_token <s_refresh_token> --h_refresh_token <h_refresh_token> --n_refresh_token <n_refresh_token> --a_refresh_token <a_refresh_token> --m_refresh_token <m_refresh_token> --y_refresh_token <y_refresh_token>
```

For Windows, please replace the executable file name with `colmsg.exe`.

## Features

* ✅ No need to root the device
* ✅ Supports both Android and iOS apps
* ✅ Can be run on Windows, macOS, and Linux
* ✅ Various saving methods are available
* ✅ Supports the following app versions
  * "Sakurazaka46 Message": Version 1.12.01.169
  * "Hinatazaka46 Message": Version 2.13.01.169
  * "Nogizaka46 Message": Version 1.8.01.169
  * "Asuka Saito Message": Version 1.1.01.169
  * "Mai Shiraishi Message": Version 3.4.3.426
  * "yodel": Version 4.1.1.455

## Usage

The basic usage was explained in the overview.  
However, since the refresh_token is sensitive information, it is not advisable to input it directly in the terminal.  
Therefore, it is recommended to set the default options in the config file.  
Please refer to [here](#config-file) for details about the config file.  
From here on, it is assumed that the refresh_token is set in the config file.

`colmsg` has several options and allows you to choose various saving methods.

If you want to save messages from a specific member

```shell script
colmsg -n 菅井友香 -n 佐々木久美
```

If you want to save messages from a specific group

```shell script
colmsg -g sakurazaka
```

If you want to save a specific type of message

```shell script
colmsg -k picture -k video
```

If you want to save messages after a specific date and time

```shell script
colmsg -F '2020/01/01 00:00:00'
```
Options can be used in combination. For more detailed explanations, please execute the following to check.


```shell script
colmsg --help
```

## Detailed Specifications

* When the command is executed while some messages are already saved, it retrieves and saves messages posted after the last saved message  
* Saved messages are stored in the following directory structure
  * ```shell script
    colmsg/
    ├── Hinatazaka46 1st Generation
    │   └── Kumi Sasaki
    │       └── 1_0_20191231235959.txt
    ├── Nogizaka46
    │   └── Manatsu Akimoto
    │       └── 2_1_20200101000000.jpg
    └── Sakurazaka46 1st Generation
        └── Yūka Sugai
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
* Messages that have already been saved will not be overwritten

## config file

`colmsg` allows you to specify options in advance in a configuration file.  
You can check the default path by running the following.

```shell script
colmsg --config-dir
```
You can also specify the location of the configuration file in the environment variable `COLMSG_CONFIG_PATH`.

```shell script
export COLMSG_CONFIG_PATH="/path/to/colmsg.conf"
```

### Format

This configuration file is a simple list of command line arguments. You can use `colmsg --help` to view the available options and their values. Additionally, comments can be added using `#`.

Example of a configuration file:

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

## Installation

### Windows

Prebuilt executable files for Windows are compressed in a zip and placed on the [release page](https://github.com/proshunsuke/colmsg/releases).  
Download and extract them using decompression software such as [7-Zip](https://sevenzip.osdn.jp/).  
After extraction, you will get the executable file `colmsg.exe`.  
Run it on [PowerShell](https://docs.microsoft.com/ja-jp/powershell/) or similar.

### macOS

It can be installed via Homebrew.

```shell script
brew tap proshunsuke/colmsg
brew install colmsg
```

### Arch Linux

It can be installed from the [AUR](https://aur.archlinux.org/packages/colmsg/).

```bash
yay -S colmsg
```

### Binary

Built executable files for different architectures have been placed on the [releases page](https://github.com/proshunsuke/colmsg/releases).

## Development

`colmsg` calls external APIs. During development, you can set up a mock server using OpenApi.

```shell
make server/kh
make server/n46
```
By specifying the environment variables `S_BASE_URL`, `H_BASE_URL`, and `N_BASE_URL`, you can make requests to the mock server.


```shell script
S_BASE_URL=http://localhost:8003 H_BASE_URL=http://localhost:8003 N_BASE_URL=http://localhost:8006 cargo run -- -d ~/Downloads/temp/ --help
```

## TODO

* [ ] Automated testing with CI
* [ ] Prepare examples
* [ ] Parallelize message saving process
* [ ] Crate-ify the API client

## License

`colmsg` is distributed under the terms of the MIT License.

For details of the license, please refer to the [LICENSE](https://raw.githubusercontent.com/proshunsuke/colmsg/main/LICENSE.txt) file.

## Notes

Please be aware of the following items under Article 8 (Prohibited Matters) of the app's Terms of Use.

* (16) Accessing or attempting to access this service by means other than the access methods specified by the company
* (17) Accessing or attempting to access this service by automated means (including crawlers and similar technologies)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---