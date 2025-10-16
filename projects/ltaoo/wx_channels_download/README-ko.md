# 위챗 비디오 채널 다운로더

용량이 작고 사용이 간편하며 macOS 및 Windows 시스템을 지원합니다.

## 250913 업데이트

1. 비디오 채널 홈 페이지에 다운로드 버튼 추가
<br/>
2. `uninstall` 명령 추가, 본 도구가 설치한 루트 인증서 제거 가능
<br/>
3. 긴 동영상 페이지가 빈 화면으로 나오는 문제 수정

<details><summary>더 많은 업데이트 내용 보기</summary>

## 250808 업데이트

1. 위챗 최신 버전에서 다운로드 버튼이 없는 문제 수정


## 250621 업데이트

1. 다운로드 시 ‘진행률’ 표시 효과 최적화
<br/>
2. `download` 명령 추가, 터미널에서 동영상 다운로드 및 복호화 가능. 1GB 이상 동영상은 이 방식을 권장
<br/>

```bash
# 使用方式
./wx_video_download_xx download --url "视频地址" --key 解密key --filename "文件名"
# 视频地址、文件名参数需要双引号包裹。解密key不用双引号
# 将会下载视频到 `Downloads` 目录，然后解密
```
3、비디오 계정 「더보기」 메뉴에 「인쇄 다운로드 명령」 버튼 추가  
<br/>  
4、설치 인증서 시 일부 오류 메시지가 중국어가 아닌 문제 수정  


## 250514 업데이트  

1、이미지 및 비디오 다운로드 불가 문제 수정  

## 25042501 업데이트  

1、다운로드한 비디오가 재생되지 않는 문제 수정  

## 250425 업데이트  

1、비디오 다운로드 불가 문제 수정  

## 250424 업데이트  

1、다운로드 버튼 스타일 불일치 문제 수정  
<br/>  
2、더보기 버튼 클릭 시 더보기 메뉴가 표시되지 않는 문제 수정  
<br/>  
3、윈도우 시작 실패 시 관리자 권한으로 실행할지 여부 안내 추가  

## 250215 업데이트  

1、콘솔에 다운로드 진행률 표시, 진행률을 알 수 없을 때는 다운로드된 바이트 수 표시  
<br/>  
2、「더보기」 메뉴에 표지 이미지 다운로드 추가  
<br/>  
3、현재 네트워크 장치 자동 감지 및 프록시 적용  
<br/>  
4、명령행 인자로 프록시할 네트워크 장치 및 프로그램에서 사용하는 포트 번호 지정 지원  


```bash
./wx_video_download_xxx --dev=Wi-Fi --port=1080
```
> 일반적으로 장치와 포트 번호를 수동으로 지정할 필요 없이, ./wx_video_download_xxx 를 직접 실행하면 됩니다.

## 241216 업데이트

1. 라이브 방송 재생 다운로드 지원
<br/>
2. macOS 시스템 지원
<br/>
WeChat 버전 3.8.9 (28564)에서 테스트 완료

macOS 사용 설명


```bash
chmod +x ./wx_video_download_darwin_xxx
sudo ./wx_video_download_darwin_xxx
```
이때 파일을 열 수 없다는 메시지가 표시되면 시스템 설정에서 허용한 후, 다시 `sudo ./wx_video_download_darwin_xxx` 명령을 실행하세요.  
<br/>

인증서 설치 과정에서 권한 요청이 나오면 동의하면 됩니다. 이후에는 `sudo` 없이 더블 클릭으로 실행할 수 있습니다.  
<br/>

`macOS` 터미널을 종료할 때는 `Command + c`를 사용하세요. 그렇지 않으면 시스템 프록시가 해제되지 않아 네트워크 접속이 불가능해질 수 있습니다.  
<br/>

> 네트워크 접속이 안 될 경우 시스템 프록시를 확인하고 수동으로 해제하세요.

<br/>

## 241106 업데이트

1. 처음이 아닌 영상이 다운로드 후 재생되지 않는 문제를 수정했습니다.

이제 페이지 상의 「더 많은 추천」 동영상을 클릭해 다운로드한 영상이 정상적으로 재생됩니다.  
<br>
「복호화 실패, 다운로드 중지」 메시지가 뜰 경우 모든 영상 페이지와 창을 닫고 다시 열면 다운로드가 가능합니다.

## 241104 업데이트

1. 다양한 화질의 영상 다운로드를 지원합니다.  
<br>
2. 다운로드한 영상에서 진행바를 드래그할 수 없는 문제를 수정했습니다.  
<br>
3. 긴 영상의 내용이 로드되지 않은 상태에서 다운로드해 영상이 재생되지 않거나 불완전한 문제를 수정했습니다.  
<br>
4. 일부 영상을 이미지로 잘못 판단해 다운로드할 수 없는 문제를 수정했습니다.  
<br>
5. 라이브 방송실이 계속 로딩되는 문제를 수정했습니다.

![다운로드 버튼2](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot13.png)

다양한 화질 영상에 대한 자세한 내용은 아래 사용 설명을 참고하세요.

## 241102 업데이트


「더보기」 드롭다운 메뉴에 「동영상 다운로드」 버튼을 추가하여, 다양한 상세 페이지 레이아웃으로 인해 다운로드 버튼이 없는 문제를 해결했습니다.

