# OCI AI Blueprints

**Разворачивайте, масштабируйте и мониторьте AI-нагрузки с помощью платформы OCI AI Blueprints и сокращайте время запуска GPU с недель до минут.**

OCI AI Blueprints — это упрощённое, не требующее программирования решение для развертывания и управления генеративными AI-нагрузками на Kubernetes Engine (OKE). Благодаря заранее подобранным аппаратным рекомендациям, готовым программным стекам и встроенным средствам наблюдения, OCI AI Blueprints позволяет быстро и эффективно запускать ваши AI-приложения — без необходимости разбираться в сложностях инфраструктуры, совместимости ПО и лучших практиках MLOps.

[![Установить OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## Содержание

**Начало работы**

- [Установка AI Blueprints](./GETTING_STARTED_README.md)
- [Доступ к порталу и API AI Blueprints](docs/usage_guide.md)

**О OCI AI Blueprints**

- [Что такое OCI AI Blueprints?](docs/about.md)
- [Зачем использовать OCI AI Blueprints?](docs/about.md)
- [Возможности](docs/about.md)
- [Список Blueprints](#blueprints)
- [FAQ](docs/about.md)
- [Поддержка и контакты](https://github.com/oracle-quickstart/oci-ai-blueprints/blob/vkammari/doc_improvements/docs/about/README.md#frequently-asked-questions-faq)

**Справочник API**

- [Документация по API](docs/api_documentation.md)

**Дополнительные ресурсы**

- [Публикация пользовательских Blueprints](./docs/custom_blueprints)
- [Установка обновлений](docs/installing_new_updates.md)
- [Политики IAM](docs/iam_policies.md)
- [Содержимое репозитория](docs/about.md)
- [Известные проблемы](docs/known_issues.md)

## Начало работы

Установите OCI AI Blueprints, нажав на кнопку ниже:

[![Установить OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## Blueprints

Blueprints выходят за пределы стандартных Terraform-шаблонов. Каждый blueprint:

- Предлагает проверенные аппаратные рекомендации (например, оптимальные типы машин, конфигурации CPU/GPU),
- Включает end-to-end стеки приложений, адаптированные под различные сценарии GenAI,
- Содержит мониторинг, логирование и авто-масштабирование "из коробки".

После установки OCI AI Blueprints на кластер OKE в вашем tenancy вы можете развернуть эти готовые blueprints:

| Blueprint                                                                                     | Описание                                                                                                                               |
| --------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------- |
| [**LLM & VLM Inference с vLLM**](docs/sample_blueprints/llm_inference_with_vllm/README.md)    | Развертывание моделей Llama 2/3/3.1 7B/8B на GPU NVIDIA с использованием vLLM-инференса и авто-масштабирования.                        |
| [**Fine-Tuning Benchmarking**](./docs/sample_blueprints/lora-benchmarking)                    | Запуск MLCommons квантованного Llama-2 70B LoRA фонтюнинга на A100 для бенчмаркинга производительности.                                |
| [**LoRA Fine-Tuning**](./docs/sample_blueprints/lora-fine-tuning)                             | LoRA-файнтюнинг кастомных или HuggingFace моделей на любых датасетах. Гибкая настройка гиперпараметров.                                |
| [**Health Check**](./docs/sample_blueprints/gpu-health-check)                                 | Комплексная оценка производительности GPU для обеспечения готовности оборудования перед запуском вычислительно-интенсивных задач.      |
| [**CPU Inference**](./docs/sample_blueprints/cpu-inference)                                   | Используйте Ollama для тестирования инференса на CPU с моделями Mistral, Gemma и другими.                                              |
| [**Мульти-нода инференс с RDMA и vLLM**](./docs/sample_blueprints/multi-node-inference/)      | Развертывание Llama-405B моделей на нескольких нодах с RDMA, используя H100-ноды, vLLM и LeaderWorkerSet.                             |
| [**Автомасштабируемый инференс с vLLM**](./docs/sample_blueprints/auto_scaling/)              | Обслуживание LLM с авто-масштабированием через KEDA: масштабирование на несколько GPU и нод на основе метрик приложения (например, latency). |
| [**LLM Inference с MIG**](./docs/sample_blueprints/mig_multi_instance_gpu/)                   | Развертывание LLM на части GPU с использованием мульти-инстанс GPU Nvidia и vLLM.                                                      |
| [**Очередь заданий**](./docs/sample_blueprints/teams)                                         | Используйте очереди заданий, лимиты ресурсов и справедливое распределение между командами.                                             |

## Поддержка и контакты

Если у вас есть вопросы, проблемы или предложения, свяжитесь с [vishnu.kammari@oracle.com](mailto:vishnu.kammari@oracle.com) или [grant.neuman@oracle.com](mailto:grant.neuman@oracle.com).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---