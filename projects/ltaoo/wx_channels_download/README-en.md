# WeChat Video Channel Downloader

Small size, easy to use, supports macOS and Windows systems.

## Update 250913

1. Added a download button on the Video Channel homepage
<br/>
2. Added the `uninstall` command to uninstall the root certificate installed by this tool
<br/>
3. Fixed the issue of blank page when opening long video pages

<details><summary>Click to see more updates</summary>

## Update 250808

1. Fixed the issue of no download button in the new version of WeChat


## Update 250621

1. Optimized the "progress" display effect during download
<br/>
2. Added the `download` command to download and decrypt videos via terminal. It is recommended to use this method for videos over 1GB
<br/>

```bash
# 使用方式
./wx_video_download_xx download --url "视频地址" --key 解密key --filename "文件名"
# 视频地址、文件名参数需要双引号包裹。解密key不用双引号
# 将会下载视频到 `Downloads` 目录，然后解密
```
3. Added a "Print Download Command" button in the "More" menu of the video account  
<br/>  
4. Fixed the issue where some error messages during certificate installation were not in Chinese  


## 250514 Update  

1. Fixed the problem of being unable to download images and videos  

## 25042501 Update  

1. Fixed the issue where downloaded videos could not be played  

## 250425 Update  

1. Fixed the issue of being unable to download videos  

## 250424 Update  

1. Fixed the inconsistency in download button styles  
<br/>  
2. Fixed the issue where clicking the More button did not display the more menu  
<br/>  
3. Added a prompt to run as administrator when Windows startup fails  

## 250215 Update  

1. Display download progress in the console; when progress cannot be obtained, show the number of bytes downloaded  
<br/>  
2. Added cover image download in the "More" menu  
<br/>  
3. Automatically detect the current network device and proxy  
<br/>  
4. Support command line parameters to specify the network device to proxy and the port number used by the program  


```bash
./wx_video_download_xxx --dev=Wi-Fi --port=1080
```

> In general, there is no need to manually specify the device and port number; just run ./wx_video_download_xxx directly.

## 241216 Update

1. Supports downloading live broadcast replays  
<br/>
2. Supports macOS system  
<br/>
Tested and available on WeChat Version 3.8.9 (28564)

Instructions for use on macOS  

```bash
chmod +x ./wx_video_download_darwin_xxx
sudo ./wx_video_download_darwin_xxx
```

At this time, a prompt will appear indicating that the file cannot be opened, requiring you to allow it in the system settings, then re-execute `sudo ./wx_video_download_darwin_xxx`.
<br/>

During the certificate installation process, permission will be requested; just agree. Afterwards, you do not need to use `sudo` to open it, just double-click to run.
<br/>

When closing the `macOS` terminal, please use `Command + c`, otherwise the system proxy may not be canceled, causing network access issues.
<br/>

> If network access is unavailable, please check the system proxy and manually cancel it.

<br/>

## 241106 Update

1. Fixed the issue where videos downloaded on non-first openings could not be played.

Now, when clicking on the "More Recommendations" videos on the page, the downloaded videos can be opened and played normally.
<br>
When the prompt "Decryption failed, download stopped" appears, close all video pages and windows. Reopen, and you can download again.

## 241104 Update

1. Support for downloading videos of different qualities.
<br>
2. Fixed the issue where downloaded videos could not have their progress bar dragged.
<br>
3. Fixed the issue where downloading started before the long video content progress loaded, causing the video to be unplayable or incomplete.
<br>
4. Fixed the issue where some videos were mistakenly identified as images, preventing download.
<br>
5. Fixed the issue where live rooms kept loading indefinitely.

![Download Button 2](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot13.png)

For details on videos of different qualities, see the usage instructions below.

## 241102 Update

Added a "Download Video" button under the "More" dropdown menu to address the issue of missing download buttons due to different detail page layouts.

![Download Button 2](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot10.png)

## Update 241101

No need to manually download and install the certificate anymore.
<br>
Fixed the issue where `lib/jszip.min.js` could not be found during download.

## Update 241031

