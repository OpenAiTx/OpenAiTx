# ML Training Reference Architectures & Tests <!-- omit from toc -->

> **Peringatan**
> Kami saat ini sedang melakukan refactoring besar pada repositori ini, terutama fokus pada bagian test cases. Jika Anda lebih memilih menggunakan struktur direktori sebelumnya dan test cases yang sudah tidak digunakan, silakan lihat [v1.1.0](https://github.com/aws-samples/awsome-distributed-training/releases/tag/v1.1.0).


Repositori ini berisi arsitektur referensi dan test cases untuk pelatihan model terdistribusi dengan [Amazon SageMaker Hyperpod](https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html), [AWS ParallelCluster](https://docs.aws.amazon.com/parallelcluster/latest/ug/what-is-aws-parallelcluster.html), [AWS Batch](https://docs.aws.amazon.com/batch/latest/userguide/what-is-batch.html), dan [Amazon EKS](https://docs.aws.amazon.com/eks/latest/userguide/getting-started-console.html). Test cases mencakup berbagai tipe dan ukuran model serta berbagai framework dan optimasi paralel (Pytorch DDP/FSDP, MegatronLM, NemoMegatron...).

Komponen utama dari direktori ini adalah:

```bash
reference-architectures/
|-- 1.architectures/               # Template CloudFormation untuk arsitektur referensi
|-- 2.ami_and_containers/          # Skrip untuk membuat AMI dan image container
|-- 3.test_cases/                  # Test case referensi dan/atau skrip benchmark
|-- 4.validation_observability/    # Alat untuk mengukur performa atau troubleshooting
`-- ...
```

**CATATAN**: arsitektur dirancang untuk bekerja dengan bucket S3 dan VPC yang dibuat menggunakan template referensi `1.architectures/0.s3/` dan `1.architectures/1.vpc_network/`. _Sangat disarankan untuk menerapkan kedua template ini **sebelum** menerapkan arsitektur referensi manapun._

## 0. Workshop

Anda dapat mengikuti workshop berikut untuk melatih model di AWS. Masing-masing berisi contoh untuk beberapa test case serta informasi penting tentang mengoperasikan cluster untuk pelatihan LLM.

| Nama                                                                           | Komentar
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------- |
| [Amazon SageMaker HyperPod](https://catalog.workshops.aws/sagemaker-hyperpod/en-US)   | Workshop untuk SageMaker HyperPod, menunjukkan cara deploy dan memonitor |
| [AWS ParallelCluster](https://catalog.workshops.aws/ml-on-aws-parallelcluster) | Workshop serupa seperti HyperPod tapi di ParallelCluster            |
| [Amazon SageMaker HyperPod EKS](https://catalog.workshops.aws/sagemaker-hyperpod-eks)   | Workshop untuk SageMaker HyperPod EKS, menunjukkan cara deploy dan memonitor |

## 1. Arsitektur

Arsitektur berada di `1.architectures` dan terdiri dari utilitas serta arsitektur terkait layanan.

| Nama                                                               | Kategori | Penggunaan                                           |
| ------------------------------------------------------------------ | -------- | --------------------------------------------------- |
| [`0.s3`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/0.s3)                                   | Storage  | Membuat bucket S3                                   |
| [`1.vpc_network`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/1.vpc_network)                 | Network  | Membuat VPC dengan subnet dan sumber daya yang diperlukan |
| [`2.aws-parallelcluster`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/2.aws-parallelcluster) | Compute  | Template cluster untuk pelatihan GPU & custom silicon |
| [`3.aws-batch`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/3.aws-batch)                     | Compute  | Template AWS Batch untuk pelatihan terdistribusi    |
| [`4.amazon-eks`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/4.amazon-eks)                   | Compute  | File manifest untuk pelatihan dengan Amazon EKS     |
| [`5.sagemaker-hyperpod`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/5.sagemaker-hyperpod)   | Compute  | Template SageMaker HyperPod untuk pelatihan terdistribusi|

Akan ada lebih banyak lagi, silakan tambahkan yang baru (misal Ray?). Anda juga akan menemukan [dokumentasi](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-cheatsheet.md) untuk EFA dan variabel lingkungan yang direkomendasikan.

## 2. Custom Amazon Machine Images

Image mesin kustom dapat dibangun menggunakan [Packer](www.packer.io) untuk AWS ParallelCluster, Amazon EKS dan EC2 biasa. Image ini berbasis pada peran dan playbook Ansible.

## 3. Test cases

Test cases diorganisasi berdasarkan framework dan mencakup berbagai skenario pelatihan terdistribusi. Setiap test case mencakup skrip dan konfigurasi yang diperlukan untuk menjalankan pekerjaan pelatihan terdistribusi.

### Test Cases PyTorch
- [`FSDP/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/FSDP) - Contoh pelatihan Fully Sharded Data Parallel
- [`megatron-lm/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/megatron-lm) - Contoh pelatihan terdistribusi Megatron-LM
- [`nemo-launcher/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-launcher) - Contoh NeMo Launcher untuk pelatihan terdistribusi. Test case ini untuk NeMo versi 1.0 saja.
- [`nemo-run/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-run) - Contoh pelatihan terdistribusi framework NeMo. Test case ini untuk NeMo versi 2.0+.
- [`neuronx-distributed/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/neuronx-distributed) - Contoh pelatihan terdistribusi AWS Trainium
- [`mosaicml-composer/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/mosaicml-composer) - Contoh MosaicML Composer
- [`picotron/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/picotron) - Contoh pelatihan terdistribusi PicoTron
- [`torchtitan/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/torchtitan) - Contoh TorchTitan
- [`cpu-ddp/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/cpu-ddp) - Contoh Distributed Data Parallel berbasis CPU
- [`bionemo/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/bionemo) - Contoh pelatihan terdistribusi BioNeMo

### Test Cases JAX
- [`jax/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/jax) - Contoh pelatihan terdistribusi berbasis JAX menggunakan PaxML

Setiap test case mencakup:
- Skrip dan konfigurasi pelatihan
- Definisi container (jika ada)
- Skrip peluncuran untuk berbagai jenis cluster
- Alat pemantauan performa dan validasi

## 4. Skrip Validasi

Skrip utilitas dan contoh micro-benchmark disimpan di `4.validation_scripts/`. Prometheus exporter untuk EFA dapat ditemukan di [direktori ini](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter) 


| Nama                                                                                    | Komentar                                                        |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------- |
| [`1.pytorch-env-validation`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/1.pytorch-env-validation) | Memvalidasi lingkungan PyTorch Anda                            |
| [`3.efa-node-exporter`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter)           | Node exporter dengan modul monitoring Amazon EFA               |
| [`4.prometheus-grafana`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/4.prometheus-grafana)         | Asset deployment untuk memonitor SageMaker Hyperpod Clusters    |
| [`5.nsight`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/5.nsight)                                 | Menunjukkan cara menjalankan Nvidia Nsight Systems untuk profiling beban kerja Anda |
| [`efa-versions.py`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-versions.py)                                  | Mendapatkan versi library Nvidia, driver dan driver EFA         |


## 5. CI

Tes integrasi ditulis dalam [pytest](https://docs.pytest.org). Jalankan saja:

```bash
pytest .
```

Alternatifnya, Anda dapat menjalankan tes tanpa menangkap stdout dan mempertahankan semua image docker dan artefak lainnya.

```bash
pytest -s --keep-artifacts=t
```

## 6. Kontributor

Terima kasih kepada semua kontributor yang telah membangun, mereview dan menguji.

[![Contributors](https://contrib.rocks/image?repo=aws-samples/awsome-distributed-training)](https://github.com/aws-samples/awsome-distributed-training/graphs/contributors)

## 7. Star History

[![Star History Chart](https://api.star-history.com/svg?repos=aws-samples/awsome-distributed-training&type=Date)](https://star-history.com/#aws-samples/awsome-distributed-training&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---