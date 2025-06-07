<div align="center">
 👋 Hai, semuanya!
    verl adalah library pelatihan RL yang diprakarsai oleh <b>Tim ByteDance Seed</b> dan dikelola oleh komunitas verl.
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

<h1 style="text-align: center;">verl: Volcano Engine Reinforcement Learning untuk LLM</h1>

verl adalah library pelatihan RL yang fleksibel, efisien, dan siap produksi untuk model bahasa besar (LLM).

verl merupakan versi open-source dari makalah **[HybridFlow: A Flexible and Efficient RLHF Framework](https://arxiv.org/abs/2409.19256v2)**.

verl fleksibel dan mudah digunakan dengan:

- **Ekstensi mudah untuk berbagai algoritma RL**: Model pemrograman hybrid-controller memungkinkan representasi fleksibel dan eksekusi efisien alur data post-training yang kompleks. Bangun alur data RL seperti GRPO, PPO hanya dengan beberapa baris kode.

- **Integrasi mulus infrastruktur LLM yang ada dengan API modular**: Memisahkan komputasi dan dependensi data, memungkinkan integrasi mulus dengan framework LLM yang sudah ada, seperti FSDP, Megatron-LM, vLLM, SGLang, dll.

- **Pemetaan perangkat yang fleksibel**: Mendukung berbagai penempatan model pada berbagai GPU untuk pemanfaatan sumber daya yang efisien dan skalabilitas di berbagai ukuran klaster.

- Integrasi siap pakai dengan model HuggingFace populer

verl cepat dengan:

- **Throughput mutakhir (state-of-the-art)**: Integrasi engine pelatihan dan inferensi LLM SOTA serta throughput RL SOTA.

- **Resharding model aktor yang efisien dengan 3D-HybridEngine**: Menghilangkan redundansi memori dan secara signifikan mengurangi overhead komunikasi saat transisi antara fase pelatihan dan generasi.

</p>

## Berita Terbaru

- [2025/06] verl dengan backend Megatron mendukung model MoE besar seperti [DeepSeek-671b dan Qwen3-236b](https://verl.readthedocs.io/en/latest/perf/dpsk.html).
- [2025/06] Tim verl akan menyampaikan pembaruan proyek terbaru di [PyTorch Day China](https://www.lfasiallc.com/pytorch-day-china/) pada 7 Juni. Temui tim pengembang kami di Beijing!
- [2025/05] [PF-PPO](https://arxiv.org/abs/2409.06957), diterima di ICML 2025, kini didukung di verl! PF-PPO meningkatkan efisiensi dan robustness pembelajaran kebijakan dengan memfilter sinyal reward yang berpotensi noise dan menggunakan kembali pengalaman berkualitas tinggi melalui replay buffer.
- [2025/04] Kami akan memberikan tutorial tentang teknik post-training terbaru dan panduan pemrograman verl di [ICLR 2025 Expo](https://iclr.cc/virtual/2025/calendar?filter_events=Expo+Talk+Panel&filter_rooms=), [SCI-FM workshop](https://open-foundation-model.github.io/) dan [LMSys afterparty](https://lu.ma/d23nyynm). Materi presentasi tersedia [di sini](https://github.com/eric-haibin-lin/verl-community/tree/main/iclr25).
- [2025/04] Laporan teknis [Seed-Thinking-v1.5](https://github.com/ByteDance-Seed/Seed-Thinking-v1.5/blob/main/seed-thinking-v1.5.pdf) telah dirilis! Dilatih dengan verl, Seed-Thinking-v1.5 mencapai 86.7 pada AIME 2024, 55.0 pada Codeforces dan 77.3 pada GPQA, menunjukkan kemampuan reasoning yang sangat baik di bidang STEM dan pemrograman. Selain tugas reasoning, metode ini juga menunjukkan generalisasi yang luar biasa di berbagai domain.
- [2025/04] Makalah [VAPO](https://arxiv.org/pdf/2504.05118) (value-based augmented PPO) membahas metode RL terbaru kami untuk model reasoning. Dilatih dari model Qwen-32B-base, VAPO mencapai 60.4 pada AIME 2024, mengungguli DAPO-32B.
- [2025/03] verl v0.3.0.post1 dirilis! Lihat [catatan rilis](https://github.com/volcengine/verl/releases/) untuk detailnya. Mencapai [~1.4x percepatan](https://tongyx361.github.io/blogs/posts/verl-intro/#/verl-flexible-and-efficient-rl-for-llms) dibandingkan versi sebelumnya.
- [2025/03] [DAPO](https://dapo-sia.github.io/) adalah algoritma RL SOTA open-source yang mencapai 50 poin di AIME 2024 berbasis model pra-latih Qwen2.5-32B, melampaui SOTA sebelumnya dari DeepSeek's GRPO (DeepSeek-R1-Zero-Qwen-32B). Pelatihan DAPO sepenuhnya menggunakan verl dan kode reproduksi kini tersedia di `recipe/dapo`.
<details><summary> lebih... </summary>
<ul>
  <li>[2025/05] verl akan dipresentasikan di [A2M Shanghai](https://a2m.msup.com.cn/home/?aid=4488&city=shanghai) pada 16-17 Mei.</li>
  <li>[2025/05] verl akan dipresentasikan di [GOSIM x PyTorch Day 2025](https://paris2025.gosim.org/). Sampai jumpa di Paris! </li>
  <li>[2025/03] Kami memperkenalkan model pemrograman verl di [vLLM Beijing Meetup](https://mp.weixin.qq.com/s/n77GibL2corAtQHtVEAzfg) dan [pengantar & pembaruan verl](https://github.com/eric-haibin-lin/verl-community/blob/main/slides/verl-lmsys-meetup.pdf) di [SGLang-LMSYS Org Meetup](https://lu.ma/ntjrr7ig) di Sunnyvale pertengahan Maret.</li>
  <li>[2025/03] Kami akan mempresentasikan verl(HybridFlow) di EuroSys 2025. Sampai jumpa di Rotterdam!</li>
  <li>[2025/02] verl v0.2.0.post2 dirilis!</li>
  <li>[2025/02] Kami mempresentasikan verl di <a href="https://lu.ma/ji7atxux">Bytedance/NVIDIA/Anyscale Ray Meetup</a>. Sampai jumpa di San Jose!</li>
  <li>[2025/01] [Doubao-1.5-pro](https://team.doubao.com/zh/special/doubao_1_5_pro) dirilis dengan performa SOTA pada LLM & VLM. Model preview RL scaling dilatih menggunakan verl, mencapai performa setara OpenAI O1 pada benchmark matematika (70.0 pass@1 di AIME).</li>
  <li>[2024/12] verl dipresentasikan di Ray Forward 2024. Slide tersedia <a href="https://github.com/eric-haibin-lin/verl-community/blob/main/slides/Ray_Forward_2024_%E5%B7%AB%E9%94%A1%E6%96%8C.pdf">di sini</a></li>
  <li>[2024/12] Tim mempresentasikan <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">Post-training LLMs: From Algorithms to Infrastructure</a> di NeurIPS 2024. <a href="https://github.com/eric-haibin-lin/verl-data/tree/neurips">Slide</a> dan <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">video</a> tersedia.</li>
  <li>[2024/10] verl dipresentasikan di Ray Summit. <a href="https://www.youtube.com/watch?v=MrhMcXkXvJU&list=PLzTswPQNepXntmT8jr9WaNfqQ60QwW7-U&index=37">Video Youtube</a> tersedia.</li>
  <li>[2024/08] HybridFlow (verl) diterima di EuroSys 2025.</li>
</ul>   
</details>

## Fitur Utama

- **FSDP**, **FSDP2** dan **Megatron-LM** untuk pelatihan.
- **vLLM**, **SGLang** dan **HF Transformers** untuk generasi rollout.
- Kompatibel dengan Hugging Face Transformers dan Modelscope Hub: [Qwen-3](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/run_qwen3-8b.sh), Qwen-2.5, Llama3.1, Gemma2, DeepSeek-LLM, dll.
- Fine-tuning terawasi.
- Pembelajaran penguatan dengan [PPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/), [GRPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/), [ReMax](https://raw.githubusercontent.com/volcengine/verl/main/examples/remax_trainer/), [REINFORCE++](https://verl.readthedocs.io/en/latest/examples/config.html#algorithm), [RLOO](https://raw.githubusercontent.com/volcengine/verl/main/examples/rloo_trainer/), [PRIME](https://raw.githubusercontent.com/volcengine/verl/main/recipe/prime/), [DAPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/dapo/), [DrGRPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/drgrpo), dll.
  - Mendukung reward berbasis model dan reward berbasis fungsi (verifiable reward) untuk matematika, [coding](https://github.com/volcengine/verl/tree/main/recipe/dapo), dll.
  - Mendukung model vision-language (VLM) dan [multi-modal RL](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/run_qwen2_5_vl-7b.sh) dengan Qwen2.5-vl, Kimi-VL
  - [Multi-turn dengan tool calling](https://github.com/volcengine/verl/tree/main/examples/sglang_multiturn)
- Resep alignment LLM seperti [Self-play preference optimization (SPPO)](https://github.com/volcengine/verl/tree/main/recipe/sppo)
- Flash attention 2, [sequence packing](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_qwen2-7b_seq_balance.sh), [sequence parallelism](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_deepseek7b_llm_sp2.sh) melalui DeepSpeed Ulysses, [LoRA](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_peft.sh), [Liger-kernel](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_sp2_liger.sh).
- Menskalakan hingga model 671B dan ratusan GPU dengan [expert parallelism](https://github.com/volcengine/verl/pull/1467)
- Dukungan multi-gpu [LoRA RL](https://verl.readthedocs.io/en/latest/advance/ppo_lora.html) untuk menghemat memori.
- Pelacakan eksperimen dengan wandb, swanlab, mlflow dan tensorboard.

## Fitur dan Perubahan Mendatang

- Roadmap https://github.com/volcengine/verl/issues/710
- Optimasi DeepSeek 671b dengan Megatron v0.11 https://github.com/volcengine/verl/issues/708
- Rollout multi-turn dan optimasi penggunaan tools https://github.com/volcengine/verl/issues/1882
- Interaksi lingkungan https://github.com/volcengine/verl/issues/1172
- Daftar breaking changes sejak v0.3 https://github.com/volcengine/verl/discussions/943, entropy_coeff default ke 0
- Lora untuk RL https://github.com/volcengine/verl/pull/1127 

## Memulai

<a href="https://verl.readthedocs.io/en/latest/index.html"><b>Dokumentasi</b></a>

**Quickstart:**

- [Instalasi](https://verl.readthedocs.io/en/latest/start/install.html)
- [Quickstart](https://verl.readthedocs.io/en/latest/start/quickstart.html)
- [Panduan Pemrograman](https://verl.readthedocs.io/en/latest/hybrid_flow.html)
- [PPO di verl](https://verl.readthedocs.io/en/latest/algo/ppo.html)
- [GRPO di verl](https://verl.readthedocs.io/en/latest/algo/grpo.html)

**Menjalankan contoh PPO langkah demi langkah:**


- [Persiapan Data untuk Post-Training](https://verl.readthedocs.io/en/latest/preparation/prepare_data.html)
- [Implementasi Fungsi Reward untuk Dataset](https://verl.readthedocs.io/en/latest/preparation/reward_function.html)
- [Arsitektur Contoh PPO](https://verl.readthedocs.io/en/latest/examples/ppo_code_architecture.html)
- [Penjelasan Konfigurasi](https://verl.readthedocs.io/en/latest/examples/config.html)

**Baseline algoritma yang dapat direproduksi:**

- [Performa RL pada coding, matematika](https://verl.readthedocs.io/en/latest/algo/baseline.html)

**Untuk penjelasan kode dan penggunaan lanjutan (ekstensi):**

- PPO Trainer dan Workers
  - [PPO Ray Trainer](https://verl.readthedocs.io/en/latest/workers/ray_trainer.html)
  - [PyTorch FSDP Backend](https://verl.readthedocs.io/en/latest/workers/fsdp_workers.html)
  - [Megatron-LM Backend](https://verl.readthedocs.io/en/latest/index.html)

- Penggunaan Lanjutan dan Ekstensi
  - [Menambah Model dengan FSDP Backend](https://verl.readthedocs.io/en/latest/advance/fsdp_extension.html)
  - [Menambah Model dengan Megatron-LM Backend](https://verl.readthedocs.io/en/latest/advance/megatron_extension.html)
  - [Dukungan Multi-turn Rollout](https://verl.readthedocs.io/en/latest/sglang_multiturn/multiturn.html)
  - [Integrasi Search Tool](https://verl.readthedocs.io/en/latest/sglang_multiturn/search_tool_example.html)
  - [Integrasi Sandbox Fusion](https://verl.readthedocs.io/en/latest/examples/sandbox_fusion_example.html)
  - [Deployment menggunakan Sumber Daya GPU Terpisah](https://raw.githubusercontent.com/volcengine/verl/main/examples/split_placement)
  - [Perluas ke Algoritma RL(HF) Lainnya](https://verl.readthedocs.io/en/latest/advance/dpo_extension.html)
  - [Tutorial desain API Ray](https://verl.readthedocs.io/en/latest/advance/placement.html)

**Blog dari komunitas**

- [SGLang, verl, OpenBMB dan Universitas Tsinghua: Pelopor End-to-End Multi-Turn RLHF](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/multi-turn/verl-multiturn-rollout-Release.md)
- [Reinforcement Learning dari Human Feedback di GPU AMD dengan integrasi verl dan ROCm](https://rocm.blogs.amd.com/artificial-intelligence/verl-large-scale/README.html)
- [veMLP x verl ：Eksplorasi pelatihan reinforcement learning](https://mp.weixin.qq.com/s/7nbqxk4knMGd-hQE9ls2tA)
- [Praktik terbaik pelatihan RL terdistribusi GRPO menggunakan verl](https://www.volcengine.com/docs/6459/1463942)
- [Analisis asli HybridFlow verl](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/readme.md)
- [Hingga 20x peningkatan throughput! Tim Doubao merilis framework RLHF baru, kini open-source!](https://team.doubao.com/en/blog/%E6%9C%80%E9%AB%98%E6%8F%90%E5%8D%8720%E5%80%8D%E5%90%9E%E5%90%90%E9%87%8F-%E8%B1%86%E5%8C%85%E5%A4%A7%E6%A8%A1%E5%9E%8B%E5%9B%A2%E9%98%9F%E5%8F%91%E5%B8%83%E5%85%A8%E6%96%B0-rlhf-%E6%A1%86%E6%9E%B6-%E7%8E%B0%E5%B7%B2%E5%BC%80%E6%BA%90)

## Panduan Penyetelan Performa

Performa sangat penting untuk algoritma RL on-policy. Kami telah menulis [panduan penyetelan performa](https://verl.readthedocs.io/en/latest/perf/perf_tuning.html) yang detail untuk membantu Anda mengoptimalkan performa.

## Upgrade ke vLLM >= v0.8.2

verl kini mendukung vLLM>=0.8.2 saat menggunakan FSDP sebagai backend pelatihan. Silakan lihat [dokumen ini](https://github.com/volcengine/verl/blob/main/docs/README_vllm0.8.md) untuk panduan instalasi dan informasi lebih lanjut. Hindari vllm 0.7.x, karena mengandung bug yang dapat menyebabkan OOM dan error tak terduga.

## Gunakan SGLang Terbaru

SGLang didukung penuh di verl, dan Grup RL SGLang bekerja membangun fitur unik seperti multi-turn agentic RL, VLM RLHF, RL berbasis server, dan partial rollout. Silakan lihat [dokumen ini](https://verl.readthedocs.io/en/latest/workers/sglang_worker.html) untuk panduan instalasi dan info lebih lanjut.

## Upgrade ke FSDP2

verl sepenuhnya mengadopsi FSDP2! FSDP2 direkomendasikan oleh tim torch distributed, memberikan throughput dan penggunaan memori lebih baik, serta dapat digabung dengan fitur lain (misal torch.compile). Untuk mengaktifkan FSDP2, cukup gunakan verl main dan atur opsi berikut:
```
actor_rollout_ref.ref.strategy=fsdp2
actor_rollout_ref.actor.strategy=fsdp2
critic.strategy=fsdp2 
reward_model.strategy=fsdp2 
```
Selain itu, offloading CPU FSDP2 kompatibel dengan akumulasi gradien. Anda dapat mengaktifkannya untuk menghemat memori dengan `actor_rollout_ref.actor.offload_policy=True`. Detail selengkapnya di https://github.com/volcengine/verl/pull/1026

## Dukungan AMD (Kernel ROCm)

verl kini mendukung FSDP sebagai engine pelatihan (dukungan Megatron segera hadir) serta terintegrasi dengan vLLM dan SGLang sebagai engine inferensi. Silakan lihat [dokumen ini](https://github.com/volcengine/verl/blob/main/docs/amd_tutorial/amd_build_dockerfile_page.rst) untuk panduan instalasi dan info lebih lanjut, serta [dokumen ini](https://github.com/volcengine/verl/blob/main/docs/amd_tutorial/amd_vllm_page.rst) untuk tuning performa vLLM pada ROCm.


## Sitasi dan Pengakuan

Jika Anda merasa proyek ini bermanfaat, silakan kutip:

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

verl terinspirasi dari desain Nemo-Aligner, Deepspeed-chat, dan OpenRLHF. Proyek ini diadopsi dan dikontribusi oleh Bytedance, Anyscale, LMSys.org, [Tim Qwen Alibaba](https://github.com/QwenLM/), Shanghai AI Lab, Universitas Tsinghua, UC Berkeley, UCLA, UIUC, University of Hong Kong, ke.com, [All Hands AI](https://www.all-hands.dev/), [ModelBest](http://modelbest.cn/), OpenPipe, JD AI Lab, Microsoft Research, [StepFun](https://www.stepfun.com/), Amazon, Linkedin, Meituan, [Camel-AI](https://www.camel-ai.org/), [OpenManus](https://github.com/OpenManus), Xiaomi, Prime Intellect, NVIDIA research, [Baichuan](https://www.baichuan-ai.com/home), [RedNote](https://www.xiaohongshu.com/), [SwissAI](https://www.swiss-ai.org/), [Moonshot AI (Kimi)](https://www.moonshot-ai.com/), Baidu, Snowflake, dan banyak lagi.

## Karya-karya Keren Menggunakan verl

- [TinyZero](https://github.com/Jiayi-Pan/TinyZero): reproduksi resep **DeepSeek R1 Zero** untuk tugas reasoning ![GitHub Repo stars](https://img.shields.io/github/stars/Jiayi-Pan/TinyZero)
- [SkyThought](https://github.com/NovaSky-AI/SkyThought): Pelatihan RL untuk Sky-T1-7B oleh tim NovaSky AI. ![GitHub Repo stars](https://img.shields.io/github/stars/NovaSky-AI/SkyThought)
- [simpleRL-reason](https://github.com/hkust-nlp/simpleRL-reason): SimpleRL-Zoo: Investigasi dan Penjinakan Zero Reinforcement Learning untuk Open Base Models in the Wild ![GitHub Repo stars](https://img.shields.io/github/stars/hkust-nlp/simpleRL-reason)
- [Easy-R1](https://github.com/hiyouga/EasyR1): Framework pelatihan RL **multi-modal** ![GitHub Repo stars](https://img.shields.io/github/stars/hiyouga/EasyR1)
- [OpenManus-RL](https://github.com/OpenManus/OpenManus-RL): Framework tuning RL Agen LLM untuk multi lingkungan agen. ![GitHub Repo stars](https://img.shields.io/github/stars/OpenManus/OpenManus-RL)
- [rllm](https://github.com/agentica-project/rllm): pelatihan RL async dengan [verl-pipeline](https://github.com/agentica-project/verl-pipeline) ![GitHub Repo stars](https://img.shields.io/github/stars/agentica-project/rllm)
- [PRIME](https://github.com/PRIME-RL/PRIME): Reinforcement proses melalui reward implisit ![GitHub Repo stars](https://img.shields.io/github/stars/PRIME-RL/PRIME)
- [RAGEN](https://github.com/ZihanWang314/ragen): framework pelatihan **agen** reasoning umum ![GitHub Repo stars](https://img.shields.io/github/stars/ZihanWang314/ragen)
- [Search-R1](https://github.com/PeterGriffinJin/Search-R1): RL dengan reasoning dan **searching (tool-call)** LLM interleaved ![GitHub Repo stars](https://img.shields.io/github/stars/PeterGriffinJin/Search-R1)
- [DeepRetrieval](https://github.com/pat-jj/DeepRetrieval): Pelatihan RL **Agen Pencarian** dengan **Search/Retrieval Outcome** ![GitHub Repo stars](https://img.shields.io/github/stars/pat-jj/DeepRetrieval)
- [ReSearch](https://github.com/Agent-RL/ReSearch): Belajar **Re**ason dengan **Search** untuk LLM melalui RL ![GitHub Repo stars](https://img.shields.io/github/stars/Agent-RL/ReSearch)
- [Code-R1](https://github.com/ganler/code-r1): Mereproduksi R1 untuk **Kode** dengan Reward Andal ![GitHub Repo stars](https://img.shields.io/github/stars/ganler/code-r1)
- [Skywork-OR1](https://github.com/SkyworkAI/Skywork-OR1): Seri Skywork open reasoner ![GitHub Repo stars](https://img.shields.io/github/stars/SkyworkAI/Skywork-OR1)
- [ToRL](https://github.com/GAIR-NLP/ToRL): Menskalakan RL terintegrasi tool ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/ToRL)
- [verl-agent](https://github.com/langfengQ/verl-agent): Framework pelatihan skalabel untuk **agen LLM/VLM long-horizon**, beserta algoritma baru **GiGPO** ![GitHub Repo stars](https://img.shields.io/github/stars/langfengQ/verl-agent)
- [PF-PPO](https://arxiv.org/abs/2409.06957): Policy Filtration untuk PPO berdasarkan reliabilitas sinyal reward demi RLHF yang lebih efisien dan robust.
- [GUI-R1](https://github.com/ritzz-ai/GUI-R1): **GUI-R1**: Model Aksi Vision-Language Generalis R1-style Untuk **Agen GUI** ![GitHub Repo stars](https://img.shields.io/github/stars/ritzz-ai/GUI-R1)
- [DeepResearcher](https://github.com/GAIR-NLP/DeepResearcher): Menskalakan deep research melalui RL di lingkungan nyata ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/DeepResearcher)
- [VAGEN](https://github.com/RAGEN-AI/VAGEN): Melatih agen VLM dengan RL multi-turn ![GitHub Repo stars](https://img.shields.io/github/stars/RAGEN-AI/VAGEN)
- [ReTool](https://retool-rl.github.io/): ReTool: reinforcement learning untuk penggunaan tool strategis pada LLM. Kode segera dirilis...
- [RM-R1](https://arxiv.org/abs/2505.02387): RL pelatihan model reward reasoning ![GitHub Repo stars](https://img.shields.io/github/stars/RM-R1-UIUC/RM-R1)
- [Absolute Zero Reasoner](https://arxiv.org/abs/2505.03335): Framework self-play tanpa data kurasi manusia untuk reasoning![GitHub Repo stars](https://img.shields.io/github/stars/LeapLabTHU/Absolute-Zero-Reasoner)
- [LUFFY](https://arxiv.org/pdf/2504.14945): Belajar Reasoning di bawah Off-Policy Guidance![GitHub Repo stars](https://img.shields.io/github/stars/ElliottYan/LUFFY)
- [verl-tool](https://github.com/TIGER-AI-Lab/verl-tool): Framework pelatihan tool-agent yang terintegrasi dan mudah diperluas berbasis verl![GitHub Repo stars](https://img.shields.io/github/stars/TIGER-AI-Lab/verl-tool)
- [DeepMath](https://github.com/zwhe99/DeepMath): DeepMath-103K data dan seri model untuk reasoning matematika![GitHub Repo stars](https://img.shields.io/github/stars/zwhe99/DeepMath)

dan masih banyak lagi karya keren lainnya di [recipe](https://raw.githubusercontent.com/volcengine/verl/main/recipe/README.md).
## Panduan Kontribusi

Kontribusi dari komunitas sangat kami sambut! Silakan cek [roadmap proyek](https://github.com/volcengine/verl/issues/710) dan [good first issues](https://github.com/volcengine/verl/issues?q=is%3Aissue%20state%3Aopen%20label%3A%22good%20first%20issue%22) untuk melihat di mana Anda bisa berkontribusi.

### Linting dan Formatting Kode

Kami menggunakan pre-commit untuk membantu meningkatkan kualitas kode. Untuk menginisialisasi pre-commit, jalankan:

```bash
pip install pre-commit
pre-commit install
```

Untuk mengatasi error CI secara lokal, Anda dapat menjalankan pre-commit secara manual dengan:

```bash
pre-commit run
```

### Menambahkan Tes CI

Jika memungkinkan, tambahkan tes CI untuk fitur baru Anda:

1. Temukan file workflow yml yang paling relevan, biasanya sesuai dengan config default `hydra` (misal `ppo_trainer`, `ppo_megatron_trainer`, `sft_trainer`, dll).
2. Tambahkan pola path terkait ke bagian `paths` jika belum ada.
3. Minimalkan beban kerja skrip tes (lihat contoh skrip yang sudah ada).

## Tentang [Tim ByteDance Seed](https://team.doubao.com/)

Didirikan pada 2023, Tim ByteDance Seed berdedikasi untuk menciptakan model AI foundation paling maju di industri. Tim ini bercita-cita menjadi tim riset kelas dunia dan berkontribusi signifikan pada kemajuan ilmu pengetahuan dan masyarakat. Anda dapat mengenal Tim ByteDance Seed lebih lanjut melalui kanal-kanal berikut 👇
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

Kami sedang MEMBUKA LOWONGAN! Kirimkan [email](mailto:haibin.lin@bytedance.com) jika Anda tertarik dengan peluang magang/FTE di RL untuk agen.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---