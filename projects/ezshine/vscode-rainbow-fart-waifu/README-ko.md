# 🌈 레인보우 퍼트 와이푸 (Rainbow Fart Waifu)
![](https://s1.ax1x.com/2020/08/21/dNvHfS.gif)

웹사이트：[https://rfw.jnsii.com](https://rfw.jnsii.com/index_en.html)

언어: [简体中文](./README.zh.md) | English

## 요약

----

이 확장 프로그램의 아이디어는 [@SaekiRaku](https://github.com/SaekiRaku/vscode-rainbow-fart)에서 왔으며, 모든 코드를 새로 작성하였습니다. 모든 보이스패키지와 호환되며, 몇 가지 새로운 기능이 추가되었습니다.

## 특별 감사

---

1. 이 확장에는 [@justkowalski](https://github.com/JustKowalski)의 중국어 보이스 패키지가 포함되어 있습니다. [github에서 더 많은 보이스 패키지를 받을 수 있습니다](https://github.com/topics/rainbow-fart)
2. 이 확장에는 [@James K. Lawless](http://jiml.us)에서 가져온 cmdmp3win.exe가 포함되어 있습니다.
3. 기본 와이푸 모델은 [@二夏](https://erxia207.lofter.com)에서 가져왔습니다. 자신만의 오리지널 와이푸를 디자인하고 싶으시면 그녀에게 연락하세요.
4. 이 확장에는 keysoban이라는 또 다른 와이푸 모델이 포함되어 있으며, [@DenchiSoft](https://twitter.com/DenchiSoft/status/1036017773011525632)에서 오픈소스로 제공되었습니다.

[더 많은 와이푸 모델 받기](https://github.com/ezshine/live2d-model-collections)

## 지원 플랫폼

---

~~~~
MacOS와 Windows10만 지원합니다
~~~~

## Q&A

---

#### _와이푸가 표시되지 않나요?_
> A: [여기서](https://github.com/ezshine/live2d-model-collections) 와이푸 컨테이너를 다운로드해야 합니다. zip 파일을 모두 압축 해제한 후, liv2dplayer.exe를 실행하고, vscode에서 명령어 목록을 호출하여 와이푸 모델을 전환해보세요.

## 매뉴얼, 명령어

---

🌈 레인보우 퍼트 와이푸 명령어 보기

- "보이스 패키지 전환"
- "와이푸 모델 전환"
- "리소스 디렉토리 열기"

> 보이스패키지 또는 모델패키지를 다운로드한 경우, 이 명령어를 사용하여 리소스 디렉토리를 열고 해당 패키지들을 해당 경로에 이동시켜야 합니다.

- "와이푸 컨테이너 및 더 많은 리소스 다운로드"

## 기능

---

1. WebUI를 제거하고, MacOS에서는 'afplay', Windows10에서는 'cmdmp3win'을 사용하여 오디오 파일을 재생합니다.
2. WaifuContainer와 상호작용하여, 데스크탑에 가상 와이푸를 띄워 프로그래밍 시 함께할 수 있습니다.

## 보이스패키지 참고사항

---

~~~~
커스텀 보이스 패키지를 만들거나 인터넷에서 다운로드한 보이스 패키지를 사용할 때의 참고사항
~~~~

1. 'manifest.json'이 아닌 'contributes.json'을 사용하세요.
2. 보이스 내용에 맞게 'contributes.json'에 texts를 추가하세요.

~~~~javascript
"contributes": [
    {
        "keywords": ["function", "=>", "func ", "def "],
        "voices":[
            "function_01.mp3",
            "function_02.mp3",
            "function_03.mp3"
        ],
        "texts":[
            "와우, 콜백 함수 정말 잘 썼어요!",
            "이 함수 이름에 제 이름을 써보는 건 어때요?",
            "아무리 대단한 함수라도, 제가 당신을 좋아하는 마음만큼은 실행할 수 없어요!"
        ]
    }
]
~~~~

## 후원하기

---

이 확장 프로그램이 당신의 프로그래밍을 더 즐겁게 만들었다면, 콜라 한 잔 사주실래요?

![](https://raw.githubusercontent.com/ezshine/vscode-rainbow-fart-waifu/master/resources/donate.jpg)

**즐기세요!**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---