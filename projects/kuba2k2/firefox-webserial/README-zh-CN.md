
# Firefox 的 WebSerial

适用于 Mozilla Firefox 浏览器的 WebSerial API 补充插件

## 介绍

此插件允许在 Firefox 中使用 WebSerial API。

它使用本地应用程序与串口通信。

**注意：** 目前，该插件仅支持 Windows 和 Linux（x86-64）。

## 安装

该插件可从 Mozilla 附加组件下载：
[Firefox 的 WebSerial](https://addons.mozilla.org/pl/firefox/addon/webserial-for-firefox/)。

本地应用程序需要先安装在计算机上。首次尝试打开串口时，GUI 会提示下载
本地应用程序。

### Windows 安装

.exe 文件是安装程序 - 只需打开它并安装本地应用程序。

### Linux 安装

运行脚本：


```sh
curl -s -L https://raw.githubusercontent.com/kuba2k2/firefox-webserial/master/native/install/linux_x86_64.sh | bash
```
#### 或手动安装

1. 将下载的文件放入 `~/.mozilla/native-messaging-hosts`
2. 重命名为 `firefox-webserial`。
3. 使其可执行：`chmod +x ~/.mozilla/native-messaging-hosts/firefox-webserial`。
4. 在同一目录下创建一个名为 `io.github.kuba2k2.webserial.json` 的文件，内容如下：


	```json
	{
		"name": "io.github.kuba2k2.webserial",
		"description": "WebSerial for Firefox",
		"path": "/home/USER/.mozilla/native-messaging-hosts/firefox-webserial",
		"type": "stdio",
		"allowed_extensions": ["webserial@kuba2k2.github.io"]
	}
	```
	调整 `/home/USER` 以匹配您的用户名。
5. 重启浏览器并使用该扩展。

**注意：** 在 Alpine Linux（或其他基于 musl 的发行版）上，您需要安装 `gcompat`。

## 使用方法

一些可在 Firefox 上通过此附加组件运行的应用程序：

- [Spacehuhn 串口终端](https://serial.huhn.me/)
- [Google Chrome Labs 串口终端](https://googlechromelabs.github.io/serial-terminal/)
- [Spacehuhn 的 ESPWebTool](https://esp.huhn.me/)
- [Espressif 的 ESP 工具](https://espressif.github.io/esptool-js/)
- [ESPHome Web](https://web.esphome.io/)
- [ESPHome 的 ESP Web 工具](https://esphome.github.io/esp-web-tools/)
- [Geoffrey Hunter 的 NinjaTerm](https://ninjaterm.mbedded.ninja/)

## 调试

查看扩展产生的日志以进行调试：

- 打开 [about:debugging](about:debugging)，点击 `This Firefox`
- 找到 `WebSerial for Firefox`，点击 `Inspect`
- 在控制台输入：`window.wsdebug = true`
- 访问任意网站，尝试连接串口——控制台应显示扩展日志。

## 许可证

```
MIT License

Copyright (c) 2023 Kuba Szczodrzyński

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---