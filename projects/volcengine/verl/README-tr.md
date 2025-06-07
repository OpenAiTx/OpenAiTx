<div align="center">
 👋 Merhaba, herkese! 
    verl, <b>ByteDance Seed ekibi</b> tarafından başlatılan ve verl topluluğu tarafından sürdürülen bir RL eğitim kütüphanesidir.
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

<h1 style="text-align: center;">verl: LLM'ler için Volcano Engine Takviyeli Öğrenme (Reinforcement Learning)</h1>

verl, büyük dil modelleri (LLM'ler) için esnek, verimli ve üretime hazır bir RL eğitim kütüphanesidir.

verl, **[HybridFlow: A Flexible and Efficient RLHF Framework](https://arxiv.org/abs/2409.19256v2)** makalesinin açık kaynaklı versiyonudur.

verl, aşağıdaki özellikleriyle esnek ve kullanımı kolaydır:

- **Çeşitli RL algoritmalarının kolayca genişletilmesi:** Hibrid-kontrolcü programlama modeli, karmaşık eğitim sonrası veri akışlarının esnek şekilde temsil edilmesini ve verimli şekilde yürütülmesini sağlar. GRPO, PPO gibi RL veri akışlarını birkaç satır kod ile oluşturun.

- **Mevcut LLM altyapısı ile modüler API'ler ile sorunsuz entegrasyon:** Hesaplama ve veri bağımlılıklarını ayırır, mevcut LLM framework'leriyle (FSDP, Megatron-LM, vLLM, SGLang vb.) sorunsuz entegrasyona olanak tanır.

- **Esnek cihaz haritalama:** Modellerin farklı GPU kümelerine yerleştirilmesini destekler; kaynakların verimli kullanımı ve farklı küme boyutları arasında ölçeklenebilirlik sağlar.

- Popüler HuggingFace modelleriyle hazır entegrasyon

verl hızlıdır çünkü:

- **En güncel (SOTA) aktarım oranı:** SOTA LLM eğitim ve çıkarım motoru entegrasyonları ve SOTA RL aktarım hızı.

- **3D-HybridEngine ile verimli aktör modeli yeniden bölütleme (resharding):** Eğitim ve üretim aşamaları arasındaki geçişlerde bellek fazlalığını ortadan kaldırır ve iletişim yükünü önemli ölçüde azaltır.

</p>

## Haberler

- [2025/06] Megatron backend ile verl, [DeepSeek-671b ve Qwen3-236b](https://verl.readthedocs.io/en/latest/perf/dpsk.html) gibi büyük MoE modellerini destekliyor.
- [2025/06] verl ekibi [PyTorch Day China](https://www.lfasiallc.com/pytorch-day-china/) etkinliğinde 7 Haziran'da son proje güncellemelerini sunacak. Pekin'de geliştirme ekibimizle tanışın!
- [2025/05] [PF-PPO](https://arxiv.org/abs/2409.06957), ICML 2025'e kabul edildi ve artık verl'de destekleniyor! PF-PPO, potansiyel olarak gürültülü ödül sinyallerini filtreleyerek ve yüksek kaliteli deneyimleri tekrar kullanarak politika öğrenme verimliliğini ve sağlamlığını artırır.
- [2025/04] [ICLR 2025 Expo](https://iclr.cc/virtual/2025/calendar?filter_events=Expo+Talk+Panel&filter_rooms=), [SCI-FM workshop](https://open-foundation-model.github.io/) ve [LMSys afterparty](https://lu.ma/d23nyynm) etkinliklerinde verl ile ilgili en yeni eğitim sonrası teknikler ve programlama rehberi hakkında bir eğitim vereceğiz. Sunum materyallerine [buradan](https://github.com/eric-haibin-lin/verl-community/tree/main/iclr25) ulaşabilirsiniz.
- [2025/04] [Seed-Thinking-v1.5](https://github.com/ByteDance-Seed/Seed-Thinking-v1.5/blob/main/seed-thinking-v1.5.pdf) teknik raporu yayımlandı! verl ile eğitilen Seed-Thinking-v1.5, AIME 2024'te 86.7, Codeforces'da 55.0, GPQA'da 77.3 puan alarak STEM ve kodlama alanlarında mükemmel akıl yürütme yetenekleri sergilemektedir. Yöntem ayrıca, çeşitli alanlarda dikkate değer genelleme kabiliyeti göstermektedir.
- [2025/04] [VAPO](https://arxiv.org/pdf/2504.05118) (değer tabanlı geliştirilmiş PPO) makalesi, akıl yürütme modelleri için en yeni RL metodumuzu kapsar. Qwen-32B-base modelinden eğitilen VAPO, AIME 2024'te 60.4 skoruna ulaşarak DAPO-32B'yi geride bırakmıştır.
- [2025/03] verl v0.3.0.post1 yayımlandı! Ayrıntılar için [sürüm notuna](https://github.com/volcengine/verl/releases/) bakın. Önceki sürümlere kıyasla [~1.4x hız artışı](https://tongyx361.github.io/blogs/posts/verl-intro/#/verl-flexible-and-efficient-rl-for-llms) elde edilmiştir.
- [2025/03] [DAPO](https://dapo-sia.github.io/) açık kaynak SOTA RL algoritmasıdır ve Qwen2.5-32B ön-eğitimli modeli ile AIME 2024'te 50 puan elde ederek DeepSeek'in GRPO'sunu (DeepSeek-R1-Zero-Qwen-32B) geçmiştir. DAPO'nun eğitimi tamamen verl ile yapılmaktadır ve yeniden üretim kodu artık `recipe/dapo` dizininde mevcuttur.
<details><summary> daha fazla... </summary>
<ul>
  <li>[2025/05] verl, [A2M Shanghai](https://a2m.msup.com.cn/home/?aid=4488&city=shanghai) etkinliğinde 16-17 Mayıs'ta sunulacaktır.</li>
  <li>[2025/05] verl, [GOSIM x PyTorch Day 2025](https://paris2025.gosim.org/) etkinliğinde sunulacak. Paris'te görüşmek üzere!</li>
  <li>[2025/03] verl'in programlama modelini [vLLM Beijing Meetup](https://mp.weixin.qq.com/s/n77GibL2corAtQHtVEAzfg) ve [SGLang-LMSYS Org Meetup](https://lu.ma/ntjrr7ig) etkinliklerinde tanıttık, ayrıntılar için [verl intro and updates](https://github.com/eric-haibin-lin/verl-community/blob/main/slides/verl-lmsys-meetup.pdf).</li>
  <li>[2025/03] verl(HybridFlow) EuroSys 2025'te sunulacak. Rotterdam'da görüşmek üzere!</li>
  <li>[2025/02] verl v0.2.0.post2 yayımlandı!</li>
  <li>[2025/02] verl'i <a href="https://lu.ma/ji7atxux">Bytedance/NVIDIA/Anyscale Ray Meetup</a>'ta sunduk. San Jose'de görüşmek üzere!</li>
  <li>[2025/01] [Doubao-1.5-pro](https://team.doubao.com/zh/special/doubao_1_5_pro), LLM & VLM'de SOTA seviyesinde performans ile yayımlandı. RL ölçekleme önizleme modeli verl kullanılarak eğitildi ve matematik benchmarklarında OpenAI O1 seviyesine ulaştı (AIME'de 70.0 pass@1).</li>
  <li>[2024/12] verl, Ray Forward 2024'te sunuldu. Sunum dosyasına <a href="https://github.com/eric-haibin-lin/verl-community/blob/main/slides/Ray_Forward_2024_%E5%B7%AB%E9%94%A1%E6%96%8C.pdf">buradan</a> ulaşabilirsiniz.</li>
  <li>[2024/12] Ekip, NeurIPS 2024'te <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">Post-training LLMs: From Algorithms to Infrastructure</a> başlıklı sunumu gerçekleştirdi. <a href="https://github.com/eric-haibin-lin/verl-data/tree/neurips">Sunumlar</a> ve <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">video</a> mevcut.</li>
  <li>[2024/10] verl, Ray Summit'te sunuldu. <a href="https://www.youtube.com/watch?v=MrhMcXkXvJU&list=PLzTswPQNepXntmT8jr9WaNfqQ60QwW7-U&index=37">Youtube videosu</a> mevcut.</li>
  <li>[2024/08] HybridFlow (verl), EuroSys 2025'e kabul edildi.</li>
</ul>   
</details>

## Temel Özellikler

- Eğitim için **FSDP**, **FSDP2** ve **Megatron-LM**.
- Rollout üretimi için **vLLM**, **SGLang** ve **HF Transformers**.
- Hugging Face Transformers ve Modelscope Hub ile uyumlu: [Qwen-3](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/run_qwen3-8b.sh), Qwen-2.5, Llama3.1, Gemma2, DeepSeek-LLM vb.
- Denetimli ince ayar (supervised fine-tuning).
- [PPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/), [GRPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/), [ReMax](https://raw.githubusercontent.com/volcengine/verl/main/examples/remax_trainer/), [REINFORCE++](https://verl.readthedocs.io/en/latest/examples/config.html#algorithm), [RLOO](https://raw.githubusercontent.com/volcengine/verl/main/examples/rloo_trainer/), [PRIME](https://raw.githubusercontent.com/volcengine/verl/main/recipe/prime/), [DAPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/dapo/), [DrGRPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/drgrpo/) gibi takviyeli öğrenme algoritmaları.
  - Matematik, [kodlama](https://raw.githubusercontent.com/volcengine/verl/main/recipe/dapo/) vb. için model tabanlı ödül ve fonksiyon tabanlı ödül (doğrulanabilir ödül) desteği
  - Görüntü-dil modelleri (VLM'ler) ve [çok modlu RL](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/run_qwen2_5_vl-7b.sh) için destek (Qwen2.5-vl, Kimi-VL)
  - [Araç çağrısı ile çoklu tur](https://raw.githubusercontent.com/volcengine/verl/main/examples/sglang_multiturn/)
- [Kendi kendine oyun tercih optimizasyonu (SPPO)](https://raw.githubusercontent.com/volcengine/verl/main/recipe/sppo/) gibi LLM hizalama tarifleri
- Flash attention 2, [dizi paketleme (sequence packing)](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_qwen2-7b_seq_balance.sh), [dizi paralelliği (sequence parallelism)](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_deepseek7b_llm_sp2.sh) desteği (DeepSpeed Ulysses ile), [LoRA](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_peft.sh), [Liger-kernel](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_sp2_liger.sh)
- [Uzman paralelliği](https://github.com/volcengine/verl/pull/1467) ile 671B modele ve yüzlerce GPU'ya ölçeklenebilirlik
- Bellekten tasarruf için çoklu GPU ile [LoRA RL](https://verl.readthedocs.io/en/latest/advance/ppo_lora.html) desteği
- wandb, swanlab, mlflow ve tensorboard ile deney takibi

## Yaklaşan Özellikler ve Değişiklikler

- Yol haritası: https://github.com/volcengine/verl/issues/710
- Megatron v0.11 ile DeepSeek 671b optimizasyonları: https://github.com/volcengine/verl/issues/708
- Çoklu tur rollout ve araç kullanımı optimizasyonları: https://github.com/volcengine/verl/issues/1882
- Ortam etkileşimleri: https://github.com/volcengine/verl/issues/1172
- v0.3'ten bu yana yapılan yıkıcı değişiklikler: https://github.com/volcengine/verl/discussions/943, entropy_coeff varsayılan olarak 0
- RL için Lora: https://github.com/volcengine/verl/pull/1127 

## Başlarken

<a href="https://verl.readthedocs.io/en/latest/index.html"><b>Dokümantasyon</b></a>

**Hızlı Başlangıç:**

- [Kurulum](https://verl.readthedocs.io/en/latest/start/install.html)
- [Hızlı Başlangıç](https://verl.readthedocs.io/en/latest/start/quickstart.html)
- [Programlama Rehberi](https://verl.readthedocs.io/en/latest/hybrid_flow.html)
- [verl'de PPO](https://verl.readthedocs.io/en/latest/algo/ppo.html)
- [verl'de GRPO](https://verl.readthedocs.io/en/latest/algo/grpo.html)

**Adım adım bir PPO örneği çalıştırmak:**

- [Eğitim Sonrası için Veri Hazırlama](https://verl.readthedocs.io/en/latest/preparation/prepare_data.html)
- [Veri Seti için Ödül Fonksiyonu Uygulama](https://verl.readthedocs.io/en/latest/preparation/reward_function.html)
- [PPO Örneği Mimarisi](https://verl.readthedocs.io/en/latest/examples/ppo_code_architecture.html)
- [Yapılandırma Açıklaması](https://verl.readthedocs.io/en/latest/examples/config.html)

**Tekrarlanabilir algoritma taban çizgileri:**

- [Kodlama, matematikte RL performansı](https://verl.readthedocs.io/en/latest/algo/baseline.html)

**Kod açıklaması ve ileri seviye kullanım (genişletme) için:**

- PPO Eğitici ve Çalışanlar
  - [PPO Ray Eğitici](https://verl.readthedocs.io/en/latest/workers/ray_trainer.html)
  - [PyTorch FSDP Backend](https://verl.readthedocs.io/en/latest/workers/fsdp_workers.html)
  - [Megatron-LM Backend](https://verl.readthedocs.io/en/latest/index.html)

- İleri Düzey Kullanım ve Genişletme
  - [FSDP Backend ile Model Ekleme](https://verl.readthedocs.io/en/latest/advance/fsdp_extension.html)
  - [Megatron-LM Backend ile Model Ekleme](https://verl.readthedocs.io/en/latest/advance/megatron_extension.html)
  - [Çoklu Tur Rollout Desteği](https://verl.readthedocs.io/en/latest/sglang_multiturn/multiturn.html)
  - [Arama Aracı Entegrasyonu](https://verl.readthedocs.io/en/latest/sglang_multiturn/search_tool_example.html)
  - [Sandbox Fusion Entegrasyonu](https://verl.readthedocs.io/en/latest/examples/sandbox_fusion_example.html)
  - [Ayrı GPU Kaynakları ile Dağıtım](https://raw.githubusercontent.com/volcengine/verl/main/examples/split_placement/)
  - [Diğer RL(HF) algoritmalarına genişletme](https://verl.readthedocs.io/en/latest/advance/dpo_extension.html)
  - [Ray API tasarım eğitimi](https://verl.readthedocs.io/en/latest/advance/placement.html)

**Topluluktan Bloglar**

- [SGLang, verl, OpenBMB ve Tsinghua Üniversitesi: Uçtan Uca Çoklu Tur RLHF'de Öncülük](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/multi-turn/verl-multiturn-rollout-Release.md)
- [verl ve ROCm Entegrasyonu ile AMD GPU'larda İnsan Geri Bildirimli Takviyeli Öğrenme](https://rocm.blogs.amd.com/artificial-intelligence/verl-large-scale/README.html)
- [veMLP x verl ：Takviyeli Öğrenme Eğitiminde Ustalık](https://mp.weixin.qq.com/s/7nbqxk4knMGd-hQE9ls2tA)
- [verl ile GRPO Dağıtık Takviyeli Öğrenme En İyi Uygulamaları](https://www.volcengine.com/docs/6459/1463942)
- [HybridFlow verl Orijinal Metin Analizi](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/readme.md)
- [Maksimum 20 Kat Artış! Doubao Büyük Model Ekibi Yeni RLHF Çerçevesini Yayınladı, Şimdi Açık Kaynak!](https://team.doubao.com/en/blog/%E6%9C%80%E9%AB%98%E6%8F%90%E5%8D%8720%E5%80%8D%E5%90%9E%E5%90%90%E9%87%8F-%E8%B1%86%E5%8C%85%E5%A4%A7%E6%A8%A1%E5%9E%8B%E5%9B%A2%E9%98%9F%E5%8F%91%E5%B8%83%E5%85%A8%E6%96%B0-rlhf-%E6%A1%86%E6%9E%B6-%E7%8E%B0%E5%B7%B2%E5%BC%80%E6%BA%90)

## Performans Ayarlama Rehberi

On-policy RL algoritması için performans kritiktir. Performansı optimize etmenize yardımcı olmak için ayrıntılı bir [performans ayarlama rehberi](https://verl.readthedocs.io/en/latest/perf/perf_tuning.html) yazdık.

## vLLM >= v0.8.2'ye Yükseltme

verl, eğitim backend'i olarak FSDP kullanıldığında artık vLLM>=0.8.2'yi destekliyor. Kurulum rehberi ve daha fazla bilgi için [bu dokümana](https://raw.githubusercontent.com/volcengine/verl/main/docs/README_vllm0.8.md) bakabilirsiniz. OOM ve beklenmeyen hatalara yol açabileceği için vllm 0.7.x kullanmaktan kaçının.

## En Güncel SGLang'i Kullanın

SGLang, verl ile tamamen uyumludur ve SGLang RL Grubu çoklu tur ajan RL, VLM RLHF, sunucu tabanlı RL ve kısmi rollout gibi özellikler üzerinde yoğun şekilde çalışmaktadır. Kurulum rehberi ve daha fazla bilgi için [bu dokümana](https://verl.readthedocs.io/en/latest/workers/sglang_worker.html) bakabilirsiniz.

## FSDP2'ye Yükseltme

verl, FSDP2'yi tamamen benimsiyor! FSDP2, torch distributed ekibi tarafından önerilmekte olup daha iyi aktarım hızı ve bellek kullanımı sağlar ve diğer özelliklerle (örn. torch.compile) birlikte kullanılabilir. FSDP2'yi etkinleştirmek için, verl main'i kullanın ve aşağıdaki seçenekleri ayarlayın:
```
actor_rollout_ref.ref.strategy=fsdp2
actor_rollout_ref.actor.strategy=fsdp2
critic.strategy=fsdp2 
reward_model.strategy=fsdp2 
```
Ayrıca, FSDP2 cpu offload, gradient accumulation ile uyumludur. Bellekten tasarruf etmek için `actor_rollout_ref.actor.offload_policy=True` olarak ayarlayabilirsiniz. Daha fazla detay için: https://github.com/volcengine/verl/pull/1026

## AMD Desteği (ROCm Kernel)

verl, eğitim motoru olarak FSDP'yi (yakında Megatron desteği de gelecek) ve çıkarım motoru olarak vLLM ve SGLang entegrasyonlarını desteklemektedir. Kurulum rehberi ve daha fazla bilgi için [bu dokümana](https://raw.githubusercontent.com/volcengine/verl/main/docs/amd_tutorial/amd_build_dockerfile_page.rst) ve ROCm için vLLM performans ayarlama için [bu dokümana](https://raw.githubusercontent.com/volcengine/verl/main/docs/amd_tutorial/amd_vllm_page.rst) bakabilirsiniz.


## Atıf ve Teşekkür

Projeyi faydalı bulursanız, lütfen şu makaleleri atıf gösterin:

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

verl, Nemo-Aligner, Deepspeed-chat ve OpenRLHF tasarımından ilham alınarak geliştirilmiştir. Projeye Bytedance, Anyscale, LMSys.org, [Alibaba Qwen ekibi](https://github.com/QwenLM/), Shanghai AI Lab, Tsinghua Üniversitesi, UC Berkeley, UCLA, UIUC, Hong Kong Üniversitesi, ke.com, [All Hands AI](https://www.all-hands.dev/), [ModelBest](http://modelbest.cn/), OpenPipe, JD AI Lab, Microsoft Research, [StepFun](https://www.stepfun.com/), Amazon, Linkedin, Meituan, [Camel-AI](https://www.camel-ai.org/), [OpenManus](https://github.com/OpenManus), Xiaomi, Prime Intellect, NVIDIA research, [Baichuan](https://www.baichuan-ai.com/home), [RedNote](https://www.xiaohongshu.com/), [SwissAI](https://www.swiss-ai.org/), [Moonshot AI (Kimi)](https://www.moonshot-ai.com/), Baidu, Snowflake ve daha birçok kurum katkıda bulunmuştur.

## verl kullanan muhteşem çalışmalar

- [TinyZero](https://github.com/Jiayi-Pan/TinyZero): **DeepSeek R1 Zero** tarifinin akıl yürütme görevleri için yeniden üretimi ![GitHub Repo stars](https://img.shields.io/github/stars/Jiayi-Pan/TinyZero)
- [SkyThought](https://github.com/NovaSky-AI/SkyThought): NovaSky AI ekibi tarafından Sky-T1-7B için RL eğitimi ![GitHub Repo stars](https://img.shields.io/github/stars/NovaSky-AI/SkyThought)
- [simpleRL-reason](https://github.com/hkust-nlp/simpleRL-reason): SimpleRL-Zoo: Açık temel modellerde Sıfır Takviyeli Öğrenmeyi inceleme ve yönetme ![GitHub Repo stars](https://img.shields.io/github/stars/hkust-nlp/simpleRL-reason)
- [Easy-R1](https://github.com/hiyouga/EasyR1): **Çok modlu** RL eğitim çerçevesi ![GitHub Repo stars](https://img.shields.io/github/stars/hiyouga/EasyR1)
- [OpenManus-RL](https://github.com/OpenManus/OpenManus-RL): Birden fazla ajan ortamı için LLM ajan RL ince ayar çerçevesi ![GitHub Repo stars](https://img.shields.io/github/stars/OpenManus/OpenManus-RL)
- [rllm](https://github.com/agentica-project/rllm): [verl-pipeline](https://github.com/agentica-project/verl-pipeline) ile asenkron RL eğitimi ![GitHub Repo stars](https://img.shields.io/github/stars/agentica-project/rllm)
- [PRIME](https://github.com/PRIME-RL/PRIME): Dolaylı ödüllerle süreç takviyelendirme ![GitHub Repo stars](https://img.shields.io/github/stars/PRIME-RL/PRIME)
- [RAGEN](https://github.com/ZihanWang314/ragen): Genel amaçlı akıl yürütme **ajanı** eğitim çerçevesi ![GitHub Repo stars](https://img.shields.io/github/stars/ZihanWang314/ragen)
- [Search-R1](https://github.com/PeterGriffinJin/Search-R1): Akıl yürütme ve **arama (araç çağrısı)** iç içe geçmiş LLM'ler ile RL ![GitHub Repo stars](https://img.shields.io/github/stars/PeterGriffinJin/Search-R1)
- [DeepRetrieval](https://github.com/pat-jj/DeepRetrieval): **Arama/Araştırma Sonuçları** ile **Arama Ajanı**'nın RL Eğitimi ![GitHub Repo stars](https://img.shields.io/github/stars/pat-jj/DeepRetrieval)
- [ReSearch](https://github.com/Agent-RL/ReSearch): Takviyeli öğrenme ile LLM'lerde **Arama ile Akıl Yürütme**yi Öğrenmek ![GitHub Repo stars](https://img.shields.io/github/stars/Agent-RL/ReSearch)
- [Code-R1](https://github.com/ganler/code-r1): **Kod** için R1'in güvenilir ödüllerle yeniden üretimi ![GitHub Repo stars](https://img.shields.io/github/stars/ganler/code-r1)
- [Skywork-OR1](https://github.com/SkyworkAI/Skywork-OR1): Skywork açık akıl yürütücü serisi ![GitHub Repo stars](https://img.shields.io/github/stars/SkyworkAI/Skywork-OR1)
- [ToRL](https://github.com/GAIR-NLP/ToRL): Araç entegre RL ölçeklendirme ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/ToRL)
- [verl-agent](https://github.com/langfengQ/verl-agent): **Uzun ufuklu LLM/VLM ajanları** için ölçeklenebilir eğitim çerçevesi ve yeni algoritma **GiGPO** ![GitHub Repo stars](https://img.shields.io/github/stars/langfengQ/verl-agent)
- [PF-PPO](https://arxiv.org/abs/2409.06957): Daha verimli ve sağlam RLHF için ödül sinyallerinin güvenilirliğine dayalı PPO için Politika Filtrasyonu.
- [GUI-R1](https://github.com/ritzz-ai/GUI-R1): **GUI-R1**: **GUI Ajanları** için Genelci R1 tarzı Görsel-Dil Eylem Modeli ![GitHub Repo stars](https://img.shields.io/github/stars/ritzz-ai/GUI-R1)
- [DeepResearcher](https://github.com/GAIR-NLP/DeepResearcher): Gerçek dünya ortamlarında takviyeli öğrenme ile derin araştırmayı ölçeklendirme ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/DeepResearcher)
- [VAGEN](https://github.com/RAGEN-AI/VAGEN): Çoklu tur takviyeli öğrenme ile VLM ajanları eğitimi ![GitHub Repo stars](https://img.shields.io/github/stars/RAGEN-AI/VAGEN)
- [ReTool](https://retool-rl.github.io/): LLM'lerde stratejik araç kullanımı için takviyeli öğrenme. Kod yakında yayınlanacak...
- [RM-R1](https://arxiv.org/abs/2505.02387): Akıl yürütme ödül modellerinin RL ile eğitimi ![GitHub Repo stars](https://img.shields.io/github/stars/RM-R1-UIUC/RM-R1)
- [Absolute Zero Reasoner](https://arxiv.org/abs/2505.03335): Akıl yürütme için insan tarafından hazırlanmış veri gerektirmeyen kendi kendine oyun çerçevesi ![GitHub Repo stars](https://img.shields.io/github/stars/LeapLabTHU/Absolute-Zero-Reasoner)
- [LUFFY](https://arxiv.org/pdf/2504.14945): Politikaları politika dışı rehberlikle öğrenmek ![GitHub Repo stars](https://img.shields.io/github/stars/ElliottYan/LUFFY)
- [verl-tool](https://github.com/TIGER-AI-Lab/verl-tool): verl tabanlı birleşik ve kolay genişletilebilir bir araç-ajan eğitim çerçevesi ![GitHub Repo stars](https://img.shields.io/github/stars/TIGER-AI-Lab/verl-tool)
- [DeepMath](https://github.com/zwhe99/DeepMath): Matematiksel akıl yürütme için DeepMath-103K veri seti ve model serisi ![GitHub Repo stars](https://img.shields.io/github/stars/zwhe99/DeepMath)

ve daha fazlası [recipe](https://raw.githubusercontent.com/volcengine/verl/main/recipe/README.md) dizininde listelenmiştir.
## Katkı Rehberi

Topluluktan katkılar memnuniyetle karşılanır! [Proje yol haritasını](https://github.com/volcengine/verl/issues/710) ve [iyi ilk sorunlar](https://github.com/volcengine/verl/issues?q=is%3Aissue%20state%3Aopen%20label%3A%22good%20first%20issue%22) listesini inceleyerek katkıda bulunabileceğiniz alanları görebilirsiniz.

### Kod Lint ve Biçimlendirme

Kod kalitesini artırmak için pre-commit kullanıyoruz. Pre-commit'i başlatmak için:

```bash
pip install pre-commit
pre-commit install
```

CI hatalarını yerelde çözmek için pre-commit'i manuel olarak çalıştırabilirsiniz:

```bash
pre-commit run
```

### CI Testleri Ekleme

Mümkünse, yeni özelliğiniz için CI testi ekleyin:

1. En ilgili workflow yml dosyasını bulun, genellikle bir `hydra` varsayılan yapılandırmasına karşılık gelir (örn. `ppo_trainer`, `ppo_megatron_trainer`, `sft_trainer` vb).
2. Henüz eklenmemişse ilgili yol desenlerini `paths` bölümüne ekleyin.
3. Test betiklerinin iş yükünü minimuma indirin (örnekler için mevcut betiklere bakın).

## [ByteDance Seed Ekibi](https://team.doubao.com/) Hakkında

2023 yılında kurulan ByteDance Seed Ekibi, sektördeki en ileri AI temel modellerini geliştirmeye kendini adamıştır. Ekip, dünya çapında bir araştırma ekibi olmayı ve bilime ve topluma önemli katkılar sağlamayı hedeflemektedir. Bytedance Seed hakkında daha fazla bilgi için aşağıdaki kanalları ziyaret edebilirsiniz👇
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

İŞE ALIM YAPIYORUZ! RL ile ajanlar konusunda staj/FTE fırsatlarıyla ilgileniyorsanız bize bir [e-posta](mailto:haibin.lin@bytedance.com) gönderin.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---