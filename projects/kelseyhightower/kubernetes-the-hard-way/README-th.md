# Kubernetes The Hard Way

บทแนะนำนี้จะพาคุณตั้งค่า Kubernetes ด้วยวิธีที่ยากกว่าปกติ คู่มือนี้ไม่ได้เหมาะสำหรับผู้ที่มองหาเครื่องมืออัตโนมัติเต็มรูปแบบเพื่อสร้างคลัสเตอร์ Kubernetes ขึ้นมา Kubernetes The Hard Way ได้รับการออกแบบมาเพื่อการเรียนรู้ หมายความว่าคุณจะต้องทำตามขั้นตอนทีละขั้นเพื่อให้เข้าใจทุกภารกิจที่จำเป็นในการบูตสตรัปคลัสเตอร์ Kubernetes

> ผลลัพธ์จากบทแนะนำนี้ไม่ควรถูกมองว่าเหมาะกับการใช้งานในระบบ production และอาจได้รับการสนับสนุนจากชุมชนในระดับจำกัด แต่อย่าให้สิ่งนี้หยุดคุณจากการเรียนรู้!

## ลิขสิทธิ์

<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br />ผลงานนี้อยู่ภายใต้สัญญาอนุญาต <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License</a>.


## กลุ่มเป้าหมาย

กลุ่มเป้าหมายสำหรับบทแนะนำนี้คือผู้ที่ต้องการเข้าใจพื้นฐานของ Kubernetes และวิธีการที่องค์ประกอบหลักแต่ละส่วนทำงานร่วมกัน

## รายละเอียดของคลัสเตอร์

Kubernetes The Hard Way จะแนะนำขั้นตอนการบูตสตรัปคลัสเตอร์ Kubernetes เบื้องต้น โดยที่คอมโพเนนต์ของ control plane ทั้งหมดจะทำงานอยู่บนโหนดเดียว และมี worker node สองตัว ซึ่งเพียงพอสำหรับการเรียนรู้แนวคิดหลัก

เวอร์ชันของคอมโพเนนต์:

* [kubernetes](https://github.com/kubernetes/kubernetes) v1.32.x
* [containerd](https://github.com/containerd/containerd) v2.1.x
* [cni](https://github.com/containernetworking/cni) v1.6.x
* [etcd](https://github.com/etcd-io/etcd) v3.6.x

## ห้องปฏิบัติการ

บทแนะนำนี้ต้องการเครื่องเสมือนหรือเครื่องจริงพื้นฐาน ARM64 หรือ AMD64 จำนวนสี่ (4) เครื่อง ที่เชื่อมต่ออยู่ในเครือข่ายเดียวกัน

* [ข้อกำหนดเบื้องต้น](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/01-prerequisites.md)
* [การตั้งค่า Jumpbox](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/02-jumpbox.md)
* [การจัดเตรียมทรัพยากรคอมพิวต์](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/03-compute-resources.md)
* [การจัดเตรียม CA และสร้างใบรับรอง TLS](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/04-certificate-authority.md)
* [การสร้างไฟล์คอนฟิก Kubernetes สำหรับการยืนยันตัวตน](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/05-kubernetes-configuration-files.md)
* [การสร้าง Data Encryption Config และ Key](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/06-data-encryption-keys.md)
* [การบูตสตรัป etcd คลัสเตอร์](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/07-bootstrapping-etcd.md)
* [การบูตสตรัป Kubernetes Control Plane](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/08-bootstrapping-kubernetes-controllers.md)
* [การบูตสตรัป Kubernetes Worker Node](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/09-bootstrapping-kubernetes-workers.md)
* [การตั้งค่า kubectl สำหรับการเข้าถึงจากระยะไกล](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/10-configuring-kubectl.md)
* [การจัดเตรียมเส้นทางเครือข่าย Pod](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/11-pod-network-routes.md)
* [ทดสอบระบบเบื้องต้น](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/12-smoke-test.md)
* [การทำความสะอาด](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/13-cleanup.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---