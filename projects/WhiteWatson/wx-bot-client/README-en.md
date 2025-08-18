# Hi there, I'm WxBotClient <img width="30px" src="https://media.tenor.com/images/3b388fe03da271d2674faf85eb7c3fcd/tenor.gif" />
I am an open-source WeChat hosting software, developed based on electron, wechaty, and vue, now integrated with ChatGPT. The compiled installation package is ready to use out of the box, does not rely on complex environments, and the hosting program does not disconnect arbitrarily, making it stable and reliable.

<img align="right" height="200" src="https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./src/assets/icons/icon.png" />

---
## Setup Method
### Download & Install
[Releases package download link](https://github.com/WhiteWatson/wx-bot-client/releases), here you can download the already built **.exe installer (Windows)**. During the download, your software might warn that the file is unsafe; you can ignore this prompt. After downloading, just install it locally.

### Host Your WeChat
Open the software, click the **Let's Start** button, and fill in your openAI APIKey in the pop-up window,

![markdown picture](https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./doc/images/one.png)

![markdown picture](https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./doc/images/apikeyinput.png)

After filling in, click **Now, Start the Bot**, wait for the QR code to appear, then scan the QR code with WeChat to log in and host your WeChat.

tips: Use a VPN if you are in China, otherwise the API will not pass, and the AI will remain in a thinking state.

### Basic Bot Settings
After a successful login, enter the bot management backend. Click the **GPT Settings** menu on the left to see the basic bot settings.

Modify the bot trigger word in **AI Trigger Word**

Specify the groups or WeChat users the bot serves in **AI Group Chat, AI Private Chat**

![markdown picture](https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./doc/images/gptsetting.png)

---
## Feature Overview
### AI Text Chat Capability

```
提问格式： @AI + 问题内容

例：@AI 你是谁？
```
### AI-Generated Image Capabilities

```
提问格式： /image + 图片提示词

例：/image 一个骑马的人
```
tips: Since AI easily generates prohibited images, the bot sends image links directly, and the links are time-sensitive

---

## Custom Deployment
This project depends on the node environment to run locally

### Install Dependencies

Please note that you must use yarn or pnpm to install dependencies here
```
yarn install
```

### Access ChatGPT and Run the Project Locally:

```
npm run electron:serve
```

### Packaging the Client Installation Package:
```
npm run electron:build
```
### Configure openAI APIKey in the project
Go to the `/src/bot/config.ts` directory, and fill in the `Organization` and `APIKey` obtained from the [openAi official API application page](https://platform.openai.com/account/api-keys) into the `setApiKey` function.

### If you encounter problems [you can first refer to this document](https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./doc/problem.md)

---
## I'm a Computer Science and Engineering Student  

- 👨‍💻 I’m currently working on web development technologies like JavaScript, Vue etc.
- 💪🏼 Future Goals: Learn more technologies - Never stop creating new ideas.
- ⚡ Fun fact: I love to play Genshin Impact.

### Special thanks to leeguiyu@qq.com for creating the icons

### Languages and Tools 🛠 

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

  <h2 align="center"> Github Statistics 📈 </h2>
  
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