
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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

[![Status do Portal de Qualidade](https://sonarcloud.io/api/project_badges/measure?project=luyiourwong_VertexTuningGenerator&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=luyiourwong_VertexTuningGenerator)
[![Cobertura](https://sonarcloud.io/api/project_badges/measure?project=luyiourwong_VertexTuningGenerator&metric=coverage)](https://sonarcloud.io/summary/new_code?id=luyiourwong_VertexTuningGenerator)

# Gerador / Editor de Ajuste de Vertex

Uma aplicação de página única para geração de conjuntos de dados de ajuste do GCP VertexAI.

## Documentação de Referência

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

### Compilar e Atualizar Automaticamente para Desenvolvimento

```sh
npm run dev
```

### Relatório de teste e cobertura
Relatório em `./coverage`, o sonar usará o lcov em `./coverage/lcov.info`.
```sh
npm run test:coverage
```

## Contribuindo

Contribuições são bem-vindas!

O código deve atender aos padrões de qualidade para ser implantado.

<details>
<summary><strong>📋 Padrões de Qualidade de Código</strong></summary>

Todos os pull requests devem passar pelos seguintes critérios de qualidade no SonarQube antes de serem mesclados:

- Classificação de Confiabilidade: A
- Classificação de Segurança: A
- Classificação de Manutenibilidade: A
- Cobertura mínima exigida: 80%
- Código duplicado máximo permitido: 3%

> Nota: Você pode monitorar os resultados da análise nos checks do PR e em [SonarCloud](https://sonarcloud.io/project/pull_requests_list?id=luyiourwong_VertexTuningGenerator)
</details>

## GitHub Actions

Este repositório possui GitHub Actions configuradas para ajudar a manter a qualidade do código e automatizar implantações:

1. **Pull Requests para `main`**:
    - Dispara automaticamente uma análise SonarQube, teste unitário e gera um relatório de cobertura de código.
    - O bot Gemini Code Assist irá revisar e comentar automaticamente no pull request baseado nos resultados da análise.

2. **Pushes para `main`**:
    - Dispara automaticamente uma análise SonarQube, teste unitário e gera um relatório de cobertura de código.
    - Se o critério de qualidade for aprovado, o site é implantado automaticamente no **GitHub Pages**.

## Links

- [Repositório GitHub](https://github.com/luyiourwong/VertexTuningGenerator)
- [Rastreador de Issues](https://github.com/luyiourwong/VertexTuningGenerator/issues)
- [CI/CD](https://github.com/luyiourwong/VertexTuningGenerator/actions)
- [Sonarcloud](https://sonarcloud.io/project/overview?id=luyiourwong_VertexTuningGenerator)
- [Github pages](https://luyiourwong.github.io/VertexTuningGenerator/)

## Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---