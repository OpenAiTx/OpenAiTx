<center>
  <h1>ChinaTravel: Tolok Ukur Dunia Nyata untuk Agen Bahasa dalam Perencanaan Perjalanan di Tiongkok
</h1>
</center>

Repositori kode resmi untuk makalah "ChinaTravel: Tolok Ukur Dunia Nyata untuk Agen Bahasa dalam Perencanaan Perjalanan di Tiongkok".

<!-- | [Webpage](https://www.lamda.nju.edu.cn/shaojj/chinatravel/) | [Paper](https://arxiv.org/abs/2412.13682) | [Dataset(Huggingface)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)| -->

[![Webpage](https://img.shields.io/badge/Webpage-Visit-blue)](https://www.lamda.nju.edu.cn/shaojj/chinatravel/)
[![Paper](https://img.shields.io/badge/Paper-View-red)](https://arxiv.org/abs/2412.13682)
[![Dataset(Huggingface)](https://img.shields.io/badge/Dataset-Huggingface-yellow)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)
[![Competition(TPC@IJCAI2025)](https://img.shields.io/badge/IJCAI%20Competition-TPC@IJCAI2025-green)](https://chinatravel-competition.github.io/IJCAI2025/)
[![Competition(TPC@AIC2025)](https://img.shields.io/badge/AIC%20Competition-TPC@AIC2025-green)](TPC@AIC2025/readme.md)


<!-- 
![Overview](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/images/overview.png) -->

## 🏆 Tantangan Perencanaan Perjalanan IJCAI 2025 (TPC@IJCAI)

Kami dengan bangga mengumumkan bahwa ChinaTravel telah terpilih sebagai tolok ukur resmi untuk **Travel Planning Challenge (TPC) @ IJCAI 2025**!

**Situs Kompetisi Resmi**:
[https://chinatravel-competition.github.io/IJCAI2025/](https://chinatravel-competition.github.io/IJCAI2025/)

Peserta diundang untuk mengembangkan agen baru yang dapat menangani skenario perencanaan perjalanan dunia nyata di bawah berbagai kendala kompleks. Kompetisi ini akan menampilkan pendekatan mutakhir dalam riset agen bahasa.

## 📝 ChangeLog

### 2025.09
1. Unggah solusi juara untuk track DSL TPC@IJCAI2025. Terima kasih kepada [@evergreenee](https://github.com/evergreenee) atas kontribusinya.  


### 2025.06

1. Memperbaiki pengumpulan error pada kode evaluasi commonsense. 
2. Memperbaiki pipeline agen pure-neuro
3. Memperbaiki load_datasets dari huggingface
4. Memperbarui penanganan exception pada verifikasi sintaks


### 2025.05

1. Catatan pembaruan untuk versi terbaru.
2. Menyediakan kode evaluasi untuk TPC.

### 2025.04

1. Menambahkan pemuat data lokal. Pengguna sekarang dapat memuat kueri kustom secara lokal. Saat menentukan nilai splits_name selain default (misal, "abc") untuk "run_exp.py", sistem secara otomatis akan memuat file terkait dari evaluation/default_splits/abc.txt, di mana file TXT berisi nama file kueri target.
2. Klasifikasi batasan secara detail. Lihat dokumentasi detail di [Evaluation README](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)
3. Memperkenalkan baseline LLM-modulo
   Mengimplementasikan pipeline LLM-modulo dengan verifier simbolik ground-truth.
   Berdasarkan metodologi dari:
   Paper: Robust Planning with Compound LLM Architectures: An LLM-Modulo Approach
   Codebase: https://github.com/Atharva-Gundawar/LLM-Modulo-prompts
4. Mendukung inferensi LLM lokal dengan Qwen3-8B/4B.

## 🚀 Mulai Cepat

### ⚙️ Pengaturan

1. Buat lingkungan conda dan instal dependensi:

```bash
conda create -n chinatravel python=3.9  
conda activate chinatravel  
pip install -r requirements.txt  
```

2. Unduh basis data dan ekstrak ke direktori "chinatravel/environment/"

Tautan Unduhan: [Google Drive](https://drive.google.com/drive/folders/1bJ7jA5cfExO_NKxKfi9qgcxEbkYeSdAU), [NJU Drive](https://box.nju.edu.cn/d/dd83e5a4a9e242ed8eb4/)

3. Unduh LLM open-source (opsional).

```bash
bash download_llm.sh
```

4. Unduh tokenizer.

```bash
wget https://cdn.deepseek.com/api-docs/deepseek_v3_tokenizer.zip -P chinatravel/local_llm/
unzip chinatravel/local_llm/deepseek_v3_tokenizer.zip -d chinatravel/local_llm/
```

### ▶️ Menjalankan

Kami mendukung deepseek (API resmi dari deepseek), gpt-4o (chatgpt-4o-latest), glm4-plus, dan inferensi lokal dengan Qwen (Qwen3-8B), llama, mistral (Mistral-7B-Instruct-v0.3), dll.

```bash
export OPENAI_API_KEY=""

python run_exp.py --splits easy --agent LLMNeSy --llm deepseek --oracle_translation
python run_exp.py --splits medium --agent LLMNeSy --llm deepseek --oracle_translation
python run_exp.py --splits human --agent LLMNeSy --llm deepseek --oracle_translation

python run_exp.py --splits human --agent LLMNeSy --llm Qwen3-8B --oracle_translation


python run_exp.py --splits human --agent LLMNeSy --llm deepseek 
python run_exp.py --splits human --agent LLMNeSy --llm Qwen3-8B 


python run_exp.py --splits human --agent LLM-modulo --llm deepseek --refine_steps 10 --oracle_translation
python run_exp.py --splits human --agent LLM-modulo --llm Qwen3-8B --refine_steps 10 --oracle_translation
```

**Catatan**:

- Flag `--oracle_translation` mengaktifkan akses ke ground truth beranotasi termasuk:

  - `hard_logic_py`: Kode DSL verifikasi yang dapat dieksekusi
  - `hard_logic_nl`: Deskripsi kendala yang bersesuaian
  - Contoh struktur anotasi:

  ```python
  {
    "hard_logic_py": [
      "
      total_cost=0 
      for activity in allactivities(plan):
          total_cost+=activity_cost(activity)
              total_cost += innercity_transport_cost(activity_transports(activity))
      result=(total_cost<=1000)
      ", 
      "
      innercity_transport_set=set()
      for activity in allactivities(plan):
          if activity_transports(activity)!=[]:              
              innercity_transport_set.add(innercity_transport_type(activity_transports(activity)))
      result=(innercity_transport_set<={'taxi'})
      "
    ], 
    "hard_logic_nl": ["总预算为1800元", "市内交通选择taxi"], 
  }
  ```
- Metode LLM-modulo **memerlukan** mode oracle_translation untuk proses penyempurnaan simboliknya

### 📊 Evaluasi

```bash
python eval_exp.py --splits human --method LLMNeSy_deepseek_oracletranslation
python eval_exp.py --splits human --method LLMNeSy_deepseek
python eval_exp.py --splits human --method LLM-modulo_deepseek_10steps_oracletranslation
python eval_exp.py --splits human --method LLM-modulo_Qwen3-8B_10steps_oracletranslation

```

Dalam TPC@IJCAI2025, kode evaluasi tersedia di file `eval_tpc.py`. Anda dapat menjalankan kode evaluasi sebagai berikut:

```bash
python eval_tpc.py --splits tpc_phase1 --method YOUR_METHOD_NAME
```

## 📚 Dokumentasi

[Lingkungan](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/environment/readme.md)
[Kendala](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)

## 🛠️ Pengembangan Lanjutan

### 1. Kembangkan Algoritma Agen Anda Sendiri

Untuk mengembangkan algoritma agen Anda sendiri, Anda perlu mewarisi kelas `BaseAgent` dari `chinatravel/agent/base.py` dan menambahkan logika algoritma Anda ke fungsi `init_agent` di `chinatravel/agent/load_model.py`. Kami menyediakan contoh agen kosong bernama `TPCAgent`.

Langkah-langkah:

- **Mewarisi kelas `BaseAgent`**: Buat file Python baru di direktori `chinatravel/agent` dan definisikan kelas agen Anda sendiri dengan mewarisi dari `BaseAgent`.

```python:chinatravel/agent/your_agent.py
from .base import BaseAgent

class YourAgent(BaseAgent):
    def __init__(self, **kwargs):
        super().__init__(**kwargs)
        # Initialization logic

    def act(self, observation):
        # Implement the decision - making logic of the agent
        pass
```

- **Tambahkan kode ke fungsi init_agent**: Buka file chinatravel/agent/load_model.py dan tambahkan dukungan untuk agen baru Anda di fungsi init_agent.

```python:
def init_agent(kwargs):
    # ... existing code ...
    elif kwargs["method"] == "YourMethodName":
        agent = YourAgent(
            **kwargs
        )
    # ... existing code ...
    return agent
```

### 2. Kembangkan LLM Lokal Anda Sendiri

Untuk mengembangkan model bahasa berskala besar (LLM) lokal Anda sendiri, Anda perlu mewarisi kelas AbstractLLM dari chinatravel/agent/llms.py dan menambahkan kode inferensi LLM lokal yang sesuai di llms.py. Kami menyediakan contoh LLM kosong bernama TPCLLM.
Langkah-langkah:

- **Mewarisi kelas AbstractLLM**: Definisikan kelas LLM Anda sendiri di file chinatravel/agent/llms.py, dengan mewarisi dari AbstractLLM.

```python
class YourLLM(AbstractLLM):
    def __init__(self):
        super().__init__()
        # Initialization logic
        self.name = "YourLLMName"

    def _get_response(self, messages, one_line, json_mode):
        # Implement the response logic of the LLM
        response = "Your LLM response"
        if json_mode:
            # Handle JSON mode
            pass
        elif one_line:
            # Handle one - line mode
            response = response.split("\n")[0]
        return response
```

- **Tambahkan kode ke fungsi init_agent**: Buka file chinatravel/agent/load_model.py dan tambahkan dukungan untuk llm baru Anda di fungsi init_llm.

```python:
def init_llm(kwargs):
    # ... existing code ...
    elif llm_name == "glm4-plus":
        llm = YourLLM()
    # ... existing code ...
    return llm
```

### 3. Jalankan Kode Anda Menggunakan Skrip Eksperimen

Setelah menyelesaikan pengembangan di atas, Anda dapat menggunakan skrip eksperimen untuk menjalankan kode Anda.

Contoh menjalankan:

```bash
python run_tpc.py --splits easy --agent TPCAgent --llm TPCLLM
python run_exp.py --splits easy --agent YourMethodName --llm YourLLMName
```

Hasilnya akan disimpan di direktori `results/NamaMetodeAnda_NamaLLMAnda_xxx`, misalnya, `results/TPCAgent_TPCLLM`.

## ✉️ Kontak

Jika Anda memiliki masalah, silakan hubungi [Jie-Jing Shao](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/shaojj@lamda.nju.edu.cn), [Bo-Wen Zhang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/221900200@smail.nju.edu.cn), [Xiao-Wen Yang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/yangxw@lamda.nju.edu.cn).

## 📌 Sitasi

Jika makalah atau sumber daya terkait kami terbukti bermanfaat untuk penelitian Anda, kami mohon untuk dicantumkan sebagai sitasi.

```
@misc{shao2024chinatravelrealworldbenchmarklanguage,
      title={ChinaTravel: A Real-World Benchmark for Language Agents in Chinese Travel Planning}, 
      author={Jie-Jing Shao and Xiao-Wen Yang and Bo-Wen Zhang and Baizhi Chen and Wen-Da Wei and Guohao Cai and Zhenhua Dong and Lan-Zhe Guo and Yu-feng Li},
      year={2024},
      eprint={2412.13682},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2412.13682}, 
}
```
[English](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=th) | [Français](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=de) | [Español](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=it) | [Русский](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ru) | [Português](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=as)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-13

---