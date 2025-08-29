# grtblog

[![GitHub license](https://img.shields.io/github/license/grtsinry43/grtblog)](http://www.apache.org/licenses/LICENSE-2.0.html)
[![GitHub release](https://img.shields.io/github/v/release/grtsinry43/grtblog)](https://github.com/grtsinry43/grtblog/releases)
[![Last commit](https://img.shields.io/github/last-commit/grtsinry43/grtblog)](https://github.com/grtsinry43/grtblog/commits/main)
[![GitHub issues](https://img.shields.io/github/issues/grtsinry43/grtblog)](https://github.com/grtsinry43/grtblog/issues)
[![GitHub pull requests](https://img.shields.io/github/issues-pr/grtsinry43/grtblog)](https://github.com/grtsinry43/grtblog/pulls)
[![Languages](https://img.shields.io/github/languages/top/grtsinry43/grtblog)](https://github.com/grtsinry43/grtblog)
[![Author](https://img.shields.io/badge/author-grtsinry43-blue)](https://github.com/grtsinry43)
[![Development Status](https://img.shields.io/badge/status-in%20development-yellow)](https://github.com/grtsinry43/grtblog)

🚧🚧🚧 **このプロジェクトは現在開発中です。 / 施工中，请稍候再来看** 🚧🚧🚧

⏳⏳⏳ **現在の進捗状況: / 当前进度：**

- [x] Markdown に基づく記事レンダリング / 基于 Markdown 的文章渲染
- [x] 記事・タグ・カテゴリー管理 / 文章 / 标签 / 分类管理
- [x] 部分的リロード / 部分重载
- [x] 内蔵ページスタイル / 内置页面样式
- [x] コメントシステム / 评论系统
- [ ] マルチテーマ対応 / 多主题支持
- [x] 検索機能 / 搜索功能
- [ ] 管理者ダッシュボード / 管理员仪表盘
- [ ] カスタマイズオプション / 自定义选项
- [ ] テーマ切替 / 主题切换

## 概要 / 概述

grtblog は React.js と Spring Boot に基づく総合的なブログシステム（コンテンツ管理システム）です。  
フロントエンドとバックエンドが分離されており、サーバーサイドと静的生成のハイブリッドモードをサポートし、豊富なカスタマイズオプション、部分的なリロード対応、テーマ切替機能を備えています。

grtblog 是一个基于 React.js 和 Spring Boot 的综合博客系统（内容管理系统）。它具有前后端分离的架构，支持服务端和静态生成混合模式，提供丰富的自定义选项，支持部分重载和主题切换。

## 特徴 / 特性

- **分離アーキテクチャ / 前后端分离架构**: フロントエンドとバックエンドを分離し、拡張性と保守性を向上。前后端分离，提升可扩展性和可维护性。
- **ハイブリッド生成 / 混合生成**: サーバーサイドと静的生成の両方をサポート。支持服务端和静态生成。
- **カスタマイズ / 自定义**: テーマやコンポーネントの豊富なカスタマイズオプションを提供。提供丰富的主题和组件自定义选项。


- **Partial Reload / 部分重载**: Efficient partial reload support. 高効率の部分リロードサポート。
- **Theme Switching / 主题切换**: Easy theme switching for a personalized experience. 簡単なテーマ切り替えでパーソナライズ体験を提供。

## Screenshots / スクリーンショット

![image](https://github.com/user-attachments/assets/40cac1c2-767a-4e0e-b72c-664384e93dfd)
![image](https://github.com/user-attachments/assets/0f8819c4-5be2-47bf-b526-2db097141bd9)
![image](https://github.com/user-attachments/assets/acbb9f7b-4ffc-45ff-835e-e09ee0a16979)
![image](https://github.com/user-attachments/assets/72116ff9-eb07-4e0c-921a-c3db32cbd59c)
![image](https://github.com/user-attachments/assets/6e790aab-94f4-4ada-8fc7-fc1bef0af5c8)


## Getting Started / はじめに

### Prerequisites / 前提条件

- Node.js
- npm
- Java
- Maven

### Installation / インストール

1. Clone the repository / リポジトリをクローン:
    ```bash
    git clone https://github.com/grtsinry43/grtblog.git
    cd grtblog
    ```
2. フロントエンドの依存関係をインストール / 安装前端依赖:

    ```bash
    cd frontend
    npm install
    ```
3. Install back-end dependencies / バックエンド依存関係のインストール:

    ```bash
    cd ../backend
    mvn install
    ```

### アプリケーションの実行 / 运行应用

1. バックエンドサーバーを起動する / 启动后端服务器:
    ```bash
    cd backend
    mvn spring-boot:run
    ```
2. フロントエンド開発サーバーを起動する / 启动前端开发服务器:

    ```bash
    cd ../frontend
    npm start
    ```

## Contributing / 貢献

[//]: # (Contributions are welcome! Please read the [contributing guidelines]&#40;CONTRIBUTING.md&#41; for more information.)

[//]: # ()
[//]: # (貢献を歓迎します！詳細は[貢献ガイドライン]&#40;CONTRIBUTING.md&#41;をご覧ください。)

## License / ライセンス

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

本プロジェクトはMITライセンスのもとで提供されています。詳細は[LICENSE](LICENSE)ファイルをご覧ください。

## Acknowledgements / 謝辞

- [React.js](https://reactjs.org/)
- [Spring Boot](https://spring.io/projects/spring-boot)

## Contact / 連絡先

For any inquiries, please contact [grtsinry43](https://github.com/grtsinry43).

ご質問等ございましたら、[grtsinry43](https://github.com/grtsinry43)までご連絡ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---