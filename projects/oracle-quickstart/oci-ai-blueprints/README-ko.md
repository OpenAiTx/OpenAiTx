# OCI AI Blueprints

**OCI AI Blueprints 플랫폼을 사용하여 AI 워크로드를 배포, 확장 및 모니터링하고, GPU 온보딩 시간을 몇 주에서 몇 분으로 단축하세요.**

OCI AI Blueprints는 Kubernetes Engine(OKE)에서 생성형 AI 워크로드를 배포하고 관리하기 위한 간소화된 노코드 솔루션입니다. 권장 하드웨어, 사전 패키징된 소프트웨어 스택, 즉시 사용 가능한 가시성 도구를 제공하여, OCI AI Blueprints는 인프라 결정, 소프트웨어 호환성, MLOps 모범 사례의 복잡함 없이 AI 애플리케이션을 빠르고 효율적으로 실행할 수 있도록 지원합니다.

[![OCI AI Blueprints 설치](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)

## 목차

**시작하기**

- [AI Blueprints 설치](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)
- [AI Blueprints 포털 및 API 접속](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/usage_guide.md)

**OCI AI Blueprints 소개**

- [OCI AI Blueprints란?](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [OCI AI Blueprints를 사용하는 이유](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [주요 기능](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [블루프린트 목록](#blueprints)
- [FAQ](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [지원 및 연락처](https://github.com/oracle-quickstart/oci-ai-blueprints/blob/vkammari/doc_improvements/docs/about/README.md#frequently-asked-questions-faq)

**API 레퍼런스**

- [API 레퍼런스 문서](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/api_documentation.md)

**추가 자료**

- [커스텀 블루프린트 게시](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/custom_blueprints)
- [업데이트 설치](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/installing_new_updates.md)
- [IAM 정책](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/iam_policies.md)
- [저장소 구성](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [알려진 이슈](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/known_issues.md)

## 시작하기

아래 버튼을 클릭하여 OCI AI Blueprints를 설치하세요:

[![OCI AI Blueprints 설치](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)

## 블루프린트

블루프린트는 기본적인 Terraform 템플릿을 넘어섭니다. 각 블루프린트는 다음을 제공합니다:

- 검증된 하드웨어 제안(예: 최적의 Shape, CPU/GPU 구성),
- 다양한 생성형 AI(GenAI) 사용 사례에 맞춘 엔드 투 엔드 애플리케이션 스택,
- 모니터링, 로깅, 오토스케일링이 사전 구성되어 즉시 사용 가능.

테넌시의 OKE 클러스터에 OCI AI Blueprints를 설치한 후, 다음과 같은 사전 구축된 블루프린트를 배포할 수 있습니다:

| 블루프린트                                                                                     | 설명                                                                                                                             |
| --------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------ |
| [**vLLM을 활용한 LLM & VLM 추론**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/llm_inference_with_vllm/README.md) | NVIDIA GPU Shape와 vLLM 추론 엔진을 사용해 Llama 2/3/3.1 7B/8B 모델을 오토스케일링과 함께 배포합니다.                   |
| [**파인튜닝 벤치마킹**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/lora-benchmarking)                    | A100에서 MLCommons 양자화 Llama-2 70B LoRA 파인튜닝을 실행하여 성능을 벤치마킹합니다.                                     |
| [**LoRA 파인튜닝**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/lora-fine-tuning)                             | 모든 데이터셋을 사용하여 커스텀 또는 HuggingFace 모델의 LoRA 파인튜닝을 제공합니다. 유연한 하이퍼파라미터 튜닝 포함.          |
| [**헬스 체크**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/gpu-health-check)                                 | 고부하 연산 작업 전 최적의 하드웨어 상태를 확인하기 위한 종합 GPU 성능 평가를 수행합니다.                                  |
| [**CPU 추론**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/cpu-inference)                                   | Ollama를 활용하여 Mistral, Gemma 등 다양한 모델로 CPU 기반 추론을 테스트할 수 있습니다.                                    |
| [**RDMA 및 vLLM을 활용한 멀티노드 추론**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/multi-node-inference/) | H100 노드와 vLLM 및 LeaderWorkerSet을 활용하여 Llama-405B 사이즈 LLM을 여러 노드에 걸쳐 RDMA로 배포합니다.                |
| [**vLLM 오토스케일링 추론**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/auto_scaling/)                 | KEDA를 사용해 추론 지연 등 애플리케이션 메트릭 기반으로 LLM을 여러 GPU 및 노드로 오토스케일링하며 제공합니다.             |
| [**MIG를 활용한 LLM 추론**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/mig_multi_instance_gpu/)                | Nvidia 멀티 인스턴스 GPU를 활용해 GPU의 일부에 LLM을 배포하고, vLLM으로 서비스합니다.                                      |
| [**잡 대기열**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/teams)                                             | 잡 대기열, 리소스 할당량 및 팀 간 공정한 자원 분배를 활용할 수 있습니다.                                                   |

## 지원 및 연락처

질문, 이슈 또는 피드백이 있으신 경우 [vishnu.kammari@oracle.com](mailto:vishnu.kammari@oracle.com) 또는 [grant.neuman@oracle.com](mailto:grant.neuman@oracle.com)으로 문의해 주시기 바랍니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---