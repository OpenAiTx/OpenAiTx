
# Firefox용 WebSerial

Mozilla Firefox 브라우저용 WebSerial API 폴리필

## 소개

이 애드온은 Firefox에서 WebSerial API를 사용할 수 있게 합니다.

시리얼 포트와 통신하기 위해 네이티브 애플리케이션을 사용합니다.

**참고:** 현재 이 애드온은 Windows와 Linux(x86-64)에서만 작동합니다.

## 설치

애드온은 Mozilla 애드온에서 다운로드할 수 있습니다:
[Firefox용 WebSerial](https://addons.mozilla.org/pl/firefox/addon/webserial-for-firefox/).

네이티브 애플리케이션은 먼저 컴퓨터에 설치되어야 합니다. 시리얼 포트를 처음 열 때 GUI에서
네이티브 애플리케이션 다운로드를 제안합니다.

### Windows 설치

.exe 파일은 설치 프로그램입니다 - 실행하여 네이티브 애플리케이션을 설치하세요.

### Linux 설치

스크립트를 실행하세요:


```sh
curl -s -L https://raw.githubusercontent.com/kuba2k2/firefox-webserial/master/native/install/linux_x86_64.sh | bash
```
#### 또는 수동으로 설치하기

1. 다운로드한 파일을 `~/.mozilla/native-messaging-hosts`에 넣으세요  
2. 파일 이름을 `firefox-webserial`로 변경하세요  
3. 실행 권한을 부여하세요: `chmod +x ~/.mozilla/native-messaging-hosts/firefox-webserial`  
4. 동일한 디렉터리에 `io.github.kuba2k2.webserial.json` 파일을 만들고, 다음 내용을 입력하세요:


	```json
	{
		"name": "io.github.kuba2k2.webserial",
		"description": "WebSerial for Firefox",
		"path": "/home/USER/.mozilla/native-messaging-hosts/firefox-webserial",
		"type": "stdio",
		"allowed_extensions": ["webserial@kuba2k2.github.io"]
	}
	```

	`/home/USER`를 본인의 사용자 이름에 맞게 조정하세요.
5. 브라우저를 재시작하고 확장 기능을 사용하세요.

**참고:** Alpine Linux(또는 다른 musl 기반 배포판)에서는 `gcompat`가 설치되어 있어야 합니다.

## 사용법

이 애드온과 함께 Firefox에서 작동할 수 있는 일부 애플리케이션:

- [Spacehuhn 시리얼 터미널](https://serial.huhn.me/)
- [Google Chrome Labs 시리얼 터미널](https://googlechromelabs.github.io/serial-terminal/)
- [Spacehuhn의 ESPWebTool](https://esp.huhn.me/)
- [Espressif의 ESP Tool](https://espressif.github.io/esptool-js/)
- [ESPHome 웹](https://web.esphome.io/)
- [ESPHome의 ESP 웹 도구](https://esphome.github.io/esp-web-tools/)
- [Geoffrey Hunter의 NinjaTerm](https://ninjaterm.mbedded.ninja/)

## 디버깅

디버깅 목적으로 확장 기능에서 생성된 로그를 보려면:

- [about:debugging](about:debugging)를 열고 `이 Firefox`를 클릭하세요
- `WebSerial for Firefox`를 찾아 `검사`를 클릭하세요
- 콘솔에 `window.wsdebug = true`를 입력하세요
- 원하는 웹사이트로 이동하여 시리얼 포트 연결을 시도하면 콘솔에 확장 로그가 표시됩니다.

## 라이선스


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