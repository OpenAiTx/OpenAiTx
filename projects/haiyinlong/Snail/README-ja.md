<!-- 
Spring Boot 3 マイクロサービススキャフォールド、Spring Cloud OAuth2 認証、shadcn ui バックエンドテンプレート、 
Java 高速開発フレームワーク、Spring Boot Admin フロントエンド・バックエンド分離、Nacos 設定センター、 
マイクロサービス権限管理、JWT ログイン、Spring Security 6、Vue3 管理システム 
-->
<p align="center">
  <h3 align="center">Snail - エンタープライズ向けマイクロサービス高速開発スキャフォールド</h3>
  <p align="center">
    🚀 Spring Boot 3 + Spring Cloud + OAuth2 + shadcn/ui ベース
  </p>
  <p align="center">
    <a href="#-快速开始">クイックスタート</a> •
    <a href="#-文档">ドキュメント</a> •
    <a href="#-贡献">貢献</a> •
  </p>
  <p align="center">
    <img src="https://img.shields.io/github/stars/haiyinlong/snail?style=social" alt="GitHub Stars">
    <img src="https://img.shields.io/github/forks/haiyinlong/snail?style=social" alt="GitHub Forks">
  </p>
</p>

# 🐌 Snail - 軽量級 Spring Boot 高速開発スキャフォールド

> **Snail** は Spring Boot 3 をベースにした
> モダンなマイクロサービス高速開発フレームワークで、認証、認可、ゲートウェイ、リソースサービスなどのコア機能を即時利用可能に提供し、エンタープライズが安全で拡張性の高いクラウドネイティブアプリケーションを迅速に構築できるよう支援します。

🚀 **即時利用可能 | 安全・信頼性 | 拡張容易 | フロントエンド・バックエンド統合**

---

## 🌟 特徴

- ✅ **最新技術スタックベース**：`Spring Boot 3.5.5` + `Spring Cloud 2025.0.0` +
  `Spring Cloud Alibaba 2023.0.3.3`
- 🔐 **OAuth2 認証・認可**：`Spring Security` + `JWT` 統合、統一ID認証と細粒度権限制御をサポート
- 🌐 **マイクロサービスアーキテクチャ**：モジュール分割、認証、認可、ゲートウェイ、リソースサービスを含み、独立デプロイと水平スケールをサポート
- ⚡ **高性能ゲートウェイ**：`Spring Cloud Gateway` ベースでルーティング、レート制限、サーキットブレーカー、認証を実装
- 🧩 **クラウドネイティブ対応**：Nacos、Sentinel、Seata 対応、サービス発見、設定センター、分散トランザクションをサポート
- 🎨 **モダン管理バックエンド**：[shadcn-vue/ui](https://www.shadcn-vue.com/)
  ベースのシンプルでレスポンシブな管理画面
- 📚 **ドキュメントの充実**：アーキテクチャ設計、デプロイガイド、APIドキュメントおよび二次開発の説明を網羅

---

## 🛠 技術スタック

| カテゴリ        | 技術                                                                |
|-----------|-------------------------------------------------------------------|
| **バックエンドフレームワーク**  | Spring Boot 3.5.5, Spring Cloud 2025.0.0, Spring Security, OAuth2 |
| **マイクロサービス管理** | Nacos（登録センター & 設定センター）,                                               |
| **ゲートウェイ**    | Spring Cloud Gateway                                              |
| **データベース**   | MySQL 8                                                           |
| **フロントエンドフレームワーク**  | Vue 3 + Vite + TypeScript + shadcn/ui                             |
| **ビルドツール**  | Maven, Docker, Docker Compose                                     |
| **監視**    | Spring Boot Actuator, Prometheus（オプション）, Grafana（オプション）                 |

---

## 🏗 プロジェクト構造

```bash
snail/
├── authentication/           # 認証サービス（OAuth2 認可サーバー）
├── authorization/          # 認可サービス（権限管理、ロール、メニュー）
├── gateway/               # APIゲートウェイ（ルーティング、認証、レート制限）
├── resource/              # リソースサービス（ビジネスAPIサンプル）
├── snail-vue-app/          # 管理画面（Vue3 + shadcn/ui）
└── pom.xml                      # Maven 親プロジェクト
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---