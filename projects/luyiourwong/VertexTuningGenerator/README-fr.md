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
### Compiler et recharger à chaud pour le développement


```sh
npm run dev
```

### Rapport de test et de couverture
Rapport dans `./coverage`, sonar utilisera le lcov dans `./coverage/lcov.info`.
```sh
npm run test:coverage
```

## Contribution

Les contributions sont les bienvenues !

Le code doit passer les standards de qualité pour être déployé.

<details>
<summary><strong>📋 Normes de Qualité du Code</strong></summary>

Toutes les pull requests doivent passer les portes de qualité suivantes dans SonarQube avant d’être fusionnées :

- Note de Fiabilité : A
- Note de Sécurité : A
- Note de Maintenabilité : A
- Exigence minimale de couverture : 80%
- Code dupliqué maximal autorisé : 3%

> Remarque : Vous pouvez suivre les résultats de l’analyse dans les vérifications de la PR et sur [SonarCloud](https://sonarcloud.io/project/pull_requests_list?id=luyiourwong_VertexTuningGenerator)
</details>

## Actions GitHub

Ce dépôt a des Actions GitHub configurées pour aider à maintenir la qualité du code et automatiser les déploiements :

1. **Pull Requests vers `main`** :
    - Déclenche automatiquement une analyse SonarQube, des tests unitaires et génère un rapport de couverture de code.
    - Le bot Gemini Code Assist examinera automatiquement et commentera la pull request en fonction des résultats de l’analyse.

2. **Push vers `main`** :
    - Déclenche automatiquement une analyse SonarQube, des tests unitaires et génère un rapport de couverture de code.
    - Si la porte de qualité est franchie, le site est automatiquement déployé sur **GitHub Pages**.

## Liens

- [Dépôt GitHub](https://github.com/luyiourwong/VertexTuningGenerator)
- [Suivi des Problèmes](https://github.com/luyiourwong/VertexTuningGenerator/issues)
- [CI/CD](https://github.com/luyiourwong/VertexTuningGenerator/actions)
- [Sonarcloud](https://sonarcloud.io/project/overview?id=luyiourwong_VertexTuningGenerator)
- [Pages Github](https://luyiourwong.github.io/VertexTuningGenerator/)

## Licence

Ce projet est sous licence [MIT License](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---