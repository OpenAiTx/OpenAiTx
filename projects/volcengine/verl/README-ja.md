<div align="center">
 👋 こんにちは、みなさん！
    verlは<b>ByteDance Seedチーム</b>が発起し、verlコミュニティによってメンテナンスされているRLトレーニングライブラリです。
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

<h1 style="text-align: center;">verl: Volcano Engine Reinforcement Learning for LLMs</h1>

verlは、大規模言語モデル（LLM）向けの柔軟で高効率かつプロダクションレディなRLトレーニングライブラリです。

verlは、**[HybridFlow: A Flexible and Efficient RLHF Framework](https://arxiv.org/abs/2409.19256v2)** 論文のオープンソースバージョンです。

verlは以下の特徴で柔軟かつ使いやすい設計となっています：

- **多様なRLアルゴリズムの容易な拡張**：ハイブリッドコントローラプログラミングモデルにより、複雑な後処理データフローを柔軟かつ効率的に表現・実行可能。GRPOやPPOなどのRLデータフローを数行のコードで構築できます。

- **モジュラーAPIによる既存LLMインフラとのシームレス統合**：計算とデータ依存性を分離し、FSDP、Megatron-LM、vLLM、SGLangなど既存LLMフレームワークとのシームレスな統合を実現。

- **柔軟なデバイスマッピング**：さまざまなGPUセットへのモデル配置をサポートし、効率的なリソース活用とクラスター規模に応じたスケーラビリティを提供。

- HuggingFaceの人気モデルとの即時統合

verlは高速です：

- **最先端のスループット**：SOTA LLMトレーニング・推論エンジン統合およびSOTA RLスループットを実現。

- **3D-HybridEngineによる効率的なアクターモデル再シャーディング**：トレーニングと生成フェーズの遷移時にメモリの冗長性を解消し、通信オーバーヘッドを大幅に削減。

</p>

## ニュース

- [2025/06] verlはMegatronバックエンドで[DeepSeek-671bおよびQwen3-236b](https://verl.readthedocs.io/en/latest/perf/dpsk.html)などの大規模MoEモデルをサポート。
- [2025/06] verlチームが[PyTorch Day China](https://www.lfasiallc.com/pytorch-day-china/)（6月7日開催）で最新プロジェクトアップデートを発表予定。北京でお会いしましょう！
- [2025/05] [PF-PPO](https://arxiv.org/abs/2409.06957)がICML 2025に採択され、verlでサポート開始！PF-PPOはリプレイバッファによる高品質経験の再利用とノイズリワード信号のフィルタリングで方策学習効率と堅牢性を強化します。
- [2025/04] [ICLR 2025 Expo](https://iclr.cc/virtual/2025/calendar?filter_events=Expo+Talk+Panel&filter_rooms=)、[SCI-FMワークショップ](https://open-foundation-model.github.io/)、[LMSys afterparty](https://lu.ma/d23nyynm)でverlの最新後処理技術とプログラミングガイドのチュートリアルを行います。資料は[こちら](https://github.com/eric-haibin-lin/verl-community/tree/main/iclr25)。
- [2025/04] [Seed-Thinking-v1.5](https://github.com/ByteDance-Seed/Seed-Thinking-v1.5/blob/main/seed-thinking-v1.5.pdf)技術レポート公開！verlでトレーニングされ、Seed-Thinking-v1.5はAIME 2024で86.7、Codeforcesで55.0、GPQAで77.3を達成。STEMやコーディング領域で優れた推論能力と幅広い汎化性能を示します。
- [2025/04] [VAPO](https://arxiv.org/pdf/2504.05118)（価値ベース拡張PPO）論文で最新RL手法を公開。Qwen-32B-baseモデルから学習しAIME 2024で60.4を達成、DAPO-32Bを上回ります。
- [2025/03] verl v0.3.0.post1リリース！詳細は[リリースノート](https://github.com/volcengine/verl/releases/)参照。前バージョン比で[~1.4倍高速化](https://tongyx361.github.io/blogs/posts/verl-intro/#/verl-flexible-and-efficient-rl-for-llms)。
- [2025/03] [DAPO](https://dapo-sia.github.io/)はQwen2.5-32B事前学習モデルでAIME 2024で50点を達成し、DeepSeekのGRPO（DeepSeek-R1-Zero-Qwen-32B）を超えるSOTA RLアルゴリズム。verlで完全トレーニングされ、`recipe/dapo`で再現コード公開中。
<details><summary> さらに表示... </summary>
<ul>
  <li>[2025/05] [A2M Shanghai](https://a2m.msup.com.cn/home/?aid=4488&city=shanghai)（5/16-5/17）でverlを発表。</li>
  <li>[2025/05] [GOSIM x PyTorch Day 2025](https://paris2025.gosim.org/)でverlを発表。パリで会いましょう！</li>
  <li>[2025/03] [vLLM Beijing Meetup](https://mp.weixin.qq.com/s/n77GibL2corAtQHtVEAzfg)、[SGLang-LMSYS Org Meetup](https://lu.ma/ntjrr7ig)でverlのプログラミングモデルを紹介。[発表資料](https://github.com/eric-haibin-lin/verl-community/blob/main/slides/verl-lmsys-meetup.pdf)。</li>
  <li>[2025/03] EuroSys 2025でverl(HybridFlow)を発表予定。ロッテルダムで会いましょう！</li>
  <li>[2025/02] verl v0.2.0.post2リリース！</li>
  <li>[2025/02] <a href="https://lu.ma/ji7atxux">Bytedance/NVIDIA/Anyscale Ray Meetup</a>でverlを発表。サンノゼで会いましょう！</li>
  <li>[2025/01] [Doubao-1.5-pro](https://team.doubao.com/zh/special/doubao_1_5_pro)がLLM & VLMでSOTA級性能で公開。verlでRLスケーリングプレビューモデルがトレーニングされ、AIMEでOpenAI O1級性能（pass@1: 70.0）を達成。</li>
  <li>[2024/12] Ray Forward 2024でverlを発表。[資料はこちら](https://github.com/eric-haibin-lin/verl-community/blob/main/slides/Ray_Forward_2024_%E5%B7%AB%E9%94%A1%E6%96%8C.pdf)</li>
  <li>[2024/12] NeurIPS 2024で<a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">Post-training LLMs: From Algorithms to Infrastructure</a>を発表。[スライド](https://github.com/eric-haibin-lin/verl-data/tree/neurips)、[ビデオ](https://neurips.cc/Expo/Conferences/2024/workshop/100677)公開中。</li>
  <li>[2024/10] Ray Summitでverlを発表。[Youtube動画](https://www.youtube.com/watch?v=MrhMcXkXvJU&list=PLzTswPQNepXntmT8jr9WaNfqQ60QwW7-U&index=37)</li>
  <li>[2024/08] HybridFlow (verl)がEuroSys 2025に採択。</li>
</ul>   
</details>

## 主な特徴

- トレーニング用に**FSDP**、**FSDP2**、**Megatron-LM**をサポート
- ロールアウト生成に**vLLM**、**SGLang**、**HF Transformers**をサポート
- Hugging Face TransformersおよびModelscope Hubと互換：[Qwen-3](https://github.com/volcengine/verl/blob/main/examples/grpo_trainer/run_qwen3-8b.sh)、Qwen-2.5、Llama3.1、Gemma2、DeepSeek-LLMなど
- 教師ありファインチューニング
- 強化学習：[PPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/)、[GRPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/)、[ReMax](https://raw.githubusercontent.com/volcengine/verl/main/examples/remax_trainer/)、[REINFORCE++](https://verl.readthedocs.io/en/latest/examples/config.html#algorithm)、[RLOO](https://raw.githubusercontent.com/volcengine/verl/main/examples/rloo_trainer/)、[PRIME](https://raw.githubusercontent.com/volcengine/verl/main/recipe/prime/)、[DAPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/dapo/)、[DrGRPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/drgrpo)など
  - 数学や[コーディング](https://github.com/volcengine/verl/tree/main/recipe/dapo)等に対してモデルベースリワード・関数ベースリワード（検証可能リワード）をサポート
  - VLMsや[マルチモーダルRL](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/run_qwen2_5_vl-7b.sh)をQwen2.5-vl、Kimi-VLでサポート
  - [ツールコールによるマルチターン](https://github.com/volcengine/verl/tree/main/examples/sglang_multiturn)
- LLMアライメントレシピ（[Self-play preference optimization (SPPO)](https://github.com/volcengine/verl/tree/main/recipe/sppo)など）
- Flash attention 2、[シーケンスパッキング](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_qwen2-7b_seq_balance.sh)、[シーケンス並列](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_deepseek7b_llm_sp2.sh)をDeepSpeed Ulysses経由でサポート、[LoRA](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_peft.sh)、[Liger-kernel](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_sp2_liger.sh)も
- [エキスパート並列](https://github.com/volcengine/verl/pull/1467)で671Bモデル・数百GPU規模へ拡張可能
- マルチGPU [LoRA RL](https://verl.readthedocs.io/en/latest/advance/ppo_lora.html)で省メモリ化
- wandb, swanlab, mlflow, tensorboard等で実験トラッキング

## 今後の機能・変更点

- ロードマップ https://github.com/volcengine/verl/issues/710
- Megatron v0.11によるDeepSeek 671b最適化 https://github.com/volcengine/verl/issues/708
- マルチターンロールアウト・ツール統合最適化 https://github.com/volcengine/verl/issues/1882
- 環境インタラクション https://github.com/volcengine/verl/issues/1172
- v0.3以降のブレイキングチェンジ一覧 https://github.com/volcengine/verl/discussions/943、entropy_coeffはデフォルト0
- RL用Lora https://github.com/volcengine/verl/pull/1127 

## はじめに

<a href="https://verl.readthedocs.io/en/latest/index.html"><b>ドキュメント</b></a>

**クイックスタート：**

- [インストール](https://verl.readthedocs.io/en/latest/start/install.html)
- [クイックスタート](https://verl.readthedocs.io/en/latest/start/quickstart.html)
- [プログラミングガイド](https://verl.readthedocs.io/en/latest/hybrid_flow.html)
- [verlでのPPO](https://verl.readthedocs.io/en/latest/algo/ppo.html)
- [verlでのGRPO](https://verl.readthedocs.io/en/latest/algo/grpo.html)

**PPOの例をステップバイステップで実行：**

- [後処理用データ準備](https://verl.readthedocs.io/en/latest/preparation/prepare_data.html)
- [データセット用リワード関数実装](https://verl.readthedocs.io/en/latest/preparation/reward_function.html)
- [PPO例のアーキテクチャ解説](https://verl.readthedocs.io/en/latest/examples/ppo_code_architecture.html)
- [設定ファイル解説](https://verl.readthedocs.io/en/latest/examples/config.html)

**再現性のあるアルゴリズムベースライン：**

- [コーディング・数学でのRL性能](https://verl.readthedocs.io/en/latest/algo/baseline.html)

**コード解説・高度な利用（拡張）：**

- PPOトレーナーとワーカー
  - [PPO Rayトレーナー](https://verl.readthedocs.io/en/latest/workers/ray_trainer.html)
  - [PyTorch FSDPバックエンド](https://verl.readthedocs.io/en/latest/workers/fsdp_workers.html)
  - [Megatron-LMバックエンド](https://verl.readthedocs.io/en/latest/index.html)

- 高度な利用・拡張
  - [FSDPバックエンドでのモデル追加](https://verl.readthedocs.io/en/latest/advance/fsdp_extension.html)
  - [Megatron-LMバックエンドでのモデル追加](https://verl.readthedocs.io/en/latest/advance/megatron_extension.html)
  - [マルチターンロールアウト対応](https://verl.readthedocs.io/en/latest/sglang_multiturn/multiturn.html)
  - [検索ツール統合](https://verl.readthedocs.io/en/latest/sglang_multiturn/search_tool_example.html)
  - [Sandbox Fusion統合](https://verl.readthedocs.io/en/latest/examples/sandbox_fusion_example.html)
  - [GPUリソース分割によるデプロイ](https://github.com/volcengine/verl/tree/main/examples/split_placement)
  - [他のRL(HF)アルゴリズム拡張](https://verl.readthedocs.io/en/latest/advance/dpo_extension.html)
  - [Ray API設計チュートリアル](https://verl.readthedocs.io/en/latest/advance/placement.html)

**コミュニティのブログ**

- [SGLang, verl, OpenBMB, 清華大学：エンドツーエンド多ターンRLHFの開拓](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/multi-turn/verl-multiturn-rollout-Release.md)
- [verlとROCm統合によるAMD GPUでの人間フィードバック強化学習](https://rocm.blogs.amd.com/artificial-intelligence/verl-large-scale/README.html)
- [veMLP x verl ：強化学習トレーニング活用](https://mp.weixin.qq.com/s/7nbqxk4knMGd-hQE9ls2tA)
- [verlによるGRPO分散強化学習ベストプラクティス](https://www.volcengine.com/docs/6459/1463942)
- [HybridFlow verl原文浅析](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/readme.md)
- [最大20倍スループット向上！豆包大模型チーム、新RLHFフレームワーク公開](https://team.doubao.com/en/blog/%E6%9C%80%E9%AB%98%E6%8F%90%E5%8D%8720%E5%80%8D%E5%90%9E%E5%90%90%E9%87%8F-%E8%B1%86%E5%8C%85%E5%A4%A7%E6%A8%A1%E5%9E%8B%E5%9B%A3%E9%98%9F%E5%8F%91%E5%B8%83%E5%85%A8%E6%96%B0-rlhf-%E6%A1%86%E6%9E%B6-%E7%8E%B0%E5%B7%B2%E5%BC%80%E6%BA%90)

## 性能チューニングガイド

オンポリシーRLアルゴリズムの性能は極めて重要です。最適化のための詳細な[性能チューニングガイド](https://verl.readthedocs.io/en/latest/perf/perf_tuning.html)を用意しています。

## vLLM >= v0.8.2へのアップグレード

verlはFSDPをトレーニングバックエンドとして利用時、vLLM>=0.8.2をサポートします。[こちらのドキュメント](https://github.com/volcengine/verl/blob/main/docs/README_vllm0.8.md)をご参照ください。vllm 0.7.xはOOMや予期せぬエラーの原因となるバグを含むため避けてください。

## 最新SGLangの利用

SGLangはverlと完全統合されています。SGLang RLグループはマルチターンエージェントRL、VLM RLHF、サーバーベースRL、部分ロールアウトなどユニークな機能に積極的に取り組んでいます。[こちら](https://verl.readthedocs.io/en/latest/workers/sglang_worker.html)を参照してください。

## FSDP2へのアップグレード

verlはFSDP2を全面的にサポートします！FSDP2はtorch distributedチーム推奨で、より高いスループットとメモリ効率、他の機能との組み合わせが可能です（例：torch.compile）。FSDP2有効化は下記設定で可能です：
```
actor_rollout_ref.ref.strategy=fsdp2
actor_rollout_ref.actor.strategy=fsdp2
critic.strategy=fsdp2 
reward_model.strategy=fsdp2 
```
さらに、FSDP2のCPUオフロードは勾配蓄積と互換があり、`actor_rollout_ref.actor.offload_policy=True`で省メモリ化できます。詳細は https://github.com/volcengine/verl/pull/1026

## AMDサポート（ROCmカーネル）

verlはFSDPをトレーニングエンジンとしてサポート（Megatronは近日対応予定）、推論エンジンとしてvLLM・SGLang統合済みです。[インストールガイドはこちら](https://github.com/volcengine/verl/blob/main/docs/amd_tutorial/amd_build_dockerfile_page.rst)、[vLLMのROCmチューニングはこちら](https://github.com/volcengine/verl/blob/main/docs/amd_tutorial/amd_vllm_page.rst)。

## 引用・謝辞

本プロジェクトが有用な場合、以下を引用してください：

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

verlはNemo-Aligner、Deepspeed-chat、OpenRLHFの設計にインスパイアされています。Bytedance、Anyscale、LMSys.org、[Alibaba Qwenチーム](https://github.com/QwenLM/)、上海AI Lab、清華大学、UC Berkeley、UCLA、UIUC、香港大学、ke.com、[All Hands AI](https://www.all-hands.dev/)、[ModelBest](http://modelbest.cn/)、OpenPipe、JD AI Lab、Microsoft Research、[StepFun](https://www.stepfun.com/)、Amazon、Linkedin、美団、[Camel-AI](https://www.camel-ai.org/)、[OpenManus](https://github.com/OpenManus)、Xiaomi、Prime Intellect、NVIDIA研究所、[Baichuan](https://www.baichuan-ai.com/home)、[RedNote](https://www.xiaohongshu.com/)、[SwissAI](https://www.swiss-ai.org/)、[Moonshot AI (Kimi)](https://www.moonshot-ai.com/)、Baidu、Snowflake等、多くの団体に採用・貢献されています。

## verlを活用した素晴らしいプロジェクト

- [TinyZero](https://github.com/Jiayi-Pan/TinyZero)：**DeepSeek R1 Zero**の推論タスク再現 ![GitHub Repo stars](https://img.shields.io/github/stars/Jiayi-Pan/TinyZero)
- [SkyThought](https://github.com/NovaSky-AI/SkyThought)：NovaSky AIチームによるSky-T1-7B RLトレーニング ![GitHub Repo stars](https://img.shields.io/github/stars/NovaSky-AI/SkyThought)
- [simpleRL-reason](https://github.com/hkust-nlp/simpleRL-reason)：SimpleRL-Zoo: ゼロRLの検証と制御 ![GitHub Repo stars](https://img.shields.io/github/stars/hkust-nlp/simpleRL-reason)
- [Easy-R1](https://github.com/hiyouga/EasyR1)：**マルチモーダル**RLトレーニングフレームワーク ![GitHub Repo stars](https://img.shields.io/github/stars/hiyouga/EasyR1)
- [OpenManus-RL](https://github.com/OpenManus/OpenManus-RL)：マルチエージェント環境向けLLMエージェントRLチューニングフレームワーク ![GitHub Repo stars](https://img.shields.io/github/stars/OpenManus/OpenManus-RL)
- [rllm](https://github.com/agentica-project/rllm)：[verl-pipeline](https://github.com/agentica-project/verl-pipeline)による非同期RLトレーニング ![GitHub Repo stars](https://img.shields.io/github/stars/agentica-project/rllm)
- [PRIME](https://github.com/PRIME-RL/PRIME)：暗黙的リワードによるプロセス強化学習 ![GitHub Repo stars](https://img.shields.io/github/stars/PRIME-RL/PRIME)
- [RAGEN](https://github.com/ZihanWang314/ragen)：汎用推論**エージェント**トレーニングフレームワーク ![GitHub Repo stars](https://img.shields.io/github/stars/ZihanWang314/ragen)
- [Search-R1](https://github.com/PeterGriffinJin/Search-R1)：推論と**検索（ツールコール）**を組み合わせたRL ![GitHub Repo stars](https://img.shields.io/github/stars/PeterGriffinJin/Search-R1)
- [DeepRetrieval](https://github.com/pat-jj/DeepRetrieval)：**検索エージェント**のRLトレーニング ![GitHub Repo stars](https://img.shields.io/github/stars/pat-jj/DeepRetrieval)
- [ReSearch](https://github.com/Agent-RL/ReSearch)：LLMによる**検索付き推論**の強化学習 ![GitHub Repo stars](https://img.shields.io/github/stars/Agent-RL/ReSearch)
- [Code-R1](https://github.com/ganler/code-r1)：**コード**用R1再現と信頼できるリワード ![GitHub Repo stars](https://img.shields.io/github/stars/ganler/code-r1)
- [Skywork-OR1](https://github.com/SkyworkAI/Skywork-OR1)：Skyworkオープンリアゾナーシリーズ ![GitHub Repo stars](https://img.shields.io/github/stars/SkyworkAI/Skywork-OR1)
- [ToRL](https://github.com/GAIR-NLP/ToRL)：ツール統合RLのスケーリング ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/ToRL)
- [verl-agent](https://github.com/langfengQ/verl-agent)：**長期LLM/VLMエージェント**用スケーラブルトレーニングフレームワーク & 新アルゴリズム**GiGPO** ![GitHub Repo stars](https://img.shields.io/github/stars/langfengQ/verl-agent)
- [PF-PPO](https://arxiv.org/abs/2409.06957)：リワード信号信頼性に基づくPPO方策フィルタリングで効率的かつ堅牢なRLHF
- [GUI-R1](https://github.com/ritzz-ai/GUI-R1)：**GUI-R1**: GUIエージェント用R1型VLMアクションモデル ![GitHub Repo stars](https://img.shields.io/github/stars/ritzz-ai/GUI-R1)
- [DeepResearcher](https://github.com/GAIR-NLP/DeepResearcher)：実環境での強化学習による深層研究のスケーリング ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/DeepResearcher)
- [VAGEN](https://github.com/RAGEN-AI/VAGEN)：マルチターン強化学習でVLMエージェントをトレーニング ![GitHub Repo stars](https://img.shields.io/github/stars/RAGEN-AI/VAGEN)
- [ReTool](https://retool-rl.github.io/)：LLMの戦略的ツール利用に対する強化学習。コードは近日公開予定...
- [RM-R1](https://arxiv.org/abs/2505.02387)：推論リワードモデルのRLトレーニング ![GitHub Repo stars](https://img.shields.io/github/stars/RM-R1-UIUC/RM-R1)
- [Absolute Zero Reasoner](https://arxiv.org/abs/2505.03335)：人間ラベルなし自己対戦推論フレームワーク ![GitHub Repo stars](https://img.shields.io/github/stars/LeapLabTHU/Absolute-Zero-Reasoner)
- [LUFFY](https://arxiv.org/pdf/2504.14945)：オフポリシーガイダンス下での推論学習 ![GitHub Repo stars](https://img.shields.io/github/stars/ElliottYan/LUFFY)
- [verl-tool](https://github.com/TIGER-AI-Lab/verl-tool)：verlベースの統一的・拡張容易なツールエージェント学習フレームワーク ![GitHub Repo stars](https://img.shields.io/github/stars/TIGER-AI-Lab/verl-tool)
- [DeepMath](https://github.com/zwhe99/DeepMath)：DeepMath-103Kデータ・数理推論モデル群 ![GitHub Repo stars](https://img.shields.io/github/stars/zwhe99/DeepMath)

他にも多くの事例が[recipe](https://raw.githubusercontent.com/volcengine/verl/main/recipe/README.md)に掲載されています。

## 貢献ガイド

コミュニティからの貢献を歓迎しています！[プロジェクトロードマップ](https://github.com/volcengine/verl/issues/710)、[good first issues](https://github.com/volcengine/verl/issues?q=is%3Aissue%20state%3Aopen%20label%3A%22good%20first%20issue%22)を確認し、ぜひご参加ください。

### コードリント・整形

pre-commitを利用しコード品質を向上させています。初期化は：

```bash
pip install pre-commit
pre-commit install
```

CIエラーのローカル解消は：

```bash
pre-commit run
```

### CIテストの追加

可能な場合、新機能にはCIテストを追加してください：

1. 最も関連するworkflow ymlファイルを探し、通常`hydra`デフォルト構成（例：`ppo_trainer`、`ppo_megatron_trainer`、`sft_trainer`など）に対応します。
2. 関連パスパターンを`paths`セクションに追加（未登録の場合）。
3. テストスクリプトの負荷を最小化（既存スクリプト例を参照）。

## [ByteDance Seed Team](https://team.doubao.com/)について

2023年設立のByteDance Seed Teamは、業界最先端のAI基盤モデルの構築に注力しています。世界レベルの研究チームを目指し、科学と社会の進歩に大きく貢献することを目標としています。以下のチャネルからSeedチームについてさらに知ることができます👇
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

採用中！RLエージェント分野のインターン・FTEにご興味ある方は[email](mailto:haibin.lin@bytedance.com)までご連絡ください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---