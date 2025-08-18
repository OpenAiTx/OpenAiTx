# 안녕하세요, 저는 WxBotClient 입니다 <img width="30px" src="https://media.tenor.com/images/3b388fe03da271d2674faf85eb7c3fcd/tenor.gif" />
저는 electron, wechaty, vue를 기반으로 개발된 오픈소스 위챗 위탁 소프트웨어이며, 현재 ChatGPT가 접목되어 있습니다. 빌드된 설치 패키지는 바로 사용할 수 있고, 복잡한 환경에 의존하지 않으며, 위탁 프로그램이 임의로 연결이 끊기지 않아 안정적이고 신뢰할 수 있습니다.

<img align="right" height="200" src="https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./src/assets/icons/icon.png" />

---
## 구축 방법
### 다운로드&설치
[릴리즈 패키지 다운로드 주소](https://github.com/WhiteWatson/wx-bot-client/releases), 여기서 이미 빌드된 **.exe 설치 패키지(윈도우용)** 를 다운로드할 수 있습니다. 다운로드 중에 소프트웨어가 파일이 안전하지 않다고 경고할 수 있으나, 이 경고는 무시해도 됩니다. 다운로드가 완료되면 로컬에서 설치하면 됩니다.

### 위챗 위탁하기
소프트웨어를 열고, **시작하기** 버튼을 클릭하세요. 팝업 창에 당신의 openAI APIKey를 입력합니다.

![markdown picture](https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./doc/images/one.png)

![markdown picture](https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./doc/images/apikeyinput.png)

입력 완료 후 **지금 바로, 로봇 시작하기**를 클릭하고 QR 코드가 나타날 때까지 기다리세요. QR 코드가 나타나면 위챗으로 스캔하여 로그인하고 위챗을 위탁할 수 있습니다.

팁: 국내에서 사용 시 VPN을 사용해야 하며, 그렇지 않으면 API가 통과되지 않아 AI가 계속 생각 중 상태에 머무를 수 있습니다.

### 로봇 기본 설정
로그인에 성공하면 로봇 관리 백엔드에 진입합니다. 좌측에서 **GPT 설정** 메뉴를 클릭하면 기본 로봇 설정을 볼 수 있습니다.

**AI 트리거 단어**에서 로봇의 트리거 단어를 수정할 수 있습니다.

**AI 그룹채팅, AI 개인채팅**에서는 로봇이 서비스를 제공할 그룹채팅 또는 위챗 사용자를 지정할 수 있습니다.

![markdown picture](https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./doc/images/gptsetting.png)

---
## 기능 소개
### AI 문자 대화 능력

```
提问格式： @AI + 问题内容

例：@AI 你是谁？
```
### AI 생성 이미지 능력

```
提问格式： /image + 图片提示词

例：/image 一个骑马的人
```
tips: AI가 금지된 이미지를 쉽게 생성할 수 있으므로, 로봇은 직접 이미지 링크를 전송하며 링크는 유효 기간이 있습니다.

---

## 사용자 정의 배포
이 프로젝트는 로컬에서 node 환경에 의존합니다.

### 의존성 설치

여기서는 반드시 yarn 또는 pnpm을 사용하여 의존성을 설치해야 합니다.
```
yarn install
```
### ChatGPT 접속 및 로컬 실행 프로젝트:


```
npm run electron:serve
```

### 클라이언트 설치 패키지 패키징:
```
npm run electron:build
```
### 프로젝트에서 openAI APIKey 설정하기
`/src/bot/config.ts` 경로로 이동하여, [openAi 공식 API 신청 페이지](https://platform.openai.com/account/api-keys)에서 받은 `Organization`과 `APIKey`를 `setApiKey` 함수에 입력합니다.

### 문제가 발생하면 [이 문서를 먼저 참조하세요](https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./doc/problem.md)

---
## 저는 컴퓨터 공학과 학생입니다  

- 👨‍💻 현재 JavaScript, Vue 등의 웹 개발 기술을 공부하고 있습니다.
- 💪🏼 미래 목표: 더 많은 기술을 배우고 새로운 아이디어를 계속 창조하는 것.
- ⚡ 재미있는 사실: 저는 원신(Genshin Impact)을 즐겨 합니다.

### 특별히 leeguiyu@qq.com 님이 제작한 아이콘에 감사드립니다.

### 사용 언어 및 도구 🛠 

![JavaScript](https://img.shields.io/badge/-JavaScript-%23F7DF1C?style=flat-square&logo=javascript&logoColor=000000&labelColor=%23F7DF1C&color=%23FFCE5A)
![HTML5](https://img.shields.io/badge/-HTML5-%23E44D27?style=flat-square&logo=html5&logoColor=ffffff)
![CSS3](https://img.shields.io/badge/-CSS3-%231572B6?style=flat-square&logo=css3)
![Sass](https://img.shields.io/badge/-Sass-%23CC6699?style=flat-square&logo=sass&logoColor=ffffff)
![Bootstrap](https://img.shields.io/badge/-Bootstrap-563D7C?style=flat-square&logo=Bootstrap)
![Markdown](https://img.shields.io/badge/-Markdown-000000?style=flat-square&logo=markdown)
![Nodejs](https://img.shields.io/badge/-Nodejs-339933?style=flat-square&logo=Node.js&logoColor=ffffff)
![Npm](https://img.shields.io/badge/-npm-CB3837?style=flat-square&logo=npm)
![Git](https://img.shields.io/badge/-Git-%23F05032?style=flat-square&logo=git&logoColor=%23ffffff)
![GitHub](https://img.shields.io/badge/-GitHub-181717?style=flat-square&logo=github)
![VS Code](http://img.shields.io/badge/-VS%20Code-007ACC?style=flat-square&logo=visual-studio-code&logoColor=ffffff)
![Powershell](http://img.shields.io/badge/-Powershell-5391FE?style=flat-square&logo=powershell&logoColor=ffffff)
![Windows](http://img.shields.io/badge/-Windows-0078D6?style=flat-square&logo=windows&logoColor=ffffff)

<br/>

<br/>

  <h2 align="center"> Github 통계 📈 </h2>
  
  <div align="center"> 
     <a href="">
      <img align="center" src="https://github-readme-stats-sigma-five.vercel.app/api?username=WhiteWatson&show_icons=true&include_all_commits=true&count_private=true&theme=react&line_height=40" />
    </a>
    <a href="">
      <img align="center" src="https://github-readme-stats.vercel.app/api/top-langs/?username=WhiteWatson&theme=react&line_height=40&hide=css"/>
    </a>
</div
  
<br/>




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-18

---