![다운로드 버튼2](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot10.png)

## 241101 업데이트

이제 수동으로 인증서를 다운로드하여 설치할 필요가 없습니다.
<br>
다운로드 시 `lib/jszip.min.js` 를 찾을 수 없다는 문제를 수정했습니다.

## 241031 업데이트

이전에 페이지에서 다운로드가 불가능했던 문제가 다시 발생하여, 이번에는 압축 파일로 다운로드하도록 변경했습니다. 동영상은 압축 파일 내에 포함됩니다.
현재는 작동하지만, 앞으로도 계속 작동한다고 보장할 수는 없습니다.

더 안정적인 [WechatVideoSniffer2.0](https://github.com/kanadeblisst00/WechatVideoSniffer2.0) 사용을 권장합니다.

## 241030 업데이트

동영상 콘텐츠가 여러 장의 이미지인 경우에도 다운로드 버튼이 표시됩니다. 클릭하면 모든 이미지를 포함한 압축 파일을 다운로드합니다.

## 241022 업데이트

동영상이 삭제되었을 때 「삭제됨」이 제대로 표시되지 않고 계속 로딩 상태로 남아 있던 문제를 수정했습니다.
다운로드 버튼 스타일을 다른 작업 버튼과 동일하게 변경했습니다.

## 241016 업데이트

이전 버전에서는 다시 다운로드가 불가능했으나, 페이지에서 직접 다운로드하는 방식으로 되돌리니 정상 작동했습니다. 이는 위챗 클라이언트 버전과 관련이 있을 수 있는데, 이 부분은 잘 모릅니다.
만약 241016 버전이 작동하지 않는다면 다른 버전을 시도해 보시기 바랍니다.
현재 제 위챗 클라이언트 버전은 `Weixin 3.9.12.17`이며 정상적으로 다운로드됩니다.

## 241011 업데이트

동영상 채널이 또 다시 개편되어 페이지에서 직접 다운로드가 불가능해졌습니다. 다운로드 버튼을 클릭하면 동영상 링크가 클립보드에 복사되고, 구글이나 다른 브라우저에서 열어 다운로드하도록 변경했습니다.
또한 여러 동영상을 테스트한 결과 대부분 직접 다운로드가 가능하며 암호화된 동영상은 없습니다. 따라서 암호화된 동영상이 있다면 새 버전에서 다운로드 실패할 수 있습니다.

> 페이지에서 직접 다운로드는 이론상 여전히 가능하지만 구현이 훨씬 복잡해져서 나중에 다시 연구해 보겠습니다.

</details>
## 사용 설명

[바이너리 파일](https://github.com/ltaoo/wx_channels_download/releases)을 다운로드하고, **관리자 권한으로 실행**합니다. 처음 실행 시 자동으로 인증서가 설치되고 서비스가 시작됩니다.

터미널에 "서비스가 정상적으로 시작되었습니다"라는 메시지가 나타나면 사용 준비가 완료된 것입니다.

![정상 사용](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot8.png)

> 인증서가 이미 설치되어 있으면 인증서 설치 단계를 건너뜁니다.

위챗 PC 버전을 열고, 다운로드할 동영상을 클릭하면 동영상 아래 조작 버튼 열에 다운로드 버튼이 추가되어 있습니다. 아래와 같이 표시됩니다.

![동영상 다운로드 버튼](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot1.png)

> 만약 없다면 "더보기" 메뉴에 "동영상 다운로드" 버튼이 있는지 확인해 보세요. <br> > ![다운로드 버튼2](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot10.png)

동영상이 재생되기 시작하면 일시정지하고, 다운로드 버튼을 클릭하면 동영상이 다운로드됩니다. 다운로드가 성공하면 상단에 다운로드된 파일이 표시되며, 파일명 끝에 동영상 화질 표시가 붙습니다.

![동영상 다운로드 성공](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot2.png)

기본적으로 드롭다운 메뉴의 첫 번째 화질 동영상을 다운로드합니다. 더보기를 열면 원본 동영상을 포함한 다른 화질 동영상을 다운로드할 수 있습니다.

![다른 화질 동영상 다운로드](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot13.png)
<br>

동영상마다 표시되는 옵션이 다르며, xWT111이 구체적으로 어떤 해상도, 크기인지에 대한 설명은 없습니다.
<br>
테스트 결과, 원본 동영상이 104MB일 때, 가장 큰 크기는 xWT111이 17MB, 가장 작은 크기는 xWT98이 7MB입니다.

![다른 화질 동영상 크기 통계](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot14.png)

참고용입니다.

## 자주 묻는 질문

1. 서비스는 시작되었으나, 동영상 상세 페이지가 계속 로딩 중이고 터미널에 로그가 출력되지 않습니다.
<br>
터미널에서 `Ctrl+C`를 눌러 한 번만 실행을 중단해 보세요.


2、복호화 실패, 다운로드 중지
<br>
모든 비디오 페이지와 창을 닫으세요. 다시 열면 다운로드할 수 있습니다.

## 개발 설명

먼저 관리자 권한으로 터미널을 실행한 후, `go run main.go`를 실행하세요.

## 패키징

# windows

```bash
go build -o wx_video_download.exe main.go
```

패키징 후 `upx`를 사용하여 압축할 수 있으며, 크기를 17MB에서 5MB로 줄일 수 있습니다.

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