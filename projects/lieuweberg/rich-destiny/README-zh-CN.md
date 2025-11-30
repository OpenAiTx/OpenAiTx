![GitHub all releases](https://img.shields.io/github/downloads/lieuweberg/rich-destiny/total) ![GitHub release (latest by date)](https://img.shields.io/github/downloads/lieuweberg/rich-destiny/latest/total) ![Time spent coding (15 minute timeout)](https://wakatime.com/badge/user/a637a12a-da87-4487-8b1e-660151dc3e7b/project/94fa2fc6-7e9b-4c74-b6eb-4ce6a09b4cdf.svg)

# rich-destiny
| <img src="https://richdestiny.app/favicon.ico" width="100"> | 即插即用的后台程序，将您当前的《命运2》活动显示在 Discord 状态中。现代化设计，无需截图，体积小巧。 |
| :---: | :---: |

## 贡献 ✨

如果您想贡献，太棒了！对于新功能，请先在 Discord 服务器上询问或创建一个您想实现内容的问题。如果您想修复错误，可以直接创建 PR。不过建议先询问，以防“这不是错误，这是功能”。

## 开发 🛠
先决条件：
 - （客户端）拥有较新的 Go 1.x 版本。
 - （客户端）Windows 用户需要安装 git bash。您也可以手动运行构建脚本中的命令，但我使用 bash 脚本 :)
 - （网站）拥有较新的 Node.js 和 npm 版本。

构建：
 - 克隆仓库。
  
 - 客户端：
   - `cd client`
   - 复制 `config.go.example` 为 `config.go` 并填写相关值。对于重定向 URI，您可以使用 `https://richdestiny.app/login` —— 在 Bungie.net 开发者门户也有相同设置。它只是重定向到本地主机的重定向地址。
   - `go get`
   - `./build dev`
     - 你可以使用带有有效语义版本号的 `./build vX.Y.Z`，但开发时请使用 dev。它会自动禁用更新以及未来可能的其他功能。

 - 网站：
   - `cd web`
   - `npm install`
   - 使用 `npm run start` 启动本地开发服务器，或使用 `npm run build` 进行生产构建。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-30

---