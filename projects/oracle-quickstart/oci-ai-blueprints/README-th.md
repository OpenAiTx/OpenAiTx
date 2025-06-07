# OCI AI Blueprints

**ปรับใช้ ขยาย และตรวจสอบเวิร์กโหลด AI ด้วยแพลตฟอร์ม OCI AI Blueprints และลดระยะเวลาในการเริ่มต้นใช้งาน GPU จากสัปดาห์เหลือเพียงไม่กี่นาที**

OCI AI Blueprints คือโซลูชันแบบไร้โค้ดที่เรียบง่ายสำหรับการปรับใช้และจัดการเวิร์กโหลด Generative AI บน Kubernetes Engine (OKE) โดยให้คำแนะนำฮาร์ดแวร์ที่เหมาะสม สแต็กซอฟต์แวร์ที่เตรียมไว้ล่วงหน้า และเครื่องมือสังเกตการณ์ที่ติดตั้งมาให้พร้อมใช้ OCI AI Blueprints ช่วยให้แอปพลิเคชัน AI ของคุณเริ่มทำงานได้อย่างรวดเร็วและมีประสิทธิภาพ—โดยไม่ต้องยุ่งยากกับการตัดสินใจด้านโครงสร้างพื้นฐาน ความเข้ากันได้ของซอฟต์แวร์ และแนวทางปฏิบัติ MLOps ที่ดีที่สุด

[![ติดตั้ง OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## สารบัญ

**เริ่มต้นใช้งาน**

- [ติดตั้ง AI Blueprints](./GETTING_STARTED_README.md)
- [เข้าถึง Portal และ API ของ AI Blueprints](docs/usage_guide.md)

**เกี่ยวกับ OCI AI Blueprints**

- [OCI AI Blueprints คืออะไร?](docs/about.md)
- [ทำไมต้องใช้ OCI AI Blueprints?](docs/about.md)
- [คุณสมบัติ](docs/about.md)
- [รายการ Blueprints](#blueprints)
- [คำถามที่พบบ่อย (FAQ)](docs/about.md)
- [การสนับสนุน & ติดต่อสอบถาม](https://github.com/oracle-quickstart/oci-ai-blueprints/blob/vkammari/doc_improvements/docs/about/README.md#frequently-asked-questions-faq)

**API Reference**

- [เอกสารอ้างอิง API](docs/api_documentation.md)

**แหล่งข้อมูลเพิ่มเติม**

- [เผยแพร่ Custom Blueprints](./docs/custom_blueprints)
- [ติดตั้งอัปเดต](docs/installing_new_updates.md)
- [นโยบาย IAM](docs/iam_policies.md)
- [เนื้อหารีโพซิทอรี](docs/about.md)
- [ปัญหาที่ทราบแล้ว](docs/known_issues.md)

## เริ่มต้นใช้งาน

ติดตั้ง OCI AI Blueprints โดยคลิกที่ปุ่มด้านล่าง:

[![ติดตั้ง OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## Blueprints

Blueprints ให้มากกว่าเทมเพลต Terraform ทั่วไป โดยแต่ละ Blueprint:

- เสนอคำแนะนำฮาร์ดแวร์ที่ได้รับการตรวจสอบ (เช่น รูปแบบที่เหมาะสม การกำหนดค่า CPU/GPU ที่เหมาะสม),
- รวมสแต็กแอปพลิเคชันแบบ end-to-end ที่ปรับแต่งสำหรับกรณีการใช้งาน GenAI ที่แตกต่างกัน, และ
- มาพร้อมกับการตั้งค่าการตรวจสอบ การบันทึก และการปรับขนาดอัตโนมัติพร้อมใช้งาน

หลังจากติดตั้ง OCI AI Blueprints ไปยังคลัสเตอร์ OKE ใน tenancy ของคุณแล้ว คุณสามารถปรับใช้ Blueprints ที่สร้างไว้ล่วงหน้าเหล่านี้ได้:

| Blueprint                                                                                     | คำอธิบาย                                                                                                                               |
| --------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- |
| [**LLM & VLM Inference with vLLM**](docs/sample_blueprints/llm_inference_with_vllm/README.md) | ปรับใช้โมเดล Llama 2/3/3.1 7B/8B ด้วย NVIDIA GPU shapes และ vLLM inference engine พร้อมการปรับขนาดอัตโนมัติ                           |
| [**Fine-Tuning Benchmarking**](./docs/sample_blueprints/lora-benchmarking)                    | รัน MLCommons quantized Llama-2 70B LoRA finetuning บน A100 เพื่อทดสอบประสิทธิภาพ                                                      |
| [**LoRA Fine-Tuning**](./docs/sample_blueprints/lora-fine-tuning)                             | LoRA fine-tuning สำหรับโมเดล custom หรือ HuggingFace โดยใช้ dataset ใดก็ได้ พร้อมรองรับการปรับแต่ง hyperparameter อย่างยืดหยุ่น         |
| [**Health Check**](./docs/sample_blueprints/gpu-health-check)                                 | ประเมินประสิทธิภาพ GPU อย่างครบถ้วน เพื่อให้แน่ใจว่าฮาร์ดแวร์พร้อมใช้งานในระดับสูงสุดก่อนเริ่มเวิร์กโหลดที่ต้องใช้การประมวลผลหนัก     |
| [**CPU Inference**](./docs/sample_blueprints/cpu-inference)                                   | ใช้ Ollama ในการทดสอบ CPU-based inference กับโมเดล เช่น Mistral, Gemma และอื่น ๆ                                                      |
| [**Multi-node Inference with RDMA and vLLM**](./docs/sample_blueprints/multi-node-inference/) | ปรับใช้ Llama-405B ขนาด LLM หลายโหนดพร้อม RDMA โดยใช้ H100 nodes กับ vLLM และ LeaderWorkerSet                                         |
| [**Autoscaling Inference with vLLM**](./docs/sample_blueprints/auto_scaling/)                 | ให้บริการ LLMs พร้อม autoscaling ด้วย KEDA ซึ่งสามารถขยายไปยัง GPU และโหนดหลายตัวโดยใช้ metric ของแอปพลิเคชัน เช่น inference latency |
| [**LLM Inference with MIG**](./docs/sample_blueprints/mig_multi_instance_gpu/)                | ปรับใช้ LLMs เฉพาะส่วนของ GPU ด้วย multi-instance GPU ของ Nvidia และให้บริการด้วย vLLM                                               |
| [**Job Queuing**](./docs/sample_blueprints/teams)                                             | ใช้ประโยชน์จาก job queuing และกำหนด resource quotas พร้อมควบคุมการแบ่งปันทรัพยากรที่เป็นธรรมระหว่างทีม                              |

## การสนับสนุน & ติดต่อสอบถาม

หากคุณมีคำถาม ปัญหา หรือข้อเสนอแนะ กรุณาติดต่อ [vishnu.kammari@oracle.com](mailto:vishnu.kammari@oracle.com) หรือ [grant.neuman@oracle.com](mailto:grant.neuman@oracle.com)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---