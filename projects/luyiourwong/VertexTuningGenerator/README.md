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

### Compile and Hot-Reload for Development

```sh
npm run dev
```

### Test and coverage report
Report at `./coverage`, sonar will use the lcov on `./coverage/lcov.info`.
```sh
npm run test:coverage
```

## Contributing

Contributions are welcome!

Code must passed quality standards to process deploy.

<details>
<summary><strong>📋 Code Quality Standards</strong></summary>

All pull requests must pass the following quality gates in SonarQube before being merged:

- Reliability Rating: A
- Security Rating: A
- Maintainability Rating: A
- Minimum coverage requirement: 80%
- Maximum allowed duplicated code: 3%

> Note: You can monitor the analysis results in the PR checks and on [SonarCloud](https://sonarcloud.io/project/pull_requests_list?id=luyiourwong_VertexTuningGenerator)
</details>

## GitHub Actions

This repository has GitHub Actions configured to help maintain code quality and automate deployments:

1. **Pull Requests to `main`**:
    - Automatically trigger a SonarQube scan, unit test and generate a code coverage report.
    - Gemini Code Assist bot will automatically review and comment on the pull request based on the scan results.

2. **Pushes to `main`**:
    - Automatically trigger a SonarQube scan, unit test and generate a code coverage report.
    - If the quality gate passes, the site is automatically deployed to **GitHub Pages**.

## Links

- [GitHub Repository](https://github.com/luyiourwong/VertexTuningGenerator)
- [Issue Tracker](https://github.com/luyiourwong/VertexTuningGenerator/issues)
- [CI/CD](https://github.com/luyiourwong/VertexTuningGenerator/actions)
- [Sonarcloud](https://sonarcloud.io/project/overview?id=luyiourwong_VertexTuningGenerator)
- [Github pages](https://luyiourwong.github.io/VertexTuningGenerator/)

## License

This project is licensed under the [MIT License](LICENSE).
