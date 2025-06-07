<div align="center">
 👋 สวัสดีทุกคน! 
    verl คือไลบรารีฝึก RL ที่ริเริ่มโดย <b>ทีม ByteDance Seed</b> และดูแลโดยชุมชน verl
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

<h1 style="text-align: center;">verl: Volcano Engine Reinforcement Learning สำหรับ LLMs</h1>

verl คือไลบรารีฝึก RL ที่ยืดหยุ่น มีประสิทธิภาพ และพร้อมใช้งานสำหรับโมเดลภาษาใหญ่ (LLMs)

verl คือเวอร์ชันโอเพ่นซอร์สของผลงานวิจัย **[HybridFlow: A Flexible and Efficient RLHF Framework](https://arxiv.org/abs/2409.19256v2)**

verl ยืดหยุ่นและใช้งานง่ายด้วย:

- **ขยายอัลกอริทึม RL ได้ง่าย**: โมเดล hybrid-controller ช่วยให้สามารถแสดงและประมวลผล dataflow หลังการฝึกที่ซับซ้อนได้อย่างยืดหยุ่นและมีประสิทธิภาพ สร้าง RL dataflow เช่น GRPO, PPO ได้ในไม่กี่บรรทัดโค้ด

- **รวมโครงสร้าง LLM ที่มีอยู่เดิมเข้าด้วย API แบบโมดูลาร์**: แยก computation และ data dependency ออกจากกัน ทำให้รวมกับเฟรมเวิร์ก LLM ที่มีอยู่เช่น FSDP, Megatron-LM, vLLM, SGLang ฯลฯ ได้อย่างไร้รอยต่อ

- **Flexible device mapping**: รองรับการจัดวางโมเดลบน GPU หลายชุด เพื่อการใช้ทรัพยากรที่มีประสิทธิภาพและรองรับการขยายกับคลัสเตอร์ขนาดต่างๆ

- พร้อมใช้กับโมเดลยอดนิยมของ HuggingFace

verl เร็วและมีประสิทธิภาพด้วย:

- **Throughput ระดับ SOTA**: ผสานรวม engine ฝึกและ inference ของ LLM ระดับ SOTA และ throughput ของ RL ระดับ SOTA

- **Resharding actor model อย่างมีประสิทธิภาพด้วย 3D-HybridEngine**: ลดการใช้หน่วยความจำซ้ำซ้อนและลด overhead ในการสื่อสารระหว่างเฟสฝึกและเฟสสร้าง

</p>

## ข่าวสาร

- [2025/06] verl พร้อม backend Megatron รองรับโมเดล MoE ใหญ่เช่น [DeepSeek-671b และ Qwen3-236b](https://verl.readthedocs.io/en/latest/perf/dpsk.html)
- [2025/06] ทีม verl จะอัปเดตโปรเจกต์ล่าสุดที่ [PyTorch Day China](https://www.lfasiallc.com/pytorch-day-china/) วันที่ 7 มิ.ย. พบทีม dev ของเราได้ที่ปักกิ่ง!
- [2025/05] [PF-PPO](https://arxiv.org/abs/2409.06957) ที่ได้รับการยอมรับในงาน ICML 2025 ได้รับการรองรับใน verl แล้ว! PF-PPO เพิ่มประสิทธิภาพและความเสถียรในการเรียนรู้ policy ด้วยการกรอง reward ที่อาจมี noise และนำประสบการณ์คุณภาพสูงกลับมาใช้ใหม่ผ่าน replay buffer
- [2025/04] เราจะให้ tutorial เรื่องเทคนิค post-training ล่าสุดและแนวทางโปรแกรมสำหรับ verl ที่ [ICLR 2025 Expo](https://iclr.cc/virtual/2025/calendar?filter_events=Expo+Talk+Panel&filter_rooms=), [SCI-FM workshop](https://open-foundation-model.github.io/) และ [LMSys afterparty](https://lu.ma/d23nyynm) เอกสารประกอบการบรรยาย [ที่นี่](https://github.com/eric-haibin-lin/verl-community/tree/main/iclr25)
- [2025/04] รายงานเทคนิค [Seed-Thinking-v1.5](https://github.com/ByteDance-Seed/Seed-Thinking-v1.5/blob/main/seed-thinking-v1.5.pdf) เปิดตัวแล้ว! ฝึกด้วย verl, Seed-Thinking-v1.5 ได้คะแนน 86.7 บน AIME 2024, 55.0 บน Codeforces และ 77.3 บน GPQA แสดงศักยภาพ reasoning ที่ยอดเยี่ยมในสาย STEM และโค้ดดิ้ง นอกจากนี้ยังแสดงการ generalize ได้ดีในงานหลากหลาย
- [2025/04] [VAPO](https://arxiv.org/pdf/2504.05118) (value-based augmented PPO) นำเสนอวิธี RL ล่าสุดสำหรับ reasoning models ฝึกจาก Qwen-32B-base VAPO ได้ 60.4 บน AIME 2024 ดีกว่า DAPO-32B
- [2025/03] verl v0.3.0.post1 เปิดตัว! ดู [release note](https://github.com/volcengine/verl/releases/) รายละเอียด เทียบกับเวอร์ชันก่อน เร็วขึ้น [~1.4x](https://tongyx361.github.io/blogs/posts/verl-intro/#/verl-flexible-and-efficient-rl-for-llms)
- [2025/03] [DAPO](https://dapo-sia.github.io/) คืออัลกอริทึม RL SOTA แบบโอเพ่นซอร์สที่ได้ 50 คะแนนบน AIME 2024 ด้วย Qwen2.5-32B pre-trained model ดีกว่า SOTA ก่อนหน้าของ DeepSeek’s GRPO (DeepSeek-R1-Zero-Qwen-32B) ฝึกโดยใช้ verl ทั้งหมด โค้ด reproduction มีใน `recipe/dapo` แล้ว
<details><summary> เพิ่มเติม... </summary>
<ul>
  <li>[2025/05] verl จะถูกนำเสนอที่ [A2M Shanghai](https://a2m.msup.com.cn/home/?aid=4488&city=shanghai) วันที่ 16-17 พ.ค.</li>
  <li>[2025/05] verl จะถูกนำเสนอที่ [GOSIM x PyTorch Day 2025](https://paris2025.gosim.org/) พบกันที่ปารีส!</li>
  <li>[2025/03] เราแนะนำ programming model ของ verl ที่ [vLLM Beijing Meetup](https://mp.weixin.qq.com/s/n77GibL2corAtQHtVEAzfg) และ [verl intro and updates](https://github.com/eric-haibin-lin/verl-community/blob/main/slides/verl-lmsys-meetup.pdf) ที่ [SGLang-LMSYS Org Meetup](https://lu.ma/ntjrr7ig) ที่ Sunnyvale กลางเดือนมีนาคม</li>
  <li>[2025/03] เราจะนำเสนอ verl(HybridFlow) ที่ EuroSys 2025 เจอกันที่ Rotterdam!</li>
  <li>[2025/02] verl v0.2.0.post2 เปิดตัวแล้ว!</li>
  <li>[2025/02] เรานำเสนอ verl ใน <a href="https://lu.ma/ji7atxux">Bytedance/NVIDIA/Anyscale Ray Meetup</a> เจอกันที่ San Jose!</li>
  <li>[2025/01] [Doubao-1.5-pro](https://team.doubao.com/zh/special/doubao_1_5_pro) เปิดตัวพร้อมประสิทธิภาพระดับ SOTA บน LLM & VLM โมเดล RL scaling preview ฝึกด้วย verl ได้ระดับ OpenAI O1 บนเบนช์มาร์คคณิตศาสตร์ (70.0 pass@1 บน AIME)</li>
  <li>[2024/12] verl นำเสนอที่ Ray Forward 2024. สไลด์ <a href="https://github.com/eric-haibin-lin/verl-community/blob/main/slides/Ray_Forward_2024_%E5%B7%AB%E9%94%A1%E6%96%8C.pdf">ที่นี่</a></li>
  <li>[2024/12] ทีมงานนำเสนอ <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">Post-training LLMs: From Algorithms to Infrastructure</a> ที่ NeurIPS 2024 <a href="https://github.com/eric-haibin-lin/verl-data/tree/neurips">สไลด์</a> และ <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">วิดีโอ</a> มีให้ดู</li>
  <li>[2024/10] verl นำเสนอที่ Ray Summit <a href="https://www.youtube.com/watch?v=MrhMcXkXvJU&list=PLzTswPQNepXntmT8jr9WaNfqQ60QwW7-U&index=37">วิดีโอ Youtube</a></li>
  <li>[2024/08] HybridFlow (verl) ได้รับการตอบรับใน EuroSys 2025</li>
</ul>   
</details>

## คุณสมบัติเด่น

- รองรับ **FSDP**, **FSDP2** และ **Megatron-LM** สำหรับการฝึก
- รองรับ **vLLM**, **SGLang** และ **HF Transformers** สำหรับ rollout generation
- เข้ากันได้กับ Hugging Face Transformers และ Modelscope Hub: [Qwen-3](https://github.com/volcengine/verl/blob/main/examples/grpo_trainer/run_qwen3-8b.sh), Qwen-2.5, Llama3.1, Gemma2, DeepSeek-LLM เป็นต้น
- Supervised fine-tuning
- Reinforcement learning ด้วย [PPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/), [GRPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/), [ReMax](https://raw.githubusercontent.com/volcengine/verl/main/examples/remax_trainer/), [REINFORCE++](https://verl.readthedocs.io/en/latest/examples/config.html#algorithm), [RLOO](https://raw.githubusercontent.com/volcengine/verl/main/examples/rloo_trainer/), [PRIME](https://raw.githubusercontent.com/volcengine/verl/main/recipe/prime/), [DAPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/dapo/), [DrGRPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/drgrpo) ฯลฯ
  - รองรับ reward จาก model และ reward จากฟังก์ชัน (verifiable reward) สำหรับคณิตศาสตร์, [coding](https://github.com/volcengine/verl/tree/main/recipe/dapo) ฯลฯ
  - รองรับ vision-language models (VLMs) และ [multi-modal RL](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/run_qwen2_5_vl-7b.sh) ด้วย Qwen2.5-vl, Kimi-VL
  - [Multi-turn พร้อม tool calling](https://github.com/volcengine/verl/tree/main/examples/sglang_multiturn)
- สูตร alignment LLM เช่น [Self-play preference optimization (SPPO)](https://github.com/volcengine/verl/tree/main/recipe/sppo)
- Flash attention 2, [sequence packing](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_qwen2-7b_seq_balance.sh), [sequence parallelism](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_deepseek7b_llm_sp2.sh) ผ่าน DeepSpeed Ulysses, [LoRA](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_peft.sh), [Liger-kernel](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_sp2_liger.sh)
- ขยายได้ถึง 671B models และ GPU หลายร้อยตัวด้วย [expert parallelism](https://github.com/volcengine/verl/pull/1467)
- Multi-gpu [LoRA RL](https://verl.readthedocs.io/en/latest/advance/ppo_lora.html) เพื่อประหยัดหน่วยความจำ
- ติดตามผลการทดลองด้วย wandb, swanlab, mlflow และ tensorboard

## ฟีเจอร์และการเปลี่ยนแปลงในอนาคต

- Roadmap https://github.com/volcengine/verl/issues/710
- DeepSeek 671b ปรับแต่งด้วย Megatron v0.11 https://github.com/volcengine/verl/issues/708
- Multi-turn rollout และ tools ด้วย optimization https://github.com/volcengine/verl/issues/1882
- การโต้ตอบกับ environment https://github.com/volcengine/verl/issues/1172
- รายการ breaking changes ตั้งแต่ v0.3 https://github.com/volcengine/verl/discussions/943, entropy_coeff ค่า default เป็น 0
- Lora สำหรับ RL https://github.com/volcengine/verl/pull/1127 

## เริ่มต้นใช้งาน

<a href="https://verl.readthedocs.io/en/latest/index.html"><b>เอกสาร</b></a>

**เริ่มต้นอย่างรวดเร็ว:**

- [ติดตั้ง](https://verl.readthedocs.io/en/latest/start/install.html)
- [Quickstart](https://verl.readthedocs.io/en/latest/start/quickstart.html)
- [Programming Guide](https://verl.readthedocs.io/en/latest/hybrid_flow.html)
- [PPO ใน verl](https://verl.readthedocs.io/en/latest/algo/ppo.html)
- [GRPO ใน verl](https://verl.readthedocs.io/en/latest/algo/grpo.html)

**สอนใช้งาน PPO อย่างละเอียด:**

- [เตรียมข้อมูลสำหรับ Post-Training](https://verl.readthedocs.io/en/latest/preparation/prepare_data.html)
- [สร้าง Reward Function สำหรับ Dataset](https://verl.readthedocs.io/en/latest/preparation/reward_function.html)
- [สถาปัตยกรรมตัวอย่าง PPO](https://verl.readthedocs.io/en/latest/examples/ppo_code_architecture.html)
- [คำอธิบาย config](https://verl.readthedocs.io/en/latest/examples/config.html)

**อัลกอริทึม baseline ที่ reproducible:**

- [ประสิทธิภาพ RL ใน coding, math](https://verl.readthedocs.io/en/latest/algo/baseline.html)

**สำหรับอธิบายโค้ดและการใช้งานขั้นสูง (extension):**

- PPO Trainer และ Workers
  - [PPO Ray Trainer](https://verl.readthedocs.io/en/latest/workers/ray_trainer.html)
  - [PyTorch FSDP Backend](https://verl.readthedocs.io/en/latest/workers/fsdp_workers.html)
  - [Megatron-LM Backend](https://verl.readthedocs.io/en/latest/index.html)

- การใช้งานขั้นสูงและ extension
  - [เพิ่มโมเดลด้วย FSDP Backend](https://verl.readthedocs.io/en/latest/advance/fsdp_extension.html)
  - [เพิ่มโมเดลด้วย Megatron-LM Backend](https://verl.readthedocs.io/en/latest/advance/megatron_extension.html)
  - [รองรับ Multi-turn Rollout](https://verl.readthedocs.io/en/latest/sglang_multiturn/multiturn.html)
  - [การรวม Search Tool](https://verl.readthedocs.io/en/latest/sglang_multiturn/search_tool_example.html)
  - [การรวม Sandbox Fusion](https://verl.readthedocs.io/en/latest/examples/sandbox_fusion_example.html)
  - [Deployment แยกใช้ GPU](https://github.com/volcengine/verl/tree/main/examples/split_placement)
  - [ขยายสู่อัลกอริทึม RL(HF) อื่นๆ](https://verl.readthedocs.io/en/latest/advance/dpo_extension.html)
  - [Ray API design tutorial](https://verl.readthedocs.io/en/latest/advance/placement.html)

**บล็อกจากชุมชน**

- [SGLang, verl, OpenBMB และ Tsinghua: พัฒนา End-to-End Multi-Turn RLHF](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/multi-turn/verl-multiturn-rollout-Release.md)
- [Reinforcement Learning from Human Feedback บน AMD GPU ด้วย verl และ ROCm Integration](https://rocm.blogs.amd.com/artificial-intelligence/verl-large-scale/README.html)
- [veMLP x verl ：เล่นกับการฝึก RL](https://mp.weixin.qq.com/s/7nbqxk4knMGd-hQE9ls2tA)
- [ฝึก GRPO แบบ distributed RL ด้วย verl อย่างไรให้ดีที่สุด](https://www.volcengine.com/docs/6459/1463942)
- [วิเคราะห์ต้นฉบับ HybridFlow verl](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/readme.md)
- [เพิ่ม throughput สูงสุด 20 เท่า! ทีม Doubao เปิดตัว RLHF Framework ใหม่ล่าสุด เปิดซอร์สแล้ว!](https://team.doubao.com/en/blog/%E6%9C%80%E9%AB%98%E6%8F%90%E5%8D%8720%E5%80%8D%E5%90%9E%E5%90%90%E9%87%8F-%E8%B1%86%E5%8C%85%E5%A4%A7%E6%A8%A1%E5%9E%8B%E5%9B%A2%E9%98%9F%E5%8F%91%E5%B8%83%E5%85%A8%E6%96%B0-rlhf-%E6%A1%86%E6%9E%B6-%E7%8E%B0%E5%B7%B2%E5%BC%80%E6%BA%90)

## Performance Tuning Guide

ประสิทธิภาพสำคัญสำหรับอัลกอริทึม RL แบบ on-policy เราเขียน [คู่มือปรับจูนประสิทธิภาพ](https://verl.readthedocs.io/en/latest/perf/perf_tuning.html) อย่างละเอียดเพื่อช่วยให้คุณ optimize ได้

## อัปเกรดเป็น vLLM >= v0.8.2

verl รองรับ vLLM>=0.8.2 เมื่อใช้ FSDP เป็น backend ฝึก กรุณาดู [เอกสารนี้](https://github.com/volcengine/verl/blob/main/docs/README_vllm0.8.md) สำหรับวิธีติดตั้งและข้อมูลเพิ่มเติม ควรหลีกเลี่ยง vllm 0.7.x ที่มี bug อาจทำให้ OOM และ error ที่ไม่คาดคิด

## ใช้ SGLang เวอร์ชันล่าสุด

SGLang รองรับเต็มรูปแบบกับ verl และกลุ่ม SGLang RL กำลังพัฒนาฟีเจอร์ใหม่ๆ เช่น multi-turn agentic RL, VLM RLHF, server-based RL, partial rollout กรุณาดู [เอกสารนี้](https://verl.readthedocs.io/en/latest/workers/sglang_worker.html) สำหรับวิธีติดตั้งและข้อมูลเพิ่มเติม

## อัปเกรดเป็น FSDP2

verl รองรับ FSDP2 เต็มที่! FSDP2 แนะนำโดยทีม torch distributed ให้ throughput ดีกว่า ใช้ memory น้อยกว่า และรวมกับฟีเจอร์อื่นๆ ได้ (เช่น torch.compile) แค่ใช้ verl main และตั้ง options ต่อไปนี้:
```
actor_rollout_ref.ref.strategy=fsdp2
actor_rollout_ref.actor.strategy=fsdp2
critic.strategy=fsdp2 
reward_model.strategy=fsdp2 
```
นอกจากนี้ FSDP2 cpu offload เข้ากันได้กับ gradient accumulation เปิดใช้งานประหยัดหน่วยความจำได้ด้วย `actor_rollout_ref.actor.offload_policy=True` ดูรายละเอียดเพิ่มเติมที่ https://github.com/volcengine/verl/pull/1026

## รองรับ AMD (ROCm Kernel)

verl รองรับ FSDP เป็น engine ฝึก (Megatron จะตามมาเร็วๆ นี้) และรวมกับ vLLM และ SGLang เป็น inference engine ดู [เอกสารนี้](https://github.com/volcengine/verl/blob/main/docs/amd_tutorial/amd_build_dockerfile_page.rst) สำหรับวิธีติดตั้งและข้อมูลเพิ่มเติม และ [เอกสารนี้](https://github.com/volcengine/verl/blob/main/docs/amd_tutorial/amd_vllm_page.rst) สำหรับปรับจูน vLLM สำหรับ ROCm

## การอ้างอิงและขอบคุณ

หากคุณพบว่าโปรเจกต์นี้มีประโยชน์ โปรดอ้างอิง:

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

verl ได้แรงบันดาลใจจาก Nemo-Aligner, Deepspeed-chat และ OpenRLHF โปรเจกต์นี้ได้รับการรับและมีส่วนร่วมจาก Bytedance, Anyscale, LMSys.org, [Alibaba Qwen team](https://github.com/QwenLM/), Shanghai AI Lab, Tsinghua University, UC Berkeley, UCLA, UIUC, University of Hong Kong, ke.com, [All Hands AI](https://www.all-hands.dev/), [ModelBest](http://modelbest.cn/), OpenPipe, JD AI Lab, Microsoft Research, [StepFun](https://www.stepfun.com/), Amazon, Linkedin, Meituan, [Camel-AI](https://www.camel-ai.org/), [OpenManus](https://github.com/OpenManus), Xiaomi, Prime Intellect, NVIDIA research, [Baichuan](https://www.baichuan-ai.com/home), [RedNote](https://www.xiaohongshu.com/), [SwissAI](https://www.swiss-ai.org/), [Moonshot AI (Kimi)](https://www.moonshot-ai.com/), Baidu, Snowflake และอื่นๆ อีกมากมาย

## ผลงานเด่นที่ใช้ verl

- [TinyZero](https://github.com/Jiayi-Pan/TinyZero): รีโปรดิวซ์ **DeepSeek R1 Zero** สำหรับ reasoning tasks ![GitHub Repo stars](https://img.shields.io/github/stars/Jiayi-Pan/TinyZero)
- [SkyThought](https://github.com/NovaSky-AI/SkyThought): RL training สำหรับ Sky-T1-7B โดยทีม NovaSky AI ![GitHub Repo stars](https://img.shields.io/github/stars/NovaSky-AI/SkyThought)
- [simpleRL-reason](https://github.com/hkust-nlp/simpleRL-reason): SimpleRL-Zoo: สำรวจและควบคุม Zero RL สำหรับ Open Base Models ![GitHub Repo stars](https://img.shields.io/github/stars/hkust-nlp/simpleRL-reason)
- [Easy-R1](https://github.com/hiyouga/EasyR1): เฟรมเวิร์ค RL **มัลติโหมด** ![GitHub Repo stars](https://img.shields.io/github/stars/hiyouga/EasyR1)
- [OpenManus-RL](https://github.com/OpenManus/OpenManus-RL): เฟรมเวิร์ค RL สำหรับ LLM Agents หลาย environment ![GitHub Repo stars](https://img.shields.io/github/stars/OpenManus/OpenManus-RL)
- [rllm](https://github.com/agentica-project/rllm): RL แบบ async ด้วย [verl-pipeline](https://github.com/agentica-project/verl-pipeline) ![GitHub Repo stars](https://img.shields.io/github/stars/agentica-project/rllm)
- [PRIME](https://github.com/PRIME-RL/PRIME): Process reinforcement ผ่าน implicit rewards ![GitHub Repo stars](https://img.shields.io/github/stars/PRIME-RL/PRIME)
- [RAGEN](https://github.com/ZihanWang314/ragen): เฟรมเวิร์คฝึก **agent** reasoning ทั่วไป ![GitHub Repo stars](https://img.shields.io/github/stars/ZihanWang314/ragen)
- [Search-R1](https://github.com/PeterGriffinJin/Search-R1): RL ที่ผสม reasoning กับ **searching (tool-call)** ![GitHub Repo stars](https://img.shields.io/github/stars/PeterGriffinJin/Search-R1)
- [DeepRetrieval](https://github.com/pat-jj/DeepRetrieval): RL Training **Search Agent** ด้วย **Search/Retrieval Outcome** ![GitHub Repo stars](https://img.shields.io/github/stars/pat-jj/DeepRetrieval)
- [ReSearch](https://github.com/Agent-RL/ReSearch): สอน **Reason** ด้วย **Search** บน LLMs ผ่าน RL ![GitHub Repo stars](https://img.shields.io/github/stars/Agent-RL/ReSearch)
- [Code-R1](https://github.com/ganler/code-r1): รีโปรดิวซ์ R1 สำหรับ **โค้ด** ด้วยรางวัลที่เชื่อถือได้ ![GitHub Repo stars](https://img.shields.io/github/stars/ganler/code-r1)
- [Skywork-OR1](https://github.com/SkyworkAI/Skywork-OR1): Skywork open reaonser series ![GitHub Repo stars](https://img.shields.io/github/stars/SkyworkAI/Skywork-OR1)
- [ToRL](https://github.com/GAIR-NLP/ToRL): RL แบบ tool-integrated ที่ขยายได้ ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/ToRL)
- [verl-agent](https://github.com/langfengQ/verl-agent): เฟรมเวิร์คฝึก **agent LLM/VLM ระยะยาว** ที่ขยายขนาดได้ พร้อมอัลกอริทึมใหม่ **GiGPO** ![GitHub Repo stars](https://img.shields.io/github/stars/langfengQ/verl-agent)
- [PF-PPO](https://arxiv.org/abs/2409.06957): Policy Filtration for PPO สำหรับความน่าเชื่อถือของ reward เพิ่มประสิทธิภาพและความเสถียรของ RLHF
- [GUI-R1](https://github.com/ritzz-ai/GUI-R1): **GUI-R1**: Vision-Language Action Model สำหรับ **GUI Agents** ![GitHub Repo stars](https://img.shields.io/github/stars/ritzz-ai/GUI-R1)
- [DeepResearcher](https://github.com/GAIR-NLP/DeepResearcher): RL ขยายขีดความสามารถด้าน research ใน environment จริง ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/DeepResearcher)
- [VAGEN](https://github.com/RAGEN-AI/VAGEN): ฝึก VLM agents ด้วย multi-turn RL ![GitHub Repo stars](https://img.shields.io/github/stars/RAGEN-AI/VAGEN)
- [ReTool](https://retool-rl.github.io/): ReTool: RL สำหรับ LLMs ที่ใช้เครื่องมือเชิงกลยุทธ์ รอโค้ดเร็วๆ นี้...
- [RM-R1](https://arxiv.org/abs/2505.02387): RL training ของ reasoning reward models ![GitHub Repo stars](https://img.shields.io/github/stars/RM-R1-UIUC/RM-R1)
- [Absolute Zero Reasoner](https://arxiv.org/abs/2505.03335): เฟรมเวิร์ค self-play reasoning ที่ไม่ต้องใช้ human curated data ![GitHub Repo stars](https://img.shields.io/github/stars/LeapLabTHU/Absolute-Zero-Reasoner)
- [LUFFY](https://arxiv.org/pdf/2504.14945): Learning to Reason under Off-Policy Guidance![GitHub Repo stars](https://img.shields.io/github/stars/ElliottYan/LUFFY)
- [verl-tool](https://github.com/TIGER-AI-Lab/verl-tool): เฟรมเวิร์ค train tool-agent ที่ unified และขยายง่ายบน verl![GitHub Repo stars](https://img.shields.io/github/stars/TIGER-AI-Lab/verl-tool)
- [DeepMath](https://github.com/zwhe99/DeepMath): ข้อมูล DeepMath-103K และโมเดล reasoning ทางคณิตศาสตร์![GitHub Repo stars](https://img.shields.io/github/stars/zwhe99/DeepMath)

และผลงานอื่นๆ อีกมากมายใน [recipe](https://raw.githubusercontent.com/volcengine/verl/main/recipe/README.md)
## แนวทางการมีส่วนร่วม

ชุมชนสามารถมีส่วนร่วมได้! ดู [roadmap โปรเจกต์](https://github.com/volcengine/verl/issues/710) และ [good first issues](https://github.com/volcengine/verl/issues?q=is%3Aissue%20state%3Aopen%20label%3A%22good%20first%20issue%22) เพื่อดูว่าคุณจะช่วยอะไรได้บ้าง

### การตรวจสอบรูปแบบโค้ด

เราใช้ pre-commit เพื่อช่วยปรับปรุงคุณภาพโค้ด เริ่มต้น pre-commit ด้วย:

```bash
pip install pre-commit
pre-commit install
```

หาก CI error สามารถแก้ไขเองโดยรัน:

```bash
pre-commit run
```

### การเพิ่ม CI tests

ถ้าเป็นไปได้ เพิ่ม CI test สำหรับฟีเจอร์ใหม่ของคุณ:

1. หา workflow yml ที่เกี่ยวข้องที่สุด ซึ่งมักจะตรงกับ config `hydra` (เช่น `ppo_trainer`, `ppo_megatron_trainer`, `sft_trainer` ฯลฯ)
2. เพิ่ม path pattern ที่เกี่ยวข้องใน `paths` ถ้ายังไม่มี
3. ลด workload ของ test script ให้มากที่สุด (ดูตัวอย่างจากสคริปต์ที่มีอยู่)

## เกี่ยวกับ [ByteDance Seed Team](https://team.doubao.com/)

ก่อตั้งในปี 2023 ByteDance Seed Team มุ่งเน้นพัฒนาโมเดล AI พื้นฐานที่ล้ำหน้าที่สุดในอุตสาหกรรม ทีมตั้งเป้าสู่ทีมวิจัยระดับโลกและสร้างประโยชน์อย่างมีนัยสำคัญต่อวิทยาศาสตร์และสังคม รู้จักทีม ByteDance Seed เพิ่มเติมได้ที่ช่องทางต่อไปนี้👇
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

เรารับสมัครงาน! สนใจฝึกงาน/ร่วมงานแบบประจำในสาย RL สำหรับเอเจนต์ ส่ง [email](mailto:haibin.lin@bytedance.com) มาหาเราได้เลย

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---