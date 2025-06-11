# ML 학습 참조 아키텍처 및 테스트 <!-- omit from toc -->

> **경고**
> 현재 이 저장소는 특히 테스트 케이스 섹션을 중심으로 대대적인 리팩토링 중입니다. 이전 디렉터리 구조와 더 이상 사용되지 않는 테스트 케이스를 사용하고 싶으시면 [v1.1.0](https://github.com/aws-samples/awsome-distributed-training/releases/tag/v1.1.0)을 참조하세요.


이 저장소는 [Amazon SageMaker Hyperpod](https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html), [AWS ParallelCluster](https://docs.aws.amazon.com/parallelcluster/latest/ug/what-is-aws-parallelcluster.html), [AWS Batch](https://docs.aws.amazon.com/batch/latest/userguide/what-is-batch.html), 및 [Amazon EKS](https://docs.aws.amazon.com/eks/latest/userguide/getting-started-console.html)를 사용한 분산 모델 학습을 위한 참조 아키텍처 및 테스트 케이스를 포함합니다. 테스트 케이스는 다양한 유형과 크기의 모델뿐만 아니라 다양한 프레임워크 및 병렬 최적화(Pytorch DDP/FSDP, MegatronLM, NemoMegatron 등)를 다룹니다.

이 디렉터리의 주요 구성 요소는 다음과 같습니다:

```bash
reference-architectures/
|-- 1.architectures/               # 참조 아키텍처용 CloudFormation 템플릿
|-- 2.ami_and_containers/          # AMI 및 컨테이너 이미지 생성 스크립트
|-- 3.test_cases/                  # 참조 테스트 케이스 및/또는 벤치마크 스크립트
|-- 4.validation_observability/    # 성능 측정 또는 문제 해결 도구
`-- ...
```

**참고**: 아키텍처는 참조 템플릿 `1.architectures/0.s3/` 및 `1.architectures/1.vpc_network/`를 사용해 생성한 S3 버킷 및 VPC와 함께 작동하도록 설계되었습니다. _모든 참조 아키텍처를 배포하기 전에 이 두 템플릿을 반드시 배포할 것을 강력히 권장합니다._

## 0. 워크숍

아래 워크숍을 따라 AWS에서 모델을 학습할 수 있습니다. 각 워크숍에는 여러 테스트 케이스 예제와 LLM 학습을 위한 클러스터 운영에 관한 정보가 포함되어 있습니다.

| 이름                                                                             | 설명                                                              |
| -------------------------------------------------------------------------------- | ----------------------------------------------------------------- |
| [Amazon SageMaker HyperPod](https://catalog.workshops.aws/sagemaker-hyperpod/en-US)   | SageMaker HyperPod 워크숍, 배포 및 모니터링 방법 안내            |
| [AWS ParallelCluster](https://catalog.workshops.aws/ml-on-aws-parallelcluster)    | HyperPod와 유사하지만 ParallelCluster 기반 워크숍                  |
| [Amazon SageMaker HyperPod EKS](https://catalog.workshops.aws/sagemaker-hyperpod-eks) | SageMaker HyperPod EKS 워크숍, 배포 및 모니터링 방법 안내          |

## 1. 아키텍처

아키텍처는 `1.architectures`에 위치하며 유틸리티와 서비스 관련 아키텍처로 구성됩니다.

| 이름                                                               | 분류    | 용도                                                   |
| ------------------------------------------------------------------ | ------- | ------------------------------------------------------ |
| [`0.s3`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/0.s3)                                   | 스토리지  | S3 버킷 생성                                           |
| [`1.vpc_network`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/1.vpc_network)                 | 네트워크  | 서브넷 및 필요한 리소스를 포함한 VPC 생성              |
| [`2.aws-parallelcluster`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/2.aws-parallelcluster) | 컴퓨트  | GPU 및 커스텀 실리콘 학습용 클러스터 템플릿             |
| [`3.aws-batch`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/3.aws-batch)                     | 컴퓨트  | 분산 학습용 AWS Batch 템플릿                            |
| [`4.amazon-eks`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/4.amazon-eks)                   | 컴퓨트  | Amazon EKS를 이용한 학습용 매니페스트 파일               |
| [`5.sagemaker-hyperpod`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/5.sagemaker-hyperpod)   | 컴퓨트  | 분산 학습용 SageMaker HyperPod 템플릿                    |

더 많은 아키텍처가 추가될 예정이며, Ray 등 새로운 아키텍처를 자유롭게 추가할 수 있습니다. 또한 EFA와 권장 환경 변수에 관한 [문서](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-cheatsheet.md)도 확인할 수 있습니다.

## 2. 커스텀 아마존 머신 이미지

AWS ParallelCluster, Amazon EKS 및 일반 EC2용 커스텀 머신 이미지는 [Packer](www.packer.io)를 사용해 빌드할 수 있습니다. 이 이미지들은 Ansible 롤과 플레이북을 기반으로 합니다.

## 3. 테스트 케이스

테스트 케이스는 프레임워크별로 구성되어 있으며 다양한 분산 학습 시나리오를 다룹니다. 각 테스트 케이스에는 분산 학습 작업을 실행하는 데 필요한 스크립트와 구성이 포함되어 있습니다.

### PyTorch 테스트 케이스
- [`FSDP/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/FSDP) - 완전 샤딩 데이터 병렬 학습 예제
- [`megatron-lm/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/megatron-lm) - Megatron-LM 분산 학습 예제
- [`nemo-launcher/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-launcher) - NeMo Launcher 분산 학습 예제 (NeMo 버전 1.0 전용)
- [`nemo-run/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-run) - NeMo 프레임워크 분산 학습 예제 (NeMo 버전 2.0 이상)
- [`neuronx-distributed/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/neuronx-distributed) - AWS Trainium 분산 학습 예제
- [`mosaicml-composer/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/mosaicml-composer) - MosaicML Composer 예제
- [`picotron/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/picotron) - PicoTron 분산 학습 예제
- [`torchtitan/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/torchtitan) - TorchTitan 예제
- [`cpu-ddp/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/cpu-ddp) - CPU 기반 분산 데이터 병렬 예제
- [`bionemo/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/bionemo) - BioNeMo 분산 학습 예제

### JAX 테스트 케이스
- [`jax/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/jax) - PaxML을 사용한 JAX 기반 분산 학습 예제

각 테스트 케이스는 다음을 포함합니다:
- 학습 스크립트 및 구성
- 컨테이너 정의(해당 시)
- 다양한 클러스터 유형에 대한 실행 스크립트
- 성능 모니터링 및 검증 도구

## 4. 검증 스크립트

유틸리티 스크립트 및 마이크로 벤치마크 예제는 `4.validation_scripts/`에 있습니다. EFA Prometheus exporter는 이 [디렉터리](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter)에서 찾을 수 있습니다.

| 이름                                                                                     | 설명                                                              |
| ---------------------------------------------------------------------------------------- | ----------------------------------------------------------------- |
| [`1.pytorch-env-validation`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/1.pytorch-env-validation) | PyTorch 환경 검증                                                  |
| [`3.efa-node-exporter`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter)             | Amazon EFA 모니터링 모듈 포함 노드 익스포터                        |
| [`4.prometheus-grafana`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/4.prometheus-grafana)           | SageMaker Hyperpod 클러스터 모니터링용 배포 자산                   |
| [`5.nsight`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/5.nsight)                                   | Nvidia Nsight Systems를 사용해 워크로드 프로파일링 방법 안내        |
| [`efa-versions.py`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-versions.py)                                    | Nvidia 라이브러리, 드라이버 및 EFA 드라이버 버전 확인 스크립트      |


## 5. CI

통합 테스트는 [pytest](https://docs.pytest.org)로 작성되어 있습니다. 다음 명령어를 실행하세요:

```bash
pytest .
```

또는 stdout 캡처 없이 모든 도커 이미지 및 기타 아티팩트를 보존하면서 테스트를 실행할 수 있습니다.

```bash
pytest -s --keep-artifacts=t
```

## 6. 기여자

빌드, 리뷰 및 테스트에 참여한 모든 기여자분들께 감사드립니다.

[![Contributors](https://contrib.rocks/image?repo=aws-samples/awsome-distributed-training)](https://github.com/aws-samples/awsome-distributed-training/graphs/contributors)

## 7. 스타 히스토리

[![Star History Chart](https://api.star-history.com/svg?repos=aws-samples/awsome-distributed-training&type=Date)](https://star-history.com/#aws-samples/awsome-distributed-training&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---