# kkTerminal

> kkTerminal, a terminal for Web SSH connection
>
> Author: [zyyzyykk](https://github.com/zyyzyykk/)
>
> Source Code: https://github.com/zyyzyykk/kkTerminal
>
> Docker Hub Address: https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general
>
> Preview: https://ssh.kkbpro.com/
>
> Update Time: 2025-03-15
>

<p align="center"><a href="https://ssh.kkbpro.com/" target="_blank" rel="noopener noreferrer"><img width="100" src="https://kkbapps.oss-cn-shanghai.aliyuncs.com/logo/terminal.png" alt="kkTerminal"></a></p>

<p align="center">
  <a href="https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general"><img src="https://img.shields.io/docker/pulls/zyyzyykk/kkterminal?logo=docker" alt="Docker Image"></a>
  <a href="https://www.oracle.com/cn/java/technologies/downloads/#java8-windows"><img src="https://img.shields.io/badge/jdk-1.8-orange?logo=openjdk&logoColor=%23e3731c" alt="JDK Version"></a>
  <a href="https://spring.io/projects/spring-boot"><img src="https://img.shields.io/badge/springboot-2.7.15-green?color=6db33f&logo=springboot" alt="SpringBoot Version"></a>
  <a href="https://cn.vuejs.org/"><img src="https://img.shields.io/badge/vue-3.x-green?color=42b883&logo=vue.js" alt="Vue Version"></a>
  <a href="https://www.apache.org/licenses/"><img src="https://img.shields.io/badge/licence-Apache-red?logo=apache&logoColor=%23D22128" alt="Apache Licence"></a>
  <a href="https://github.com/zyyzyykk/kkTerminal"><img src="https://img.shields.io/github/stars/zyyzyykk/kkterminal" alt="GitHub"></a>
</p>
<p align="center">English ｜ <a href="https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/zh_CN/README.md" >简体中文</a></p>

### ⚡ Quick integration

Quickly integrate by using the `iframe` tag in HTML web pages:

```html
<iframe src="https://ssh.kkbpro.com/" height="400px" width="600px" ></iframe>
```

### 🐳 Deploy with Docker

1. Pull the image:

```bash
docker pull zyyzyykk/kkterminal
```

2. Create and run a container with port mapping: `-p port:3000`

```bash
docker run -d --name kkterminal -p 3000:3000 zyyzyykk/kkterminal
```

3. Customize the ASCII art title: `-e TITLE="ArtWord"`

```bash
docker run -d --name kkterminal -p 3000:3000 -e TITLE="kkbpro" zyyzyykk/kkterminal
```

4. Access in browser: `http://server-ip:3000/`

### 🛸 Preview

Visit the following website: https://ssh.kkbpro.com/

![Connect](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Connect.png)

![Preference](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Preference.png)

![File](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/File.png)

![Editor](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Editor.png)

[**More Module Previews**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/MODULE.md)

### 💡 Function Description

1. kkTerminal is a terminal for Web SSH connection. Click the terminal icon in the upper left corner and select connection settings to establish an SSH connection.

2. Supports quick integration into third-party websites using the `iframe` tag in web pages.

3. Supports customizing terminal configuration through [URL Parameters](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/PARAMS.md).

4. Supports internationalization and switching between Chinese and English.

5. Supports local PC deployment and automatically opens a browser window upon startup.

6. Supports adaptive window size and Chinese input.

7. Supports custom preference settings, allowing users to choose background/foreground color, font size, cursor display style, enable TCode for the terminal, etc.

8. Supports restart: will automatically restart after modifying SSH connection settings or custom preferences, or can be manually restarted after SSH connection is disconnected.

9. Supports copy and paste:

   - Copy: Like the `Git` terminal, selecting text will automatically copy it.
   - Paste: Like the `Cmd` terminal, right-click to paste (requires browser access permission).


10. Supports file management. Open the File Management module to view, decompress, upload, and download files/folders.

11. Supports shortcut operations such as multiple/all file selection, copy and paste, cut, selection switch, open, etc.

12. Supports file browsing and editing. Modify files and save to the remote server with `ctrl+s`.

13. Supports [TCode (Terminal Code)](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/TCODE.md), enabling automated workflows similar to shell scripts via custom TCode.

14. Supports operation recording and cloud synchronization.

15. Supports Cooperate, Monitor, and Docker functions.

### 👨‍💻 Update Records

##### zyyzyykk/kkterminal:3.6.0: latest

- Add Advance Cooperate function
- Add Advance Monitor function
- Add Advance Docker function
- Optimize package size & web page display

##### zyyzyykk/kkterminal:3.5.6: 

- Support more URL parameters
- Add editor text & image size percentage
- Optimize web page display

##### zyyzyykk/kkterminal:3.5.3: 

- Add URL parameter to customize terminal configuration
- Fix bug of multi-window restart
- Add operation recording and cloud synchronization functions
- Refactor some code logic

[**History Update Records**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/UPDATE.md)

### 🧬 Architecture

```markdown
+---------+     http      +-------------+    ssh     +---------------+
| browser | <===========> | kk Terminal | <========> | remote server |
+---------+   websocket   +-------------+    sftp    +---------------+
Vue + Xterm              SpringBoot + SSHJ                Linux OS    
```

### 🏘️ About this project

Dear Users,

I regret to announce that due to limited time and energy, I will not be able to maintain `kkTerminal` in the future.

If you are interested in `kkTerminal` or would like to continue maintaining it, please feel free to contact me or open an issue.

If you discover bugs or wish to develop new features, please also open an issue.

Finally, thank you for your support of `kkTerminal` and I sincerely hope that `kkTerminal` can truly help you.

Best Regards,

[zyyzyykk](https://github.com/zyyzyykk/)

2025.03.15

### 🌟 Stars

[![Stars](https://starchart.cc/zyyzyykk/kkTerminal.svg?variant=adaptive)](https://starchart.cc/zyyzyykk/kkTerminal)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---