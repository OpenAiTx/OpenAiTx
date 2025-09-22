# BookHaven

![BookHaven 首页](https://raw.githubusercontent.com/HrBingR/BookHaven/master/./bookhaven_home.png)

## 目录
1. [应用功能](#what-the-application-does)
2. [功能特点](#features)
3. [部署](#deployment)
   - [Docker](#docker)
   - [开发](#development)
4. [构建应用](#building-the-application)
5. [更新日志](#change-log)


## 应用功能
BookHaven 扫描并管理您本地的 EPUB 电子书库，允许您在任何设备上阅读和下载电子书，界面简洁、现代且响应迅速。

## 功能特点
- **在浏览器中阅读电子书**
  用户可以直接访问并阅读 EPUB 格式的电子书，无需额外软件。
- **下载电子书**
  轻松将收藏中的任何电子书下载到您的设备。
- **无损元数据编辑**
  对电子书元数据（如标题、作者、系列）的更改存储在数据库中，原始 EPUB 文件保持不变。
- **自动或手动库扫描**
  应用部署后会定期按可配置的间隔扫描您的书库变化，同时也支持手动扫描。
- **首页按字母排序**
  书籍先按作者字母排序，再按系列排序，提供整洁直观的浏览体验。
- **强大搜索**
  首页的搜索功能允许用户按作者、书名或系列过滤书库，快速定位特定内容。
- **筛选器**
  提供基础筛选功能，可筛选标记为收藏、已读或未标记为已读的书籍。
- **作者页面及直观导航**
  专门的作者页面将作者按字母排列成可点击的网格。用户可点击字母展开作者列表，进入作者页面，按系列和单本书名字母顺序查看其作品。
- **支持 CloudFlare 访问**
  提供标志以绕过登录界面，方便使用 CloudFlare Access。详见 `.env.example`。
- **支持 OIDC**
  允许配置 OIDC 以支持新用户注册及现有用户登录。
- **支持 OPDS**
  使用您喜欢的兼容 OPDS 的电子书阅读器或应用浏览、下载并阅读书库中的书籍。
- **上传功能**  
  用户现在可以通过用户界面直接上传电子书，上传后有一个表单用于修正元数据。  
- **基本的 RBAC 支持**  
  管理员现在可以为用户赋予不同的角色，拥有不同级别的访问权限。  
- **图书请求**  
  用户现在可以请求他们希望在网站上看到的特定图书。管理员和编辑可以查看并在上传/添加后处理这些请求。  

## 部署  

### 要求  

运行该应用程序的最低要求：  

- 一个数据库（MySQL、SQLite、PostgreSQL）  
- 一个 Redis 实例  

为了快速简便的部署，`.compose.yml.example` 文件已经定义了这两项。  

### Docker  
按照以下步骤使用 Docker Compose 部署应用程序：  
1. **下载配置文件**  
下载或克隆仓库以获取 `compose.yml.example` 和 `.env.example`。  

2. **重命名示例文件**
``` bash
   mv compose.yml.example compose.yml
   mv .env.example .env
```
3. **自定义 `.env` 文件**

编辑 `.env` 以配置基本设置。

4. **启动应用程序**

运行以下命令：
``` bash
   docker compose up -d
```
这将启动 `BookHaven`、Redis 和 MySQL 容器。  
5. **访问应用程序**  

打开浏览器，导航到您配置的 `BASE_URL`:`APP_PORT`（默认是 `http://localhost:5000`）。  

6. **停止应用程序**

``` bash
   docker compose down
```

### 开发
按照以下步骤进行开发部署：
1. **克隆代码库**：
``` bash
   git clone https://github.com/HrBingR/BookHaven.git
   cd BookHaven
```

2. **重命名示例文件**：
```bash
   mv compose.exmaple.yml compose.yml
   mv .env.example .env
```

3. **自定义 `.env` 文件**：

编辑 `.env` 以配置必要的设置。

4. **修改 `compose.yml` 文件**：

更改：

```yaml
    epub-reader:
       image: hrbingr/bookhaven:latest
```

To:

```yaml
  epub-reader:
     build:
        context: .
        dockerfile: Dockerfile
```

5. **构建容器**：
```bash
   docker compose up --build -d
```

6. **访问应用程序**：

通过 `.env` 文件中定义的 `BASE_URL` 和 `APP_PORT` 访问应用程序。

## 构建应用程序
要为生产环境构建应用程序：
1. **构建前端**：
``` bash
   cd frontend
   npm run build:dev
```
2. **构建 Docker 镜像**：

在项目根目录（BookHaven）中运行：
``` bash
   docker build -t tag:version .
```
将 `tag:version` 替换为您首选的镜像名称和版本（例如，`bookhaven:1.0.0`）。

## 变更日志：

详细变更日志请参见 [CHANGELOG](https://raw.githubusercontent.com/HrBingR/BookHaven/master/CHANGELOG.md)

- v1.0.x
  - 初始发布
- v1.1.0 - v1.1.1
  - 新增 OIDC 支持
  - 修复 OIDC 前端组件在禁用 OIDC 时仍会渲染的错误。
- v1.2.0 - v1.2.2
  - 新增支持可选地将元数据写入 ePub 文件，而不仅仅写入数据库。
  - 修复 Celery 在显式定义 PERIODIC_SCAN_INTERVAL 时将其识别为字符串并抛出异常的问题。
  - 修复迁移和数据库模型逻辑，防止 PostgreSQL 用户初始化数据库失败。
- v1.3.0 - v1.3.5
  - 新增基础 OPDS 支持。
  - 改进 OPDS 功能。
  - 修复作者页面的 UI 问题
  - 修复首页滚动相关的一些用户体验问题
  - 改进前端封面图片加载
  - 提升默认 API 速率限制并支持自定义
  - 实现扫描过程锁定，确保同一时间只运行一个扫描
  - 改进扫描逻辑中的数据库组件
  - 修复移动端“作者”页面展开作者列表的渲染问题
  - 更新扫描逻辑 - 启动时将自动扫描图书馆
- v1.4.0 - v1.4.1
  - 新增上传功能 - 详见 .env.example 如何启用和使用
  - 更新扫描器备用标识符，从相对路径改为文件名
  - 创建迁移以更新现有的备用标识符
  - 从 gunicorn sync 切换到 gunicorn gthread，以提升上传性能
  - 修复定时扫描的 celery 任务导入问题
  - 修复上传功能禁用时隐藏上传按钮的问题
- v1.5.0 - v1.5.2
  - 新增基于角色的访问控制（RBAC）。管理员现在可以为用户分配以下不同角色：
    - 用户：可访问除上传、编辑元数据和管理用户外的所有基本功能。
    - 编辑：包括上传和编辑元数据权限。
    - 管理员：包括管理其他用户的权限。
  - 改进通过 Cloudflare Access 登录时的逻辑。
  - 修复影响从未删除的旧列的小错误。
  - 使迁移脚本更具弹性。
- v.1.6.0
  - 添加了请求功能，允许用户请求将新书添加到网站。

## 待办事项：

- 使用最新添加内容更新测试
- 探索对其他格式的支持
- 探索添加更多可编辑的元数据字段

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---