## MCP-Zero: Otonom LLM Ajanları için Aktif Araç Keşfi

<div style="display: flex; align-items: center; gap: 10px; margin-bottom: 10px;">
  <!-- <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/robot.png" alt="MCP-Zero Robot" width="24" height="24"> -->
  <a href="https://arxiv.org/abs/2506.01056">
    <img src="https://img.shields.io/badge/Paper-arXiv-red">
  </a>
  <a href="https://arxiv.org/abs/2506.01056">
    https://arxiv.org/abs/2506.01056
  </a>
</div>


MCP-Zero'ya gösterdiğiniz ilgi için teşekkürler! 🤗

Makaledeki ilgili kodları artık açık kaynak olarak yayınladık. Çalışmamızı güncellemeye, endüstrideki uygulamalarını keşfetmeye ve bu projeyi genişletmeye devam edeceğiz.


<div align="center">
  <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/fig1.png" alt="MCP-Zero workflow">
  <p> MCP-Zero kullanarak "Harika bir yemek yapmak" için araç zincirlerini proaktif olarak oluşturma </p>
</div>


### Yöntem: MCP-Zero

```
MCP-zero/
├── experiment_apibank.py       # deneyler: APIBank
├── experiment_mcptools.py      # deneyler: mcp_tools (needle testi)
├── matcher.py                  # benzerlik eşleştirme kodu
├── prompt_guide/               # yöntemimiz için istemler
├── reformatter.py              # araç açıklaması için json formatlayıcı
├── sampler.py                  # hedef aracı seçmek için örnekleyici
├── test_cases.jsonl            # eşleştirici için test vakası
├── test_matcher.py             # eşleştirici için birim testi
└── utils.py                    # yardımcılar: grid_search
```

Makaledeki kodumuzu artık yayınladık. Makaledeki kod, alma yeteneklerini uygular ve deneylerde somut sonuçlar elde eder.

Gelecekteki çalışmalarımızda MCP-zero'yu endüstride uygulamaya kararlıyız; bu nedenle, MCP sunucularının dinamik dağıtımı, GAIA testi için ortam kurulumu vb. gibi diğer modüllerin de dahil edilmesi gerekmektedir. Çalışmamızı geliştirmeye devam edeceğiz ve bu çalışmaya gösterdiğiniz ilgi için teşekkür ederiz. Güncel kaldığınızı bana bildirmek için bir yıldız bırakın🌟 :D



### Veri Kümesi: MCP-tools

- **Google Drive**: [İndirme Linki](https://drive.google.com/file/d/1RjBGU-AGdHdhUABoeYSztbfQlD0hjUBn/view?usp=sharing)
- **Huggingface Linki**: Yakında
- **Dosyayı şuraya koyun**: `./MCP-tools/mcp_tools_with_embedding.json`


**Tanıtım**: MCP resmi deposundan filtrelenmiş tüm araçları içeren bir veri kümesi (toplam 308 sunucu ve 2.797 araç).

**Veri yapısı**:
```
{
  "server_name": string, // MCP sunucusunun adı, README'den çıkarılmış veya türetilmiş
  "server_summary": string, // Sunucunun amacı ve yeteneklerinin özeti, README'nin ilgili tüm bölümlerine dayanarak.
  "server_description": string, // Metadata'dan açıklama.
  "description_embedding": float[3072], // Sunucu açıklamasının text-embedding-3-large ile embedding'i
  "summary_embedding": float[3072], // Sunucu özetinin text-embedding-3-large ile embedding'i
  "tools": [
    {
      "name": string, // Fonksiyon/araç adı
      "description": string, // Aracın ne yaptığına dair kısa açıklama
      "description_embedding": float[3072], // Araç açıklamasının text-embedding-3-large ile embedding'i
      "parameter": { // Girdi parametrelerinin sözlüğü, açıkça tanımlanmışsa dahil edilir
        "param1": "(tip) açıklama1",
        "param2": "(Opsiyonel, tip) açıklama2"
      }
    }
  ]
}
```

**Kendi veri kümenizi oluşturun**: MCP sunucuları için özel veri kümesi oluşturmak isterseniz, `MCP-tools/build_data` klasörü altındaki kodları takip edebilirsiniz.

```
MCP-tools/
├── build_data
│   ├── get_server_summary.py       # MCP sunucusunun ReadMe dosyasından yapısal veri çıkarmak için kod
│   ├── run_vllm.sh                 # Qwen2.5-72B-Instruct modelini VLLM ile dağıtma
│   └── server_summary.prompt       # Veri kümesi çıkarmak için istem
└── download_data.md
```


### Atıf

> Atıf beni mutlu eder.
> 
>   --Shakespeare
>   ~~(sadece eğlence amaçlı :D)~~

```bibtex
@article{fei2025mcp,
  title={MCP-Zero: Active Tool Discovery for Autonomous LLM Agents},
  author={Fei, Xiang ve Zheng, Xiawu ve Feng, Hao},
  journal={arXiv preprint arXiv:2506.01056},
```
  yıl={2025}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-06

---