# 윈도우용 Warpinator (비공식)

이것은 윈도우 7 이상용으로 리눅스 민트의 파일 공유 도구 [Warpinator](https://github.com/linuxmint/warpinator)를 비공식 재구현한 것입니다.

리눅스, 윈도우, 안드로이드 기기 간 파일 전송

## ⚠️ 경고: 가짜/악성 웹사이트

`http://warpinator.com`은 가짜 웹사이트이며, 잠재적으로 악성입니다!

여기서 어떤 소프트웨어도 다운로드하거나 실행하지 마십시오!

누가 운영하는지 알 수 없습니다. [리눅스 민트 팀의 공지](https://github.com/linuxmint/warpinator?tab=readme-ov-file#%EF%B8%8F-warning-fakemalicious-website)를 참조하세요.

## 다운로드
현재 [릴리즈](https://github.com/slowscript/warpinator-windows/releases) 페이지에서 이용 가능

또는 winget으로 설치 가능:  
`winget install slowscript.Warpinator`

## 빌드
.NET SDK 4.7.2 필요

Visual Studio로 빌드

### 스크린샷
![screenshot](https://raw.githubusercontent.com/slowscript/warpinator-windows/master/screenshot.png)

## 번역하기
최신 버전의 Visual Studio가 필요합니다  
1) Resources 폴더에 Strings.xx.resx라는 새 리소스 파일을 만드십시오. 여기서 xx는 번역하려는 언어 코드입니다  
2) Strings.resx의 전체 테이블을 복사하여 값들을 번역합니다. 주석은 문맥 설명용입니다  
3) Controls\TransferPanel, Form1, SettingsForm, TransferForm을 디자이너에서 열고 각 파일에 대해 4-6단계를 반복합니다  
4) 최상위 요소(전체 창)를 선택하고 속성에서 Language를 번역할 언어로 변경합니다  
5) 텍스트가 있는 컨트롤(버튼, 라벨, 메뉴)을 선택하고 "Text" 속성을 번역합니다. 런타임에 대체될 명확한 자리 표시자는 번역할 필요 없습니다. 애플리케이션을 실행해(툴바의 녹색 재생 화살표) 확인할 수 있습니다. 또한, TransferPanel의 두 버튼은 다른 두 버튼 아래에 숨겨져 있습니다.  
6) 새 문자열에 맞게 컨트롤을 이동하거나 크기 조정할 수 있으며, 이는 선택된 언어에만 영향을 줍니다


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-20

---