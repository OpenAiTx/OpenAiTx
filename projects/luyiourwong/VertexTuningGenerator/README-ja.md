[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=luyiourwong_VertexTuningGenerator&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=luyiourwong_VertexTuningGenerator)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=luyiourwong_VertexTuningGenerator&metric=coverage)](https://sonarcloud.io/summary/new_code?id=luyiourwong_VertexTuningGenerator)

# Vertex Tuning Generator / Editor

A single page application for GCP VertexAI tuning dataset generator.

## Reference Documentation

[VertexAI Model tuning](https://console.cloud.google.com/vertex-ai/studio/tuning)

[VertexAI Model tuning documentation](https://cloud.google.com/vertex-ai/generative-ai/docs/models/tune-models)

[Fine tuning use cases](https://cloud.google.com/transform/top-five-gen-ai-tuning-use-cases-gemini-hundreds-of-orgs)

## Sample dataset (from [tuning document](https://cloud.google.com/vertex-ai/generative-ai/docs/models/tune_gemini/text_tune#sample-datasets))

[Gemini 2.0 training dataset](https://storage.googleapis.com/cloud-samples-data/ai-platform/generative_ai/gemini-2_0/text/sft_train_data.jsonl)

[Gemini 2.0 validation dataset](https://storage.googleapis.com/cloud-samples-data/ai-platform/generative_ai/gemini-2_0/text/sft_validation_data.jsonl)

## Use online

[![pages-build-deployment](https://github.com/luyiourwong/VertexTuningGenerator/actions/workflows/pages/pages-build-deployment/badge.svg?branch=gh-pages)](https://github.com/luyiourwong/VertexTuningGenerator/actions/workflows/pages/pages-build-deployment)

[Online Application on Github pages](https://luyiourwong.github.io/VertexTuningGenerator/)

## Development

### Project Setup

```sh
npm install
```

### 開発のためのコンパイルとホットリロード

```sh
npm run dev
```

### テストとカバレッジレポート
レポートは `./coverage` にあり、Sonarは `./coverage/lcov.info` のlcovを使用します。
```sh
npm run test:coverage
```
## 貢献について

貢献は歓迎します！

コードはデプロイを進めるために品質基準をクリアする必要があります。

<details>
<summary><strong>📋 コード品質基準</strong></summary>

すべてのプルリクエストはマージ前にSonarQubeの以下の品質ゲートを通過する必要があります：

- 信頼性評価：A
- セキュリティ評価：A
- 保守性評価：A
- 最低カバレッジ要件：80%
- 許容される重複コードの最大割合：3%

> 注：分析結果はPRチェックおよび[SonarCloud](https://sonarcloud.io/project/pull_requests_list?id=luyiourwong_VertexTuningGenerator)で確認できます
</details>

## GitHub Actions

このリポジトリにはコード品質の維持とデプロイの自動化を支援するGitHub Actionsが設定されています：

1. **`main`へのプルリクエスト**：
    - 自動的にSonarQubeスキャン、単体テスト、コードカバレッジレポートを生成します。
    - Gemini Code Assistボットがスキャン結果に基づき自動でプルリクエストをレビューしコメントします。

2. **`main`へのプッシュ**：
    - 自動的にSonarQubeスキャン、単体テスト、コードカバレッジレポートを生成します。
    - 品質ゲートを通過した場合、サイトが自動的に**GitHub Pages**にデプロイされます。

## リンク

- [GitHubリポジトリ](https://github.com/luyiourwong/VertexTuningGenerator)
- [イシュートラッカー](https://github.com/luyiourwong/VertexTuningGenerator/issues)
- [CI/CD](https://github.com/luyiourwong/VertexTuningGenerator/actions)
- [Sonarcloud](https://sonarcloud.io/project/overview?id=luyiourwong_VertexTuningGenerator)
- [Github pages](https://luyiourwong.github.io/VertexTuningGenerator/)


## ライセンス

このプロジェクトは[MITライセンス](LICENSE)の下でライセンスされています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---