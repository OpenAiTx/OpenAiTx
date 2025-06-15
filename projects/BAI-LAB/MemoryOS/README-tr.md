# MemoryOS
<div align="center">
  <img src="https://raw.githubusercontent.com/BAI-LAB/MemoryOS/main/logo_1.png" alt="logo" width="400"/>
</div>
<p align="center">
  <a href="https://arxiv.org/abs/2506.06326">
    <img src="https://img.shields.io/badge/Arxiv-paper-red" alt="Mem0 Discord">
  </a>
  <a href="https://github.com/user-attachments/assets/d195e740-1249-4eb1-962a-2c0d99a38c39">
    <img src="https://img.shields.io/badge/Wechat-群二维码-green" alt="Mem0 PyPI - Downloads">
  </a>
  <a href="https://youtu.be/y9Igs0FnX_M" target="blank">
    <img src="https://img.shields.io/badge/Demo-Video-red" alt="Npm package">
  </a>
    <a href="https://www.apache.org/licenses/LICENSE-2.0" target="_blank">
    <img src="https://img.shields.io/badge/License-Apache_2.0-blue" alt="License: Apache 2.0">
  </a>
</p>

<h5 align="center"> 🎉 Eğer projemizi beğendiyseniz, lütfen en son güncellemeler için GitHub’da bize yıldız ⭐ verin.</h5>
**MemoryOS**, kişiselleştirilmiş AI ajanları için bir bellek işletim sistemi sağlamak üzere tasarlanmıştır ve daha tutarlı, kişiselleştirilmiş ve bağlama duyarlı etkileşimler sağlar. İşletim sistemlerindeki bellek yönetimi ilkelerinden ilham alarak, Dört çekirdek modülden oluşan (Depolama, Güncelleme, Getirme ve Üretim) hiyerarşik bir depolama mimarisi benimser ve kapsamlı ve verimli bir bellek yönetimi sağlar. LoCoMo benchmark’ında, model F1 ve BLEU-1 skorlarında sırasıyla **%49,11** ve **%46,18**’lik ortalama iyileşme sağlamıştır.

