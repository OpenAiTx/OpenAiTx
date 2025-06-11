# معماری‌های مرجع آموزش ML و تست‌ها <!-- omit from toc -->

> **هشدار**
> در حال حاضر در حال انجام یک بازسازی عمده در این مخزن هستیم، به‌ویژه در بخش موارد تست. اگر ترجیح می‌دهید از ساختار دایرکتوری قبلی و موارد تست منسوخ شده استفاده کنید، لطفاً به [v1.1.0](https://github.com/aws-samples/awsome-distributed-training/releases/tag/v1.1.0) مراجعه کنید.

این مخزن شامل معماری‌های مرجع و موارد تست برای آموزش مدل توزیع‌شده با [Amazon SageMaker Hyperpod](https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html)، [AWS ParallelCluster](https://docs.aws.amazon.com/parallelcluster/latest/ug/what-is-aws-parallelcluster.html)، [AWS Batch](https://docs.aws.amazon.com/batch/latest/userguide/what-is-batch.html) و [Amazon EKS](https://docs.aws.amazon.com/eks/latest/userguide/getting-started-console.html) است. موارد تست انواع و اندازه‌های مختلف مدل‌ها را پوشش می‌دهند و همچنین فریمورک‌ها و بهینه‌سازی‌های موازی مختلف (Pytorch DDP/FSDP، MegatronLM، NemoMegatron و غیره) را شامل می‌شوند.

اجزای اصلی این دایرکتوری عبارتند از:

```bash
reference-architectures/
|-- 1.architectures/               # قالب‌های CloudFormation برای معماری مرجع
|-- 2.ami_and_containers/          # اسکریپت‌ها برای ایجاد AMI و ایمیج‌های کانتینر
|-- 3.test_cases/                  # موارد تست مرجع و/یا اسکریپت‌های بنچمارک
|-- 4.validation_observability/    # ابزارهایی برای اندازه‌گیری عملکرد یا عیب‌یابی
`-- ...
```

**توجه**: معماری‌ها برای کار با سطل S3 و VPC ایجاد شده با استفاده از قالب‌های مرجع `1.architectures/0.s3/` و `1.architectures/1.vpc_network/` طراحی شده‌اند. _به شدت توصیه می‌شود این دو قالب را **قبل از** استقرار هر یک از معماری‌های مرجع، پیاده‌سازی کنید._

## 0. کارگاه‌ها

شما می‌توانید از کارگاه‌های زیر برای آموزش مدل‌ها روی AWS استفاده کنید. هر کدام شامل مثال‌هایی برای چندین مورد تست و نکات مهم درباره راه‌اندازی خوشه برای آموزش LLM هستند.

| نام                                                                            | توضیحات                                                         |
| ------------------------------------------------------------------------------ | ---------------------------------------------------------------- |
| [Amazon SageMaker HyperPod](https://catalog.workshops.aws/sagemaker-hyperpod/en-US)   | کارگاه برای SageMaker HyperPod، نشان می‌دهد چگونه آن را مستقر و مانیتور کنید |
| [AWS ParallelCluster](https://catalog.workshops.aws/ml-on-aws-parallelcluster) | کارگاه مشابه HyperPod اما روی ParallelCluster                   |
| [Amazon SageMaker HyperPod EKS](https://catalog.workshops.aws/sagemaker-hyperpod-eks)   | کارگاه برای SageMaker HyperPod EKS، نشان می‌دهد چگونه آن را مستقر و مانیتور کنید |

## 1. معماری‌ها

معماری‌ها در `1.architectures` قرار دارند و شامل ابزارها و معماری‌های مرتبط با سرویس هستند.

| نام                                                               | دسته‌بندی | کاربرد                                               |
| ------------------------------------------------------------------ | -------- | --------------------------------------------------- |
| [`0.s3`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/0.s3)                                   | ذخیره‌سازی  | ایجاد یک سطل S3                                   |
| [`1.vpc_network`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/1.vpc_network)                 | شبکه  | ایجاد یک VPC با ساب‌نت‌ها و منابع مورد نیاز        |
| [`2.aws-parallelcluster`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/2.aws-parallelcluster) | محاسبات  | قالب‌های خوشه برای آموزش GPU و سیلیکون سفارشی     |
| [`3.aws-batch`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/3.aws-batch)                     | محاسبات  | قالب AWS Batch برای آموزش توزیع‌شده                 |
| [`4.amazon-eks`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/4.amazon-eks)                   | محاسبات  | فایل‌های manifest برای آموزش با Amazon EKS         |
| [`5.sagemaker-hyperpod`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/5.sagemaker-hyperpod)   | محاسبات  | قالب SageMaker HyperPod برای آموزش توزیع‌شده       |

موارد بیشتری اضافه خواهد شد، می‌توانید موارد جدیدی اضافه کنید (مثلاً Ray؟). همچنین می‌توانید [مستندات](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-cheatsheet.md) مربوط به EFA و متغیرهای محیطی پیشنهادی را بیابید.

## 2. ایمیج‌های سفارشی ماشین آمازون

ایمیج‌های سفارشی ماشین می‌توانند با استفاده از [Packer](https://www.packer.io) برای AWS ParallelCluster، Amazon EKS و EC2 ساده ساخته شوند. این ایمیج‌ها مبتنی بر نقش‌ها و playbook‌های Ansible هستند.

## 3. موارد تست

موارد تست بر اساس فریمورک سازماندهی شده و سناریوهای مختلف آموزش توزیع‌شده را پوشش می‌دهند. هر مورد تست شامل اسکریپت‌ها و پیکربندی‌های لازم برای اجرای کارهای آموزش توزیع‌شده است.

### موارد تست PyTorch
- [`FSDP/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/FSDP) - مثال‌های آموزش موازی داده کاملاً تقسیم شده (Fully Sharded Data Parallel)
- [`megatron-lm/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/megatron-lm) - مثال‌های آموزش توزیع‌شده Megatron-LM
- [`nemo-launcher/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-launcher) - مثال‌های NeMo Launcher برای آموزش توزیع‌شده. این مورد برای نسخه 1.0 NeMo است.
- [`nemo-run/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-run) - مثال‌های فریمورک NeMo برای آموزش توزیع‌شده. این مورد برای نسخه 2.0+ NeMo است.
- [`neuronx-distributed/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/neuronx-distributed) - مثال‌های آموزش توزیع‌شده AWS Trainium
- [`mosaicml-composer/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/mosaicml-composer) - مثال‌های MosaicML Composer
- [`picotron/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/picotron) - مثال‌های آموزش توزیع‌شده PicoTron
- [`torchtitan/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/torchtitan) - مثال‌های TorchTitan
- [`cpu-ddp/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/cpu-ddp) - مثال‌های آموزش موازی داده توزیع‌شده مبتنی بر CPU
- [`bionemo/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/bionemo) - مثال‌های آموزش توزیع‌شده BioNeMo

### موارد تست JAX
- [`jax/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/jax) - مثال‌های آموزش توزیع‌شده مبتنی بر JAX با استفاده از PaxML

هر مورد تست شامل:
- اسکریپت‌ها و پیکربندی‌های آموزش
- تعریف کانتینرها (در صورت نیاز)
- اسکریپت‌های راه‌اندازی برای انواع مختلف خوشه‌ها
- ابزارهای مانیتورینگ عملکرد و اعتبارسنجی

## 4. اسکریپت‌های اعتبارسنجی

اسکریپت‌های ابزار و نمونه‌های میکروبنچمارک در `4.validation_scripts/` قرار دارند. اکسپورتر EFA Prometheus را می‌توانید در این [دایرکتوری](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter) بیابید.

| نام                                                                                      | توضیحات                                                        |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------- |
| [`1.pytorch-env-validation`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/1.pytorch-env-validation) | اعتبارسنجی محیط PyTorch شما                              |
| [`3.efa-node-exporter`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter)           | اکسپورتر نود با ماژول‌های مانیتورینگ Amazon EFA                |
| [`4.prometheus-grafana`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/4.prometheus-grafana)         | دارایی‌های استقرار برای مانیتورینگ خوشه‌های SageMaker Hyperpod        |
| [`5.nsight`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/5.nsight)                                 | نشان می‌دهد چگونه Nvidia Nsight Systems را برای پروفایل بار کاری خود اجرا کنید |
| [`efa-versions.py`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-versions.py)                                  | دریافت نسخه‌های کتابخانه‌ها، درایورها و درایورهای EFA Nvidia   |

## 5. CI

تست‌های یکپارچه‌سازی با [pytest](https://docs.pytest.org) نوشته شده‌اند. فقط کافی است اجرا کنید:

```bash
pytest .
```

همچنین می‌توانید تست‌ها را بدون ضبط stdout و با حفظ همه ایمیج‌های داکر و سایر مصنوعات اجرا کنید:

```bash
pytest -s --keep-artifacts=t
```

## 6. مشارکت‌کنندگان

از همه مشارکت‌کنندگان برای ساخت، بازبینی و تست تشکر می‌کنیم.

[![Contributors](https://contrib.rocks/image?repo=aws-samples/awsome-distributed-training)](https://github.com/aws-samples/awsome-distributed-training/graphs/contributors)

## 7. تاریخچه ستاره‌ها

[![Star History Chart](https://api.star-history.com/svg?repos=aws-samples/awsome-distributed-training&type=Date)](https://star-history.com/#aws-samples/awsome-distributed-training&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---