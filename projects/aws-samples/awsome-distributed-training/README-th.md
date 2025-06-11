# สถาปัตยกรรมอ้างอิงและการทดสอบการฝึกอบรม ML <!-- omit from toc -->

> **คำเตือน**
> ขณะนี้เรากำลังดำเนินการปรับโครงสร้างครั้งใหญ่ของที่เก็บนี้ โดยมุ่งเน้นเป็นพิเศษที่ส่วนของกรณีทดสอบ หากคุณต้องการใช้โครงสร้างไดเรกทอรีก่อนหน้าและกรณีทดสอบที่เลิกใช้ โปรดดูที่ [v1.1.0](https://github.com/aws-samples/awsome-distributed-training/releases/tag/v1.1.0) 


ที่เก็บนี้ประกอบด้วยสถาปัตยกรรมอ้างอิงและกรณีทดสอบสำหรับการฝึกโมเดลแบบกระจายด้วย [Amazon SageMaker Hyperpod](https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html), [AWS ParallelCluster](https://docs.aws.amazon.com/parallelcluster/latest/ug/what-is-aws-parallelcluster.html), [AWS Batch](https://docs.aws.amazon.com/batch/latest/userguide/what-is-batch.html) และ [Amazon EKS](https://docs.aws.amazon.com/eks/latest/userguide/getting-started-console.html) กรณีทดสอบครอบคลุมโมเดลหลายประเภทและขนาดต่าง ๆ รวมถึงเฟรมเวิร์กและการปรับแต่งแบบขนานที่แตกต่างกัน (Pytorch DDP/FSDP, MegatronLM, NemoMegatron...)

ส่วนประกอบหลักของไดเรกทอรีนี้คือ:

```bash
reference-architectures/
|-- 1.architectures/               # เทมเพลต CloudFormation สำหรับสถาปัตยกรรมอ้างอิง
|-- 2.ami_and_containers/          # สคริปต์สำหรับสร้าง AMI และอิมเมจคอนเทนเนอร์
|-- 3.test_cases/                  # กรณีทดสอบอ้างอิงและ/หรือสคริปต์เบนช์มาร์ก
|-- 4.validation_observability/    # เครื่องมือสำหรับวัดประสิทธิภาพหรือตรวจสอบปัญหา
`-- ...
```

**หมายเหตุ**: สถาปัตยกรรมถูกออกแบบมาให้ทำงานร่วมกับบัคเก็ต S3 และ VPC ที่สร้างขึ้นโดยใช้เทมเพลตอ้างอิง `1.architectures/0.s3/` และ `1.architectures/1.vpc_network/` _แนะนำอย่างยิ่งให้คุณทำการปรับใช้เทมเพลตทั้งสองนี้ **ก่อน** การปรับใช้สถาปัตยกรรมอ้างอิงใด ๆ_

## 0. เวิร์กช็อป

คุณสามารถติดตามเวิร์กช็อปด้านล่างเพื่อฝึกโมเดลบน AWS แต่ละเวิร์กช็อปประกอบด้วยตัวอย่างสำหรับกรณีทดสอบหลายกรณี รวมถึงข้อมูลสำคัญเกี่ยวกับการดำเนินงานคลัสเตอร์เพื่อการฝึก LLM

| ชื่อ                                                                              | ความเห็น
| --------------------------------------------------------------------------------- | ------------------------------------------------------------- |
| [Amazon SageMaker HyperPod](https://catalog.workshops.aws/sagemaker-hyperpod/en-US)   | เวิร์กช็อปสำหรับ SageMaker HyperPod แสดงวิธีการปรับใช้และตรวจสอบ |
| [AWS ParallelCluster](https://catalog.workshops.aws/ml-on-aws-parallelcluster)   | เวิร์กช็อปที่คล้ายกับ HyperPod แต่สำหรับ ParallelCluster       |
| [Amazon SageMaker HyperPod EKS](https://catalog.workshops.aws/sagemaker-hyperpod-eks) | เวิร์กช็อปสำหรับ SageMaker HyperPod EKS แสดงวิธีการปรับใช้และตรวจสอบ |

## 1. สถาปัตยกรรม

สถาปัตยกรรมตั้งอยู่ใน `1.architectures` และประกอบด้วยยูทิลิตี้และสถาปัตยกรรมที่เกี่ยวข้องกับบริการ

| ชื่อ                                                               | หมวดหมู่ | การใช้งาน                                             |
| ------------------------------------------------------------------ | -------- | ----------------------------------------------------- |
| [`0.s3`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/0.s3)                                   | ที่เก็บข้อมูล  | สร้างบัคเก็ต S3                                    |
| [`1.vpc_network`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/1.vpc_network)                 | เครือข่าย  | สร้าง VPC พร้อมซับเน็ตและทรัพยากรที่จำเป็น             |
| [`2.aws-parallelcluster`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/2.aws-parallelcluster) | การประมวลผล  | เทมเพลตคลัสเตอร์สำหรับการฝึกด้วย GPU & ซิลิกอนกำหนดเอง  |
| [`3.aws-batch`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/3.aws-batch)                     | การประมวลผล  | เทมเพลต AWS Batch สำหรับการฝึกแบบกระจาย                  |
| [`4.amazon-eks`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/4.amazon-eks)                   | การประมวลผล  | ไฟล์แมนนิเฟสต์สำหรับฝึกด้วย Amazon EKS                   |
| [`5.sagemaker-hyperpod`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/5.sagemaker-hyperpod)   | การประมวลผล  | เทมเพลต SageMaker HyperPod สำหรับการฝึกแบบกระจาย          |

จะมีเพิ่มเติมในอนาคต คุณสามารถเพิ่มของใหม่ได้ตามต้องการ (เช่น Ray?) คุณยังจะพบ [เอกสาร](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-cheatsheet.md) สำหรับ EFA และตัวแปรสภาพแวดล้อมที่แนะนำ

## 2. อิมเมจเครื่อง Amazon Machine แบบกำหนดเอง

อิมเมจเครื่องแบบกำหนดเองสามารถสร้างได้โดยใช้ [Packer](https://www.packer.io) สำหรับ AWS ParallelCluster, Amazon EKS และ EC2 ธรรมดา อิมเมจเหล่านี้สร้างขึ้นบนบทบาทและเพลย์บุ๊กของ Ansible

## 3. กรณีทดสอบ

กรณีทดสอบถูกจัดเรียงตามเฟรมเวิร์กและครอบคลุมสถานการณ์การฝึกแบบกระจายต่าง ๆ แต่ละกรณีทดสอบประกอบด้วยสคริปต์และการตั้งค่าที่จำเป็นสำหรับการรันงานฝึกแบบกระจาย

### กรณีทดสอบ PyTorch
- [`FSDP/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/FSDP) - ตัวอย่างการฝึก Fully Sharded Data Parallel
- [`megatron-lm/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/megatron-lm) - ตัวอย่างการฝึกแบบกระจาย Megatron-LM
- [`nemo-launcher/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-launcher) - ตัวอย่าง NeMo Launcher สำหรับการฝึกแบบกระจาย กรณีทดสอบนี้สำหรับ NeMo เวอร์ชัน 1.0 เท่านั้น
- [`nemo-run/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-run) - ตัวอย่างการฝึกแบบกระจายเฟรมเวิร์ก NeMo กรณีทดสอบนี้สำหรับ NeMo เวอร์ชัน 2.0 ขึ้นไป
- [`neuronx-distributed/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/neuronx-distributed) - ตัวอย่างการฝึกแบบกระจาย AWS Trainium
- [`mosaicml-composer/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/mosaicml-composer) - ตัวอย่าง MosaicML Composer
- [`picotron/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/picotron) - ตัวอย่างการฝึกแบบกระจาย PicoTron
- [`torchtitan/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/torchtitan) - ตัวอย่าง TorchTitan
- [`cpu-ddp/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/cpu-ddp) - ตัวอย่าง Distributed Data Parallel บน CPU
- [`bionemo/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/bionemo) - ตัวอย่างการฝึกแบบกระจาย BioNeMo

### กรณีทดสอบ JAX
- [`jax/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/jax) - ตัวอย่างการฝึกแบบกระจายบน JAX โดยใช้ PaxML

แต่ละกรณีทดสอบประกอบด้วย:
- สคริปต์และการตั้งค่าสำหรับการฝึก
- คำจำกัดความคอนเทนเนอร์ (ถ้ามี)
- สคริปต์เปิดใช้งานสำหรับคลัสเตอร์ประเภทต่าง ๆ
- เครื่องมือการตรวจสอบประสิทธิภาพและการตรวจสอบความถูกต้อง

## 4. สคริปต์ตรวจสอบ

ยูทิลิตี้สคริปต์และตัวอย่างไมโครเบนช์มาร์กตั้งอยู่ใน `4.validation_scripts/` ตัวส่งออก Prometheus สำหรับ EFA สามารถพบได้ใน [ไดเรกทอรีนี้](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter) 


| ชื่อ                                                                                     | ความเห็น                                                      |
| ---------------------------------------------------------------------------------------- | ------------------------------------------------------------- |
| [`1.pytorch-env-validation`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/1.pytorch-env-validation) | ตรวจสอบสภาพแวดล้อม PyTorch ของคุณ                            |
| [`3.efa-node-exporter`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter)           | ตัวส่งออกโหนดพร้อมโมดูลตรวจสอบ Amazon EFA                   |
| [`4.prometheus-grafana`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/4.prometheus-grafana)         | ทรัพย์สินสำหรับปรับใช้เพื่อตรวจสอบคลัสเตอร์ SageMaker Hyperpod |
| [`5.nsight`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/5.nsight)                                 | แสดงวิธีรัน Nvidia Nsight Systems เพื่อวิเคราะห์โปรไฟล์งานของคุณ |
| [`efa-versions.py`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-versions.py)                                  | ดูเวอร์ชันของไลบรารี Nvidia, ไดรเวอร์ และไดรเวอร์ EFA       |


## 5. การทดสอบแบบ CI

การทดสอบแบบบูรณาการเขียนด้วย [pytest](https://docs.pytest.org) เพียงรัน:

```bash
pytest .
```

อีกทางเลือกหนึ่งคุณสามารถรันการทดสอบโดยไม่จับ stdout และเก็บรักษาอิมเมจ Docker และอาร์ติแฟกต์อื่น ๆ

```bash
pytest -s --keep-artifacts=t
```

## 6. ผู้ร่วมพัฒนา

ขอขอบคุณผู้ร่วมพัฒนาทุกคนสำหรับการสร้าง, ตรวจสอบ และทดสอบ

[![Contributors](https://contrib.rocks/image?repo=aws-samples/awsome-distributed-training)](https://github.com/aws-samples/awsome-distributed-training/graphs/contributors)

## 7. ประวัติการให้ดาว

[![Star History Chart](https://api.star-history.com/svg?repos=aws-samples/awsome-distributed-training&type=Date)](https://star-history.com/#aws-samples/awsome-distributed-training&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---