## 📣 Son Haberler
*   *<mark>[yeni]</mark>* 🔥  **[2025-06-15]**:🛠️ Açık kaynaklı **MemoryOS-MCP** yayınlandı! Ajan istemcilerinde sorunsuz entegrasyon ve özelleştirme için şimdi yapılandırılabilir. [👉 Görüntüle](#memoryos_mcp-getting-started)
*   **[2025-05-30]**: **MemoryOS**’un ilk sürümü yayınlandı! Otomatik kullanıcı profili ve bilgi güncellemesi ile kısa, orta ve uzun vadeli persona Belleği sunar.

## Demo
[![Videoyu izle](https://img.youtube.com/vi/y9Igs0FnX_M/maxresdefault.jpg)](https://youtu.be/y9Igs0FnX_M)

## 	Sistem Mimarisi
![image](https://github.com/user-attachments/assets/09200494-03a9-4b7d-9ffa-ef646d9d51f0)

## Proje Yapısı

```
memoryos/
├── __init__.py            # MemoryOS paketini başlatır
├── __pycache__/           # Python önbellek dizini (otomatik üretilir)
├── long_term.py           # Uzun vadeli persona belleğini yönetir (kullanıcı profili, bilgi)
├── memoryos.py            # MemoryOS için ana sınıf, tüm bileşenleri organize eder
├── mid_term.py            # Orta vadeli belleği yönetir, kısa vadeli etkileşimleri birleştirir
├── prompts.py             # LLM etkileşimlerinde (özetleme, analiz vb.) kullanılan istemleri içerir
├── retriever.py           # Tüm bellek katmanlarından ilgili bilgileri getirir
├── short_term.py          # Son etkileşimler için kısa vadeli belleği yönetir
├── updater.py             # Bellek güncellemelerini işler, katmanlar arası bilgi terfisi dahil
└── utils.py               # Kütüphane genelinde kullanılan yardımcı fonksiyonlar
```

## Nasıl Çalışır?

1.  **Başlatma:** `Memoryos` kullanıcı ve asistan kimlikleri, API anahtarları, veri depolama yolları ve çeşitli kapasite/eşik ayarları ile başlatılır. Her kullanıcı ve asistan için özel depolama alanı kurar.
2.  **Bellek Ekleme:** Kullanıcı girişleri ve ajan yanıtları Soru-Cevap çiftleri olarak eklenir. Bunlar ilk olarak kısa vadeli bellekte saklanır.
3.  **Kısa Vadeli’den Orta Vadeli’ye İşleme:** Kısa vadeli bellek dolduğunda, `Updater` modülü bu etkileşimleri işler, anlamlı segmentlere dönüştürür ve orta vadeli belleğe kaydeder.
4.  **Orta Vadeli Analiz & LPM Güncellemeleri:** Orta vadeli bellek segmentleri, ziyaret sıklığı ve etkileşim uzunluğu gibi faktörlere bağlı olarak "ısınır". Bir segmentin ısısı eşiği aştığında, içeriği analiz edilir:
    *   Kullanıcı profili içgörüleri çıkarılır ve uzun vadeli kullanıcı profili güncellenir.
    *   Spesifik kullanıcı bilgileri, kullanıcının uzun vadeli bilgisine eklenir.
    *   Asistan için ilgili bilgiler, asistanın uzun vadeli bilgi tabanına eklenir.
5.  **Yanıt Üretimi:** Bir kullanıcı sorgusu alındığında:
    *   `Retriever` modülü, kısa vadeli geçmiş, orta vadeli bellek segmentleri, kullanıcının profili & bilgisi ve asistan bilgi tabanından ilgili bağlamı getirir.
    *   Bu kapsamlı bağlam, kullanıcının sorgusu ile birlikte, LLM aracılığıyla tutarlı ve bilgilendirici bir yanıt üretmek için kullanılır.

## MemoryOS_PYPI Başlarken

### Önkoşullar

*   Python >= 3.10
*   pip install -i https://pypi.org/simple/ MemoryOS-BaiJia

### Kurulum

```bash
conda create -n MemoryOS python=3.10
conda activate MemoryOS
pip install -i https://pypi.org/simple/ MemoryOS-BaiJia
```

### Temel Kullanım

```python

import os
from memoryos import Memoryos

# --- Temel Yapılandırma ---
USER_ID = "demo_user"
ASSISTANT_ID = "demo_assistant"
API_KEY = "YOUR_OPENAI_API_KEY"  # Anahtarınızı buraya girin
BASE_URL = ""  # Opsiyonel: özel bir OpenAI uç noktası kullanıyorsanız
DATA_STORAGE_PATH = "./simple_demo_data"
LLM_MODEL = "gpt-4o-mini"

def simple_demo():
    print("MemoryOS Basit Demo")
    
    # 1. MemoryOS'u başlat
    print("MemoryOS başlatılıyor...")
    try:
        memo = Memoryos(
            user_id=USER_ID,
            openai_api_key=API_KEY,
            openai_base_url=BASE_URL,
            data_storage_path=DATA_STORAGE_PATH,
            llm_model=LLM_MODEL,
            assistant_id=ASSISTANT_ID,
            short_term_capacity=7,  
            mid_term_heat_threshold=5,  
            retrieval_queue_capacity=7,
            long_term_knowledge_capacity=100
        )
        print("MemoryOS başarıyla başlatıldı!\n")
    except Exception as e:
        print(f"Hata: {e}")
        return

    # 2. Bazı temel bellekleri ekleyin
    print("Bazı bellekler ekleniyor...")
    
    memo.add_memory(
        user_input="Merhaba! Ben Tom, San Francisco'da veri bilimci olarak çalışıyorum.",
        agent_response="Merhaba Tom! Tanıştığımıza memnun oldum. Veri bilimi çok heyecan verici bir alan. Ne tür verilerle çalışıyorsun?"
    )
     
    test_query = "İşim hakkında ne hatırlıyorsun?"
    print(f"Kullanıcı: {test_query}")
    
    response = memo.get_response(
        query=test_query,
    )
    
    print(f"Asistan: {response}")

if __name__ == "__main__":
    simple_demo()
```
## MemoryOS-MCP Başlarken
### 🔧 Temel Araçlar

#### 1. `add_memory`
Kullanıcı ile AI asistanı arasındaki konuşmanın içeriğini, kalıcı bir diyalog geçmişi ve bağlamsal kayıt oluşturmak amacıyla bellek sistemine kaydeder.

#### 2. `retrieve_memory`
Bir sorguya göre bellek sisteminden ilgili geçmiş diyalogları, kullanıcı tercihlerini ve bilgi verilerini getirir ve AI asistanının kullanıcının ihtiyaçlarını ve geçmişini anlamasına yardımcı olur.

#### 3. `get_user_profile`
Geçmiş diyalogların analizinden elde edilen, kullanıcının kişilik özellikleri, ilgi tercihleri ve ilgili bilgi geçmişini içeren bir kullanıcı profili elde eder.


### 1. Bağımlılıkları yükleyin
```bash
cd memoryos-mcp
pip install -r requirements.txt
```
### 2. Yapılandırma

`config.json` dosyasını düzenleyin：
```json
{
  "user_id": "kullanıcı ID’niz",
  "openai_api_key": "OpenAI API anahtarınız",
  "openai_base_url": "https://api.openai.com/v1",
  "data_storage_path": "./memoryos_data",
  "assistant_id": "assistant_id",
  "llm_model": "gpt-4o-mini"
}
```
### 3. Sunucuyu başlatın
```bash
python server_new.py --config config.json
```
### 4. Test edin
```bash
python test_comprehensive.py
```
### 5. Cline ve diğer istemcilerde yapılandırın
mcp.json dosyasını kopyalayın ve dosya yolunun doğru olduğundan emin olun.
```bash
command": "/root/miniconda3/envs/memos/bin/python"
#Bunu sanal ortamınızın Python yorumlayıcısına göre değiştirmelisiniz
```
## Katkıda Bulunma

Katkılar memnuniyetle karşılanır! Lütfen sorun veya pull request göndermekten çekinmeyin.

## Atıf
Daha fazla detay okumak isterseniz, lütfen buraya tıklayın: [Tam Makaleyi Oku](https://arxiv.org/abs/2506.06326)

Bu projeyi faydalı bulursanız, lütfen makalemizi atıf olarak kullanmayı düşünün:

```bibtex
@misc{kang2025memoryosaiagent,
      title={Memory OS of AI Agent}, 
      author={Jiazheng Kang and Mingming Ji and Zhe Zhao and Ting Bai},
      year={2025},
      eprint={2506.06326},
```
## Bize Ulaşın
BaiJiaAI, Beijing Posta ve Telekomünikasyon Üniversitesi'nden Doç. Dr. Bai Ting'in rehberliğinde yürütülen bir araştırma grubudur ve silikon tabanlı insanlar için duygusal olarak zengin ve olağanüstü hafızaya sahip beyinler geliştirmeye kendini adamıştır.<br>
İş birliği ve öneriler için: baiting@bupt.edu.cn<br>
BaiJiaAgent WeChat resmi hesabını ve WeChat grubumuzu takip etmeye davetlisiniz, birlikte iletişimde olalım!  
<div style="display: flex; justify-content: center; gap: 20px;">
  <img src="https://github.com/user-attachments/assets/42651f49-f1f7-444d-9455-718e13ed75e9" alt="百家Agent公众号" width="250"/>
  <img src="https://github.com/user-attachments/assets/6b15a873-9e9a-44ee-b0b3-64f488fbd5d8" alt="微信群二维码" width="300"/>
</div>
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---