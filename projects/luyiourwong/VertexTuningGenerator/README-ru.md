
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
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

[![Статус контроля качества](https://sonarcloud.io/api/project_badges/measure?project=luyiourwong_VertexTuningGenerator&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=luyiourwong_VertexTuningGenerator)
[![Покрытие](https://sonarcloud.io/api/project_badges/measure?project=luyiourwong_VertexTuningGenerator&metric=coverage)](https://sonarcloud.io/summary/new_code?id=luyiourwong_VertexTuningGenerator)

# Генератор / Редактор Vertex Tuning

Одностраничное приложение для генерации датасетов для настройки GCP VertexAI.

## Справочная документация

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

### Компиляция и горячая перезагрузка для разработки

```sh
npm run dev
```

### Отчет о тестировании и покрытии
Отчет находится в `./coverage`, sonar будет использовать lcov из `./coverage/lcov.info`.
```sh
npm run test:coverage
```

## Вклад

Вклад приветствуется!

Код должен соответствовать стандартам качества для развертывания.

<details>
<summary><strong>📋 Стандарты качества кода</strong></summary>

Все pull-запросы должны проходить следующие контрольные точки качества в SonarQube перед слиянием:

- Оценка надежности: A
- Оценка безопасности: A
- Оценка поддерживаемости: A
- Минимальное требование по покрытию тестами: 80%
- Максимально допустимое количество дублированного кода: 3%

> Примечание: Вы можете отслеживать результаты анализа в проверках PR и на [SonarCloud](https://sonarcloud.io/project/pull_requests_list?id=luyiourwong_VertexTuningGenerator)
</details>

## GitHub Actions

В этом репозитории настроены GitHub Actions для поддержания качества кода и автоматизации развертываний:

1. **Pull-запросы в `main`**:
    - Автоматически запускается сканирование SonarQube, юнит-тестирование и формируется отчет о покрытии кода.
    - Бот Gemini Code Assist автоматически рецензирует и комментирует pull-запрос на основе результатов сканирования.

2. **Push в `main`**:
    - Автоматически запускается сканирование SonarQube, юнит-тестирование и формируется отчет о покрытии кода.
    - Если контроль качества пройден, сайт автоматически разворачивается на **GitHub Pages**.

## Ссылки

- [Репозиторий на GitHub](https://github.com/luyiourwong/VertexTuningGenerator)
- [Трекер задач](https://github.com/luyiourwong/VertexTuningGenerator/issues)
- [CI/CD](https://github.com/luyiourwong/VertexTuningGenerator/actions)
- [Sonarcloud](https://sonarcloud.io/project/overview?id=luyiourwong_VertexTuningGenerator)
- [Github Pages](https://luyiourwong.github.io/VertexTuningGenerator/)

## Лицензия

Этот проект лицензирован на условиях [лицензии MIT](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---