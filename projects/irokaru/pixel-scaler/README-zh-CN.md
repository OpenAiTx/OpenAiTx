<div align="center">  
  <a href="https://irokaru.github.io/pixel-scaler/">
    <img src="https://raw.githubusercontent.com/irokaru/pixel-scaler/master/./public/logo.png" width="33%" alt="Pixel Scaler Logo"/>
  </a>
  <p><b>像素艺术放大工具</b></p>

  <!-- Badges -->
  <p>
    <a href="https://github.com/irokaru/pixel-scaler/releases/latest"><img src="https://img.shields.io/github/v/release/irokaru/pixel-scaler.svg?style=for-the-badge" alt="Latest Release"/></a>
    <img src="https://img.shields.io/github/downloads/irokaru/pixel-scaler/total?style=for-the-badge" alt="Downloads"/>
    <a href="https://app.codecov.io/gh/irokaru/pixel-scaler/tree/master"><img src="https://img.shields.io/codecov/c/github/irokaru/pixel-scaler?style=for-the-badge" alt="Coverage"/></a>
    <a href="https://x.com/IroKaru"><img src="https://img.shields.io/twitter/follow/irokaru?style=for-the-badge" alt="Follow on X"/></a>
  </p>
</div>

## 开发环境

* node (>= 22.x)
* rust (>=1.85.0)
  * (Tauri 开发所需)

## 开发环境设置（WSL）

安装依赖：

```sh
npm ci
```

（可选）如果您想使用 Tauri：

```sh
cargo install tauri-cli
sudo apt install -y libsoup2.4-dev javascriptcoregtk-4.1 libsoup-3.0 webkit2gtk-4.1 \
                    libjavascriptcoregtk-4.0-dev libwebkit2gtk-4.0-dev librsvg2-dev
```

## 可用命令

| 命令                      | 描述                                                      |
|-------------------------|------------------------------------------------------------|
| `npm run dev`           | 使用 Vite 启动开发服务器                                    |
| `npm run dev:tauri`     | 启动 Tauri 开发服务器                                       |
| `npm run build`         | 构建生产环境项目                                           |
| `npm run build:tauri`   | 使用 tauri 构建项目                                        |
| `npm run preview`       | 预览构建后的项目（需先运行 `npm run build`）              |
| `npm run test`          | 运行测试                                                  |
| `npm run test:watch`    | 以监听模式运行测试                                        |
| `npm run test:coverage` | 运行测试并生成覆盖率报告                                  |
| `npm run test:e2e`      | 使用 playwright 运行测试                                   |
| `npm run clean`         | 删除生成的文件                                            |
| `npm run lint-staged`   | 对暂存文件运行代码格式检查                                |
| `npm run prepare`       | 为 Git 钩子设置 Husky                                     |

## 缩放库

* xBRjs（版权归 2020 Josep del Rio 所有）
  * https://github.com/joseprio/xBRjs


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-27

---