Encountered the previous issue of being unable to download from the page again; this time changed to downloading a compressed package with the video inside.
Currently works, but cannot guarantee it will continue to do so.

It is recommended to use [WechatVideoSniffer2.0](https://github.com/kanadeblisst00/WechatVideoSniffer2.0) for higher stability.

## Update 241030

When the video account content consists of multiple images, a download button will also appear. Clicking it will download a compressed package containing all the images.

## Update 241022

When a video is deleted, it did not correctly display "Deleted" and remained in the loading state.
The download button style was changed to match other operation buttons.

## Update 241016

The previous version failed to download again; reverting to direct page downloads works fine, possibly related to the WeChat client version, which I do not understand well.
If version 241016 does not work, you can try other versions.
My current WeChat client version is `Weixin 3.9.12.17` and it downloads normally.

## Update 241011

It seems the video account was redesigned again, preventing direct downloads from the page. Changed to copying the video link to the clipboard when clicking the download button, then open it in Chrome or another browser to download.
Also tested many videos that can be downloaded directly without encryption. So if there are encrypted videos, the new version may fail to download.

> Direct downloads on the page are theoretically still possible but much more complicated to implement. Will research this later.

</details>

## Instructions

Download the [binary file](https://github.com/ltaoo/wx_channels_download/releases), **run as administrator**, the first time you open it, it will automatically install the certificate and then start the service.

When the terminal prompts "Service started successfully," it means it is ready to use.

![Normal Use](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot8.png)

> If the certificate is already installed, the installation step will be skipped.

Open the WeChat PC client, click on the video you want to download, and a download button will appear in the row of operation buttons below the video, as shown below

![Video Download Button](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot1.png)

> If not, check if there is a "Download Video" button under "More".<br> > ![Download Button 2](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot10.png)

Wait for the video to start playing, then pause the video, and click the download button to download the video. After a successful download, the downloaded file will be displayed above, and the file name will indicate the video quality.

![Video Download Success](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot2.png)

By default, the first quality video in the dropdown menu will be downloaded. Click "More" to download videos of other qualities, including the original video.

![Download Videos of Different Qualities](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot13.png)
<br>

Different videos show different options here. There is no specific explanation for xWT111, such as what resolution or size it corresponds to.
<br>
After testing, if the original video is 104MB, the largest size here is xWT111 at 17MB, and the smallest is xWT98 at 7MB.

![Different Quality Video Size Statistics](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot14.png)

For reference only.

## FAQ

1. The service is started, but after opening the video details, it keeps loading and there is no log information in the terminal.
<br>
Try pressing `Ctrl+C` once in the terminal.

2. Decryption failed, stop downloading
<br>
Close all video pages and windows. Reopen, then you can download.

## Development Instructions

First start the terminal as an administrator, then run `go run main.go`.

## Packaging

# windows

```bash
go build -o wx_video_download.exe main.go
```

After packaging, `upx` can be used for compression, reducing the size from 17MB to 5MB.

# macOS

```bash
CGO_ENABLED=1 GOOS=darwin SDKROOT=$(xcrun --sdk macosx --show-sdk-path) go build -trimpath -ldflags="-s -w" -o wx_video_download
```

```bash
CGO_ENABLED=1 GOOS=darwin GOARCH=amd64 SDKROOT=$(xcrun --sdk macosx --show-sdk-path) go build -trimpath -ldflags="-s -w" -o wx_video_download
```

## 其他

此程序大部分参考自以下项目代码
<br>
https://github.com/kanadeblisst00/WechatVideoSniffer2.0

此程序的核心实现依赖以下库
<br>
https://github.com/qtgolang/SunnyNet

## 我的赞赏码

如果我的项目对你有所帮助，可以请我喝杯咖啡 ☕️

[![Sponsors](https://sponsorkit-iota.vercel.app/api/sponsors)](https://sponsorkit-iota.vercel.app/api/sponsors)

```text
                 本项目为开源项目
            仅用于技术交流学习和研究的目的
          请遵守法律法规,请勿用作任何非法用途
               否则造成一切后果自负
           若您下载并使用即视为您知晓并同意
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---