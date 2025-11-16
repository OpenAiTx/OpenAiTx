# ExKeyMo
自 Android 4.1 起，应用程序可以通过 [Key Character Map](https://source.android.com/docs/core/input/key-character-map-files) 文件提供额外的键盘布局。  
从那时起，可以通过安装包含所需布局的应用程序，在无需 root 权限的情况下自定义键盘布局。  
即使你对 Android 开发一无所知，ExKeyMo 也能帮助你构建这样的应用程序。  

ExKeyMo 曾托管于 [Heroku](https://exkeymo.herokuapp.com/)，但现已不可用，因为 Heroku 停止免费托管项目且未批准该项目加入 Heroku 开源软件信用计划。你必须在本地运行 ExKeyMo 来创建包含自定义布局的 APK，或者使用下面列出的预构建 APK。  

需要两个以上的布局？你可以基于 [Custom Keyboard Layout](https://github.com/ris58h/custom-keyboard-layout) 项目构建这样的 APK。  

想支持我？[请请我喝咖啡](https://www.buymeacoffee.com/ris58h)。  

## 预构建 APK  
- CapsLock 转 Ctrl [ExKeyMo-caps2ctrl.zip](https://github.com/ris58h/exkeymo-server/files/12775514/ExKeyMo-caps2ctrl.zip)  
- CapsLock 与 Ctrl 互换 [ExKeyMo-swap-caps-and-ctrl.zip](https://github.com/ris58h/exkeymo-server/files/12775516/ExKeyMo-swap-caps-and-ctrl.zip)  
- CapsLock 转 Esc [ExKeyMo-caps2esc.zip](https://github.com/ris58h/exkeymo-server/files/12775515/ExKeyMo-caps2esc.zip)  
- CapsLock 与 Esc 互换 [ExKeyMo-swap-caps-and-esc.zip](https://github.com/ris58h/exkeymo-server/files/12775517/ExKeyMo-swap-caps-and-esc.zip)  

## 应用安装与设置  

1. 安装应用。该应用为自签名应用，Android 会警告你来源不受信任或类似提示。注意：如果安装时出现错误，请先卸载之前的版本（如果有的话）。  
2. 进入 `设置 -> 语言和输入法 -> 物理键盘`（具体路径可能不同），选择你想自定义的键盘，然后选择 `ExKeyMo 布局`。  

## 本地运行项目  

### 需求  
- Java（17 或更高版本）。  

### 获取  
通过 Git 克隆源码：
```
git clone git@github.com:ris58h/exkeymo-server.git
```
或者以 zip 格式[下载](https://github.com/ris58h/exkeymo-server/archive/refs/heads/master.zip)它。

### 构建
```
./mvnw clean install
```

### Run
```
java -jar target/exkeymo-server-*-jar-with-dependencies.jar
```
要在特定端口运行，请使用 `server.port` 系统属性：
```
java -Dserver.port=PORT_NUMBER -jar target/exkeymo-server-*-jar-with-dependencies.jar
```

### 使用
访问 [http://localhost/](http://localhost/) ，别忘了查看 __RTFM__ ([http://localhost/docs.html](http://localhost/docs.html))。

### 使用 Docker 运行
您可以使用 Docker 运行该应用程序。有两种方法：使用 Docker Compose 或直接使用 Docker。

#### 使用 Docker
构建 Docker 镜像：
```bash
docker build -t exkeymo-server .
```

运行 Docker 容器：
```bash
docker run -p 80:80 exkeymo-server
```
这将启动容器并在端口80上暴露应用程序。

#### 使用 Docker Compose

确保已安装 Docker 和 Docker Compose。然后，在包含 `docker-compose.yml` 文件的目录中运行以下命令：
```bash
docker-compose up
```
这将构建 Docker 镜像并启动容器，将应用程序暴露在端口 80 上。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-16

---