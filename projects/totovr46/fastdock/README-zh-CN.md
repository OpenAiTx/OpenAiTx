![icon](https://raw.githubusercontent.com/totovr46/fastdock/main/Icon2Nobg.png)

# Fastdock

一个简单的基于网页的 Docker 容器管理界面，具有现代设计风格。该应用通过美观的网页界面，提供了一种快速直观的方式来随时启动和停止 Docker 容器。

🎯 [在线演示](https://fastdock.salvatoremusumeci.com)

![Fastdock 界面](https://raw.githubusercontent.com/totovr46/fastdock/main/fast-demo.png)
![Fastdock iOS 界面](https://raw.githubusercontent.com/totovr46/fastdock/main/iphone.png)

## ⚠️ 安全提醒

**此应用仅供内部使用，应部署在 VPN 之后或安全的网络环境中。**

* 无身份验证或授权机制
* 直接访问 Docker 守护进程
* 文件上传功能无高级验证
* 仅适用于开发/测试环境

## ✨ 功能

* **实时容器管理**：启动和停止 Docker 容器
* **多服务器管理**：通过单一界面管理多台服务器上的 Docker 容器
* **服务器选择器**：快速切换本地和远程服务器
* **添加/编辑/删除服务器**：配置远程服务器的自定义名称、地址和端口
* **服务器感知显示**：容器卡片显示所属服务器
* **自定义容器图标**：上传自定义图标以便更好识别
* **容器重命名**：为容器分配自定义名称
* **响应式设计**：在桌面、平板和移动设备上无缝运行

## 🚀 快速开始

### 前提条件

* Node.js >= 16.0.0
* Docker 守护进程运行中
* 可访问 Docker 套接字（`/var/run/docker.sock`）

### 安装

1. **克隆代码库**

```bash
git clone https://github.com/totovr46/fastdock.git
cd fastdock
```
2. **安装依赖项**


```bash
npm install
```
3. **启动应用程序**


```bash
npm start
```
4. **访问界面**  
   打开浏览器并导航至 `http://serverIP:3080`  

## 📋 API 接口  

### 容器操作  

* `GET /api/containers` - 列出所选服务器上的所有容器  
* `POST /api/containers/:id/start` - 启动容器  
* `POST /api/containers/:id/stop` - 停止容器  
* `GET /api/containers/name/:name` - 通过名称查找容器  

### 容器设置  

* `POST /api/containers/settings/:id` - 更新容器设置（名称，图标）  
* `GET /api/containers/settings` - 获取所有容器设置  

### 服务器管理  

* `GET /api/servers` - 列出已配置的远程服务器  
* `POST /api/servers` - 添加新服务器  
* `PUT /api/servers/:id` - 编辑现有服务器  
* `DELETE /api/servers/:id` - 删除服务器  

## 🛠️ 开发  

### 项目结构  


```
fastdock/
├── server.js                  # Main server file
├── package.json              # Dependencies and scripts
├── public/
│   ├── index.html            # Main web interface
│   ├── assets/               # Uploaded container icons
│   ├── containerSettings.json # Container customization data
│   └── servers.json          # Stored remote server configurations
└── README.md
```


## 🔧 配置

### 环境变量

* `PORT` - 服务器端口（默认：3080），你可以在 server.js 文件中根据需要更改

### Docker 套接字

应用程序需要访问 Docker 套接字。确保 Docker 正在运行且套接字可访问：

**Linux/macOS:**


```bash
ls -la /var/run/docker.sock
```
**Windows (WSL)：**


```bash
# Ensure Docker Desktop is running
docker ps
```
## 🚦 使用说明

### 基本操作

1. **选择服务器**：使用下拉菜单选择本地或远程服务器
2. **查看容器**：查看所选服务器的所有容器
3. **启动/停止**：使用按钮按常规方式管理容器
4. **编辑容器**：点击铅笔图标更改名称或图标

### 容器自定义

1. 点击任意容器卡上的编辑图标（铅笔）
2. 上传自定义图标（仅限图像文件）
3. 设置自定义名称以便识别
4. 点击“保存”应用更改

### 服务器管理

1. 点击服务器选择下拉菜单
2. 选择“添加服务器”配置新的远程Docker服务器
3. 使用编辑或删除选项管理现有服务器
4. 服务器数据被持久保存并自动加载

### 状态指示

* 🟢 **绿色**：容器正在运行
* 🔴 **红色**：容器已停止

## 🔐 安全注意事项

### 网络安全

* **部署于VPN后面**：确保应用只能通过安全VPN连接访问
* **内部网络**：仅在可信的内部网络中使用

### 文件上传安全

* 仅接受容器图标的图像文件
* 文件存储在 `public/assets/` 目录

### Docker访问

* 应用需要Docker socket访问权限
* 所有VPN用户将拥有完整容器管理权限
* 请遵循Docker socket安全最佳实践

## 🚨 限制

* **无用户认证**：所有用户访问权限相同
* **无审计日志**：容器操作不记录日志
* **本地存储**：设置存储在本地JSON文件
* **单实例**：不支持多实例部署

## 🛌 多服务器支持

自 **v1.1.0** 起，FastDock 支持管理多个Docker主机上的容器。关键点：

* 添加带自定义名称、地址和端口的服务器
* 使用下拉选择器切换服务器
* 分服务器查看和管理容器
* 每个容器显示所属服务器
* 完全兼容单服务器设置
* 服务器列表和设置本地持久化

## 🤝 贡献指南

1. Fork 本仓库
2. 创建功能分支（`git checkout -b feature/amazing-feature`）
3. 提交更改（`git commit -m 'Add amazing feature'`）
4. 推送分支（`git push origin feature/amazing-feature`）
5. 提交 Pull Request

---

**⚠️ 重要**：此应用提供对Docker容器的直接访问。仅在安全、受控且可信用户环境中使用。
![icon](https://raw.githubusercontent.com/totovr46/fastdock/main/Icon.png)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---