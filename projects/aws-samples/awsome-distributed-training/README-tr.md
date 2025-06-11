# ML Eğitim Referans Mimarileri & Testler <!-- omit from toc -->

> **Uyarı**
> Bu depo şu anda büyük bir yeniden yapılandırma sürecinden geçmektedir, özellikle test vakaları bölümü üzerinde yoğunlaşılmıştır. Önceki dizin yapısını ve kullanımdan kaldırılmış test vakalarını kullanmayı tercih ederseniz, lütfen [v1.1.0](https://github.com/aws-samples/awsome-distributed-training/releases/tag/v1.1.0) sürümüne bakınız.

Bu depo, [Amazon SageMaker Hyperpod](https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html), [AWS ParallelCluster](https://docs.aws.amazon.com/parallelcluster/latest/ug/what-is-aws-parallelcluster.html), [AWS Batch](https://docs.aws.amazon.com/batch/latest/userguide/what-is-batch.html) ve [Amazon EKS](https://docs.aws.amazon.com/eks/latest/userguide/getting-started-console.html) ile dağıtılmış model eğitimi için referans mimariler ve test vakalarını içermektedir. Test vakaları, farklı tür ve boyuttaki modelleri, farklı frameworkleri ve paralel optimizasyonları (Pytorch DDP/FSDP, MegatronLM, NemoMegatron...) kapsamaktadır.

Bu dizinin ana bileşenleri şunlardır:

```bash
reference-architectures/
|-- 1.architectures/               # Referans mimariler için CloudFormation şablonları
|-- 2.ami_and_containers/          # AMI'ler ve container imajları oluşturma scriptleri
|-- 3.test_cases/                  # Referans test vakaları ve/veya benchmark scriptleri
|-- 4.validation_observability/    # Performans ölçüm veya sorun giderme araçları
`-- ...
```

**NOT**: Mimariler, `1.architectures/0.s3/` ve `1.architectures/1.vpc_network/` referans şablonları kullanılarak oluşturulan S3 bucket ve VPC ile çalışacak şekilde tasarlanmıştır. _Herhangi bir referans mimariyi dağıtmadan **önce** bu iki şablonu dağıtmanız şiddetle önerilir._

## 0. Atölyeler

Aşağıdaki atölyeleri takip ederek AWS üzerinde modeller eğitebilirsiniz. Her biri çeşitli test vakaları için örnekler ve LLM eğitimi için bir küme işletme hakkında bilgiler içerir.

| İsim                                                                           | Açıklamalar
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------- |
| [Amazon SageMaker HyperPod](https://catalog.workshops.aws/sagemaker-hyperpod/en-US)   | SageMaker HyperPod için atölye, nasıl dağıtılacağı ve izleneceğini gösterir |
| [AWS ParallelCluster](https://catalog.workshops.aws/ml-on-aws-parallelcluster) | HyperPod ile benzer atölye ama ParallelCluster için                 |
| [Amazon SageMaker HyperPod EKS](https://catalog.workshops.aws/sagemaker-hyperpod-eks)   | SageMaker HyperPod EKS için atölye, nasıl dağıtılacağı ve izleneceğini gösterir |

## 1. Mimariler

Mimariler `1.architectures` içinde yer almakta olup yardımcı programlar ve servis ile ilgili mimarilerden oluşur.

| İsim                                                               | Kategori | Kullanım                                               |
| ------------------------------------------------------------------ | -------- | ----------------------------------------------------- |
| [`0.s3`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/0.s3)                                   | Depolama  | Bir S3 bucket oluşturur                                |
| [`1.vpc_network`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/1.vpc_network)                 | Ağ  | Gerekli kaynaklarla bir VPC ve alt ağlar oluşturur     |
| [`2.aws-parallelcluster`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/2.aws-parallelcluster) | Hesaplama  | GPU & özel silikon eğitimi için küme şablonları       |
| [`3.aws-batch`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/3.aws-batch)                     | Hesaplama  | Dağıtılmış eğitim için AWS Batch şablonu               |
| [`4.amazon-eks`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/4.amazon-eks)                   | Hesaplama  | Amazon EKS ile eğitim için manifest dosyaları          |
| [`5.sagemaker-hyperpod`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/5.sagemaker-hyperpod)   | Hesaplama  | Dağıtılmış eğitim için SageMaker HyperPod şablonu      |

Daha fazlası gelecek, yeni mimariler eklemekten çekinmeyin (ör. Ray?). Ayrıca EFA ve önerilen ortam değişkenleri için [belgelere](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-cheatsheet.md) ulaşabilirsiniz.

## 2. Özel Amazon Makine İmajları

Özel makine imajları, AWS ParallelCluster, Amazon EKS ve saf EC2 için [Packer](www.packer.io) kullanılarak oluşturulabilir. Bu imajlar Ansible rollerine ve playbook'larına dayanmaktadır.

## 3. Test vakaları

Test vakaları framework bazında organize edilmiştir ve çeşitli dağıtılmış eğitim senaryolarını kapsar. Her test vakası, dağıtılmış eğitim işleri yürütmek için gerekli scriptleri ve yapılandırmaları içerir.

### PyTorch Test Vakaları
- [`FSDP/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/FSDP) - Tam Bölünmüş Veri Paralel eğitim örnekleri
- [`megatron-lm/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/megatron-lm) - Megatron-LM dağıtılmış eğitim örnekleri
- [`nemo-launcher/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-launcher) - NeMo Launcher dağıtılmış eğitim örnekleri. Bu test vakası yalnızca NeMo sürüm 1.0 içindir.
- [`nemo-run/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-run) - NeMo framework dağıtılmış eğitim örnekleri. Bu test vakası NeMo sürüm 2.0+ içindir.
- [`neuronx-distributed/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/neuronx-distributed) - AWS Trainium dağıtılmış eğitim örnekleri
- [`mosaicml-composer/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/mosaicml-composer) - MosaicML Composer örnekleri
- [`picotron/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/picotron) - PicoTron dağıtılmış eğitim örnekleri
- [`torchtitan/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/torchtitan) - TorchTitan örnekleri
- [`cpu-ddp/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/cpu-ddp) - CPU tabanlı Dağıtılmış Veri Paralel örnekleri
- [`bionemo/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/bionemo) - BioNeMo dağıtılmış eğitim örnekleri

### JAX Test Vakaları
- [`jax/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/jax) - PaxML kullanarak JAX tabanlı dağıtılmış eğitim örnekleri

Her test vakası şunları içerir:
- Eğitim scriptleri ve yapılandırmaları
- Container tanımları (varsa)
- Farklı küme türleri için başlatma scriptleri
- Performans izleme ve doğrulama araçları

## 4. Doğrulama scriptleri

Yardımcı scriptler ve mikro-benchmark örnekleri `4.validation_observability/` altında bulunmaktadır. EFA Prometheus exporter bu [dizinde](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter) bulunabilir.

| İsim                                                                                    | Açıklamalar                                                    |
| --------------------------------------------------------------------------------------- | -------------------------------------------------------------- |
| [`1.pytorch-env-validation`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/1.pytorch-env-validation) | PyTorch ortamınızı doğrular                                   |
| [`3.efa-node-exporter`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter)           | Amazon EFA izleme modülleri ile node exporter                 |
| [`4.prometheus-grafana`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/4.prometheus-grafana)         | SageMaker Hyperpod Kümelerini izlemek için dağıtım varlıkları  |
| [`5.nsight`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/5.nsight)                                 | İş yükünüzü profil çıkarmak için Nvidia Nsight Systems nasıl çalıştırılır |
| [`efa-versions.py`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-versions.py)                                  | Nvidia kütüphane, sürücü ve EFA sürümlerini alır              |


## 5. CI

Entegrasyon testleri [pytest](https://docs.pytest.org) ile yazılmıştır. Aşağıdaki komutu çalıştırmanız yeterlidir:

```bash
pytest .
```

Alternatif olarak stdout yakalamadan ve tüm docker imajları ile diğer artefaktları koruyarak testleri çalıştırabilirsiniz.

```bash
pytest -s --keep-artifacts=t
```

## 6. Katkıda Bulunanlar

Yapılandırma, inceleme ve test için katkıda bulunan herkese teşekkürler.

[![Katkıda Bulunanlar](https://contrib.rocks/image?repo=aws-samples/awsome-distributed-training)](https://github.com/aws-samples/awsome-distributed-training/graphs/contributors)

## 7. Yıldız Geçmişi

[![Yıldız Geçmişi Grafiği](https://api.star-history.com/svg?repos=aws-samples/awsome-distributed-training&type=Date)](https://star-history.com/#aws-samples/awsome-distributed-training&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---