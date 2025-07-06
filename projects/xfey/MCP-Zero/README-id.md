## MCP-Zero: Penemuan Alat Aktif untuk Agen LLM Otonom

<div style="display: flex; align-items: center; gap: 10px; margin-bottom: 10px;">
  <!-- <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/robot.png" alt="MCP-Zero Robot" width="24" height="24"> -->
  <a href="https://arxiv.org/abs/2506.01056">
    <img src="https://img.shields.io/badge/Paper-arXiv-red">
  </a>
  <a href="https://arxiv.org/abs/2506.01056">
    https://arxiv.org/abs/2506.01056
  </a>
</div>


Terima kasih atas perhatian Anda pada MCP-Zero! 🤗

Kami sekarang telah membuka kode sumber yang terlibat dalam makalah ini. Kami akan terus memperbarui pekerjaan kami, mengeksplorasi penerapannya di industri, dan terus mengembangkan proyek ini.


<div align="center">
  <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/fig1.png" alt="MCP-Zero workflow">
  <p> Menggunakan MCP-Zero untuk secara proaktif membangun toolchain untuk "Membuat hidangan yang luar biasa"</p>
</div>


### Metode: MCP-Zero

```
MCP-zero/
├── experiment_apibank.py       # eksperimen: APIBank
├── experiment_mcptools.py      # eksperimen: mcp_tools (needle test)
├── matcher.py                  # kode untuk pencocokan kemiripan
├── prompt_guide/               # prompt untuk metode kami
├── reformatter.py              # json formatter untuk deskripsi alat
├── sampler.py                  # sampler untuk memilih alat target
├── test_cases.jsonl            # testcase untuk matcher
├── test_matcher.py             # unit test untuk matcher
└── utils.py                    # utils: grid_search
```

Kami sekarang telah merilis kode untuk makalah ini. Kode dalam makalah ini mengimplementasikan kemampuan retrieval dan mencapai hasil konkret dalam eksperimen.

Dalam pekerjaan kami selanjutnya, kami berkomitmen untuk menerapkan MCP-zero ke industri, sehingga modul-modul lain masih perlu dilibatkan, seperti deployment dinamis server MCP, deployment environment untuk pengujian GAIA, dll. Kami akan terus meningkatkan pekerjaan kami, dan terima kasih atas perhatian Anda terhadap pekerjaan ini. Tinggalkan bintang🌟 untuk memberi tahu saya bahwa Anda tetap mengikuti perkembangan :D



### Dataset: MCP-tools

- **Google Drive**: [Tautan Unduhan](https://drive.google.com/file/d/1RjBGU-AGdHdhUABoeYSztbfQlD0hjUBn/view?usp=sharing)
- **Huggingface Link**: Segera hadir
- **Letakkan file di**: `./MCP-tools/mcp_tools_with_embedding.json`


**Pengantar**: Dataset yang berisi semua alat yang telah difilter (total 308 server dan 2.797 alat) dari repo resmi MCP.

**Struktur data**:
```
{
  "server_name": string, // Nama server MCP, diekstrak atau disimpulkan dari README
  "server_summary": string, // Ringkasan tujuan dan kapabilitas server, berdasarkan semua bagian relevan dari README.
  "server_description": string, // Deskripsi dari metadata.
  "description_embedding": float[3072], // Embedding dari deskripsi server dari text-embedding-3-large
  "summary_embedding": float[3072], // Embedding dari ringkasan server dari text-embedding-3-large
  "tools": [
    {
      "name": string, // Nama fungsi/alat
      "description": string, // Deskripsi singkat tentang apa yang dilakukan alat ini
      "description_embedding": float[3072], // Embedding dari deskripsi alat dari text-embedding-3-large
      "parameter": { // Dictionary parameter input, disertakan jika didefinisikan secara eksplisit
        "param1": "(type) deskripsi1",
        "param2": "(Optional, type) deskripsi2"
      }
    }
  ]
}
```

**Bangun dataset sendiri**: Jika Anda ingin membangun dataset kustom untuk server MCP, Anda dapat mengikuti kode di folder `MCP-tools/build_data`.

```
MCP-tools/
├── build_data
│   ├── get_server_summary.py       # kode untuk mengekstrak data terstruktur dari file ReadMe server MCP
│   ├── run_vllm.sh                 # deploy model Qwen2.5-72B-Instruct dengan VLLM
│   └── server_summary.prompt       # prompt untuk ekstraksi dataset
└── download_data.md
```


### Sitasi

> Sitasi membuat saya bahagia.
> 
>   --Shakespeare
>   ~~(hanya untuk bersenang-senang :D)~~

```bibtex
@article{fei2025mcp,
  title={MCP-Zero: Active Tool Discovery for Autonomous LLM Agents},
  author={Fei, Xiang dan Zheng, Xiawu dan Feng, Hao},
  journal={arXiv preprint arXiv:2506.01056},
tahun={2025}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-06

---