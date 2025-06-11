# مراجع هندسة تدريب التعلم الآلي والاختبارات <!-- omit from toc -->

> **تحذير**
> نحن حاليًا نقوم بإعادة هيكلة كبيرة لهذا المستودع، مع التركيز بشكل خاص على قسم حالات الاختبار. إذا كنت تفضل استخدام هيكل الدليل السابق وحالات الاختبار المهجورة، يرجى الرجوع إلى [الإصدار v1.1.0](https://github.com/aws-samples/awsome-distributed-training/releases/tag/v1.1.0).

يحتوي هذا المستودع على مراجع هندسية وحالات اختبار لتدريب النماذج الموزعة باستخدام [Amazon SageMaker Hyperpod](https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html)، و [AWS ParallelCluster](https://docs.aws.amazon.com/parallelcluster/latest/ug/what-is-aws-parallelcluster.html)، و [AWS Batch](https://docs.aws.amazon.com/batch/latest/userguide/what-is-batch.html)، و [Amazon EKS](https://docs.aws.amazon.com/eks/latest/userguide/getting-started-console.html). تغطي حالات الاختبار أنواعًا وأحجامًا مختلفة من النماذج بالإضافة إلى أُطُر مختلفة وتحسينات موازية (Pytorch DDP/FSDP، MegatronLM، NemoMegatron...).

المكونات الرئيسية لهذا الدليل هي:

```bash
reference-architectures/
|-- 1.architectures/               # قوالب CloudFormation للهندسة المرجعية
|-- 2.ami_and_containers/          # سكريبتات لإنشاء صور AMI وصور الحاويات
|-- 3.test_cases/                  # حالات اختبار مرجعية و/أو سكريبتات القياس المرجعي
|-- 4.validation_observability/    # أدوات لقياس الأداء أو استكشاف الأخطاء وإصلاحها
`-- ...
```

**ملاحظة**: تم تصميم هذه الهندسات للعمل مع دلو S3 وشبكة VPC التي تم إنشاؤها باستخدام القوالب المرجعية `1.architectures/0.s3/` و `1.architectures/1.vpc_network/`. _ننصح بشدة بنشر هذين القالبين **قبل** نشر أي من الهندسات المرجعية._

## 0. ورش العمل

يمكنك متابعة ورش العمل التالية لتدريب النماذج على AWS. يحتوي كل منها على أمثلة لعدة حالات اختبار بالإضافة إلى معلومات قيمة حول تشغيل الكتلة لتدريب نماذج اللغة الكبيرة.

| الاسم                                                                           | التعليقات
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------- |
| [Amazon SageMaker HyperPod](https://catalog.workshops.aws/sagemaker-hyperpod/en-US)   | ورشة عمل لـ SageMaker HyperPod، توضح كيفية النشر والمراقبة          |
| [AWS ParallelCluster](https://catalog.workshops.aws/ml-on-aws-parallelcluster) | ورشة عمل مشابهة لـ HyperPod ولكن على ParallelCluster                |
| [Amazon SageMaker HyperPod EKS](https://catalog.workshops.aws/sagemaker-hyperpod-eks)   | ورشة عمل لـ SageMaker HyperPod على EKS، توضح كيفية النشر والمراقبة  |

## 1. الهندسات

تقع الهندسات في `1.architectures` وتتألف من أدوات وهندسات متعلقة بالخدمات.

| الاسم                                                               | الفئة    | الاستخدام                                             |
| ------------------------------------------------------------------ | -------- | ----------------------------------------------------- |
| [`0.s3`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/0.s3)                                   | تخزين    | إنشاء دلو S3                                         |
| [`1.vpc_network`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/1.vpc_network)                 | شبكة     | إنشاء VPC مع الشبكات الفرعية والموارد المطلوبة       |
| [`2.aws-parallelcluster`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/2.aws-parallelcluster) | حوسبة    | قوالب كتلة لتدريب GPU وشرائح مخصصة                    |
| [`3.aws-batch`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/3.aws-batch)                     | حوسبة    | قالب AWS Batch للتدريب الموزع                         |
| [`4.amazon-eks`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/4.amazon-eks)                   | حوسبة    | ملفات التعريف للتدريب باستخدام Amazon EKS            |
| [`5.sagemaker-hyperpod`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/5.sagemaker-hyperpod)   | حوسبة    | قالب SageMaker HyperPod للتدريب الموزع                |

سيتم إضافة المزيد، لا تتردد في إضافة أخرى جديدة (مثلاً Ray؟). ستجد أيضًا [توثيقًا](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-cheatsheet.md) لـ EFA والمتغيرات البيئية الموصى بها.

## 2. صور أمازون المخصصة للآلات

يمكن بناء الصور المخصصة للآلات باستخدام [Packer](www.packer.io) لـ AWS ParallelCluster، Amazon EKS و EC2 العادي. هذه الصور مبنية على أدوار Ansible وملفات التشغيل (playbooks).

## 3. حالات الاختبار

تم تنظيم حالات الاختبار حسب الإطار وتغطي سيناريوهات تدريب موزعة متنوعة. تتضمن كل حالة اختبار السكريبتات والتكوينات اللازمة لتشغيل مهام التدريب الموزع.

### حالات اختبار PyTorch
- [`FSDP/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/FSDP) - أمثلة تدريب موازي بيانات مشطر بالكامل
- [`megatron-lm/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/megatron-lm) - أمثلة تدريب موزع لـ Megatron-LM
- [`nemo-launcher/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-launcher) - أمثلة NeMo Launcher للتدريب الموزع. هذه الحالة مخصصة لإصدار NeMo 1.0 فقط.
- [`nemo-run/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-run) - أمثلة إطار NeMo للتدريب الموزع. هذه الحالة لإصدار NeMo 2.0+.
- [`neuronx-distributed/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/neuronx-distributed) - أمثلة تدريب موزع لـ AWS Trainium
- [`mosaicml-composer/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/mosaicml-composer) - أمثلة MosaicML Composer
- [`picotron/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/picotron) - أمثلة تدريب موزع لـ PicoTron
- [`torchtitan/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/torchtitan) - أمثلة TorchTitan
- [`cpu-ddp/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/cpu-ddp) - أمثلة توزيع بيانات موازية على المعالج المركزي (CPU)
- [`bionemo/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/bionemo) - أمثلة تدريب موزع لـ BioNeMo

### حالات اختبار JAX
- [`jax/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/jax) - أمثلة تدريب موزع باستخدام JAX عبر PaxML

تتضمن كل حالة اختبار:
- سكريبتات التدريب والتكوينات
- تعريفات الحاويات (إذا وجدت)
- سكريبتات الإطلاق لأنواع مختلفة من الكتل
- أدوات مراقبة الأداء والتحقق

## 4. سكريبتات التحقق

توجد سكريبتات مساعدة وأمثلة على المقاييس الدقيقة في `4.validation_scripts/`. يمكن العثور على برنامج تصدير EFA Prometheus في هذا [الدليل](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter) 

| الاسم                                                                                    | التعليقات                                                        |
| --------------------------------------------------------------------------------------- | ---------------------------------------------------------------- |
| [`1.pytorch-env-validation`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/1.pytorch-env-validation) | يتحقق من بيئة PyTorch الخاصة بك                                 |
| [`3.efa-node-exporter`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter)           | برنامج تصدير العقدة مع وحدات مراقبة Amazon EFA                 |
| [`4.prometheus-grafana`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/4.prometheus-grafana)         | أصول نشر لمراقبة عناقيد SageMaker Hyperpod                     |
| [`5.nsight`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/5.nsight)                                 | يوضح كيفية تشغيل Nvidia Nsight Systems لتحليل حمل العمل الخاص بك|
| [`efa-versions.py`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-versions.py)                                  | الحصول على إصدارات مكتبات Nvidia وبرامج التشغيل وبرامج تشغيل EFA|

## 5. التكامل المستمر (CI)

اختبارات التكامل مكتوبة باستخدام [pytest](https://docs.pytest.org). فقط قم بتشغيل:

```bash
pytest .
```

بدلاً من ذلك، يمكنك تشغيل الاختبارات بدون التقاط المخرجات القياسية واحتفاظ بجميع صور الدوكر والقطع الفنية الأخرى.

```bash
pytest -s --keep-artifacts=t
```

## 6. المساهمون

شكرًا لجميع المساهمين على البناء والمراجعة والاختبار.

[![المساهمون](https://contrib.rocks/image?repo=aws-samples/awsome-distributed-training)](https://github.com/aws-samples/awsome-distributed-training/graphs/contributors)

## 7. تاريخ النجوم

[![مخطط تاريخ النجوم](https://api.star-history.com/svg?repos=aws-samples/awsome-distributed-training&type=Date)](https://star-history.com/#aws-samples/awsome-distributed-training&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---