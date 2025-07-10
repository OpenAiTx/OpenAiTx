<p align="center">
  <a href="https://www.jukeboxhq.com">
    <img height="500" src="https://raw.githubusercontent.com/skeptrunedev/jukebox/main/frontend/public/opengraph-image.jpg" alt="Trieve 标志">
  </a>
</p>

<p align="center">
  <a href="https://hub.docker.com/r/skeptrune/jukebox-server" style="text-decoration: none;">
    <img src="https://img.shields.io/docker/pulls/skeptrune/jukebox-server?style=flat-square" alt="Docker 拉取次数" />
  </a>
  <a href="https://github.com/skeptrunedev/jukebox/stargazers" style="text-decoration: none;">
    <img src="https://img.shields.io/github/stars/skeptrunedev/jukebox?style=flat-square" alt="GitHub 星标" />
  </a>
  <a href="https://x.com/skeptrune" style="text-decoration: none;">
    <img src="https://img.shields.io/badge/follow%20on-x.com-1da1f2?logo=x&style=flat-square" alt="在 X（Twitter）上关注" />
  </a>
</p>

---
# 将任意设备变为协作点歌机

**Jukebox** 让你可以和朋友即时创建共享音乐播放列表——无需应用、无需登录、无广告。只需创建一个盒子，分享链接，然后一起添加歌曲。非常适合聚会、自驾游或任何团体活动！

- 🌐 **开源的 Spotify 协作歌单替代方案**
- 🕵️ **无需账户**：匿名使用——无需注册或邮箱
- ✨ **分享链接，共同添加歌曲**：所有人都可实时贡献
- 🚀 **无需下载应用**：任何设备浏览器均可使用
- 🎵 **YouTube 集成**：几乎可即时搜索和播放任意歌曲
- 📱 **移动端友好**：专为手机、平板和桌面设计
- ⚖️ **公平排队**：歌曲自动排序，确保每个人都有机会
- 🆓 **100% 免费，无广告**

---

## 立即试用

1. **创建点歌盒**：访问首页并创建一个新盒子
2. **分享链接**：将邀请链接发送给你的朋友
3. **添加歌曲**：搜索 YouTube 或手动添加歌曲
4. **播放音乐**：使用内置播放器一起在线收听

---
## 功能

- 协作播放列表：一起添加、排队和播放歌曲
- 匿名使用：无需登录或账户
- YouTube 搜索与播放：访问海量音乐库
- 移动优先，响应式界面
- 开源（MIT 许可证）
- 轻松使用 Docker 部署

### Docker Compose 部署

启动所有服务：

```bash
docker-compose up -d
```

在更新镜像后零停机时间重新部署服务：

```bash
bash ./redeploy.sh
```
---

## 入门指南

### 前置条件

- Node.js 16 及以上版本
- npm 或 yarn
- YouTube Data API v3 密钥（可从 Google 免费获取）

### YouTube API 设置

1. 前往 [Google Cloud 控制台](https://console.cloud.google.com/)
2. 创建一个新项目或选择一个已有项目
3. 启用 **YouTube Data API v3**
4. 创建凭据（API 密钥）
5. 复制您的 API 密钥

### 安装
```bash
# 克隆仓库
git clone <your-repo-url>
cd jukebox

# 安装服务器依赖
cd server
yarn install

# 安装前端依赖
cd ../frontend
yarn install

# 配置环境变量
cd ../server
cp .env.example .env
# 编辑 .env 并添加你的 YouTube API 密钥

# 运行数据库迁移
```
yarn migrate

# 启动开发服务器
# 后端：
cd server
yarn dev
# Worker：
cd server
yarn dev:worker
# 前端（在新终端中）：
cd frontend
yarn dev
```

---

## 许可证

MIT

---
## 贡献与反馈

- 在 [GitHub](https://github.com/skeptrunedev/jukebox) 上提交 issue 或 pull request
- 有功能请求？私信 [@skeptrune 在 X (Twitter)](https://twitter.com/skeptrune)

---

## 更新日志

请查看 [更新日志](https://jukebox.skeptrune.com#changelog) 获取最新的更新和功能。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---