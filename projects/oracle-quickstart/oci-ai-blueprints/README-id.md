# OCI AI Blueprints

**Sebarkan, skalakan, dan pantau beban kerja AI dengan platform OCI AI Blueprints, serta kurangi waktu onboarding GPU Anda dari beberapa minggu menjadi beberapa menit.**

OCI AI Blueprints adalah solusi tanpa kode yang disederhanakan untuk menyebarkan dan mengelola beban kerja Generative AI pada Kubernetes Engine (OKE). Dengan menyediakan rekomendasi perangkat keras yang terstandarisasi, tumpukan perangkat lunak siap pakai, serta alat observabilitas bawaan, OCI AI Blueprints membantu Anda menjalankan aplikasi AI dengan cepat dan efisien—tanpa harus berurusan dengan kompleksitas keputusan infrastruktur, kompatibilitas perangkat lunak, dan praktik terbaik MLOps.

[![Install OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)

## Daftar Isi

**Memulai**

- [Instal AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)
- [Akses Portal dan API AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/usage_guide.md)

**Tentang OCI AI Blueprints**

- [Apa itu OCI AI Blueprints?](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [Mengapa menggunakan OCI AI Blueprints?](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [Fitur](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [Daftar Blueprints](#blueprints)
- [FAQ](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [Dukungan & Kontak](https://github.com/oracle-quickstart/oci-ai-blueprints/blob/vkammari/doc_improvements/docs/about/README.md#frequently-asked-questions-faq)

**Referensi API**

- [Dokumentasi Referensi API](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/api_documentation.md)

**Sumber Daya Tambahan**

- [Publikasikan Blueprint Kustom](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/custom_blueprints)
- [Instal Pembaruan](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/installing_new_updates.md)
- [Kebijakan IAM](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/iam_policies.md)
- [Isi Repository](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [Masalah yang Diketahui](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/known_issues.md)

## Memulai

Instal OCI AI Blueprints dengan mengklik tombol di bawah ini:

[![Install OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)

## Blueprints

Blueprint melampaui template Terraform dasar. Setiap blueprint:

- Menawarkan saran perangkat keras yang telah divalidasi (misal: bentuk optimal, konfigurasi CPU/GPU),
- Menyertakan tumpukan aplikasi end-to-end yang disesuaikan untuk berbagai use case GenAI, dan
- Sudah dilengkapi dengan monitoring, logging, dan auto-scaling secara default.

Setelah Anda menginstal OCI AI Blueprints ke cluster OKE di tenancy Anda, Anda dapat menyebarkan blueprint siap pakai berikut ini:

| Blueprint                                                                                     | Deskripsi                                                                                                                              |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------- |
| [**LLM & VLM Inference dengan vLLM**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/llm_inference_with_vllm/README.md) | Deploy model Llama 2/3/3.1 7B/8B menggunakan bentuk GPU NVIDIA dan engine inferensi vLLM dengan auto-scaling.                          |
| [**Fine-Tuning Benchmarking**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/lora-benchmarking)                    | Jalankan MLCommons quantized Llama-2 70B LoRA finetuning pada A100 untuk benchmarking performa.                                         |
| [**LoRA Fine-Tuning**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/lora-fine-tuning)                             | Fine-tuning LoRA untuk model kustom atau HuggingFace menggunakan dataset apa pun. Termasuk tuning hyperparameter yang fleksibel.        |
| [**Health Check**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/gpu-health-check)                                 | Evaluasi komprehensif performa GPU untuk memastikan kesiapan perangkat keras secara optimal sebelum memulai beban kerja komputasi berat. |
| [**CPU Inference**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/cpu-inference)                                   | Manfaatkan Ollama untuk menguji inferensi berbasis CPU dengan model seperti Mistral, Gemma, dan lainnya.                                |
| [**Multi-node Inference dengan RDMA dan vLLM**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/multi-node-inference/) | Deploy LLM berukuran Llama-405B di beberapa node dengan RDMA menggunakan node H100 dengan vLLM dan LeaderWorkerSet.                     |
| [**Autoscaling Inference dengan vLLM**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/auto_scaling/)                 | Layani LLM dengan auto-scaling menggunakan KEDA, yang diskalakan ke beberapa GPU dan node menggunakan metrik aplikasi seperti latency inferensi. |
| [**LLM Inference dengan MIG**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/mig_multi_instance_gpu/)                | Deploy LLM ke sebagian GPU dengan Nvidia multi-instance GPU dan layani dengan vLLM.                                                     |
| [**Job Queuing**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/teams)                                             | Manfaatkan job queuing dan terapkan kuota sumber daya serta pembagian adil antar tim.                                                   |

## Dukungan & Kontak

Jika Anda memiliki pertanyaan, masalah, atau masukan, hubungi [vishnu.kammari@oracle.com](mailto:vishnu.kammari@oracle.com) atau [grant.neuman@oracle.com](mailto:grant.neuman@oracle.com).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---