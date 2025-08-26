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

### Compilar y recargar en caliente para desarrollo

```sh
npm run dev
```

### Informe de pruebas y cobertura
Informe en `./coverage`, sonar usará el lcov en `./coverage/lcov.info`.
```sh
npm run test:coverage
```

## Contribuyendo

¡Se aceptan contribuciones!

El código debe pasar los estándares de calidad para procesar el despliegue.

<details>
<summary><strong>📋 Estándares de Calidad de Código</strong></summary>

Todas las solicitudes de extracción deben pasar las siguientes puertas de calidad en SonarQube antes de ser fusionadas:

- Calificación de Fiabilidad: A
- Calificación de Seguridad: A
- Calificación de Mantenibilidad: A
- Requisito mínimo de cobertura: 80%
- Código duplicado máximo permitido: 3%

> Nota: Puedes monitorear los resultados del análisis en las verificaciones del PR y en [SonarCloud](https://sonarcloud.io/project/pull_requests_list?id=luyiourwong_VertexTuningGenerator)
</details>

## Acciones de GitHub

Este repositorio tiene configuradas Acciones de GitHub para ayudar a mantener la calidad del código y automatizar los despliegues:

1. **Solicitudes de extracción a `main`**:
    - Dispara automáticamente un escaneo SonarQube, pruebas unitarias y genera un reporte de cobertura de código.
    - El bot Gemini Code Assist revisará y comentará automáticamente la solicitud de extracción basándose en los resultados del escaneo.

2. **Push a `main`**:
    - Dispara automáticamente un escaneo SonarQube, pruebas unitarias y genera un reporte de cobertura de código.
    - Si la puerta de calidad se aprueba, el sitio se despliega automáticamente en **GitHub Pages**.

## Enlaces

- [Repositorio de GitHub](https://github.com/luyiourwong/VertexTuningGenerator)
- [Rastreador de Problemas](https://github.com/luyiourwong/VertexTuningGenerator/issues)
- [CI/CD](https://github.com/luyiourwong/VertexTuningGenerator/actions)
- [Sonarcloud](https://sonarcloud.io/project/overview?id=luyiourwong_VertexTuningGenerator)
- [Github pages](https://luyiourwong.github.io/VertexTuningGenerator/)

## Licencia

Este proyecto está licenciado bajo la [Licencia MIT](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---