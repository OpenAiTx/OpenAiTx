![preview](https://github.com/user-attachments/assets/e6762b5a-479a-4261-8e5c-e6b5d04344c5)
# Pantry
[![build](https://github.com/imRohan/Pantry/actions/workflows/continuous_integration.yml/badge.svg)](https://github.com/imRohan/Pantry/actions/workflows/continuous_integration.yml)
![Maintainability](https://api.codeclimate.com/v1/badges/8f1460270ced1f60744c/maintainability)
![Issues Open](https://img.shields.io/github/issues/imrohan/Pantry?&logo=github)
![Issues Closed](https://img.shields.io/github/issues-closed-raw/imrohan/pantry?color=green&logo=github)
[![Coverage Status](https://coveralls.io/repos/github/imRohan/Pantry/badge.svg?branch=master)](https://coveralls.io/github/imRohan/Pantry?branch=master)

[Pantry](https://getpantry.cloud/) 是一项免费的服务，提供针对小型项目的易腐数据存储。数据会被安全存储，只要您和您的用户需要，且在一段时间不活动后会被删除。只需使用 restful API 发送 JSON 对象，剩下的我们来处理。

它的构建目的是为较小规模的项目提供一个简单、可复用的存储解决方案。它由开发者为开发者创建，随时为您提供支持，帮助您快速原型开发下一个项目。

## 开发

#### 克隆仓库
`git clone https://github.com/imRohan/Pantry.git && cd Pantry`

#### 安装依赖
`yarn`

#### 安装 Redis
您需要在您的机器上安装 Redis（版本 ^6.2.0）并且保持服务器运行，
使用其默认设置

#### 创建并编辑 `.env` 和 `config.ts`
`cp env.sample .env`
`cp src/app/config.dev.ts src/app/config.ts`

#### 构建前端资源并运行服务器（默认端口 3000）

`yarn run dev`

#### 打开示例 HTML 页面

在您选择的浏览器中打开 `http://localhost:3000/`


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-27

---