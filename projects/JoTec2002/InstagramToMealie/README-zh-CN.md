# InstagramToMealie

一个简单的小转换器，可以将Instagram链接导入到Mealie中

<p align="center">
    <img src="https://raw.githubusercontent.com/PKief/vscode-material-icon-theme/ec559a9f6bfd399b82bb44393651661b08aaf7ba/icons/folder-markdown-open.svg" align="center" width="30%">
</p>
<p align="center"><h1 align="center">INSTAGRAM TO MEALIE</h1></p>

<p align="center">
	<img src="https://img.shields.io/github/license/JoTec2002/InstagramToMealie?style=default&logo=opensourceinitiative&logoColor=white&color=0080ff" alt="license">
	<img src="https://img.shields.io/github/last-commit/JoTec2002/InstagramToMealie?style=default&logo=git&logoColor=white&color=0080ff" alt="last-commit">
	<img src="https://img.shields.io/github/languages/top/JoTec2002/InstagramToMealie?style=default&color=0080ff" alt="repo-top-language">
	<img src="https://img.shields.io/github/languages/count/JoTec2002/InstagramToMealie?style=default&color=0080ff" alt="repo-language-count">
</p>
<br>

## 目录

- [概述](#overview)
- [快速开始](#getting-started)
    - [先决条件](#prerequisites)
    - [安装](#installation)
    - [使用方法](#usage)
    - [配置](#configuration)
- [贡献](#contributing)
- [许可证](#license)
- [致谢](#acknowledgments)

---

## 概述

使用InstagramToMealie，您只需输入Instagram帖子链接。该项目无缝集成Mealie API，
创建一个新的食谱，并附带相关的图片或视频资源。

---

## 快速开始

### 前提条件

1. 确保你已在 Mealie 中配置了 OpenAI / Ollama，方法是在你的 Mealie 实例中访问 `/admin/debug/openai`。该项目不直接集成 OpenAI / Ollama，但需要在 Mealie 中配置它才能正常工作。我个人使用 Ollama 模型 `qwen2.5:7b` 得到了最佳效果。
2. 生成一个 Mealie API 密钥（`/user/profile/api-tokens`）。[Mealie 文档](https://docs.mealie.io/documentation/getting-started/api-usage/)
3. 生成一个 Instagram 会话文件（这是最棘手的步骤）。本仓库提供了一个[辅助脚本](https://raw.githubusercontent.com/JoTec2002/InstagramToMealie/refs/heads/main/helpers/instaloader_login_helper.py)！它只是从[Instaloader 文档](https://instaloader.github.io/troubleshooting.html)复制过来的。
    1. 下载脚本：[https://raw.githubusercontent.com/JoTec2002/InstagramToMealie/refs/heads/main/helpers/instaloader_login_helper.py](https://raw.githubusercontent.com/JoTec2002/InstagramToMealie/refs/heads/main/helpers/instaloader_login_helper.py)
    2. 在 Firefox 中登录 Instagram
    3. 执行命令：`python ./instaloader_login_helper.py`
    4. 将脚本生成的文件复制到已知位置。此文件稍后会挂载到 Docker 容器中。它可以在另一台系统上生成，然后复制到目标系统。

### 安装

使用以下方法之一安装 InstagramToMealie：

**从源码构建：**
<details closed>

1. 克隆 InstagramToMealie 仓库：


```sh
❯ git clone https://github.com/JoTec2002/InstagramToMealie
```

2. 进入项目目录：

```sh
❯ cd InstagramToMealie
```

3. 安装项目依赖：

```sh
❯ pip install -r requirements.txt
```

4. 启动服务器：

```sh
❯ python -u main.py
```

</details>

**使用提供的 Docker 镜像 [jotec2002/instagramtomealie](https://hub.docker.com/repository/docker/jotec2002/instagramtomealie/general)**

通过 Docker Compose 与您的 Mealie 安装一起部署

使用会话文件进行身份验证的示例 `compose.yaml` 文件：

```yaml
services:
  mealie:
    image: ghcr.io/mealie-recipes/mealie:v2.1.0
    container_name: mealie
    #Look up in the Mealie Docs for how to use Mealie
  InstagramToMealie:
    image: jotec2002/instagramtomealie
    ports:
      - 9001:9001
    environment:
      INSTA_USER: "instagram username"
      MEALIE_API_KEY: "MEALIE API KEY"
      MEALIE_URL: "YOU LOCAL MEALIE INSTALLATION" # e.g http://mealie:9000
      MEALIE_OPENAI_REQUEST_TIMEOUT: 60           # Optional, default: 60
    volumes:
      - ./session-file:/app/session-file        # The Instagram session file you created in the Prerequisites
    depends_on:
      mealie:
        condition: service_healthy
```

使用用户名和密码环境变量进行身份验证的示例 `compose.yaml` 文件：

> [!IMPORTANT]
> **为了使此方法有效，必须在账户上禁用两因素认证（TFA/TOTP）。**
> 您可能需要多次尝试才能成功。请在其他系统/IP上同时登录，以避免触发Instagram的机器人检测。
> 这不是设置InstagramToMealie的推荐方式。

```yaml
services:
  mealie:
    image: ghcr.io/mealie-recipes/mealie:v2.1.0
    container_name: mealie
    #Look up in the Mealie Docs for how to use Mealie
  InstagramToMealie:
    image: jotec2002/instagramtomealie
    ports:
      - 9001:9001
    environment:
      INSTA_USER: "instagram username"
      INSTA_PWD: "Cleartext Instagram password"
      MEALIE_API_KEY: "MEALIE API KEY"
      MEALIE_URL: "YOU LOCAL MEALIE INSTALLATION" # e.g http://mealie:9000
      MEALIE_OPENAI_REQUEST_TIMEOUT: 60           # Optional, default: 60
      MEALIE_USE_INSTAGRAM_TAGS: true
```

**自行构建 Docker 镜像**

配置方法与使用提供的 Docker 镜像时相同，但在 `compose.yaml` 中替换为以下内容：

```diff
services:
  mealie:
    image: ghcr.io/mealie-recipes/mealie:v2.1.0
    container_name: mealie
    #Look up in the Mealie Docs for how to use Mealie
  InstagramToMealie:
+   build:
+     context: .
+     dockerfile: Dockerfile
+   image: instagramtomealie:latest
    ports:
      - 9001:9001
```

### 使用方法

1. 在网页浏览器中打开（例如 `http://instagramtomealie.my-server.com`），然后将 Instagram URL 导入文本框中  
2. 从自动化工具调用（例如 iOS 快捷指令）URL `http://instagramtomealie.my-server.com?url=<InstagramURL>`  
3. 如果需要一个返回导入结果的 API，使用 `POST http://instagramtomealie.my-server.com/api`，将 URL 作为请求体中的 JSON 格式发送（推荐，`{"url": "<InstagramURL>"}`）或作为查询参数发送（见上一条）。API 返回的 JSON 格式为：
```json
{
  "recipe_slug": <imported recipe slug>,
  "error": <error message if any error>,
  "url": <Instagram URL which was imported>
}
```

### 配置

```env
MEALIE_URL:                          # Full URL of your Mealie instance (e.g http://mealie:9000, http://192.168.1.2:9000, http://my-mealie.com), required.
MEALIE_API_KEY:                      # API key used to authenticate with the Mealie REST API, required.
MEALIE_OPENAI_REQUEST_TIMEOUT: 60    # The timeout in seconds for OpenAI / Ollama requests, optional, default 60.
MEALIE_USE_INSTAGRAM_TAGS: true      # Embeds tags provided on the Instagram post as tags in Mealie, optional, default true.
INSTA_USER:                          # Instagram username (e.g mob_kitchen), required.
INSTA_PWD:                           # Instagram password in plaintext, optional (if using a session file).
INSTA_TOTP_SECRET:                   # Secret key used for 2FA authentication, optional, not recommended.
HTTP_PORT:                           # Port to use for the Flask HTTP server, optional, default 9001
```

---

## 贡献

- **💬 [加入讨论](https://github.com/JoTec2002/InstagramToMealie/discussions)**：分享你的见解，提供反馈，或提问。
- **🐛 [报告问题](https://github.com/JoTec2002/InstagramToMealie/issues)**：提交发现的错误或记录 `InstagramToMealie` 项目的功能请求。
- **💡 [提交拉取请求](https://github.com/JoTec2002/InstagramToMealie/blob/main/CONTRIBUTING.md)**：审查开放的 PR，并提交你自己的 PR。

<details closed>
<summary>贡献者图谱</summary>
<br>
<p align="left">
   <a href="https://github.com{/JoTec2002/InstagramToMealie/}graphs/contributors">
      <img src="https://contrib.rocks/image?repo=JoTec2002/InstagramToMealie">
   </a>
</p>
</details>

---

## 许可证

本项目受 MIT 许可证保护。更多详情请参阅 [LICENSE](https://choosealicense.com/licenses/) 文件。

---

## 致谢

- [Mealie](https://github.com/mealie-recipes/mealie/)
- [Instadownloader](https://github.com/instaloader/instaloader)

---






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-25

---