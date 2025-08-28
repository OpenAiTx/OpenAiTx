
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![Stato Quality Gate](https://sonarcloud.io/api/project_badges/measure?project=luyiourwong_VertexTuningGenerator&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=luyiourwong_VertexTuningGenerator)
[![Copertura](https://sonarcloud.io/api/project_badges/measure?project=luyiourwong_VertexTuningGenerator&metric=coverage)](https://sonarcloud.io/summary/new_code?id=luyiourwong_VertexTuningGenerator)

# Vertex Tuning Generator / Editor

Un'applicazione a pagina singola per la generazione di dataset di tuning di GCP VertexAI.

## Documentazione di riferimento

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

### Compilazione e Hot-Reload per lo Sviluppo

```sh
npm run dev
```

### Report di test e copertura
Il report si trova in `./coverage`, sonar utilizzerà l'lcov su `./coverage/lcov.info`.
```sh
npm run test:coverage
```

## Contributi

I contributi sono benvenuti!

Il codice deve rispettare gli standard di qualità per poter essere distribuito.

<details>
<summary><strong>📋 Standard di Qualità del Codice</strong></summary>

Tutte le pull request devono superare i seguenti controlli di qualità in SonarQube prima di essere unite:

- Affidabilità: A
- Sicurezza: A
- Manutenibilità: A
- Copertura minima richiesta: 80%
- Codice duplicato massimo consentito: 3%

> Nota: Puoi monitorare i risultati dell’analisi nei controlli PR e su [SonarCloud](https://sonarcloud.io/project/pull_requests_list?id=luyiourwong_VertexTuningGenerator)
</details>

## GitHub Actions

Questo repository ha GitHub Actions configurate per mantenere la qualità del codice e automatizzare i deploy:

1. **Pull Request su `main`**:
    - Avvia automaticamente una scansione SonarQube, un test unitario e genera un report di copertura del codice.
    - Il bot Gemini Code Assist recensirà e commenterà automaticamente la pull request in base ai risultati della scansione.

2. **Push su `main`**:
    - Avvia automaticamente una scansione SonarQube, un test unitario e genera un report di copertura del codice.
    - Se il controllo qualità viene superato, il sito viene automaticamente distribuito su **GitHub Pages**.

## Link

- [Repository GitHub](https://github.com/luyiourwong/VertexTuningGenerator)
- [Issue Tracker](https://github.com/luyiourwong/VertexTuningGenerator/issues)
- [CI/CD](https://github.com/luyiourwong/VertexTuningGenerator/actions)
- [Sonarcloud](https://sonarcloud.io/project/overview?id=luyiourwong_VertexTuningGenerator)
- [Github pages](https://luyiourwong.github.io/VertexTuningGenerator/)

## Licenza

Questo progetto è distribuito sotto la [Licenza MIT](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---