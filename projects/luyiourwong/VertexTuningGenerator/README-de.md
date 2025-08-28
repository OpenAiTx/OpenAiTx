
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=ja">Japanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=ko">Koreanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=th">Thailändisch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=fa">Persisch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![Qualitätsstatus](https://sonarcloud.io/api/project_badges/measure?project=luyiourwong_VertexTuningGenerator&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=luyiourwong_VertexTuningGenerator)
[![Testabdeckung](https://sonarcloud.io/api/project_badges/measure?project=luyiourwong_VertexTuningGenerator&metric=coverage)](https://sonarcloud.io/summary/new_code?id=luyiourwong_VertexTuningGenerator)

# Vertex Tuning Generator / Editor

Eine Single-Page-Anwendung zur Erstellung von GCP VertexAI-Tuning-Datensätzen.

## Referenzdokumentation

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

### Kompilieren und Hot-Reload für die Entwicklung

```sh
npm run dev
```

### Test- und Abdeckungsbericht
Bericht unter `./coverage`, Sonar verwendet die lcov-Datei unter `./coverage/lcov.info`.
```sh
npm run test:coverage
```

## Beitrag leisten

Beiträge sind willkommen!

Der Code muss Qualitätsstandards erfüllen, um bereitgestellt werden zu können.

<details>
<summary><strong>📋 Code-Qualitätsstandards</strong></summary>

Alle Pull Requests müssen die folgenden Qualitätskriterien in SonarQube bestehen, bevor sie zusammengeführt werden:

- Zuverlässigkeitsbewertung: A
- Sicherheitsbewertung: A
- Wartbarkeitsbewertung: A
- Mindestabdeckungsanforderung: 80%
- Maximal erlaubter doppelter Code: 3%

> Hinweis: Die Analyseergebnisse können in den PR-Checks und auf [SonarCloud](https://sonarcloud.io/project/pull_requests_list?id=luyiourwong_VertexTuningGenerator) überwacht werden.
</details>

## GitHub Actions

Dieses Repository verwendet GitHub Actions, um die Codequalität zu sichern und Deployments zu automatisieren:

1. **Pull Requests zu `main`**:
    - Führt automatisch einen SonarQube-Scan, Unit-Tests und einen Bericht zur Codeabdeckung aus.
    - Der Gemini Code Assist Bot überprüft und kommentiert automatisch den Pull Request basierend auf den Scan-Ergebnissen.

2. **Pushes zu `main`**:
    - Führt automatisch einen SonarQube-Scan, Unit-Tests und einen Bericht zur Codeabdeckung aus.
    - Wenn das Qualitätskriterium besteht, wird die Seite automatisch auf **GitHub Pages** bereitgestellt.

## Links

- [GitHub Repository](https://github.com/luyiourwong/VertexTuningGenerator)
- [Issue Tracker](https://github.com/luyiourwong/VertexTuningGenerator/issues)
- [CI/CD](https://github.com/luyiourwong/VertexTuningGenerator/actions)
- [Sonarcloud](https://sonarcloud.io/project/overview?id=luyiourwong_VertexTuningGenerator)
- [Github pages](https://luyiourwong.github.io/VertexTuningGenerator/)

## Lizenz

Dieses Projekt ist unter der [MIT-Lizenz](LICENSE) lizenziert.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---