<div align="center">
 👋 안녕하세요, 여러분! 
    verl은 <b>바이트댄스 Seed 팀</b>이 주도하고 verl 커뮤니티가 유지 관리하는 RL(강화학습) 트레이닝 라이브러리입니다.
    <br>
    <br>
</div>

<div align="center">

[<img src="https://devin.ai/assets/deepwiki-badge.png" alt="Ask DeepWiki.com" height="20"/>](https://deepwiki.com/volcengine/verl)
[![GitHub Repo stars](https://img.shields.io/github/stars/volcengine/verl)](https://github.com/volcengine/verl/stargazers)
[![Twitter](https://img.shields.io/twitter/follow/verl_project)](https://twitter.com/verl_project)
<a href="https://join.slack.com/t/verlgroup/shared_invite/zt-2w5p9o4c3-yy0x2Q56s_VlGLsJ93A6vA"><img src="https://img.shields.io/badge/Slack-verl-blueviolet?logo=slack&amp"></a>
<a href="https://arxiv.org/pdf/2409.19256"><img src="https://img.shields.io/static/v1?label=EuroSys&message=Paper&color=red"></a>
[![Documentation](https://img.shields.io/badge/documentation-blue)](https://verl.readthedocs.io/en/latest/)
<a href="https://raw.githubusercontent.com/eric-haibin-lin/verl-community/refs/heads/main/WeChat.JPG"><img src="https://img.shields.io/badge/微信-green?logo=wechat&amp"></a>

</div>

![seed logo](https://github.com/user-attachments/assets/c42e675e-497c-4508-8bb9-093ad4d1f216)

<h1 style="text-align: center;">verl: LLM을 위한 Volcano Engine 강화학습</h1>

verl은 대규모 언어 모델(LLM)을 위한 유연하고 효율적이며 프로덕션 레디(Production-ready) RL(강화학습) 트레이닝 라이브러리입니다.

verl은 **[HybridFlow: A Flexible and Efficient RLHF Framework](https://arxiv.org/abs/2409.19256v2)** 논문의 오픈소스 버전입니다.

verl은 다음과 같은 특징으로 유연하고 사용하기 쉽습니다:

- **다양한 RL 알고리즘의 손쉬운 확장**: 하이브리드 컨트롤러 프로그래밍 모델을 통해 복잡한 사후 트레이닝 데이터플로우를 유연하게 표현하고 효율적으로 실행할 수 있습니다. GRPO, PPO 등 RL 데이터플로우를 몇 줄의 코드로 구축할 수 있습니다.

- **모듈형 API로 기존 LLM 인프라와의 완벽한 통합**: 연산과 데이터 종속성을 분리하여 FSDP, Megatron-LM, vLLM, SGLang 등 기존 LLM 프레임워크와 원활하게 통합할 수 있습니다.

- **유연한 디바이스 매핑**: 다양한 GPU 세트에 모델을 배치하는 것을 지원하여, 다양한 클러스터 크기에서 효율적인 자원 활용 및 확장이 가능합니다.

- 인기 있는 HuggingFace 모델과의 즉시 통합 지원

verl은 다음과 같이 빠릅니다:

- **최첨단(SOTA) 처리량**: SOTA LLM 트레이닝 및 추론 엔진 통합, 그리고 SOTA RL 처리량

- **3D-HybridEngine 기반 효율적인 액터 모델 리샤딩**: 트레이닝과 생성 단계 전환 시 메모리 중복을 없애고 통신 오버헤드를 크게 줄입니다.

</p>

## 소식

- [2025/06] Megatron 백엔드와 함께 verl이 [DeepSeek-671b 및 Qwen3-236b](https://verl.readthedocs.io/en/latest/perf/dpsk.html)와 같은 대규모 MoE 모델을 지원합니다.
- [2025/06] verl 팀이 6월 7일 [PyTorch Day China](https://www.lfasiallc.com/pytorch-day-china/)에서 최신 프로젝트 업데이트를 제공합니다. 베이징에서 개발팀을 만나보세요!
- [2025/05] [PF-PPO](https://arxiv.org/abs/2409.06957)가 ICML 2025에 채택되어 verl에서 지원됩니다! PF-PPO는 잠재적으로 노이즈가 많은 보상 신호를 필터링하고, 리플레이 버퍼를 통해 고품질 경험을 재사용함으로써 정책 학습의 효율성과 견고성을 향상시킵니다.
- [2025/04] [ICLR 2025 Expo](https://iclr.cc/virtual/2025/calendar?filter_events=Expo+Talk+Panel&filter_rooms=), [SCI-FM 워크샵](https://open-foundation-model.github.io/), [LMSys afterparty](https://lu.ma/d23nyynm)에서 verl의 최신 사후 트레이닝 기법과 프로그래밍 가이드에 대한 튜토리얼을 제공합니다. 발표 자료는 [여기](https://github.com/eric-haibin-lin/verl-community/tree/main/iclr25)에서 확인하세요.
- [2025/04] [Seed-Thinking-v1.5](https://github.com/ByteDance-Seed/Seed-Thinking-v1.5/blob/main/seed-thinking-v1.5.pdf) 기술 보고서가 공개되었습니다! verl로 트레이닝된 Seed-Thinking-v1.5는 AIME 2024에서 86.7, Codeforces에서 55.0, GPQA에서 77.3을 달성하여 STEM 및 코딩 분야에서 탁월한 추론 능력을 보였습니다. 추론 태스크를 넘어 다양한 도메인에서 뛰어난 일반화 능력도 확인되었습니다.
- [2025/04] [VAPO](https://arxiv.org/pdf/2504.05118) (value-based augmented PPO) 논문은 추론 모델을 위한 최신 RL 방법을 다룹니다. Qwen-32B-base 모델로 트레이닝된 VAPO는 AIME 2024에서 60.4를 기록하여 DAPO-32B를 능가했습니다.
- [2025/03] verl v0.3.0.post1 출시! 자세한 내용은 [릴리즈 노트](https://github.com/volcengine/verl/releases/) 참조. 이전 버전 대비 [약 1.4배 속도 향상](https://tongyx361.github.io/blogs/posts/verl-intro/#/verl-flexible-and-efficient-rl-for-llms)을 달성했습니다.
- [2025/03] [DAPO](https://dapo-sia.github.io/)는 Qwen2.5-32B 프리트레인 모델을 기반으로 AIME 2024에서 50점을 기록한 오픈소스 SOTA RL 알고리즘으로, DeepSeek의 GRPO(DeepSeek-R1-Zero-Qwen-32B)가 달성한 이전 SOTA를 능가합니다. DAPO 트레이닝은 모두 verl을 기반으로 하며, 재현 코드는 `recipe/dapo`에 공개되어 있습니다.
<details><summary> 더 보기... </summary>
<ul>
  <li>[2025/05] [A2M Shanghai](https://a2m.msup.com.cn/home/?aid=4488&city=shanghai)에서 5/16 - 5/17에 verl이 소개됩니다.</li>
  <li>[2025/05] [GOSIM x PyTorch Day 2025](https://paris2025.gosim.org/)에서 verl이 발표됩니다. 파리에서 만나요! </li>
  <li>[2025/03] [vLLM Beijing Meetup](https://mp.weixin.qq.com/s/n77GibL2corAtQHtVEAzfg)과 [SGLang-LMSYS Org Meetup](https://lu.ma/ntjrr7ig)에서 verl의 프로그래밍 모델과 최신 업데이트를 소개했습니다. [발표자료](https://github.com/eric-haibin-lin/verl-community/blob/main/slides/verl-lmsys-meetup.pdf) 참고.</li>
  <li>[2025/03] EuroSys 2025에서 verl(HybridFlow)이 발표됩니다. 로테르담에서 만나요!</li>
  <li>[2025/02] verl v0.2.0.post2 출시!</li>
  <li>[2025/02] <a href="https://lu.ma/ji7atxux">Bytedance/NVIDIA/Anyscale Ray Meetup</a>에서 verl을 발표했습니다. 산호세에서 만나요!</li>
  <li>[2025/01] [Doubao-1.5-pro](https://team.doubao.com/zh/special/doubao_1_5_pro)가 LLM & VLM에서 SOTA 수준의 성능으로 출시되었습니다. RL 스케일링 프리뷰 모델은 verl로 트레이닝되었으며, 수학 벤치마크에서 OpenAI O1 수준(70.0 pass@1 on AIME)을 달성했습니다.</li>
  <li>[2024/12] Ray Forward 2024에서 verl이 발표되었습니다. 슬라이드는 <a href="https://github.com/eric-haibin-lin/verl-community/blob/main/slides/Ray_Forward_2024_%E5%B7%AB%E9%94%A1%E6%96%8C.pdf">여기</a>에서 확인하세요.</li>
  <li>[2024/12] NeurIPS 2024에서 <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">Post-training LLMs: From Algorithms to Infrastructure</a>를 발표했습니다. <a href="https://github.com/eric-haibin-lin/verl-data/tree/neurips">슬라이드</a> 및 <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">영상</a> 제공.</li>
  <li>[2024/10] Ray Summit에서 verl이 발표되었습니다. <a href="https://www.youtube.com/watch?v=MrhMcXkXvJU&list=PLzTswPQNepXntmT8jr9WaNfqQ60QwW7-U&index=37">Youtube 영상</a> 참조.</li>
  <li>[2024/08] HybridFlow (verl)이 EuroSys 2025에 채택되었습니다.</li>
</ul>   
</details>

## 주요 특징

- **FSDP**, **FSDP2**, **Megatron-LM**을 이용한 트레이닝 지원
- **vLLM**, **SGLang**, **HF Transformers**를 이용한 rollout 생성 지원
- Hugging Face Transformers 및 Modelscope Hub와 호환: [Qwen-3](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/run_qwen3-8b.sh), Qwen-2.5, Llama3.1, Gemma2, DeepSeek-LLM 등
- 지도학습(SFT) 파인튜닝 지원
- 강화학습: [PPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/), [GRPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/), [ReMax](https://raw.githubusercontent.com/volcengine/verl/main/examples/remax_trainer/), [REINFORCE++](https://verl.readthedocs.io/en/latest/examples/config.html#algorithm), [RLOO](https://raw.githubusercontent.com/volcengine/verl/main/examples/rloo_trainer/), [PRIME](https://raw.githubusercontent.com/volcengine/verl/main/recipe/prime/), [DAPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/dapo/), [DrGRPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/drgrpo) 등
  - 수학, [코딩](https://raw.githubusercontent.com/volcengine/verl/main/recipe/dapo) 등에서 모델 기반 보상 및 함수 기반(검증가능한) 보상 지원
  - 비전-언어 모델(VLM) 및 [멀티모달 RL](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/run_qwen2_5_vl-7b.sh) 지원 (Qwen2.5-vl, Kimi-VL 등)
  - [툴 콜을 활용한 멀티턴](https://raw.githubusercontent.com/volcengine/verl/main/examples/sglang_multiturn) 지원
- [Self-play preference optimization (SPPO)](https://raw.githubusercontent.com/volcengine/verl/main/recipe/sppo) 등 LLM 정렬 레시피
- Flash attention 2, [시퀀스 패킹](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_qwen2-7b_seq_balance.sh), [시퀀스 병렬처리](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_deepseek7b_llm_sp2.sh) (DeepSpeed Ulysses 기반), [LoRA](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_peft.sh), [Liger-kernel](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_sp2_liger.sh) 지원
- [전문가 병렬화](https://raw.githubusercontent.com/volcengine/verl/main/pull/1467)로 671B 모델 및 수백 개 GPU까지 확장
- 멀티 GPU [LoRA RL](https://verl.readthedocs.io/en/latest/advance/ppo_lora.html) 지원으로 메모리 절약
- wandb, swanlab, mlflow, tensorboard를 통한 실험 추적 지원

## 예정된 기능 및 변경 사항

- 로드맵 https://github.com/volcengine/verl/issues/710
- Megatron v0.11 기반 DeepSeek 671b 최적화 https://github.com/volcengine/verl/issues/708
- 멀티턴 rollout 및 툴 최적화 https://github.com/volcengine/verl/issues/1882
- 환경 상호작용 https://github.com/volcengine/verl/issues/1172
- v0.3 이후 주요 변경사항 목록 https://github.com/volcengine/verl/discussions/943, entropy_coeff 기본값 0
- RL용 Lora https://github.com/volcengine/verl/pull/1127 

## 시작하기

<a href="https://verl.readthedocs.io/en/latest/index.html"><b>문서 바로가기</b></a>

**퀵스타트:**

- [설치](https://verl.readthedocs.io/en/latest/start/install.html)
- [퀵스타트](https://verl.readthedocs.io/en/latest/start/quickstart.html)
- [프로그래밍 가이드](https://verl.readthedocs.io/en/latest/hybrid_flow.html)
- [verl에서 PPO 사용법](https://verl.readthedocs.io/en/latest/algo/ppo.html)
- [verl에서 GRPO 사용법](https://verl.readthedocs.io/en/latest/algo/grpo.html)

**PPO 예제 단계별 실행법:**

- [사후 트레이닝 데이터 준비](https://verl.readthedocs.io/en/latest/preparation/prepare_data.html)
- [데이터셋 보상 함수 구현](https://verl.readthedocs.io/en/latest/preparation/reward_function.html)
- [PPO 예제 구조](https://verl.readthedocs.io/en/latest/examples/ppo_code_architecture.html)
- [설정(Config) 설명](https://verl.readthedocs.io/en/latest/examples/config.html)

**재현 가능한 알고리즘 벤치마크:**

- [코딩, 수학 RL 성능](https://verl.readthedocs.io/en/latest/algo/baseline.html)

**코드 설명 및 고급 활용(확장):**

- PPO 트레이너와 워커
  - [PPO Ray 트레이너](https://verl.readthedocs.io/en/latest/workers/ray_trainer.html)
  - [PyTorch FSDP 백엔드](https://verl.readthedocs.io/en/latest/workers/fsdp_workers.html)
  - [Megatron-LM 백엔드](https://verl.readthedocs.io/en/latest/index.html)

- 고급 활용 및 확장
  - [FSDP 백엔드로 모델 추가](https://verl.readthedocs.io/en/latest/advance/fsdp_extension.html)
  - [Megatron-LM 백엔드로 모델 추가](https://verl.readthedocs.io/en/latest/advance/megatron_extension.html)
  - [멀티턴 rollout 지원](https://verl.readthedocs.io/en/latest/sglang_multiturn/multiturn.html)
  - [검색 툴 통합](https://verl.readthedocs.io/en/latest/sglang_multiturn/search_tool_example.html)
  - [Sandbox Fusion 통합](https://verl.readthedocs.io/en/latest/examples/sandbox_fusion_example.html)
  - [별도 GPU 자원으로 배포](https://raw.githubusercontent.com/volcengine/verl/main/examples/split_placement)
  - [기타 RL(HF) 알고리즘 확장](https://verl.readthedocs.io/en/latest/advance/dpo_extension.html)
  - [Ray API 디자인 튜토리얼](https://verl.readthedocs.io/en/latest/advance/placement.html)

**커뮤니티 블로그**

- [SGLang, verl, OpenBMB 및 칭화대: 엔드-투-엔드 멀티턴 RLHF 선구자](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/multi-turn/verl-multiturn-rollout-Release.md)
- [AMD GPU와 verl, ROCm 통합을 통한 Human Feedback 기반 강화학습](https://rocm.blogs.amd.com/artificial-intelligence/verl-large-scale/README.html)
- [veMLP x verl ：강화학습 트레이닝 마스터하기](https://mp.weixin.qq.com/s/7nbqxk4knMGd-hQE9ls2tA)
- [verl을 활용한 GRPO 분산 강화학습 트레이닝 모범 사례](https://www.volcengine.com/docs/6459/1463942)
- [HybridFlow verl 원문 분석](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/readme.md)
- [최대 20배 향상된 처리량! Doubao 대모델팀 RLHF 프레임워크 오픈소스 공개!](https://team.doubao.com/en/blog/%E6%9C%80%E9%AB%98%E6%8F%90%E5%8D%8720%E5%80%8D%E5%90%9E%E5%90%90%E9%87%8F-%E8%B1%86%E5%8C%85%E5%A4%A7%E6%A8%A1%E5%9E%8B%E5%9B%A2%E9%98%9F%E5%8F%91%E5%B8%83%E5%85%A8%E6%96%B0-rlhf-%E6%A1%86%E6%9E%B6-%E7%8E%B0%E5%B7%B2%E5%BC%80%E6%BA%90)

## 성능 튜닝 가이드

온폴리시 RL 알고리즘에서 성능은 매우 중요합니다. 자세한 [성능 튜닝 가이드](https://verl.readthedocs.io/en/latest/perf/perf_tuning.html)를 참고하여 성능을 최적화하세요.

## vLLM >= v0.8.2로 업그레이드

verl은 FSDP를 트레이닝 백엔드로 사용할 때 vLLM>=0.8.2를 지원합니다. 설치 가이드 및 자세한 내용은 [이 문서](https://raw.githubusercontent.com/volcengine/verl/main/docs/README_vllm0.8.md)를 참고하세요. OOM 및 예기치 않은 오류가 발생할 수 있는 vllm 0.7.x 버전은 피해주세요.

## 최신 SGLang 사용하기

SGLang은 verl과 완전히 호환되며, SGLang RL 그룹은 멀티턴 에이전트 RL, VLM RLHF, 서버 기반 RL, 부분 rollout 등 고유 기능 개발에 주력하고 있습니다. 설치 가이드와 자세한 내용은 [이 문서](https://verl.readthedocs.io/en/latest/workers/sglang_worker.html)를 참고하세요.

## FSDP2 업그레이드

verl은 FSDP2를 완전히 지원합니다! FSDP2는 torch distributed 팀이 권장하며, 더 나은 처리량과 메모리 사용성을 제공하며 torch.compile 등 다른 기능과 조합 사용이 가능합니다. FSDP2 활성화는 verl main에서 다음 옵션을 설정하면 됩니다:
```
actor_rollout_ref.ref.strategy=fsdp2
actor_rollout_ref.actor.strategy=fsdp2
critic.strategy=fsdp2 
reward_model.strategy=fsdp2 
```
또한, FSDP2 CPU 오프로드는 그래디언트 누적과 호환됩니다. 메모리를 아끼려면 `actor_rollout_ref.actor.offload_policy=True`로 설정하세요. 자세한 내용은 https://github.com/volcengine/verl/pull/1026 참고.

## AMD 지원(ROCm 커널)

verl은 FSDP를 트레이닝 엔진으로 지원(곧 Megatron 지원 예정)하며, vLLM 및 SGLang과 추론 엔진으로 통합됩니다. 설치 가이드는 [이 문서](https://raw.githubusercontent.com/volcengine/verl/main/docs/amd_tutorial/amd_build_dockerfile_page.rst)와 vLLM ROCm 성능 튜닝은 [이 문서](https://raw.githubusercontent.com/volcengine/verl/main/docs/amd_tutorial/amd_vllm_page.rst)를 참고하세요.

## 인용 및 감사

프로젝트가 도움이 되었다면 아래 논문을 인용해 주세요:

- [HybridFlow: A Flexible and Efficient RLHF Framework](https://arxiv.org/abs/2409.19256v2)
- [A Framework for Training Large Language Models for Code Generation via Proximal Policy Optimization](https://i.cs.hku.hk/~cwu/papers/gmsheng-NL2Code24.pdf)

```bibtex
@article{sheng2024hybridflow,
  title   = {HybridFlow: A Flexible and Efficient RLHF Framework},
  author  = {Guangming Sheng and Chi Zhang and Zilingfeng Ye and Xibin Wu and Wang Zhang and Ru Zhang and Yanghua Peng and Haibin Lin and Chuan Wu},
  year    = {2024},
  journal = {arXiv preprint arXiv: 2409.19256}
}
```

verl은 Nemo-Aligner, Deepspeed-chat, OpenRLHF 설계에서 영감을 받았습니다. Bytedance, Anyscale, LMSys.org, [Alibaba Qwen team](https://github.com/QwenLM/), Shanghai AI Lab, 칭화대, UC 버클리, UCLA, UIUC, 홍콩대, ke.com, [All Hands AI](https://www.all-hands.dev/), [ModelBest](http://modelbest.cn/), OpenPipe, JD AI Lab, Microsoft Research, [StepFun](https://www.stepfun.com/), Amazon, Linkedin, Meituan, [Camel-AI](https://www.camel-ai.org/), [OpenManus](https://github.com/OpenManus), Xiaomi, Prime Intellect, NVIDIA research, [Baichuan](https://www.baichuan-ai.com/home), [RedNote](https://www.xiaohongshu.com/), [SwissAI](https://www.swiss-ai.org/), [Moonshot AI (Kimi)](https://www.moonshot-ai.com/), Baidu, Snowflake 등 다양한 기관에서 채택 및 기여하고 있습니다.

## verl을 활용한 주요 프로젝트

- [TinyZero](https://github.com/Jiayi-Pan/TinyZero): **DeepSeek R1 Zero** 레시피 재현 ![GitHub Repo stars](https://img.shields.io/github/stars/Jiayi-Pan/TinyZero)
- [SkyThought](https://github.com/NovaSky-AI/SkyThought): NovaSky AI 팀의 Sky-T1-7B RL 트레이닝 ![GitHub Repo stars](https://img.shields.io/github/stars/NovaSky-AI/SkyThought)
- [simpleRL-reason](https://github.com/hkust-nlp/simpleRL-reason): SimpleRL-Zoo: 오픈 베이스 모델의 제로 RL 연구 및 탐구 ![GitHub Repo stars](https://img.shields.io/github/stars/hkust-nlp/simpleRL-reason)
- [Easy-R1](https://github.com/hiyouga/EasyR1): **멀티모달** RL 트레이닝 프레임워크 ![GitHub Repo stars](https://img.shields.io/github/stars/hiyouga/EasyR1)
- [OpenManus-RL](https://github.com/OpenManus/OpenManus-RL): 다양한 에이전트 환경을 위한 LLM 에이전트 RL 튜닝 프레임워크 ![GitHub Repo stars](https://img.shields.io/github/stars/OpenManus/OpenManus-RL)
- [rllm](https://github.com/agentica-project/rllm): [verl-pipeline](https://github.com/agentica-project/verl-pipeline) 기반 비동기 RL 트레이닝 ![GitHub Repo stars](https://img.shields.io/github/stars/agentica-project/rllm)
- [PRIME](https://github.com/PRIME-RL/PRIME): 암묵적 보상을 통한 프로세스 강화학습 ![GitHub Repo stars](https://img.shields.io/github/stars/PRIME-RL/PRIME)
- [RAGEN](https://github.com/ZihanWang314/ragen): 범용 추론 **에이전트** 트레이닝 프레임워크 ![GitHub Repo stars](https://img.shields.io/github/stars/ZihanWang314/ragen)
- [Search-R1](https://github.com/PeterGriffinJin/Search-R1): 추론 및 **검색(툴 콜)**이 결합된 RL ![GitHub Repo stars](https://img.shields.io/github/stars/PeterGriffinJin/Search-R1)
- [DeepRetrieval](https://github.com/pat-jj/DeepRetrieval): **검색/검색결과 기반** RL 트레이닝 ![GitHub Repo stars](https://img.shields.io/github/stars/pat-jj/DeepRetrieval)
- [ReSearch](https://github.com/Agent-RL/ReSearch): RL을 통한 LLM **추론+검색** 학습 ![GitHub Repo stars](https://img.shields.io/github/stars/Agent-RL/ReSearch)
- [Code-R1](https://github.com/ganler/code-r1): 신뢰성 높은 보상 기반 **코드** R1 재현 ![GitHub Repo stars](https://img.shields.io/github/stars/ganler/code-r1)
- [Skywork-OR1](https://github.com/SkyworkAI/Skywork-OR1): Skywork 오픈 리저너 시리즈 ![GitHub Repo stars](https://img.shields.io/github/stars/SkyworkAI/Skywork-OR1)
- [ToRL](https://github.com/GAIR-NLP/ToRL): 툴 통합 RL 스케일링 ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/ToRL)
- [verl-agent](https://github.com/langfengQ/verl-agent): **롱-호라이즌 LLM/VLM 에이전트**를 위한 확장형 트레이닝 프레임워크 및 새로운 **GiGPO** 알고리즘 ![GitHub Repo stars](https://img.shields.io/github/stars/langfengQ/verl-agent)
- [PF-PPO](https://arxiv.org/abs/2409.06957): 보상 신호 신뢰성 기반 정책 필터링을 통한 PPO (효율적, 견고한 RLHF)
- [GUI-R1](https://github.com/ritzz-ai/GUI-R1): **GUI-R1**: GUI 에이전트를 위한 범용 R1 스타일 비전-언어 액션 모델 ![GitHub Repo stars](https://img.shields.io/github/stars/ritzz-ai/GUI-R1)
- [DeepResearcher](https://github.com/GAIR-NLP/DeepResearcher): 실제 환경에서 RL을 통한 딥 리서치 스케일링 ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/DeepResearcher)
- [VAGEN](https://github.com/RAGEN-AI/VAGEN): 멀티턴 강화학습을 통한 VLM 에이전트 트레이닝 ![GitHub Repo stars](https://img.shields.io/github/stars/RAGEN-AI/VAGEN)
- [ReTool](https://retool-rl.github.io/): LLM의 전략적 툴 활용을 위한 강화학습 (코드 공개 예정)
- [RM-R1](https://arxiv.org/abs/2505.02387): 추론 보상 모델의 RL 트레이닝 ![GitHub Repo stars](https://img.shields.io/github/stars/RM-R1-UIUC/RM-R1)
- [Absolute Zero Reasoner](https://arxiv.org/abs/2505.03335): 휴먼 큐레이션 데이터 없이 자체 플레이로 추론하는 프레임워크 ![GitHub Repo stars](https://img.shields.io/github/stars/LeapLabTHU/Absolute-Zero-Reasoner)
- [LUFFY](https://arxiv.org/pdf/2504.14945): 오프폴리시 가이던스 하에서의 추론 학습 ![GitHub Repo stars](https://img.shields.io/github/stars/ElliottYan/LUFFY)
- [verl-tool](https://github.com/TIGER-AI-Lab/verl-tool): verl 기반 통합 및 확장형 툴-에이전트 트레이닝 프레임워크 ![GitHub Repo stars](https://img.shields.io/github/stars/TIGER-AI-Lab/verl-tool)
- [DeepMath](https://github.com/zwhe99/DeepMath): 수학 추론용 DeepMath-103K 데이터 및 시리즈 모델 ![GitHub Repo stars](https://img.shields.io/github/stars/zwhe99/DeepMath)

더 많은 프로젝트는 [recipe](https://raw.githubusercontent.com/volcengine/verl/main/recipe/README.md)에서 확인하세요.

## 기여 안내

커뮤니티의 기여를 환영합니다! [프로젝트 로드맵](https://github.com/volcengine/verl/issues/710)과 [good first issues](https://github.com/volcengine/verl/issues?q=is%3Aissue%20state%3Aopen%20label%3A%22good%20first%20issue%22)를 참고해 기여할 부분을 찾아보세요.

### 코드 린팅 및 포맷팅

코드 품질 향상을 위해 pre-commit을 사용합니다. 초기화 방법:

```bash
pip install pre-commit
pre-commit install
```

CI 오류를 로컬에서 해결하려면 수동으로 pre-commit을 실행하세요:

```bash
pre-commit run
```

### CI 테스트 추가

가능하다면 새로운 기능에 대해 CI 테스트를 추가해 주세요:

1. 관련 워크플로우 yml 파일을 찾으세요(대부분 hydra 기본 config와 매칭됩니다. 예: `ppo_trainer`, `ppo_megatron_trainer`, `sft_trainer` 등).
2. 관련 경로 패턴을 `paths` 섹션에 추가하세요(없다면).
3. 테스트 스크립트의 작업량을 최소화하세요(기존 스크립트 참고).

## [ByteDance Seed Team](https://team.doubao.com/) 소개

2023년에 설립된 ByteDance Seed Team은 업계 최고의 AI 기반 모델을 개발하는 데 전념하고 있습니다. 세계적 수준의 연구팀이 되어 과학과 사회 발전에 크게 기여하는 것이 목표입니다. 아래 채널을 통해 Bytedance Seed를 더 알아보세요👇
<div>
  <a href="https://team.doubao.com/">
    <img src="https://img.shields.io/badge/Website-%231e37ff?style=for-the-badge&logo=bytedance&logoColor=white"></a>
  <a href="https://github.com/user-attachments/assets/469535a8-42f2-4797-acdf-4f7a1d4a0c3e">
    <img src="https://img.shields.io/badge/WeChat-07C160?style=for-the-badge&logo=wechat&logoColor=white"></a>
 <a href="https://www.xiaohongshu.com/user/profile/668e7e15000000000303157d?xsec_token=ABl2-aqekpytY6A8TuxjrwnZskU-6BsMRE_ufQQaSAvjc%3D&xsec_source=pc_search">
    <img src="https://img.shields.io/badge/Xiaohongshu-%23FF2442?style=for-the-badge&logo=xiaohongshu&logoColor=white"></a>
  <a href="https://www.zhihu.com/org/dou-bao-da-mo-xing-tuan-dui/">
    <img src="https://img.shields.io/badge/zhihu-%230084FF?style=for-the-badge&logo=zhihu&logoColor=white"></a>

</div>
---

채용 중입니다! 에이전트 RL 관련 인턴십/정규직(FTE)에 관심 있는 분들은 [이메일](mailto:haibin.lin@bytedance.com)로 연락 바랍니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---