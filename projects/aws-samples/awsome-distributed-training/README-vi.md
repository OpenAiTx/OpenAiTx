# ML Training Reference Architectures & Tests <!-- omit from toc -->

> **Cảnh báo**
> Chúng tôi hiện đang tiến hành tái cấu trúc lớn cho kho lưu trữ này, đặc biệt tập trung vào phần các trường hợp kiểm thử. Nếu bạn muốn sử dụng cấu trúc thư mục cũ và các trường hợp kiểm thử đã bị loại bỏ, vui lòng tham khảo [v1.1.0](https://github.com/aws-samples/awsome-distributed-training/releases/tag/v1.1.0).


Kho lưu trữ này chứa các kiến trúc tham khảo và các trường hợp kiểm thử cho huấn luyện mô hình phân tán với [Amazon SageMaker Hyperpod](https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html), [AWS ParallelCluster](https://docs.aws.amazon.com/parallelcluster/latest/ug/what-is-aws-parallelcluster.html), [AWS Batch](https://docs.aws.amazon.com/batch/latest/userguide/what-is-batch.html), và [Amazon EKS](https://docs.aws.amazon.com/eks/latest/userguide/getting-started-console.html). Các trường hợp kiểm thử bao gồm nhiều loại và kích thước mô hình khác nhau cũng như các framework và tối ưu song song khác nhau (Pytorch DDP/FSDP, MegatronLM, NemoMegatron...).

Các thành phần chính của thư mục này bao gồm:

```bash
reference-architectures/
|-- 1.architectures/               # Các mẫu CloudFormation cho kiến trúc tham khảo
|-- 2.ami_and_containers/          # Các script tạo AMI và ảnh container
|-- 3.test_cases/                  # Các trường hợp kiểm thử tham khảo và/hoặc script benchmark
|-- 4.validation_observability/    # Công cụ đo hiệu suất hoặc khắc phục sự cố
`-- ...
```

**LƯU Ý**: các kiến trúc được thiết kế để hoạt động với bucket S3 và VPC được tạo bằng các mẫu tham khảo `1.architectures/0.s3/` và `1.architectures/1.vpc_network/`. _Bạn nên triển khai hai mẫu này **trước** khi triển khai bất kỳ kiến trúc tham khảo nào._

## 0. Workshops

Bạn có thể theo dõi các workshop dưới đây để huấn luyện mô hình trên AWS. Mỗi workshop chứa ví dụ cho nhiều trường hợp kiểm thử cũng như những thông tin hữu ích về vận hành cụm cho huấn luyện LLM.

| Tên                                                                          | Bình luận                                                       |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------- |
| [Amazon SageMaker HyperPod](https://catalog.workshops.aws/sagemaker-hyperpod/en-US)   | Workshop cho SageMaker HyperPod, hướng dẫn cách triển khai và giám sát |
| [AWS ParallelCluster](https://catalog.workshops.aws/ml-on-aws-parallelcluster) | Workshop tương tự HyperPod nhưng trên ParallelCluster             |
| [Amazon SageMaker HyperPod EKS](https://catalog.workshops.aws/sagemaker-hyperpod-eks)   | Workshop cho SageMaker HyperPod EKS, hướng dẫn cách triển khai và giám sát |

## 1. Kiến trúc

Các kiến trúc nằm trong `1.architectures` và bao gồm các tiện ích cùng các kiến trúc liên quan đến dịch vụ.

| Tên                                                               | Danh mục | Mục đích                                             |
| ------------------------------------------------------------------ | -------- | --------------------------------------------------- |
| [`0.s3`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/0.s3)                                   | Lưu trữ  | Tạo bucket S3                                      |
| [`1.vpc_network`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/1.vpc_network)                 | Mạng  | Tạo VPC với các subnet và tài nguyên cần thiết        |
| [`2.aws-parallelcluster`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/2.aws-parallelcluster) | Tính toán  | Mẫu cụm cho huấn luyện GPU & silicon tùy chỉnh         |
| [`3.aws-batch`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/3.aws-batch)                     | Tính toán  | Mẫu AWS Batch cho huấn luyện phân tán                   |
| [`4.amazon-eks`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/4.amazon-eks)                   | Tính toán  | Các file manifest để huấn luyện với Amazon EKS          |
| [`5.sagemaker-hyperpod`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/5.sagemaker-hyperpod)   | Tính toán  | Mẫu SageMaker HyperPod cho huấn luyện phân tán          |

Sẽ có thêm nhiều kiến trúc mới, bạn có thể thêm kiến trúc mới (ví dụ: Ray?). Bạn cũng sẽ tìm thấy [tài liệu](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-cheatsheet.md) cho EFA và các biến môi trường được khuyến nghị.

## 2. Ảnh máy Amazon tùy chỉnh

Ảnh máy tùy chỉnh có thể được xây dựng bằng [Packer](https://www.packer.io) cho AWS ParallelCluster, Amazon EKS và EC2 thông thường. Các ảnh này dựa trên các vai trò và playbook Ansible.

## 3. Trường hợp kiểm thử

Các trường hợp kiểm thử được tổ chức theo framework và bao phủ các kịch bản huấn luyện phân tán khác nhau. Mỗi trường hợp kiểm thử bao gồm các script và cấu hình cần thiết để chạy các công việc huấn luyện phân tán.

### Trường hợp kiểm thử PyTorch
- [`FSDP/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/FSDP) - Ví dụ huấn luyện Fully Sharded Data Parallel
- [`megatron-lm/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/megatron-lm) - Ví dụ huấn luyện phân tán Megatron-LM
- [`nemo-launcher/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-launcher) - Ví dụ NeMo Launcher cho huấn luyện phân tán. Trường hợp này dành cho phiên bản NeMo 1.0.
- [`nemo-run/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-run) - Ví dụ framework NeMo cho huấn luyện phân tán. Trường hợp này dành cho NeMo phiên bản 2.0 trở lên.
- [`neuronx-distributed/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/neuronx-distributed) - Ví dụ huấn luyện phân tán AWS Trainium
- [`mosaicml-composer/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/mosaicml-composer) - Ví dụ MosaicML Composer
- [`picotron/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/picotron) - Ví dụ huấn luyện phân tán PicoTron
- [`torchtitan/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/torchtitan) - Ví dụ TorchTitan
- [`cpu-ddp/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/cpu-ddp) - Ví dụ Distributed Data Parallel trên CPU
- [`bionemo/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/bionemo) - Ví dụ huấn luyện phân tán BioNeMo

### Trường hợp kiểm thử JAX
- [`jax/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/jax) - Ví dụ huấn luyện phân tán dựa trên JAX sử dụng PaxML

Mỗi trường hợp kiểm thử bao gồm:
- Script và cấu hình huấn luyện
- Định nghĩa container (nếu có)
- Script khởi chạy cho các loại cụm khác nhau
- Công cụ giám sát hiệu suất và xác thực

## 4. Script xác thực

Các script tiện ích và ví dụ benchmark nhỏ được đặt trong `4.validation_scripts/`. Bộ xuất Prometheus cho EFA có thể tìm thấy trong [thư mục này](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter) 


| Tên                                                                                     | Bình luận                                                        |
| --------------------------------------------------------------------------------------- | ---------------------------------------------------------------- |
| [`1.pytorch-env-validation`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/1.pytorch-env-validation) | Xác thực môi trường PyTorch của bạn                              |
| [`3.efa-node-exporter`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter)           | Node exporter với các module giám sát Amazon EFA                |
| [`4.prometheus-grafana`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/4.prometheus-grafana)         | Tài nguyên triển khai để giám sát cụm SageMaker Hyperpod        |
| [`5.nsight`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/5.nsight)                                 | Hướng dẫn chạy Nvidia Nsight Systems để phân tích tải công việc |
| [`efa-versions.py`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-versions.py)                                  | Lấy phiên bản thư viện Nvidia, driver và driver EFA            |


## 5. CI

Các bài kiểm thử tích hợp được viết bằng [pytest](https://docs.pytest.org). Chỉ cần chạy:

```bash
pytest .
```

Ngoài ra bạn có thể chạy kiểm thử mà không chặn stdout và giữ lại tất cả ảnh docker cùng các artifacts khác.

```bash
pytest -s --keep-artifacts=t
```

## 6. Những người đóng góp

Cảm ơn tất cả các đóng góp viên đã xây dựng, đánh giá và kiểm thử.

[![Contributors](https://contrib.rocks/image?repo=aws-samples/awsome-distributed-training)](https://github.com/aws-samples/awsome-distributed-training/graphs/contributors)

## 7. Lịch sử sao

[![Star History Chart](https://api.star-history.com/svg?repos=aws-samples/awsome-distributed-training&type=Date)](https://star-history.com/#aws-samples/awsome-distributed-training&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---