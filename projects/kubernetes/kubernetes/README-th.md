# Kubernetes (K8s)

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/569/badge)](https://bestpractices.coreinfrastructure.org/projects/569) [![Go Report Card](https://goreportcard.com/badge/github.com/kubernetes/kubernetes)](https://goreportcard.com/report/github.com/kubernetes/kubernetes) ![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/kubernetes/kubernetes?sort=semver)

<img src="https://github.com/kubernetes/kubernetes/raw/master/logo/logo.png" width="100">

----

Kubernetes หรือที่รู้จักกันในชื่อ K8s เป็นระบบโอเพ่นซอร์สสำหรับจัดการ [แอปพลิเคชันที่ทำงานในคอนเทนเนอร์] 
บนโฮสต์หลายเครื่อง โดยให้กลไกพื้นฐานสำหรับการปรับใช้ การบำรุงรักษา 
และการปรับขนาดของแอปพลิเคชัน

Kubernetes สร้างขึ้นจากประสบการณ์กว่าหนึ่งทศวรรษครึ่งของ Google ในการรัน 
งานโปรดักชันขนาดใหญ่ด้วยระบบที่เรียกว่า [Borg] 
ผสมผสานกับแนวคิดและแนวปฏิบัติที่ดีที่สุดจากชุมชน

Kubernetes โฮสต์โดย Cloud Native Computing Foundation ([CNCF])
หากบริษัทของคุณต้องการมีส่วนร่วมในการพัฒนาเทคโนโลยี 
ที่เป็นแพ็กเกจคอนเทนเนอร์ กำหนดเวลาทำงานแบบไดนามิก 
และเน้นไมโครเซอร์วิส ลองเข้าร่วม CNCF
สำหรับรายละเอียดเกี่ยวกับผู้ที่มีส่วนร่วมและบทบาทของ Kubernetes 
โปรดอ่าน [ประกาศของ CNCF]

----

## เริ่มต้นใช้งาน K8s

ดูเอกสารของเราที่ [kubernetes.io]

เรียนคอร์สฟรีเกี่ยวกับ [Scalable Microservices with Kubernetes]

หากต้องการใช้โค้ด Kubernetes เป็นไลบรารีในแอปพลิเคชันอื่น ดู [รายชื่อคอมโพเนนต์ที่เผยแพร่แล้ว](https://git.k8s.io/kubernetes/staging/README.md)
ไม่รองรับการใช้โมดูล `k8s.io/kubernetes` หรือแพ็กเกจ `k8s.io/kubernetes/...` เป็นไลบรารี

## เริ่มต้นพัฒนา K8s

[community repository] มีข้อมูลทั้งหมดเกี่ยวกับ 
การคอมไพล์ Kubernetes จากซอร์สโค้ด วิธีการมีส่วนร่วมในโค้ด 
และเอกสารต่าง ๆ รวมถึงช่องทางติดต่อ

หากคุณต้องการคอมไพล์ Kubernetes ทันที มีสองตัวเลือก:

##### คุณมี [Go environment] ที่ใช้งานได้

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make
```

##### คุณมี [Docker environment] ที่ใช้งานได้

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make quick-release
```

สำหรับรายละเอียดฉบับเต็ม โปรดดูที่ [developer's documentation]

## การสนับสนุน

หากคุณต้องการความช่วยเหลือ เริ่มต้นที่ [troubleshooting guide] 
และปฏิบัติตามขั้นตอนที่เราได้แนะนำไว้

หากคุณมีคำถาม สามารถติดต่อเราได้ 
[ตามช่องทางนี้][communication]

[announcement]: https://cncf.io/news/announcement/2015/07/new-cloud-native-computing-foundation-drive-alignment-among-container
[Borg]: https://research.google.com/pubs/pub43438.html?authuser=1
[CNCF]: https://www.cncf.io/about
[communication]: https://git.k8s.io/community/communication
[community repository]: https://git.k8s.io/community
[containerized applications]: https://kubernetes.io/docs/concepts/overview/what-is-kubernetes/
[developer's documentation]: https://git.k8s.io/community/contributors/devel#readme
[Docker environment]: https://docs.docker.com/engine
[Go environment]: https://go.dev/doc/install
[kubernetes.io]: https://kubernetes.io
[Scalable Microservices with Kubernetes]: https://www.udacity.com/course/scalable-microservices-with-kubernetes--ud615
[troubleshooting guide]: https://kubernetes.io/docs/tasks/debug/

## การประชุมชุมชน

[ปฏิทิน](https://www.kubernetes.dev/resources/calendar/) มีรายการการประชุมทั้งหมดของชุมชน Kubernetes ในที่เดียว

## ผู้ใช้งาน

เว็บไซต์ [User Case Studies](https://kubernetes.io/case-studies/) มีกรณีศึกษาการใช้งานจริงจากองค์กรในหลากหลายอุตสาหกรรมที่ใช้งาน/ย้ายไปใช้ Kubernetes

## ธรรมาภิบาล

โปรเจกต์ Kubernetes อยู่ภายใต้กรอบของหลักการ ค่านิยม นโยบาย และกระบวนการ 
เพื่อช่วยให้ชุมชนและผู้มีส่วนได้ส่วนเสียบรรลุเป้าหมายร่วมกัน

[Kubernetes Community](https://github.com/kubernetes/community/blob/master/governance.md) เป็นจุดเริ่มต้นสำหรับเรียนรู้เกี่ยวกับการจัดระเบียบของเรา

[ที่เก็บ Kubernetes Steering community](https://github.com/kubernetes/steering) ใช้โดยคณะกรรมการ Kubernetes Steering ซึ่งดูแลธรรมาภิบาลของโปรเจกต์ Kubernetes

## แผนงาน

[ที่เก็บ Kubernetes Enhancements](https://github.com/kubernetes/enhancements) ให้ข้อมูลเกี่ยวกับการออกเวอร์ชันของ Kubernetes รวมถึงการติดตามฟีเจอร์และแบ็คลอก

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---