# kkTerminal

> kkTerminal，一款用于 Web SSH 连接的终端
>
> 作者: [zyyzyykk](https://github.com/zyyzyykk/)
>
> 源代码: https://github.com/zyyzyykk/kkTerminal
>
> Docker Hub 地址: https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general
>
> 预览: https://ssh.kkbpro.com/
>
> 更新时间: 2025-03-15
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

### ⚡ 快速集成

在 HTML 网页中使用 `iframe` 标签即可快速集成：

```html
<iframe src="https://ssh.kkbpro.com/" height="400px" width="600px" ></iframe>
```

### 🐳 使用 Docker 部署

1. 拉取镜像：

```bash
docker pull zyyzyykk/kkterminal
```

2. 创建并运行容器进行端口映射：`-p 本地端口:3000`

```bash
docker run -d --name kkterminal -p 3000:3000 zyyzyykk/kkterminal
```

3. 自定义艺术字：`-e TITLE="ArtWord"`

```bash
docker run -d --name kkterminal -p 3000:3000 -e TITLE="kkbpro" zyyzyykk/kkterminal
```

4. 浏览器访问：`http://服务器IP:3000/`

### 🛸 预览

访问以下网站：https://ssh.kkbpro.com/

![Connect](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Connect.png)

![Preference](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Preference.png)

![File](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/File.png)

![Editor](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Editor.png)

[**更多模块预览**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/MODULE.md)

### 💡 功能说明

1. kkTerminal 是一个 Web SSH 连接终端，点击左上角终端图标并选择连接设置即可建立 SSH 连接

2. 支持在网页中使用 `iframe` 标签，快速集成到第三方网站

3. 支持通过[URL 参数](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/PARAMS.md)自定义终端配置

4. 支持国际化和中英文语言切换

5. 支持本地电脑部署，启动后自动打开浏览器窗口

6. 支持窗口自适应和中文输入

7. 支持自定义偏好设置，用户可选择背景/前景色、字体大小、光标显示样式、开启终端 TCode 等

8. 支持重启：修改 SSH 连接设置或自定义偏好设置后自动重启，SSH 断开后可手动重启

9. 支持复制粘贴：

   - 复制：与 `Git` 终端一致，选中文字自动复制
   - 粘贴：与 `Cmd` 终端一致，右键粘贴（需浏览器授权）

9. 支持文件管理，打开文件管理模块可查看、解压、上传和下载文件/文件夹

10. 支持多选/全选、复制粘贴、剪切、切换选择、打开等快捷键操作

11. 支持文件浏览与编辑，修改后使用 `ctrl+s` 保存到远程服务器

12. 支持 [TCode (终端代码)](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/TCODE.md)，可通过自定义 TCode 实现类似 Shell 脚本的自动化流程

13. 支持操作录制与云同步功能

14. 支持协作、监控和 Docker 功能

### 👨‍💻 更新记录

##### zyyzyykk/kkterminal:3.6.0: latest

- 新增高级协作功能
- 新增高级监控功能
- 新增高级 Docker 功能
- 优化打包体积与网页展示

##### zyyzyykk/kkterminal:3.5.6: 

- 支持更多 URL 参数
- 编辑器支持文本与图片大小百分比
- 优化网页展示

##### zyyzyykk/kkterminal:3.5.3: 

- 新增 URL 参数自定义终端配置
- 修复多窗口重启 bug
- 新增操作录制与云同步功能
- 重构部分代码逻辑

[**历史更新记录**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/UPDATE.md)

### 🧬 架构

```markdown
+---------+     http      +-------------+    ssh     +---------------+
| browser | <===========> | kk Terminal | <========> | remote server |
+---------+   websocket   +-------------+    sftp    +---------------+
Vue + Xterm              SpringBoot + SSHJ                Linux OS    
```

### 🏘️ 关于本项目

亲爱的用户：

很遗憾地通知大家，由于时间和精力有限，未来将无法继续维护 `kkTerminal`。

如果你对 `kkTerminal` 感兴趣或希望继续维护，欢迎与我联系或提交 issue。

如果你发现了 bug 或希望开发新功能，也请提交 issue。

最后，感谢大家对 `kkTerminal` 的支持，真诚地希望 `kkTerminal` 能真正帮助到你。

祝好！

[zyyzyykk](https://github.com/zyyzyykk/)

2025.03.15

### 🌟 Star

[![Stars](https://starchart.cc/zyyzyykk/kkTerminal.svg?variant=adaptive)](https://starchart.cc/zyyzyykk/kkTerminal)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---