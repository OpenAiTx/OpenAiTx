[![License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE) [![Coverage](https://github.com/NVIDIA/KAI-Scheduler/raw/coverage-badge/badges/coverage.svg)](https://github.com/NVIDIA/KAI-Scheduler/blob/main/.github/workflows/update-coverage-badge.yaml)
# KAI Scheduler
KAI Scheduler เป็น [Kubernetes scheduler](https://kubernetes.io/docs/concepts/scheduling-eviction/kube-scheduler/) ที่มีความเสถียร มีประสิทธิภาพ และสามารถขยายขนาดได้ ออกแบบมาเพื่อเพิ่มประสิทธิภาพการจัดสรรทรัพยากร GPU สำหรับงาน AI และ Machine Learning

ออกแบบมาเพื่อบริหารจัดการคลัสเตอร์ GPU ขนาดใหญ่ที่มีโหนดนับพัน และรองรับปริมาณงานจำนวนมาก ทำให้ KAI Scheduler เหมาะสำหรับสภาพแวดล้อมขนาดใหญ่และต้องการสมรรถนะสูง
KAI Scheduler ช่วยให้ผู้ดูแลระบบ Kubernetes สามารถจัดสรรทรัพยากร GPU ให้กับงานต่าง ๆ ได้แบบไดนามิก

KAI Scheduler รองรับวงจรชีวิต AI ทั้งหมด ตั้งแต่งานขนาดเล็กที่ต้องการทรัพยากรน้อยและตอบสนองไว ไปจนถึงการฝึกสอนและทำนายผลขนาดใหญ่ ทั้งหมดในคลัสเตอร์เดียวกัน
ช่วยให้มั่นใจว่าทรัพยากรถูกจัดสรรอย่างเหมาะสม พร้อมรักษาความเป็นธรรมระหว่างผู้ใช้งานที่แตกต่างกัน
สามารถทำงานร่วมกับ scheduler อื่น ๆ ที่ติดตั้งในคลัสเตอร์ได้

## คุณสมบัติเด่น
* [Batch Scheduling](docs/batch/README.md): รับประกันว่าพ็อดทั้งหมดในกลุ่มจะถูกจัดสรรพร้อมกันหรือไม่ถูกจัดสรรเลย
* การบรรจุแบบ Bin Packing & Spread Scheduling: เพิ่มประสิทธิภาพการใช้โหนดโดยลดการกระจัดกระจาย (bin-packing) หรือเพิ่มความทนทานและการกระจายโหลด (spread scheduling)
* [Workload Priority](docs/priority/README.md): จัดลำดับความสำคัญของงานในคิวได้อย่างมีประสิทธิภาพ
* [Hierarchical Queues](docs/queues/README.md): จัดการงานผ่านคิว 2 ระดับ เพื่อความยืดหยุ่นในการควบคุมขององค์กร
* [Resource distribution](docs/fairness/README.md#resource-division-algorithm): ปรับแต่งโควต้า น้ำหนักเกินโควต้า ขีดจำกัด และลำดับความสำคัญต่อคิว
* [Fairness Policies](docs/fairness/README.md#reclaim-strategies): รับประกันการจัดสรรทรัพยากรอย่างเป็นธรรมด้วย Dominant Resource Fairness (DRF) และการเรียกคืนทรัพยากรข้ามคิว
* Workload Consolidation: จัดสรรงานที่กำลังทำงานใหม่อย่างชาญฉลาดเพื่อลดการกระจัดกระจายและเพิ่มการใช้คลัสเตอร์
* [Elastic Workloads](docs/elastic/README.md): ปรับขนาดงานแบบไดนามิกภายในจำนวนพ็อดขั้นต่ำและสูงสุดที่กำหนด
* Dynamic Resource Allocation (DRA): รองรับทรัพยากรฮาร์ดแวร์เฉพาะผู้ผลิตผ่าน Kubernetes ResourceClaims (เช่น GPU จาก NVIDIA หรือ AMD)
* [GPU Sharing](docs/gpu-sharing/README.md): อนุญาตให้งานหลายรายการแชร์ GPU เดียวหรือหลายตัวได้อย่างมีประสิทธิภาพ เพื่อใช้ทรัพยากรอย่างสูงสุด
* รองรับ Cloud & On-premise: ใช้งานร่วมกับโครงสร้างพื้นฐาน Cloud แบบไดนามิก (รวมถึง auto-scalers เช่น Karpenter) และการติดตั้งแบบ On-premise

## ข้อกำหนดเบื้องต้น
ก่อนติดตั้ง KAI Scheduler ให้ตรวจสอบว่าคุณมี:

- คลัสเตอร์ Kubernetes ที่กำลังทำงานอยู่
- ติดตั้ง [Helm](https://helm.sh/docs/intro/install) CLI แล้ว
- ติดตั้ง [NVIDIA GPU-Operator](https://github.com/NVIDIA/gpu-operator) เพื่อให้สามารถจัดสรรงานที่ขอใช้ทรัพยากร GPU

## การติดตั้ง
KAI Scheduler จะถูกติดตั้งใน namespace `kai-scheduler` เมื่อส่งงาน ให้ใช้ namespace แยกเฉพาะ

### วิธีการติดตั้ง
KAI Scheduler สามารถติดตั้งได้โดย:

- **จาก Production (แนะนำ)**
- **จาก Source (Build it Yourself)**

#### ติดตั้งจาก Production
ค้นหาเวอร์ชันล่าสุดที่หน้า [releases](https://github.com/NVIDIA/KAI-Scheduler/releases)
รันคำสั่งด้านล่างโดยแทนที่ `<VERSION>` ด้วยเวอร์ชันที่ต้องการ:
```sh
helm upgrade -i kai-scheduler oci://ghcr.io/nvidia/kai-scheduler/kai-scheduler -n kai-scheduler --create-namespace --version <VERSION>
```
#### Build จาก Source
ปฏิบัติตามคำแนะนำ [ที่นี่](docs/developer/building-from-source.md)

## เริ่มต้นอย่างรวดเร็ว
หากต้องการเริ่มจัดสรรงานด้วย KAI Scheduler โปรดดูตัวอย่าง [Quick Start](docs/quickstart/README.md)

## แผนการดำเนินงาน

### ภาพรวมลำดับความสำคัญหลักสำหรับปี 2025
* ปรับโครงสร้างโค้ดเพื่อรองรับการใช้งานแบบเป็นกลางทางผู้ผลิต (vendor neutrality)
* รองรับ Scheduling Gates https://github.com/NVIDIA/KAI-Scheduler/issues/63
* ศึกษาความเป็นไปได้ในการเชื่อมต่อกับ Kueue https://github.com/NVIDIA/KAI-Scheduler/issues/68
* เพิ่มการรองรับ Topology Aware Scheduling สำหรับ pod-group https://github.com/NVIDIA/KAI-Scheduler/issues/66
* รองรับ Min Run Time ต่อ workload
* รองรับ Max Run Time ต่อ workload (พร้อม delayed requeue)
* เพิ่ม PriorityClasses หลายรายการเป็นค่าเริ่มต้นในการติดตั้ง KAI
* รองรับ JobSet
* รองรับ LWS (LeaderWorkerSet)
* เพิ่ม metric สำหรับ pod และ pod-group preemptions
* แยกการทำงานของ Priority และ Preemption

### เป้าหมายระยะยาว
* รองรับการ time decay ต่อคิว
* ปรับปรุงความสามารถในการขยายขนาด (hyper scale)
* รองรับ Consolidation ของ Inference workload เพื่อลดการกระจัดกระจายของคลัสเตอร์
* รองรับคิวแบบลำดับชั้น n-levels
* Rollout งาน Inference อย่างปลอดภัย (new revision update โดยใช้ queue temporary over-quota)

## ชุมชน การพูดคุย และการสนับสนุน

เรายินดีรับฟังความคิดเห็นจากคุณ! ช่องทางติดต่อที่ดีที่สุดมีดังนี้:

### Slack
เข้าร่วม [CNCF Slack](https://communityinviter.com/apps/cloud-native/cncf) ก่อน และเยี่ยมชมช่อง [#kai-scheduler](https://cloud-native.slack.com/archives/kai-scheduler)

### ประชุมชุมชนทุกสองสัปดาห์  
**เมื่อ:** ทุกวันจันทร์สัปดาห์เว้นสัปดาห์ เวลา 17:00 CEST  
[แปลงเวลาเป็นเขตเวลาของคุณ](https://dateful.com/time-zone-converter?t=17&tz2=Germany) | [เพิ่มลงในปฏิทินของคุณ](https://calendar.google.com/calendar/event?action=TEMPLATE&tmeid=N2Q2bjhoNXAzMGc0cWpnZTQ4OGtpdXFhanFfMjAyNTA2MDlUMTUwMDAwWiAxZjQ2OTZiOWVlM2JiMWE1ZWIzMTAwODBkNDZiZmMwMDZjNTUxYWFiZmU1YTM3ZGM2YTc0NTFhYmNhMmE1ODk0QGc&tmsrc=1f4696b9ee3bb1a5eb310080d46bfc006c551aabfe5a37dc6a7451abca2a5894%40group.calendar.google.com&scp=ALL)  | [บันทึกการประชุม & วาระการประชุม](https://docs.google.com/document/d/13K7NGdPebOstlrsif1YLjGz1x-aJafMXeIgqbO7WghI/edit?usp=sharing)

### Mailing List  
เข้าร่วม [kai-scheduler mailing list](https://groups.google.com/g/kai-scheduler) เพื่อรับข่าวสารอัปเดตการประชุมประจำสัปดาห์

### ปัญหาทางเทคนิค & ขอฟีเจอร์  
โปรดเปิด [GitHub issue](https://github.com/NVIDIA/KAI-Scheduler/issues/new/choose) สำหรับแจ้งบั๊ก เสนอฟีเจอร์ หรือขอความช่วยเหลือทางเทคนิค เพื่อให้เราติดตามคำขอและตอบกลับได้อย่างมีประสิทธิภาพ



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---