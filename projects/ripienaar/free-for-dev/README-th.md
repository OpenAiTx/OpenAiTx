# free-for.dev

นักพัฒนาและผู้เขียนโอเพ่นซอร์ซปัจจุบันมีบริการที่มีระดับฟรีให้เลือกมากมาย แต่การค้นหาทั้งหมดต้องใช้เวลาเพื่อให้ตัดสินใจได้อย่างมีข้อมูล

นี่คือรายชื่อซอฟต์แวร์ (SaaS, PaaS, IaaS ฯลฯ) และข้อเสนออื่น ๆ ที่มีระดับฟรีสำหรับนักพัฒนา

ขอบเขตของรายการนี้จำกัดเฉพาะสิ่งที่นักพัฒนาโครงสร้างพื้นฐาน (ผู้ดูแลระบบ, ผู้ปฏิบัติ DevOps ฯลฯ) มักจะพบว่ามีประโยชน์ เราชื่นชอบบริการฟรีทั้งหมดที่มีอยู่ แต่ควรจะเน้นเฉพาะหัวข้อ บางครั้งก็เป็นเส้นสีเทา ดังนั้นนี่คือความคิดเห็นส่วนตัว; กรุณาอย่ารู้สึกไม่พอใจหากข้อเสนอของคุณไม่ได้รับการยอมรับ

รายชื่อนี้เกิดจาก Pull Requests, การตรวจทาน, ไอเดีย และการทำงานโดยผู้คนกว่า 1600 คน คุณก็สามารถช่วยได้โดยการส่ง [Pull Requests](https://github.com/ripienaar/free-for-dev) เพื่อเพิ่มบริการใหม่ หรือเอาบริการที่เงื่อนไขเปลี่ยนแปลงหรือเลิกให้บริการออก

[![Track Awesome List](https://www.trackawesomelist.com/badge.svg)](https://www.trackawesomelist.com/ripienaar/free-for-dev)

**หมายเหตุ**: รายการนี้สำหรับบริการแบบ as-a-Service เท่านั้น ไม่ใช่ซอฟต์แวร์ที่ติดตั้งเอง เพื่อให้มีคุณสมบัติ บริการต้องมีระดับฟรี ไม่ใช่แค่ทดลองใช้ฟรี ระดับฟรีต้องใช้งานได้อย่างน้อยหนึ่งปีหากมีข้อจำกัดด้านเวลา เรายังพิจารณาระดับฟรีในมุมมองด้านความปลอดภัยด้วย ดังนั้น SSO ถือว่าใช้ได้ แต่จะไม่รับบริการที่จำกัด TLS เฉพาะระดับเสียเงิน

# สารบัญ

  * [ขีดจำกัดฟรีถาวรของผู้ให้บริการคลาวด์รายใหญ่](#major-cloud-providers)
  * [โซลูชันการจัดการคลาวด์](#cloud-management-solutions)
  * [การวิเคราะห์, เหตุการณ์, และสถิติ](#analytics-events-and-statistics)
  * [APIs, ข้อมูล และ ML](#apis-data-and-ml)
  * [ที่เก็บอาร์ติแฟกต์](#artifact-repos)
  * [BaaS](#baas)
  * [แพลตฟอร์ม Low-code](#low-code-platform)
  * [CDN และการป้องกัน](#cdn-and-protection)
  * [CI และ CD](#ci-and-cd)
  * [CMS](#cms)
  * [การสร้างโค้ด](#code-generation)
  * [คุณภาพโค้ด](#code-quality)
  * [ค้นหาและเรียกดูโค้ด](#code-search-and-browsing)
  * [การจัดการข้อผิดพลาดและข้อยกเว้น](#crash-and-exception-handling)
  * [การแสดงผลข้อมูลบนแผนที่](#data-visualization-on-maps)
  * [บริการข้อมูลที่มีการจัดการ](#managed-data-services)
  * [ออกแบบและ UI](#design-and-ui)
  * [แรงบันดาลใจด้านการออกแบบ](#design-inspiration)
  * [เว็บไซต์บล็อกสำหรับนักพัฒนา](#dev-blogging-sites)
  * [DNS](#dns)
  * [ที่เกี่ยวข้องกับ Docker](#docker-related)
  * [โดเมน](#domain)
  * [การศึกษาและพัฒนาอาชีพ](#education-and-career-development)
  * [อีเมล](#email)
  * [แพลตฟอร์มการจัดการ Feature Toggles](#feature-toggles-management-platforms)
  * [ฟอนต์](#font)
  * [ฟอร์ม](#forms)
  * [Generative AI](#generative-ai)
  * [IaaS](#iaas)
  * [IDE และการแก้ไขโค้ด](#ide-and-code-editing)
  * [API และ SDK สำหรับตรวจสอบหมายเลขมือถือระหว่างประเทศ](#international-mobile-number-verification-api-and-sdk)
  * [การติดตามปัญหาและการจัดการโครงการ](#issue-tracking-and-project-management)
  * [การจัดการล็อก](#log-management)
  * [การแจกจ่ายและข้อเสนอแนะแอปมือถือ](#mobile-app-distribution-and-feedback)
  * [ระบบการจัดการ](#management-system)
  * [การส่งข้อความและการสตรีม](#messaging-and-streaming)
  * [เบ็ดเตล็ด](#miscellaneous)
  * [การตรวจสอบ](#monitoring)
  * [PaaS](#paas)
  * [ระบบสร้างแพ็กเกจ](#package-build-system)
  * [การรวมระบบชำระเงินและวางบิล](#payment-and-billing-integration)
  * [การจัดการความเป็นส่วนตัว](#privacy-management)
  * [Screenshot APIs](#screenshot-apis)
  * [Flutter และการสร้างแอป iOS โดยไม่ใช้ Mac](#flutter-related-and-building-ios-apps-without-mac)
  * [ค้นหา](#search)
  * [ความปลอดภัยและ PKI](#security-and-pki)
  * [การพิสูจน์ตัวตน, การอนุญาต และการจัดการผู้ใช้](#authentication-authorization-and-user-management)
  * [ที่เก็บซอร์สโค้ด](#source-code-repos)
  * [การจัดเก็บและประมวลผลมีเดีย](#storage-and-media-processing)
  * [Tunneling, WebRTC, Web Socket Servers และ Router อื่น ๆ](#tunneling-webrtc-web-socket-servers-and-other-routers)
  * [การทดสอบ](#testing)
  * [เครื่องมือสำหรับทีมและการทำงานร่วมกัน](#tools-for-teams-and-collaboration)
  * [การจัดการการแปล](#translation-management)
  * [ที่เกี่ยวข้องกับ Vagrant](#vagrant-related)
  * [บันทึกเซสชันผู้เยี่ยมชม](#visitor-session-recording)
  * [โฮสติ้งเว็บไซต์](#web-hosting)
  * [แพลตฟอร์มแสดงความคิดเห็น](#commenting-platforms)
  * [การจำลองฮาร์ดแวร์บนเบราว์เซอร์](#browser-based-hardware-emulation-written-in-javascript)
  * [เครื่องมือเดสก์ท็อประยะไกล](#remote-desktop-tools)
  * [การพัฒนาเกม](#game-development)
  * [ทรัพยากรฟรีอื่น ๆ](#other-free-resources)

## ผู้ให้บริการคลาวด์รายใหญ่

  * [Google Cloud Platform](https://cloud.google.com)
    * App Engine - 28 ชั่วโมงอินสแตนซ์ frontend ต่อวัน, 9 ชั่วโมงอินสแตนซ์ backend ต่อวัน
    * Cloud Firestore - พื้นที่จัดเก็บ 1GB, อ่าน 50,000 ครั้ง, เขียน 20,000 ครั้ง, ลบ 20,000 ครั้งต่อวัน
    * Compute Engine - 1 e2-micro ที่ไม่ใช่ preemptible, HDD 30GB, ที่เก็บ snapshot 5GB (จำกัดเฉพาะบางภูมิภาค), 1GB network egress จากอเมริกาเหนือไปยังปลายทางทุกภูมิภาค (ยกเว้นจีนและออสเตรเลีย) ต่อเดือน
    * Cloud Storage - 5GB, network egress 1GB
    * Cloud Shell - เชลล์ Linux บนเว็บ/IDE หลัก พร้อมพื้นที่จัดเก็บถาวร 5GB จำกัด 60 ชั่วโมงต่อสัปดาห์
    * Cloud Pub/Sub - ข้อความ 10GB ต่อเดือน
    * Cloud Functions - เรียกใช้งาน 2 ล้านครั้งต่อเดือน (รวมทั้ง background และ HTTP invocations)
    * Cloud Run - 2 ล้านคำขอต่อเดือน, 360,000 GB-seconds หน่วยความจำ, 180,000 vCPU-seconds ของเวลาในการประมวลผล, network egress 1GB จากอเมริกาเหนือ ต่อเดือน
    * Google Kubernetes Engine - ไม่มีค่าบริหารจัดการคลัสเตอร์สำหรับ zonal cluster หนึ่งคลัสเตอร์ ผู้ใช้แต่ละ node คิดค่าบริการตามราคามาตรฐานของ Compute Engine
    * BigQuery - การสืบค้น 1TB ต่อเดือน, พื้นที่จัดเก็บ 10GB ต่อเดือน
    * Cloud Build - 120 นาทีการสร้างต่อวัน
    * Cloud Source Repositories - สูงสุด 5 ผู้ใช้, พื้นที่จัดเก็บ 50GB, Egress 50GB
    * [Google Colab](https://colab.research.google.com/) - สภาพแวดล้อม Jupyter Notebooks สำหรับพัฒนาใช้งานฟรี
    * [Firebase Studio](https://firebase.studio) Google Firebase Studio (เดิมชื่อ Project IDX) VSCode ออนไลน์ที่รันบน Google Cloud
    * รายการเต็มและละเอียด - https://cloud.google.com/free

  * [Amazon Web Services](https://aws.amazon.com)
    * [CloudFront](https://aws.amazon.com/cloudfront/) - egress 1TB ต่อเดือน และ 2 ล้าน Function invocations ต่อเดือน
    * [CloudWatch](https://aws.amazon.com/cloudwatch/) - metric แบบกำหนดเอง 10 รายการ และ alarm 10 รายการ
* [CodeBuild](https://aws.amazon.com/codebuild/) - เวลา build 100 นาทีต่อเดือน
* [CodeCommit](https://aws.amazon.com/codecommit/) - ผู้ใช้งาน 5 คน, ที่เก็บข้อมูล 50GB และ 10,000 คำขอต่อเดือน
* [CodePipeline](https://aws.amazon.com/codepipeline/) - 1 pipeline ที่ใช้งานได้ต่อเดือน
* [DynamoDB](https://aws.amazon.com/dynamodb/) - ฐานข้อมูล NoSQL ขนาด 25GB
* [EC2](https://aws.amazon.com/ec2/) - 750 ชั่วโมงต่อเดือนสำหรับ t2.micro หรือ t3.micro (12 เดือน) ข้อมูลออก 100GB ต่อเดือน
* [EBS](https://aws.amazon.com/ebs/) - 30GB ต่อเดือนสำหรับ General Purpose (SSD) หรือ Magnetic (12 เดือน)
* [Elastic Load Balancing](https://aws.amazon.com/elasticloadbalancing/) - 750 ชั่วโมงต่อเดือน (12 เดือน)
* [RDS](https://aws.amazon.com/rds/) - 750 ชั่วโมงต่อเดือนสำหรับ db.t2.micro, db.t3.micro หรือ db.t4g.micro, ที่เก็บข้อมูล SSD แบบ General Purpose 20GB, สำรองข้อมูล 20GB (12 เดือน)
* [S3](https://aws.amazon.com/s3/) - พื้นที่เก็บวัตถุมาตรฐาน 5GB, คำขอ Get 20,000 ครั้ง และ Put 2,000 ครั้ง (12 เดือน)
* [Glacier](https://aws.amazon.com/glacier/) - พื้นที่เก็บข้อมูลระยะยาว 10GB
* [Lambda](https://aws.amazon.com/lambda/) - 1 ล้านคำขอต่อเดือน
* [SNS](https://aws.amazon.com/sns/) - การเผยแพร่ 1 ล้านครั้งต่อเดือน
* [SES](https://aws.amazon.com/ses/) - 3,000 ข้อความต่อเดือน (12 เดือน)
* [SQS](https://aws.amazon.com/sqs/) - คำขอคิวข้อความ 1 ล้านครั้ง
* รายการทั้งหมดแบบละเอียด - https://aws.amazon.com/free/

* [Microsoft Azure](https://azure.microsoft.com)
  * [Virtual Machines](https://azure.microsoft.com/services/virtual-machines/) - VM Linux B1S 1 เครื่อง, VM Windows B1S 1 เครื่อง (12 เดือน)
  * [App Service](https://azure.microsoft.com/services/app-service/) - 10 เว็บ, โมบายล์ หรือ API แอป (60 นาที CPU/วัน)
  * [Functions](https://azure.microsoft.com/services/functions/) - 1 ล้านคำขอต่อเดือน
  * [DevTest Labs](https://azure.microsoft.com/services/devtest-lab/) - สร้างสภาพแวดล้อม dev-test ได้อย่างรวดเร็ว ง่ายดาย และประหยัด
  * [Active Directory](https://azure.microsoft.com/services/active-directory/) - 500,000 อ็อบเจ็กต์
  * [Active Directory B2C](https://azure.microsoft.com/services/active-directory/external-identities/b2c/) - ผู้ใช้ที่เก็บต่อเดือน 50,000 ราย
  * [Azure DevOps](https://azure.microsoft.com/services/devops/) - ผู้ใช้งาน 5 คน, repo Git ส่วนตัวไม่จำกัด
  * [Azure Pipelines](https://azure.microsoft.com/services/devops/pipelines/) — 10 งานขนานฟรี (parallel jobs) พร้อมเวลาการใช้งานไม่จำกัดสำหรับ open source บน Linux, macOS และ Windows
  * [Microsoft IoT Hub](https://azure.microsoft.com/services/iot-hub/) - 8,000 ข้อความต่อวัน
  * [Load Balancer](https://azure.microsoft.com/services/load-balancer/) - 1 IP สาธารณะ (VIP) ที่มีการกระจายโหลดฟรี
  * [Notification Hubs](https://azure.microsoft.com/services/notification-hubs/) - push notifications 1 ล้านครั้ง
  * [Bandwidth](https://azure.microsoft.com/pricing/details/bandwidth/) - ข้อมูลเข้า 15GB (12 เดือน) & ข้อมูลออก 5GB ต่อเดือน
  * [Cosmos DB](https://azure.microsoft.com/services/cosmos-db/) - ที่เก็บข้อมูล 25GB และ 1000 RUs throughput ที่กำหนดไว้
  * [Static Web Apps](https://azure.microsoft.com/pricing/details/app-service/static/) — สร้าง, deploy และโฮสต์แอปแบบ static และ serverless functions พร้อม SSL ฟรี, Authentication/Authorization และ custom domains
  * [Storage](https://azure.microsoft.com/services/storage/) - ที่เก็บข้อมูลไฟล์ LRS หรือ Blob 5GB (12 เดือน)
  * [Cognitive Services](https://azure.microsoft.com/services/cognitive-services/) - AI/ML APIs (Computer Vision, Translator, Face detection, Bots ฯลฯ) พร้อม tier ฟรีที่รวมธุรกรรมจำกัด
  * [Cognitive Search](https://azure.microsoft.com/services/search/#features) - บริการค้นหาและจัดทำดัชนีด้วย AI ฟรีสำหรับ 10,000 เอกสาร
  * [Azure Kubernetes Service](https://azure.microsoft.com/services/kubernetes-service/) - บริการ Kubernetes แบบจัดการ ฟรีสำหรับการจัดการคลัสเตอร์
  * [Event Grid](https://azure.microsoft.com/services/event-grid/) - 100,000 การดำเนินการต่อเดือน
  * รายการทั้งหมดแบบละเอียด - https://azure.microsoft.com/free/

* [Oracle Cloud](https://www.oracle.com/cloud/)
  * คอมพิวต์
     - VM แบบ AMD 2 เครื่อง พร้อม 1/8 OCPU และหน่วยความจำ 1GB ต่อเครื่อง
     - คอร์ Arm-based Ampere A1 4 คอร์ และหน่วยความจำ 24GB ใช้งานได้เป็น VM เดียวหรือสูงสุด 4 VM
     - อินสแตนซ์จะถูกเรียกคืนเมื่อ [ว่างงาน](https://docs.oracle.com/en-us/iaas/Content/FreeTier/freetier_topic-Always_Free_Resources.htm#compute__idleinstances)
  * Block Volume - 2 volumes, รวม 200GB (ใช้สำหรับ compute)
  * Object Storage - 10GB
  * Load balancer - 1 อินสแตนซ์ ความเร็ว 10 Mbps
  * ฐานข้อมูล - 2 DB, ขนาดละ 20GB
  * Monitoring - จุดข้อมูลที่ ingest ได้ 500 ล้านจุด, ดึงข้อมูลได้ 1 พันล้านจุด
  * Bandwidth - ข้อมูลออก 10TB ต่อเดือน, จำกัดความเร็วที่ 50 Mbps บน VM x64, 500 Mbps * จำนวนคอร์บน ARM VM
  * IP สาธารณะ - IPv4 2 รายการสำหรับ VM, IPv4 1 รายการสำหรับ load balancer
  * Notifications - ตัวเลือกการส่ง 1 ล้านครั้งต่อเดือน, ส่งอีเมล 1,000 ฉบับต่อเดือน
  * รายการทั้งหมดแบบละเอียด - https://www.oracle.com/cloud/free/

* [IBM Cloud](https://www.ibm.com/cloud/free/)
  * ฐานข้อมูล Cloudant - ที่เก็บข้อมูล 1GB
  * ฐานข้อมูล Db2 - ที่เก็บข้อมูล 100MB
  * API Connect - 50,000 คำขอ API ต่อเดือน
  * Availability Monitoring - จุดข้อมูล 3 ล้านจุดต่อเดือน
  * Log Analysis - log รายวัน 500MB
  * รายการทั้งหมดแบบละเอียด - https://www.ibm.com/cloud/free/

* [Cloudflare](https://www.cloudflare.com/)
  * [Application Services](https://www.cloudflare.com/plans/) - DNS ฟรีสำหรับโดเมนไม่จำกัด, ป้องกัน DDoS, CDN พร้อม SSL ฟรี, กฎไฟร์วอลล์และกฎหน้า, WAF, Bot Mitigation, Free Unmetered Rate Limiting - 1 กฎต่อโดเมน, การวิเคราะห์, ส่งต่ออีเมล
  * [Zero Trust & SASE](https://www.cloudflare.com/plans/zero-trust-services/) - สูงสุด 50 ผู้ใช้, บันทึกกิจกรรม 24 ชั่วโมง, 3 สถานที่เครือข่าย
  * [Cloudflare Tunnel](https://www.cloudflare.com/products/tunnel/) - สามารถเปิดเผยพอร์ต HTTP ที่รันในเครื่องผ่าน tunnel ไปยัง subdomain สุ่มบน trycloudflare.com โดยใช้ [Quick Tunnels](https://developers.cloudflare.com/cloudflare-one/connections/connect-networks/do-more-with-tunnels/trycloudflare/), ไม่ต้องใช้บัญชีผู้ใช้ ฟีเจอร์เพิ่มเติม (TCP tunnel, Load balancing, VPN) ใน [Zero Trust](https://www.cloudflare.com/products/zero-trust/) Free Plan
  * [Workers](https://developers.cloudflare.com/workers/) - deploy โค้ดแบบ serverless ฟรี บนเครือข่าย Cloudflare ทั่วโลก—100,000 คำขอ/วัน
  * [Workers KV](https://developers.cloudflare.com/kv) - อ่าน 100,000 ครั้ง/วัน, เขียน 1,000 ครั้ง/วัน, ลบ 1,000 ครั้ง/วัน, รายการ 1,000 ครั้ง/วัน, ที่เก็บข้อมูล 1GB
  * [R2](https://developers.cloudflare.com/r2/) - 10GB/เดือน, 1 ล้านการดำเนินการ Class A/เดือน, 10 ล้านการดำเนินการ Class B/เดือน
  * [D1](https://developers.cloudflare.com/d1/) - อ่านแถว 5 ล้านครั้ง/วัน, เขียนแถว 100,000 ครั้ง/วัน, ที่เก็บข้อมูล 1GB
  * [Pages](https://developers.cloudflare.com/pages/) - พัฒนาและ deploy เว็บแอปบนเครือข่าย Cloudflare ที่รวดเร็วและปลอดภัย รองรับ 500 builds/เดือน, 100 custom domains, SSL ในตัว, ที่นั่งไม่จำกัด, deployment ตัวอย่างไม่จำกัด, รองรับ full-stack โดยผสานกับ Cloudflare Workers
  * [Queues](https://developers.cloudflare.com/queues/) - 1 ล้านการดำเนินการต่อเดือน
  * [TURN](https://developers.cloudflare.com/calls/turn/) – ทราฟฟิกขาออกฟรี 1TB/เดือน

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## โซลูชันการบริหารจัดการคลาวด์

* [Brainboard](https://www.brainboard.co) - โซลูชันสำหรับทำงานร่วมกัน เพื่อสร้างและบริหารจัดการโครงสร้างพื้นฐานคลาวด์แบบครบวงจรด้วยภาพ
* [Cloud 66](https://www.cloud66.com/) - ฟรีสำหรับโปรเจกต์ส่วนตัว (รวมเซิร์ฟเวอร์ deployment 1 เครื่อง, เว็บไซต์ static 1 เว็บ) Cloud 66 มีทุกสิ่งที่คุณต้องการในการสร้าง, deploy และขยายแอปพลิเคชันบนคลาวด์ใดก็ได้ โดยไม่ต้องปวดหัวกับ “เรื่องเซิร์ฟเวอร์”
* [Pulumi](https://www.pulumi.com/) — แพลตฟอร์ม infrastructure as code สมัยใหม่ที่ให้คุณใช้ภาษาและเครื่องมือโปรแกรมที่คุ้นเคยเพื่อสร้าง, deploy และจัดการโครงสร้างพื้นฐานคลาวด์
* [terraform.io](https://www.terraform.io/) — Terraform Cloud. ฟรีสำหรับการจัดการ state จากระยะไกลและการทำงานร่วมกันของทีมสูงสุด 500 ทรัพยากร
* [scalr.com](https://scalr.com/) - Scalr คือผลิตภัณฑ์ Terraform Automation และ Collaboration (TACO) ที่ช่วยให้การทำงานร่วมกันและอัตโนมัติบน infrastructure/configuration ที่บริหารโดย Terraform ดีขึ้น รองรับ Terraform CLI เต็มรูปแบบ, ผสาน OPA, และโมเดลคอนฟิกแบบลำดับชั้น ไม่มีค่าใช้จ่าย SSO ใช้งานได้ทุกฟีเจอร์ ฟรีสูงสุด 50 runs/เดือน
* [deployment.io](https://deployment.io) - Deployment.io ช่วยให้นักพัฒนา automate deployment บน AWS ใน tier ฟรี นักพัฒนาหนึ่งคน (single user) สามารถ deploy เว็บไซต์ static, เว็บเซอร์วิส และ environment ได้ไม่จำกัด มี job executions ฟรี 20 ครั้ง/เดือน พร้อม preview และ auto-deploy รวมใน tier ฟรีแล้ว

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## ที่เก็บซอร์สโค้ด

* [Bitbucket](https://bitbucket.org/) — repo Git สาธารณะและส่วนตัวไม่จำกัดสำหรับผู้ใช้สูงสุด 5 คน พร้อม Pipelines สำหรับ CI/CD
* [chiselapp.com](https://chiselapp.com/) — ที่เก็บ Fossil สาธารณะและส่วนตัวไม่จำกัด
* [codebasehq.com](https://www.codebasehq.com/) — 1 โปรเจกต์ฟรี พื้นที่ 100 MB และผู้ใช้ 2 คน
* [Codeberg](https://codeberg.org/) — repo Git สาธารณะและส่วนตัวไม่จำกัดสำหรับโปรเจกต์ฟรีและโอเพนซอร์ส (พร้อมผู้ร่วมงานไม่จำกัด) ขับเคลื่อนโดย [Forgejo](https://forgejo.org/) โฮสต์เว็บไซต์ static ด้วย [Codeberg Pages](https://codeberg.page/) โฮสต์ CI/CD ด้วย [Codeberg's CI](https://docs.codeberg.org/ci/) โฮสต์แปลภาษาโดย [Codeberg Translate](https://translate.codeberg.org/) รวมถึงโฮสต์แพ็กเกจและคอนเทนเนอร์, การจัดการโปรเจกต์ และ Issue Tracking
* [GitGud](https://gitgud.io) — ที่เก็บข้อมูลสาธารณะและส่วนตัวไม่จำกัด ฟรีตลอดไป ขับเคลื่อนโดย GitLab & Sapphire ไม่รวม CI/CD
* [GitHub](https://github.com/) — ที่เก็บสาธารณะและส่วนตัวไม่จำกัด (ผู้ร่วมงานไม่จำกัด) รวม CI/CD, สภาพแวดล้อมพัฒนา, Static Hosting, โฮสต์แพ็กเกจและคอนเทนเนอร์, การจัดการโปรเจกต์ และ AI Copilot
* [gitlab.com](https://about.gitlab.com/) — ที่เก็บ Git สาธารณะและส่วนตัวไม่จำกัด พร้อมผู้ร่วมงานสูงสุด 5 คน รวม CI/CD, Static Hosting, Container Registry, การจัดการโปรเจกต์ และ Issue Tracking
* [framagit.org](https://framagit.org/) — Framagit คือซอฟต์แวร์ forge ของ Framasoft ที่อิงกับ Gitlab รวม CI, Static Pages, Project pages และ Issue tracking
* [heptapod.net](https://foss.heptapod.net/) — Heptapod เป็น fork ที่เป็นมิตรของ GitLab Community Edition ที่รองรับ Mercurial
* [ionicframework.com](https://ionicframework.com/appflow) - repo และเครื่องมือสำหรับพัฒนาแอปด้วย Ionic; พร้อม repo ของ Ionic
* [NotABug](https://notabug.org) — NotABug.org คือแพลตฟอร์มร่วมมือเขียนโค้ดสำหรับซอฟต์แวร์เสรี โครงการที่ใช้ Git เป็นหลัก
* [OSDN](https://osdn.net/) - OSDN.net ให้บริการฟรีสำหรับนักพัฒนาซอฟต์แวร์โอเพนซอร์ส มีที่เก็บ SVN/Git/Mercurial/Bazaar/CVS
  * [Pagure.io](https://pagure.io) — Pagure.io เป็นแพลตฟอร์มการทำงานร่วมกันด้านซอฟต์แวร์โอเพนซอร์สฟรีสำหรับโครงการที่ได้รับอนุญาต FOSS, ใช้ Git
  * [perforce.com](https://www.perforce.com/products/helix-teamhub) — ฟรี 1GB Cloud และที่เก็บ Git, Mercurial หรือ SVN
  * [pijul.com](https://pijul.com/) - ระบบควบคุมเวอร์ชันแบบกระจายฟรีและโอเพนซอร์สแบบไม่จำกัด จุดเด่นคือทฤษฎีของแพตช์ที่ถูกต้อง ทำให้ง่ายต่อการเรียนรู้ ใช้งาน และแจกจ่าย แก้ไขปัญหาหลายอย่างของ git/hg/svn/darcs
  * [plasticscm.com](https://plasticscm.com/) — ฟรีสำหรับบุคคล, OSS, และองค์กรไม่แสวงหากำไร
  * [projectlocker.com](https://projectlocker.com) — โปรเจกต์ส่วนตัวฟรี 1 โปรเจกต์ (Git และ Subversion) พร้อมพื้นที่ 50 MB
  * [RocketGit](https://rocketgit.com) — โฮสติ้ง Repository ด้วย Git มีที่เก็บ Public และ Private ไม่จำกัด
  * [savannah.gnu.org](https://savannah.gnu.org/) - ระบบจัดการพัฒนาและทำงานร่วมกันสำหรับโครงการซอฟต์แวร์เสรี (สำหรับโครงการ GNU)
  * [savannah.nongnu.org](https://savannah.nongnu.org/) - ระบบจัดการพัฒนาและทำงานร่วมกันสำหรับโครงการซอฟต์แวร์เสรี (สำหรับโครงการที่ไม่ใช่ GNU)

**[⬆️ กลับไปด้านบน](#table-of-contents)**

## APIs, Data, and ML

  * [JSONGrid](https://jsongrid.com) - เครื่องมือฟรีสำหรับแสดงผล แก้ไข กรองข้อมูล JSON ที่ซับซ้อนให้อยู่ในรูปแบบตารางที่สวยงาม บันทึกและแชร์ข้อมูล JSON ผ่านลิงก์ได้
  * [Zerosheets](https://zerosheets.com) - เปลี่ยน Google Sheets ของคุณให้เป็น API ที่ทรงพลังสำหรับสร้างต้นแบบ เว็บไซต์ แอป ฯลฯ ได้อย่างรวดเร็ว ฟรี 500 คำขอต่อเดือน
  * [IP.City](https://ip.city) — ฟรี 100 คำขอค้นหาตำแหน่ง IP ต่อวัน
  * [Abstract API](https://www.abstractapi.com) — ชุด API สำหรับใช้งานหลากหลาย เช่น ค้นหาตำแหน่ง IP, ตรวจสอบเพศ, หรือยืนยันอีเมล
  * [Apify](https://www.apify.com/) — แพลตฟอร์ม web scraping และ automation เพื่อสร้าง API สำหรับเว็บไซต์ใดก็ได้และดึงข้อมูล มี scraper สำเร็จรูป, proxy ในตัว, และโซลูชันแบบกำหนดเอง แผนฟรีมีเครดิตแพลตฟอร์ม $5 ต่อเดือน
  * [APITemplate.io](https://apitemplate.io) - สร้างภาพและ PDF อัตโนมัติด้วย API หรือเครื่องมืออัตโนมัติอย่าง Zapier & Airtable โดยไม่ต้องใช้ CSS/HTML แผนฟรีให้ 50 รูป/เดือน และ 3 เทมเพลต
  * [APIToolkit.io](https://apitoolkit.io) - เครื่องมือครบชุดสำหรับเข้าใจการทำงานของ API และ backend พร้อมการตรวจสอบและตรวจสอบข้อตกลง API อัตโนมัติ แผนฟรีรองรับเซิร์ฟเวอร์ที่มีสูงสุด 10,000 คำขอต่อวัน
  * [APIVerve](https://apiverve.com) - เข้าถึง API กว่า 120+ ตัวได้ฟรี คุณภาพสูง สม่ำเสมอ และน่าเชื่อถือ แผนฟรีรองรับ 50 API Token ต่อเดือน (อาจถูกปิด, 2025-06-25)
  * [Arize AI](https://arize.com/) - เครื่องมือสังเกตการณ์ ML สำหรับการตรวจสอบโมเดลและหาสาเหตุของปัญหา เช่น คุณภาพข้อมูลและการเปลี่ยนแปลงประสิทธิภาพ ฟรีสูงสุด 2 โมเดล
  * [Maxim AI](https://getmaxim.ai/) - จำลอง, ประเมินผล, และสังเกตการณ์ AI agent ของคุณ Maxim เป็นแพลตฟอร์มประเมินและสังเกตการณ์ครบวงจร ช่วยให้ทีมปล่อย AI agent ได้อย่างน่าเชื่อถือและเร็วขึ้นกว่า 5 เท่า ฟรีตลอดไปสำหรับนักพัฒนาอิสระและทีมเล็ก (3 ที่นั่ง)
  * [Beeceptor](https://beeceptor.com) - สร้าง mock rest API ได้ในไม่กี่วินาที, ตอบสนอง API ปลอมและอื่น ๆ อีกมากมาย ฟรี 50 คำขอต่อวัน, dashboard สาธารณะ, endpoint เปิด (ใครก็ได้ที่มีลิงก์ dashboard ดู submission และคำตอบได้)
  * [BigDataCloud](https://www.bigdatacloud.com/) - API ฟรี (แบบไม่จำกัดหรือสูงสุด 10K-50K/เดือน) สำหรับเว็บสมัยใหม่เช่น IP Geolocation, Reverse Geocoding, Networking Insights, Email และ Phone Validation, Client Info และอื่น ๆ อีกมากมาย
  * [Browse AI](https://www.browse.ai) — ดึงข้อมูลและตรวจสอบข้อมูลบนเว็บ ฟรี 1,000 เครดิตต่อเดือน เท่ากับ 1,000 คำขอพร้อมกัน
  * [BrowserCat](https://www.browsercat.com) - Headless browser API สำหรับ automation, scraping, ให้ AI agent เข้าถึงเว็บ, สร้างภาพ/pdf ฯลฯ แผนฟรีมี 1,000 คำขอต่อเดือน
  * [Calendarific](https://calendarific.com) - API ข้อมูลวันหยุดสาธารณะสำหรับกว่า 200 ประเทศ แผนฟรีมี 500 คำขอต่อเดือน
  * [Canopy](https://www.canopyapi.co/) - GraphQL API สำหรับข้อมูลสินค้า ค้นหา และหมวดหมู่ของ Amazon.com แผนฟรีมี 100 คำขอต่อเดือน
  * [Clarifai](https://www.clarifai.com) — Image API สำหรับตรวจจับและจดจำใบหน้าแบบกำหนดเอง สามารถฝึกโมเดล AI ได้ แผนฟรีมี 1,000 คำขอต่อเดือน
  * [Cloudmersive](https://cloudmersive.com/) — แพลตฟอร์ม Utility API พร้อมเข้าถึงไลบรารี API ขนาดใหญ่ เช่น Document Conversion, Virus Scanning ฯลฯ ฟรี 600 คำขอ/เดือน เฉพาะโซน North America AZ ไฟล์สูงสุด 2.5MB
  * [Colaboratory](https://colab.research.google.com) — โน้ตบุ๊ก Python บนเว็บฟรีพร้อม Nvidia Tesla K80 GPU
  * [CometML](https://www.comet.com/site/) - แพลตฟอร์ม MLOps สำหรับติดตามการทดลอง, จัดการโมเดล, model registry และ data lineage ครบวงจร ตั้งแต่การฝึกจนถึง production ฟรีสำหรับบุคคลและนักวิชาการ
  * [Commerce Layer](https://commercelayer.io) - Composable commerce API สำหรับสร้าง จัดการ และดูแลออเดอร์จาก front end ใดก็ได้ แผน developer ฟรี 100 ออเดอร์ต่อเดือน และสูงสุด 1,000 SKU
  * [Composio](https://composio.dev/) - แพลตฟอร์มอินทิเกรตสำหรับ AI Agent และ LLMs เชื่อมต่อกับเครื่องมือกว่า 200+ ทั่วอินเทอร์เน็ตแบบเอเย่นต์
  * [Conversion Tools](https://conversiontools.io/) - แปลงไฟล์ออนไลน์สำหรับเอกสาร, รูปภาพ, วิดีโอ, เสียง และ eBooks มี REST API ไลบรารีสำหรับ Node.js, PHP, Python รองรับไฟล์สูงสุด 50 GB (สำหรับแผนเสียเงิน) แผนฟรีจำกัดไฟล์ 20MB และ 30 ไฟล์/วัน 300 ไฟล์/เดือน
  * [Country-State-City Microservice API](https://country-state-city.rebuscando.info/) - API และ Microservice สำหรับข้อมูลประเทศ ภูมิภาค จังหวัด เมือง รหัสไปรษณีย์ ฯลฯ แผนฟรีสูงสุด 100 คำขอต่อวัน
  * [Coupler](https://www.coupler.io/) - เครื่องมือเชื่อมต่อข้อมูลระหว่างแอป สร้าง dashboard และรายงานสด, แปลงและจัดการค่า, เก็บและสำรองข้อมูลเชิงลึก แผนฟรีจำกัดผู้ใช้ 1 คน การเชื่อมต่อ, แหล่งข้อมูล, และปลายทางข้อมูล 1 อย่าง ต้องรีเฟรชข้อมูลเอง
  * [CraftMyPDF](https://craftmypdf.com) - สร้างเอกสาร PDF อัตโนมัติจากเทมเพลตที่ใช้ซ้ำได้ด้วย editor แบบลากวางและ API ง่าย ๆ แผนฟรี 100 PDF/เดือน และ 3 เทมเพลต
  * [Crawlbase](https://crawlbase.com/) — ดึงข้อมูลและ scrape เว็บไซต์โดยไม่ต้องใช้ proxy, โครงสร้างพื้นฐาน หรือ browser เราช่วยแก้ captcha และป้องกันการ block ฟรี 1,000 คำขอแรก
  * [CurlHub](https://curlhub.io) — Proxy service สำหรับตรวจสอบและดีบัก API call แผนฟรี 10,000 คำขอต่อเดือน
  * [CurrencyScoop](https://currencyscoop.com) - API ข้อมูลอัตราแลกเปลี่ยนแบบเรียลไทม์สำหรับแอป fintech แผนฟรี 5,000 คำขอต่อเดือน
  * [Cube](https://cube.dev/) - Cube ช่วยให้นักพัฒนาและวิศวกรข้อมูลเข้าถึงข้อมูลจาก data store สมัยใหม่ จัดระเบียบ และส่งต่อไปยังแอปต่าง ๆ ใช้ Cube Cloud ได้เร็วที่สุด แผนฟรีจำกัด 1,000 คำขอ/วัน
  * [Data Dead Drop](https://datadeaddrop.com) - แชร์ไฟล์ฟรีและง่าย ข้อมูลจะทำลายตัวเองหลังจากถูกเข้าถึง อัปโหลดและดาวน์โหลดผ่านเบราว์เซอร์หรือ command line client
  * [Data Fetcher](https://datafetcher.com) - เชื่อม Airtable กับแอปหรือ API อื่น ๆ โดยไม่ต้องเขียนโค้ด อินเทอร์เฟซคล้าย Postman สำหรับรัน API request ใน Airtable มี integration สำเร็จรูปมากมาย แผนฟรี 100 ครั้ง/เดือน
  * [Dataimporter.io](https://www.dataimporter.io) - เครื่องมือเชื่อมต่อ, ทำความสะอาด, และนำเข้าข้อมูลสู่ Salesforce แผนฟรีรองรับ 20,000 records/เดือน
  * [Datalore](https://datalore.jetbrains.com) - Python notebook โดย Jetbrains ให้พื้นที่ 10 GB และ 120 ชั่วโมง runtime ต่อเดือน
  * [Data Miner](https://dataminer.io/) - ส่วนขยายเบราว์เซอร์ (Google Chrome, MS Edge) สำหรับดึงข้อมูลจากเว็บเป็น CSV หรือ Excel แผนฟรี 500 หน้า/เดือน
  * [Datapane](https://datapane.com) - API สำหรับสร้าง interactive report ใน Python และ deploy script Python กับ Jupyter Notebook เป็น self-service tool
  * [DB-IP](https://db-ip.com/api/free) - API ฟรีสำหรับ IP geolocation 1,000 คำขอ/IP/วัน lite database ภายใต้ CC-BY 4.0 License ให้ดาวน์โหลดฟรีด้วย
  * [DB Designer](https://www.dbdesigner.net/) — เครื่องมือออกแบบและสร้าง schema ฐานข้อมูลบน cloud แผนฟรีเริ่มต้นได้ 2 แบบโมเดล และ 10 ตารางต่อโมเดล
  * [DeepAR](https://developer.deepar.ai) — ฟิลเตอร์ใบหน้า AR สำหรับทุกแพลตฟอร์มด้วย SDK เดียว แผนฟรีรองรับผู้ใช้งานสูงสุด 10 คนต่อเดือน (MAU) และติดตามใบหน้าได้ 4 หน้า
  * [Deepnote](https://deepnote.com) - โน้ตบุ๊ก data science ใหม่ รองรับ Jupyter, ทำงานร่วมกันแบบ real-time และรันบนคลาวด์ แผนฟรีมีโปรเจกต์ส่วนตัวไม่จำกัด, เครื่องพื้นฐาน (5GB RAM, 2vCPU) ไม่จำกัด, และทีมสูงสุด 3 คน
  * [Disease.sh](https://disease.sh/) — API ฟรีสำหรับข้อมูลโควิด-19 ที่แม่นยำ เพื่อสร้างแอปที่เกี่ยวข้อง
  * [Doczilla](https://www.doczilla.app/) — SaaS API สำหรับสร้าง screenshot หรือ PDF จากโค้ด HTML/CSS/JS โดยตรง แผนฟรี 250 เอกสาร/เดือน
  * [Doppio](https://doppio.sh/) — API จัดการและเก็บ PDF กับ Screenshot แบบ private ด้วยเทคโนโลยี rendering ชั้นนำ แผนฟรี 400 PDF และ Screenshot ต่อเดือน
  * [drawDB](https://drawdb.app/) — เครื่องมือวาดไดอะแกรมฐานข้อมูลออนไลน์ฟรีและโอเพนซอร์ส ไม่ต้องสมัครสมาชิก
  * [dreamfactory.com](https://dreamfactory.com/) — แบ็กเอนด์ REST API โอเพนซอร์สสำหรับแอปมือถือ เว็บ และ IoT เชื่อมต่อ SQL/NoSQL, ที่เก็บไฟล์ หรือบริการภายนอกใดก็ได้ แล้วสร้าง REST API พร้อมเอกสารและจัดการผู้ใช้ทันที
  * [Duply.co](https://duply.co) — สร้างภาพไดนามิกผ่าน API & URL ออกแบบเทมเพลตครั้งเดียวแล้วใช้ซ้ำ แผนฟรีให้ 20 เครดิต
  * [DynamicDocs](https://advicement.io) - สร้าง PDF ด้วย JSON to PDF API บนเทมเพลต LaTeX แผนฟรี 50 API call/เดือน และเข้าถึงคลังเทมเพลต
  * [Efemarai](https://efemarai.com) - แพลตฟอร์มทดสอบและดีบักโมเดล ML และข้อมูล แสดง computational graph ฟรีสำหรับใช้งาน local
  * [ERD Lab](https://www.erdlab.io) — เครื่องมือ ERD บนคลาวด์ฟรีสำหรับนักพัฒนา ทดลองใช้ฟรี 2 โปรเจกต์ โปรเจกต์ละ 10 ตาราง
  * [ExtendsClass](https://extendsclass.com/rest-client-online.html) - HTTP client บนเว็บฟรีสำหรับส่ง HTTP request
  * [Export SDK](https://exportsdk.com) - PDF generator API พร้อม editor แบบลากวาง มี SDK และ integration แบบไม่ต้องโค้ด แผนฟรี 250 หน้า/เดือน, ผู้ใช้ไม่จำกัด, เทมเพลต 3 แบบ
  * [file.coffee](https://file.coffee/) - แพลตฟอร์มสำหรับเก็บไฟล์สูงสุด 15MB/ไฟล์ (30MB/ไฟล์เมื่อลงทะเบียน)
  * [Financial Data](https://financialdata.net/) - API ข้อมูลตลาดหุ้นและการเงิน แผนฟรี 300 คำขอต่อวัน
  * [FormatJSONOnline.com](https://formatjsononline.com) - เครื่องมือจัดรูปแบบ, ตรวจสอบ, เปรียบเทียบ และย่อ JSON ฟรีบนเบราว์เซอร์
  * [FraudLabs Pro](https://www.fraudlabspro.com) — ตรวจสอบการทุจริตการชำระเงินด้วยบัตรเครดิตของออเดอร์ REST API จะตรวจจับลักษณะทุจริตทุกแบบตามพารามิเตอร์ของออเดอร์ แผน Micro ฟรี 500 รายการ/เดือน
  * [GeoDataSource](https://www.geodatasource.com) — บริการค้นหาตำแหน่งโดยใช้ชื่อเมืองและพิกัดละติจูด/ลองจิจูด API ฟรีสูงสุด 500 ครั้ง/เดือน
  * [Geolocated.io](https://geolocated.io) — API Geolocation IP พร้อมเซิร์ฟเวอร์หลายทวีป แผนฟรี 2,000 คำขอ/วัน
  * [Glitterly](https://glitterly.app/) - สร้างภาพไดนามิกจากเทมเพลตแบบโปรแกรม มี REST API และ integration แบบไม่ต้องโค้ด แผนฟรี 50 รูป/เดือน, เทมเพลต 5 แบบ
  * [Hex](https://hex.tech/) - แพลตฟอร์ม data สำหรับโน้ตบุ๊ก, data app และ knowledge libraries ร่วมมือกัน แผน community ฟรี สูงสุด 5 โปรเจกต์
  * [Hook0](https://www.hook0.com/) - Webhooks-as-a-service (WaaS) โอเพนซอร์สสำหรับให้บริการ webhook ในผลิตภัณฑ์ออนไลน์ ส่งเหตุการณ์สูงสุด 100 ครั้ง/วัน พร้อมเก็บประวัติ 7 วัน ฟรี
  * [Hoppscotch](https://hoppscotch.io) - API request builder ฟรี สวย และเร็ว
  * [huggingface.co](https://huggingface.co) - สร้าง ฝึก และ deploy โมเดล NLP สำหรับ Pytorch, TensorFlow และ JAX ฟรีสูงสุด 30,000 ตัวอักษร/เดือน
  * [Hybiscus](https://hybiscus.dev/) - สร้างรายงาน PDF ด้วย API แบบ declarative ง่าย ๆ แผนทดลองใช้ฟรี 14 วัน มีรายงานหน้าเดียว 50 ชิ้น พร้อมปรับแต่งสีและฟอนต์
  * [Invantive Cloud](https://cloud.invantive.com/) — เข้าถึงแพลตฟอร์ม (คลาวด์) กว่า 70 แห่ง เช่น Exact Online, Twinfield, ActiveCampaign หรือ Visma ด้วย Invantive SQL หรือ OData4 (เช่น Power BI หรือ Power Query) รองรับ replication และแลกเปลี่ยนข้อมูล แผนฟรีสำหรับนักพัฒนาและที่ปรึกษา ฟรีสำหรับบางแพลตฟอร์มโดยจำกัดปริมาณข้อมูล
  * [ipaddress.sh](https://ipaddress.sh) — บริการง่าย ๆ สำหรับดู public IP address ใน [รูปแบบต่าง ๆ](https://about.ipaddress.sh/)
  * [ip-api](https://ip-api.com) — API Geolocation IP ฟรีสำหรับใช้ไม่เชิงพาณิชย์ ไม่ต้องใช้ API key จำกัด 45 คำขอ/นาที/IP สำหรับแผนฟรี
  * [ipbase.com](https://ipbase.com) - API Geolocation IP - แผนฟรีตลอดชีพ 150 คำขอ/เดือน
  * [IP Geolocation](https://ipgeolocation.io/) — API Geolocation IP - แผนฟรีตลอดชีพสำหรับนักพัฒนา จำกัด 1,000 คำขอ/วัน
  * [IP Geolocation API](https://www.abstractapi.com/ip-geolocation-api) — IP Geolocation API จาก Abstract - ฟรี 1,000 คำขอ
  * [IPLocate](https://www.iplocate.io) — API Geolocation IP ฟรีสูงสุด 1,000 คำขอ/วัน รวมถึงตรวจจับ proxy/VPN/hosting, ASN, IP to Company และอื่น ๆ มีฐานข้อมูล IP to Country และ IP to ASN สำหรับดาวน์โหลดฟรีในรูปแบบ CSV หรือ MMDB
  * [IP2Location](https://www.ip2location.com) — บริการ IP geolocation แบบ freemium มี LITE database ให้ดาวน์โหลดฟรี สามารถนำเข้าฐานข้อมูลไปใช้ในเซิร์ฟเวอร์เพื่อ query เมือง, พิกัด, ISP ได้
  * [IP2Location.io](https://www.ip2location.io/) — API geolocation IP แบบ freemium รวดเร็วและน่าเชื่อถือ ข้อมูลเมือง พิกัด ISP ฯลฯ แผนฟรี 50,000 เครดิต/เดือน มี WHOIS และ hosted domain lookup ฟรี 500 ครั้ง/เดือน ดูรายละเอียดโดเมนและหาโดเมนที่โฮสต์บน IP เฉพาะ อัปเกรดแผนเพื่อฟีเจอร์เพิ่มเติม
  * [ipapi](https://ipapi.co/) - API หาตำแหน่ง IP โดย Kloudend, Inc - Geolocation API เชื่อถือได้บน AWS ที่องค์กร Fortune 500 ไว้วางใจ แผนฟรี 30,000 คำขอ/เดือน (1,000/วัน) ไม่ต้องสมัคร
  * [ipapi.is](https://ipapi.is/) - API IP Address สำหรับนักพัฒนาโดยนักพัฒนา พร้อมความสามารถ Hosting Detection ดีที่สุด แผนฟรี 1,000 ครั้ง ไม่ต้องสมัคร
  * [IPinfo](https://ipinfo.io/) — API ข้อมูล IP address รวดเร็ว แม่นยำ ฟรีสูงสุด 50,000/เดือน มีข้อมูล geolocation, บริษัท, เครือข่าย, ช่วง IP, โดเมน, ผู้ติดต่อ abuse ฯลฯ ทดลองทุก API ที่เสียเงินได้ฟรี
  * [IPQuery](https://ipquery.io) — IP API ไม่จำกัดสำหรับนักพัฒนา ไม่มีข้อจำกัดอัตรา/ราคา
  * [IPTrace](https://iptrace.io) — API ง่าย ๆ สำหรับข้อมูล geolocation IP เชื่อถือได้ พร้อม 50,000 ฟรี lookup ต่อเดือน
  * [JSON2Video](https://json2video.com) - API ตัดต่อวิดีโอเพื่อวิดีโอการตลาดและโซเชียลอัตโนมัติ ใช้งานแบบโปรแกรมหรือไม่ต้องโค้ด
  * [JSON IP](https://getjsonip.com) — ส่งคืน Public IP address ของ client ที่ร้องขอ ไม่ต้องสมัครสำหรับแผนฟรี รองรับ CORS ขอข้อมูลได้จาก JS ฝั่ง client โดยตรง เหมาะกับการมอนิเตอร์ IP client/server ที่เปลี่ยน ไม่จำกัดคำขอ
  * [JSON Serve](https://jsonserve.com/) — บริการฟรีสำหรับเก็บวัตถุ JSON และใช้ JSON นั้นเป็น REST API ในแอปของคุณ
  * [JSONing](https://jsoning.com/api/) — สร้าง fake REST API จากวัตถุ JSON ปรับแต่ง HTTP status, header, และ response body ได้
  * [konghq.com](https://konghq.com/) — Marketplace API และเครื่องมือ API ส่วนตัว/สาธารณะทรงพลัง แผนฟรีบางฟีเจอร์เช่น monitoring, alert, และ support จะถูกจำกัด
  * [Kreya](https://kreya.app) — gRPC GUI client ฟรีสำหรับเรียกและทดสอบ gRPC API สามารถนำเข้า API ผ่าน server reflection
  * [Lightly](https://www.lightly.ai/) — พัฒนาโมเดล machine learning ให้ดีขึ้นด้วยข้อมูลที่ใช่ ใช้ dataset ได้สูงสุด 1,000 ตัวอย่างฟรี
  * [LoginLlama](https://loginllama.app) - API ความปลอดภัยการล็อกอิน ตรวจจับการเข้าสู่ระบบที่น่าสงสัยและแจ้งลูกค้า ฟรี 1,000 ล็อกอิน/เดือน
  * [MailboxValidator](https://www.mailboxvalidator.com) — บริการตรวจสอบอีเมลโดยเชื่อมต่อกับ mail server จริงเพื่อยืนยันอีเมล แผน API ฟรี 100 การตรวจสอบ/เดือน
  * [Market Data API](https://www.marketdata.app) - ให้ข้อมูลการเงินแบบเรียลไทม์และย้อนหลังสำหรับหุ้น, ออปชั่น, กองทุนรวม ฯลฯ แผน Free Forever API ขอข้อมูลได้ฟรี 100 ครั้ง/วัน
  * [Meteosource Weather API](https://www.meteosource.com/) — API สภาพอากาศทั่วโลกสำหรับข้อมูลอากาศปัจจุบันและพยากรณ์อากาศ พยากรณ์อากาศอิงจากการผสมผสานแบบ Machine Learning จากโมเดลอากาศหลายตัวเพื่อความแม่นยำมากขึ้น แผนฟรีให้ 400 ครั้งต่อวัน
  * [microlink.io](https://microlink.io/) – เปลี่ยนเว็บไซต์ใดๆ ให้กลายเป็นข้อมูล เช่น การทำให้ metatag เป็นมาตรฐาน แสดงลิงก์ตัวอย่างสวยงาม ความสามารถในการดึงข้อมูล หรือบริการถ่ายภาพหน้าจอ ฟรี 50 คำขอต่อวัน
  * [Mindee](https://developers.mindee.com) – Mindee คือซอฟต์แวร์ OCR อันทรงพลังและแพลตฟอร์ม API-first ที่ช่วยให้นักพัฒนาทำงานอัตโนมัติในแอปพลิเคชัน ด้วยการมาตรฐานชั้นประมวลผลเอกสารผ่านการรู้จำข้อมูลสำคัญโดยใช้ Computer Vision และ Machine Learning แผนฟรีให้ 500 หน้าต่อเดือน
  * [Mintlify](https://mintlify.com) — มาตรฐานใหม่สำหรับเอกสาร API มี UI สวยงาม ดูแลรักษาง่าย ค้นหาในแอป และ Playground แบบโต้ตอบ ฟรีสำหรับ 1 ผู้แก้ไข
  * [MockAPI](https://www.mockapi.io/) — MockAPI เป็นเครื่องมือที่ช่วยให้คุณจำลอง API ได้อย่างรวดเร็ว สร้างข้อมูลตามต้องการ และดำเนินการผ่าน RESTful interface เหมาะสำหรับงานต้นแบบ/ทดสอบ/เรียนรู้ ฟรี 1 โปรเจกต์/2 ทรัพยากรต่อโปรเจกต์
  * [Mockfly](https://www.mockfly.dev/) — Mockfly เป็นเครื่องมือพัฒนาสำหรับ Mock API และ Feature Flag Management ที่เชื่อถือได้ สร้างและควบคุม Mock API ได้อย่างรวดเร็วด้วยอินเทอร์เฟซที่เข้าใจง่าย แผนฟรีให้ 500 คำขอต่อวัน
  * [Mocki](https://mocki.io) - เครื่องมือสร้าง Mock GraphQL และ REST API ที่ซิงก์กับ GitHub repository REST API ทั่วไปสามารถพัฒนาและใช้งานฟรีโดยไม่ต้องสมัครสมาชิก
  * [Mocko.dev](https://mocko.dev/) — Proxy API ของคุณ เลือก endpoint ที่ต้องการ mock ใน cloud และตรวจสอบ traffic ได้ฟรี ช่วยเร่งพัฒนาซอฟต์แวร์และการทดสอบ integration
  * [Mocky](https://designer.mocky.io/) - เว็บแอปง่ายๆ สำหรับสร้าง HTTP response แบบกำหนดเองเพื่อจำลอง HTTP request มี [open source](https://github.com/julien-lafont/Mocky) ด้วย
  * [Mock N Roll](https://mpcknroll.me/) - บริการ Mocks API ฟรี—เครื่องมือทรงพลังสำหรับจำลอง API response จริงโดยไม่มีดีเลย์ฝั่ง backend เหมาะสำหรับ frontend dev, QA, DevOps [repo](https://github.com/haerulmuttaqin/mocknroll-web)
  * [microenv.com](https://microenv.com) —  สร้าง REST API ปลอมสำหรับนักพัฒนา พร้อมฟีเจอร์ generate code และแอปใน docker container
  * [Multi-Exit IP Address Checker](https://ip.alstra.ca/) —  เครื่องมือตรวจสอบ IP address exit หลาย node ฟรีและใช้งานง่าย เข้าใจว่าคุณปรากฏตัวต่อภูมิภาค/บริการต่างๆ อย่างไร เหมาะสำหรับทดสอบ DNS splitting rules เช่น Control D
  * [Namekit](https://namekit.app/) - ค้นหาโดเมนด้วย AI – หาชื่อที่ว่างและราคามาตรฐานได้ทันที ฟรี ค้นหาต่อวัน
  * [News API](https://newsapi.org) — ค้นหาข่าวบนเว็บด้วยโค้ดและรับผลลัพธ์ JSON นักพัฒนาใช้ฟรี 100 คำขอต่อวัน บทความดีเลย์ 24 ชม.
  * [numlookupapi.com](https://numlookupapi.com) - API ตรวจสอบหมายเลขโทรศัพท์ฟรี - 100 คำขอ/เดือน
  * [OCR.Space](https://ocr.space/) — OCR API แปลงภาพและไฟล์ pdf เป็นข้อความในรูปแบบ JSON ฟรี 25,000 คำขอต่อเดือน ขนาดไฟล์ไม่เกิน 1MB
  * [OpenAPI3 Designer](https://openapidesigner.com/) — สร้าง OpenAPI 3 definitions แบบภาพได้ฟรี
  * [parsehub.com](https://parsehub.com/) — ดึงข้อมูลจากเว็บไซต์ไดนามิก เปลี่ยนเว็บไซต์เป็น API ฟรี 5 โปรเจกต์
  * [Parseur](https://parseur.com) — 20 หน้าฟรี/เดือน: ดึงข้อมูลจาก PDF, อีเมล ขับเคลื่อนด้วย AI ใช้ API ได้เต็มที่
  * [PDFBolt](https://pdfbolt.com) - API สร้าง PDF เน้นความเป็นส่วนตัว มีเอกสารแนว Stripe ฟรี 500 การแปลง PDF ต่อเดือน
  * [pdfEndpoint.com](https://pdfendpoint.com) - แปลง HTML หรือ URL เป็น PDF ผ่าน API ได้ง่ายๆ ฟรี 100 การแปลงต่อเดือน
  * [PDF-API.io](https://pdf-api.io) - PDF Automation API, ตัวแก้ไข template แบบภาพ, แปลง HTML เป็น PDF, เชื่อมโยงข้อมูล, เรนเดอร์ PDF ผ่าน API แผนฟรีให้ 1 template, 100 PDF/เดือน
  * [Pixela](https://pixe.la/) - บริการฐานข้อมูล daystream ฟรี ใช้งานผ่าน API ทั้งหมด แสดงผลด้วย heatmap และกราฟเส้น
  * [Postman](https://postman.com) — ทำงานง่ายขึ้น สร้าง API ได้เร็วขึ้นด้วย Postman แพลตฟอร์มสำหรับพัฒนา API ใช้แอป Postman ฟรีตลอดไป ฟีเจอร์คลาวด์ฟรีตลอดไปในบางขีดจำกัด
  * [Insomnia](https://insomnia.rest) - API client แบบ open-source สำหรับออกแบบและทดสอบ API รองรับ REST และ GraphQL
  * [PrefectCloud](https://www.prefect.io/cloud/) — แพลตฟอร์มครบวงจรสำหรับ automation ข้อมูล แผนฟรีมี 5 workflows และ 500 นาที serverless compute/เดือน
  * [Preset Cloud](https://preset.io/) - บริการ Apache Superset แบบโฮสต์ ฟรีตลอดไปสำหรับทีมไม่เกิน 5 คน มี dashboard, chart ไม่จำกัด, ตัวสร้าง chart แบบ no-code และ SQL editor แบบร่วมมือ
  * [PromptLoop](https://www.promptloop.com/) - PromptLoop ทำ scraping ข้อมูลเว็บด้วย AI ได้ง่ายกว่า 10 เท่า ประหยัดเวลา 85%+ ทำงานได้ 4 เท่าเร็วขึ้น มี REST API endpoint สำหรับงานค้นคว้า 1,000 เครดิตแรกฟรีต่อเดือน
  * [Public-Apis Github Repo](https://github.com/public-apis/public-apis) — รายชื่อ Public API ฟรี
  * [Rapidapi](https://rapidapi.com/) - ศูนย์กลาง API ใหญ่ที่สุดในโลก นักพัฒนาหลายล้านคนค้นหาและเชื่อมต่อกับ API นับพัน พัฒนา API พร้อมตัวอย่างและ challenge ให้สนุก
  * [RequestBin.com](https://requestbin.com) — สร้าง endpoint ฟรีเพื่อรับ HTTP requests ทุก request จะถูกบันทึก payload และ header เพื่อใช้ดูผลจาก webhook และบริการอื่นๆ
  * [reqres.in](https://reqres.in) - REST API ฟรีที่พร้อมตอบกลับ AJAX request ของคุณ
  * [Roboflow](https://roboflow.com) - สร้างและ deploy โมเดล computer vision ส่วนตัวได้โดยไม่ต้องมีประสบการณ์ ML ฟรี 30 เครดิตต่อเดือน
  * [ROBOHASH](https://robohash.org/) - บริการสร้างภาพยูนีคและเท่ๆ จากข้อความใดก็ได้
  * [Scraper's Proxy](https://scrapersproxy.com) — HTTP proxy API สำหรับ scraping ใช้ scrape แบบไม่เปิดเผยตัวตน ฟรี 100 ครั้งแรก/เดือน รวม Javascript rendering (ขอเพิ่มได้หากติดต่อซัพพอร์ต)
  * [ScrapingAnt](https://scrapingant.com/) — Chrome scraping API แบบ headless และ proxy ฟรี ตรวจสอบ proxy, render JavaScript, หมุน proxy, หลบ CAPTCHA ฟรี 10,000 เครดิต API
  * [Simplescraper](https://simplescraper.io) — trigger webhook หลังแต่ละ operation แผนฟรีมี 100 cloud scrape credits
  * [Select Star](https://www.selectstar.com/) - แพลตฟอร์มค้นหาข้อมูลอัจฉริยะ วิเคราะห์และจัดเอกสารข้อมูลอัตโนมัติ ฟรี light tier มี 2 Data Source, สูงสุด 1,000 Table และ 25 ผู้ใช้
  * [Sheetson](https://sheetson.com) - เปลี่ยน Google Sheets เป็น RESTful API ได้ทันที แผนฟรีรวม 1,000 แถว/ชีท
  * [Shipyard](https://www.shipyardapp.com) — แพลตฟอร์ม orchestration ข้อมูลแบบ low-code บนคลาวด์ ผสมระหว่าง template low-code และโค้ดคุณเอง (Python, Node.js, Bash, SQL) แผนฟรีนักพัฒนาให้ 10 ชั่วโมง runtime/เดือน/คน
  * [Siterelic](https://siterelic.com/) - API สำหรับถ่ายภาพหน้าจอ ตรวจสอบเว็บไซต์ สแกน TLS, lookup DNS, ทดสอบ TTFB ฯลฯ แผนฟรี 100 คำขอ/เดือน
  * [SerpApi](https://serpapi.com/) - API ดึงข้อมูล search engine แบบ real-time ส่งคืน JSON สำหรับ Google, YouTube, Bing, Baidu, Walmart ฯลฯ แผนฟรี 100 คำขอ/เดือน
  * [SmartParse](https://smartparse.io) - แพลตฟอร์มย้ายข้อมูลและ CSV to API ที่ประหยัดเวลาและต้นทุน Free tier 300 Processing Units/เดือน, อัพโหลดผ่านเบราเซอร์, กักกันข้อมูล, Circuit breakers, Job Alerts
  * [Sofodata](https://www.sofodata.com/) - สร้าง RESTful API จากไฟล์ CSV อย่างปลอดภัย อัปโหลด CSV และเข้าถึงข้อมูลผ่าน API ได้ทันที แผนฟรี 2 API, 2,500 คำขอ/เดือน ไม่ต้องใช้บัตรเครดิต
  * [Sqlable](https://sqlable.com/) - SQL tools ออนไลน์ฟรี เช่น SQL formatter, validator, regex tester, generator ข้อมูลปลอม และ playground ฐานข้อมูล
  * [Stoplight](https://stoplight.io/) - Saas สำหรับออกแบบและเขียนเอกสาร API ร่วมกัน แผนฟรีมีเครื่องมือ design, mock, document ฟรี
  * [Supportivekoala](https://supportivekoala.com/) — สร้างภาพอัตโนมัติตาม input ด้วย template แผนฟรีสร้างภาพได้ 50 ภาพ/เดือน
  * [Svix](https://www.svix.com/) - Webhooks as a Service ส่งข้อความได้สูงสุด 50,000 ข้อความ/เดือน ฟรี
  * [Tavily AI](https://tavily.com/) - API สำหรับค้นหาออนไลน์ insight รวดเร็วและวิจัยครอบคลุม พร้อมความสามารถจัดระเบียบผลวิจัย 1,000 คำขอ/เดือน สำหรับ Free tier ไม่ต้องใช้บัตรเครดิต
  * [The IP API](https://theipapi.com/) - IP Geolocation API ฟรี 1,000 คำขอ/วัน ให้ข้อมูลประเทศ เมือง ภูมิภาค ฯลฯ
  * [TinyMCE](https://www.tiny.cloud) - API แก้ไข rich text ฟีเจอร์หลักใช้ฟรีไม่จำกัด
  * [Tomorrow.io Weather API](https://www.tomorrow.io/weather-api/) - มีแผน API สภาพอากาศฟรี พยากรณ์แม่นยำแบบเรียลไทม์ ครอบคลุมทั่วโลก ข้อมูลย้อนหลังและการตรวจสอบสภาพอากาศ
  * [Treblle](https://www.treblle.com) - Treblle ช่วยทีมสร้าง ส่งมอบ และควบคุม API พร้อม log, observability, เอกสาร และ debugging ขั้นสูง ใช้ฟีเจอร์ทั้งหมดฟรี จำกัด 250,000 คำขอต่อเดือน
  * [UniRateAPI](https://unirateapi.com) – อัตราแลกเปลี่ยนแบบเรียลไทม์สำหรับเงิน 590+ สกุลและคริปโต ฟรี API call ไม่จำกัด เหมาะสำหรับนักพัฒนาและแอปการเงิน
  * [vatcheckapi.com](https://vatcheckapi.com) - API ตรวจสอบ VAT ฟรี 150 ครั้ง/เดือน
  * [WeatherXu](https://weatherxu.com/) — ข้อมูลอากาศทั่วโลกแบบเรียลไทม์ พยากรณ์รายชั่วโมง-วัน แจ้งเตือนสภาพอากาศทาง API ใช้ AI และ ML วิเคราะห์โมเดลอากาศหลายตัวเพื่อความแม่นยำ แผนฟรี 10,000 คำขอ/เดือน
  * [Webhook Store](https://www.openwebhook.io) - เครื่องมือเก็บ webhook จาก third-party และดีบั๊กบน localhost (แนว ngrok) Open source และ self-host ฟรีโดเมนส่วนตัว *username*.github.webhook.store, โดเมนสาธารณะ *anything*.webhook.store
  * [WebScraping.AI](https://webscraping.ai) - API ขูดเว็บพร้อม parsing, Chrome rendering, proxy ฟรี 2,000 คำขอ/เดือน
  * [Weights & Biases](https://wandb.ai) — แพลตฟอร์ม MLOps สำหรับนักพัฒนา สร้างโมเดลดีขึ้นเร็วขึ้นด้วยการ track experiment, version dataset, และจัดการโมเดล ฟรีสำหรับโปรเจกต์ส่วนตัว 100 GB storage
  * [What The Diff](https://whatthediff.ai) - ผู้ช่วยรีวิวโค้ดด้วย AI แผนฟรีจำกัด 25,000 token/เดือน (~10 PR)
  * [wolfram.com](https://wolfram.com/language/) — อัลกอริธึมแบบ knowledge-based ในคลาวด์
  * [wrapapi.com](https://wrapapi.com/) — เปลี่ยนเว็บไซต์ใดก็ได้เป็น API แบบ parameterized ฟรี 30,000 คำขอ/เดือน
  * [Zenscrape](https://zenscrape.com/web-scraping-api) — Web scraping API ที่มี headless browser, IP residential, ราคาตรงไปตรงมา ฟรี 1,000 คำขอ/เดือน นักศึกษาและองค์กรไม่แสวงหากำไรขอเครดิตเพิ่มได้
  * [Zipcodebase](https://zipcodebase.com) - API รหัสไปรษณีย์ฟรี เข้าถึงข้อมูล Postal Code ทั่วโลก ฟรี 5,000 คำขอ/เดือน
  * [Zipcodestack](https://zipcodestack.com) - API รหัสไปรษณีย์และตรวจสอบรหัสไปรษณีย์ฟรี 10,000 คำขอ/เดือน
  * [Zuplo](https://zuplo.com/) - แพลตฟอร์ม API Management ฟรีสำหรับออกแบบ สร้าง และ deploy API ไปยัง Edge เพิ่ม authentication, limit, เอกสารและ Monetization ให้ API ได้ในไม่กี่นาที รองรับ OpenAPI เต็มรูปแบบ, โปรแกรมได้ด้วย web standard apis & Typescript แผนฟรีสูงสุด 10 โปรเจกต์, production edge ไม่จำกัด, 1M คำขอ/เดือน, 10GB egress

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## Artifact Repos

  * [Artifactory](https://jfrog.com/start-free/) - ที่เก็บ artifact ที่รองรับแพ็กเกจหลากหลายรูปแบบ เช่น Maven, Docker, Cargo, Helm, PyPI, CocoaPods และ GitLFS มี XRay สำหรับสแกนแพ็กเกจและ CI/CD Pipelines (ชื่อเดิม Shippable) แผนฟรี 2,000 นาที CI/CD ต่อเดือน
  * [central.sonatype.org](https://central.sonatype.org) — ที่เก็บ artifact หลักสำหรับ Apache Maven, SBT และระบบ build อื่นๆ
  * [cloudrepo.io](https://cloudrepo.io) - ที่เก็บ Maven และ PyPi แบบคลาวด์ ทั้งแบบ private และ public ฟรีสำหรับโปรเจกต์ open-source
  * [cloudsmith.io](https://cloudsmith.io) — บริการที่เก็บแพ็กเกจแบบรวมศูนย์ ปลอดภัย สำหรับ Java/Maven, RedHat, Debian, Python, Ruby, Vagrant ฯลฯ แผนฟรี + ฟรีสำหรับ open source
  * [jitpack.io](https://jitpack.io/) — Maven repository สำหรับโปรเจกต์ JVM และ Android บน GitHub ฟรีสำหรับโปรเจกต์สาธารณะ
  * [packagecloud.io](https://packagecloud.io/users/new?plan=free_usage_plan) — บริการโฮสต์ repo สำหรับ Maven, RPM, DEB, PyPi, NPM, RubyGem ใช้งานง่าย (มีแผนฟรี)
  * [repsy.io](https://repsy.io) — 1 GB ฟรี Maven Repository แบบ private/public
  * [Gemfury](https://gemfury.com) — ที่เก็บ artifact แบบ private/public สำหรับ Maven, PyPi, NPM, Go Module, Nuget, APT และ RPM ฟรีสำหรับโปรเจกต์ public
  * [paperspace](https://www.paperspace.com/) — สร้างและขยายโมเดล AI, พัฒนา ฝึกสอน และ deploy แอป AI, แผนฟรี: โปรเจกต์ public, พื้นที่ 5Gb, instance พื้นฐาน
  * [RepoForge](https://repoforge.io) - ที่เก็บ Python, Debian, NPM, Docker registry แบบ private บนคลาวด์ แผนฟรีสำหรับโปรเจกต์ open source/public
  * [RepoFlow](https://repoflow.io) - RepoFlow บริหารแพ็กเกจง่าย รองรับ npm, PyPI, Docker, Go, Helm ฯลฯ ทดลองฟรี 10GB storage, 10GB bandwidth, 100 packages, user ไม่จำกัดบนคลาวด์ หรือ self-host สำหรับใช้งานส่วนตัวเท่านั้น

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## เครื่องมือสำหรับทีมและการทำงานร่วมกัน
  * [3Cols](https://3cols.com/) - ตัวจัดการ code snippet บนคลาวด์ฟรี สำหรับใช้งานส่วนตัวและทีม
  * [Bitwarden](https://bitwarden.com) — วิธีเก็บ แชร์ และ sync ข้อมูลสำคัญที่ง่ายและปลอดภัยที่สุดสำหรับบุคคล ทีม และองค์กรธุรกิจ
  * [Braid](https://www.braidchat.com/) — แอปแชทสำหรับทีม ฟรีสำหรับกลุ่มสาธารณะ ผู้ใช้ไม่จำกัด ประวัติและ integration ไม่จำกัด มีเวอร์ชัน open source ติดตั้งเองได้
  * [cally.com](https://cally.com/) — หาเวลานัดหมายที่ลงตัว ใช้งานง่าย เหมาะกับกลุ่มเล็กและใหญ่
  * [Calendly](https://calendly.com) — เครื่องมือเชื่อมต่อและนัดหมาย แผนฟรีเชื่อมต่อปฏิทินได้ 1 อันต่อผู้ใช้และนัดไม่จำกัด มีแอปทั้ง Desktop และ Mobile
  * [Discord](https://discord.com/) — แชทแบบห้องสาธารณะ/ส่วนตัว รองรับ Markdown, เสียง, วิดีโอ และแชร์หน้าจอ ฟรีสำหรับผู้ใช้ไม่จำกัด
  * [Fibo](https://fibo.dev) - เครื่องมือ scrum poker ออนไลน์ฟรีแบบเรียลไทม์สำหรับทีม agile ให้สมาชิกไม่จำกัดประเมิน story point ได้เร็วขึ้น
  * [Telegram](https://telegram.org/) — แอปแชทและโทรสำหรับทุกคน เหมาะกับผู้ใช้ธุรกิจและทีมขนาดเล็ก มีกรุ๊ปขนาดใหญ่, username, แอปเดสก์ท็อป, แชร์ไฟล์ได้ทรงพลัง
  * [DevToolLab](https://devtoollab.com) — เครื่องมือออนไลน์สำหรับนักพัฒนา ใช้ฟรีทุกเครื่องมือพื้นฐาน บันทึกอัตโนมัติ 1 รายการ/เครื่องมือ ความเร็วปกติ และมีชุมชนช่วยเหลือ
  * [Dubble](https://dubble.so/) — สร้างคู่มือ Step-by-Step ฟรี ถ่ายภาพหน้าจอ, บันทึกขั้นตอน และทำงานร่วมกับทีม รองรับบันทึกหน้าจอแบบ async
  * [Duckly](https://duckly.com/) — พูดคุยและทำงานร่วมกันแบบเรียลไทม์กับทีม Pair programming ใน IDE แชร์ terminal, เสียง, วิดีโอ, หน้าจอ ฟรีสำหรับทีมเล็ก
  * [Dyte](https://dyte.io) - SDK วิดีโอ/เสียงสดที่เป็นมิตรกับนักพัฒนามากที่สุด มีปลั๊กอินทำงานร่วมกันเพื่อเพิ่ม productivity แผนฟรีรวม 10,000 นาทีวิดีโอ/เสียงต่อเดือน
  * [evernote.com](https://evernote.com/) — เครื่องมือจัดระเบียบข้อมูล แชร์โน้ตและทำงานร่วมกับผู้อื่น
  * [Fibery](https://fibery.io/) — แพลตฟอร์ม workspace เชื่อมโยงข้อมูล ฟรีสำหรับผู้ใช้เดี่ยว พื้นที่ 2 GB
  * [flock.com](https://flock.com) — วิธีที่รวดเร็วขึ้นสำหรับทีมของคุณในการสื่อสาร ฟรี ข้อความไม่จำกัด, ช่อง, ผู้ใช้, แอป & การเชื่อมต่อ
  * [Gather](https://www.gather.town/) - วิธีที่ดีกว่าในการประชุมออนไลน์ เน้นพื้นที่ที่ปรับแต่งได้เต็มที่ Gather ทำให้การใช้เวลากับชุมชนของคุณง่ายเหมือนชีวิตจริง ฟรีสำหรับผู้ใช้พร้อมกันสูงสุด 10 คน
  * [gokanban.io](https://gokanban.io) - Kanban Board ที่ใช้งานรวดเร็วตามไวยากรณ์ ไม่ต้องลงทะเบียน ใช้ได้ฟรีโดยไม่มีข้อจำกัด
  * [flat.social](https://flat.social) - พื้นที่ปรับแต่งได้สำหรับการประชุมทีม & สังสรรค์แบบโต้ตอบ ประชุมได้ไม่จำกัด ฟรีสำหรับผู้ใช้พร้อมกันสูงสุด 8 คน
  * [GitDailies](https://gitdailies.com) - รายงานกิจกรรม Commit และ Pull Request ของทีมคุณบน GitHub รายวัน รวมถึง Push visualizer, ระบบการยอมรับเพื่อนร่วมงาน และตัวสร้างการแจ้งเตือนแบบกำหนดเอง แผนฟรีมีผู้ใช้ไม่จำกัด 3 repos และ 3 การตั้งค่าการแจ้งเตือน
  * [gitter.im](https://gitter.im/) — แชทสำหรับ GitHub ห้องสนทนาสาธารณะและส่วนตัวไม่จำกัด ฟรีสำหรับทีมสูงสุด 25 คน
  * [Hackmd.io](https://hackmd.io/) - เครื่องมือทำงานร่วมกันและเขียนเอกสาร/ไฟล์ในรูปแบบ markdown แบบเรียลไทม์ เหมือน Google Docs แต่สำหรับไฟล์ markdown ฟรี "โน้ต" ไม่จำกัดจำนวน แต่จำนวนผู้ร่วมมือ (ผู้ที่เชิญ) สำหรับโน้ตส่วนตัว & เทมเพลต [จะถูกจำกัด](https://hackmd.io/pricing)
  * [hangouts.google.com](https://hangouts.google.com/) — จุดเดียวสำหรับทุกบทสนทนา ฟรี ต้องมีบัญชี Google
  * [HeySpace](https://hey.space) - เครื่องมือจัดการงานพร้อมแชท ปฏิทิน ไทม์ไลน์ และวิดีโอคอล ฟรีสำหรับผู้ใช้สูงสุด 5 คน
  * [helplightning.com](https://www.helplightning.com/) — ช่วยเหลือผ่านวิดีโอด้วยเทคโนโลยีเสริมจริง ฟรีแต่ไม่มี analytics, encryption, support
  * [ideascale.com](https://ideascale.com/) — ให้ลูกค้าส่งไอเดียและโหวต ฟรีสำหรับสมาชิก 25 คนใน 1 ชุมชน
  * [Igloo](https://www.igloosoftware.com/) — พอร์ทัลภายในสำหรับแบ่งปันเอกสาร บล็อก ปฏิทิน ฯลฯ ฟรีสำหรับผู้ใช้สูงสุด 10 คน
  * [Keybase](https://keybase.io/) — Keybase เป็นทางเลือก FOSS สำหรับ Slack; ปกป้องแชทและไฟล์ของทุกคน ตั้งแต่ครอบครัว ชุมชน ไปจนถึงบริษัท
  * [Google Meet](https://meet.google.com/) — ใช้ Google Meet สำหรับการประชุมวิดีโอออนไลน์ทางธุรกิจของคุณ ให้การประชุมออนไลน์ที่ปลอดภัย เข้าร่วมง่าย
  * [/meet for Slack](https://meetslack.com) - เริ่ม Google Meetings จาก Slack โดยใช้ /meet ในช่อง กลุ่ม หรือ DM ใดๆ ฟรีโดยไม่มีข้อจำกัด
  * [Livecycle](https://www.livecycle.io/) — แพลตฟอร์ม collaboration สำหรับทีม cross-functional และโปรเจกต์โอเพนซอร์ส
  * [Lockitbot](https://www.lockitbot.com/) — จองและล็อกทรัพยากรร่วมภายใน Slack เช่น ห้อง, Dev environments, server ฯลฯ ฟรีสำหรับ 2 ทรัพยากร
  * [MarkUp](https://www.markup.io/) — MarkUp ให้คุณรวบรวม feedback โดยตรงบนเว็บไซต์, PDF และรูปภาพของคุณ
  * [Proton Pass](https://proton.me/pass) — ตัวจัดการรหัสผ่านพร้อมอีเมล alias, 2FA, การแชร์ และ passkeys ในตัว ใช้ได้บนเว็บ, ส่วนขยายเบราว์เซอร์, แอปมือถือ และเดสก์ท็อป
  * [Visual Debug](https://visualdebug.com) - เครื่องมือ feedback เชิงภาพสำหรับสื่อสารระหว่างลูกค้า-นักพัฒนา
  * [meet.jit.si](https://meet.jit.si/) — วิดีโอคุยและแชร์หน้าจอคลิกเดียว ฟรี
  * [Microsoft Teams](https://products.office.com/microsoft-teams/free) — Microsoft Teams เป็นศูนย์กลางดิจิทัลแบบแชทที่รวมบทสนทนา เนื้อหา และแอปไว้ที่เดียว ฟรีสำหรับผู้ใช้สูงสุด 500,000 คน
  * [Miro](https://miro.com/) - กระดานไวท์บอร์ด collaboration ระดับองค์กร รองรับหลายอุปกรณ์ มีแผนฟรี
  * [nootiz](https://www.nootiz.com/) - เครื่องมือหลักสำหรับรวบรวมและจัดการ feedback เชิงภาพบนเว็บไซต์ใดก็ได้
  * [Notion](https://www.notion.so/) - แอปจดบันทึกและทำงานร่วมกัน รองรับ markdown ผสานงานกับงาน วิกิ และฐานข้อมูล แอปนี้อธิบายว่าเป็น workspace ครบวงจรสำหรับการจดบันทึก การจัดการโปรเจกต์ และงานต่างๆ มีทั้งแอปข้ามแพลตฟอร์มและใช้งานผ่านเว็บเบราว์เซอร์ส่วนใหญ่ได้
  * [Nuclino](https://www.nuclino.com) - วิกิ collaborative น้ำหนักเบาสำหรับความรู้ เอกสาร และโน้ตของทีม แผนฟรีมีฟีเจอร์สำคัญทั้งหมด สูงสุด 50 รายการ และที่เก็บข้อมูล 5GB
  * [OnlineInterview.io](https://onlineinterview.io/) - แพลตฟอร์มสัมภาษณ์โค้ดฟรีพร้อมวิดีโอแชท กระดานวาด เขียนและรันโค้ดได้บนเบราว์เซอร์ สร้างห้องสัมภาษณ์ทางไกลได้ด้วยคลิกเดียว
  * [Quidlo Timesheets](https://www.quidlo.com/timesheets) - แอป timesheet และติดตามเวลาแบบง่ายสำหรับทีม แผนฟรีรองรับติดตามเวลาและออกรีพอร์ตสำหรับผู้ใช้สูงสุด 10 คน
  * [PageShare.dev](https://www.pageshare.dev) - เพิ่มความสามารถรีวิวเชิงภาพใน GitHub Pull Request โดยไม่ต้อง deploy เว็บไซต์ ฟรีสำหรับสูงสุด 10 หน้า/เดือน และพื้นที่รวม 100MB
  * [Pendulums](https://pendulums.io/) - เครื่องมือจับเวลาฟรี ช่วยจัดการเวลาของคุณด้วยอินเทอร์เฟซใช้งานง่ายและสถิติที่มีประโยชน์
  * [Pumble](https://pumble.com) - แอปแชททีมฟรี ผู้ใช้และประวัติข้อความไม่จำกัด ฟรีตลอดไป
  * [Raindrop.io](https://raindrop.io) - แอปบุ๊กมาร์กส่วนตัวและปลอดภัยสำหรับ macOS, Windows, Android, iOS และเว็บ ฟรีสำหรับบุ๊กมาร์กและ collaboration ไม่จำกัด
  * [element.io](https://element.io/) — เครื่องมือสื่อสาร decentralized และโอเพนซอร์สบน Matrix สนทนากลุ่ม แชทตรง ส่งไฟล์เข้ารหัส คุยเสียง/วิดีโอ และเชื่อมต่อกับบริการอื่นๆ ได้ง่าย
  * [Rocket.Chat](https://rocket.chat/) - แพลตฟอร์มสื่อสารโอเพนซอร์สพร้อม Omnichannel, Matrix Federation, เชื่อมกับแอปอื่น, ข้อความไม่จำกัด และประวัติข้อความเต็ม
  * [seafile.com](https://www.seafile.com/) — พื้นที่จัดเก็บไฟล์ส่วนตัว/คลาวด์ แชร์ไฟล์ ซิงก์ สนทนา รุ่นคลาวด์มีพื้นที่ 1 GB
  * [Sema](https://www.semasoftware.com/) - เครื่องมือ portfolio สำหรับนักพัฒนาฟรี รวมผลงานจากหลาย repo เป็นรีพอร์ตเดียว
  * [Screen Sharing via Browser](https://screensharing.net) - เครื่องมือแชร์หน้าจอผ่านเบราว์เซอร์ฟรี แชร์กับเพื่อนร่วมงานได้ทันทีโดยไม่ต้องดาวน์โหลดหรือลงทะเบียน
  * [Slab](https://slab.com/) — ระบบจัดการความรู้สมัยใหม่สำหรับทีม ฟรีสำหรับผู้ใช้สูงสุด 10 คน
  * [slack.com](https://slack.com/) — ฟรีสำหรับผู้ใช้ไม่จำกัดบางฟีเจอร์จะถูกจำกัด
  * [Spectrum](https://spectrum.chat/) - สร้างชุมชนสาธารณะหรือส่วนตัวฟรี
  * [StatusPile](https://www.statuspile.com/) - เพจสถานะของเพจสถานะ คุณติดตามสถานะของผู้ให้บริการ upstream ได้หรือไม่?
  * [Stickies](https://stickies.app/) - แอป collaboration เชิงภาพสำหรับ brainstorming, คัดเนื้อหา, และจดโน้ต ฟรีสำหรับ 3 Walls ผู้ใช้ไม่จำกัด และ 1 GB
  * [Stacks](https://betterstacks.com/) - พื้นที่จัดการเนื้อหาพร้อมโน้ต ลิงก์ และเก็บไฟล์แบบครบในที่เดียว แผนส่วนตัวฟรีตลอดไป
  * [talky.io](https://talky.io/) — วิดีโอแชทกลุ่มฟรี ไม่ระบุตัวตน Peer‑to‑peer ไม่ต้องติดตั้ง ไม่ต้องสมัคร ไม่ต้องจ่าย
  * [Teamhood](https://teamhood.com/) - ซอฟต์แวร์ Project, Task, Issue-tracking ฟรี รองรับ Kanban กับ Swimlanes และ Scrum เต็มรูปแบบ มี time tracking ในตัว ฟรีสำหรับ 5 ผู้ใช้และ 3 โปรเจกต์พอร์ตโฟลิโอ
  * [Teamplify](https://teamplify.com) - ยกระดับการพัฒนาในทีมด้วย Team Analytics และ Smart Daily Standup มี Time Off management เต็มฟีเจอร์สำหรับทีม remote-first ฟรีสำหรับกลุ่มเล็กสูงสุด 5 คน
  * [Tefter](https://tefter.io) - แอปบุ๊กมาร์กพร้อม integration กับ Slack ที่ทรงพลัง ฟรีสำหรับทีมโอเพนซอร์ส
  * [TeleType](https://teletype.oorja.io/) — แชร์ terminal, เสียง, โค้ด, ไวท์บอร์ด ฯลฯ ไม่ต้องลงชื่อเข้าใช้ รองรับ collaboration เข้ารหัส end-to-end สำหรับนักพัฒนา
  * [TimeCamp](https://www.timecamp.com/) - โปรแกรมจับเวลาฟรีสำหรับผู้ใช้ไม่จำกัด เชื่อมต่อกับ PM tools อย่าง Jira, Trello, Asana ฯลฯ ได้ง่าย
  * [Huly](https://huly.io/) - แพลตฟอร์ม All-in-One Project Management (ทางเลือก Linear, Jira, Slack, Notion, Motion) - ผู้ใช้ไม่จำกัด พื้นที่ 10GB ต่อ workspace ทราฟฟิควิดีโอ(เสียง) 10GB
  * [Teamcamp](https://www.teamcamp.app) - แอปจัดการโปรเจกต์ครบวงจรสำหรับบริษัทซอฟต์แวร์
  * [twist.com](https://twist.com) — แอปสื่อสารทีมแบบ async ที่ช่วยจัดระเบียบบทสนทนา ฟรีและมีแผนไม่จำกัด มีส่วนลดสำหรับทีมที่ผ่านเกณฑ์
  * [tldraw.com](https://tldraw.com) — เครื่องมือไวท์บอร์ดและไดอะแกรมโอเพนซอร์สฟรี มีลูกศรอัจฉริยะ, snap, sticky note, ส่งออก SVG, โหมดหลายผู้ใช้สำหรับแก้ไขร่วมกัน มี official VS Code extension ฟรีด้วย
  * [BookmarkOS.com](https://bookmarkos.com) - ฟรี all-in-one ตัวจัดการบุ๊กมาร์ก แท็บ และงาน ในเดสก์ท็อปออนไลน์แบบปรับแต่งและ collaboration โฟลเดอร์
  * [typetalk.com](https://www.typetalk.com/) — แชร์และพูดคุยไอเดียกับทีมของคุณผ่านแชททันทีทางเว็บหรือมือถือ
  * [Tugboat](https://tugboat.qa) - พรีวิวทุก pull request แบบอัตโนมัติและออนดีมานด์ ฟรีสำหรับทุกคน Nano tier ฟรีสำหรับองค์กรไม่แสวงหากำไร
  * [whereby.com](https://whereby.com/) — วิดีโอคุยคลิกเดียว ฟรี (ชื่อเดิม appear.in)
  * [windmill.dev](https://windmill.dev/) - แพลตฟอร์มโอเพนซอร์สสำหรับนักพัฒนา สร้าง automation และแอป internal แบบ production-grade จาก Python/Typescript script สร้างหรือเข้าร่วม workspace ได้สูงสุด 3 แห่ง (non-premium)
  * [vadoo.tv](https://vadoo.tv/) — โฮสต์และทำการตลาดวิดีโอง่ายๆ อัปโหลดวิดีโอคลิกเดียว บันทึก จัดการ แชร์ ฯลฯ แผนฟรีรองรับ 10 วิดีโอ 1GB พื้นที่เก็บ 10GB แบนด์วิดท์/เดือน
  * [userforge.com](https://userforge.com/) - สร้าง persona ออนไลน์แบบเชื่อมโยง, user stories และ context mapping ฟรีสำหรับ 3 persona และ 2 ผู้ร่วมมือ
  * [wistia.com](https://wistia.com/) — โฮสต์วิดีโอพร้อม analytics, ส่งวิดีโอ HD, เครื่องมือการตลาด, 25 วิดีโอ และเครื่องเล่น Wistia ติดแบรนด์
  * [wormhol.org](https://www.wormhol.org/) — บริการแชร์ไฟล์ง่ายๆ แชร์ไฟล์ไม่จำกัดขนาดสูงสุด 5GB กับเพื่อนกี่คนก็ได้
  * [Wormhole](https://wormhole.app/) - แชร์ไฟล์สูงสุด 5GB ด้วยการเข้ารหัส end-to-end นาน 24 ชั่วโมง ไฟล์ใหญ่กว่า 5GB จะใช้การส่งแบบ peer-to-peer
  * [zoom.us](https://zoom.us/) — วิดีโอและเว็บคอนเฟอเรนซ์ปลอดภัย มีเสริมการประชุม แผนฟรีจำกัด 40 นาที
  * [Zulip](https://zulip.com/) — แชทเรียลไทม์พร้อมระบบ threading แบบอีเมลไม่เหมือนใคร แผนฟรีค้นหาประวัติ 10,000 ข้อความ และเก็บไฟล์สูงสุด 5GB มีเวอร์ชันโอเพนซอร์สโฮสต์เองได้
  * [robocorp.com](https://robocorp.com) - สแต็กโอเพนซอร์สสำหรับ Automation Ops ทดลองใช้ Cloud features และทำ automation ง่ายๆ ฟรี งานหุ่นยนต์ 240 นาที/เดือน, 10 Assistant runs, พื้นที่ 100 MB
  * [Fleep.io](https://fleep.io/) — Fleep เป็นทางเลือก Slack แผนฟรีสำหรับทีมเล็กพร้อมประวัติข้อความเต็ม, 1:1 ไม่จำกัด, 1 กลุ่ม, พื้นที่ไฟล์ 1 GB
  * [Chanty.com](https://chanty.com/) — Chanty เป็นอีกหนึ่งทางเลือก Slack แผนฟรีตลอดไปสำหรับทีมเล็ก (สูงสุด 10 คน) แชทสาธารณะ/ส่วนตัวไม่จำกัด ประวัติค้นหาได้ 1:1 audio call ไม่จำกัด ข้อความเสียงไม่จำกัด 10 integration พื้นที่ 20 GB ต่อทีม
  * [ruttl.com](https://ruttl.com/) — เครื่องมือ feedback all-in-one ที่ดีที่สุดสำหรับเก็บ feedback เว็บไซต์, PDF, รูปภาพ
  * [Mattermost](https://mattermost.com/) — collaboration ปลอดภัยสำหรับทีมเทคนิค แผนฟรีมีช่อง, playbook, board, ผู้ใช้, พื้นที่ 10GB ฯลฯ ไม่จำกัด
  * [Webvizio](https://webvizio.com) — เครื่องมือ feedback เว็บไซต์, ซอฟต์แวร์รีวิวเว็บไซต์ และรายงานบั๊กสำหรับการ collaboration ในเว็บแอป, รูปภาพ, PDF, ไฟล์ออกแบบ
  * [Pullflow](https://pullflow.com) — แพลตฟอร์มรีวิวโค้ดแบบ collaboration เสริม AI สำหรับ GitHub, Slack และ VS Code
  * [Webex](https://www.webex.com/) — วิดีโอประชุม แผนฟรีประชุม 40 นาที/ครั้ง สูงสุด 100 คน
  * [RingCentral](https://www.ringcentral.com/) — วิดีโอประชุม แผนฟรี 50 นาที/ครั้ง สูงสุด 100 คน
  * [GitBook](https://www.gitbook.com/) — แพลตฟอร์มจัดเก็บและบันทึกความรู้ด้านเทคนิค — ตั้งแต่เอกสารสินค้า ฐานความรู้ภายใน ไปจนถึง API แผนฟรีสำหรับนักพัฒนาเดี่ยว
  * [transfernow](https://www.transfernow.net/) — อินเทอร์เฟซโอนและแชร์ไฟล์ที่ง่าย เร็ว และปลอดภัยที่สุด ส่งภาพ วิดีโอ และไฟล์ใหญ่โดยไม่ต้องสมัครสมาชิก
  * [paste.sh](https://paste.sh/) — เว็บไซต์ paste ที่ใช้ JavaScript และ Crypto ง่ายๆ
  * [Revolt.chat](https://revolt.chat/) — ทางเลือกโอเพนซอร์สสำหรับ [Discord](https://discord.com/) ที่เคารพความเป็นส่วนตัวของคุณ มีฟีเจอร์ proprietary ส่วนใหญ่ของ discord ให้ใช้ฟรี Revolt เป็นแอป all-in-one ที่ปลอดภัยและรวดเร็ว ฟรี 100% ทุกฟีเจอร์ฟรี มีระบบ plugin (official & unofficial) ต่างจากแอปแชทหลักอื่นๆ
  * [Tencent RTC](https://trtc.io/) — Tencent Real-Time Communication (TRTC) มีโซลูชันคุยเสียง/วิดีโอกลุ่ม ฟรี 10,000 นาที/เดือนในปีแรก
  * [Pastefy](https://pastefy.app/) - Pastebin สวยงามและใช้งานง่าย พร้อม Client-Encryption, Multitab, API, Editor ไฮไลท์ ฯลฯ
  * [SiteDots](https://sitedots.com/) - แชร์ feedback สำหรับโปรเจกต์เว็บได้โดยตรงบนเว็บไซต์ของคุณ ไม่มี emulation, canvas หรือวิธีอ้อม แผนฟรีใช้งานได้เต็มฟังก์ชัน

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## CMS

  * [acquia.com](https://www.acquia.com/) — โฮสติ้งสำหรับเว็บไซต์ Drupal มี Free tier สำหรับนักพัฒนา และมีเครื่องมือพัฒนา (เช่น Acquia Dev Desktop) ฟรีด้วย
  * [Contentful](https://www.contentful.com/) — Headless CMS ระบบจัดการและส่งมอบเนื้อหาแบบ API บนคลาวด์ มี Community space ฟรี 1 ที่ รองรับ 5 ผู้ใช้, 25K records, 48 Content Types, 2 locales
  * [Cosmic](https://www.cosmicjs.com/) — Headless CMS และ API toolkit แผนส่วนตัวฟรีสำหรับนักพัฒนา
  * [Crystallize](https://crystallize.com) — Headless PIM พร้อม ecommerce API GraphQL ในตัว รุ่นฟรีรองรับผู้ใช้ไม่จำกัด 1000 catalog, 5 GB/เดือน, 25k/เดือน API calls
  * [DatoCMS](https://www.datocms.com/) - มี Free tier สำหรับโปรเจกต์ขนาดเล็ก DatoCMS เป็น CMS ที่ใช้ GraphQL แผนล่างสุดรองรับ 100k calls/เดือน
  * [Directus](https://directus.io) — Headless CMS แพลตฟอร์มฟรีและโอเพนซอร์สเต็มรูปแบบสำหรับจัดการ asset และเนื้อหาฐานข้อมูล on-prem หรือคลาวด์ ไม่มีข้อจำกัดหรือ paywall
  * [FrontAid](https://frontaid.io/) — Headless CMS ที่เก็บข้อมูล JSON ไว้ใน Git repo ของคุณโดยตรง ไม่มีข้อจำกัด
  * [kontent.ai](https://www.kontent.ai) - แพลตฟอร์ม Content-as-a-Service ที่ให้ทุกประโยชน์ของ headless CMS พร้อม empower ฝ่ายการตลาด แผนนักพัฒนารองรับ 2 ผู้ใช้ โปรเจกต์ไม่จำกัด 2 environment ต่อโปรเจกต์ 500 content item 2 ภาษา API Delivery/Management และรองรับ Custom element ปรับแผนได้ตามต้องการ
  * [Prismic](https://www.prismic.io/) — Headless CMS อินเทอร์เฟซจัดการเนื้อหาพร้อม API โฮสต์และปรับขนาดได้ แผน Community ให้ API call, เอกสาร, custom type, asset, locale ไม่จำกัด สำหรับ 1 ผู้ใช้ มีแผนฟรีขนาดใหญ่สำหรับโปรเจกต์ Open Content/Open Source
  * [Sanity.io](https://www.sanity.io/) - แพลตฟอร์มสำหรับ structured content พร้อม editor โอเพนซอร์สและ data store แบบเรียลไทม์โฮสต์ Unlimited projects, admin ไม่จำกัด, non-admin 3 คน, datasets 2, API CDN 500K ครั้ง, แบนด์วิดท์ 10GB, asset 5GB ต่อโปรเจกต์ฟรี
  * [sensenet](https://sensenet.com) - API-first headless CMS สำหรับองค์กรทุกขนาด แผนนักพัฒนารองรับ 3 ผู้ใช้, 500 content, 3 role ในตัว, 25+5 content type, REST API, preview เอกสาร, แก้ไข Office Online
  * [TinaCMS](https://tina.io/) — แทน Forestry.io โอเพนซอร์ส Git-backed headless CMS รองรับ Markdown, MDX, JSON แผนพื้นฐานฟรีสำหรับ 2 ผู้ใช้
  * [GatsbyjsCMS](https://www.gatsbyjs.com/) - Gatsby คือเฟรมเวิร์กที่เร็วและยืดหยุ่นสำหรับสร้างเว็บกับ CMS, API หรือฐานข้อมูลใดก็ได้ สร้างและดีพลอยเว็บ headless ที่เพิ่มทราฟฟิค, แปลงดีขึ้น, รายได้มากขึ้น!
  * [Hygraph](https://hygraph.com/) - มี Free tier สำหรับโปรเจกต์ขนาดเล็ก API-first GraphQL ย้ายจาก CMS เดิมสู่ Headless CMS แบบ GraphQL Native ขับเคลื่อน omnichannel API-first
  * [Squidex](https://squidex.io/) - มีแพ็กเกจฟรีสำหรับโปรเจ็กต์ขนาดเล็ก API / GraphQL เป็นหลัก โอเพ่นซอร์สและใช้ event sourcing (บันทึกทุกการเปลี่ยนแปลงโดยอัตโนมัติ)
  * [InstaWP](https://instawp.com/) - เปิดเว็บไซต์ WordPress ได้ในไม่กี่วินาที มีแพ็กเกจฟรีพร้อม 5 ไซต์ที่ใช้งาน, พื้นที่ 500 MB, ไซต์หมดอายุใน 48 ชั่วโมง
  * [Storyblok](https://www.storyblok.com) - Headless CMS สำหรับนักพัฒนาและนักการตลาดที่รองรับเฟรมเวิร์กสมัยใหม่ทุกชนิด แพ็กเกจ Community (ฟรี) มี Management API, Visual Editor, แหล่งข้อมูล 10 แหล่ง, Custom Field Types, รองรับหลายภาษา/ท้องถิ่นไม่จำกัด, Asset Manager (สูงสุด 2500 ไฟล์), Image Optimizing Service, Search Query, Webhook + แถม Traffic 250GB/เดือน
  * [WPJack](https://wpjack.com) - ติดตั้ง WordPress บนคลาวด์ใดๆ ได้ในไม่ถึง 5 นาที! แพ็กเกจฟรีประกอบด้วย 1 เซิร์ฟเวอร์, 2 เว็บไซต์, ใบรับรอง SSL ฟรี, และ cron jobs ไม่จำกัด ไม่มีหมดอายุหรือจำกัดเวลา—เว็บไซต์ของคุณ ในแบบของคุณ

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## การสร้างโค้ดอัตโนมัติ

  * [Appinvento](https://appinvento.io/) — AppInvento คือเครื่องมือสร้างแอปแบบ No code ฟรี ในโค้ดฝั่ง backend ที่สร้างให้อัตโนมัติ ผู้ใช้สามารถเข้าถึงซอร์สโค้ดและ API/route ได้ไม่จำกัด รองรับการอินทิเกรตอย่างกว้างขวาง แพ็กเกจฟรีมี 3 โปรเจ็กต์, 5 ตาราง, และ Google add-on
  * [Cody AI](https://sourcegraph.com/cody) - Cody เป็นผู้ช่วยเขียนโค้ดด้วย AI ที่เข้าใจ codebase ของคุณอย่างลึกซึ้ง ช่วยให้เขียนและเข้าใจโค้ดได้เร็วขึ้น Cody ให้เลือก LLM (รวมถึง inference ในเครื่อง), รองรับ IDE หลายแบบ, รองรับภาษาโปรแกรมยอดนิยมทั้งหมด และมีแพ็กเกจฟรี แพ็กเกจฟรีให้แชท 20 ข้อความ/เดือน (ใช้ Claude 3 Sonnet เป็น LLM) และ autocompletion 500 ครั้ง/เดือน (ใช้ Starcoder 16b)
  * [DhiWise](https://www.dhiwise.com/) — แปลงดีไซน์ Figma เป็นแอป Flutter & React แบบ dynamic ได้อย่างไร้รอยต่อ ด้วยเทคโนโลยีสร้างโค้ดอัตโนมัติของ DhiWise เพิ่มประสิทธิภาพ workflow และช่วยให้พัฒนาแอปมือถือและเว็บได้อย่างรวดเร็ว
  * [Codeium](https://www.codeium.com/) — Codeium คือเครื่องมือเติมโค้ดอัตโนมัติด้วย AI ฟรี รองรับมากกว่า 20 ภาษาโปรแกรม (Python, JavaScript, Java, TypeScript, PHP, C/C++, Go ฯลฯ) และเชื่อมต่อกับ IDE ชั้นนำทั้งแบบ standalone และแบบเว็บ
  * [Fern](https://buildwithfern.com) - เขียน API definitions และใช้สร้าง SDK/ไลบรารีไคลเอนต์ในภาษา TypeScript, Python, Java, Go ฯลฯ รองรับ OpenAPI เต็มรูปแบบ แพ็กเกจฟรีสร้างโค้ดได้สูงสุด 20 endpoints
  * [Metalama](https://www.postsharp.net/metalama) - สำหรับ C# เท่านั้น Metalama สร้าง boilerplate โค้ดระหว่างคอมไพล์แบบอัตโนมัติ โค้ดต้นฉบับจึงสะอาด ฟรีสำหรับโปรเจ็กต์โอเพ่นซอร์ส และแพ็กเกจฟรีเชิงพาณิชย์รองรับ 3 aspects
  * [Supermaven](https://www.supermaven.com/) — Supermaven คือปลั๊กอินเติมโค้ดด้วย AI สำหรับ VSCode, JetBrains, และ Neovim แพ็กเกจฟรีให้เติมโค้ด inline ได้ไม่จำกัด
  * [tabnine.com](https://www.tabnine.com/) — Tabnine ช่วยให้นักพัฒนาเขียนซอฟต์แวร์ได้ดีและเร็วขึ้น ด้วย insights ที่เรียนรู้จากโค้ดทั่วโลก มีปลั๊กอินให้ใช้งาน
  * [v0.dev](https://v0.dev/) — v0 ใช้ AI สร้างโค้ดจากข้อความ prompt ธรรมดา โดยจะสร้างโค้ด React ที่พร้อมคัดลอก-วาง ใช้ shadcn/ui และ Tailwind CSS ใช้ในโปรเจ็กต์ได้ การสร้างแต่ละครั้งใช้เครดิตขั้นต่ำ 30 เครดิต เริ่มต้นมี 1200 เครดิต และรับฟรีอีก 200 เครดิตทุกเดือน

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## คุณภาพของโค้ด

  * [beanstalkapp.com](https://beanstalkapp.com/) — เวิร์กโฟลว์สำหรับเขียน, ตรวจสอบ, และ deploy โค้ด ครบวงจร มีบัญชีฟรีสำหรับ 1 ผู้ใช้ และ 1 repository พร้อมพื้นที่ 100 MB
  * [browserling.com](https://www.browserling.com/) — ทดสอบข้ามเบราว์เซอร์แบบโต้ตอบสด ฟรี 3 นาที/เซสชั่น เฉพาะ MS IE 9 บน Vista ที่ความละเอียด 1024 x 768
  * [codacy.com](https://www.codacy.com/) — ตรวจสอบโค้ดอัตโนมัติสำหรับ PHP, Python, Ruby, Java, JavaScript, Scala, CSS, CoffeeScript ฟรีสำหรับ public และ private repo ไม่จำกัด
  * [Codeac.io](https://www.codeac.io/infrastructure-as-code.html?ref=free-for-dev) - เครื่องมือรีวิว Infrastructure as Code อัตโนมัติสำหรับ DevOps เชื่อมต่อกับ GitHub, Bitbucket, GitLab (รวม self-hosted) รองรับภาษา Ansible, Terraform, CloudFormation, Kubernetes ฯลฯ (โอเพ่นซอร์สใช้ฟรี)
  * [CodeBeat](https://codebeat.co) — แพลตฟอร์มรีวิวโค้ดอัตโนมัติ รองรับหลายภาษา ฟรีตลอดไปสำหรับ public repo พร้อมเชื่อมต่อ Slack และอีเมล
  * [codeclimate.com](https://codeclimate.com/) — ตรวจสอบโค้ดอัตโนมัติ ฟรีสำหรับ Open Source และ private repo ที่องค์กรเป็นเจ้าของไม่จำกัด (สูงสุด 4 ผู้ร่วมงาน) ฟรีสำหรับนักเรียน/สถาบันด้วย
  * [codecov.io](https://codecov.io/) — เครื่องมือวัด coverage ของโค้ด (SaaS) ฟรีสำหรับ Open Source และ 1 private repo
  * [CodeFactor](https://www.codefactor.io) — รีวิวโค้ดอัตโนมัติสำหรับ Git เวอร์ชันฟรีรองรับผู้ใช้ไม่จำกัด, public repo ไม่จำกัด, และ 1 private repo
  * [coderabbit.ai](https://coderabbit.ai) — เครื่องมือรีวิวโค้ดด้วย AI เชื่อมกับ GitHub/GitLab แพ็กเกจฟรีรองรับ 200 ไฟล์/ชม., 3 รีวิว/ชม., และ 50 บทสนทนา/ชม. ฟรีตลอดไปสำหรับโปรเจ็กต์โอเพ่นซอร์ส
  * [codescene.io](https://codescene.io/) - Codescene จัดอันดับ technical debt ตามวิธีที่นักพัฒนาทำงานกับโค้ดและแสดงปัจจัยด้านองค์กร เช่น team coupling และ system mastery ฟรีสำหรับ Open Source
  * [CodSpeed](https://codspeed.io) - ติดตามประสิทธิภาพใน CI pipeline อัตโนมัติ จับ performance regression ก่อน deploy ด้วย metric ที่แม่นยำและคงที่ ฟรีตลอดไปสำหรับโอเพ่นซอร์ส
  * [coveralls.io](https://coveralls.io/) — แสดงรายงาน test coverage ฟรีสำหรับ Open Source
  * [dareboost](https://dareboost.com) - วิเคราะห์ประสิทธิภาพเว็บ, การเข้าถึง, และความปลอดภัย ฟรี 5 ครั้ง/เดือน
  * [deepcode.ai](https://www.deepcode.ai) — DeepCode ค้นหา bug, ช่องโหว่, ปัญหาประสิทธิภาพ และ API ด้วย AI วิเคราะห์โค้ดได้แบบ real time รองรับ Java, C/C++, JavaScript, Python, TypeScript เชื่อมต่อกับ GitHub, BitBucket, GitLab ฟรีสำหรับ open source และ private repo สูงสุด 30 นักพัฒนา
  * [deepscan.io](https://deepscan.io) — วิเคราะห์โค้ด JavaScript เชิงสถิติเพื่อหาข้อผิดพลาด runtime ฟรีสำหรับ Open Source
  * [DeepSource](https://deepsource.io/) - วิเคราะห์การเปลี่ยนแปลงโค้ดอย่างต่อเนื่อง ค้นหาและแก้ไขปัญหาด้าน security, performance, anti-patterns, bug-risks, documentation, style เชื่อมต่อกับ GitHub, GitLab, Bitbucket ได้โดยตรง
  * [DiffText](https://difftext.com) - หาความแตกต่างระหว่างโค้ดสองชุดได้ทันที ใช้ฟรีทั้งหมด
  * [eversql.com](https://www.eversql.com/) — EverSQL แพลตฟอร์ม #1 สำหรับปรับแต่งฐานข้อมูล วิเคราะห์ฐานข้อมูลและ SQL query ของคุณอัตโนมัติ
  * [gerrithub.io](https://review.gerrithub.io/) — Gerrit code review สำหรับ repo บน GitHub ฟรี
  * [gocover.io](https://gocover.io/) — ตรวจสอบ coverage ของ code [Go](https://golang.org/) package ใดก็ได้
  * [goreportcard.com](https://goreportcard.com/) — ตรวจสอบคุณภาพโค้ด Go ฟรีสำหรับ Open Source
  * [gtmetrix.com](https://gtmetrix.com/) — รายงานและข้อเสนอแนะในการปรับแต่งเว็บไซต์อย่างละเอียด
  * [holistic.dev](https://holistic.dev/) - ตัววิเคราะห์โค้ดแบบ static อันดับ 1 สำหรับปรับแต่ง Postgresql ตรวจจับปัญหา performance, security, และ architect ของฐานข้อมูลโดยอัตโนมัติ
  * [houndci.com](https://houndci.com/) — แสดงความคิดเห็นเกี่ยวกับคุณภาพโค้ดบน GitHub commits ฟรีสำหรับ Open Source
  * [Moderne.io](https://app.moderne.io) — ปรับโครงสร้างซอร์สโค้ดอัตโนมัติ มี migration เฟรมเวิร์ก, วิเคราะห์โค้ดพร้อม remediation, และแปลงโค้ดขนาดใหญ่ในระดับองค์กร ฟรีสำหรับ Open Source
  * [reviewable.io](https://reviewable.io/) — รีวิวโค้ดสำหรับ repo บน GitHub ฟรีสำหรับ public หรือ personal repo
  * [parsers.dev](https://parsers.dev/) - ให้บริการ abstract syntax tree parsers และ intermediate representation compilers แบบ as a service
  * [scan.coverity.com](https://scan.coverity.com/) — วิเคราะห์โค้ดแบบ static สำหรับ Java, C/C++, C#, JavaScript ฟรีสำหรับ Open Source
  * [scrutinizer-ci.com](https://scrutinizer-ci.com/) — แพลตฟอร์มตรวจสอบโค้ดอย่างต่อเนื่อง ฟรีสำหรับ Open Source
  * [semanticdiff.com](https://app.semanticdiff.com/) — diff ที่เข้าใจภาษาโปรแกรมสำหรับ pull request และ commit บน GitHub ฟรีสำหรับ public repo
  * [shields.io](https://shields.io) — แสดง badge metadata คุณภาพสำหรับโปรเจ็กต์โอเพ่นซอร์ส
  * [sonarcloud.io](https://sonarcloud.io) — วิเคราะห์ซอร์สโค้ดอัตโนมัติสำหรับ Java, JavaScript, C/C++, C#, VB.NET, PHP, Objective-C, Swift, Python, Groovy ฯลฯ ฟรีสำหรับ Open Source
  * [SourceLevel](https://sourcelevel.io/) — รีวิวโค้ดอัตโนมัติและวิเคราะห์ทีม ฟรีสำหรับ Open Source และองค์กรที่มีผู้ร่วมงานไม่เกิน 5 คน
  * [webceo.com](https://www.webceo.com/) — เครื่องมือ SEO ที่มีฟีเจอร์ตรวจสอบโค้ดและรองรับการทดสอบบนอุปกรณ์หลากหลาย
  * [zoompf.com](https://zoompf.com/) — วิเคราะห์และแก้ไขปัญหาประสิทธิภาพเว็บไซต์อย่างละเอียด

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## การค้นหาและเรียกดูโค้ด

  * [libraries.io](https://libraries.io/) — ค้นหาและแจ้งเตือนอัปเดต dependency สำหรับ package manager 32 แบบ ฟรีสำหรับ open source
  * [Namae](https://namae.dev/) - ค้นหาชื่อโปรเจ็กต์ที่ว่างบนเว็บไซต์ต่างๆ เช่น GitHub, Gitlab, Heroku, Netlify ฯลฯ
  * [searchcode.com](https://searchcode.com/) — ค้นหาโค้ดแบบ text-based อย่างครอบคลุม ฟรีสำหรับ Open Source
  * [tickgit.com](https://www.tickgit.com/) — แสดง `TODO` comments (และ marker อื่นๆ) เพื่อระบุจุดที่ควรกลับไปปรับปรุง
  * [CodeKeep](https://codekeep.io) - Google Keep สำหรับบันทึกโค้ด snippet จัดระเบียบ, ค้นหา, และแชร์โค้ด พร้อมฟีเจอร์ถ่าย screenshot ของโค้ดด้วย template ที่ตั้งไว้และฟีเจอร์ลิงก์

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## CI และ CD

  * [AccessLint](https://github.com/marketplace/accesslint) — AccessLint ทดสอบ web accessibility อัตโนมัติใน workflow การพัฒนา ฟรีสำหรับ open source และการศึกษา
  * [appcircle.io](https://appcircle.io) — แพลตฟอร์ม Mobile DevOps ระดับองค์กรสำหรับ build, test, publish แอปมือถือ อัตโนมัติ ฟรีสูงสุด 30 นาทีต่อ build, 20 build/เดือน, และ 1 concurrent build
  * [appveyor.com](https://www.appveyor.com/) — บริการ CD สำหรับ Windows ฟรีสำหรับ Open Source
  * [LocalOps](https://localops.co/) - ดีพลอยแอปบน AWS/GCP/Azure ใน 30 นาที สร้างสภาพแวดล้อมมาตรฐานบนคลาวด์ใดก็ได้ มีระบบ continuous deployment และ observability ขั้นสูง แพ็กเกจฟรีสำหรับ 1 ผู้ใช้ และ 1 สภาพแวดล้อม
  * [Argonaut](https://argonaut.dev/) - ดีพลอยแอปและ infrastructure บนคลาวด์ของคุณในไม่กี่นาที รองรับการดีพลอยแอปแบบ custom และ third-party บน Kubernetes และ Lambda แพ็กเกจฟรีดีพลอยไม่จำกัดสำหรับ 5 โดเมน และ 2 ผู้ใช้
  * [bitrise.io](https://www.bitrise.io/) — CI/CD สำหรับแอปมือถือ native หรือ hybrid ฟรี 200 build/เดือน, 10 นาที/build, 2 สมาชิก ทีม OSS ได้ 45 นาที/build, +1 concurrency, ทีมไม่จำกัด
  * [buddy.works](https://buddy.works/) — CI/CD ฟรี 5 โปรเจ็กต์, 1 concurrent run (120 executions/เดือน)
  * [Buildkite](https://buildkite.com) CI Pipelines ฟรี 3 ผู้ใช้, 5,000 job minutes/เดือน Test Analytics ฟรี 100,000 test executions/เดือน และฟรีมากขึ้นสำหรับโอเพ่นซอร์ส
  * [bytebase.com](https://www.bytebase.com/) — Database CI/CD และ DevOps ฟรีไม่เกิน 20 ผู้ใช้ และ 10 database instance
  * [CircleCI](https://circleci.com/) — แพลตฟอร์ม CI/CD ครบวงจร ฟรีพร้อมฟีเจอร์ทั้งหมดสำหรับ GitHub, GitLab, BitBucket รองรับ resource class, Docker, Windows, Mac OS, ARM, local runner, test splitting, Docker Layer Caching ฯลฯ ฟรีสูงสุด 6,000 นาที/เดือน, ผู้ร่วมงานไม่จำกัด, 30 งานขนานในโปรเจ็กต์ส่วนตัว, และสูงสุด 80,000 นาที build ฟรีสำหรับ Open Source
  * [cirrus-ci.org](https://cirrus-ci.org) - ฟรีสำหรับ public repo บน GitHub
  * [cirun.io](https://cirun.io) - ฟรีสำหรับ public repo บน GitHub
  * [codefresh.io](https://codefresh.io) — Free-for-Life plan: 1 build, 1 environment, shared servers, public repo ไม่จำกัด
  * [codemagic.io](https://codemagic.io/) - ฟรี 500 build นาที/เดือน
  * [codeship.com](https://codeship.com/) — 100 private build/เดือน, 5 โปรเจ็กต์ส่วนตัว, ไม่จำกัดสำหรับ Open Source
  * [deploybot.com](https://www.deploybot.com/) — 1 repo, 10 deployments, ฟรีสำหรับ Open Source
  * [deployhq.com](https://www.deployhq.com/) — 1 โปรเจ็กต์, 10 ดีพลอย/วัน (30 นาที build/เดือน)
  * [drone](https://cloud.drone.io/) - Drone Cloud รัน Continuous Delivery pipeline ได้หลายสถาปัตยกรรมทั้ง x86 และ Arm (32/64 บิต) ในที่เดียว
  * [LayerCI](https://layerci.com) — CI สำหรับโปรเจ็กต์ full stack มี full stack preview environment ฟรี 1 ชุด, RAM 5GB & 3 CPU
  * [semaphoreci.com](https://semaphoreci.com/) — ฟรีสำหรับ Open Source, 100 private build/เดือน
  * [Squash Labs](https://www.squash.io/) — สร้าง VM สำหรับแต่ละ branch และให้แอปใช้งานผ่าน URL เฉพาะ ฟรี public & private repo ไม่จำกัด, VM สูงสุด 2 GB
  * [styleci.io](https://styleci.io/) — รองรับเฉพาะ public GitHub repo
  * [Mergify](https://mergify.io) — workflow automation และ merge queue สำหรับ GitHub — ฟรีสำหรับ public GitHub repo
  * [Make](https://www.make.com/en) — เครื่องมือ workflow automation เชื่อมต่อแอปและ API ยอดนิยม ใช้ UI ฟรีสำหรับ public GitHub repo และแพ็กเกจฟรี 100 Mb, 1,000 Operations, interval ต่ำสุด 15 นาที
  * [Spacelift](https://spacelift.io/) - แพลตฟอร์มบริหาร Infrastructure as Code แพ็กเกจฟรี: IaC collaboration, Terraform module registry, ChatOps, ตรวจสอบ resource compliance ด้วย Open Policy Agent, SSO SAML 2.0, เข้าถึง public worker pools: สูงสุด 200 นาที/เดือน
  * [microtica.com](https://microtica.com/) - สร้าง startup environment ด้วย infrastructure component สำเร็จรูป ดีพลอยแอปบน AWS ฟรี รองรับ workload production แพ็กเกจฟรีมี 1 Environment (ใน AWS ของคุณ), 2 Kubernetes Service, 100 build นาที/เดือน, 20 deployment/เดือน
* [Nx Cloud](https://nx.dev/ci) - Nx Cloud ช่วยเร่งความเร็วให้กับ monorepos ของคุณบน CI ด้วยฟีเจอร์ต่าง ๆ เช่น remote caching, การกระจายงานข้ามเครื่อง และการแบ่งชุดทดสอบ e2e อัตโนมัติ มีแผนฟรีสำหรับผู้ร่วมงานสูงสุด 30 คน พร้อมเครดิต 150,000 เครดิตต่อเดือน
* [blacksmith](https://www.blacksmith.sh/) - จัดการ performance runner สำหรับ GitHub Actions พร้อมใช้งานฟรี 3,000 นาทีต่อเดือน ไม่ต้องใช้บัตรเครดิต
* [Terramate](https://terramate.io/) - แพลตฟอร์ม orchestration และการจัดการสำหรับ Infrastructure as Code (IaC) เช่น Terraform, OpenTofu และ Terragrunt ฟรีสำหรับผู้ใช้สูงสุด 2 คน พร้อมฟีเจอร์ครบถ้วน
* [Terrateam](https://terrateam.io) - ระบบอัตโนมัติ Terraform แบบ GitOps-first ด้วย workflow ที่ขับเคลื่อนด้วย pull request, การแบ่งโปรเจกต์ด้วย self-hosted runner และการรันแบบชั้นสำหรับการดำเนินการตามลำดับ ฟรีสำหรับผู้ใช้สูงสุด 3 คน

**[⬆️ กลับไปด้านบน](#table-of-contents)**

## การทดสอบ

* [Applitools.com](https://applitools.com/) — การตรวจสอบภาพอัจฉริยะสำหรับเว็บ, แอปมือถือ native และแอปเดสก์ท็อป ผสานรวมกับโซลูชันอัตโนมัติแทบทุกชนิด (เช่น Selenium และ Karma) และ remote runner (เช่น Sauce Labs, Browser Stack) ฟรีสำหรับโอเพ่นซอร์ส มีแผนฟรีสำหรับผู้ใช้เดี่ยวที่มีจุดตรวจสอบจำกัดต่อสัปดาห์
* [Appetize](https://appetize.io) — ทดสอบแอป Android & iOS ของคุณบน emulator มือถือ/แท็บเล็ต Android และ simulator iPhone/iPad บนคลาวด์ผ่านเบราว์เซอร์ แผนฟรีรองรับ 2 session พร้อมเวลาใช้งาน 30 นาทีต่อเดือน ไม่จำกัดขนาดแอป
* [Apptim](https://apptim.com) — เครื่องมือทดสอบมือถือที่ช่วยให้ผู้ไม่มีทักษะด้าน performance engineering สามารถประเมินประสิทธิภาพแอปและ UX ได้ เวอร์ชั่นเดสก์ท็อปใช้เครื่องของคุณเอง ฟรี 100% พร้อมการทดสอบไม่จำกัดบน iOS และ Android
* [Argos](https://argos-ci.com) - การทดสอบภาพแบบโอเพ่นซอร์สสำหรับนักพัฒนา โปรเจกต์ไม่จำกัด พร้อม 5,000 ภาพหน้าจอต่อเดือน ฟรีสำหรับโปรเจกต์โอเพ่นซอร์ส
* [Bencher](https://bencher.dev/) - ชุดเครื่องมือ benchmarking แบบต่อเนื่องเพื่อจับ performance regression บน CI ฟรีสำหรับโปรเจกต์สาธารณะทั้งหมด
* [browserstack.com](https://www.browserstack.com/) — ทดสอบเบราว์เซอร์ทั้งแบบ manual และอัตโนมัติ, [ฟรีสำหรับโอเพ่นซอร์ส](https://www.browserstack.com/open-source?ref=pricing)
* [BugBug](https://bugbug.io/) - เครื่องมืออัตโนมัติทดสอบเว็บแอปที่น้ำหนักเบา ใช้งานง่ายโดยไม่ต้องเขียนโค้ด สามารถรันทดสอบไม่จำกัดบนเครื่องของคุณเองได้ฟรี มีบริการ cloud monitoring และเชื่อมต่อ CI/CD ด้วยค่าบริการเพิ่มเติม
* [Checkly](https://checklyhq.com) - การตรวจสอบแบบ synthetic monitoring สำหรับ DevOps สมัยใหม่ ตรวจสอบ API และแอปของคุณในราคาย่อมเยากว่าผู้ให้บริการรุ่นเก่า ขับเคลื่อนด้วย workflow Monitoring as Code และ Playwright ฟรี tier ใจกว้างสำหรับ dev
* [checkbot.io](https://www.checkbot.io/) — ส่วนเสริมเบราว์เซอร์สำหรับตรวจสอบว่าเว็บไซต์ของคุณเป็นไปตาม best practices ด้าน SEO, ความเร็ว และความปลอดภัยกว่า 50 ข้อ มีฟรี tier สำหรับเว็บไซต์ขนาดเล็ก
* [CORS-Tester](https://cors-error.dev/cors-tester/) - เครื่องมือฟรีสำหรับนักพัฒนาและผู้ทดสอบ API เพื่อตรวจสอบว่า API เปิดใช้งาน CORS สำหรับโดเมนที่กำหนดหรือไม่ พร้อมคำแนะนำที่นำไปใช้ได้จริง
* [cypress.io](https://www.cypress.io/) - การทดสอบที่รวดเร็ว ง่าย และเชื่อถือได้สำหรับทุกอย่างที่รันในเบราว์เซอร์ Cypress Test Runner เปิดให้ใช้ฟรีและโอเพ่นซอร์สโดยไม่มีข้อจำกัด Cypress Dashboard ฟรีสำหรับโปรเจกต์โอเพ่นซอร์สสูงสุด 5 ผู้ใช้
* [Cypress Recorder by Preflight](https://cypress.preflight.com/) - สร้าง Cypress Tests/POM models โดยใช้ AI บนเบราว์เซอร์ของคุณ เป็นโอเพ่นซอร์ส (ยกเว้นส่วน AI) ฟรีสำหรับการสร้างเทสต์ 5 ครั้งต่อเดือน พร้อม Self-healing script, อีเมล และ visual testing
* [everystep-automation.com](https://www.everystep-automation.com/) — บันทึกและเล่นซ้ำทุกขั้นตอนที่ทำในเบราว์เซอร์และสร้างสคริปต์ ฟรีแต่มีตัวเลือกน้อยกว่า
* [Gremlin](https://www.gremlin.com/gremlin-free-software) — เครื่องมือ Chaos Engineering ของ Gremlin ช่วยให้คุณ inject ความล้มเหลวเข้าสู่ระบบได้อย่างปลอดภัยเพื่อค้นหาจุดอ่อนก่อนจะเกิดปัญหากับลูกค้า Gremlin Free ให้ใช้งาน Shutdown และ CPU attack ได้สูงสุด 5 โฮสต์หรือคอนเทนเนอร์
* [gridlastic.com](https://www.gridlastic.com/) — Selenium Grid ทดสอบได้ฟรีสูงสุด 4 selenium node พร้อม 10 grid start และ 4,000 นาทีทดสอบต่อเดือน
* [katalon.com](https://katalon.com) - แพลตฟอร์มทดสอบที่เหมาะกับทีมทุกขนาดและระดับการทดสอบ รวมถึง Katalon Studio, TestOps (+ Visual Testing ฟรี), TestCloud และ Katalon Recorder
* [Keploy](https://keploy.io/) - ชุดเครื่องมือทดสอบฟังก์ชันสำหรับนักพัฒนา บันทึก API call เพื่อสร้าง E2E test (KTests) และ mock/stub (KMocks) ฟรีสำหรับโปรเจกต์โอเพ่นซอร์ส
* [knapsackpro.com](https://knapsackpro.com) - เร่งความเร็วการทดสอบด้วยการแบ่งชุดทดสอบอย่างเหมาะสมบน CI ทุกเจ้า แบ่งการทดสอบ Ruby, JavaScript บน CI node แบบขนานเพื่อประหยัดเวลา แผนฟรีสำหรับ test file 10 นาที และไม่จำกัดสำหรับโอเพ่นซอร์ส
* [lambdatest.com](https://www.lambdatest.com/) — ทดสอบเบราว์เซอร์แบบ manual, visual, screenshot และอัตโนมัติบน selenium และ cypress, [ฟรีสำหรับโอเพ่นซอร์ส](https://www.lambdatest.com/open-source-cross-browser-testing-tool)
* [loadmill.com](https://www.loadmill.com/) - สร้าง API และ load test อัตโนมัติโดยวิเคราะห์ network traffic จำลองผู้ใช้พร้อมกันสูงสุด 50 คน สูงสุด 60 นาทีต่อเดือนฟรี
* [lost-pixel.com](https://lost-pixel.com) - การทดสอบ visual regression แบบครบวงจรสำหรับ Storybook, Ladle, Histoire stories และเว็บแอป สมาชิกทีมไม่จำกัด ฟรีสำหรับโอเพ่นซอร์ส 7,000 snapshot/เดือน
* [octomind.dev](https://www.octomind.dev/) - สร้างและดูแล Playwright UI test โดยอัตโนมัติด้วย AI
* [percy.io](https://percy.io) - เพิ่มการทดสอบภาพให้กับเว็บแอป, เว็บไซต์แบบ static, style guide หรือ component library สมาชิกทีมไม่จำกัด มี demo app โปรเจกต์ไม่จำกัด 5,000 snapshot/เดือน
* [preflight.com](https://preflight.com) - ทดสอบเว็บแบบอัตโนมัติโดยไม่ต้องเขียนโค้ด บันทึกเทสต์บนเบราว์เซอร์ที่ทนต่อการเปลี่ยนแปลง UI และรันบนเครื่อง Windows สามารถเชื่อมต่อกับ CI/CD ได้ แผนฟรีมี 50 เทสต์ต่อเดือน พร้อมวิดีโอ, HTML session และอื่น ๆ
* [qase.io](https://qase.io) - ระบบบริหารจัดการเทสต์สำหรับทีม Dev และ QA จัดการเทสต์, รัน, ติดตาม defect และวัดผลกระทบ แผนฟรีมีฟีเจอร์หลักครบถ้วน แนบไฟล์ได้ 500MB สูงสุด 3 ผู้ใช้
* [Repeato](https://repeato.app/) เครื่องมืออัตโนมัติทดสอบแอปมือถือแบบไม่ต้องโค้ด ใช้ computer vision และ AI รองรับ native, flutter, react-native, web, ionic และเฟรมเวิร์กอื่น ๆ แผนฟรีจำกัด 10 เทสต์ iOS และ 10 เทสต์ Android แต่มีฟีเจอร์หลักเหมือนแผนเสียเงิน รวมถึงรันทดสอบไม่จำกัด
* [Requestly](https://requestly.com/) ส่วนเสริม Chrome แบบโอเพ่นซอร์สสำหรับดัก, เปลี่ยนทาง, และ mock HTTP request มี [Debugger](https://requestly.com/products/web-debugger/), [Mock Server](https://requestly.com/products/mock-server/), [API Client](https://requestly.com/products/api-client/) และ [Session Recording](https://requestly.com/products/session-book/) เปลี่ยน URL, แก้ HTTP header, mock API, inject JS, แก้ไข GraphQL, สร้าง mock endpoint และบันทึก session พร้อม log เครือข่าย สร้างกฎได้สูงสุด 10 กฎใน Free Tier ฟรีสำหรับโอเพ่นซอร์ส
* [seotest.me](https://seotest.me/) — เครื่องมือทดสอบ SEO บนหน้าเว็บฟรี ตรวจเว็บได้ 10 เว็บต่อวัน มีแหล่งเรียนรู้ SEO และแนะนำวิธีปรับปรุง SEO สำหรับทุกเว็บไซต์ไม่จำกัดเทคโนโลยี
* [snippets.uilicious.com](https://snippets.uilicious.com) - คล้ายกับ CodePen แต่สำหรับทดสอบข้ามเบราว์เซอร์ UI-licious ให้คุณเขียนเทสต์แบบ user story และมีแพลตฟอร์มฟรี - UI-licious Snippets - ให้รันทดสอบบน Chrome ได้ไม่จำกัดโดยไม่ต้องสมัครใช้งาน สูงสุด 3 นาทีต่อการรัน เจอบั๊ก? คัดลอก URL เทสต์เพื่อส่งให้นักพัฒนาได้ทันที
* [TestCollab](https://testcollab.com) - ซอฟต์แวร์บริหารจัดการเทสต์ใช้งานง่าย แผนฟรีมี Jira integration, โปรเจกต์ไม่จำกัด, นำเข้าเทสต์ด้วย CSV/XLSx, บันทึกเวลา และที่เก็บไฟล์ 1GB
* [testingbot.com](https://testingbot.com/) — ทดสอบเบราว์เซอร์และอุปกรณ์ด้วย Selenium, [ฟรีสำหรับโอเพ่นซอร์ส](https://testingbot.com/open-source)
* [Testspace.com](https://testspace.com/) - Dashboard สำหรับเผยแพร่ผลการทดสอบอัตโนมัติ และ framework สำหรับทดสอบ manual แบบเป็นโค้ดบน GitHub [ฟรีสำหรับโอเพ่นซอร์ส](https://github.com/marketplace/testspace-com) พร้อม 450 ผลลัพธ์ต่อเดือน
* [tesults.com](https://www.tesults.com) — รายงานผลการทดสอบและบริหารจัดการเทสต์ เชื่อมต่อกับเฟรมเวิร์กยอดนิยม นักพัฒนาโอเพ่นซอร์ส, บุคคล, ผู้สอน และทีมเล็ก ๆ ขอรับสิทธิ์ฟรีหรือส่วนลดเพิ่มเติมได้เกินแผนฟรี
* [UseWebhook.com](https://usewebhook.com) - เก็บและตรวจสอบ webhook จากเบราว์เซอร์ ส่งต่อไปยัง localhost หรือ replay จาก history ใช้ได้ฟรี
* [Vaadin](https://vaadin.com) — สร้าง UI ที่ขยายขนาดได้ใน Java หรือ TypeScript พร้อมเครื่องมือ, คอมโพเนนต์ และ design system ในตัวเพื่อเร่งพัฒนา ออกแบบได้ดีขึ้น และลดความซับซ้อน โปรเจกต์ไม่จำกัด พร้อมดูแลฟรี 5 ปี
* [websitepulse.com](https://www.websitepulse.com/tools/) — เครื่องมือทดสอบเครือข่ายและเซิร์ฟเวอร์หลากหลายให้ใช้ฟรี
* [webhook-test.com](https://webhook-test.com) - ดีบักและตรวจสอบ webhook และ HTTP request ด้วย URL เฉพาะระหว่าง integration ฟรี 100% สร้าง URL ได้ไม่จำกัด พร้อมคำแนะนำ
* [webhook.site](https://webhook.site) - ตรวจสอบ webhook, outbound HTTP request หรืออีเมลด้วย URL เฉพาะ URL ชั่วคราวและอีเมลเปิดให้ใช้ฟรีเสมอ
* [webhookbeam.com](https://webhookbeam.com) - ตั้งค่า webhook และตรวจสอบผ่าน push notification และอีเมล

**[⬆️ กลับไปด้านบน](#table-of-contents)**

## ความปลอดภัยและ PKI

* [aikido.dev](https://www.aikido.dev) — แพลตฟอร์ม appsec all-in-one ครอบคลุม SCA, SAST, CSPM, DAST, Secret, IaC, Malware, Container scanning, EOL ฯลฯ แผนฟรีรองรับ 2 ผู้ใช้ สแกน repo ได้ 10 repo, 1 cloud, 2 container และ 1 โดเมน
* [alienvault.com](https://www.alienvault.com/open-threat-exchange/reputation-monitor) — ตรวจสอบระบบที่ถูก compromise ในเครือข่ายของคุณ
* [Altcha.org](https://altcha.org/anti-spam) - ระบบกรองสแปมสำหรับเว็บไซต์และ API ขับเคลื่อนด้วย NLP และ machine learning แผนฟรีรองรับ 200 request ต่อวันต่อโดเมน
* [atomist.com](https://atomist.com/) — วิธีที่เร็วกว่าและสะดวกกว่าในการอัตโนมัติกระบวนการพัฒนาต่าง ๆ ขณะนี้อยู่ในช่วงเบต้า
* [cloudsploit.com](https://cloudsploit.com/) — การตรวจสอบและ audit ความปลอดภัย AWS
* [Public Cloud Threat Intelligence](https://cloudintel.himanshuanand.com/) — Indicator of Compromise (IOC) ที่เชื่อถือได้สำหรับโครงสร้างพื้นฐาน cloud สาธารณะ มีบางส่วนบน github (https://github.com/unknownhad/AWSAttacks) รายการเต็มใช้ API
* [CodeNotary.io](https://www.codenotary.io/) — แพลตฟอร์มโอเพ่นซอร์สสำหรับโนตาไรซ์โค้ด ไฟล์ ไดเรกทอรี หรือ container ด้วยหลักฐานที่ลบไม่ได้
* [crypteron.com](https://www.crypteron.com/) — แพลตฟอร์มความปลอดภัยสำหรับนักพัฒนา ป้องกันข้อมูลรั่วใน .NET และ Java แบบ cloud-first ใช้งานง่าย
* [CyberChef](https://gchq.github.io/CyberChef/) — เว็บแอปวิเคราะห์และเข้ารหัส/ถอดรหัสข้อมูลแบบใช้งานง่ายเหมือนมีดสวิสสำหรับงานเข้ารหัส ฟีเจอร์ทั้งหมดใช้ฟรี ไม่มีข้อจำกัด โอเพ่นซอร์สสำหรับ self-host
* [DAS](https://signup.styra.com/) — Styra DAS Free จัดการ policy lifecycle เต็มรูปแบบสำหรับสร้าง, deploy และบริหาร Open Policy Agent (OPA) authorization
* [Datree](https://www.datree.io/) — CLI tool แบบโอเพ่นซอร์สสำหรับป้องกัน Kubernetes misconfiguration ให้ manifest และ Helm chart ปฏิบัติตาม best practices และนโยบายองค์กร
* [Dependabot](https://dependabot.com/) อัปเดต dependency อัตโนมัติสำหรับ Ruby, JavaScript, Python, PHP, Elixir, Rust, Java (Maven และ Gradle), .NET, Go, Elm, Docker, Terraform, Git Submodules และ GitHub Actions
* [DJ Checkup](https://djcheckup.com) — สแกนเว็บไซต์ Django ของคุณเพื่อหาช่องโหว่ด้านความปลอดภัยด้วยเครื่องมืออัตโนมัติ ฟรี fork มาจาก Pony Checkup
* [Doppler](https://doppler.com/) — Universal Secrets Manager สำหรับแอปและ config รองรับการ sync ไปยังคลาวด์ต่าง ๆ ฟรีสำหรับ 5 ผู้ใช้ พร้อมการควบคุมสิทธิ์เบื้องต้น
* [Dotenv](https://dotenv.org/) — Sync ไฟล์ .env ของคุณอย่างรวดเร็วและปลอดภัย เลิกแชร์ .env ผ่านช่องทางไม่ปลอดภัยอย่าง Slack หรืออีเมล และไม่สูญหายอีกต่อไป ฟรีสำหรับเพื่อนร่วมทีมสูงสุด 3 คน
* [GitGuardian](https://www.gitguardian.com) — ป้องกัน secret รั่วในซอร์สโค้ดด้วยการตรวจจับและแก้ไขอัตโนมัติ สแกน git repo สำหรับ secret และไฟล์สำคัญกว่า 350 แบบ ฟรีสำหรับบุคคลและทีมไม่เกิน 25 คน
* [Have I been pwned?](https://haveibeenpwned.com) — REST API สำหรับดึงข้อมูลการรั่วไหล
* [hostedscan.com](https://hostedscan.com) — สแกนหาช่องโหว่เว็บแอป, เซิร์ฟเวอร์ และเครือข่ายออนไลน์ ฟรี 10 ครั้งต่อเดือน
* [Infisical](https://infisical.com/) — แพลตฟอร์มโอเพ่นซอร์สสำหรับจัดการ secret นักพัฒนาทั้งทีมและโครงสร้างพื้นฐานทุกสภาพแวดล้อม ฟรีสูงสุด 5 นักพัฒนา
* [Internet.nl](https://internet.nl) — ทดสอบมาตรฐานอินเทอร์เน็ตรุ่นใหม่ เช่น IPv6, DNSSEC, HTTPS, DMARC, STARTTLS และ DANE
* [keychest.net](https://keychest.net) - จัดการวันหมดอายุ SSL และซื้อใบรับรองพร้อมฐานข้อมูล CT ในตัว
* [letsencrypt.org](https://letsencrypt.org/) — ออกใบรับรอง SSL ฟรี ที่เบราว์เซอร์หลักทุกเจ้ารับรอง
* [meterian.io](https://www.meterian.io/) - ตรวจสอบช่องโหว่ dependency ใน Java, Javascript, .NET, Scala, Ruby และ NodeJS ฟรี 1 โปรเจกต์ส่วนตัว, ไม่จำกัดสำหรับโอเพ่นซอร์ส
* [Mozilla Observatory](https://observatory.mozilla.org/) — ค้นหาและแก้ช่องโหว่ความปลอดภัยบนเว็บไซต์ของคุณ
* [opswat.com](https://www.opswat.com/) — ตรวจสอบความปลอดภัยคอมพิวเตอร์, อุปกรณ์, แอป, การตั้งค่า ฟรี 25 ผู้ใช้และดูประวัติ 30 วัน
* [openapi.security](https://openapi.security/) - เครื่องมือฟรีสำหรับตรวจสอบความปลอดภัย API ที่สร้างด้วย OpenAPI / Swagger ไม่ต้องสมัคร
* [pixee.ai](https://pixee.ai) - Product Security Engineer อัตโนมัติแบบบอทฟรีสำหรับ GitHub ส่ง PR เพื่อแก้ไขช่องโหว่ในโค้ด Java อัตโนมัติ ภาษาอื่นกำลังตามมา!
* [pyup.io](https://pyup.io) — ติดตามช่องโหว่ dependency Python และอัปเดตอัตโนมัติ ฟรี 1 โปรเจกต์ส่วนตัว ไม่จำกัดสำหรับโอเพ่นซอร์ส
* [qualys.com](https://www.qualys.com/community-edition) — ตรวจหาช่องโหว่เว็บแอป Audit ตาม OWASP Risk
* [report-uri.io](https://report-uri.io/) — รายงาน CSP และ HPKP violation
* [ringcaptcha.com](https://ringcaptcha.com/) — เครื่องมือใช้เบอร์โทรศัพท์เป็น ID เปิดให้ใช้ฟรี
* [seclookup.com](https://www.seclookup.com/) - Seclookup API เพิ่มข้อมูล domain threat ใน SIEM ให้ข้อมูลโดเมนอย่างละเอียดและช่วยตรวจจับภัยคุกคาม ฟรี 50,000 ครั้ง [ที่นี่](https://account.seclookup.com/)
* [snyk.io](https://snyk.io) — ค้นหาและแก้ไขช่องโหว่ security ใน dependency โอเพ่นซอร์ส ฟรีไม่จำกัดสำหรับโอเพ่นซอร์ส จำกัด 200 ครั้ง/เดือนสำหรับโปรเจกต์ส่วนตัว
* [ssllabs.com](https://www.ssllabs.com/ssltest/) — วิเคราะห์การตั้งค่า SSL web server อย่างละเอียด
* [SOOS](https://soos.io) - ฟรี SCA scan ไม่จำกัดสำหรับโอเพ่นซอร์ส ตรวจจับและแก้ภัยคุกคามก่อนปล่อยโปรเจกต์ ปกป้องโค้ดของคุณได้ง่ายและมีประสิทธิภาพ
* [StackHawk](https://www.stackhawk.com/) อัตโนมัติการสแกนแอปพลิเคชันใน pipeline เพื่อหาช่องโหว่ก่อนขึ้น production สแกนและ environment ไม่จำกัดสำหรับแอปเดียว
* [Sucuri SiteCheck](https://sitecheck.sucuri.net) - ตรวจสอบความปลอดภัยเว็บไซต์และสแกน malware ฟรี
* [Protectumus](https://protectumus.com) - ฟรีเช็คความปลอดภัยเว็บไซต์, สแกนไวรัสเว็บ, firewall (WAF) สำหรับ PHP มี email แจ้งเตือนสำหรับผู้ใช้ฟรีที่ลงทะเบียน
* [TestTLS.com](https://testtls.com) - ทดสอบ SSL/TLS service สำหรับการตั้งค่าเซิร์ฟเวอร์, ใบรับรอง ฯลฯ ไม่จำกัดเฉพาะ HTTPS
* [threatconnect.com](https://threatconnect.com) — Threat Intelligence สำหรับนักวิจัย, นักวิเคราะห์ และองค์กรที่เริ่มต้นด้าน cyber threat intelligence ฟรี 3 ผู้ใช้
* [tinfoilsecurity.com](https://www.tinfoilsecurity.com/) — สแกนช่องโหว่อัตโนมัติ แผนฟรีสแกน XSS รายสัปดาห์
* [Ubiq Security](https://ubiqsecurity.com/) — เข้ารหัสและถอดรหัสข้อมูลด้วยโค้ด 3 บรรทัด พร้อมจัดการกุญแจอัตโนมัติ ฟรี 1 แอป และสูงสุด 1,000,000 การเข้ารหัสต่อเดือน
* [Virgil Security](https://virgilsecurity.com/) — เครื่องมือและบริการสำหรับ end-to-end encryption, ปกป้องฐานข้อมูล, IoT security ฯลฯ ฟรีสำหรับแอปที่มีผู้ใช้ไม่เกิน 250 คน
* [Vulert](https://vulert.com) - Vulert ตรวจสอบ dependency โอเพ่นซอร์สของคุณอย่างต่อเนื่องเพื่อหาช่องโหว่ใหม่ แนะนำวิธีแก้ไขโดยไม่ต้องติดตั้งหรือเข้าถึงโค้ด ฟรีสำหรับโอเพ่นซอร์ส
* [Escape GraphQL Quickscan](https://escape.tech/) - สแกนความปลอดภัย endpoint GraphQL เพียงคลิกเดียว ฟรี ไม่ต้องล็อกอิน
* [HasMySecretLeaked](https://gitguardian.com/hasmysecretleaked) - ค้นหา secret ที่หลุดกว่า 20 ล้านรายการใน public GitHub repo, gist, issue และ comment ได้ฟรี
* [Project Gatekeeper](https://gatekeeper.binarybiology.top/) - ชุดเครื่องมือ SSL ครบวงจร เช่น Private Key & CSR Generator, SSL Certificate Decoder, Certificate Matcher และสั่งซื้อ SSL Certificate สามารถขอใบรับรอง SSL ฟรีจาก Let's Encrypt, Google Trust และ BuyPass ด้วย CNAME Record (ไม่ต้องใช้ TXT)
**[⬆️ กลับไปด้านบน](#table-of-contents)**

## การยืนยันตัวตน การอนุญาต และการจัดการผู้ใช้

  * [Aserto](https://www.aserto.com) - การให้สิทธิ์แบบละเอียดในรูปแบบบริการสำหรับแอปพลิเคชันและ API ฟรีสูงสุด 1,000 MAUs และ 100 อินสแตนซ์ authorizer
  * [asgardeo.io](https://wso2.com/asgardeo) - การรวม SSO, MFA, การยืนยันตัวตนแบบไร้รหัสผ่าน และอื่น ๆ อย่างไร้รอยต่อ รวม SDK สำหรับแอปฝั่งหน้าและหลัง ฟรีสูงสุด 1,000 MAUs และผู้ให้บริการตัวตนห้าราย
  * [Auth0](https://auth0.com/) — SSO แบบโฮสต์ แผนฟรีรวม 25,000 MAUs, การเชื่อมต่อ Social ไม่จำกัด, โดเมนแบบกำหนดเอง และอื่น ๆ
  * [Authgear](https://www.authgear.com) - นำระบบไร้รหัสผ่าน, OTPs, 2FA, SSO มาสู่แอปของคุณในไม่กี่นาที รวมส่วนหน้าให้ทั้งหมด ฟรีสูงสุด 5,000 MAUs
  * [Authress](https://authress.io/) — ระบบล็อกอินและควบคุมสิทธิ์การเข้าใช้ รองรับผู้ให้บริการตัวตนไม่จำกัดสำหรับทุกโปรเจกต์ Facebook, Google, Twitter และอื่น ๆ ฟรี 1,000 API calls แรก
  * [Authy](https://authy.com) - การยืนยันตัวตนแบบสองขั้นตอน (2FA) บนอุปกรณ์หลายเครื่อง พร้อมระบบสำรอง ใช้งานแทน Google Authenticator ได้ ฟรีสำหรับ 100 การยืนยันตัวตนที่สำเร็จแรก
  * [Cerbos Hub](https://www.cerbos.dev/product-cerbos-hub) - ระบบจัดการสิทธิ์การเข้าถึงแบบครบวงจรสำหรับการสร้าง ทดสอบ และนำไปใช้งานนโยบายสิทธิ์ ระดับรายละเอียดสูง ฟรีสูงสุด 100 principals ที่ใช้งานต่อเดือน
  * [Clerk](https://clerk.com) — ระบบจัดการผู้ใช้ การยืนยันตัวตน 2FA/MFA ส่วนประกอบ UI สำเร็จรูปสำหรับลงชื่อเข้าใช้ สมัครสมาชิก โปรไฟล์ผู้ใช้ และอื่น ๆ ฟรีสูงสุด 10,000 ผู้ใช้ที่ใช้งานต่อเดือน
  * [Cloud-IAM](https://www.cloud-iam.com/) — Keycloak Identity and Access Management as a Service ฟรีสูงสุด 100 ผู้ใช้ และ 1 realm
  * [Corbado](https://www.corbado.com/) — เพิ่มการยืนยันตัวตนแบบ passkey-first ให้กับแอปใหม่หรือที่มีอยู่ ฟรีสำหรับ MAUs ไม่จำกัด
  * [Descope](https://www.descope.com/) — กระบวนการ AuthN ที่ปรับแต่งได้สูง มีทั้งแบบ no-code และ API/SDK ฟรี 7,500 ผู้ใช้ที่ใช้งานต่อเดือน, 50 tenant (รองรับสูงสุด 5 SAML/SSO tenant)
  * [duo.com](https://duo.com/) — การยืนยันตัวตนแบบสองขั้นตอน (2FA) สำหรับเว็บไซต์หรือแอป ฟรีสำหรับ 10 ผู้ใช้ ทุกวิธีการยืนยันตัวตน ไม่จำกัดการเชื่อมต่อ token ฮาร์ดแวร์
  * [Kinde](https://kinde.com/) - ระบบยืนยันตัวตนที่เรียบง่ายและแข็งแกร่ง ผสานเข้ากับผลิตภัณฑ์ของคุณในไม่กี่นาที ฟรี 7,500 MAU
  * [logintc.com](https://www.logintc.com/) — 2FA ผ่าน push notifications ฟรีสำหรับ 10 ผู้ใช้, VPN, เว็บไซต์ และ SSH
  * [MojoAuth](https://mojoauth.com/) - MojoAuth ช่วยให้การนำระบบไร้รหัสผ่านมาใช้ในเว็บ แอปมือถือ หรือแอปใด ๆ ง่ายในไม่กี่นาที
  * [Okta](https://developer.okta.com/signup/) — ระบบจัดการผู้ใช้ การยืนยันตัวตนและการอนุญาต ฟรีสูงสุด 100 ผู้ใช้ที่ใช้งานต่อเดือน
  * [onelogin.com](https://www.onelogin.com/) — Identity as a Service (IDaaS), SSO, Cloud SSO IdP, แอปบริษัท 3 แอป, แอปส่วนตัว 5 แอป, ผู้ใช้ไม่จำกัด
  * [Ory](https://ory.sh/) - AuthN/AuthZ/OAuth2.0/Zero Trust แพลตฟอร์มความปลอดภัยแบบ managed บัญชีนักพัฒนาใช้ฟรีตลอดชีพ รวมฟีเจอร์ความปลอดภัยทั้งหมด สมาชิกทีมไม่จำกัด 200 ผู้ใช้ที่ใช้งานต่อวัน และตรวจสอบสิทธิ์ 25k ครั้ง/เดือน
  * [Permit.io](https://permit.io) - แพลตฟอร์ม Authorization-as-a-service รองรับ RBAC, ABAC, ReBAC สำหรับไมโครเซอร์วิสแบบขยายขนาด พร้อมอัปเดตแบบเรียลไทม์และ UI นโยบายแบบ no-code ฟรี 1,000 MAU
  * [Phase Two](https://phasetwo.io) - Keycloak Open Source Identity and Access Management ฟรี 1 realm สูงสุด 1,000 ผู้ใช้, SSO 10 connections, ใช้ Phase Two's Keycloak enhanced container รวม [Organization](https://phasetwo.io/product/organizations/) extension
  * [SSOJet](https://ssojet.com/) - เพิ่ม Enterprise SSO โดยไม่ต้องสร้างระบบ auth ใหม่ แผนฟรี: MAU ไม่จำกัด, องค์กรไม่จำกัด, SSO 2 connections & SCIM 2 connections
  * [Stytch](https://www.stytch.com/) - แพลตฟอร์มรวม API และ SDK สำหรับการยืนยันตัวตนและป้องกันการโกง แผนฟรี: 10,000 MAU, องค์กรไม่จำกัด, SSO หรือ SCIM 5 connections, M2M token 1,000 รายการ
  * [Stack Auth](https://stack-auth.com) — การยืนยันตัวตนโอเพนซอร์สที่ใช้งานง่ายสำหรับนักพัฒนา Self-host ฟรี หรือเลือก SaaS แบบ managed ฟรี 10,000 MAU
  * [SuperTokens](https://supertokens.com/) - การยืนยันตัวตนโอเพนซอร์สที่ผสานเข้ากับแอปของคุณโดยตรง เริ่มต้นได้รวดเร็วและควบคุมประสบการณ์ผู้ใช้/นักพัฒนา ฟรีสูงสุด 5,000 MAUs
  * [Warrant](https://warrant.dev/) — บริการควบคุมสิทธิ์ระดับองค์กรแบบโฮสต์สำหรับแอปของคุณ แผนฟรี: 1 ล้าน API request/เดือน และ 1,000 กฎ authz
  * [ZITADEL Cloud](https://zitadel.com) — ระบบจัดการผู้ใช้และสิทธิ์แบบ turnkey รองรับกรณี multi-tenant (B2B) ฟรี 25,000 authenticated request พร้อมฟีเจอร์ความปลอดภัยทั้งหมด (ไม่เสียค่าใช้จ่ายสำหรับ OTP, ไร้รหัสผ่าน, นโยบาย ฯลฯ)
  * [PropelAuth](https://propelauth.com) — ขายบริการให้บริษัทได้ทันทีด้วยโค้ดเพียงไม่กี่บรรทัด ฟรี 200 ผู้ใช้ 10,000 อีเมลธุรกรรม (มีลายน้ำ "Powered by PropelAuth")
  * [Logto](https://logto.io/) - พัฒนา ปกป้อง และจัดการตัวตนผู้ใช้ของผลิตภัณฑ์คุณ ทั้งยืนยันตัวตนและการอนุญาต ฟรีสูงสุด 5,000 MAUs และรองรับ self-host แบบโอเพนซอร์ส
  * [WorkOS](https://workos.com/) - ฟรีสำหรับการจัดการผู้ใช้และการยืนยันตัวตนสูงสุด 1 ล้าน MAUs รองรับอีเมล + รหัสผ่าน, social auth, Magic Auth, MFA และอื่น ๆ


**[⬆️ กลับไปด้านบน](#table-of-contents)**

## การแจกจ่ายและข้อเสนอแนะสำหรับแอปมือถือ

  * [TestApp.io](https://testapp.io) - แพลตฟอร์มสำหรับตรวจสอบให้แน่ใจว่าแอปมือถือของคุณทำงานได้ถูกต้อง แผนฟรี: 1 แอป, วิเคราะห์ข้อมูล, เวอร์ชันและติดตั้งไม่จำกัด, เก็บข้อเสนอแนะได้
  * [Loadly](https://loadly.io) - บริการแจกจ่ายแอป beta สำหรับ iOS & Android ฟรีสมบูรณ์ ดาวน์โหลดไม่จำกัด ดาวน์โหลดเร็ว อัปโหลดไม่จำกัด
  * [Diawi](https://www.diawi.com) - ติดตั้งแอป iOS & Android ลงอุปกรณ์โดยตรง แผนฟรี: อัปโหลดแอป, ลิงก์ป้องกันด้วยรหัสผ่าน, ลิงก์หมดอายุ 1 วัน, ติดตั้งได้ 10 ครั้ง
  * [InstallOnAir](https://www.installonair.com) - แจกจ่ายแอป iOS & Android แบบ OTA แผนฟรี: อัปโหลดไม่จำกัด, ลิงก์ส่วนตัว, ลิงก์หมดอายุ 2 วันสำหรับ guest, 60 วันสำหรับผู้ใช้ที่ลงทะเบียน
  * [GetUpdraft](https://www.getupdraft.com) - แจกจ่ายแอปมือถือเพื่อทดสอบ แผนฟรี: 1 โปรเจกต์, 3 เวอร์ชันแอป, พื้นที่ 500 MB, ติดตั้งแอป 100 ครั้ง/เดือน
  * [Appho.st](https://appho.st) - แพลตฟอร์มโฮสต์แอปมือถือ แผนฟรี: 5 แอป, ดาวน์โหลด 50 ครั้ง/เดือน, ไฟล์สูงสุด 100 MB

**[⬆️ กลับไปด้านบน](#table-of-contents)**

## ระบบจัดการ

  * [bitnami.com](https://bitnami.com/) — ติดตั้งแอปสำเร็จรูปบน IaaS จัดการ AWS micro instance ฟรี 1 เครื่อง
  * [Esper](https://esper.io) — MDM และ MAM สำหรับอุปกรณ์ Android พร้อม DevOps ฟรี 100 อุปกรณ์ ผู้ใช้ 1 license และ Application Storage 25 MB
  * [jamf.com](https://www.jamf.com/) —  จัดการอุปกรณ์ iPad, iPhone, Mac ฟรี 3 อุปกรณ์
  * [Miradore](https://miradore.com) — บริการจัดการอุปกรณ์ อัปเดตอุปกรณ์และรักษาความปลอดภัยให้ไม่จำกัด ฟรีแผนพื้นฐาน
  * [moss.sh](https://moss.sh) - ช่วยนักพัฒนาติดตั้งและจัดการเว็บแอป/เซิร์ฟเวอร์ ฟรี 25 git deploy/เดือน
  * [runcloud.io](https://runcloud.io/) - จัดการเซิร์ฟเวอร์ โฟกัสหลักที่ PHP project ฟรี 1 เซิร์ฟเวอร์
  * [ploi.io](https://ploi.io/) - เครื่องมือจัดการเซิร์ฟเวอร์และดีพลอยไซต์ ใช้งานง่าย ฟรี 1 เซิร์ฟเวอร์
  * [xcloud.host](https://xcloud.host) — แพลตฟอร์มจัดการและดีพลอยเซิร์ฟเวอร์ UI ใช้งานง่าย ฟรี 1 เซิร์ฟเวอร์
  * [serveravatar.com](https://serveravatar.com) — จัดการ/มอนิเตอร์เซิร์ฟเวอร์เว็บ PHP ด้วยการตั้งค่าอัตโนมัติ ฟรี 1 เซิร์ฟเวอร์

**[⬆️ กลับไปด้านบน](#table-of-contents)**

## การรับส่งข้อความและสตรีมมิ่ง

  * [Ably](https://www.ably.com/) - ระบบรับส่งข้อความแบบเรียลไทม์พร้อม presence, persistence, การรับประกันการส่ง แผนฟรี: ข้อความ 3 ล้าน/เดือน, 100 การเชื่อมต่อสูงสุด, 100 ช่องสูงสุด
  * [cloudamqp.com](https://www.cloudamqp.com/) — RabbitMQ as a Service แผน Little Lemur: ข้อความสูงสุด 1 ล้าน/เดือน, เชื่อมต่อสูงสุด 20, คิวสูงสุด 100, ข้อความในคิวสูงสุด 10,000, หลายโหนดใน AZ ต่างกัน
  * [courier.com](https://www.courier.com/) — API เดียวสำหรับ push, in-app, อีเมล, แชท, SMS ฯลฯ พร้อมจัดการ template แผนฟรี 10,000 ข้อความ/เดือน
  * [engagespot.co](https://engagespot.co/) — โครงสร้างการแจ้งเตือน multi-channel สำหรับนักพัฒนา พร้อมกล่องขาเข้าในแอปและตัวแก้ไข template แบบ no-code แผนฟรี 10,000 ข้อความ/เดือน
  * [HiveMQ](https://www.hivemq.com/mqtt-cloud-broker/) - เชื่อมต่ออุปกรณ์ MQTT กับ Cloud Native IoT Messaging Broker ฟรีตลอดชีพสำหรับ 100 อุปกรณ์ (ไม่ต้องใช้บัตรเครดิต)
  * [knock.app](https://knock.app) – โครงสร้างแจ้งเตือนสำหรับนักพัฒนา ส่งได้หลายช่องทางใน API เดียว เช่น in-app, อีเมล, SMS, Slack, push แผนฟรี 10,000 ข้อความ/เดือน
  * [NotificationAPI.com](https://www.notificationapi.com/) — เพิ่มการแจ้งเตือนให้ซอฟต์แวร์ใน 5 นาที แผนฟรี 10,000 การแจ้งเตือน/เดือน + SMS 100 ครั้งและโทรอัตโนมัติ
  * [Novu.co](https://novu.co) — โครงสร้างแจ้งเตือนโอเพนซอร์สสำหรับนักพัฒนา จัดการทุกช่องทาง Email, SMS, Direct, In-App, Push ง่าย ๆ ในที่เดียว แผนฟรี 30,000 การแจ้งเตือน/เดือน เก็บข้อมูล 90 วัน
  * [pusher.com](https://pusher.com/) — ระบบรับส่งข้อความแบบเรียลไทม์ ฟรี 100 การเชื่อมต่อพร้อมกัน และ 200,000 ข้อความ/วัน
  * [scaledrone.com](https://www.scaledrone.com/) — ระบบรับส่งข้อความแบบเรียลไทม์ ฟรี 20 การเชื่อมต่อพร้อมกัน 100,000 event/วัน
  * [synadia.com](https://synadia.com/ngs) — [NATS.io](https://nats.io) as a service รองรับ Global, AWS, GCP, Azure ฟรีตลอดชีพ ขนาด msg 4k, การเชื่อมต่อ 50, ข้อมูล 5GB/เดือน
  * [pubnub.com](https://www.pubnub.com/) - Swift, Kotlin, React messaging ฟรี 1 ล้านธุรกรรมต่อเดือน ธุรกรรมอาจมีหลายข้อความ
  * [eyeson API](https://developers.eyeson.team/) - API สื่อสารวิดีโอบน WebRTC (SFU, MCU) สร้างแพลตฟอร์มวิดีโอ รองรับ Data Injection, Video Layouts, บันทึก, UI โฮสต์สำเร็จรูป (quickstart) หรือชุดพัฒนา UI แบบ custom ฟรี [free tier สำหรับนักพัฒนา](https://apiservice.eyeson.com/api-pricing) 1,000 นาทีประชุม/เดือน
  * [webpushr](https://www.webpushr.com/) - แจ้งเตือน Web Push ฟรีสูงสุด 10,000 subscribers, push ไม่จำกัด, ข้อความในเบราว์เซอร์
  * [httpSMS](https://httpsms.com) - ส่งและรับ SMS ผ่าน Android ของคุณเป็น SMS Gateway ฟรี 200 ข้อความ/เดือน
  * [EMQX Serverless](https://www.emqx.com/en/cloud/serverless-mqtt) - MQTT broker แบบ serverless ขยายขนาดและปลอดภัย ฟรี 1 ล้าน session minute/เดือน (ไม่ต้องใช้บัตรเครดิต)
  * [Pocket Alert](https://pocketalert.app) - ส่ง push notification ไปยัง iOS และ Android ของคุณ เชื่อมต่อผ่าน API หรือ Webhook ฟรี 50 ข้อความ/วัน 1 อุปกรณ์ 1 แอป
  * [SuprSend](https://www.suprsend.com/) - โครงสร้างการแจ้งเตือนที่รวมทุกอย่าง ส่ง notification ธุรกรรม, cron, engagement ได้หลายช่องทางผ่าน API เดียว ฟรี 10,000 การแจ้งเตือน/เดือน รองรับ node workflow เช่น digest, batch, multi-channel, preference, tenant, broadcast ฯลฯ

**[⬆️ กลับไปด้านบน](#table-of-contents)**

## การจัดการ Log

  * [bugfender.com](https://bugfender.com/) — ฟรีสูงสุด 100k log lines/วัน เก็บข้อมูล 24 ชั่วโมง
  * [logentries.com](https://logentries.com/) — ฟรีสูงสุด 5 GB/เดือน เก็บข้อมูล 7 วัน
  * [loggly.com](https://www.loggly.com/) — ฟรีสำหรับผู้ใช้เดียว 200MB/วัน เก็บข้อมูล 7 วัน
  * [logz.io](https://logz.io/) — ฟรีสูงสุด 1 GB/วัน เก็บข้อมูล 1 วัน
  * [ManageEngine Log360 Cloud](https://www.manageengine.com/cloud-siem/) — บริการ Log Management โดย Manage Engine แผนฟรี: พื้นที่ 50 GB เก็บข้อมูล 15 วัน ค้นหา 7 วัน
  * [papertrailapp.com](https://papertrailapp.com/) — ค้นหา 48 ชั่วโมง, เก็บ archive 7 วัน, 50 MB/เดือน
  * [sematext.com](https://sematext.com/logsene) — ฟรีสูงสุด 500 MB/วัน เก็บข้อมูล 7 วัน
  * [sumologic.com](https://www.sumologic.com/) — ฟรีสูงสุด 500 MB/วัน เก็บข้อมูล 7 วัน
  * [logflare.app](https://logflare.app/) — ฟรีสูงสุด 12,960,000 entries/แอป/เดือน เก็บข้อมูล 3 วัน
  * [logtail.com](https://logtail.com/) — จัดการ Log แบบ SQL (ClickHouse) ฟรีสูงสุด 1 GB/เดือน เก็บข้อมูล 3 วัน
  * [logzab.com](https://logzab.com/) — ระบบจัดการ audit trail ฟรี 1,000 user activity log/เดือน เก็บข้อมูล 1 เดือน สูงสุด 5 โปรเจกต์
  * [openobserve.ai](https://openobserve.ai/) - ฟรี 200 GB ingestion/เดือน เก็บข้อมูล 15 วัน


**[⬆️ กลับไปด้านบน](#table-of-contents)**

## การจัดการการแปลภาษา

  * [crowdin.com](https://crowdin.com/) — โปรเจกต์ไม่จำกัด, สตริงไม่จำกัด, และผู้ร่วมงานไม่จำกัดสำหรับโอเพ่นซอร์ส
  * [gitlocalize.com](https://gitlocalize.com) - ฟรีและไม่จำกัดทั้งรีโพสาธิ์แบบส่วนตัวและสาธารณะ
  * [Lecto](https://lecto.ai/) - API แปลภาษาด้วยเครื่อง พร้อมแพ็กเกจฟรี (30 คำขอต่อเดือน, 1,000 ตัวอักษรที่แปลต่อคำขอ) ผสานกับปลั๊กอิน Loco Translate ของ Wordpress
  * [lingohub.com](https://lingohub.com/) — ฟรีสูงสุด 3 ผู้ใช้ ฟรีตลอดไปสำหรับโอเพ่นซอร์ส
  * [localazy.com](https://localazy.com) - ฟรีสำหรับ 1,000 สตริงภาษาแหล่งที่มา, ไม่จำกัดภาษา, ไม่จำกัดผู้ร่วมงาน, ข้อเสนอสำหรับสตาร์ทอัพและโอเพ่นซอร์ส
  * [Localeum](https://localeum.com) - ฟรีสูงสุด 1,000 สตริง, 1 ผู้ใช้, ไม่จำกัดภาษา, ไม่จำกัดโปรเจกต์
  * [localizely.com](https://localizely.com/) — ฟรีสำหรับโอเพ่นซอร์ส
  * [Loco](https://localise.biz/) — ฟรีสูงสุด 2,000 การแปล, นักแปลไม่จำกัด, สิบภาษา/โปรเจกต์, ทรัพยากรที่แปลได้ 1,000 รายการ/โปรเจกต์
  * [oneskyapp.com](https://www.oneskyapp.com/) — รุ่นฟรีแบบจำกัดสำหรับสูงสุด 5 ผู้ใช้ ฟรีสำหรับโอเพ่นซอร์ส
  * [POEditor](https://poeditor.com/) — ฟรีสูงสุด 1,000 สตริง
  * [SimpleLocalize](https://simplelocalize.io/) - ฟรีสูงสุด 100 คีย์การแปล, สตริงไม่จำกัด, ภาษาไม่จำกัด, ข้อเสนอสำหรับสตาร์ทอัพ
  * [Texterify](https://texterify.com/) - ฟรีสำหรับผู้ใช้คนเดียว
  * [Tolgee](https://tolgee.io) - ให้บริการ SaaS ฟรีพร้อมการแปลจำกัด และมีเวอร์ชันโฮสต์เองแบบฟรีตลอดไป
  * [transifex.com](https://www.transifex.com/) — ฟรีสำหรับโอเพ่นซอร์ส
  * [Translation.io](https://translation.io) - ฟรีสำหรับโอเพ่นซอร์ส
  * [Translized](https://translized.com) - ฟรีสูงสุด 1,000 สตริง, 1 ผู้ใช้, ภาษาไม่จำกัด, โปรเจกต์ไม่จำกัด
  * [webtranslateit.com](https://webtranslateit.com/) — ฟรีสูงสุด 500 สตริง
  * [weblate.org](https://weblate.org/) — ฟรีสำหรับโปรเจกต์เสรีสูงสุด 10,000 สตริงแหล่งที่มาในแพ็กเกจฟรี และไม่จำกัดสำหรับการโฮสต์เองในองค์กร
  * [Free PO editor](https://pofile.net/free-po-editor) — ฟรีสำหรับทุกคน
  * [Lingo.dev](https://lingo.dev) – CLI แบบโอเพ่นซอร์สที่ขับเคลื่อนด้วย AI สำหรับ localization เว็บ & มือถือ นำ LLM มาใช้เอง หรือใช้ฟรี 10,000 คำต่อเดือนผ่าน localization engine ที่ Lingo.dev จัดการ

**[⬆️ กลับไปด้านบน](#table-of-contents)**

## การมอนิเตอร์

  * [UptimeObserver.com](https://uptimeobserver.com) - รับการมอนิเตอร์ uptime 20 รายการที่ช่วงเวลา 5 นาที พร้อมหน้าสถานะที่ปรับแต่งได้ แม้ใช้เชิงพาณิชย์ แจ้งเตือนแบบเรียลไทม์ไม่จำกัดทางอีเมลและ Telegram ไม่ต้องใช้บัตรเครดิตในการเริ่มต้น
  * [Pingmeter.com](https://pingmeter.com/) - การมอนิเตอร์ uptime 5 รายการที่ช่วงเวลา 10 นาที มอนิเตอร์ SSH, HTTP, HTTPS และพอร์ต TCP แบบกำหนดเอง
  * [alerty.ai](https://www.alerty.ai) - ฟรี APM และมอนิเตอร์สำหรับ FE, BE, DB และอื่น ๆ + agent ฟรี
  * [appdynamics.com](https://www.appdynamics.com/) — ฟรีสำหรับเมตริก 24 ชั่วโมง, ตัวจัดการประสิทธิภาพแอปพลิเคชันจำกัด 1 Java, 1 .NET, 1 PHP และ 1 Node.js
  * [appneta.com](https://www.appneta.com/) — ฟรีพร้อมการเก็บข้อมูล 1 ชั่วโมง
  * [appspector.com](https://appspector.com/) - ควบคุมภารกิจสำหรับ debug ระยะไกล iOS/Android/Flutter ฟรีสำหรับปริมาณข้อมูลขนาดเล็ก (64MB logs)
  * [assertible.com](https://assertible.com) — ทดสอบ API อัตโนมัติและมอนิเตอร์ มีแพ็กเกจฟรีสำหรับทีมและบุคคล
  * [bleemeo.com](https://bleemeo.com) - ฟรีสำหรับ 3 เซิร์ฟเวอร์, 5 การมอนิเตอร์ uptime, ผู้ใช้ไม่จำกัด, dashboard ไม่จำกัด, กฎแจ้งเตือนไม่จำกัด
  * [Core Web Vitals History](https://punits.dev/core-web-vitals-historical/) - ค้นหาประวัติ Core Web Vitals สำหรับ url หรือเว็บไซต์
  * [checklyhq.com](https://checklyhq.com) - มอนิเตอร์ E2E / Synthetic แบบโอเพ่นซอร์สและ API เชิงลึกสำหรับนักพัฒนา แผนฟรี 1 ผู้ใช้, 10,000 API & network / 1,500 browser check
  * [cloudsploit.com](https://cloudsploit.com) — มอนิเตอร์ความปลอดภัยและการตั้งค่า AWS ฟรี: สแกนตามต้องการไม่จำกัด, ผู้ใช้ไม่จำกัด, บัญชีที่จัดเก็บไม่จำกัด แบบสมัครสมาชิก: สแกนอัตโนมัติ, API, ฯลฯ
  * [cronitor.io](https://cronitor.io/) - ข้อมูลเชิงลึกประสิทธิภาพและมอนิเตอร์ uptime สำหรับ cron jobs, เว็บไซต์, API ฯลฯ แพ็กเกจฟรีมี 5 ตัวมอนิเตอร์
  * [datadoghq.com](https://www.datadoghq.com/) — ฟรีสูงสุด 5 โหนด
  * [deadmanssnitch.com](https://deadmanssnitch.com/) — มอนิเตอร์สำหรับ cron jobs ฟรี 1 snitch (มอนิเตอร์) เพิ่มได้โดยแนะนำเพื่อนสมัคร
  * [downtimemonkey.com](https://downtimemonkey.com/) — มอนิเตอร์ uptime 60 รายการ, ช่วงเวลา 5 นาที อีเมล, แจ้งเตือน Slack
  * [economize.cloud](https://economize.cloud) — ช่วยทำความเข้าใจต้นทุนโครงสร้างพื้นฐานคลาวด์ โดยจัดระเบียบทรัพยากรคลาวด์เพื่อเพิ่มประสิทธิภาพและรายงาน ฟรีสำหรับยอดใช้จ่าย Google Cloud Platform สูงสุด $5,000 ต่อเดือน
  * [elastic.co](https://www.elastic.co/solutions/apm) — ข้อมูลเชิงลึกประสิทธิภาพทันทีสำหรับนักพัฒนา JS ฟรีพร้อมการเก็บข้อมูล 24 ชั่วโมง
  * [fivenines.io](https://fivenines.io/) — มอนิเตอร์เซิร์ฟเวอร์ Linux พร้อมแดชบอร์ดและแจ้งเตือนแบบเรียลไทม์ ฟรีตลอดไปสูงสุด 5 เซิร์ฟเวอร์ที่ช่วงเวลา 60 วินาที ไม่ต้องใช้บัตรเครดิต
  * [Grafana Cloud](https://grafana.com/products/cloud/) - แพลตฟอร์มสังเกตการณ์ที่รวมเมตริกและ log กับ Grafana ฟรี: 3 ผู้ใช้, 10 dashboard, 100 การแจ้งเตือน, เก็บเมตริกใน Prometheus และ Graphite (10,000 series, 14 วัน), เก็บ log ใน Loki (50GB, 14 วัน)
  * [healthchecks.io](https://healthchecks.io) — มอนิเตอร์ cron jobs และงานเบื้องหลัง ฟรีสูงสุด 20 checks
  * [Hydrozen.io](https://hydrozen.io) — มอนิเตอร์ uptime & Status pages, แผนฟรี: มอนิเตอร์ uptime 10 รายการ, heartbeat 5 รายการ, โดเมน 1 รายการ, Statuspage 1 รายการฟรี
  * [incidenthub.cloud](https://incidenthub.cloud/) — ตัวรวมสถานะคลาวด์และ SaaS - มอนิเตอร์ 20 รายการและช่องแจ้งเตือน 2 ช่อง (Slack, Discord) ฟรีตลอดไป
  * [inspector.dev](https://www.inspector.dev) - แดชบอร์ดมอนิเตอร์แบบเรียลไทม์ครบถ้วนใน 1 นาที พร้อมแพ็กเกจฟรีตลอดไป
  * [instrumentalapp.com](https://instrumentalapp.com) - มอนิเตอร์แอปและเซิร์ฟเวอร์ ใช้ง่ายและสวยงาม สูงสุด 500 เมตริกและดูข้อมูลย้อนหลัง 3 ชั่วโมงฟรี
  * [keychest.net/speedtest](https://keychest.net/speedtest) - ทดสอบความเร็วอิสระและ latency TLS handshake กับ Digital Ocean
  * [letsmonitor.org](https://letsmonitor.org) - มอนิเตอร์ SSL ฟรีสูงสุด 5 ตัว
  * [linkok.com](https://linkok.com) - ตรวจสอบลิงก์เสียออนไลน์ ฟรีสำหรับเว็บขนาดเล็กสูงสุด 100 หน้า ฟรีสำหรับโปรเจกต์โอเพ่นซอร์ส
  * [loader.io](https://loader.io/) — เครื่องมือโหลดเทสต์ฟรีพร้อมข้อจำกัด
  * [MonitorMonk](https://monitormonk.com) - มอนิเตอร์ uptime แบบมินิมอลพร้อมหน้าสถานะสวยงาม แผนฟรีตลอดไปรองรับ HTTPS, Keyword, SSL, Response-time มอนิเตอร์ 10 เว็บไซต์หรือ API, มี 2 dashboard/status page
  * [netdata.cloud](https://www.netdata.cloud/) — Netdata เป็นเครื่องมือโอเพ่นซอร์สสำหรับเก็บเมตริกแบบเรียลไทม์ เป็นผลิตภัณฑ์ที่เติบโตและหาได้บน GitHub ด้วย
  * [newrelic.com](https://www.newrelic.com) — แพลตฟอร์มสังเกตการณ์ New Relic ช่วยให้นักพัฒนาสร้างซอฟต์แวร์ที่สมบูรณ์แบบยิ่งขึ้น จาก monolith ถึง serverless ตรวจสอบ วิเคราะห์ แก้ปัญหา และเพิ่มประสิทธิภาพทั้ง stack แผนฟรีมีข้อมูลฟรี 100GB/เดือน, ผู้ใช้เต็มสิทธิ์ฟรี 1 คน, ผู้ใช้หลักฟรีไม่จำกัด
  * [Middleware.io](https://middleware.io/) - แพลตฟอร์มสังเกตการณ์ Middleware ให้คุณเห็นทุกอย่างในแอปและ stack, มอนิเตอร์ log สูงสุด 1 ล้าน event, มอนิเตอร์โครงสร้างพื้นฐาน & APM สำหรับ 2 โฮสต์ ฟรีตลอดไปสำหรับชุมชนนักพัฒนา
  * [nixstats.com](https://nixstats.com) - ฟรีสำหรับ 1 เซิร์ฟเวอร์ แจ้งเตือนอีเมล, public status page, ช่วงเวลา 60 วินาที ฯลฯ
  * [OnlineOrNot.com](https://onlineornot.com/) - มอนิเตอร์ uptime เว็บไซต์และ API, cron jobs, scheduled tasks และหน้าสถานะ ฟรี 5 checks แรกที่ช่วงเวลา 3 นาที แจ้งเตือนฟรีผ่าน Slack, Discord, Email
  * [OntarioNet.ca CN Test](https://cntest.ontarionet.ca) — ตรวจสอบว่าเว็บไซต์ถูกบล็อกในจีนโดย Great Firewall หรือไม่ โดยเปรียบเทียบผล DNS และ ASN จากเซิร์ฟเวอร์ในจีนกับสหรัฐ
  * [opsgenie.com](https://www.opsgenie.com/) — แจ้งเตือนและจัดการ on-call สำหรับบริการที่ต้องออนไลน์ตลอดเวลา ฟรีสูงสุด 5 ผู้ใช้
  * [paessler.com](https://www.paessler.com/) — โซลูชันมอนิเตอร์โครงสร้างพื้นฐานและเครือข่าย พร้อมแจ้งเตือน แสดงผลดี และรายงานพื้นฐาน ฟรีสูงสุด 100 เซ็นเซอร์
  * [pagecrawl.io](https://pagecrawl.io/) - มอนิเตอร์การเปลี่ยนแปลงเว็บไซต์ ฟรีสูงสุด 6 monitors เช็กวันละครั้ง
  * [syagent.com](https://syagent.com/) — บริการมอนิเตอร์เซิร์ฟเวอร์ฟรีสำหรับใช้ไม่เชิงพาณิชย์ พร้อมแจ้งเตือนและเมตริก
  * [pagerly.io](https://pagerly.io/) - จัดการ on-call บน Slack (เชื่อมกับ Pagerduty, OpsGenie) ฟรีสำหรับ 1 ทีม (1 ทีม = 1 on call)
  * [pagertree.com](https://pagertree.com/) - อินเทอร์เฟซแจ้งเตือนและ on-call ที่ใช้งานง่าย ฟรีสูงสุด 5 ผู้ใช้
  * [phare.io](https://phare.io/) - มอนิเตอร์ uptime ฟรีสูงสุด 100,000 events สำหรับโปรเจกต์และสถานะไม่จำกัด
  * [pingbreak.com](https://pingbreak.com/) — บริการมอนิเตอร์ uptime สมัยใหม่ ตรวจสอบ URL ไม่จำกัด แจ้งเตือน downtime ทาง Discord, Slack หรืออีเมล
  * [pingpong.one](https://pingpong.one/) — แพลตฟอร์ม status page พร้อมมอนิเตอร์ แผนฟรีมีหน้าสถานะสาธารณะ 1 หน้า ปรับแต่งได้พร้อม SSL Pro ฟรีสำหรับโอเพ่นซอร์ส/องค์กรไม่แสวงหากำไร
  * [robusta.dev](https://home.robusta.dev/) — มอนิเตอร์ Kubernetes ทรงพลังบน Prometheus ใช้ Prometheus เองหรือ bundle all-in-one ฟรีสูงสุด 20 โหนด แจ้งเตือนผ่าน Slack, MS Teams, Discord ฯลฯ เชื่อมกับ PagerDuty, OpsGenie, VictorOps, DataDog ฯลฯ
  * [sematext.com](https://sematext.com/) — ฟรีสำหรับเมตริก 24 ชม., เซิร์ฟเวอร์ไม่จำกัด, เมตริกกำหนดเอง 10 ตัว, 500,000 datapoints, dashboard ไม่จำกัด, ผู้ใช้ไม่จำกัด ฯลฯ
  * [sitemonki.com](https://sitemonki.com/) — มอนิเตอร์เว็บไซต์, โดเมน, Cron & SSL ฟรี 5 ตัวในแต่ละหมวด
  * [sitesure.net](https://sitesure.net) - มอนิเตอร์เว็บไซต์และ cron ฟรี 2 ตัว
  * [skylight.io](https://www.skylight.io/) — ฟรีสำหรับ 100,000 requests แรก (เฉพาะ Rails)
  * [speedchecker.xyz](https://probeapi.speedchecker.xyz/) — API มอนิเตอร์ประสิทธิภาพ ตรวจสอบ Ping, DNS ฯลฯ
  * [stathat.com](https://www.stathat.com/) — เริ่มต้นฟรีกับ 10 สถิติ ไม่มีหมดอายุ
  * [statuscake.com](https://www.statuscake.com/) — มอนิเตอร์เว็บไซต์ ทดสอบไม่จำกัดฟรี (มีข้อจำกัด)
  * [statusgator.com](https://statusgator.com/) — มอนิเตอร์ status page ฟรี 3 ตัว
  * [SweetUptime](https://dicloud.net/sweetuptime-server-uptime-monitoring/) — มอนิเตอร์เซิร์ฟเวอร์ uptime DNS & โดเมน ฟรี 10 server 10 uptime 10 domain
  * [thousandeyes.com](https://www.thousandeyes.com/) — มอนิเตอร์เครือข่ายและประสบการณ์ผู้ใช้ ฟรี 3 จุดตรวจสอบ 20 data feed เว็บใหญ่
  * [uptimetoolbox.com](https://uptimetoolbox.com/) — มอนิเตอร์ฟรีสำหรับ 5 เว็บไซต์, ช่วงเวลา 60 วินาที, statuspage สาธารณะ
  * [zenduty.com](https://www.zenduty.com/) — แพลตฟอร์มจัดการ incident, แจ้งเตือน, on-call และการตอบสนองแบบ end-to-end สำหรับ network, SRE, DevOps ทีม ฟรีสูงสุด 5 ผู้ใช้
  * [instatus.com](https://instatus.com) - สร้าง status page สวยใน 10 วินาที ฟรีตลอดไป subs และทีมไม่จำกัด
  * [Squadcast.com](https://squadcast.com) - ซอฟต์แวร์จัดการ incident end-to-end สำหรับ SRE แผนฟรีตลอดไปสูงสุด 10 ผู้ใช้
  * [RoboMiri.com](https://robomiri.com/) - RoboMiri คือ uptime monitor ที่เสถียร รองรับ cronjob, keyword, เว็บไซต์, port, ping ฟรี 25 checks ที่ช่วงเวลา 3 นาที แจ้งเตือนทางโทรศัพท์, SMS, อีเมล, Webhooks
  * [Better Stack](https://betterstack.com/better-uptime) - มอนิเตอร์ uptime, จัดการ incident, on-call, status page ในผลิตภัณฑ์เดียว แผนฟรีมี 10 monitors, ตรวจสอบทุก 3 นาที, status page
  * [Pulsetic](https://pulsetic.com) - 10 monitors, ประวัติ Uptime/Logs 6 เดือน, status page ไม่จำกัด, โดเมนกำหนดเอง ฟรีตลอดไป แจ้งเตือนอีเมลไม่จำกัด ไม่ต้องใช้บัตรเครดิต
  * [Wachete](https://www.wachete.com) - มอนิเตอร์ 5 หน้า ตรวจสอบทุก 24 ชั่วโมง
  * [Xitoring.com](https://xitoring.com/) — มอนิเตอร์ uptime: ฟรี 20, มอนิเตอร์ Linux/Windows Server: ฟรี 5, Status page: ฟรี 1 - แอปมือถือ, ช่องแจ้งเตือนหลากหลาย ฯลฯ
  * [Servervana](https://servervana.com) - มอนิเตอร์ uptime ขั้นสูง รองรับโปรเจกต์และทีมขนาดใหญ่ HTTP, Browser, DNS, โดเมน, status page ฯลฯ ฟรี 10 HTTP, 1 DNS, 1 status page

**[⬆️ กลับไปด้านบน](#table-of-contents)**

## การจัดการ Crash และ Exception
  * [CatchJS.com](https://catchjs.com/) - ระบบติดตามข้อผิดพลาดของ JavaScript พร้อมภาพหน้าจอและเส้นทางการคลิก ฟรีสำหรับโปรเจกต์โอเพ่นซอร์ส
  * [bugsnag.com](https://www.bugsnag.com/) — ฟรีสำหรับข้อผิดพลาดสูงสุด 2,000 รายการ/เดือน หลังจากช่วงทดลองใช้งานเริ่มต้น
  * [elmah.io](https://elmah.io/) — ระบบบันทึกข้อผิดพลาดและมอนิเตอร์ uptime สำหรับนักพัฒนาเว็บ สมัครสมาชิก Small Business ฟรีสำหรับโปรเจกต์โอเพ่นซอร์ส
  * [Embrace](https://embrace.io/) — การมอนิเตอร์แอปมือถือ ฟรีสำหรับทีมขนาดเล็ก สูงสุด 1 ล้านเซสชันผู้ใช้ต่อปี
  * [exceptionless](https://exceptionless.com) — รายงานข้อผิดพลาด ฟีเจอร์ และล็อกแบบเรียลไทม์ และอื่น ๆ ฟรีสำหรับ 3,000 อีเวนต์ต่อเดือน/1 ผู้ใช้ โอเพ่นซอร์สและติดตั้งใช้งานเองได้ไม่จำกัด
  * [GlitchTip](https://glitchtip.com/) — ระบบติดตามข้อผิดพลาดแบบง่าย โอเพ่นซอร์ส รองรับ SDK ของ Sentry แบบโอเพ่นซอร์ส 1,000 อีเวนต์ต่อเดือนฟรี หรือโฮสต์เองได้โดยไม่จำกัด
  * [honeybadger.io](https://www.honeybadger.io) - มอนิเตอร์ Exception, uptime, และ cron ฟรีสำหรับทีมขนาดเล็กและโปรเจกต์โอเพ่นซอร์ส (12,000 ข้อผิดพลาด/เดือน)
  * [memfault.com](https://memfault.com) — แพลตฟอร์มสังเกตการณ์และดีบักอุปกรณ์บนคลาวด์ อุปกรณ์ฟรี 100 เครื่องสำหรับอุปกรณ์ [Nordic](https://app.memfault.com/register-nordic), [NXP](https://app.memfault.com/register-nxp), และ [Laird](https://app.memfault.com/register-laird)
  * [rollbar.com](https://rollbar.com/) — มอนิเตอร์ Exception และข้อผิดพลาด ฟรี 5,000 ข้อผิดพลาด/เดือน ผู้ใช้ไม่จำกัด เก็บข้อมูล 30 วัน
  * [sentry.io](https://sentry.io/) — Sentry ติดตามข้อยกเว้นของแอปแบบเรียลไทม์และมีแผนฟรีขนาดเล็ก ฟรีสำหรับ 5,000 ข้อผิดพลาด/เดือน/1 ผู้ใช้ ใช้งานได้ไม่จำกัดหากโฮสต์เอง
  * [Axiom](https://axiom.co/) — เก็บล็อกสูงสุด 0.5 TB พร้อมเก็บข้อมูล 30 วัน มีอินทิเกรตกับแพลตฟอร์มอย่าง Vercel และสามารถคิวรีข้อมูลขั้นสูงพร้อมการแจ้งเตือนทางอีเมล/Discord
  * [Semaphr](https://semaphr.com) — ฟรี Kill switch แบบ all-in-one สำหรับแอปมือถือของคุณ
  * [Jam](https://jam.dev) - รายงานบั๊กที่เป็นมิตรกับนักพัฒนาในคลิกเดียว แผนฟรีพร้อม Jam ไม่จำกัด
  * [Whitespace](https://whitespace.dev) – รายงานบั๊กในคลิกเดียวตรงในเบราว์เซอร์ของคุณ แผนฟรีพร้อมการบันทึกไม่จำกัดสำหรับการใช้งานส่วนตัว

**[⬆️ Back to Top](#table-of-contents)**

## Search

  * [algolia.com](https://www.algolia.com/) — โซลูชันค้นหาบนคลาวด์พร้อมรองรับการสะกดผิด ความเกี่ยวข้อง และไลบรารี UI เพื่อสร้างประสบการณ์ค้นหาได้ง่าย แผน "Build" ฟรี รวม 1M เอกสาร และ 10K การค้นหาต่อเดือน มี [ค้นหาคู่มือสำหรับนักพัฒนา](https://docsearch.algolia.com/) ฟรีด้วย
  * [bonsai.io](https://bonsai.io/) — ฟรี 1 GB หน่วยความจำ และ 1 GB พื้นที่จัดเก็บ
  * [CommandBar](https://www.commandbar.com/) - แถบค้นหาแบบ unified เป็นบริการ วิดเจ็ต/ปลั๊กอิน UI บนเว็บให้ผู้ใช้ค้นหาคอนเทนต์ เมนู ฟีเจอร์ต่าง ๆ ในโปรดักต์ของคุณ ฟรีสำหรับผู้ใช้แอคทีฟรายเดือนสูงสุด 1,000 ราย คำสั่งไม่จำกัด
  * [Orama Cloud](https://orama.com/pricing) — ฟรี 3 ดัชนี, 100,000 เอกสาร/ดัชนี, ค้นหา full-text/vector/hybrid ไม่จำกัด, วิเคราะห์ข้อมูล 60 วัน
  * [searchly.com](http://www.searchly.com/) — ฟรี 2 ดัชนี และ 20 MB พื้นที่เก็บข้อมูล
  * [easysitesearch.com](https://easysitesearch.com/) — วิดเจ็ตค้นหาและ API พร้อมระบบจัดทำดัชนีจากเว็บครอว์เลอร์แบบอัตโนมัติ ค้นหาได้ไม่จำกัดฟรี สำหรับสูงสุด 50 หน้าย่อย

**[⬆️ Back to Top](#table-of-contents)**

## การศึกษาและการพัฒนาอาชีพ

  * [FreeCodeCamp](https://www.freecodecamp.org/) - แพลตฟอร์มโอเพ่นซอร์สที่ให้คอร์สและใบรับรองฟรีด้าน Data Analysis, Information Security, Web Development และอื่น ๆ
  * [The Odin Project](https://www.theodinproject.com/) - แพลตฟอร์มโอเพ่นซอร์สฟรีพร้อมหลักสูตรเน้น JavaScript และ Ruby สำหรับพัฒนาเว็บ
  * [Free Professional Resume Templates & Editor](https://www.overleaf.com/latex/templates/tagged/cv) - แพลตฟอร์มฟรีพร้อมแม่แบบเรซูเม่มืออาชีพมากมาย พร้อมให้ก๊อป แก้ไข และดาวน์โหลดได้เต็มรูปแบบ รองรับ ATS
  * [DeepLearning.AI Short Courses](https://www.deeplearning.ai/short-courses/) - คอร์สสั้นฟรีจากผู้เชี่ยวชาญระดับอุตสาหกรรม เพื่อทดลองใช้เครื่องมือและเทคนิค Generative AI ล่าสุดภายในหนึ่งชั่วโมงหรือน้อยกว่า
  * [LabEx](https://labex.io) - พัฒนาทักษะ Linux, DevOps, Cybersecurity, Programming, Data Science และอื่น ๆ ผ่านห้องปฏิบัติการแบบอินเทอร์แอคทีฟและโปรเจกต์จริง
  * [Roadmap.sh](https://roadmap.sh) - แผนการเรียนรู้ฟรีครอบคลุมทุกด้านของการพัฒนาตั้งแต่ Blockchain ถึง UX Design
  * [Cisco Networking Academy, Skills for All](https://skillsforall.com/) - มีคอร์สฟรีที่สอดคล้องกับใบรับรองในหัวข้ออย่าง cybersecurity, networking, และ Python
  * [MIT OpenCourseWare](https://ocw.mit.edu/) - MIT OpenCourseWare เป็นการเผยแพร่วัสดุจากคอร์สกว่า 2,500 รายวิชาของ MIT ออนไลน์ฟรี แบ่งปันความรู้กับผู้เรียนและผู้สอนทั่วโลก ช่อง YouTube ดูได้ที่ [@mitocw](https://www.youtube.com/@mitocw/featured)
  * [W3Schools](https://www.w3schools.com/) - มีคู่มือฟรีด้านเทคโนโลยีเว็บ เช่น HTML, CSS, JavaScript และอื่น ๆ
  * [Khan Academy](https://www.khanacademy.org/computing/computer-programming) - คู่มือออนไลน์ฟรีสำหรับเรียน HTML/CSS, JavaScript และ SQL เบื้องต้นและขั้นสูง
  * [Full Stack Open](https://fullstackopen.com/en/) – คอร์สฟรีระดับมหาวิทยาลัยเรื่องการพัฒนาเว็บสมัยใหม่ด้วย React, Node.js, GraphQL, TypeScript ฯลฯ เรียนออนไลน์เต็มรูปแบบและเรียนด้วยตนเอง
  * [edX](https://www.edx.org/) - เข้าถึงคอร์สออนไลน์ฟรีกว่า 4,000 รายวิชาจาก 250 สถาบันชั้นนำ เช่น Harvard และ MIT มุ่งเน้นคอมพิวเตอร์ วิศวกรรม และวิทยาศาสตร์ข้อมูล
  * [Django-tutorial.dev](https://django-tutorial.dev) - คู่มือออนไลน์ฟรีสำหรับเรียน Django เป็นเฟรมเวิร์กแรก และให้ dofollow backlink ฟรีกับบทความที่ผู้ใช้เขียน

**[⬆️ Back to Top](#table-of-contents)**

## อีเมล

  * [10minutemail](https://10minutemail.com) - อีเมลชั่วคราวฟรีสำหรับการทดสอบ
  * [AhaSend](https://ahasend.com) - บริการอีเมลธุรกรรม ฟรี 1,000 อีเมลต่อเดือน พร้อมโดเมนไม่จำกัด สมาชิกทีมไม่จำกัด เว็บฮุค และเส้นทางข้อความในแผนฟรี
  * [AnonAddy](https://anonaddy.com) - ฟอร์เวิร์ดอีเมลแบบไม่ระบุชื่อโอเพ่นซอร์ส สร้างอีเมลแฝงได้ไม่จำกัด ฟรี
  * [Antideo](https://www.antideo.com/) — 10 คำขอ API ต่อชั่วโมงสำหรับตรวจสอบอีเมล, IP, และเบอร์โทรฯ ในแผนฟรี ไม่ต้องใช้บัตรเครดิต
  * [Brevo](https://www.brevo.com/) — 9,000 อีเมล/เดือน, 300 อีเมล/วัน ฟรี
  * [OneSignal](https://onesignal.com/) — 10,000 อีเมล/เดือน ไม่ต้องใช้บัตรเครดิต
  * [Bump](https://bump.email/) - ฟรี 10 อีเมล Bump, 1 โดเมนแบบกำหนดเอง
  * [Burnermail](https://burnermail.io/) – ฟรี 5 อีเมล Burner, 1 กล่องจดหมาย, ประวัติกล่องจดหมาย 7 วัน
  * [Buttondown](https://buttondown.email/) — บริการจดหมายข่าว ฟรีสูงสุด 100 subscribers
  * [CloudMailin](https://www.cloudmailin.com/) - รับอีเมลเข้าแบบ HTTP POST และส่งออกธุรกรรม - ฟรี 10,000 อีเมล/เดือน
  * [Contact.do](https://contact.do/) — ฟอร์มติดต่อในลิงก์ (bitly สำหรับฟอร์มติดต่อ)
  * [debugmail.io](https://debugmail.io/) — เซิร์ฟเวอร์อีเมลสำหรับทดสอบ ใช้งานง่ายสำหรับนักพัฒนา
  * [DNSExit](https://dnsexit.com/) - ฟรีสูงสุด 2 อีเมลภายใต้โดเมนของคุณ พร้อมพื้นที่ 100MB รองรับ IMAP, POP3, SMTP, SPF/DKIM
  * [EmailLabs.io](https://emaillabs.io/en) — ส่งอีเมลฟรีสูงสุด 9,000 ฉบับต่อเดือน สูงสุด 300 อีเมลต่อวัน
  * [EmailOctopus](https://emailoctopus.com) - สูงสุด 2,500 subscribers และ 10,000 อีเมลต่อเดือน ฟรี
  * [EmailJS](https://www.emailjs.com/) – ไม่ใช่เซิร์ฟเวอร์อีเมลเต็มระบบ; เป็นไคลเอนต์อีเมลสำหรับส่งอีเมลจากฝั่ง client โดยไม่ต้องเปิดเผย credentials แผนฟรีมี 200 คำขอต่อเดือน, 2 แม่แบบอีเมล, คำขอสูงสุด 50Kb, ประวัติผู้ติดต่อจำกัด
  * [EtherealMail](https://ethereal.email) - Ethereal เป็นบริการ SMTP จำลอง เหมาะสำหรับ Nodemailer และ EmailEngine (แต่ไม่จำกัดแค่นั้น) เป็นบริการอีเมลป้องกันธุรกรรมฟรีทั้งหมด ข้อความจะไม่ถูกส่งจริง
  * [Temp-Mail.org](https://temp-mail.org/en/) - อีเมลชั่วคราว/ใช้แล้วทิ้ง สร้างอีเมลจากโดเมนหลายแบบ อีเมลรีเฟรชทุกครั้งที่โหลดหน้าเว็บ ฟรีทั้งหมด ไม่มีค่าใช้จ่าย
  * [TempMailDetector.com](https://tempmaildetector.com/) - ตรวจสอบอีเมลสูงสุด 200 ฉบับต่อเดือนฟรี ว่าเป็นอีเมลชั่วคราวหรือไม่
  * [Emailvalidation.io](https://emailvalidation.io) - ฟรี 100 การตรวจสอบอีเมลต่อเดือน
  * [FakeMailGenerator.com](https://www.fakemailgenerator.com/) - ผู้สร้างอีเมลชั่วคราว/ใช้แล้วทิ้งของเยอรมัน รองรับ 10 โดเมน สร้างอีเมลไม่จำกัด (มีโฆษณา) ไม่มีค่าใช้จ่ายใด ๆ ทั้งสิ้น ฟรีทั้งหมด
  * [forwardemail.net](https://forwardemail.net) — ฟอร์เวิร์ดอีเมลฟรีสำหรับโดเมนแบบกำหนดเอง สร้างและฟอร์เวิร์ดอีเมลไม่จำกัดกับชื่อโดเมนของคุณ (**หมายเหตุ**: ถ้าใช้ TLD .casa, .cf, .click, .email, .fit, .ga, .gdn, .gq, .lat, .loan, .london, .men, .ml, .pl, .rest, .ru, .tk, .top, .work ต้องเสียเงินเนื่องจากสแปม)
  * [Imitate Email](https://imitate.email) - เซิร์ฟเวอร์อีเมล sandbox สำหรับทดสอบฟังก์ชันอีเมลใน build/qa และ ci/cd บัญชีฟรีรับ 15 อีเมล/วัน ตลอดไป
  * [ImprovMX](https://improvmx.com) – ฟอร์เวิร์ดอีเมลฟรี
  * [EForw](https://www.eforw.com) – ฟอร์เวิร์ดอีเมลฟรีสำหรับ 1 โดเมน รับและส่งอีเมลจากโดเมนของคุณ
  * [Inboxes App](https://inboxesapp.com) — สร้างอีเมลชั่วคราวได้สูงสุด 3 ฉบับ/วัน แล้วลบเมื่อเสร็จผ่านส่วนขยาย Chrome เหมาะสำหรับทดสอบ flow การสมัคร
  * [inboxkitten.com](https://inboxkitten.com/) - กล่องอีเมลชั่วคราว/ใช้แล้วทิ้ง ฟรี ลบอีเมลอัตโนมัติใน 3 วัน โอเพ่นซอร์สและติดตั้งเองได้
  * [mail-tester.com](https://www.mail-tester.com) — ทดสอบการตั้งค่า DNS/SPF/DKIM/DMARC ของอีเมล 20 ครั้ง/เดือน ฟรี
  * [dkimvalidator.com](https://dkimvalidator.com/) - ทดสอบการตั้งค่า DNS/SPF/DKIM/DMARC ของอีเมล ฟรี โดย roundsphere.com
  * [mailcatcher.me](https://mailcatcher.me/) — ดักจับอีเมลและแสดงผ่านเว็บอินเทอร์เฟซ
  * [mailchannels.com](https://www.mailchannels.com) - Email API พร้อม REST API และ SMTP integration ฟรีสูงสุด 3,000 อีเมล/เดือน
  * [Mailcheck.ai](https://www.mailcheck.ai/) - ป้องกันผู้ใช้สมัครด้วยอีเมลชั่วคราว 120 คำขอต่อชั่วโมง (~86,400 ต่อเดือน)
  * [Mailchimp](https://mailchimp.com/) — ฟรี 500 subscribers และ 1,000 อีเมล/เดือน
  * [Maildroppa](https://maildroppa.com) - ฟรีสูงสุด 100 subscribers และอีเมลไม่จำกัด รวมถึง automation
  * [MailerLite.com](https://www.mailerlite.com) — ฟรี 1,000 subscribers/เดือน, 12,000 อีเมล/เดือน
  * [MailerSend.com](https://www.mailersend.com) — Email API, SMTP, ฟรี 3,000 อีเมล/เดือนสำหรับอีเมลธุรกรรม
  * [mailinator.com](https://www.mailinator.com/) — ระบบอีเมลสาธารณะฟรี ใช้กล่องจดหมายใดก็ได้
  * [Mailjet](https://www.mailjet.com/) — ฟรี 6,000 อีเมล/เดือน (จำกัดส่ง 200 อีเมลต่อวัน)
  * [Mailnesia](https://mailnesia.com) - อีเมลชั่วคราว/ใช้แล้วทิ้ง ฟรี พร้อมเข้าเยี่ยมชมลิงก์ยืนยันอัตโนมัติ
  * [mailsac.com](https://mailsac.com) - Free API สำหรับทดสอบอีเมลชั่วคราว โฮสต์อีเมลสาธารณะฟรี ดักจับขาออก ส่งอีเมลไป Slack/websocket/webhook (จำกัด 1,500 API ต่อเดือน)
  * [Mailtrap.io](https://mailtrap.io/) — เซิร์ฟเวอร์ SMTP จำลองสำหรับพัฒนา แผนฟรีมี 1 กล่องจดหมาย 100 ข้อความ ไม่มีทีม 2 อีเมล/วินาที ไม่มี forward rules
  * [Mail7.io](https://www.mail7.io/) — ฟรีอีเมล Temp สำหรับนักพัฒนา QA สร้างอีเมลทันทีผ่าน Web Interface หรือ API
  * [Momentary Email](https://www.momentaryemail.com/) — ฟรีอีเมลชั่วคราว อ่านอีเมลเข้าในเว็บหรือผ่าน RSS feed
  * [Mutant Mail](https://www.mutantmail.com/) – ฟรี 10 อีเมลไอดี, 1 โดเมน, 1 กล่องจดหมาย กล่องเดียวสำหรับทุกอีเมลไอดี
  * [Outlook.com](https://outlook.live.com/owa/) - อีเมลและปฏิทินส่วนตัวฟรี
  * [Parsio.io](https://parsio.io) — ตัวแยกข้อมูลอีเมลฟรี (ฟอร์เวิร์ดอีเมล, แยกข้อมูล, ส่งไปยังเซิร์ฟเวอร์ของคุณ)
  * [pepipost.com](https://pepipost.com) — ฟรี 30,000 อีเมลในเดือนแรก จากนั้นฟรี 100 อีเมล/วัน
  * [Plunk](https://useplunk.com) - ฟรี 3,000 อีเมล/เดือน
  * [Postmark](https://postmarkapp.com/) - ฟรี 100 อีเมล/เดือน DMARC weekly digests ไม่จำกัด
  * [Proton Mail](https://proton.me/mail) - ผู้ให้บริการอีเมลปลอดภัยฟรีพร้อมการเข้ารหัส end-to-end ในตัว ฟรี 1GB
  * [Queuemail.dev](https://queuemail.dev) — API ส่งอีเมลที่เชื่อถือได้ แผนฟรี (10,000 อีเมล/เดือน) ส่งแบบอะซิงโครนัส ใช้ SMTP หลายตัวได้ มี blocklists, logging, tracking, webhooks ฯลฯ
  * [QuickEmailVerification](https://quickemailverification.com) — ตรวจสอบอีเมลฟรี 100 ฉบับต่อวันในแผนฟรี พร้อม API ฟรีอื่น ๆ เช่น DEA Detector, DNS Lookup, SPF Detector ฯลฯ
  * [Resend](https://resend.com) - API สำหรับอีเมลธุรกรรมสำหรับนักพัฒนา ส่งอีเมลฟรี 3,000 ฉบับ/เดือน, 100 ฉบับ/วัน, 1 โดเมนที่กำหนดเอง
  * [Sender](https://www.sender.net) ส่งอีเมลได้สูงสุด 15,000 ฉบับ/เดือน, ผู้ติดตามสูงสุด 2,500 คน
  * [Sendpulse](https://sendpulse.com) — ฟรี 500 ผู้ติดตาม/เดือน, 15,000 อีเมล/เดือน
  * [SimpleLogin](https://simplelogin.io/) – โอเพ่นซอร์ส โฮสต์เองได้ สำหรับอีเมลนามแฝง/การส่งต่อ ฟรี 5 นามแฝง แบนด์วิธไม่จำกัด ตอบกลับ/ส่งไม่จำกัด ฟรีสำหรับบุคลากรสายการศึกษา (นักศึกษา นักวิจัย ฯลฯ)
  * [Substack](https://substack.com) — บริการจดหมายข่าวฟรีไม่จำกัด เริ่มเสียค่าบริการเมื่อคุณเรียกเก็บเงินจากผู้อ่าน
  * [Sweego](https://www.sweego.io/) - API สำหรับอีเมลธุรกรรมในยุโรปสำหรับนักพัฒนา ส่งอีเมลได้ฟรี 500 ฉบับ/วัน
  * [Takeout](https://takeout.bysourfruit.com) - บริการอีเมลที่อัปเดตอยู่เสมอ ช่วยให้การส่งอีเมลเป็นเรื่องง่าย ฟรี 500 อีเมลธุรกรรม/เดือน
  * [temp-mail.io](https://temp-mail.io) — บริการอีเมลชั่วคราวแบบใช้แล้วทิ้งฟรี สามารถสร้างหลายอีเมลพร้อมกัน และมีการส่งต่อ
  * [tinyletter.com](https://tinyletter.com/) — ฟรี 5,000 ผู้ติดตาม/เดือน
  * [Touchlead](https://touchlead.app) - เครื่องมืออัตโนมัติด้านการตลาดอเนกประสงค์ พร้อมจัดการลีด สร้างฟอร์ม และระบบอัตโนมัติ ฟรีสำหรับจำนวนลีดและระบบอัตโนมัติที่จำกัด
  * [trashmail.com](https://www.trashmail.com) - อีเมลชั่วคราวฟรีพร้อมการส่งต่อและหมดอายุอัตโนมัติ
  * [Tuta](https://tuta.com/) - ผู้ให้บริการอีเมลปลอดภัยฟรีพร้อมเข้ารหัส End-to-end ในตัว ไม่มีโฆษณา ไม่มีการติดตาม ฟรี 1GB พื้นที่เก็บข้อมูล 1 ปฏิทิน (Tuta มี [แพ็กเกจเสียเงิน](https://tuta.com/pricing) ด้วย) และ Tuta เป็น [โอเพ่นซอร์สบางส่วน](https://github.com/tutao/tutanota) คุณสามารถโฮสต์เองได้
  * [Verifalia](https://verifalia.com/email-verification-api) — API ตรวจสอบอีเมลแบบเรียลไทม์ พร้อมยืนยันกล่องจดหมายและตรวจจับอีเมลชั่วคราว ฟรี 25 การตรวจสอบ/วัน
  * [verimail.io](https://verimail.io/) — บริการตรวจสอบอีเมลแบบกลุ่มและ API ฟรี 100 การตรวจสอบ/เดือน
  * [Zoho](https://www.zoho.com) — เริ่มต้นจากผู้ให้บริการอีเมล และขยายเป็นชุดบริการ ซึ่งหลายบริการมีแพ็กเกจฟรี รายการบริการที่มีแพ็กเกจฟรี :
     - [Email](https://zoho.com/mail) ฟรีสำหรับ 5 ผู้ใช้ 5GB/ผู้ใช้ & แนบไฟล์สูงสุด 25 MB ต่อฉบับ 1 โดเมน
     - [Zoho Assist](https://www.zoho.com/assist) — แผนฟรีตลอดชีพมี 1 concurrent remote support license และเข้าถึง 5 คอมพิวเตอร์แบบ unattended ได้ไม่จำกัดเวลา สำหรับงานอาชีพและส่วนบุคคล
     - [Sprints](https://zoho.com/sprints) ฟรีสำหรับ 5 ผู้ใช้, 5 โปรเจกต์ & พื้นที่จัดเก็บ 500MB
     - [Docs](https://zoho.com/docs) — ฟรีสำหรับ 5 ผู้ใช้ อัปโหลดไฟล์ได้สูงสุด 1GB และพื้นที่เก็บ 5GB มาพร้อม Zoho Office Suite (Writer, Sheets & Show)
     - [Projects](https://zoho.com/projects) — ฟรีสำหรับ 3 ผู้ใช้, 2 โปรเจกต์ & แนบไฟล์ได้สูงสุด 10 MB แผนเดียวกันนี้ใช้กับ [Bugtracker](https://zoho.com/bugtracker)
     - [Connect](https://zoho.com/connect) — ระบบทำงานร่วมกันในทีม ฟรีสำหรับ 25 ผู้ใช้ มี 3 กลุ่ม, 3 แอปกำหนดเอง, 3 กระดาน, 3 คู่มือ, และ 10 การเชื่อมต่อ พร้อมช่องทาง, อีเว้นท์ & ฟอรัม
     - [Meeting](https://zoho.com/meeting) — ประชุมออนไลน์สูงสุด 3 คน, Webinar สูงสุด 10 คน
     - [Vault](https://zoho.com/vault) — จัดการรหัสผ่าน ใช้งานฟรีสำหรับบุคคลทั่วไป
     - [Showtime](https://zoho.com/showtime) — ซอฟต์แวร์ประชุมออนไลน์สำหรับฝึกอบรมระยะไกล สูงสุด 5 คน
     - [Notebook](https://zoho.com/notebook) — ทางเลือกฟรีสำหรับ Evernote
     - [Wiki](https://zoho.com/wiki) — ฟรีสำหรับ 3 ผู้ใช้ พื้นที่เก็บ 50 MB ไม่จำกัดหน้า สำรองแบบ zip ได้, RSS & Atom feed, ควบคุมสิทธิ์, ปรับแต่ง CSS ได้
     - [Subscriptions](https://zoho.com/subscriptions) — จัดการบิลรายเดือนฟรีสำหรับลูกค้า/สมาชิก 20 ราย & 1 ผู้ใช้ Zoho ดูแลการชำระเงินทั้งหมด เก็บข้อมูลเมตริกของ 40 การสมัครล่าสุด
     - [Checkout](https://zoho.com/checkout) — จัดการบิลสินค้า 3 หน้า & รับชำระสูงสุด 50 ครั้ง
     - [Desk](https://zoho.com/desk) — จัดการบริการลูกค้า 3 เอเจนต์ ฐานความรู้ส่วนตัว และระบบตั๋วอีเมล เชื่อมต่อกับ [Assist](https://zoho.com/assist) สำหรับ 1 ช่างเทคนิคระยะไกล & 5 คอมพิวเตอร์แบบ unattended
     - [Cliq](https://zoho.com/cliq) — แชททีม พื้นที่เก็บ 100 GB ผู้ใช้ไม่จำกัด 100 คน/ช่อง & SSO
     - [Campaigns](https://zoho.com/campaigns) - การตลาดผ่านอีเมล
     - [Forms](https://zoho.com/forms) - สร้างฟอร์ม
     - [Sign](https://zoho.com/sign) - ลายเซ็นอิเล็กทรอนิกส์
     - [Surveys](https://zoho.com/surveys) - แบบสำรวจออนไลน์
     - [Bookings](https://zoho.com/bookings) - ระบบนัดหมาย
  * [Maileroo](https://maileroo.com) - SMTP relay และ Email API สำหรับนักพัฒนา ฟรี 5,000 อีเมล/เดือน โดเมนไม่จำกัด ตรวจสอบอีเมลฟรี ตรวจสอบ blacklist ตัวทดสอบอีเมล และอื่นๆ

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## แพลตฟอร์มจัดการ Feature Toggles

  * [ConfigCat](https://configcat.com) - บริการ feature flag สำหรับนักพัฒนา ทีมขนาดไม่จำกัด ซัพพอร์ตดี ราคาเหมาะสม แผนฟรีรองรับ 10 flags, 2 environment, 1 product และ 5 ล้าน request/เดือน
  * [Flagsmith](https://flagsmith.com) - ปล่อยฟีเจอร์อย่างมั่นใจ จัดการ feature flag ได้ทั้งเว็บ, มือถือ และฝั่งเซิร์ฟเวอร์ ใช้ API ที่โฮสต์, ติดตั้ง private cloud หรือรันในองค์กรได้
  * [GrowthBook](https://growthbook.io) - ผู้ให้บริการ feature flag และ A/B testing แบบโอเพ่นซอร์ส พร้อม Bayesian statistical analysis ในตัว ฟรีสำหรับ 3 ผู้ใช้แรก ไม่จำกัด flags และ experiments
  * [Hypertune](https://www.hypertune.com) - Feature flag ที่ type-safe, A/B testing, analytics และกำหนดค่าการทำงานของแอป พร้อมระบบควบคุมเวอร์ชันแบบ Git และประเมิน flag แบบ local ใน memory ฟรีสำหรับสมาชิกทีม 5 คน ไม่จำกัด flags และ A/B test
  * [Molasses](https://www.molasses.app) - Feature flag และ A/B testing ที่ทรงพลัง ฟรี 3 environment แต่ละ environment ใช้ได้ 5 flag
  * [Toggled.dev](https://www.toggled.dev) - แพลตฟอร์มจัดการ feature toggle พร้อมใช้งานระดับองค์กร ขยายได้หลายภูมิภาค แผนฟรีรองรับ 10 flag, 2 environment, request ไม่จำกัด รวม SDK, dashboard, ปฏิทินปล่อยฟีเจอร์, แจ้งเตือน Slack และฟีเจอร์อื่นๆ ในแพ็กเกจฟรีตลอดชีพ
  * [Statsig](https://www.statsig.com) - แพลตฟอร์มจัดการฟีเจอร์ A/B testing analytics และอื่นๆ แผนฟรีให้ที่นั่งไม่จำกัด flags, experiments, และ config ไม่จำกัด รองรับ event สูงสุด 1 ล้าน/เดือน
  * [Abby](https://www.tryabby.com) - Feature flag และ A/B testing แบบโอเพ่นซอร์ส กำหนดค่าด้วยโค้ด SDK Typescript แบบ Typed เชื่อมต่อกับ Next.js & React ได้ดี มีแผนฟรีและขยายได้ในราคาถูก

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## ฟอนต์

  * [dafont](https://www.dafont.com/) - ฟอนต์ในเว็บไซต์นี้เป็นทรัพย์สินของผู้สร้าง อาจเป็นฟรีแวร์ แชร์แวร์ เดโม หรือสาธารณสมบัติ
  * [Everything Fonts](https://everythingfonts.com/) - มีเครื่องมือหลายอย่าง; @font-face, ตัวแปลงหน่วย, Font Hinter และ Font Submitter
  * [Font Squirrel](https://www.fontsquirrel.com/) - ฟอนต์ฟรีแวร์สำหรับใช้เชิงพาณิชย์ มีการคัดเลือกอย่างดี ใช้งานง่าย
  * [Google Fonts](https://fonts.google.com/) - ฟอนต์ฟรีมากมาย ติดตั้งลงเว็บไซต์ได้ง่ายและเร็ว ทั้งแบบดาวน์โหลดหรือเชื่อมกับ Google CDN
  * [FontGet](https://www.fontget.com/) - มีฟอนต์หลากหลาย จัดหมวดหมู่ด้วยแท็ก ดาวน์โหลดได้
  * [Fontshare](https://www.fontshare.com/) - บริการฟอนต์ฟรี เกรดโปรฯ เติบโตขึ้นเรื่อยๆ ฟรี 100% ใช้ได้ทั้งเชิงส่วนตัวและเชิงพาณิชย์
  * [Befonts](https://befonts.com/) - ให้ฟอนต์หลากหลายแบบ ใช้ได้ทั้งเชิงส่วนตัวหรือเชิงพาณิชย์
  * [Font of web](https://fontofweb.com/) - ตรวจสอบว่ามีฟอนต์อะไรบ้างในเว็บไซต์ และใช้ฟอนต์นั้นอย่างไร
  * [Bunny](https://fonts.bunny.net) Google Fonts ที่เน้นความเป็นส่วนตัว
  * [FontsKey](https://www.fontskey.com/) - ฟอนต์ฟรีและเชิงพาณิชย์สำหรับใช้ส่วนตัว พิมพ์ข้อความเพื่อคัดกรองได้อย่างรวดเร็ว
  * [fonts.xz.style](https://fonts.xz.style/) บริการฟรีและโอเพ่นซอร์สสำหรับส่งฟอนต์ไปยังเว็บไซต์ด้วย CSS
  * [Fontsensei](https://fontsensei.com/) Google fonts แบบโอเพ่นซอร์สที่ติดแท็กโดยผู้ใช้ รองรับฟอนต์ CJK (จีน ญี่ปุ่น เกาหลี)

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## ฟอร์ม

  * [Feathery](https://feathery.io) - สร้างฟอร์มที่ทรงพลัง เป็นมิตรกับนักพัฒนา ใช้งานสร้างฟอร์มสมัครสมาชิก เข้าสู่ระบบ onboarding, รับชำระเงิน, แอปการเงินที่ซับซ้อน ฯลฯ แผนฟรีส่งข้อมูลได้ 250 ครั้ง/เดือน มีฟอร์ม 5 ชุด
  * [Form-Data](https://form-data.com) - Backend ฟอร์มแบบไม่ต้องเขียนโค้ด มี spam filter, แจ้งเตือนอีเมล, ตอบกลับอัตโนมัติ, webhook, zapier, redirect, AJAX/POST ฯลฯ แผนฟรีสร้างฟอร์มได้ไม่จำกัด ส่งข้อมูลได้ 20 ครั้ง/เดือน เพิ่มอีก 2000 ครั้งหากมี badge Form-Data
  * [FabForm](https://fabform.io/) - ฟอร์ม backend สำหรับนักพัฒนายุคใหม่ แผนฟรีรับข้อมูลฟอร์มได้ 250 ครั้ง/เดือน GUI ทันสมัย ใช้งานร่วมกับ Google Sheets, Airtable, Slack, Email ฯลฯ
  * [Form.taxi](https://form.taxi/) — Endpoint สำหรับรับข้อมูลจาก HTML forms พร้อมแจ้งเตือน, ตัวกันสแปม และประมวลผลข้อมูลตาม GDPR แผนฟรีสำหรับการใช้งานขั้นพื้นฐาน
  * [Formcarry.com](https://formcarry.com) - HTTP POST Form endpoint แผนฟรีส่งข้อมูลได้ 100 ครั้ง/เดือน
  * [formingo.co](https://www.formingo.co/)- สร้างฟอร์ม HTML สำหรับเว็บ static ใช้งานฟรีไม่ต้องสมัคร แผนฟรีรับข้อมูล 500 ครั้ง/เดือน และกำหนด reply-to email ได้
  * [FormKeep.com](https://www.formkeep.com/) - สร้างฟอร์มไม่จำกัด รับข้อมูล 50 ครั้ง/เดือน ป้องกันสแปม แจ้งเตือนทางอีเมล ออกแบบลาก-วาง export HTML ได้ ฟีเจอร์เพิ่มเช่นกฎฟิลด์ ทีมงาน และเชื่อมต่อ Google Sheets, Slack, ActiveCampaign, Zapier
  * [formlets.com](https://formlets.com/) — ฟอร์มออนไลน์ ไม่จำกัดฟอร์มหน้าเดียว/เดือน รับข้อมูล 100 ครั้ง/เดือน แจ้งเตือนอีเมล
  * [formspark.io](https://formspark.io/) -  รับฟอร์มผ่านอีเมล แผนฟรีสร้างฟอร์มไม่จำกัด ส่งข้อมูล 250 ครั้ง/เดือน มีทีมช่วยเหลือลูกค้า
  * [Formspree.io](https://formspree.io/) — ส่งอีเมลผ่าน HTTP POST ฟรี 50 ครั้ง/ฟอร์ม/เดือน
  * [Formsubmit.co](https://formsubmit.co/) — Endpoint ฟอร์ม HTML ใช้งานฟรีตลอดไป ไม่ต้องสมัคร
  * [Formlick.com](https://formlick.com) - ทางเลือก Typeform แบบซื้อขาด สร้างฟอร์มฟรี 1 ชุด รับข้อมูลไม่จำกัด ถ้าซื้อพรีเมียมจะสร้างฟอร์มและรับข้อมูลได้ไม่จำกัด
  * [getform.io](https://getform.io/) - Backend ฟอร์มสำหรับนักออกแบบและนักพัฒนา ฟรี 1 ฟอร์ม 50 ข้อมูล อัปโหลดไฟล์ 1 ไฟล์ พื้นที่ 100MB
  * [HeroTofu.com](https://herotofu.com/) - ฟอร์ม backend พร้อมตรวจจับบอทและเข้ารหัส ส่งข้อมูลไป email, Slack, Zapier ใช้ front-end ของคุณเองโดยไม่ต้องมี server code แผนฟรีฟอร์มไม่จำกัด รับข้อมูล 100 ครั้ง/เดือน
  * [HeyForm.net](https://heyform.net/) - สร้างฟอร์มออนไลน์ลาก-วาง แผนฟรีสร้างฟอร์มและรับข้อมูลได้ไม่จำกัด มีเทมเพลต กันสแปม พื้นที่ไฟล์ 100MB
  * [Tally.so](https://tally.so/) - 99% ของฟีเจอร์ฟรี สร้างฟอร์มไม่จำกัด รับข้อมูลไม่จำกัด แจ้งเตือนอีเมล, form logic, รับชำระเงิน, อัปโหลดไฟล์, หน้าขอบคุณ ฯลฯ
  * [Hyperforms.app](https://hyperforms.app/) — สร้างฟอร์มรับข้อมูลทางอีเมล ฯลฯ ภายในไม่กี่วินาทีโดยไม่ต้องมี backend code บัญชีส่วนตัวรับข้อมูลฟอร์มฟรี 50 ครั้ง/เดือน
  * [Kwes.io](https://kwes.io/) - Endpoint ฟอร์มฟีเจอร์แน่น เหมาะกับ static site แผนฟรีใช้ได้ 1 เว็บไซต์ รับข้อมูล 50 ครั้ง/เดือน
  * [Pageclip](https://pageclip.co/) - แผนฟรีสำหรับ 1 เว็บไซต์ 1 ฟอร์ม รับข้อมูล 1,000 ครั้ง/เดือน
  * [Qualtrics Survey](https://qualtrics.com/free-account) — สร้างฟอร์มหรือแบบสำรวจระดับมืออาชีพ มีเทมเพลตมากกว่า 50 แบบ แผนฟรีมี 1 แบบสำรวจ, รับคำตอบ 100 ครั้ง/แบบ และ 8 ประเภทคำตอบ
  * [Screeb](https://screeb.app/) - แบบสอบถามในแอปและ analytics สำหรับวิเคราะห์พฤติกรรมผู้ใช้ แผนฟรีตลอดชีพรองรับผู้ใช้ 500 คน/เดือน ตอบกลับและ event ไม่จำกัด, เชื่อมต่อได้หลากหลาย, ส่งออก, รายงานตามรอบ
  * [smartforms.dev](https://smartforms.dev/) - Backend ฟอร์มใช้งานง่ายและทรงพลัง แผนฟรีตลอดชีพส่งข้อมูลได้ 50 ครั้ง/เดือน พื้นที่ 250MB เชื่อม Zapier, ส่งออก CSV/JSON, redirect ได้เอง, กำหนด response page, แจ้งเตือนอีเมล, Telegram & Slack bot
  * [Survicate](https://survicate.com/) — ดึง feedback ทุกช่องทาง ส่ง follow-up survey ได้ วิเคราะห์อัตโนมัติด้วย AI ฟรีทั้งแบบสอบถามอีเมล, เว็บไซต์, ในแอป, มือถือ, AI survey creator และรับข้อมูล 25 ครั้ง/เดือน
  * [staticforms.xyz](https://www.staticforms.xyz/) - เชื่อม HTML form กับ backend ได้ฟรี ไม่ต้องเขียน server code หลังจากผู้ใช้ submit ระบบจะส่งเนื้อหาฟอร์มทางอีเมลถึงคุณ
  * [stepFORM.io](https://stepform.io) - สร้าง Quiz และฟอร์ม แผนฟรีมี 5 ฟอร์ม ฟอร์มละ 3 ขั้นตอน รับข้อมูล 50 ครั้ง/เดือน
  * [Typeform.com](https://www.typeform.com/) — สร้างฟอร์มดีไซน์สวยบนเว็บไซต์ แผนฟรีจำกัด 10 ฟิลด์ต่อฟอร์ม และรับข้อมูล 100 ครั้ง/เดือน
  * [WaiverStevie.com](https://waiverstevie.com) - แพลตฟอร์มลายเซ็นอิเล็กทรอนิกส์พร้อม REST API แจ้งเตือนผ่าน webhook แผนฟรีมีลายน้ำในเอกสาร ลงชื่อและซองไม่จำกัด
  * [Web3Forms](https://web3forms.com) - ฟอร์มติดต่อสำหรับ Static & JAMStack เว็บไซต์โดยไม่ต้องเขียน backend code แผนฟรีสร้างฟอร์มไม่จำกัด โดเมนไม่จำกัด รับข้อมูล 250 ครั้ง/เดือน
* [WebAsk](https://webask.io) - เครื่องมือสร้างแบบสำรวจและฟอร์ม แผนฟรีสามารถสร้างแบบสำรวจได้ 3 รายการต่อบัญชี รับคำตอบได้ 100 ครั้งต่อเดือน และใส่ได้ 10 องค์ประกอบต่อแบบสำรวจ
* [Wufoo](https://www.wufoo.com/) - ฟอร์มออนไลน์ที่ใช้งานง่ายสำหรับเว็บไซต์ แผนฟรีจำกัดการส่งข้อมูล 100 ครั้งต่อเดือน
* [formpost.app](https://formpost.app) - บริการ Form to Email ฟรีและไม่จำกัดจำนวน ตั้งค่าการเปลี่ยนเส้นทางอัตโนมัติ, การตอบกลับอัตโนมัติ, webhook ฯลฯ ได้ฟรี
* [Formester.com](https://formester.com) - แชร์และฝังฟอร์มดีไซน์สวยบนเว็บไซต์ของคุณ—ไม่จำกัดจำนวนฟอร์มหรือฟีเจอร์ที่ใช้ สร้างและรับคำตอบได้สูงสุด 100 รายการต่อเดือนฟรี
* [SimplePDF.eu](https://simplepdf.eu/embed) - ฝังเครื่องมือแก้ไข PDF ลงในเว็บไซต์และเปลี่ยน PDF เป็นฟอร์มกรอกข้อมูลได้ แผนฟรีอนุญาตให้อัปโหลด PDF ไม่จำกัดจำนวน รับคำตอบได้ 3 ครั้งต่อ PDF
* [forms.app](https://forms.app/) — สร้างฟอร์มออนไลน์ด้วยฟีเจอร์อัจฉริยะ เช่น Logic เงื่อนไข, เครื่องคิดคะแนนอัตโนมัติ, และ AI เก็บข้อมูลตอบกลับได้สูงสุด 100 รายการกับแผนฟรี ฝังฟอร์มในเว็บไซต์หรือใช้งานผ่านลิงก์ได้
* [Qualli](https://usequalli.com) - แบบสำรวจในแอปสำหรับมือถือ ใช้ Qualli AI ช่วยสร้างคำถามที่เหมาะสม ลองใช้ฟรีได้สูงสุด 500 MAU สร้างฟอร์มและทริกเกอร์ได้ไม่จำกัด
* [Sprig](https://sprig.com/) - 1 แบบสำรวจในผลิตภัณฑ์หรือแบบสำรวจพร้อมรีเพลย์ต่อเดือน พร้อมการวิเคราะห์ด้วย AI ที่ขับเคลื่อนด้วย GPT
* [feedback.fish](https://feedback.fish/) - แผนฟรีรับข้อเสนอแนะได้ 25 รายการในภาพรวม มีคอมโพเนนต์สำหรับ React และ Vue ให้ใช้งาน
* [Vidhook](https://vidhook.io/) - รับข้อเสนอแนะผ่านแบบสำรวจที่สนุกและอัตราตอบกลับสูง แผนฟรีมี 1 แบบสำรวจที่ใช้งานได้, รับข้อมูล 25 รายการต่อแบบสำรวจ และปรับแต่งเทมเพลตได้

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## Generative AI

* [Zenable](https://zenable.io) - แก้ไขผลลัพธ์จากเครื่องมืออย่าง Cursor, Windsurf, และ Copilot ให้ตรงตามมาตรฐานคุณภาพและข้อกำหนดขององค์กรโดยอัตโนมัติด้วย guardrails ที่สร้างด้วย Policy as Code แผนฟรีรองรับ 100 เครื่องมือ/วันที่เชื่อมต่อกับ MCP server และรีวิว pull request อัตโนมัติฟรี 25 ครั้ง/วันผ่าน GitHub App
* [Keywords AI](https://keywordsai.co) - แพลตฟอร์มมอนิเตอร์ LLM ที่ดีที่สุด เรียกใช้ LLM มากกว่า 200 แบบด้วยโค้ด 2 บรรทัด ฟรี 10,000 คำขอทุกเดือน พร้อมฟีเจอร์แพลตฟอร์มฟรี!
* [Portkey](https://portkey.ai/) - แผงควบคุมสำหรับแอป Gen AI พร้อม observability suite และ AI gateway ส่งและบันทึกคำขอได้สูงสุด 10,000 ครั้งต่อเดือนฟรี
* [Braintrust](https://www.braintrustdata.com/) - Evals, prompt playground และการจัดการข้อมูลสำหรับ Gen AI แผนฟรีให้ใช้งาน eval ส่วนตัวได้สูงสุด 1,000 แถว/สัปดาห์
* [Findr](https://www.usefindr.com/) - ค้นหาแบบรวมศูนย์ ค้นหาข้อมูลจากทุกแอปในครั้งเดียว ผู้ช่วยค้นหาตอบคำถามจากข้อมูลของคุณ แผนฟรีค้นหาแบบ unified search ไม่จำกัด และใช้ co pilot query ได้ 5 ครั้งต่อวัน
* [ReportGPT](https://ReportGPT.app) - ผู้ช่วยเขียนงานด้วย AI ใช้งานแพลตฟอร์มได้ฟรีทั้งหมด หากนำ API key ของตัวเองมาใช้
* [Clair](https://askclair.ai/) - Clinical AI Reference นักศึกษาใช้งานเครื่องมือระดับ professional suite ฟรี รวมถึง Open Search, Clinical Summary, Med Review, Drug Interactions, ICD-10 Codes และ Stewardship และมี free trial สำหรับ professional suite
* [Langtrace](https://langtrace.ai) - ให้นักพัฒนาตรวจสอบ, ประเมิน, จัดการ prompt และ dataset และดีบักปัญหาที่เกี่ยวข้องกับการทำงานของ LLM application สร้าง trace มาตรฐาน open telemetry สำหรับ LLM ใดก็ได้ แผนฟรีให้ 50,000 trace/เดือน
* [LangWatch](https://langwatch.ai) - แพลตฟอร์ม LLMOps สำหรับวัดผล, มอนิเตอร์, และปรับแต่งแอป LLM ให้เสถียร ประหยัด และมีประสิทธิภาพ ด้วย DSPy ช่วยให้ทีมวิศวกรและทีมไม่เทคนิคทำงานร่วมกันได้อย่างราบรื่น แผนฟรีมีฟีเจอร์ทั้งหมด, 1,000 trace/เดือน และ 1 workflow DSPy optimizer [#opensource](https://github.com/langwatch/langwatch)
* [Comet Opik](https://www.comet.com/site/products/opik/) - ประเมิน ทดสอบ และ deploy แอป LLM ตลอดวงจร dev และ production [#opensource](https://github.com/comet-ml/opik/)
* [Langfuse](https://langfuse.com/) - แพลตฟอร์ม LLM engineering แบบโอเพ่นซอร์ส ช่วยให้ทีม debug, วิเคราะห์ และพัฒนาแอป LLM ร่วมกัน แผนฟรีตลอดชีพมี 50,000 observation/เดือนและฟีเจอร์แพลตฟอร์มทั้งหมด [#opensource](https://github.com/langfuse/langfuse)
* [Pollinations.AI](https://pollinations.ai/) - AI สร้างภาพใช้งานง่าย ฟรี มี API ให้ใช้ฟรี ไม่ต้องสมัครหรือลงทะเบียน API key และมีตัวเลือกสำหรับฝังในเว็บไซต์หรือ workflow [#opensource](https://github.com/pollinations/pollinations)
* [Othor AI](https://othor.ai/) - BI แบบ AI-native ที่เร็ว เรียบง่าย และปลอดภัย เป็นทางเลือกแทน Tableau, Power BI และ Looker ใช้ LLM สร้างโซลูชัน BI สำหรับธุรกิจได้ในไม่กี่นาที แผน Free Forever ให้ workspace เดียว, เชื่อมต่อ datasource 5 แหล่ง สำหรับผู้ใช้ 1 คน และไม่จำกัด analytics [#opensource](https://github.com/othorai/othor.ai)
* [OpenRouter](https://openrouter.ai/models?q=free) - ให้บริการโมเดล AI ฟรีหลายแบบ เช่น DeepSeek R1, V3, Llama, และ Moonshot AI เหมาะสำหรับงานประมวลผลภาษาธรรมชาติหลากหลาย มีข้อจำกัดเรื่องอัตราการใช้งาน ทั้งนี้ OpenRouter ยังมีโมเดลแบบเสียเงินสำหรับความต้องการขั้นสูง เช่น Claude, OpenAI, Grok, Gemini, และ Nova

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## CDN และการป้องกัน

* [bootstrapcdn.com](https://www.bootstrapcdn.com/) — CDN สำหรับ bootstrap, bootswatch และ fontawesome.io
* [cdnjs.com](https://cdnjs.com/) — ง่าย เร็ว และเชื่อถือได้ บริการ CDN แบบโอเพ่นซอร์สฟรี ใช้งานโดยกว่า 11% ของเว็บไซต์ทั้งหมด ดำเนินการโดย Cloudflare
* [developers.google.com](https://developers.google.com/speed/libraries/) — Google Hosted Libraries คือเครือข่าย CDN สำหรับไลบรารี JavaScript โอเพ่นซอร์สยอดนิยม
* [Stellate](https://stellate.co/) - CDN ที่เร็วและเชื่อถือได้สำหรับ GraphQL API ของคุณ ฟรีสำหรับ 2 service
* [jsdelivr.com](https://www.jsdelivr.com/) — CDN โอเพ่นซอร์ส ฟรี เร็ว และเชื่อถือได้ รองรับ npm, GitHub, WordPress, Deno และอื่น ๆ
* [Microsoft Ajax](https://docs.microsoft.com/en-us/aspnet/ajax/cdn/overview) — Microsoft Ajax CDN ให้บริการไลบรารี JavaScript ยอดนิยม เช่น jQuery และเพิ่มลงในเว็บแอปของคุณได้ง่าย
* [ovh.ie](https://www.ovh.ie/ssl-gateway/) — ป้องกัน DDoS ฟรี และใบรับรอง SSL ฟรี
* [Skypack](https://www.skypack.dev/) — 100% Native ES Module JavaScript CDN ฟรี 1 ล้านคำขอต่อโดเมนต่อเดือน
* [raw.githack.com](https://raw.githack.com/) — ตัวแทนสมัยใหม่แทน **rawgit.com** ให้บริการโฮสต์ไฟล์ผ่าน Cloudflare
* [section.io](https://www.section.io/) — วิธีง่าย ๆ ในการสร้างและจัดการโซลูชัน Varnish Cache แบบครบวงจร ฟรีตลอดชีพสำหรับ 1 เว็บไซต์
* [statically.io](https://statically.io/) — CDN สำหรับ Git repo (GitHub, GitLab, Bitbucket), ไฟล์ที่เกี่ยวข้องกับ WordPress และรูปภาพ
* [toranproxy.com](https://toranproxy.com/) — Proxy สำหรับ Packagist และ GitHub ไม่ต้องกังวลว่า CD จะล้มเหลว ฟรีสำหรับใช้ส่วนตัว 1 ผู้พัฒนา ไม่มีซัพพอร์ต
* [UNPKG](https://unpkg.com/) — CDN สำหรับทุกอย่างบน npm
* [weserv](https://images.weserv.nl/) — บริการแคชและปรับขนาดรูปภาพแบบเรียลไทม์ พร้อมแคชทั่วโลก
* [Namecheap Supersonic](https://www.namecheap.com/supersonic-cdn/#free-plan) — ป้องกัน DDoS ฟรี
* [Gcore](https://gcorelabs.com/) เครือข่าย CDN ทั่วโลก ฟรี 1 TB และ 1 ล้านคำขอต่อเดือน พร้อมบริการ DNS ฟรี
* [CacheFly](https://portal.cachefly.com/signup/free2023) - ฟรี CDN traffic สูงสุด 5 TB ต่อเดือน 19 Core PoPs, 1 โดเมน และ Universal SSL

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## PaaS

* [anvil.works](https://anvil.works) - พัฒนาเว็บแอปด้วย Python เท่านั้น แผนฟรีไม่จำกัดจำนวนแอปและ timeout 30 วินาที
* [appwrite](https://appwrite.io) - โปรเจกต์ไม่จำกัด ไม่มีการหยุดชั่วคราว (รองรับ websockets) และบริการ authentication 1 Database, 3 Buckets, 5 Functions ต่อโปรเจกต์ในแผนฟรี
* [configure.it](https://www.configure.it/) — แพลตฟอร์มพัฒนาแอปมือถือ ฟรี 2 โปรเจกต์ ฟีเจอร์จำกัดแต่ไม่จำกัดทรัพยากร
* [codenameone.com](https://www.codenameone.com/) — เครื่องมือพัฒนาแอปมือถือข้ามแพลตฟอร์มแบบโอเพ่นซอร์สสำหรับนักพัฒนา Java/Kotlin ใช้เชิงพาณิชย์ได้ฟรี โปรเจกต์ไม่จำกัดจำนวน
* [deco.cx](https://www.deco.cx/en/dev) - แพลตฟอร์ม frontend แบบ edge-native พร้อม CMS ที่สร้างอัตโนมัติจาก TypeScript มี A/B testing, segmentation, และ analytics แบบเรียลไทม์ เหมาะสำหรับเว็บเนื้อหาหนักและ e-commerce ระดับองค์กร ฟรีสูงสุด 5,000 pageviews/เดือน หรือโอเพ่นซอร์ส/โปรเจกต์ส่วนตัว
* [Deno Deploy](https://deno.com/deploy) - ระบบกระจายศูนย์รัน JavaScript, TypeScript, และ WebAssembly บน edge ทั่วโลก แผนฟรีรองรับ 100,000 คำขอต่อวัน และ data transfer 100 GiB/เดือน
* [domcloud.co](https://domcloud.co) – โฮสติ้ง Linux พร้อม CI/CD จาก GitHub, SSH และฐานข้อมูล MariaDB/Postgres รุ่นฟรีมีพื้นที่ 1 GB และทราฟฟิก 1 GB/เดือน จำกัดโดเมนฟรีเท่านั้น
* [encore.dev](https://encore.dev/) — เฟรมเวิร์ก backend ใช้ static analysis เพื่อจัดการ infrastructure อัตโนมัติ โค้ดสะอาด แถมโฮสติ้งคลาวด์ฟรีสำหรับโปรเจกต์งานอดิเรก
* [flightcontrol.dev](https://flightcontrol.dev/) - ดีพลอย web service, database ฯลฯ บน AWS ของคุณเองแบบ git push แผนฟรีสำหรับ 1 dev บน repo ส่วนตัวใน GitHub ค่าใช้จ่าย AWS จ่ายกับ AWS โดยตรง ใช้เครดิตและ AWS free tier ได้
* [gigalixir.com](https://gigalixir.com/) - ให้ instance ฟรี 1 ตัวที่ไม่หยุดทำงาน และฐานข้อมูล PostgreSQL ฟรีสำหรับแอป Elixir/Phoenix จำกัด 2 connections, 10,000 rows และไม่มี backup
* [Glitch](https://glitch.com/) — โฮสติ้งสาธารณะฟรี แชร์โค้ดและทำงานร่วมกันแบบเรียลไทม์ แผนฟรีจำกัด 1,000 ชั่วโมงต่อเดือน
* [leapcell](https://leapcell.io/) - แพลตฟอร์ม distributed application รองรับการเติบโตอย่างรวดเร็ว แผนฟรีมี 100,000 service invocation, 10,000 async tasks, และ 100,000 Redis commands
* [pipedream.com](https://pipedream.com) - แพลตฟอร์ม integration สำหรับนักพัฒนา สร้าง workflow จาก trigger ใดก็ได้ workflow เป็นโค้ดที่รัน [ฟรี](https://docs.pipedream.com/pricing/) ไม่ต้องดูแล server หรือ cloud resource
* [pythonanywhere.com](https://www.pythonanywhere.com/) — โฮสติ้ง Python บนคลาวด์ บัญชีเริ่มต้นฟรี 1 เว็บแอป Python ที่ your-username.pythonanywhere.com พื้นที่ส่วนตัว 512 MB มี MySQL 1 ฐานข้อมูล
* [ampt.dev](https://getampt.com/) - พัฒนา, ดีพลอย และขยายแอป JavaScript บน AWS โดยไม่ต้องตั้งค่าโครงสร้างพื้นฐาน แผน Preview ฟรีรวม 500 invocations รายชั่วโมง, 2,500 รายวัน, 50,000 รายเดือน ใช้ custom domain ได้เฉพาะแผนเสียเงิน
* [Koyeb](https://www.koyeb.com) - แพลตฟอร์ม serverless สำหรับนักพัฒนาสำหรับดีพลอยแอปทั่วโลก รัน Docker, web app, API ดีพลอยผ่าน git, autoscale อัตโนมัติ เครือข่าย edge ทั่วโลก มี service mesh และ discovery ในตัว Free Instance ดีพลอยได้ที่ Frankfurt, Germany หรือ Washington, D.C., US มี Managed Postgres ฟรีที่ Frankfurt, Washington D.C., และ Singapore 512MB RAM, 2GB storage, 0.1 CPU
* [Napkin](https://www.napkin.io/) - FaaS พร้อมหน่วยความจำ 500Mb, timeout 15 วินาที, 5,000 API call/เดือน จำกัด 5 call/วินาที
* [Meteor Cloud](https://www.meteor.com/cloud) — Galaxy hosting PaaS สำหรับ Meteor app มี MongoDB Shared Hosting และ SSL อัตโนมัติฟรี
* [Northflank](https://northflank.com) — ดีพลอย microservice, งาน cron, และ database พร้อม UI, API, CLI ทรงพลัง autoscale container จาก version control และ Docker registry ภายนอก แผนฟรีมี 2 service, 2 cron job, 1 database
* [YepCode](https://yepcode.io) - แพลตฟอร์ม all-in-one สำหรับเชื่อมต่อ API และบริการในสภาพแวดล้อม serverless ได้ความคล่องตัวแบบ NoCode แต่ใช้ภาษาการเขียนโปรแกรมได้เต็มที่ แผนฟรีรวม [1,000 yeps](https://yepcode.io/pricing/)
* [WunderGraph](https://cloud.wundergraph.com) - แพลตฟอร์มโอเพ่นซอร์สสำหรับสร้าง, ดีพลอย, และจัดการ API ยุคใหม่ มี CI/CD, เชื่อมต่อ GitHub, และ HTTPS อัตโนมัติ สูงสุด 3 โปรเจกต์, 1GB egress, 300 นาที build ต่อเดือนใน [แผนฟรี](https://wundergraph.com/pricing)
* [Zeabur](https://zeabur.com) - ดีพลอยบริการของคุณในคลิกเดียว ฟรี 3 service พร้อมเครดิต US$5/เดือน
* [mogenius](https://mogenius.com) - สร้าง ดีพลอย และรันบริการบน Kubernetes ได้ง่าย แผนฟรีรองรับเชื่อมต่อ Kubernetes โลคัลกับ mogenius ให้นักพัฒนาใช้ทดสอบเหมือน production ได้บนเครื่องตนเอง
* [genezio](https://genezio.com/) - ผู้ให้บริการ serverless function ฟรี 1 ล้าน function call, แบนด์วิดธ์ 100GB, และ cron job 10 งานต่อเดือน ใช้ฟรีสำหรับงานวิชาการหรือไม่เชิงพาณิชย์เท่านั้น

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## BaaS

* [Activepieces](https://www.activepieces.com) - สร้าง automation flow เชื่อมหลายแอปใน backend แอปของคุณ เช่น ส่งข้อความ Slack หรือเพิ่มแถวใน Google Sheet เมื่อเกิด event ในแอป ฟรีสูงสุด 5,000 งาน/เดือน
* [back4app.com](https://www.back4app.com) - Back4App คือ backend ที่ใช้งานง่าย ยืดหยุ่น และขยายได้ บน Parse Platform
* [backendless.com](https://backendless.com/) — BaaS สำหรับมือถือและเว็บ ฟรีพื้นที่ไฟล์ 1 GB, push notification 50,000 ครั้ง/เดือน, และ data object 1,000 รายการในตาราง
* [bismuth.cloud](https://www.bismuth.cloud/) — AI ของเราจะสร้าง Python API ของคุณบน function runtime และ storage ที่โฮสต์ สร้างและโฮสต์ฟรีใน editor ออนไลน์ หรือ local ด้วยเครื่องมือที่คุณชอบ
* [BMC Developer Program](https://developers.bmc.com/site/global/bmc_helix_platform/program/overview/index.gsp) — โปรแกรมนักพัฒนา BMC ให้เอกสารและทรัพยากรสำหรับสร้างและดีพลอยนวัตกรรมดิจิทัลในองค์กร มี sandbox ส่วนตัวที่ครอบคลุม platform, SDK และคลัง component สำหรับสร้างและปรับแต่งแอป
* [connectycube.com](https://connectycube.com) - แชทไม่จำกัด, โทรเสียง/วิดีโอ p2p, แนบไฟล์ และ push notification ฟรีสำหรับแอปที่มีผู้ใช้ไม่เกิน 1,000 คน
* [convex.dev](https://convex.dev/) - BaaS แบบ Reactive โฮสต์ข้อมูล (document ที่มีความสัมพันธ์และ transaction แบบ ACID), serverless function, WebSocket สำหรับอัปเดตแบบเรียลไทม์ ฟรีสำหรับโปรเจกต์เล็ก - 1M records, 5M function call/เดือน
* [darklang.com](https://darklang.com/) - ภาษาโปรแกรมพร้อม editor และ infrastructure ในตัว ใช้งานได้ระหว่างเบต้า มีแผนฟรีที่ใจกว้างหลังจากเบต้า
* [Firebase](https://firebase.com) — ช่วยสร้างและรันแอปสำเร็จ แผนฟรี Spark ให้ Authentication, Hosting, Firebase ML, Realtime Database, Cloud Storage, Testlab บริการ A/B Testing, Analytics, App Distribution, App Indexing, Cloud Messaging (FCM), Crashlytics, Dynamic Links, In-App Messaging, Performance Monitoring, Predictions และ Remote Config ใช้งานได้ฟรีเสมอ
* [Flutter Flow](https://flutterflow.io) — สร้าง UI Flutter App โดยไม่ต้องเขียนโค้ด มี integration กับ Firebase แผนฟรีใช้งาน UI Builder และเทมเพลตฟรีได้ทั้งหมด
* [getstream.io](https://getstream.io/) — สร้าง In-App Chat, Messaging, Video, Audio และ Feeds ที่สเกลได้ในเวลาไม่กี่ชั่วโมงแทนที่จะเป็นสัปดาห์
* [hasura.io](https://hasura.io/) — ขยายฐานข้อมูลของคุณด้วย GraphQL API ที่ปลอดภัย ใช้งานกับเว็บ, มือถือ, และ data integration ได้ แผนฟรีให้ data throughput 1GB/เดือน
* [nhost.io](https://nhost.io) - Serverless backend สำหรับเว็บและแอปมือถือ แผนฟรีมี PostgreSQL, GraphQL (Hasura), Authentication, Storage และ Serverless Function
* [onesignal.com](https://onesignal.com/) — ส่ง push notification ฟรีไม่จำกัด ส่งอีเมลได้ 10,000 ครั้ง/เดือน มี contact ไม่จำกัด และ Auto Warm Up
* [paraio.com](https://paraio.com) — Backend API พร้อม authentication ที่ยืดหยุ่น, full-text search และ caching ฟรีสำหรับ 1 แอป, ข้อมูล 1GB
  * [pubnub.com](https://www.pubnub.com/) — ฟรี Push notification สำหรับสูงสุด 1 ล้านข้อความ/เดือน และ 100 อุปกรณ์ที่ใช้งานต่อวัน
  * [pushbots.com](https://pushbots.com/) — บริการ Push notification ฟรีสำหรับสูงสุด 1.5 ล้าน pushes/เดือน
  * [pushcrew.com](https://pushcrew.com/) — บริการ Push notification แจ้งเตือนแบบไม่จำกัดสำหรับผู้ติดตามสูงสุด 2,000 คน
  * [pusher.com](https://pusher.com/beams) — ฟรี Push notification ไม่จำกัดสำหรับผู้ใช้งาน 2,000 คนต่อเดือน เพียง API เดียวสำหรับอุปกรณ์ iOS และ Android
  * [quickblox.com](https://quickblox.com/) — Backend สำหรับการสื่อสารด้วยข้อความโต้ตอบทันที วิดีโอ และการโทรด้วยเสียง รวมถึง Push notification
  * [restspace.io](https://restspace.io/) - กำหนดค่าเซิร์ฟเวอร์พร้อมบริการสำหรับ auth, ข้อมูล, ไฟล์, อีเมล API, เทมเพลต และอื่น ๆ จากนั้นนำมารวมเป็น pipeline และแปลงข้อมูลได้
  * [Salesforce Developer Program](https://developer.salesforce.com/signup) — สร้างแอปได้อย่างรวดเร็วด้วยเครื่องมือ drag-and-drop ปรับแต่ง data model ด้วยคลิก เขียนโค้ด Apex เพิ่มเติมได้ เชื่อมต่อกับทุกอย่างด้วย API อันทรงพลัง ปลอดภัยระดับองค์กร ปรับแต่ง UI ด้วยคลิกหรือเฟรมเวิร์กเว็บชั้นนำ โปรแกรมนักพัฒนาใช้ฟรีให้เข้าถึง Lightning Platform ทั้งหมด
  * [simperium.com](https://simperium.com/) — เคลื่อนย้ายข้อมูลทุกที่อย่างรวดเร็วและอัตโนมัติ รองรับหลายแพลตฟอร์ม ส่งและจัดเก็บข้อมูลแบบมีโครงสร้างไม่จำกัด สูงสุด 2,500 ผู้ใช้/เดือน
  * [Supabase](https://supabase.com) — โอเพ่นซอร์สทางเลือกแทน Firebase สำหรับสร้าง backend แผนฟรีมี Authentication, Realtime Database และ Object Storage
  * [tyk.io](https://tyk.io/) — การจัดการ API พร้อม authentication, โควต้า, มอนิเตอร์และวิเคราะห์ ข้อเสนอ cloud ฟรี
  * [zapier.com](https://zapier.com/) — เชื่อมต่อแอปต่าง ๆ เพื่อทำงานอัตโนมัติ ฟรี 5 zap ทุก 15 นาที และ 100 งาน/เดือน
  * [IFTTT](https://ifttt.com) — ทำให้งานและอุปกรณ์ที่คุณชื่นชอบเป็นอัตโนมัติ ฟรี 2 Applets
  * [Integrately](https://integrately.com) — อัตโนมัติงานที่น่าเบื่อด้วยคลิกเดียว ฟรี 100 งาน, อัปเดตทุก 15 นาที, อัตโนมัติ 5 รายการ, webhooks
  * [LeanCloud](https://leancloud.app/) — Mobile backend ฟรี 1GB พื้นที่จัดเก็บข้อมูล, 256MB อินสแตนซ์, 3,000 API requests/วัน, และ 10,000 push/วัน (API คล้าย Parse Platform)
  * [Claw.cloud](https://run.claw.cloud) - PaaS ที่ให้เครดิตฟรี $5/เดือน สำหรับผู้ใช้ที่มีบัญชี GitHub เกิน 180 วัน เหมาะสำหรับโฮสต์แอป ฐานข้อมูล และอื่น ๆ ([ลิงก์สมัครพร้อมเครดิตฟรี](https://ap-southeast-1.run.claw.cloud/signin))


**[⬆️ กลับไปด้านบน](#table-of-contents)**

## Low-code Platform

  * [appsmith](https://www.appsmith.com/) — โครงการ low code สำหรับสร้างแผงควบคุมผู้ดูแลระบบ เครื่องมือภายใน และแดชบอร์ด เชื่อมต่อกับฐานข้อมูลกว่า 15 แห่งและ API ใด ๆ ก็ได้
  * [Basedash](https://www.basedash.com) — แพลตฟอร์ม low-code สำหรับสร้างแผงควบคุมและแดชบอร์ดสำหรับงานภายใน รองรับฐานข้อมูล SQL และ REST API
  * [BudiBase](https://budibase.com/) — Budibase เป็นแพลตฟอร์ม low-code แบบโอเพ่นซอร์สสำหรับสร้างแอปภายในในไม่กี่นาที รองรับ PostgreSQL, MySQL, MSSQL, MongoDB, Rest API, Docker, K8s
  * [Clappia](https://www.clappia.com) — แพลตฟอร์ม low-code สำหรับสร้างแอปพลิเคชันกระบวนการธุรกิจ พร้อมแอปบนมือถือและเว็บที่ปรับแต่งได้ มีอินเทอร์เฟซลากแล้ววาง ฟีเจอร์ Offline Support, ติดตามตำแหน่งแบบ real-time และเชื่อมต่อกับบริการบุคคลที่สาม
  * [DronaHQ](https://www.dronahq.com/) — DronaHQ แพลตฟอร์ม low code ที่ช่วยวิศวกรและผู้จัดการผลิตภัณฑ์สร้างเครื่องมือภายใน, user journey ที่กำหนดเอง, ประสบการณ์ดิจิทัล, automation, แผงควบคุม, แอปการดำเนินงาน ได้เร็วขึ้น 10 เท่า
  * [lil'bots](https://www.lilbots.io/) - เขียนและรันสคริปต์ออนไลน์โดยใช้ API ฟรีในตัว เช่น OpenAI, Anthropic, Firecrawl และอื่น ๆ เหมาะสำหรับสร้าง AI agent/เครื่องมือภายในและแบ่งปันกับทีม แผนฟรีมี API, ผู้ช่วยเขียนโค้ด AI และเครดิตรัน 10,000 ครั้ง/เดือน
  * [Mendix](https://www.mendix.com/) — พัฒนาแอปอย่างรวดเร็วสำหรับองค์กร มี sandbox ไม่จำกัด รองรับผู้ใช้ทั้งหมด, พื้นที่จัดเก็บ 0.5 GB และ RAM 1 GB ต่อแอป Studio และ Studio Pro IDE ใช้งานได้ในแผนฟรี
  * [outsystems.com](https://www.outsystems.com/) — PaaS พัฒนาเว็บสำหรับองค์กรทั้งแบบ on-premise หรือ cloud แผนฟรี "personal environment" ให้โค้ดไม่จำกัดและฐานข้อมูลสูงสุด 1 GB
  * [ReTool](https://retool.com/) — แพลตฟอร์ม low-code สำหรับสร้างแอปภายใน Retool ปรับแต่งได้สูง สามารถใช้ JavaScript และ API ได้ตามต้องการ แผนฟรีรองรับสูงสุด 5 ผู้ใช้/เดือน, แอปและ API ไม่จำกัด
  * [Superblocks](https://superblocks.com/) — แพลตฟอร์มแอปพลิเคชันองค์กรแบบเปิดออกแบบมาสำหรับนักพัฒนาและทีมกึ่งเทคนิค ใช้ AI สร้าง แก้ไขภาพ และขยายด้วยโค้ด บริหารจัดการศูนย์กลางพร้อมอินทิเกรชัน, authentication, สิทธิ์และ audit log
  * [ToolJet](https://www.tooljet.com/) — เฟรมเวิร์ก low-code ที่ขยายได้สำหรับสร้างแอปธุรกิจ เชื่อมต่อกับฐานข้อมูล, cloud storage, GraphQL, API endpoint, Airtable ฯลฯ สร้างแอปด้วย drag-and-drop builder
  * [UI Bakery](https://uibakery.io) — แพลตฟอร์ม low-code สำหรับสร้างเว็บแอปได้เร็วขึ้น สร้าง UI ด้วย drag and drop ปรับแต่งได้สูงผ่าน JavaScript, Python, SQL มีทั้งแบบ cloud และ self-hosted ฟรีสำหรับสูงสุด 5 ผู้ใช้
  * [manubes](https://www.manubes.com) - แพลตฟอร์ม no-code บนคลาวด์สำหรับการจัดการการผลิตภาคอุตสาหกรรม ฟรี 1 ผู้ใช้และ 1 ล้าน workflow/เดือน ([มีภาษาเยอรมัน](https://www.manubes.de))

**[⬆️ กลับไปด้านบน](#table-of-contents)**

## Web Hosting

  * [Alwaysdata](https://www.alwaysdata.com/) — โฮสติ้งเว็บฟรี 100 MB รองรับ MySQL, PostgreSQL, CouchDB, MongoDB, PHP, Python, Ruby, Node.js, Elixir, Java, Deno, เว็บเซิร์ฟเวอร์แบบกำหนดเอง, เข้าถึงผ่าน FTP, WebDAV, SSH; กล่องจดหมาย, เมลลิ่งลิสต์ และตัวติดตั้งแอป
  * [Awardspace.com](https://www.awardspace.com) — โฮสติ้งเว็บฟรี + โดเมนสั้นฟรี, PHP, MySQL, ตัวติดตั้งแอป, ส่งอีเมล และไม่มีโฆษณา
  * [Bohr](https://bohr.io) — ฟรีสำหรับโปรเจกต์ที่ไม่ใช่เชิงพาณิชย์ + แพลตฟอร์มสำหรับนักพัฒนาเน้นการ deploy และพัฒนา ช่วยลดปัญหาโครงสร้างพื้นฐานและเร่งการตั้งค่า
  * [Bubble](https://bubble.io/) — โปรแกรมสร้างเว็บและแอปมือถือแบบ Visual โดยไม่ต้องเขียนโค้ด ฟรีพร้อมโลโก้ Bubble
  * [dAppling Network](https://www.dappling.network/) - แพลตฟอร์มโฮสต์เว็บแบบกระจายศูนย์สำหรับ frontend สาย Web3 เน้น uptime และความปลอดภัย พร้อมเป็น access point เพิ่มเติมให้ผู้ใช้
  * [DigitalOcean](https://www.digitalocean.com/pricing) - สร้างและ deploy เว็บไซต์ static ได้สามเว็บฟรีใน App Platform Starter tier
  * [Drive To Web](https://drv.tw) — โฮสต์ขึ้นเว็บโดยตรงจาก Google Drive & OneDrive เว็บไซต์ static เท่านั้น ฟรีตลอดชีพ หนึ่งเว็บต่อบัญชี Google/Microsoft
  * [Fenix Web Server](https://preview.fenixwebserver.com) - แอปเดสก์ท็อปสำหรับนักพัฒนาใช้โฮสต์เว็บไซต์ในเครื่องและแชร์แบบสาธารณะ (แบบ real-time) ใช้งานได้ทั้ง UI, API และ/หรือ CLI
  * [Fern](https://buildwithfern.com) - สร้างและโฮสต์เว็บไซต์เอกสาร Markdown บนแผนฟรีของ Fern สามารถสร้าง API reference อัตโนมัติจากไฟล์นิยาม API เว็บไซต์จะอยู่ที่ _yoursite_.docs.buildwithfern.com
  * [Free Hosting](https://freehostingnoads.net/) — ฟรีโฮสติ้งพร้อม PHP 5, Perl, CGI, MySQL, FTP, File Manager, POP E-Mail, ฟรี sub-domain, ฟรีโดเมน, DNS Zone Editor, สถิติผู้เข้าเว็บ, ฟรีซัพพอร์ตออนไลน์และฟีเจอร์อื่น ๆ ที่โฮสต์ฟรีเจ้าอื่นไม่มี
  * [Freehostia](https://www.freehostia.com) — FreeHostia ให้บริการโฮสต์ฟรีพร้อม Control Panel ที่ดีที่สุดในอุตสาหกรรม & ติดตั้งแอปฟรีกว่า 50 ตัวด้วยคลิกเดียว ตั้งค่าทันที ไม่มีโฆษณาบังคับ
  * [HelioHost](https://heliohost.org) — โฮสติ้งเว็บฟรีแบบไม่แสวงหากำไร พร้อม Plesk Control Panel, PHP, Node.js, Python, Django, Flask, .NET, Perl, CGI, MySQL, PostgreSQL, SQLite, อีเมล IMAP/POP3/SMTP, แบนด์วิธไม่จำกัด, ฟรี subdomain, 1,000 MB พื้นที่จัดเก็บ พร้อมอัปเกรดได้
  * [Kinsta Static Site Hosting](https://kinsta.com/static-site-hosting/) — โฮสต์เว็บไซต์ static ได้สูงสุด 100 เว็บ ฟรี ใช้โดเมนตนเองพร้อม SSL, แบนด์วิธ 100 GB/เดือน, Cloudflare CDN กว่า 260 จุด
  * [Lecturify](https://www.lecturify.net/index.en.html) - โฮสต์เว็บพร้อม SFPT สำหรับอัปโหลด/ดาวน์โหลดไฟล์ รองรับ php
  * [Neocities](https://neocities.org) — เว็บไซต์ static ฟรี 1 GB พื้นที่ 200 GB แบนด์วิธ
  * [Netlify](https://www.netlify.com/) — สร้าง, deploy และโฮสต์เว็บไซต์/แอป static ฟรี 100 GB ข้อมูลและ 100 GB/เดือน แบนด์วิธ
  * [pantheon.io](https://pantheon.io/) — โฮสต์ Drupal และ WordPress พร้อม DevOps อัตโนมัติและโครงสร้างพื้นฐานที่ขยายได้ ฟรีสำหรับนักพัฒนาและเอเจนซี่ ไม่มีโดเมนกำหนดเอง
  * [readthedocs.org](https://readthedocs.org/) — โฮสต์เอกสารฟรีพร้อม versioning, สร้าง PDF ฯลฯ
  * [render.com](https://render.com) — Cloud เดียวที่สร้างและรันแอป/เว็บพร้อม SSL ฟรี, CDN ทั่วโลก, เครือข่ายส่วนตัว, deploy อัตโนมัติจาก Git และแผนฟรีสำหรับบริการเว็บ, ฐานข้อมูล, และเว็บเพจ static
  * [SourceForge](https://sourceforge.net/) — ค้นหา, สร้าง และเผยแพร่ซอฟต์แวร์โอเพ่นซอร์สฟรี
  * [surge.sh](https://surge.sh/) — เผยแพร่เว็บ static สำหรับนักพัฒนา Front-End สร้างเว็บไม่จำกัด รองรับ custom domain
  * [telegra.ph](https://telegra.ph/) สร้างเว็บเพจอย่างง่ายด้วย Quill
  * [tilda.cc](https://tilda.cc/) — 1 เว็บ, 50 หน้า, 50 MB พื้นที่, มีแต่บล็อกหลักที่กำหนดไว้ใน 170+ บล็อก, ไม่มีฟอนต์, ไม่มี favicon, ไม่มี custom domain
  * [Vercel](https://vercel.com/) — สร้าง, deploy, โฮสต์เว็บแอปพร้อม SSL ฟรี, CDN ทั่วโลก และ Preview URL ทุกครั้งที่ `git push` เหมาะสำหรับ Next.js และ Static Site Generator อื่น ๆ
  * [Versoly](https://versoly.com/) — เครื่องมือสร้างเว็บไซต์เน้น SaaS - สร้างเว็บไม่จำกัด, 70+ blocks, 5 template, CSS กำหนดเอง, favicon, SEO, แบบฟอร์ม ไม่มี custom domain
  * [Qoddi](https://qoddi.com) - บริการ PaaS คล้าย Heroku เน้นนักพัฒนาและฟีเจอร์ครบถ้วน แผนฟรีสำหรับ static assets, staging และแอปนักพัฒนา
  * [FreeFlarum](https://freeflarum.com/) - โฮสต์ Flarum ฟรีในชุมชนสำหรับผู้ใช้สูงสุด 250 คน (บริจาคเพื่อเอา watermark ที่ footer ออก)
  * [MDB GO](https://mdbgo.com/) - โฮสต์ฟรี 1 โปรเจกต์ TTL คอนเทนเนอร์ 2 สัปดาห์, RAM 500 MB ต่อโปรเจกต์, SFTP - ดิสก์ 1G
  * [Patr Cloud](https://patr.cloud/) — แพลตฟอร์มคลาวด์ใช้งานง่าย มีบริการเสียเงินแต่โฮสต์เว็บ static ได้ 3 เว็บฟรี
  * [Serv00.com](https://serv00.com/) — โฮสต์ฟรี 3 GB พร้อม backup รายวัน (7 วัน) รองรับ: Crontab, SSH, repository (GIT, SVN, Mercurial), MySQL, PostgreSQL, MongoDB, PHP, Node.js, Python, Ruby, Java, Perl, TCL/TK, Lua, Erlang, Rust, Pascal, C, C++, D, R ฯลฯ
  - [Sevalla](https://sevalla.com/) - แพลตฟอร์มโฮสต์ออกแบบมาเพื่อให้การ deploy และจัดการแอป, ฐานข้อมูล, และเว็บ static ง่ายขึ้น - เว็บละ 1GB, แบนด์วิธ 100GB ฟรี, 600 นาที build ฟรี, 100 เว็บ/บัญชี

**[⬆️ กลับไปด้านบน](#table-of-contents)**

## DNS

  * [1.1.1.1](https://developers.cloudflare.com/1.1.1.1/) - DNS Resolver สาธารณะฟรี เร็วและปลอดภัย (เข้ารหัส DNS query) โดย Cloudflare ใช้เพื่อหลีกเลี่ยง DNS ของ ISP, ป้องกันการสอดแนม DNS query และ [บล็อกเนื้อหาไม่เหมาะสม/มัลแวร์](https://developers.cloudflare.com/1.1.1.1/1.1.1.1-for-families) ใช้ [ผ่าน API](https://developers.cloudflare.com/1.1.1.1/encrypted-dns/dns-over-https/make-api-requests) ได้ หมายเหตุ: เป็น DNS resolver ไม่ใช่ DNS hoster
  * [1984.is](https://www.1984.is/product/freedns/) — บริการ DNS ฟรีพร้อม API และฟีเจอร์ DNS อื่น ๆ มากมาย
  * [cloudns.net](https://www.cloudns.net/) — ฟรี DNS hosting สูงสุด 1 โดเมน 50 records
  * [deSEC](https://desec.io) - DNS hosting ฟรีพร้อม API ออกแบบโดยคำนึงถึงความปลอดภัย ทำงานบนโอเพ่นซอร์สและสนับสนุนโดย [SSE](https://www.securesystems.de/)
  * [dns.he.net](https://dns.he.net/) — ฟรี DNS hosting พร้อม Dynamic DNS
  * [Zonomi](https://zonomi.com/) — ฟรี DNS hosting พร้อม DNS propagation ทันที แผนฟรี: 1 DNS zone (โดเมน) สูงสุด 10 records
  * [dnspod.com](https://www.dnspod.com/) — ฟรี DNS hosting
  * [duckdns.org](https://www.duckdns.org/) — ฟรี DDNS สูงสุด 5 โดเมน มีคู่มือการตั้งค่าหลายแบบ
  * [Dynv6.com](https://dynv6.com/) — ฟรี DDNS พร้อม [API](https://dynv6.com/docs/apis) และจัดการ record ได้หลายประเภท (CNAME, MX, SPF, SRV, TXT ฯลฯ)
  * [freedns.afraid.org](https://freedns.afraid.org/) — ฟรี DNS hosting พร้อมฟรี subdomain จาก [โดเมนสาธารณะ](https://freedns.afraid.org/domain/registry/) สมัครแล้วเลือก "Subdomains"
  * [luadns.com](https://www.luadns.com/) — ฟรี DNS hosting 3 โดเมน ทุกฟีเจอร์ในขีดจำกัดเหมาะสม
  * [namecheap.com](https://www.namecheap.com/domains/freedns/) — ฟรี DNS ไม่จำกัดจำนวนโดเมน
  * [nextdns.io](https://nextdns.io) - ไฟร์วอลล์ผ่าน DNS 300,000 คำขอฟรี/เดือน
  * [noip.at](https://noip.at/) — ฟรี DDNS ไม่ต้องลงทะเบียน, ไม่มี track, log หรือโฆษณา ไม่มีจำกัดโดเมน
  * [noip](https://www.noip.com/) — บริการ DDNS ให้ฟรี 3 hostname ยืนยันทุก 30 วัน
  * [sslip.io](https://sslip.io/) — ฟรี DNS เมื่อ query ด้วย hostname ที่มี IP จะคืนค่า IP นั้น
  * [zilore.com](https://zilore.com/en/dns) — ฟรี DNS hosting 5 โดเมน
  * [zoneedit.com](https://www.zoneedit.com/free-dns/) — ฟรี DNS hosting พร้อม Dynamic DNS
  * [zonewatcher.com](https://zonewatcher.com) — สำรองและตรวจจับการเปลี่ยนแปลง DNS อัตโนมัติ ฟรี 1 โดเมน
  * [huaweicloud.com](https://www.huaweicloud.com/intl/en-us/product/dns.html) – ฟรี DNS hosting โดย Huawei
  * [Hetzner](https://www.hetzner.com/dns-console) – ฟรี DNS hosting จาก Hetzner พร้อม API
  * [Glauca](https://docs.glauca.digital/hexdns/) – ฟรี DNS hosting สูงสุด 3 โดเมน และรองรับ DNSSEC
  * [VolaryDDNS](https://volaryddns.net) - DDNS ประสิทธิภาพสูง ฟรี ไม่มีโฆษณาหรือค่าสมัคร
**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## โดเมน

  * [pp.ua](https://nic.ua/) — ฟรีซับโดเมน pp.ua
  * [us.kg](https://nic.us.kg/) - ฟรีซับโดเมน us.kg

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## IaaS

  * [4EVERLAND](https://www.4everland.org/) — รองรับ AWS S3 - APIs, การดำเนินการผ่านอินเทอร์เฟซ, CLI และวิธีอัปโหลดอื่น ๆ อัปโหลดและจัดเก็บไฟล์จากเครือข่าย IPFS และ Arweave ได้อย่างปลอดภัย สะดวก และมีประสิทธิภาพ ผู้ใช้ที่ลงทะเบียนสามารถรับพื้นที่เก็บข้อมูล IPFS ฟรี 6 GB และ Arweave ฟรี 300MB การอัปโหลดไฟล์ Arweave ที่มีขนาดเล็กกว่า 150 KB ฟรี
  * [backblaze.com](https://www.backblaze.com/b2/) — Backblaze B2 cloud storage พื้นที่เก็บข้อมูลแบบอ็อบเจกต์ (เหมือน Amazon S3) ฟรี 10 GB ไม่จำกัดเวลา
  * [filebase.com](https://filebase.com/) - S3 Compatible Object Storage ขับเคลื่อนด้วย Blockchain พื้นที่เก็บข้อมูลฟรี 5 GB ไม่จำกัดระยะเวลา
  * [Tebi](https://tebi.io/) - S3 compatibility object storage. ฟรีพื้นที่เก็บข้อมูล 25 GB และโอนถ่ายขาออก 250GB
  * [Idrive e2](https://www.idrive.com/e2/) - S3 compatibility object storage. ฟรีพื้นที่เก็บข้อมูล 10 GB และแบนด์วิดท์ดาวน์โหลด 10 GB ต่อเดือน
  * [C2 Object Storage](https://c2.synology.com/en-us/pricing/object-storage) - S3 compatibility object storage. ฟรีพื้นที่เก็บข้อมูล 15 GB และดาวน์โหลด 15 GB ต่อเดือน

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## บริการจัดการข้อมูล

  * [Aiven](https://aiven.io/) - ให้บริการ PostgreSQL, MySQL และ Redis ฟรีบนแพลตฟอร์มโอเพนซอร์สของตน โหนดเดียว 1 CPU, 1GB RAM สำหรับ PostgreSQL และ MySQL มีพื้นที่เก็บข้อมูล 5GB ย้ายไปแผนที่ใหญ่ขึ้นหรือข้าม Cloud ได้ง่าย
  * [airtable.com](https://airtable.com/) — หน้าตาคล้ายสเปรดชีต แต่เป็นฐานข้อมูลเชิงสัมพันธ์ สร้างฐานข้อมูลไม่จำกัด, 1,200 แถว/ฐาน, และ 1,000 คำขอ API/เดือน
  * [Astra](https://www.datastax.com/products/datastax-astra/) — Cloud Native Cassandra as a Service พร้อม [80GB ฟรี](https://www.datastax.com/products/datastax-astra/pricing)
  * [codehooks.io](https://codehooks.io/) — บริการ API/backend serverless JavaScript และฐานข้อมูล NoSQL ใช้งานง่าย มีฟังก์ชัน คำสั่ง Mongdb-ish ค้นหา key/value ระบบ job ข้อความเรียลไทม์ คิว worker CLI ทรงพลัง และ data manager บนเว็บ แผนฟรีให้พื้นที่เก็บข้อมูล 5GB และ 60/API calls ต่อนาที รองรับนักพัฒนา 2 คน ไม่ต้องใช้บัตรเครดิต
  * [CrateDB](https://crate.io/) - ฐานข้อมูล SQL แบบกระจายสำหรับการวิเคราะห์เรียลไทม์ [Free Tier CRFREE](https://crate.io/lp-crfree): โหนดเดียว 2 CPU, RAM 2 GiB, พื้นที่เก็บข้อมูล 8 GiB หนึ่งคลัสเตอร์ต่อองค์กร ไม่ต้องใช้วิธีชำระเงิน
  * [Upstash](https://upstash.com/) — Redis serverless พร้อมแผนฟรี สูงสุด 10,000 คำขอต่อวัน, ขนาดฐานข้อมูลสูงสุด 256MB, การเชื่อมต่อพร้อมกัน 20 รายการ
  * [Couchbase Capella](https://www.couchbase.com/products/capella/) - ฐานข้อมูลคลัสเตอร์ที่จัดการเต็มรูปแบบสำหรับนักพัฒนา มีแผนใช้ฟรีตลอดกาล
  * [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) — แผนฟรีให้พื้นที่ 512 MB
  * [redsmin.com](https://www.redsmin.com/) — บริการมอนิเตอร์และจัดการ Redis แบบเรียลไทม์ออนไลน์ ฟรีสำหรับ 1 instance
  * [redislabs](https://redislabs.com/try-free/) - Redis ขนาด 30MB ฟรี
  * [MemCachier](https://www.memcachier.com/) — บริการ Memcache แบบ Managed ฟรีสูงสุด 25MB, 1 Proxy Server และ analytics ขั้นพื้นฐาน
  * [scalingo.com](https://scalingo.com/) — เป็นหลักคือ PaaS แต่มีแผน MySQL, PostgreSQL หรือ MongoDB ฟรี 128MB ถึง 192MB
  * [SeaTable](https://seatable.io/) — ฐานข้อมูลยืดหยุ่นสไตล์สเปรดชีตโดยทีม Seafile ตารางไม่จำกัด, 2,000 แถว, เวอร์ชันย้อนหลัง 1 เดือน, สูงสุด 25 สมาชิกในทีม
  * [skyvia.com](https://skyvia.com/) — Cloud Data Platform มีแผนฟรีและทุกแผนใช้ฟรีขณะอยู่ในเบต้า
  * [StackBy](https://stackby.com/) — เครื่องมือเดียวรวมความยืดหยุ่นของสเปรดชีต พลังของฐานข้อมูล และการเชื่อมต่อกับแอปธุรกิจโปรด แผนฟรีมีผู้ใช้ไม่จำกัด 10 stack และแนบไฟล์ได้ 2GB ต่อ stack
  * [TiDB Cloud](https://en.pingcap.com/tidb-cloud/) — TiDB เป็น MySQL-compatible distributed HTAP RDBMS แบบโอเพนซอร์ส Serverless ให้พื้นที่เก็บแถว 5GB คอลัมน์ 5GB และ 50 ล้าน Request Units (RUs) ฟรีต่อเดือน
  * [Turso by ChiselStrike](https://chiselstrike.com/) - Turso คือ SQLite Developer Experience ใน Edge Database มีแผน Free Forever เริ่มต้น รวมพื้นที่ 9 GB ฐานข้อมูลสูงสุด 500 อัน สูงสุด 3 locations อ่านแถวได้ 1 พันล้านแถวต่อเดือน รองรับ Local dev ด้วย SQLite
  * [InfluxDB](https://www.influxdata.com/) — ฐานข้อมูล Timeseries ฟรีสูงสุด 3MB/5 นาที เขียน, 30MB/5 นาที อ่าน และ 10,000 series
  * [restdb.io](https://restdb.io/) - NoSQL cloud database ใช้งานง่ายและรวดเร็ว มี schema, relations, REST API อัตโนมัติ (query แบบ MongoDB), multi-user admin UI มีประสิทธิภาพ แผนฟรีรองรับ 3 ผู้ใช้, 2,500 records, และ 1 API request/วินาที
  * [CockroachDB Cloud](https://www.cockroachlabs.com/pricing/) — ฟรี 50 ล้าน RUs และ 10 GiB storage (เท่ากับ $15) ต่อเดือน ([Request Units คืออะไร](https://www.cockroachlabs.com/docs/cockroachcloud/metrics-request-units.html))
  * [Neo4j Aura](https://neo4j.com/cloud/aura/) — ฐานข้อมูลกราฟ/แพลตฟอร์ม analytics พร้อม Cypher query language และ REST API จำกัดกราฟ (50,000 nodes, 175,000 relationships)
  * [Neon](https://neon.tech/) — PostgreSQL แบบ Managed, พื้นที่ 0.5 GB (รวม), 1 โปรเจกต์, 10 branches, ฐานข้อมูลไม่จำกัด, primary branch พร้อมใช้งานเสมอ (Auto suspend หลัง 5 นาที), 20 ชั่วโมง Active time/เดือน (รวม) สำหรับ non-primary branch
  * [Prisma Postgres](https://prisma.io/postgres) - PostgreSQL แบบโฮสต์ความเร็วสูงบน unikernels และรันบน bare metal, พื้นที่ 1GB, 10 ฐานข้อมูล, รวมกับ Prisma ORM
  * [Dgraph Cloud](https://cloud.dgraph.io/pricing?type=free) — ฐานข้อมูลกราฟพร้อม GraphQL API จำกัด data transfer 1 MB/วัน
  * [Tinybird](https://tinybird.co) - ClickHouse แบบ serverless managed รองรับ data ingest over HTTP และเผยแพร่ SQL query เป็น managed HTTP APIs แผนฟรีไม่จำกัดเวลา 10GB storage + 1000 API requests/วัน
  * [TigerGraph Cloud](https://www.tigergraph.com/cloud/) — ฐานข้อมูลกราฟ/analytics พร้อม SQL-like graph query language และ REST API อินสแตนซ์ฟรี 1 ตัว 2 vCPU, 8GB Memory, 50GB storage หลับหลังไม่มีการใช้งาน 1 ชั่วโมง
  * [TerminusCMS](https://terminusdb.com/pricing) — บริการ TerminusDB ฟรีแบบ Managed ฐานข้อมูลเอกสารและกราฟเขียนด้วย Prolog และ Rust ฟรีสำหรับ dev มีจ่ายเงินสำหรับองค์กร
  * [filess.io](https://filess.io) - สร้างฐานข้อมูล 2 ฐาน (MySQL, MariaDB, MongoDB, PostgreSQL) สูงสุด 10 MB ต่อฐาน ฟรี
  * [xata.io](https://xata.io) - Database serverless พร้อม search และ analytics ในตัว API เดียว, client library type-safe หลายภาษา, ปรับแต่งให้เหมาะกับ workflow dev แผนฟรีตลอดกาลเหมาะสำหรับนักพัฒนางานอดิเรก ให้ Xata 3 unit (ดูนิยาม unit ที่เว็บ)
  * [8base.com](https://www.8base.com/) - แพลตฟอร์ม low-code เต็มรูปแบบสำหรับ JavaScript บน MySQL, GraphQL, backend serverless มี UI app builder แผนฟรี: 2,500 แถว, พื้นที่ 500, Serverless computing 1Gb/h, ผู้ใช้ client app 5 คน
  * [Nile](https://www.thenile.dev/) — แพลตฟอร์ม Postgres สำหรับแอป B2B ฐานข้อมูลไม่จำกัด ออนไลน์เสมอ 1GB พื้นที่ (รวม), 50 ล้าน query tokens, autoscaling, vector embedding ไม่จำกัด

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## Tunneling, WebRTC, Web Socket Servers และ Router อื่น ๆ

  * [Pinggy](https://pinggy.io) — สร้าง Public URL สำหรับ localhost ด้วยคำสั่งเดียว ไม่ต้องดาวน์โหลด รองรับ HTTPS / TCP / TLS tunnels แผนฟรีมีอายุ tunnel 60 นาที
  * [conveyor.cloud](https://conveyor.cloud/) — ส่วนเสริม Visual Studio สำหรับเปิดเผย IIS Express ไปยังเครือข่ายภายในหรือ URL สาธารณะผ่าน tunnel
  * [Hamachi](https://www.vpn.net/) — LogMeIn Hamachi เป็นบริการ VPN โฮสต์สำหรับสร้างเครือข่ายแบบ LAN สำหรับทีมที่กระจายตัว แผนฟรีมีเครือข่ายไม่จำกัด สูงสุด 5 คนต่อเครือข่าย
  * [Mirna Sockets](https://mirna.cloud/) - แพลตฟอร์ม Socket as a Service ฟรี ได้ URL wss:// เมื่อดีพลอยโค้ด Web Socket Server และมอนิเตอร์ประสิทธิภาพได้
  * [localhost.run](https://localhost.run/) — เปิดเผย server ที่รันในเครื่องไปยัง URL สาธารณะผ่าน tunnel
  * [localtunnel](https://theboroer.github.io/localtunnel-www/) — เปิดเผย server ที่รันในเครื่องผ่าน tunnel ไปยัง URL สาธารณะ มีเวอร์ชันฟรี และ [open source](https://github.com/localtunnel/localtunnel)
  * [ngrok.com](https://ngrok.com/) — เปิดเผย server ที่รันในเครื่องผ่าน tunnel ไปยัง URL สาธารณะ
  * [cname.dev](https://cname.dev/) — บริการ dynamic reverse proxy ฟรีและปลอดภัย
  * [serveo](https://serveo.net/) — เปิดเผย server ในเครื่องไปยังอินเทอร์เน็ต ไม่ต้องติดตั้ง ไม่ต้องสมัคร ฟรีซับโดเมน ไม่จำกัด
  * [Radmin VPN](https://www.radmin-vpn.com/) — เชื่อมต่อคอมพิวเตอร์หลายเครื่องผ่าน VPN สร้างเครือข่ายคล้าย LAN ไม่จำกัดผู้ใช้ (ทางเลือกแทน Hamachi)
  * [segment.com](https://segment.com/) — Hub สำหรับแปลงและส่งต่อ events ไปยังบริการ third-party อื่น ๆ ฟรี 100,000 events/เดือน
  * Google STUN — [stun:stun.l.google.com:19302](stun:stun.l.google.com:19302)
  * Twilio STUN — [stun:global.stun.twilio.com:3478?transport=udp](stun:global.stun.twilio.com:3478?transport=udp)
  * [Tailscale](https://tailscale.com/) — VPN Zero config ใช้ WireGuard ติดตั้งได้บน MacOS, iOS, Windows, Linux, Android แผนฟรีสำหรับส่วนตัว 100 อุปกรณ์ และ 3 ผู้ใช้
  * [webhookrelay.com](https://webhookrelay.com) — จัดการ debug fan-out และ proxy webhooks ทั้งไปยังปลายทางสาธารณะหรือภายใน (เช่น localhost) รวมถึงเปิดเผย server ใน private network ผ่าน HTTP endpoint (`https://yoursubdomain.webrelay.io <----> http://localhost:8080`)
  * [Hookdeck](https://hookdeck.com/pricing) — พัฒนา ทดสอบ และมอนิเตอร์ webhook ได้จากทุกที่ ฟรี 100K requests และ 100K attempts ต่อเดือน เก็บข้อมูล 3 วัน
  * [Xirsys](https://www.xirsys.com/pricing/) — STUN ไม่จำกัด + TURN 500 MB ต่อเดือน จำกัดแบนด์วิดท์ เลือกได้ 1 ภูมิภาค
  * [ZeroTier](https://www.zerotier.com) — FOSS managed virtual Ethernet as a service สร้างเครือข่ายเข้ารหัส end-to-end ฟรี 25 ไคลเอนต์ มี clients สำหรับ desktop/mobile/NA จัดการ routing rules และอนุมัติไคลเอนต์ใหม่บนเว็บ
  * [LocalXpose](https://localxpose.io) — Reverse proxy สำหรับเปิดเผย server ในเครื่องไปยังอินเทอร์เน็ต แผนฟรี tunnel อยู่ได้ 15 นาที
  * [Traefik-Hub](https://traefik.io/traefik-hub/) - เผยแพร่บริการที่รันในเครื่องผ่าน tunnel ไปยัง URL สาธารณะแบบ custom และป้องกันด้วย access control ฟรีสำหรับ 5 บริการใน 1 cluster
  * [Expose](https://expose.dev/) - เปิดเผยเว็บไซต์ในเครื่องผ่าน tunnel ที่ปลอดภัย แผนฟรีมี EU Server, ซับโดเมนสุ่ม, ผู้ใช้เดี่ยว
  * [btunnel](https://www.btunnel.in/) — เปิดเผย localhost และ local tcp server ไปยังอินเทอร์เน็ต แผนฟรีมี file server, ตั้ง header http request/response ได้, ป้องกันด้วย basic auth, tunnel มีอายุ 1 ชั่วโมง

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## การติดตามปัญหาและการจัดการโปรเจกต์

  * [acunote.com](https://www.acunote.com/) — ซอฟต์แวร์บริหารโปรเจกต์และ SCRUM ฟรีสูงสุด 5 สมาชิก
  * [asana.com](https://asana.com/) — ฟรีสำหรับโปรเจกต์ส่วนตัวที่มีผู้ร่วมงาน
  * [Backlog](https://backlog.com) — เครื่องมือครบวงจรสำหรับทีมในการปล่อยโปรเจกต์ แผนฟรี 1 โปรเจกต์ 10 ผู้ใช้ & 100MB storage
  * [Basecamp](https://basecamp.com/personal) - รายการงาน, จัดการเป้าหมาย, ข้อความแบบฟอรั่ม, แชร์ไฟล์, ติดตามเวลา สูงสุด 3 โปรเจกต์, 20 ผู้ใช้, 1GB storage
  * [bitrix24.com](https://www.bitrix24.com/) — เครื่องมือ Intranet และบริหารโปรเจกต์ แผนฟรีมี 5GB สำหรับผู้ใช้ไม่จำกัด
  * [cacoo.com](https://cacoo.com/) — วาดไดอะแกรมออนไลน์เรียลไทม์: flowchart, UML, network ฟรีสูงสุด 15 ผู้ใช้/diagram, 25 sheets
  * [Chpokify](https://chpokify.com/) — Planning Poker สำหรับทีม ประหยัดเวลาประเมิน sprint ฟรีสูงสุด 5 ผู้ใช้, ฟรีเชื่อมต่อ Jira, วิดีโอคอลไม่จำกัด, ทีมและเซสชันไม่จำกัด
  * [clickup.com](https://clickup.com/) — บริหารโปรเจกต์ ฟรี มีเวอร์ชันพรีเมียมพร้อม cloud storage มีแอปมือถือและเชื่อมต่อ Git ได้
  * [Clockify](https://clockify.me) - แอปบันทึกเวลาและ timesheet สำหรับติดตามชั่วโมงทำงานในโปรเจกต์ ไม่จำกัดผู้ใช้ ฟรีตลอดไป
  * [Cloudcraft](https://cloudcraft.co/) — ออกแบบไดอะแกรมสถาปัตยกรรมอย่างมืออาชีพในไม่กี่นาทีด้วย visual designer ของ Cloudcraft เหมาะกับ AWS มีชิ้นส่วนอัจฉริยะโชว์ข้อมูลสด แผนฟรีสร้างไดอะแกรมส่วนตัวไม่จำกัดสำหรับผู้ใช้เดี่ยว
  * [Codegiant](https://codegiant.io) — บริหารโปรเจกต์พร้อมโฮสต์ repository & CI/CD แผนฟรีมี repository, โปรเจกต์ & เอกสารไม่จำกัด 5 สมาชิก 500 นาที CI/CD ต่อเดือน 30,000 นาที Serverless Code Run ต่อเดือน 1GB repository storage
  * [Confluence](https://www.atlassian.com/software/confluence) - เครื่องมือ collaboration ของ Atlassian สำหรับทีม แผนฟรีสูงสุด 10 ผู้ใช้
  * [contriber.com](https://www.contriber.com/) — แพลตฟอร์มบริหารโปรเจกต์ปรับแต่งได้ แผนเริ่มต้นฟรี 5 workspaces
  * [Crosswork](https://crosswork.app/) - แพลตฟอร์มบริหารจัดการโครงการที่หลากหลาย ฟรีสำหรับสูงสุด 3 โครงการ ผู้ใช้ไม่จำกัด พื้นที่เก็บข้อมูล 1 GB
  * [diagrams.net](https://app.diagrams.net/) — สร้างไดอะแกรมออนไลน์โดยจัดเก็บไว้ใน Google Drive, OneDrive หรือ Dropbox ฟรีสำหรับทุกฟีเจอร์และระดับพื้นที่จัดเก็บข้อมูล
  * [freedcamp.com](https://freedcamp.com/) - งาน, พูดคุย, หมุดหมาย, ติดตามเวลา, ปฏิทิน, ไฟล์ และตัวจัดการรหัสผ่าน แผนฟรีรองรับโครงการ ผู้ใช้ และพื้นที่เก็บไฟล์ไม่จำกัด
  * [easyretro.io](https://www.easyretro.io/) — เครื่องมือ retrospective สำหรับ sprint ที่เรียบง่ายและใช้งานง่าย แผนฟรีมีบอร์ดสาธารณะ 3 บอร์ด และแบบสำรวจ 1 ครั้งต่อบอร์ดต่อเดือน
  * [GForge](https://gforge.com) — เครื่องมือบริหารจัดการโครงการและติดตามปัญหาสำหรับโครงการที่ซับซ้อน ทั้งแบบติดตั้งเองและ SaaS แผน SaaS ฟรีสำหรับผู้ใช้ 5 คนแรก และฟรีสำหรับโครงการ Open Source
  * [gleek.io](https://www.gleek.io) — เครื่องมือแปลงคำอธิบายเป็นไดอะแกรมสำหรับนักพัฒนา สร้าง UML class, object หรือ entity-relationship แบบไม่เป็นทางการด้วยคีย์เวิร์ดของคุณ ฟรี
  * [GraphQL Inspector](https://github.com/marketplace/graphql-inspector) - GraphQL Inspector แสดงรายการความแตกต่างระหว่าง schema ของ GraphQL สองชุด พร้อมอธิบายและจัดประเภทว่า breaking, non-breaking หรือ dangerous
  * [huboard.com](https://huboard.com/) — บริหารจัดการโครงการสำหรับ GitHub issues ของคุณทันที ฟรีสำหรับ Open Source
  * [Hygger](https://hygger.io) — แพลตฟอร์มบริหารจัดการโครงการ แผนฟรีรองรับผู้ใช้, โครงการ และบอร์ดไม่จำกัด พร้อมพื้นที่จัดเก็บ 100 MB
  * [Instabug](https://instabug.com) — SDK รายงานบั๊กและรับ feedback ในแอปอย่างครอบคลุมสำหรับแอปมือถือ แผนฟรีรองรับ 1 แอปและ 1 สมาชิก
  * [WishKit](https://wishkit.io) — รวบรวม feedback จากผู้ใช้ในแอป iOS/macOS และจัดลำดับความสำคัญฟีเจอร์ตามคะแนนโหวตของผู้ใช้ แผนฟรีรองรับ 1 แอป
  * [Ilograph](https://www.ilograph.com/)  — ไดอะแกรมแบบ interactive ให้ผู้ใช้เห็นโครงสร้างพื้นฐานจากหลายมุมมองและรายละเอียด แผนฟรีมีไดอะแกรมส่วนตัวไม่จำกัด สูงสุด 3 ผู้ชม
  * [Jira](https://www.atlassian.com/software/jira) — เครื่องมือบริหารจัดการโครงการซอฟต์แวร์ระดับสูงที่ใช้ในองค์กรต่าง ๆ แผนฟรีสำหรับสูงสุด 10 ผู้ใช้
  * [kanbanflow.com](https://kanbanflow.com/) — การบริหารโครงการแบบบอร์ด ฟรี และมีเวอร์ชันพรีเมียมที่มีฟีเจอร์เพิ่ม
  * [kanbantool.com](https://kanbantool.com/) — บริหารจัดการโครงการด้วยบอร์ด Kanban แผนฟรีมี 2 บอร์ด 2 ผู้ใช้ ไม่มีไฟล์แนบหรือไฟล์
  * [kan.bn](https://kan.bn/) - แอป kanban ที่ทรงพลังและยืดหยุ่น ช่วยจัดการงาน ติดตามความคืบหน้า และส่งมอบผลลัพธ์ในที่เดียว แผนฟรีสำหรับ 1 ผู้ใช้ บอร์ดไม่จำกัด ลิสต์ไม่จำกัด การ์ดไม่จำกัด
  * [Kitemaker.co](https://kitemaker.co) - ทำงานร่วมกันตลอดกระบวนการพัฒนาและติดตามงานข้าม Slack, Discord, Figma, และ Github ผู้ใช้ไม่จำกัด สเปซไม่จำกัด แผนฟรีรองรับ 250 รายการงาน
  * [Kiter.app](https://www.kiter.app/) - ให้ทุกคนจัดการหางานและติดตามสัมภาษณ์ โอกาส และเครือข่าย แอปเว็บและ Chrome extension ทรงพลัง ฟรีทั้งหมด
  * [Kumu.io](https://kumu.io/)  — แผนที่ความสัมพันธ์พร้อมแอนิเมชัน ตกแต่ง ฟิลเตอร์ การจัดกลุ่ม นำเข้า spreadsheet ฯลฯ แผนฟรีรองรับโครงการสาธารณะไม่จำกัด ขนาดกราฟไม่จำกัด โครงการส่วนตัวฟรีสำหรับนักเรียน มีโหมด Sandbox หากไม่ต้องการเผยแพร่ไฟล์ออนไลน์ (อัปโหลด แก้ไข ดาวน์โหลด ทิ้งไฟล์)
  * [Linear](https://linear.app/) — ระบบติดตามปัญหาพร้อมอินเทอร์เฟซลื่นไหล ฟรีสำหรับสมาชิกไม่จำกัด อัปโหลดไฟล์สูงสุด 10MB สูงสุด 250 issues (ไม่รวม Archive)
  * [leiga.com](https://www.leiga.com/) — Leiga เป็นผลิตภัณฑ์ SaaS ที่ใช้ AI จัดการโครงการอัตโนมัติ ช่วยทีมโฟกัสและปลดปล่อยศักยภาพอย่างเต็มที่ รับประกันความคืบหน้าตามแผน ฟรีสำหรับ 10 ผู้ใช้ 20 ฟิลด์แบบ custom พื้นที่เก็บข้อมูล 2GB บันทึกวิดีโอด้วย AI จำกัด 5 นาที/วิดีโอ Automation 20 ครั้ง/ผู้ใช้/เดือน
  * [Lucidchart](https://www.lucidchart.com/) - เครื่องมือสร้างไดอะแกรมออนไลน์พร้อมฟีเจอร์ทำงานร่วมกัน แผนฟรีมีเอกสารแก้ไขได้ 3 ฉบับ เทมเพลตมืออาชีพ 100 แบบ และฟีเจอร์การร่วมมือพื้นฐาน
  * [MeisterTask](https://www.meistertask.com/) — ระบบจัดการงานออนไลน์สำหรับทีม ฟรีสูงสุด 3 โครงการ สมาชิกไม่จำกัด
  * [MeuScrum](https://www.meuscrum.com/en) - เครื่องมือ scrum ออนไลน์ฟรีพร้อม kanban board
  * [nTask](https://www.ntaskmanager.com/) — ซอฟต์แวร์บริหารโครงการที่ช่วยให้ทีมทำงานร่วมกัน วางแผน วิเคราะห์ และจัดการงานประจำวัน แผน Essential ฟรีตลอดชีพ พื้นที่เก็บ 100 MB ผู้ใช้/ทีม 5 คน เวิร์กสเปซไม่จำกัด ประชุม มอบหมายงาน timesheets และ issue tracking ไม่จำกัด
  * [Ora](https://ora.pm/) - บริหารงานแบบ Agile และทำงานร่วมกันในทีม ฟรีสูงสุด 3 ผู้ใช้ ไฟล์จำกัดที่ 10 MB
  * [pivotaltracker.com](https://www.pivotaltracker.com/) — ฟรีสำหรับโครงการสาธารณะไม่จำกัด และโครงการส่วนตัว 2 โครงการ ผู้ใช้งาน (อ่าน-เขียน) รวม 3 คน ผู้ใช้อ่านอย่างเดียวไม่จำกัด
  * [plan.io](https://plan.io/) — บริหารจัดการโครงการ พร้อมโฮส repository และฟีเจอร์เพิ่มเติม ฟรีสำหรับ 2 ผู้ใช้ 10 ลูกค้า และพื้นที่ 500MB
  * [Plane](https://plane.so/) - Plane เป็นเครื่องมือบริหารจัดการโครงการและผลิตภัณฑ์แบบโอเพนซอร์สที่เรียบง่ายและขยายได้ ฟรีสำหรับสมาชิกไม่จำกัด อัปโหลดไฟล์สูงสุด 5MB 1000 issues
  * [planitpoker.com](https://www.planitpoker.com/) — ฟรี online planning poker (เครื่องมือประมาณการ)
  * [point.poker](https://www.point.poker/) - Online Planning Poker (เครื่องมือประมาณการแบบฉันทามติ) ฟรีสำหรับผู้ใช้ ทีม เซสชัน รอบ และคะแนนโหวตไม่จำกัด ไม่ต้องลงทะเบียน
  * [ScrumFast](https://www.scrumfast.com) - Scrum board พร้อมอินเทอร์เฟซใช้งานง่าย ฟรีสูงสุด 5 ผู้ใช้
  * [Shake](https://www.shakebugs.com/) - เครื่องมือรายงานบั๊กและรับ feedback ในแอปมือถือ แผนฟรี 10 รายงานบั๊กต่อแอป/เดือน
  * [Shortcut](https://shortcut.com/) - แพลตฟอร์มบริหารจัดการโครงการ ฟรีสำหรับสูงสุด 10 ผู้ใช้ตลอดไป
  * [Tadum](https://tadum.app) - แอปวาระและบันทึกการประชุมสำหรับประชุมประจำ ฟรีสำหรับทีมสูงสุด 10 คน
  * [taiga.io](https://taiga.io/) — แพลตฟอร์มบริหารจัดการโครงการสำหรับสตาร์ทอัปและนักพัฒนา agile ฟรีสำหรับ Open Source
  * [Tara AI](https://tara.ai/) — บริการบริหารจัดการ sprint ที่เรียบง่าย แผนฟรีมีงาน, sprint และ workspace ไม่จำกัด ไม่มีข้อจำกัดจำนวนผู้ใช้
  * [targetprocess.com](https://www.targetprocess.com/) — บริหารโครงการเชิงภาพ ตั้งแต่ Kanban และ Scrum ถึงกระบวนการปฏิบัติงานทุกรูปแบบ ฟรีสำหรับผู้ใช้ไม่จำกัด สูงสุด 1,000 entity ข้อมูล {[รายละเอียดเพิ่มเติม](https://www.targetprocess.com/pricing/)}
  * [taskade.com](https://www.taskade.com/) — รายการงานและร่างโครงงานแบบร่วมมือกันแบบเรียลไทม์ แผนฟรีมี workspace 1 แห่ง งานและโครงการไม่จำกัด พื้นที่ไฟล์ 1GB ประวัติโครงการ 1 สัปดาห์ ผู้เข้าร่วมประชุมวิดีโอ 5 คน
  * [taskulu.com](https://taskulu.com/) — บริหารโครงการแบบ Role-based ฟรีสูงสุด 5 ผู้ใช้ เชื่อมต่อกับ GitHub/Trello/Dropbox/Google Drive ได้
  * [Teaminal](https://www.teaminal.com) - เครื่องมือ standup, retro และ sprint planning สำหรับทีมรีโมต ฟรีสูงสุด 15 ผู้ใช้
  * [teamwork.com](https://teamwork.com/) — บริหารโครงการ & แชททีม ฟรีสำหรับ 5 ผู้ใช้ และ 2 โครงการ มีแผนพรีเมียม
  * [teleretro.com](https://www.teleretro.com/) — เครื่องมือ retrospective ที่เรียบง่ายและสนุกพร้อม icebreakers, gifs และอิโมจิ แผนฟรีมี 3 retros สมาชิกไม่จำกัด
  * [testlio.com](https://testlio.com/) — แพลตฟอร์มติดตามปัญหา จัดการทดสอบ และ beta testing ฟรีสำหรับใช้งานส่วนตัว
  * [terrastruct.com](https://terrastruct.com/) — เครื่องมือสร้างไดอะแกรมออนไลน์โดยเฉพาะสำหรับสถาปัตยกรรมซอฟต์แวร์ แผนฟรีสูงสุด 4 เลเยอร์ต่อไดอะแกรม
  * [todoist.com](https://todoist.com/) — ระบบจัดการงานร่วมกันและรายบุคคล แผนฟรีมี: 5 โครงการใช้งาน, 5 ผู้ใช้ต่อโครงการ, อัปโหลดไฟล์สูงสุด 5MB, ฟิลเตอร์ 3 อัน, ประวัติกิจกรรม 1 สัปดาห์
  * [trello.com](https://trello.com/) — บริหารโครงการแบบบอร์ด Unlimited Personal Boards, 10 Team Boards
  * [Tweek](https://tweek.so/) — ปฏิทินและจัดการงานแบบรายสัปดาห์ที่เรียบง่าย
  * [ubertesters.com](https://ubertesters.com/) — แพลตฟอร์มทดสอบ การรวมระบบ และ crowd testers 2 โครงการ 5 สมาชิก
  * [Wikifactory](https://wikifactory.com/) — บริการออกแบบผลิตภัณฑ์พร้อมโครงการ, VCS & Issues แผนฟรีรองรับโครงการและผู้ร่วมงานไม่จำกัด พื้นที่ 3GB
  * [Yodiz](https://www.yodiz.com/) — การพัฒนา agile และติดตามปัญหา ฟรีสูงสุด 3 ผู้ใช้ โครงการไม่จำกัด
  * [YouTrack](https://www.jetbrains.com/youtrack/buy/#edition=incloud) — โฮสต์ YouTrack (InCloud) ฟรีสำหรับโครงการ FOSS และโครงการส่วนตัว (ฟรีสำหรับ 3 ผู้ใช้) รวมการติดตามเวลาและ agile boards
  * [zenhub.com](https://www.zenhub.com) — โซลูชันบริหารโครงการเดียวที่อยู่ภายใน GitHub ฟรีสำหรับ public repo, OSS, และองค์กรไม่แสวงหากำไร
  * [zenkit.com](https://zenkit.com) — เครื่องมือบริหารโครงการและทำงานร่วมกัน ฟรีสูงสุด 5 สมาชิก แนบไฟล์ 5 GB
  * [Zube](https://zube.io) — บริหารโครงการ แผนฟรีสำหรับ 4 โครงการ & 4 ผู้ใช้ มี GitHub integration
  * [Toggl](https://toggl.com/) — มี 2 เครื่องมือ productivity ฟรี [Toggl Track](https://toggl.com/track/) สำหรับจัดการและติดตามเวลา แผนฟรีออกแบบเพื่อฟรีแลนซ์ รายการติดตาม, โปรเจกต์, ลูกค้า, tag, รายงาน ฯลฯ ไม่จำกัด และ [Toggl Plan](https://toggl.com/plan/) สำหรับวางแผนงาน แผนฟรีสำหรับนักพัฒนาเดี่ยว งาน, milestone, timeline ไม่จำกัด
  * [Sflow](https://sflow.io) — sflow.io เป็นเครื่องมือบริหารโครงการสำหรับ Agile, การตลาด, การขาย, และซัพพอร์ตลูกค้า โดยเฉพาะสำหรับงานเอาท์ซอร์สและความร่วมมือข้ามองค์กร แผนฟรีสูงสุด 3 โครงการ 5 สมาชิก
  * [Pulse.red](https://pulse.red) — Free Minimalistic Time Tracker และ Timesheet สำหรับโปรเจกต์

**[⬆️ Back to Top](#table-of-contents)**

## Storage and Media Processing

  * [AndroidFileHost](https://androidfilehost.com/) - แพลตฟอร์มแบ่งปันไฟล์ฟรี ความเร็วไม่จำกัด แบนด์วิดท์ จำนวนไฟล์ จำนวนดาวน์โหลด ฯลฯ มุ่งเน้นไฟล์ที่เกี่ยวกับการพัฒนา Android เช่นไฟล์ APK, custom ROM, การดัดแปลง ฯลฯ แต่ดูเหมือนจะรับไฟล์ประเภทอื่นได้เช่นกัน
  * [borgbase.com](https://www.borgbase.com/) — โฮสติ้งสำรองข้อมูล offsite สำหรับ Borg Backup อย่างง่ายและปลอดภัย พื้นที่สำรองข้อมูลฟรี 10 GB และ 2 repository
  * [icedrive.net](https://www.icedrive.net/) - บริการเก็บข้อมูลบนคลาวด์ที่ใช้งานง่าย พื้นที่ฟรี 10 GB
  * [sync.com](https://www.sync.com/) - บริการเก็บข้อมูลคลาวด์แบบ End-to-End พื้นที่ฟรี 5 GB
  * [pcloud.com](https://www.pcloud.com/) - บริการเก็บข้อมูลคลาวด์ พื้นที่ฟรีสูงสุด 10 GB
  * [sirv.com](https://sirv.com/) — Smart Image CDN พร้อมปรับแต่งและย่อขนาดภาพแบบเรียลไทม์ แผนฟรีมีพื้นที่ 500 MB แบนด์วิดท์ 2 GB
  * [cloudimage.io](https://www.cloudimage.io/en/home) — บริการปรับแต่งรูปภาพและ CDN แบบเต็มรูปแบบ มีจุดให้บริการมากกว่า 1500 แห่งทั่วโลก ฟังก์ชันปรับขนาด บีบอัด และลายน้ำ มีปลั๊กอินโอเพนซอร์สสำหรับ responsive images, 360 image และการแก้ไขภาพ แผนฟรีต่อเดือนมี CDN traffic 25GB cache storage 25GB และ transformations ไม่จำกัด
  * [cloudinary.com](https://cloudinary.com/) — อัปโหลดรูปภาพ ปรับแต่งขั้นสูง เก็บและส่งภาพสำหรับเว็บไซต์และแอป พร้อมไลบรารี Ruby, Python, Java, PHP, Objective-C ฯลฯ แผนฟรีมี 25 เครดิต/เดือน (1 เครดิต = 1,000 การปรับแต่งรูป, 1 GB storage, หรือ 1 GB CDN usage)
  * [embed.ly](https://embed.ly/) — API สำหรับฝังมีเดียในเว็บ, ปรับขนาดภาพแบบ responsive และดึง element จากเว็บ ฟรีสำหรับ 5,000 URLs/เดือน ที่ 15 requests/วินาที
  * [filestack.com](https://www.filestack.com/) — เลือกไฟล์, แปลง, และส่งต่อไฟล์ ฟรีสำหรับ 250 ไฟล์ 500 การแปลง 3 GB แบนด์วิดท์
  * [file.io](https://www.file.io) - พื้นที่เก็บไฟล์ 2 GB ไฟล์จะถูกลบอัตโนมัติหลังดาวน์โหลดครั้งเดียว มี REST API ให้ใช้งาน จำกัด 1 คำขอ/นาที
  * [freetools.site](https://freetools.site/) — เครื่องมือออนไลน์ฟรี แปลงหรือแก้ไขเอกสาร รูปภาพ เสียง วิดีโอ ฯลฯ
  * [GoFile.io](https://gofile.io/) - แพลตฟอร์มแบ่งปันและเก็บไฟล์ฟรี ใช้ได้ทั้งผ่านเว็บและ API ขนาดไฟล์, แบนด์วิดท์, จำนวนดาวน์โหลดไม่จำกัด แต่ไฟล์จะถูกลบเมื่อไม่มีการดาวน์โหลดนานเกิน 10 วัน
  * [gumlet.com](https://www.gumlet.com/) — โฮสต์ภาพและวิดีโอ, ประมวลผลและสตรีมผ่าน CDN แผนฟรีให้ 250 GB/เดือน สำหรับวิดีโอ และ 30 GB/เดือน สำหรับภาพ
  * [image-charts.com](https://www.image-charts.com/) — สร้าง image chart ไม่จำกัด พร้อมลายน้ำ
  * [Imgbot](https://github.com/marketplace/imgbot) — Imgbot คือบอทที่ช่วย optimize ภาพของคุณให้ขนาดไฟล์เล็กลงโดยไม่เสียคุณภาพ ฟรีสำหรับ open source
  * [ImgBB](https://imgbb.com/) — ImgBB คือบริการโฮสต์รูปภาพแบบไม่จำกัด ลากวางภาพได้ทุกที่บนหน้าจอ จำกัด 32 MB/ภาพ รับลิงก์ตรง BBCode และ HTML หลังอัปโหลด ล็อกอินเพื่อดูประวัติการอัปโหลด
  * [imgen](https://www.jitbit.com/imgen/) - API สร้างภาพปกโซเชียลฟรีแบบไม่จำกัด ไม่มีลายน้ำ
  * [imgix](https://www.imgix.com/) - แคชภาพ จัดการ และ CDN แผนฟรีรวม 1000 ภาพต้นฉบับ transformations ไม่จำกัด แบนด์วิดท์ 100 GB
  * [kraken.io](https://kraken.io/) — บริการปรับแต่งภาพเพื่อประสิทธิภาพเว็บไซต์ แผนฟรีรองรับไฟล์สูงสุด 1 MB
  * [kvstore.io](https://www.kvstore.io/) — บริการเก็บข้อมูลแบบ key-value แผนฟรีรองรับ 100 keys, 1KB/key, 100 calls/ชั่วโมง
  * [npoint.io](https://www.npoint.io/) — JSON store พร้อม collaborative schema editing
  * [nitropack.io](https://nitropack.io/) - เร่งความเร็วเว็บไซต์อัตโนมัติด้วยการ optimize front-end (แคช, ภาพ, โค้ด, CDN) ฟรีสำหรับ 5,000 pageviews/เดือน
  * [otixo.com](https://www.otixo.com/) — เข้ารหัส แชร์ คัดลอก ย้ายไฟล์คลาวด์ทั้งหมดจากที่เดียว แผนพื้นฐานย้ายไฟล์ไม่จำกัด ขนาดไฟล์สูงสุด 250 MB และเข้ารหัสไฟล์ได้ 5 ไฟล์
  * [packagecloud.io](https://packagecloud.io/) — โฮสต์ Package Repositories สำหรับ YUM, APT, RubyGem และ PyPI มีแผนฟรีแบบจำกัดและสำหรับโอเพนซอร์สตามคำขอ
  * [getpantry.cloud](https://getpantry.cloud/) — API จัดเก็บข้อมูล JSON อย่างง่าย เหมาะสำหรับโปรเจกต์ส่วนตัว, hackathon, และแอปมือถือ!
  * [Pinata IPFS](https://pinata.cloud) — Pinata คือวิธีที่ง่ายที่สุดในการอัปโหลดและจัดการไฟล์บน IPFS อินเทอร์เฟซผู้ใช้และ API ที่เป็นมิตร 1 GB storage ฟรี และเข้าถึง API
  * [placekitten.com](https://placekitten.com/) — บริการรูปแมวสำหรับใช้เป็น placeholder ได้อย่างรวดเร็วและง่ายดาย
  * [plot.ly](https://plot.ly/) — สร้างกราฟและแชร์ข้อมูล แผนฟรีมีไฟล์สาธารณะไม่จำกัด และไฟล์ส่วนตัว 10 ไฟล์
  * [podio.com](https://podio.com/) — ใช้งาน Podio กับทีมสูงสุด 5 คน ทดลองฟีเจอร์ของ Basic Plan (ยกเว้นการจัดการผู้ใช้)
  * [QRME.SH](https://qrme.sh) - เจนเนอเรเตอร์ QR code จำนวนมากที่รวดเร็วและสวยงาม – ไม่ต้องล็อกอิน ไม่มีลายน้ำ ไม่มีโฆษณา ส่งออกสูงสุด 100 URLs ต่อครั้ง
  * [QuickChart](https://quickchart.io) — สร้างกราฟภาพ, ชาร์ต, QR code สำหรับฝังในเว็บ
  * [redbooth.com](https://redbooth.com) — P2P file syncing ฟรีสูงสุด 2 ผู้ใช้
  * [resmush.it](https://resmush.it) — reSmush.it คือ API ฟรีสำหรับ optimize ภาพ รองรับ CMS หลัก เช่น WordPress, Drupal, Magento มีผู้ใช้มากกว่า 7 พันล้านภาพ และยังฟรีอยู่
  * [Shotstack](https://shotstack.io) - API สำหรับสร้างและแก้ไขวิดีโอในปริมาณมาก ฟรีสูงสุด 20 นาทีของวิดีโอที่เรนเดอร์ต่อเดือน
  * [tinypng.com](https://tinypng.com/) — API สำหรับบีบอัดและย่อขนาดภาพ PNG และ JPEG ฟรี 500 compressions/เดือน
  * [transloadit.com](https://transloadit.com/) — จัดการอัปโหลดไฟล์และ encoding วิดีโอ เสียง รูปภาพ เอกสาร ฟรีสำหรับ Open source, องค์กรการกุศล, และนักเรียนผ่าน GitHub Student Developer Pack ใช้งานเชิงพาณิชย์ทดสอบฟรี 2 GB
* [twicpics.com](https://www.twicpics.com) - รูปภาพแบบ Responsive ในรูปแบบบริการ ให้บริการ image CDN, media processing API และไลบรารีฝั่ง frontend เพื่ออัตโนมัติการปรับแต่งรูปภาพ บริการนี้ฟรีสำหรับทราฟฟิกสูงสุด 3GB/เดือน
* [uploadcare.com](https://uploadcare.com/hub/developers/) — Uploadcare ให้บริการ media pipeline พร้อมชุดเครื่องมือที่สมบูรณ์แบบด้วยอัลกอริธึมที่ทันสมัย ฟีเจอร์ทั้งหมดสามารถใช้งานได้ฟรีสำหรับนักพัฒนา: File Uploading API และ UI, Image CDN และ Origin Services, Adaptive Delivery, และ Smart Compression แผนฟรีรองรับ 3,000 uploads, 3 GB ทราฟฟิก, และ 3 GB ที่เก็บข้อมูล
* [imagekit.io](https://imagekit.io) – Image CDN พร้อมการปรับแต่งอัตโนมัติ, การแปลงแบบเรียลไทม์, และพื้นที่จัดเก็บที่สามารถผสานเข้ากับระบบที่มีอยู่ได้ในไม่กี่นาที แผนฟรีรวมถึงแบนด์วิดท์สูงสุด 20GB ต่อเดือน
* [internxt.com](https://internxt.com) – Internxt Drive คือบริการจัดเก็บไฟล์แบบ zero-knowledge ที่เน้นความเป็นส่วนตัวและความปลอดภัยสูงสุด สมัครใช้งานและรับพื้นที่ 10 GB ฟรีตลอดไป!
* [degoo.com](https://degoo.com/) – Cloud storage ที่ใช้ AI ให้พื้นที่ฟรีสูงสุด 20 GB, ใช้งานได้ 3 อุปกรณ์, โบนัสชวนเพื่อน 5 GB (บัญชีไม่มีการใช้งาน 90 วันจะถูกลบ)
* [MConverter.eu](https://mconverter.eu/) – แปลงไฟล์เป็นกลุ่ม รองรับหลายฟอร์แมต รวมถึงฟอร์แมตใหม่อย่าง [AVIF](https://mconverter.eu/convert/to/avif/) ดึงเฟรมภาพทั้งหมดจากวิดีโอ ฟรีสำหรับไฟล์ขนาด 100MB ไม่เกินสิบไฟล์ต่อวัน ประมวลผลได้ครั้งละสองไฟล์
* [ImageEngine](https://imageengine.io/) – ImageEngine คือ image CDN ทั่วโลกที่ใช้งานง่าย ตั้งค่าใน 60 วินาที รองรับ AVIF และ JPEGXL, ปลั๊กอินสำหรับ WordPress, Magento, React, Vue และอื่นๆ สมัครบัญชีนักพัฒนาได้ฟรี [ที่นี่](https://imageengine.io/developer-program/)
* [DocsParse](https://docsparse.com/) – ประมวลผล PDF, รูปภาพด้วย AI (GPT) แปลงเป็นข้อมูลโครงสร้าง JSON, CSV, EXCEL ฟรี 30 เครดิตต่อเดือน
* [VaocherApp QR Code Generator](https://www.vaocherapp.com/qr-code-generator) – สร้าง QR code แบบกำหนดเองสำหรับบัตรของขวัญ, คูปอง, โปรโมชั่น รองรับการปรับแต่งสไตล์, สี, โลโก้ ฯลฯ
* [LibreQR](https://libreqr.com) — เครื่องมือสร้าง QR code ฟรี เน้นความเป็นส่วนตัว ไม่มีการติดตามการใช้งาน ใช้ได้ฟรีโดยไม่มีการเก็บข้อมูล

**[⬆️ กลับไปด้านบน](#table-of-contents)**

## การออกแบบและ UI

* [AllTheFreeStock](https://allthefreestock.com) - รายการรวมรูปภาพ, เสียง และวิดีโอ stock ฟรีที่คัดสรรแล้ว
* [Float UI](https://floatui.com/) - เครื่องมือพัฒนาเว็บฟรีสำหรับสร้างเว็บไซต์ทันสมัยที่ตอบสนองได้อย่างรวดเร็ว พร้อมดีไซน์สวยงาม แม้สำหรับผู้ไม่ถนัดออกแบบ
* [Ant Design Landing Page](https://landing.ant.design/) - Ant Design Landing Page ให้เทมเพลตที่สร้างจาก motion components ของ Ant Motion มีเทมเพลตหน้าแรกมากมาย ดาวน์โหลดโค้ดและนำไปใช้ได้ทันที หรือใช้ editor เพื่อสร้างเพจของคุณเองอย่างรวดเร็ว
* [Backlight](https://backlight.dev/) — แพลตฟอร์มโค้ดที่ครบถ้วนสำหรับทีมที่ต้องการสร้าง Document, Publish, Scale และดูแล Design Systems แผนฟรีรองรับ 3 ผู้แก้ไขต่อระบบ พร้อมผู้ชมไม่จำกัด
* [BoxySVG](https://boxy-svg.com/app) — Web app สำหรับวาด SVG ติดตั้งได้ฟรี ส่งออกเป็น SVG, PNG, JPEG และฟอร์แมตอื่นๆ
* [Carousel Hero](https://carouselhero.com/) - เครื่องมือออนไลน์ฟรีสำหรับสร้าง social media carousel
* [Circum Icons](https://circumicons.com) - ไอคอน open-source ที่สม่ำเสมอสำหรับ React, Vue, และ Svelte ในรูปแบบ SVG
* [clevebrush.com](https://www.cleverbrush.com/) — แอปออกแบบกราฟิก/จัดภาพฟรี และมีบริการ integration แบบชำระเงินสำหรับนำไปเป็นคอมโพเนนต์
* [cloudconvert.com](https://cloudconvert.com/) — แปลงไฟล์ทุกชนิด รองรับมากถึง 208 ฟอร์แมต รวมถึงวิดีโอและ gif
* [CodeMyUI](https://codemyui.com) - คลังตัวอย่างโค้ด Web Design & UI ที่คัดสรรมาแล้ว
* [ColorKit](https://colorkit.co/) - สร้างชุดสีออนไลน์หรือหาแรงบันดาลใจจากชุดสีชั้นนำ
* [coolors](https://coolors.co/) - ตัวสร้างชุดสี ฟรี
* [CMYK Pantone](https://www.cmyktopantone.com/) - แปลงค่า CMYK เป็น Pantone หรือโมเดลสีอื่นได้ง่าย ๆ ฟรี
* [Branition](https://branition.com/colors) - ชุดสีที่คัดสรรมาเพื่อใช้กับแบรนด์โดยเฉพาะ
* [css-gradient.com](https://www.css-gradient.com/) - เครื่องมือฟรีสำหรับสร้าง CSS gradient แบบ cross-browser ได้อย่างรวดเร็ว ในรูปแบบ RGB และ HEX
* [easyvectors.com](https://easyvectors.com/) — คลังเวกเตอร์ SVG ฟรี ดาวน์โหลดกราฟิกเวกเตอร์คุณภาพสูงได้ฟรี
* [figma.com](https://www.figma.com) — เครื่องมือออกแบบออนไลน์แบบร่วมมือกันสำหรับทีม แผนฟรีรองรับไฟล์และผู้ชมไม่จำกัด (สูงสุด 2 ผู้แก้ไข และ 3 โปรเจกต์)
* [Flyon UI](https://flyonui.com/) - ไลบรารีคอมโพเนนต์สำหรับ Tailwind CSS ที่ใช้งานง่ายที่สุด
* [framer.com](https://www.framer.com/) - Framer ช่วยให้คุณสร้างและแอนิเมตไอเดียอินเทอร์เฟซสำหรับแอป เว็บไซต์ หรือผลิตภัณฑ์ของคุณ เริ่มจาก layout ที่ทรงพลัง แผนฟรี: ผู้ชมไม่จำกัด, 2 ผู้แก้ไข, 3 โปรเจกต์
* [freeforcommercialuse.net](https://freeforcommercialuse.net/) — รูปภาพ stock พร้อม model/property release สำหรับใช้เชิงพาณิชย์อย่างไร้กังวล
* [Gradientos](https://www.gradientos.app) - เลือก gradient ได้อย่างรวดเร็วและง่ายดาย
* [Icon Horse](https://icon.horse) – ดึง favicon ความละเอียดสูงสุดสำหรับเว็บไซต์ใดก็ได้ด้วย API ที่ใช้ง่าย
* [Iconoir](https://iconoir.com) – ไลบรารีไอคอนโอเพ่นซอร์สที่มีไอคอนนับพัน รองรับ React, React Native, Flutter, Vue, Figma, Framer
* [Icons8](https://icons8.com) — ไอคอน, ภาพประกอบ, รูปถ่าย, เพลง และเครื่องมือออกแบบ แผนฟรีรองรับฟอร์แมตจำกัดและความละเอียดต่ำ ต้องใส่ลิงก์เครดิตเมื่อใช้ asset จาก Icons8
* [landen.co](https://www.landen.co) — สร้าง แก้ไข และเผยแพร่เว็บไซต์และ landing page สำหรับสตาร์ทอัพได้โดยไม่ต้องเขียนโค้ด แผนฟรีรองรับเว็บไซต์เดียว ปรับแต่งและเผยแพร่ได้เต็มที่
* [Quant Ux](https://quant-ux.com/) - เครื่องมือ prototyping และออกแบบ ฟรีและโอเพ่นซอร์ส
* [lensdump.com](https://lensdump.com/) - โฮสต์รูปภาพบนคลาวด์ฟรี
* [Lorem Picsum](https://picsum.photos/) - เครื่องมือสร้าง placeholder รูปภาพที่ใช้งานง่ายและดูดี แค่เพิ่มขนาดภาพที่ต้องการใน URL ก็จะได้ภาพสุ่ม
* [LottieFiles](https://lottiefiles.com/) - แพลตฟอร์มออนไลน์ Lottie Animation ที่ใหญ่ที่สุดในโลกสำหรับนักออกแบบ, นักพัฒนา และอื่นๆ พร้อมเครื่องมือและปลั๊กอินสำหรับ Android, iOS, และเว็บ
* [MagicPattern](https://www.magicpattern.design/tools) — เครื่องมือและ generator สำหรับสร้าง CSS & SVG background, gradients, patterns, blobs
* [marvelapp.com](https://marvelapp.com/) — ออกแบบ สร้างต้นแบบ และทำงานร่วมกัน แผนฟรีจำกัด 1 ผู้ใช้และ 1 โปรเจกต์
* [Mindmup.com](https://www.mindmup.com/) — สร้าง mind map ไม่จำกัดฟรี พร้อมจัดเก็บบนคลาวด์ เข้าถึงได้จากทุกอุปกรณ์
* [Mockplus iDoc](https://www.mockplus.com/idoc) - เครื่องมือร่วมมือออกแบบและ handoff ที่ทรงพลัง แผนฟรีรองรับ 3 ผู้ใช้ และ 5 โปรเจกต์ พร้อมฟีเจอร์ครบ
* [mockupmark.com](https://mockupmark.com/create/free) — สร้าง mockup เสื้อผ้าและสินค้าเสมือนจริงสำหรับโซเชียลและอีคอมเมิร์ซ ฟรี 40 mockup
* [Mossaik](https://mossaik.app) - Generator รูป SVG ฟรี พร้อมเครื่องมือต่าง ๆ เช่น waves, blobs และ patterns
* [movingpencils.com](https://movingpencils.com) — เครื่องมือวาดเวกเตอร์บนเบราว์เซอร์ เร็วและฟรี
* [Octopus.do](https://octopus.do) — เครื่องมือสร้าง sitemap แบบ visual สร้างโครงสร้างเว็บไซต์แบบเรียลไทม์และแชร์เพื่อทำงานร่วมกับทีม/ลูกค้า
* [Pencil](https://github.com/evolus/pencil) - เครื่องมือออกแบบโอเพ่นซอร์สที่ใช้ Electron
* [Penpot](https://penpot.app) - เครื่องมือออกแบบและสร้างต้นแบบบนเว็บแบบโอเพ่นซอร์ส รองรับ SVG ฟรี
* [pexels.com](https://www.pexels.com/) - รูปภาพ stock ฟรีสำหรับใช้เชิงพาณิชย์ พร้อม API ค้นหารูปด้วยคีย์เวิร์ด
* [photopea.com](https://www.photopea.com) — โปรแกรมออกแบบออนไลน์ขั้นสูง ฟรี พร้อม UI แบบ Adobe Photoshop รองรับไฟล์ PSD, XCF, Sketch (Photoshop, Gimp, Sketch App)
* [pixlr.com](https://pixlr.com/) — โปรแกรมแก้ไขภาพบนเบราว์เซอร์ฟรี ระดับเดียวกับเชิงพาณิชย์
* [Plasmic](https://www.plasmic.app/) - เครื่องมือออกแบบเว็บและ page builder ที่เร็ว ใช้งานง่าย และ robust สามารถสร้างหน้า responsive หรือคอมโพเนนต์ที่ซับซ้อนได้ และนำไปใช้กับ production
* [Pravatar](https://pravatar.cc/) - สร้าง avatar ปลอม/placeholder แบบสุ่ม พร้อม hot-link URL ใช้ในเว็บ/แอปได้โดยตรง
* [Proto.io](https://www.proto.io) - สร้าง UI prototype แบบ interactive ได้โดยไม่ต้องเขียนโค้ด แผนฟรีหลังหมดช่วงทดลองใช้ฟรี รวม 1 ผู้ใช้, 1 โปรเจกต์, 5 prototype, พื้นที่ 100MB, และดูผ่านแอป proto.io
* [resizeappicon.com](https://resizeappicon.com/) — บริการปรับขนาดและจัดการไอคอนแอปอย่างง่าย
* [Rive](https://rive.app) — สร้างและนำส่ง animation ที่สวยงามไปยังทุกแพลตฟอร์ม ฟรีตลอดชีพสำหรับบุคคล บริการมี editor และโฮสต์กราฟิก พร้อม runtime สำหรับใช้งานบนหลายแพลตฟอร์ม
* [storyset.com](https://storyset.com/) — สร้างภาพประกอบที่ปรับแต่งได้ฟรีสำหรับโปรเจกต์ของคุณ
* [smartmockups.com](https://smartmockups.com/) — สร้าง mockup สินค้า ฟรี 200 mockup
* [Shadcn Studio](https://shadcnstudio.com/theme-editor) — พรีวิวการเปลี่ยนแปลงธีมในคอมโพเนนต์และเลย์เอาต์ต่าง ๆ
* [Tailark](https://tailark.com/) - คลัง UI block สมัยใหม่ ตอบสนองดี เหมาะสำหรับเว็บไซต์การตลาด
* [tabler-icons.io](https://tabler-icons.io/) — ไอคอน SVG แบบแก้ไขได้มากกว่า 1,500 แบบ ฟรี
* [tweakcn](https://tweakcn.com/) — ธีมสวย ๆ สำหรับ shadcn/ui ปรับแต่งสี ฟอนต์ ฯลฯ แบบเรียลไทม์
* [UI Avatars](https://ui-avatars.com/) - สร้าง avatar จากอักษรย่อชื่อ URL สามารถนำไปใช้ในเว็บ/แอปได้โดยตรง รองรับพารามิเตอร์กำหนดค่าใน URL
* [unDraw](https://undraw.co/) - คลัง SVG สวย ๆ ที่อัปเดตตลอด ใช้ได้ฟรีโดยไม่ต้องให้เครดิต
* [unsplash.com](https://unsplash.com/) - รูปภาพ stock ฟรีสำหรับเชิงพาณิชย์และไม่ใช่เชิงพาณิชย์ (ใบอนุญาต do-whatever-you-want)
* [vectr.com](https://vectr.com/) — โปรแกรมออกแบบฟรีสำหรับ Web และ Desktop
* [walkme.com](https://www.walkme.com/) — แพลตฟอร์มแนะนำและมีส่วนร่วมระดับองค์กร แผนฟรีรองรับ 3 walkthrough ไม่เกิน 5 ขั้นต่อ walkthrough
* [Webflow](https://webflow.com) - เครื่องมือสร้างเว็บไซต์ WYSIWYG พร้อมระบบอนิเมชันและโฮสต์เว็บไซต์ ฟรีสำหรับ 2 โปรเจกต์
* [Updrafts.app](https://updrafts.app) - เครื่องมือสร้างเว็บไซต์ WYSIWYG สำหรับดีไซน์ที่ใช้ tailwindcss ฟรีสำหรับการใช้งานที่ไม่ใช่เชิงพาณิชย์
* [whimsical.com](https://whimsical.com/) - เครื่องมือทำ flowchart, wireframe, sticky note, mind map แบบร่วมมือกัน สร้างได้ฟรี 4 board
* [Zeplin](https://zeplin.io/) — แพลตฟอร์มสำหรับนักออกแบบและนักพัฒนาทำงานร่วมกัน แสดงดีไซน์, asset, style guide ฟรีสำหรับ 1 โปรเจกต์
* [Pixelixe](https://pixelixe.com/) — สร้างและแก้ไขกราฟิก/ภาพออนไลน์ที่น่าสนใจและไม่เหมือนใคร
* [Responsively App](https://responsively.app) - เครื่องมือ dev ฟรีสำหรับพัฒนาเว็บแอปฯ responsive ได้เร็วและแม่นยำกว่า
* [SceneLab](https://scenelab.io) - โปรแกรมแก้ไข mockup กราฟิกออนไลน์ พร้อมเทมเพลตดีไซน์ฟรีมากมาย
* [xLayers](https://xlayers.dev) - พรีวิวและแปลงไฟล์ดีไซน์ Sketch เป็น Angular, React, Vue, LitElement, Stencil, Xamarin ฯลฯ (ฟรีและโอเพ่นซอร์สที่ https://github.com/xlayers/xlayers)
* [Grapedrop](https://grapedrop.com/) — เครื่องมือสร้างเว็บเพจที่ responsive, ทรงพลัง, และ SEO-friendly บน GrapesJS Framework ฟรี 5 หน้าแรก, กำหนดโดเมนเองไม่จำกัด, ฟีเจอร์ครบ ใช้งานง่าย
* [Mastershot](https://mastershot.app) - โปรแกรมตัดต่อวิดีโอในเบราว์เซอร์ ฟรี ไม่มีลายน้ำ ส่งออกสูงสุด 1080p
* [Unicorn Platform](https://unicornplatform.com/) - เครื่องมือสร้าง landing page พร้อมโฮสติ้ง ใช้ฟรี 1 เว็บไซต์
* [SVGmix.com](https://www.svgmix.com/) - คลังไอคอน SVG, คอลเลกชัน และโลโก้แบรนด์กว่า 300,000 รายการ มีโปรแกรมแก้ไขเวกเตอร์ในเบราว์เซอร์ให้ใช้งานรวดเร็ว
* [svgrepo.com](https://www.svgrepo.com/) - ค้นหาและเลือกไอคอนหรือเวกเตอร์ที่เหมาะสมที่สุดสำหรับโปรเจกต์ของคุณจากไลบรารีเวกเตอร์หลากหลาย ดาวน์โหลด SVG สำหรับใช้เชิงพาณิชย์ได้ฟรี
* [haikei.app](https://www.haikei.app/) - แอปบนเว็บสำหรับสร้างรูปร่าง SVG, พื้นหลัง และแพทเทิร์นที่ไม่ซ้ำใคร พร้อมใช้งานกับเครื่องมือออกแบบและเวิร์กโฟลว์ของคุณ
* [Canva](https://canva.com) - เครื่องมือออกแบบออนไลน์ฟรีสำหรับสร้างเนื้อหาภาพ
* [Superdesigner](https://superdesigner.co) - เครื่องมือออกแบบฟรีสำหรับสร้างพื้นหลัง, แพทเทิร์น, รูปร่าง, ภาพ ฯลฯ เพียงไม่กี่คลิก
* [TeleportHQ](https://teleporthq.io/) - แพลตฟอร์ม Low-code สำหรับออกแบบและพัฒนา front-end ร่วมมือกัน สร้างและเผยแพร่เว็บไซต์ static ได้ทันที ฟรี 3 โปรเจกต์ ผู้ร่วมงานไม่จำกัด ส่งออกโค้ดได้ฟรี
* [vector.express](https://vector.express) — แปลงไฟล์ AI, CDR, DWG, DXF, EPS, HPGL, PDF, PLT, PS และ SVG ได้อย่างรวดเร็วและง่ายดาย
* [Vertopal](https://www.vertopal.com) - แพลตฟอร์มออนไลน์ฟรีสำหรับแปลงไฟล์เป็นฟอร์แมตต่าง ๆ รวมถึงตัวแปลงสำหรับนักพัฒนา เช่น JPG เป็น SVG, GIF เป็น APNG, PNG เป็น WEBP, JSON เป็น XML ฯลฯ
* [okso.app](https://okso.app) - แอปวาดออนไลน์แบบมินิมอล สร้างสเก็ตช์และโน้ตภาพได้รวดเร็ว ส่งออกเป็น PNG, JPG, SVG, WEBP ติดตั้งเป็น PWA ได้ ใช้ฟรีโดยไม่ต้องสมัคร
* [Wdrfree SVG](https://wdrfree.com/free-svg) - ไฟล์ SVG ตัดขาวดำฟรี
* [Lucide](https://lucide.dev) - ชุดไอคอน SVG ที่ปรับแต่งได้และสม่ำเสมอ ฟรี
* [Logo.dev](https://www.logo.dev) - API โลโก้บริษัทกว่า 44 ล้านแบรนด์ ใช้ง่ายแค่เรียก URL ฟรี 10,000 call แรก
* [MDBootstrap](https://mdbootstrap.com/) - Bootstrap, Angular, React, Vue UI Kit ฟรีสำหรับการใช้งานส่วนตัวและเชิงพาณิชย์ มีคอมโพเนนต์กว่า 700 แบบ, เทมเพลตสวย, ติดตั้งใน 1 นาที, บทเรียน, และชุมชนขนาดใหญ่
* [TW Elements](https://tw-elements.com/) - Bootstrap component ฟรีที่สร้างใหม่ด้วย Tailwind CSS พร้อมดีไซน์และฟังก์ชันการใช้งานที่ดีกว่า
* [DaisyUI](https://daisyui.com/) -- ฟรี "ใช้ Tailwind CSS แต่เขียน class name น้อยลง" มีคอมโพเนนต์เช่นปุ่มต่าง ๆ
  * [Scrollbar.app](https://scrollbar.app) -- เว็บแอปฟรีที่เรียบง่ายสำหรับออกแบบ Scrollbar แบบกำหนดเองสำหรับเว็บ
  * [css.glass](https://css.glass/) -- เว็บแอปฟรีสำหรับสร้างดีไซน์แบบ glassmorphic ด้วย CSS
  * [hypercolor.dev](https://hypercolor.dev/) -- คอลเลกชัน gradients สี Tailwind CSS ที่คัดสรรมาแล้ว และยังมีเครื่องมือสร้าง gradients ของคุณเองอีกด้วย
  * [iconify.design](https://icon-sets.iconify.design/) -- รวบรวมไอคอนกว่า 100 ชุดไว้ในอินเทอร์เฟซเดียว ค้นหาไอคอนข้ามชุดและส่งออกเป็น SVG หรือใช้กับเว็บเฟรมเวิร์กยอดนิยมได้
  * [NextUI](https://nextui.org/) -- ฟรี. ไลบรารี UI สำหรับ React & Next.js ที่สวยงาม รวดเร็ว และทันสมัย
  * [Glyphs](https://glyphs.fyi/) -- ฟรี, ไอคอนที่ทรงพลังที่สุดบนเว็บ แก้ไขได้เต็มที่ & เป็นระบบออกแบบโอเพ่นซอร์สแท้จริง
  * [ShadcnUI](https://ui.shadcn.com/) -- คอมโพเนนต์ดีไซน์สวยที่สามารถก็อปปี้และนำไปใช้ในแอปของคุณได้ เข้าถึงได้ กำหนดเองได้ โอเพ่นซอร์ส
  * [HyperUI](https://www.hyperui.dev/) -- คอมโพเนนต์ Tailwind CSS โอเพ่นซอร์สฟรี
  * [Calendar Icons Generator](https://calendariconsgenerator.app/) -- สร้างไอคอนเฉพาะตัวสำหรับทั้งปีในคลิกเดียว ฟรี 100%
  * [Image BG Blurer](https://imagebgblurer.com/) -- สร้างกรอบพื้นหลังเบลอให้รูปภาพ โดยใช้ภาพต้นฉบับเป็นพื้นหลังเบลอ รองรับ Notion, Trello, Jira และเครื่องมืออื่นๆ
  * [Webstudio](https://webstudio.is/) -- ทางเลือกโอเพ่นซอร์สแทน Webflow แผนฟรีให้สร้างเว็บไซต์ไม่จำกัดบนโดเมนของเขา 5 เว็บไซต์กับโดเมนส่วนตัว ผู้เข้าชม 10,000 ครั้ง/เดือน เก็บไฟล์ 2GB
  * [Nappy](https://nappy.co/) -- รูปถ่ายคนผิวดำและผิวสีน้ำตาลที่สวยงาม ฟรี ใช้เพื่อการค้าและส่วนตัวได้
  * [Tailkits](https://tailkits.com/) -- คอลเลกชันแม่แบบ Tailwind, คอมโพเนนต์, เครื่องมือ และตัวสร้างโค้ด/กริด/เงา และอื่นๆ ที่มีประโยชน์
  * [Tailcolors](https://tailcolors.com/) -- พาเลตสี Tailwind CSS v4 ที่สวยงาม ดูตัวอย่าง & ก็อปปี้ class สี Tailwind CSS ได้ทันที
  * [Excalidraw](https://excalidraw.com/) -- เว็บเพจวาดภาพออนไลน์ฟรี บันทึกลงเครื่องและส่งออกได้ฟรี
  * [Lunacy](https://icons8.com/lunacy) -- เครื่องมือออกแบบกราฟิกฟรี ใช้งานออฟไลน์ได้ มีแอสเซทในตัว (ไอคอน, รูป, ภาพประกอบ) และทำงานร่วมกันแบบเรียลไทม์ แผนฟรีให้ 10 เอกสารบนคลาวด์ ประวัติย้อนหลัง 30 วัน แอสเซทความละเอียดต่ำ และเครื่องมือออกแบบพื้นฐาน

**[⬆️ Back to Top](#table-of-contents)**

## แรงบันดาลใจด้านการออกแบบ

  * [awwwards.](https://www.awwwards.com/) - [Top websites] โชว์ผลงานเว็บไซต์ที่ออกแบบดีที่สุด (นักออกแบบโหวต)
  * [Behance](https://www.behance.net/) - [Design showcase] พื้นที่โชว์ผลงานของนักออกแบบ ค้นหาแยกหมวด UI/UX ได้
  * [dribbble](https://dribbble.com/) - [Design showcase] แรงบันดาลใจด้านดีไซน์ที่ไม่ซ้ำใคร มักจะไม่ใช่แอปจริง
  * [Landings](https://landings.dev/) - [Web screenshots] ค้นหา landing page ที่ดีที่สุดสำหรับแรงบันดาลใจตามความชอบของคุณ
  * [Lapa Ninja](https://www.lapa.ninja/) - [Landing page / UI KIts / Web screenshots] แกลเลอรีรวมตัวอย่าง landing page ยอดเยี่ยม 6025 แบบ หนังสือฟรีและ UI kit ฟรีสำหรับนักออกแบบ
  * [LovelyLanding.net](https://www.lovelylanding.net/) - [Landing Page Designs] อัปเดต screenshot landing page บ่อย มีทั้ง Desktop, Tablet, และ Mobile
  * [Mobbin](https://mobbin.design/) - [Mobile screenshots] ประหยัดเวลาวิจัย UI & UX ด้วยคลังภาพหน้าจอแอปมือถือกว่า 50,000 ภาพ ค้นหาได้เต็มที่
  * [Uiland Design](https://uiland.design/) - [Mobile screenshots] สำรวจดีไซน์ Mobile และ Web UI จากบริษัทชั้นนำในแอฟริกาและทั่วโลก
  * [Mobile Patterns](https://www.mobile-patterns.com/) - [Mobile screenshots] คลังแรงบันดาลใจ UI UX Patterns (iOS และ Android) สำหรับนักออกแบบ นักพัฒนา และผู้สร้างผลิตภัณฑ์
  * [Page Flows](https://pageflows.com/) - [Mobile / web videos and screenshots] วิดีโอแสดง flow เต็มรูปแบบของแอปมือถือและเว็บมากมาย มีภาพหน้าจอด้วย ค้นหาและจัดหมวดหมู่ได้ดีเยี่ยม
  * [Screenlane](https://screenlane.com/) - [Mobile screenshots] แรงบันดาลใจและติดตามเทรนด์การออกแบบ UI เว็บและแอปมือถือใหม่ๆ ค้นหาตาม pattern และแอปได้
  * [scrnshts](https://scrnshts.club/) - [Mobile screenshots] คอลเลกชัน screenshot การออกแบบแอปใน app store ที่คัดสรรมาแล้ว
  * [Refero](https://refero.design/) - [Web screenshots] คลังอ้างอิงดีไซน์จากเว็บแอปชั้นเยี่ยม พร้อมแท็กและค้นหาได้

**[⬆️ Back to Top](#table-of-contents)**

## การแสดงข้อมูลบนแผนที่

  * [IP Geolocation](https://ipgeolocation.io/) — มีแผน DEVELOPER ฟรี 30,000 คำขอ/เดือน
  * [carto.com](https://carto.com/) — สร้างแผนที่และ Geospatial API จากข้อมูลของคุณและข้อมูลสาธารณะ
  * [Clockwork Micro](https://clockworkmicro.com/) — เครื่องมือแผนที่ที่ทำงานได้อย่างแม่นยำ ฟรี 50,000 คำขอรายเดือน (map tiles, db2vector, elevation)
  * [developers.arcgis.com](https://developers.arcgis.com) — API และ SDK สำหรับแผนที่ การจัดเก็บ วิเคราะห์ ค้นหาที่อยู่ นำทาง ฯลฯ บนเว็บ เดสก์ท็อป มือถือ ฟรี 2 ล้าน map tiles, 20,000 non-stored geocodes, 20,000 simple routes, 5,000 drive time calculations และพื้นที่จัดเก็บ tile+data 5GB/เดือน
  * [Foursquare](https://developer.foursquare.com/) - ค้นหาสถานที่ ค้นหาสถานที่และเนื้อหาตามบริบทจาก Places API และ Pilgrim SDK
  * [geoapify.com](https://www.geoapify.com/) - vector/raster map tiles, geocoding, places, routing, isolines API ฟรี 3,000 คำขอ/วัน
  * [geocod.io](https://www.geocod.io/) — Geocoding ผ่าน API หรืออัปโหลด CSV ฟรี 2,500 คำขอ/วัน
  * [geocodify.com](https://geocodify.com/) — Geocoding และ Geoparsing ผ่าน API หรืออัปโหลด CSV ฟรี 10,000 คำขอ/เดือน
  * [geojs.io](https://www.geojs.io/) - API ค้นหาตำแหน่ง IP แบบ REST/JSON/JSONP ที่พร้อมใช้งานสูง
  * [giscloud.com](https://www.giscloud.com/) — แสดงผล วิเคราะห์ และแชร์ข้อมูลเชิงพื้นที่ออนไลน์
  * [graphhopper.com](https://www.graphhopper.com/) มีแพ็กเกจนักพัฒนาฟรีสำหรับ Routing, Route Optimization, Distance Matrix, Geocoding, และ Map Matching
  * [here](https://developer.here.com/) — API และ SDK สำหรับแผนที่และแอปที่ใช้ตำแหน่ง ฟรี 250,000 ธุรกรรม/เดือน
  * [locationiq.com](https://locationiq.com/) — Geocoding, Maps, Routing API ฟรี 5,000 คำขอ/วัน
  * [mapbox.com](https://www.mapbox.com/) — แผนที่ บริการเชิงพื้นที่ และ SDK สำหรับแสดงข้อมูลแผนที่
  * [maptiler.com](https://www.maptiler.com/cloud/) — Vector map, map services และ SDK สำหรับแสดงแผนที่ ฟรี vector tiles อัปเดตทุกสัปดาห์ และ 4 รูปแบบแผนที่
  * [nominatim.org](https://nominatim.org/) — บริการ geocoding ฟรีของ OpenStreetMap ค้นหาที่อยู่และ reverse geocoding ทั่วโลก
  * [nextbillion.ai](https://nextbillion.ai/) - บริการเกี่ยวกับแผนที่: Geocoding, นำทาง (Direction, Routing, Route Optimization, Distance Matrix), Maps SDK (Vector, Static, Mobile SDK) [ใช้ฟรีตามโควต้าที่กำหนด](https://nextbillion.ai/pricing) สำหรับแต่ละบริการ
  * [opencagedata.com](https://opencagedata.com) — Geocoding API รวมข้อมูล OpenStreetMap และแหล่งข้อมูลเปิดอื่นๆ ฟรี 2,500 คำขอ/วัน
  * [osmnames](https://osmnames.org/) — Geocoding, จัดอันดับผลการค้นหาตามความนิยมใน Wikipedia ที่เกี่ยวข้อง
  * [positionstack](https://positionstack.com/) - Geocoding ฟรีสำหรับสถานที่และพิกัดทั่วโลก 25,000 คำขอ/เดือน ใช้ส่วนตัว
  * [stadiamaps.com](https://stadiamaps.com/) — map tiles, routing, navigation และ geospatial API อื่นๆ ฟรี 2,500 map views และ API requests/วัน สำหรับใช้ส่วนตัว/ทดสอบ
  * [maps.stamen.com](http://maps.stamen.com/) - ฟรี map tiles และโฮสต์ tile
  * [ipstack](https://ipstack.com/) - ค้นหาและระบุตำแหน่งผู้เข้าชมเว็บไซต์จาก IP Address
  * [Geokeo api](https://geokeo.com) - Geocoding API มีการแก้ไขภาษาและอื่นๆ ครอบคลุมทั่วโลก ฟรี 2,500 คำขอ/วัน

**[⬆️ Back to Top](#table-of-contents)**

## ระบบสร้างแพ็กเกจ

  * [build.opensuse.org](https://build.opensuse.org/) — บริการสร้างแพ็กเกจสำหรับดิสโทรหลายตัว (SUSE, EL, Fedora, Debian ฯลฯ)
  * [copr.fedorainfracloud.org](https://copr.fedorainfracloud.org) — บริการสร้าง RPM ด้วย Mock สำหรับ Fedora และ EL
  * [help.launchpad.net](https://help.launchpad.net/Packaging) — บริการสร้างแพ็กเกจ Ubuntu และ Debian

**[⬆️ Back to Top](#table-of-contents)**

## IDE และตัวแก้ไขโค้ด

  * [3v4l](https://3v4l.org/) - PHP shell ออนไลน์ฟรีและแชร์โค้ดสั้นๆ รันโค้ดของคุณใน PHP กว่า 300 เวอร์ชัน
  * [Android Studio](https://developer.android.com/studio) — Android Studio มีเครื่องมือที่เร็วที่สุดสำหรับสร้างแอปบนอุปกรณ์ Android ทุกประเภท เป็นโอเพ่นซอร์ส IDE ฟรีสำหรับทุกคน และดีที่สุดในการพัฒนาแอป Android รองรับ Windows, Mac, Linux และ ChromeOS!
  * [AndroidIDE](https://m.androidide.com/) — IDE โอเพ่นซอร์สสำหรับพัฒนาแอป Android จริงๆ (Gradle-based) บนอุปกรณ์ Android
  * [Apache Netbeans](https://netbeans.apache.org/) — สภาพแวดล้อมพัฒนา เครื่องมือ และเฟรมเวิร์กแอปพลิเคชัน
  * [apiary.io](https://apiary.io/) — ออกแบบ API ร่วมกัน มี instant API mock และสร้างเอกสารอัตโนมัติ (ใช้ฟรีสำหรับ API blueprint และผู้ใช้ไม่จำกัด 1 admin และเอกสารที่โฮสต์)
  * [BBEdit](https://www.barebones.com/) - BBEdit เป็น editor ยอดนิยมสำหรับ macOS โหมดฟรีให้ [ฟีเจอร์หลักที่ทรงพลัง](https://www.barebones.com/products/bbedit/comparison.html) และอัปเกรดเป็นฟีเจอร์ขั้นสูงได้
  * [Binder](https://mybinder.org/) - เปลี่ยน Git repo เป็นโน้ตบุ๊กแบบ interactive รวมเป็นคอลเลกชัน ใช้งานฟรี
  * [BlueJ](https://bluej.org) — สภาพแวดล้อมพัฒนา Java ฟรีสำหรับมือใหม่ ใช้งานโดยผู้คนนับล้านทั่วโลก สนับสนุนโดย Oracle และมี GUI ที่ใช้ง่ายสำหรับผู้เริ่มต้น
  * [Bootify.io](https://bootify.io/) - เครื่องมือสร้างแอป Spring Boot กำหนด database และ REST API ได้เอง
  * [Brackets](http://brackets.io/) - Brackets เป็น text editor โอเพ่นซอร์สที่ออกแบบมาสำหรับการพัฒนาเว็บโดยเฉพาะ น้ำหนักเบา ใช้ง่าย และปรับแต่งได้สูง
  * [cacher.io](https://www.cacher.io) — ตัวจัดการ code snippet พร้อม label และรองรับภาษาโปรแกรมกว่า 100 ภาษา
  * [Code::Blocks](https://codeblocks.org) — IDE สำหรับ Fortran & C/C++ ฟรี โอเพ่นซอร์ส ใช้ได้กับ Windows, macOS & Linux
  * [Cody](https://sourcegraph.com/cody) - ผู้ช่วยเขียนโค้ด AI ฟรีที่สามารถเขียน (block โค้ด, เติมอัตโนมัติ, unit test), เข้าใจ (รู้จัก codebase ทั้งหมด), แก้ไข และค้นหาโค้ดของคุณ มีให้ใช้กับ VS Code, JetBrains และออนไลน์
  * [codiga.io](https://codiga.io/) — Coding Assistant ที่ให้ค้นหา กำหนด และนำ code snippet กลับมาใช้ใน IDE ได้โดยตรง ฟรีสำหรับบุคคลและองค์กรขนาดเล็ก
  * [codesnip.com.br](https://codesnip.com.br) — ตัวจัดการ code snippet แบบง่าย มีหมวด ค้นหา และแท็ก ฟรีและไม่จำกัด
  * [cocalc.com](https://cocalc.com/) — (เดิมคือ SageMathCloud ที่ cloud.sagemath.com) — คำนวณร่วมกันบนคลาวด์ เข้าถึง Ubuntu เต็มรูปแบบผ่านเบราว์เซอร์ มีเครื่องมือฟรีสำหรับคณิต วิทยาศาสตร์ ดาต้าซายน์ ติดตั้ง Python, LaTeX, Jupyter Notebooks, SageMath, scikitlearn ฯลฯ
  * [code.cs50.io](https://code.cs50.io/) - Visual Studio Code สำหรับ CS50 เป็นเว็บแอปที่ code.cs50.io ซึ่งดัดแปลง GitHub Codespaces สำหรับนักเรียนและครู
  * [codepen.io](https://codepen.io/) — CodePen คือ playground สำหรับด้าน frontend ของเว็บ
  * [codesandbox.io](https://codesandbox.io/) — Playground ออนไลน์สำหรับ React, Vue, Angular, Preact และอื่นๆ
  * [Components.studio](https://webcomponents.dev/) - เขียนคอมโพเนนต์แยกทดสอบ ดูในรูปแบบ story, ทดสอบ และ publish ลง npm
  * [Eclipse Che](https://www.eclipse.org/che/) - IDE บนเว็บและ Kubernetes-Native สำหรับทีมพัฒนา รองรับหลายภาษา โอเพ่นซอร์สและขับเคลื่อนโดยชุมชน มี online instance ที่ [workspaces.openshift.com](https://workspaces.openshift.com/)
  * [fakejson.com](https://fakejson.com/) — FakeJSON ช่วยสร้างข้อมูลจำลองอย่างรวดเร็วด้วย API อธิบายสิ่งที่ต้องการและวิธีการ API จะคืนค่าข้อมูลทั้งหมดใน JSON ช่วยให้ไปสู่ตลาดได้เร็วขึ้นและทดสอบไอเดียได้
  * [GetVM](https://getvm.io) — ฟรี Linux และ IDEs แบบ sidebar ใน Chrome แผนฟรีให้ใช้ VM 5 ครั้งต่อวัน
  * [GitPod](https://www.gitpod.io) — สภาพแวดล้อมการพัฒนาแบบพร้อมใช้งานทันทีสำหรับโครงการ GitHub ในระดับฟรีมี 50 ชั่วโมง/เดือน
  * [ide.goorm.io](https://ide.goorm.io) goormIDE คือ IDE เต็มรูปแบบบนคลาวด์ รองรับหลายภาษา, คอนเทนเนอร์พื้นฐาน Linux ผ่านเทอร์มินัลเว็บ, การส่งต่อพอร์ต, URL แบบกำหนดเอง, การทำงานร่วมกันแบบเรียลไทม์และแชท, การแชร์ลิงก์, รองรับ Git/Subversion และฟีเจอร์อื่น ๆ อีกมากมาย (ระดับฟรีให้ RAM 1GB และ Storage 10GB ต่อคอนเทนเนอร์, 5 ช่องคอนเทนเนอร์)
  * [JDoodle](https://www.jdoodle.com) — คอมไพเลอร์และเครื่องมือแก้ไขออนไลน์สำหรับภาษาโปรแกรมกว่า 60 ภาษา พร้อมแผนฟรีสำหรับ REST API ในการคอมไพล์โค้ดสูงสุด 200 เครดิตต่อวัน
  * [jetbrains.com](https://jetbrains.com/products.html) — เครื่องมือเพิ่มประสิทธิภาพ, IDE และเครื่องมือดีพลอย (เช่น [IntelliJ IDEA](https://www.jetbrains.com/idea/), [PyCharm](https://www.jetbrains.com/pycharm/) ฯลฯ) ใบอนุญาตฟรีสำหรับนักเรียน, ครู, โอเพนซอร์ส และกลุ่มผู้ใช้
  * [jsbin.com](https://jsbin.com) — JS Bin เป็นสนามทดลองและเว็บไซต์แชร์โค้ดสำหรับเว็บฟรอนต์เอนด์ (HTML, CSS, และ JavaScript) รองรับ Markdown, Jade และ Sass
  * [jsfiddle.net](https://jsfiddle.net/) — JS Fiddle เป็นสนามทดลองและเว็บไซต์แชร์โค้ดสำหรับเว็บฟรอนต์เอนด์ รองรับการทำงานร่วมกัน
  * [JSONPlaceholder](https://jsonplaceholder.typicode.com/) — จุดเชื่อมต่อ REST API ที่คืนข้อมูลตัวอย่างในรูปแบบ JSON มีซอร์สโค้ดให้หากต้องการรันเซิร์ฟเวอร์เอง
  * [Lazarus](https://www.lazarus-ide.org/) — Lazarus เป็น IDE ข้ามแพลตฟอร์มที่รองรับ Delphi สำหรับการพัฒนาแอปพลิเคชันอย่างรวดเร็ว
  * [MarsCode](https://www.marscode.com/) - IDE บนคลาวด์ที่ขับเคลื่อนด้วย AI ฟรี
  * [micro-jaymock](https://micro-jaymock.now.sh/) - บริการไมโครเซอร์วิสสำหรับจำลอง API เพื่อสร้างข้อมูล JSON ปลอม
  * [mockable.io](https://www.mockable.io/) — Mockable เป็นบริการสำหรับจำลอง RESTful API หรือ SOAP web services แบบกำหนดค่าได้ กำหนด endpoint ได้อย่างรวดเร็วและรองรับ JSON หรือ XML
  * [mockaroo](https://mockaroo.com/) — Mockaroo ให้คุณสร้างข้อมูลทดสอบสมจริงในรูปแบบ CSV, JSON, SQL และ Excel และสร้าง mock สำหรับ API ฝั่ง backend
  * [Mocklets](https://mocklets.com) - เครื่องมือจำลอง Mock API แบบ HTTP สำหรับการพัฒนาขนานและการทดสอบที่ครอบคลุมมากขึ้น พร้อมระดับฟรีตลอดชีพ
  * [Paiza](https://paiza.cloud/en/) — พัฒนาแอปเว็บในเบราว์เซอร์โดยไม่ต้องติดตั้งอะไร แผนฟรีให้เซิร์ฟเวอร์ 1 เครื่อง อายุ 24 ชั่วโมง, ใช้งานได้ 4 ชั่วโมง/วัน 2 CPU, RAM 2 GB, Storage 1 GB
  * [Prepros](https://prepros.io/) - Prepros สามารถคอมไพล์ Sass, Less, Stylus, Pug/Jade, Haml, Slim, CoffeeScript และ TypeScript ได้ทันที รีโหลดเบราว์เซอร์และช่วยให้พัฒนาและทดสอบเว็บไซต์ได้ง่ายขึ้น เพิ่มเครื่องมือเองได้ในไม่กี่คลิก
  * [Replit](https://replit.com/) — สภาพแวดล้อมการเขียนโค้ดบนคลาวด์สำหรับภาษาโปรแกรมหลากหลาย
  * [SoloLearn](https://code.sololearn.com) — สนามทดลองการเขียนโปรแกรมบนคลาวด์ เหมาะสำหรับรันโค้ดสั้น ๆ รองรับหลายภาษา ไม่ต้องลงทะเบียนสำหรับการรันโค้ด แต่ต้องลงทะเบียนหากต้องการบันทึกโค้ดบนแพลตฟอร์ม มีคอร์สฟรีสำหรับมือใหม่และระดับกลาง
  * [stackblitz.com](https://stackblitz.com/) — IDE ออนไลน์/คลาวด์สำหรับสร้าง แก้ไข และดีพลอยแอป full-stack รองรับเฟรมเวิร์ค NodeJs ยอดนิยมทั้งฝั่ง frontend และ backend สร้างโปรเจกต์ใหม่ได้ที่ [https://node.new](https://node.new)
  * [Sublime Text](https://www.sublimetext.com/) - Sublime Text เป็นโปรแกรมแก้ไขข้อความยอดนิยม ปรับแต่งได้สูง เหมาะกับงานเขียนโค้ดและแก้ไขข้อความ
  * [Visual Studio Code](https://code.visualstudio.com/) - โปรแกรมแก้ไขโค้ดที่ถูกนิยามใหม่และปรับให้เหมาะกับการสร้างและดีบักแอปเว็บสมัยใหม่ พัฒนาโดย Microsoft
  * [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) — IDE เต็มรูปแบบพร้อมปลั๊กอินนับพัน พัฒนาแอปข้ามแพลตฟอร์ม (มีปลั๊กอิน Microsoft สำหรับ iOS และ Android ให้ดาวน์โหลด) รองรับเดสก์ท็อป, เว็บ, คลาวด์ และหลายภาษา (C#, C++, JavaScript, Python, PHP ฯลฯ)
  * [VSCodium](https://vscodium.com/) - แจกจ่ายไบนารีของ VSCode ที่ขับเคลื่อนโดยชุมชน ไม่มีระบบติดตาม/เทเลเมทรี และอนุญาตให้นำไปใช้ได้อย่างอิสระ
  * [wakatime.com](https://wakatime.com/) — วิเคราะห์เวลาการเขียนโค้ดผ่านปลั๊กอิน text editor มีแผนฟรีแบบจำกัด
  * [Wave Terminal](https://waveterm.dev/) - Wave เป็นเทอร์มินัลโอเพ่นซอร์ส ข้ามแพลตฟอร์มสำหรับเวิร์กโฟลว์ที่ต่อเนื่อง แสดงผลได้ทุกอย่างแบบอินไลน์ บันทึกเซสชันและประวัติ ใช้ได้กับ MacOS และ Linux
  * [WebComponents.dev](https://webcomponents.dev/) — IDE ในเบราว์เซอร์สำหรับเขียนเว็บคอมโพเนนต์แบบแยกเดี่ยว มีเทมเพลต 58 แบบ รองรับ story และ test
  * [PHPSandbox](https://phpsandbox.io/) — สภาพแวดล้อมพัฒนาออนไลน์สำหรับ PHP
  * [WebDB](https://webdb.app) - IDE ฐานข้อมูลที่มีประสิทธิภาพ ฟรี มี Server Discovery, ERD, Data Generator, AI, NoSQL Structure Manager, Database Versioning และอื่น ๆ อีกมากมาย
  * [Zed](https://zed.dev/) - Zed เป็นโปรแกรมแก้ไขโค้ดประสิทธิภาพสูง รองรับการเขียนโค้ดร่วมกันแบบหลายคน สร้างโดยทีมผู้สร้าง Atom และ Tree-sitter
  * [OneCompiler](https://onecompiler.com/) - คอมไพเลอร์ออนไลน์ฟรี รองรับมากกว่า 70 ภาษา เช่น Java, Python, C++, JavaScript


**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## การวิเคราะห์ข้อมูล กิจกรรม และสถิติ

  * [Dwh.dev](https://dwh.dev) - โซลูชัน Data Cloud Observability (Snowflake) ฟรีสำหรับใช้ส่วนตัว
  * [Hightouch](https://hightouch.com/) - แพลตฟอร์ม Reverse ETL สำหรับซิงค์ข้อมูลลูกค้าจาก data warehouse ไปยัง CRM, การตลาด และเครื่องมือสนับสนุนต่าง ๆ ระดับฟรีให้ซิงค์ข้อมูลได้ 1 จุดหมายปลายทาง
  * [Avo](https://avo.app/) — เวิร์กโฟลว์วิเคราะห์ข้อมูลแบบง่าย แผนการติดตามเดียว, ไลบรารีติดตามข้อมูลแบบ type-safe, เครื่องมือตรวจสอบในแอป, และการสังเกตข้อมูลเพื่อจับปัญหาก่อนปล่อยใช้งาน ฟรีสำหรับ 2 สมาชิก workspace และดูย้อนหลังข้อมูล 1 ชั่วโมง
  * [Branch](https://www.branch.io) — แพลตฟอร์มวิเคราะห์ข้อมูลมือถือ ระดับฟรีให้ผู้ใช้แอปสูงสุด 10,000 คน พร้อม deep-linking และบริการอื่น ๆ
  * [Census](https://www.getcensus.com/) — แพลตฟอร์ม Reverse ETL & Operational Analytics ซิงค์ 10 ฟิลด์จาก data warehouse ไปยัง SaaS กว่า 60 รายการ เช่น Salesforce, Zendesk หรือ Amplitude
  * [Clicky](https://clicky.com) — แพลตฟอร์มวิเคราะห์เว็บไซต์ แผนฟรีสำหรับ 1 เว็บไซต์และดูสถิติได้ 3,000 ครั้ง
  * [Databox](https://databox.com) — Business Insights & Analytics โดยรวมข้อมูลจากแพลตฟอร์มอื่น ๆ แผนฟรีให้ผู้ใช้ 3 คน, dashboard และแหล่งข้อมูล 3 แห่ง ประวัติข้อมูล 11 ล้านเรคคอร์ด
  * [Hitsteps.com](https://hitsteps.com/) — 2,000 pageviews/เดือน สำหรับ 1 เว็บไซต์
  * [amplitude.com](https://amplitude.com/) — 1 ล้าน events/เดือน สูงสุด 2 แอป
  * [GoatCounter](https://www.goatcounter.com/) — แพลตฟอร์มวิเคราะห์เว็บโอเพ่นซอร์ส มีบริการโฮสต์ (ฟรีสำหรับไม่ใช่เชิงพาณิชย์) หรือดาวน์โหลดไปโฮสต์เอง เน้นใช้งานง่ายและเป็นมิตรกับความเป็นส่วนตัว ระดับฟรีสำหรับไม่ใช่เชิงพาณิชย์ รวมเว็บไซต์ไม่จำกัด เก็บข้อมูล 6 เดือน และ 100,000 pageviews/เดือน
  * [Google Analytics](https://analytics.google.com/) — Google Analytics
  * [MetricsWave](https://metricswave.com) — ทางเลือก Google Analytics ที่เน้นความเป็นส่วนตัวสำหรับนักพัฒนา แผนฟรีให้ดู 20,000 pageviews/เดือน โดยไม่ต้องใช้บัตรเครดิต
  * [Expensify](https://www.expensify.com/) — รายงานค่าใช้จ่าย มีเวิร์กโฟลว์อนุมัติรายงานฟรีสำหรับบุคคล
  * [getinsights.io](https://getinsights.io) - Analytics เน้นความเป็นส่วนตัว ไม่ใช้ cookie ฟรีสำหรับ 3,000 events/เดือน
  * [heap.io](https://heap.io) — เก็บทุก action ของผู้ใช้ในแอป iOS หรือเว็บอัตโนมัติ ฟรีสูงสุด 10,000 sessions/เดือน
  * [Hotjar](https://hotjar.com) — วิเคราะห์และรายงานเว็บไซต์ แผนฟรีให้ 2,000 pageviews/วัน, 100 snapshots/วัน (สูงสุด 300), heatmap 3 รายการเก็บได้ 365 วัน สมาชิกทีมไม่จำกัด มี survey และ feedback widget ฟรี 3 ชิ้นและเก็บคำตอบ 20 รายการ/เดือน
  * [Keen](https://keen.io/) — Custom Analytics สำหรับเก็บ วิเคราะห์ และแสดงผลข้อมูล 1,000 events/เดือน ฟรี
  * [Yandex.Datalens](https://datalens.yandex.com/) — บริการวิเคราะห์และแสดงผลข้อมูลบน Yandex Cloud ฟรี ไม่มีจำกัดจำนวนผู้ใช้หรือการร้องขอ
  * [Yandex.Metrica](https://metrica.yandex.com/) — วิเคราะห์เว็บฟรีไม่จำกัด
  * [Mixpanel](https://mixpanel.com/) — 100,000 ผู้ใช้ที่ติดตามต่อเดือน ประวัติข้อมูลและที่นั่งผู้ใช้ไม่จำกัด เลือกที่ตั้งข้อมูล US/EU ได้
  * [Moesif](https://www.moesif.com) — วิเคราะห์ API สำหรับ REST และ GraphQL (ฟรีสูงสุด 500,000 API calls/เดือน)
  * [optimizely.com](https://www.optimizely.com) — โซลูชัน A/B Testing แผนฟรีสำหรับ 1 เว็บไซต์, 1 iOS และ 1 Android app
  * [Microsoft PowerBI](https://powerbi.com) — Business Insights & Analytics โดย Microsoft แผนฟรีให้ใช้งานจำกัด 1 ล้านใบอนุญาตผู้ใช้
  * [Row Zero](https://rowzero.io) - สเปรดชีตที่เชื่อมต่อข้อมูลได้อย่างรวดเร็ว เชื่อมต่อฐานข้อมูล, S3, API ได้โดยตรง นำเข้า วิเคราะห์ กราฟ และแชร์ข้อมูลนับล้านแถวได้ทันที ฟรี 3 workbook ตลอดไป
  * [sematext.com](https://sematext.com/cloud/) — ฟรีสูงสุด 50,000 actions/เดือน เก็บข้อมูล 1 วัน dashboard และผู้ใช้ไม่จำกัด
  * [Similar Web](https://similarweb.com) — วิเคราะห์เว็บและแอปมือถือ แผนฟรีให้ดูผลลัพธ์ 5 รายการต่อ metric, ข้อมูลแอปมือถือ 1 เดือน และข้อมูลเว็บไซต์ 3 เดือน
  * [StatCounter](https://statcounter.com/) — วิเคราะห์ผู้ชมเว็บไซต์ แผนฟรีสำหรับผู้ชม 500 คนล่าสุด
  * [Statsig](https://statsig.com) - แพลตฟอร์ม all-in-one สำหรับ analytics, feature flagging และ A/B testing ฟรีสูงสุด 1 ล้าน events/เดือน
  * [Tableau Developer Program](https://www.tableau.com/developer) — นวัตกรรมและสร้างสรรค์สำหรับนักพัฒนา Tableau แผนฟรีให้ license สำหรับ sandbox ส่วนตัวบน Tableau Online เป็นเวอร์ชัน pre-release ล่าสุดเพื่อทดสอบฟีเจอร์ใหม่ ๆ
  * [usabilityhub.com](https://usabilityhub.com/) — ทดสอบดีไซน์และ mockup กับผู้ใช้จริงและติดตามผู้เยี่ยมชม ฟรีสำหรับ 1 ผู้ใช้ ทดสอบได้ไม่จำกัด
  * [woopra.com](https://www.woopra.com/) — แพลตฟอร์มวิเคราะห์ผู้ใช้ฟรีสำหรับ 500,000 actions เก็บข้อมูล 90 วัน และอินทิเกรต 30+ ระบบในคลิกเดียว
  * [counter.dev](https://counter.dev) — วิเคราะห์เว็บอย่างง่าย เป็นมิตรกับความเป็นส่วนตัว ฟรีหรือจ่ายตามใจด้วยการบริจาค
  * [PostHog](https://posthog.com) - ชุด Product Analytics เต็มรูปแบบ ฟรีสูงสุด 1 ล้าน events/เดือน มี in-App Surveys ไม่จำกัด 250 คำตอบ/เดือน
  * [Uptrace](https://uptrace.dev) - เครื่องมือ Distributed Tracing เพื่อหาจุดบกพร่องและปัญหาประสิทธิภาพ มีแผนฟรี ให้ subscription ส่วนตัวสำหรับโปรเจกต์โอเพ่นซอร์ส และมีเวอร์ชันโอเพ่นซอร์ส
  * [Microsoft Clarity](https://clarity.microsoft.com/) - Clarity เป็นเครื่องมือฟรีใช้งานง่ายที่บันทึกการใช้งานจริงของผู้ใช้บนเว็บไซต์คุณ
  * [Beampipe.io](https://beampipe.io) - Beampipe คือ analytics เว็บที่เน้นความเป็นส่วนตัว ฟรีสำหรับ 5 โดเมน และ 10,000 pageviews/เดือน
  * [Aptabase](https://aptabase.com) — Open Source, Analytics ที่เน้นความเป็นส่วนตัวและเรียบง่ายสำหรับแอปมือถือและเดสก์ท็อป มี SDK สำหรับ Swift, Kotlin, React Native, Flutter, Electron และอีกมากมาย ฟรีสูงสุด 20,000 events/เดือน
  * [Trackingplan](https://www.trackingplan.com/) - ตรวจจับปัญหา analytics, ข้อมูลการตลาดและพิกเซลโดยอัตโนมัติ รักษาแผนการติดตามให้ทันสมัยและส่งเสริมการทำงานร่วมกัน ติดตั้งใน production หรือเพิ่ม coverage analytics ใน regression test โดยไม่ต้องเขียนโค้ด
  * [LogSpot](https://logspot.io) - แพลตฟอร์ม analytics เว็บและผลิตภัณฑ์แบบ unified รวม widget ฝัง analytics และโรบ็อตอัตโนมัติ (slack, telegram, webhooks) แผนฟรีให้ 10,000 events/เดือน
  * [Umami](https://umami.is/) - ทางเลือก Google Analytics แบบ open-source ที่เรียบง่าย รวดเร็ว และเน้นความเป็นส่วนตัว
  * [TrackWith Dicloud](https://dicloud.net/trackwith-privacy-focused-analytics/) - ทางเลือก Google Analytics ที่เบาและเน้นความเป็นส่วนตัว ฟรีสำหรับ 3 โดเมน 600 session replay ต่อโดเมน ไม่มีจำกัด pageviews/visitor/heatmap/goal
  * [AppFit](https://appfit.io) - AppFit เป็นเครื่องมือวิเคราะห์และบริหารจัดการผลิตภัณฑ์ที่ครอบคลุม ช่วยให้บริหาร analytics และอัปเดตผลิตภัณฑ์ข้ามแพลตฟอร์มได้อย่างต่อเนื่อง แผนฟรีให้ 10,000 events/เดือน, product journal และ weekly insights
  * [Seline](https://seline.so) - Seline คือ analytics เว็บไซต์และผลิตภัณฑ์ที่เรียบง่ายและเป็นส่วนตัว ไม่มีคุกกี้ เบา อิสระ แผนฟรีให้ 3,000 events/เดือน และเข้าถึงฟีเจอร์ทั้งหมด เช่น dashboard, user journeys, funnels ฯลฯ
  * [Peasy](https://peasy.so) - Peasy คือ analytics ที่เบาและเน้นความเป็นส่วนตัวสำหรับเว็บไซต์และผลิตภัณฑ์ แผนฟรีให้ 3,000 events/เดือน
  * [Rybbit](https://rybbit.io) - ทางเลือก Google Analytics แบบ open-source ไม่มีคุกกี้ ใช้งานง่ายกว่า 10 เท่า แผนฟรีให้ 3,000 events/เดือน

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## การบันทึกเซสชันผู้เยี่ยมชม

  * [Reactflow.com](https://www.reactflow.com/) — ต่อเว็บไซต์: 1,000 pageviews/วัน, heatmap 3 อัน, widget 3 อัน, ติดตามบั๊กฟรี
  * [OpenReplay.com](https://www.openreplay.com) - ระบบบันทึกเซสชันโอเพ่นซอร์สพร้อม dev tools สำหรับจำลองบั๊ก เซสชันสดสำหรับซัพพอร์ตแบบเรียลไทม์ และชุดเครื่องมือ analytics ฟรี 1,000 เซสชัน/เดือน พร้อมฟีเจอร์ครบถ้วนและเก็บข้อมูล 7 วัน
  * [LogRocket.com](https://www.logrocket.com) - 1,000 เซสชัน/เดือน เก็บข้อมูล 30 วัน, ติดตามข้อผิดพลาด, โหมดไลฟ์
  * [FullStory.com](https://www.fullstory.com) — 1,000 เซสชัน/เดือน เก็บข้อมูล 1 เดือน และที่นั่งผู้ใช้ 3 คน ข้อมูลเพิ่มเติม [ที่นี่](https://help.fullstory.com/hc/en-us/articles/360020623354-FullStory-Free-Edition)
  * [hotjar.com](https://www.hotjar.com/) — ต่อเว็บไซต์: 1,050 pageviews/เดือน, heatmap ไม่จำกัด, เก็บข้อมูล 3 เดือน
  * [inspectlet.com](https://www.inspectlet.com/) — 2,500 เซสชัน/เดือน ฟรีสำหรับ 1 เว็บไซต์
  * [Microsoft Clarity](https://clarity.microsoft.com/) - บันทึกเซสชันฟรี 100% ไม่มีจำกัดทราฟฟิก, ไม่มีจำกัดโปรเจกต์ และไม่มีการ sampling
  * [mouseflow.com](https://mouseflow.com/) — 500 เซสชัน/เดือน ฟรีสำหรับ 1 เว็บไซต์
  * [mousestats.com](https://www.mousestats.com/) — 100 เซสชัน/เดือน ฟรีสำหรับ 1 เว็บไซต์
  * [smartlook.com](https://www.smartlook.com/) — แพ็คเกจฟรีสำหรับเว็บและแอปมือถือ (1,500 เซสชัน/เดือน) heatmap 3 อัน, funnel 1 อัน, ประวัติข้อมูล 1 เดือน
  * [howuku.com](https://howuku.com) — ติดตาม interaction, engagement และ event ฟรีสูงสุด 5,000 visits/เดือน
  * [UXtweak.com](https://www.uxtweak.com/) — บันทึกและดูว่าผู้ใช้ใช้งานเว็บไซต์หรือแอปคุณอย่างไร ฟรีไม่จำกัดเวลาสำหรับโปรเจกต์ขนาดเล็ก

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**
## API และ SDK สำหรับการตรวจสอบหมายเลขโทรศัพท์มือถือระหว่างประเทศ

  * [numverify](https://numverify.com/) — API สำหรับตรวจสอบและค้นหาหมายเลขโทรศัพท์ทั่วโลกในรูปแบบ JSON ฟรี 100 ครั้ง/เดือน
  * [veriphone](https://veriphone.io/) — API สำหรับตรวจสอบหมายเลขโทรศัพท์ทั่วโลกที่รวดเร็วและเชื่อถือได้ในรูปแบบ JSON ฟรี 1000 ครั้ง/เดือน

**[⬆️ กลับไปด้านบน](#table-of-contents)**

## การเชื่อมต่อระบบชำระเงินและการวางบิล

  * [Qonversion](http://qonversion.io/) - แพลตฟอร์มการจัดการสมาชิกรายเดือนแบบข้ามแพลตฟอร์มที่รวมทุกอย่างในที่เดียว พร้อมเครื่องมือวิเคราะห์, ทดสอบ A/B, Apple Search Ads, รีโมทคอนฟิก และเครื่องมือเพิ่มการเติบโตสำหรับเพิ่มประสิทธิภาพการซื้อในแอปและการสร้างรายได้ รองรับ iOS, Android, React Native, Flutter, Unity, Cordova, Stripe และเว็บ ฟรีสูงสุด $10,000 รายได้ที่ติดตามต่อเดือน
  * [ParityVend](https://www.ambeteco.com/ParityVend/) – ปรับราคาสินค้าโดยอัตโนมัติตามที่ตั้งของผู้เข้าชมเพื่อขยายธุรกิจทั่วโลกและเข้าถึงตลาดใหม่ ๆ (ตามอำนาจซื้อ) แผนฟรีรองรับ 7,500 API requests/เดือน
  * [Glassfy](https://glassfy.io/) – โครงสร้างพื้นฐานของการสมัครสมาชิกรายเดือนในแอป, เหตุการณ์สมัครสมาชิกแบบเรียลไทม์ และเครื่องมือสร้างรายได้สำเร็จรูปบน iOS, Android, Stripe และ Paddle ฟรีสูงสุด $10,000 รายได้ต่อเดือน
  * [Adapty.io](https://adapty.io/) – โซลูชันครบวงจรพร้อม SDK โอเพ่นซอร์สสำหรับเชื่อมต่อการสมัครสมาชิกรายเดือนในแอปมือถือ iOS, Android, React Native, Flutter, Unity หรือเว็บแอป ฟรีสูงสุด $10,000 รายได้ต่อเดือน
  * [CoinMarketCap](https://coinmarketcap.com/api/) — ให้ข้อมูลตลาดคริปโตเคอเรนซี รวมถึงอัตราแลกเปลี่ยนสกุลเงินดิจิทัลและสกุลเงินทั่วไปล่าสุด ชั้นฟรีรองรับ 10,000 call credits/เดือน
  * [CurrencyFreaks](https://currencyfreaks.com/) — ให้ข้อมูลอัตราแลกเปลี่ยนสกุลเงินปัจจุบันและย้อนหลัง แผน DEVELOPER ฟรี รองรับ 1,000 requests/เดือน
  * [CoinGecko](https://www.coingecko.com/en/api) — ให้ข้อมูลตลาดคริปโต รวมทั้งอัตราแลกเปลี่ยนและข้อมูลย้อนหลัง API เดโมจำกัด 30 calls/นาที และสูงสุด 10,000 calls/เดือน
  * [CurrencyApi](https://currencyapi.net/) — อัตราแลกเปลี่ยนสดสำหรับสกุลเงินทั่วไปและคริปโต ส่งข้อมูลในรูปแบบ JSON และ XML ชั้นฟรีรองรับ 1,250 API requests/เดือน
  * [currencylayer](https://currencylayer.com/) — อัตราแลกเปลี่ยนและแปลงสกุลเงินที่เชื่อถือได้สำหรับธุรกิจของคุณ ฟรี 100 API requests/เดือน
  * [exchangerate-api.com](https://www.exchangerate-api.com) - API แปลงสกุลเงินแบบ JSON ใช้งานง่าย ชั้นฟรีอัปเดต 1 ครั้ง/วัน จำกัด 1,500 requests/เดือน
  * [FraudLabsPRO](https://www.fraudlabspro.com) — ช่วยผู้ค้าในการป้องกันการฉ้อโกงการชำระเงินและการเรียกเก็บเงินคืน มีแผน Micro ฟรี 500 queries/เดือน
  * [FxRatesAPI](https://fxratesapi.com) — ให้อัตราแลกเปลี่ยนแบบเรียลไทม์และย้อนหลัง ชั้นฟรีต้องมีการให้เครดิตแหล่งที่มา
  * [Moesif API Monetization](https://www.moesif.com/) - สร้างรายได้จาก API ผ่านการวางบิลตามการใช้งาน เชื่อมต่อ Stripe, Chargebee ฯลฯ ชั้นฟรีรองรับ 30,000 events/เดือน
  * [Nami ML](https://www.namiml.com/) - แพลตฟอร์มสำหรับซื้อในแอปและการสมัครสมาชิกบน iOS และ Android ครบวงจร รวมทั้ง paywall แบบไม่ต้องเขียนโค้ด, CRM และการวิเคราะห์ ฟรีสำหรับฟีเจอร์พื้นฐานทั้งหมด
  * [RevenueCat](https://www.revenuecat.com/) — โฮสต์ backend สำหรับการซื้อในแอปและการสมัครสมาชิก (iOS และ Android) ฟรีสูงสุด $2,500/เดือน รายได้ที่ติดตาม
  * [vatlayer](https://vatlayer.com/) — ตรวจสอบหมายเลข VAT ทันทีและ API อัตรา VAT ในสหภาพยุโรป ฟรี 100 API requests/เดือน
  * [Currencyapi](https://currencyapi.com) — API ข้อมูลแปลงค่าและอัตราแลกเปลี่ยนสกุลเงินฟรี ฟรี 300 requests/เดือน 10 requests/นาที สำหรับใช้งานส่วนตัว

**[⬆️ กลับไปด้านบน](#table-of-contents)**

## เกี่ยวกับ Docker

  * [canister.io](https://canister.io/) — 20 repositories ส่วนตัวฟรีสำหรับนักพัฒนา, 30 repositories ส่วนตัวฟรีสำหรับทีม เพื่อสร้างและเก็บ Docker images
  * [Container Registry Service](https://container-registry.com/) - โซลูชันการจัดการคอนเทนเนอร์บนพื้นฐาน Harbor ชั้นฟรีให้พื้นที่เก็บข้อมูล 1 GB สำหรับ repository ส่วนตัว
  * [Docker Hub](https://hub.docker.com) — 1 repository ส่วนตัวฟรี และ repositories สาธารณะไม่จำกัด สำหรับสร้างและเก็บ Docker images
  * [Play with Docker](https://labs.play-with-docker.com/) — สนามทดลอง Docker แบบ interactive และสนุก เรียนรู้ Docker ได้ง่าย ๆ
  * [quay.io](https://quay.io/) — สร้างและเก็บ container images พร้อม repositories สาธารณะฟรีไม่จำกัด
  * [ttl.sh](https://ttl.sh/) - Docker image registry แบบไม่ระบุตัวตนและหมดอายุอัตโนมัติ

**[⬆️ กลับไปด้านบน](#table-of-contents)**

## เกี่ยวกับ Vagrant

  * [Vagrant Cloud](https://app.vagrantup.com) - HashiCorp Vagrant Cloud สำหรับโฮสต์ Vagrant box
  * [Vagrantbox.es](https://www.vagrantbox.es/) — ดัชนี public box ทางเลือก

**[⬆️ กลับไปด้านบน](#table-of-contents)**

## เว็บไซต์บล็อกสำหรับนักพัฒนา

  * [BearBlog](https://bearblog.dev/) - เครื่องมือสร้างบล็อกและเว็บไซต์แบบ minimalist รองรับ Markdown
  * [Dev.to](https://dev.to/) - ชุมชนแบ่งปันไอเดียและช่วยเหลือนักพัฒนาให้เติบโต
  * [Hashnode](https://hashnode.com/) — ซอฟต์แวร์บล็อกสำหรับนักพัฒนา ใช้งานง่าย ไม่ยุ่งยาก!
  * [Medium](https://medium.com/) — อ่านสิ่งที่สำคัญกับคุณอย่างลึกซึ้งมากขึ้น
  * [AyeDot](https://ayedot.com/) — แชร์ไอเดีย ความรู้ และเรื่องราวกับคนทั่วโลก ฟรี ในรูปแบบ Miniblogs สั้น ๆ และสื่อมัลติมีเดียทันสมัย

**[⬆️ กลับไปด้านบน](#table-of-contents)**

## แพลตฟอร์มแสดงความคิดเห็น
  * [GraphComment](https://graphcomment.com/) - แพลตฟอร์มคอมเมนต์ที่ช่วยสร้างชุมชนที่มีส่วนร่วมจากผู้ชมเว็บไซต์ของคุณ
  * [Utterances](https://utteranc.es/) - วิดเจ็ตคอมเมนต์น้ำหนักเบาสร้างจาก GitHub issues ใช้ GitHub issues เป็นคอมเมนต์บล็อก, wiki และอื่น ๆ!
  * [Disqus](https://disqus.com/) - แพลตฟอร์มคอมมูนิตี้ที่เชื่อมต่อกัน ใช้งานโดยเว็บไซต์นับแสนทั่วโลก
  * [Remarkbox](https://www.remarkbox.com/) - แพลตฟอร์มคอมเมนต์โอเพ่นซอร์สแบบ hosted จ่ายเท่าที่คุณต้องการ "สำหรับ 1 ผู้ดูแลบนหลายโดเมน พร้อมควบคุมพฤติกรรมและรูปลักษณ์ได้เต็มที่"
  * [IntenseDebate](https://intensedebate.com/) - ระบบคอมเมนต์ฟีเจอร์ครบสำหรับ WordPress, Tumblr, Blogger และแพลตฟอร์มเว็บไซต์อื่น ๆ

**[⬆️ กลับไปด้านบน](#table-of-contents)**

## Screenshot APIs

  * [ApiFlash](https://apiflash.com) — API สำหรับจับภาพหน้าจอบนพื้นฐาน AWS Lambda และ Chrome จัดการทั้งหน้า, การจับเวลา และขนาด viewport
  * [microlink.io](https://microlink.io/) – แปลงเว็บไซต์ใด ๆ ให้เป็นข้อมูล เช่น การ normalize เมตาแท็ก, พรีวิวลิงก์, ความสามารถในการดึงข้อมูล หรือ screenshot เป็นบริการ ฟรี 250 requests/วัน
  * [ScreenshotAPI.net](https://screenshotapi.net/) - API สำหรับจับภาพหน้าจอเว็บไซต์โดยเรียก API อย่างง่าย โฮสต์บน Google Cloud ฟรี 100 ภาพ/เดือน
  * [screenshotlayer.com](https://screenshotlayer.com/) — จับภาพเว็บไซต์แบบปรับแต่งได้สูง ฟรี 100 snapshots/เดือน
  * [screenshotmachine.com](https://www.screenshotmachine.com/) — จับภาพได้ 100 snapshots/เดือน เป็น png, gif และ jpg รวมถึงจับหน้าเว็บแบบเต็ม ไม่จำกัดเฉพาะหน้าแรก
  * [PhantomJsCloud](https://PhantomJsCloud.com) — ระบบอัตโนมัติบราวเซอร์และการเรนเดอร์หน้าเว็บ ชั้นฟรีสูงสุด 500 หน้า/วัน ให้บริการฟรีตั้งแต่ปี 2017
  * [Webshrinker.com](https://webshrinker.com) — ให้บริการ API สำหรับ screenshot เว็บไซต์และข้อมูลโดเมน ฟรี 100 requests/เดือน
  * [Screenshots](https://screenshotson.click) — API สำหรับจับภาพหน้าจอเว็บไซต์ พร้อมตัวเลือกการตั้งค่าการจับภาพที่หลากหลาย ฟรี 100 screenshots/เดือน

**[⬆️ กลับไปด้านบน](#table-of-contents)**

## Flutter และการสร้างแอป iOS โดยไม่ใช้ Mac

  * [FlutLab](https://flutlab.io/) - FlutLab คือ IDE ออนไลน์สำหรับ Flutter ที่ทันสมัย เหมาะสำหรับสร้าง ดีบัก และ build โปรเจกต์ข้ามแพลตฟอร์ม สามารถ build แอป iOS (โดยไม่ต้องใช้ Mac) และ Android ด้วย Flutter
  * [CodeMagic](https://codemagic.io/) - บริการ CI/CD สำหรับแอปมือถือแบบโฮสต์และจัดการครบวงจร สามารถ build, test, deploy ด้วยเครื่องมือ CI/CD มี GUI แผนฟรีให้ใช้งาน 500 นาที/เดือน และ Mac Mini instance (2.3 GHz, 8 GB RAM)
  * [FlutterFlow](https://flutterflow.io/) - เครื่องมือสร้างแอปมือถือด้วย Flutter ผ่านเว็บแบบลากวาง

**[⬆️ กลับไปด้านบน](#table-of-contents)**

## การจำลองฮาร์ดแวร์ผ่านเบราว์เซอร์ด้วย Javascript

  * [JsLinux](https://bellard.org/jslinux) — เครื่องเสมือน x86 ความเร็วสูงที่สามารถรัน Linux และ Windows 2k ได้
  * [Jor1k](https://s-macke.github.io/jor1k/demos/main.html) — เครื่องเสมือน OpenRISC ที่สามารถรัน Linux พร้อมรองรับเครือข่าย
  * [v86](https://copy.sh/v86) — เครื่องเสมือน x86 ที่สามารถรัน Linux และ OS อื่น ๆ ได้โดยตรงในเบราว์เซอร์

**[⬆️ กลับไปด้านบน](#table-of-contents)**

## การจัดการความเป็นส่วนตัว
  * [Bearer](https://www.bearer.sh/) - ช่วยให้การทำ Privacy by Design เป็นเรื่องง่ายผ่านการตรวจสอบและ workflow ต่อเนื่อง เพื่อให้องค์กรปฏิบัติตาม GDPR และข้อกำหนดอื่น ๆ แผนฟรีจำกัดสำหรับทีมขนาดเล็กและเฉพาะเวอร์ชัน SaaS
  * [Osano](https://www.osano.com/) - แพลตฟอร์มจัดการความยินยอมและความสอดคล้องกฎหมาย พร้อมบริการครบถ้วนตั้งแต่ตัวแทน GDPR ไปจนถึงแบนเนอร์คุกกี้ ชั้นฟรีให้ฟีเจอร์พื้นฐาน
  * [Iubenda](https://www.iubenda.com/) - นโยบายความเป็นส่วนตัวและคุกกี้ และการจัดการความยินยอม แผนฟรีให้บริการนโยบายความเป็นส่วนตัวและคุกกี้แบบจำกัด รวมถึงแบนเนอร์คุกกี้
  * [Cookiefirst](https://cookiefirst.com/) - แบนเนอร์คุกกี้, การตรวจสอบ และโซลูชันจัดการความยินยอมหลายภาษา แผนฟรีสแกนได้ 1 ครั้ง และแบนเนอร์เดียว
  * [Ketch](https://www.ketch.com/) - เครื่องมือจัดการความยินยอมและเฟรมเวิร์กด้านความเป็นส่วนตัว ระดับฟรีมีฟีเจอร์ส่วนใหญ่พร้อมจำนวนผู้เยี่ยมชมที่จำกัด
  * [Concord](https://www.concord.tech/) - แพลตฟอร์มความเป็นส่วนตัวของข้อมูลแบบครบวงจร รวมถึงการจัดการความยินยอม การจัดการคำขอข้อมูลส่วนบุคคล (DSARs) และการแมปข้อมูล ระดับฟรีรวมฟีเจอร์หลักสำหรับการจัดการความยินยอม และยังมีแผนขั้นสูงให้ใช้ฟรีสำหรับโครงการโอเพ่นซอร์สที่ได้รับการยืนยัน

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## เบ็ดเตล็ด

  * [BackgroundStyler.com](https://backgroundstyler.com) - สร้างภาพหน้าจอสวยงามจากโค้ด ข้อความ หรือรูปภาพของคุณเพื่อแชร์บนโซเชียลมีเดีย
  * [BinShare.net](https://binshare.net) - สร้าง & แชร์โค้ดหรือไฟล์ไบนารี สามารถแชร์เป็นภาพสวยงาม เช่น สำหรับโพสต์ Twitter / Facebook หรือเป็นลิงก์สำหรับแชทหรือฟอรั่ม
  * [Blynk](https://blynk.io) — SaaS พร้อม API สำหรับควบคุม สร้าง และประเมินอุปกรณ์ IoT แผน Developer ฟรีรองรับ 5 อุปกรณ์, Cloud ฟรี & พื้นที่จัดเก็บข้อมูล มีแอปมือถือให้ใช้งานด้วย
  * [Bricks Note Calculator](https://free.getbricks.app/) - แอปจดโน้ต (PWA) ที่มีเครื่องคิดเลขหลายบรรทัดในตัวที่ทรงพลัง
  * [Carbon.now.sh](https://carbon.now.sh) - สร้างและแชร์โค้ดสแนปช็อตในรูปแบบภาพหน้าจอสวยงาม มักใช้สำหรับแชร์/โชว์โค้ดบน Twitter หรือบล็อกโพสต์อย่างสวยงาม
  * [Code Time](https://www.software.com/code-time) - ส่วนขยายสำหรับติดตามเวลาและสถิติการเขียนโค้ดใน VS Code, Atom, IntelliJ, Sublime Text และอื่นๆ
  * [Codepng](https://www.codepng.app) - สร้างภาพสแนปช็อตจากซอร์สโค้ดของคุณเพื่อแชร์บนโซเชียลมีเดีย
  * [CodeToImage](https://codetoimage.com/) - สร้างภาพหน้าจอจากโค้ดหรือข้อความเพื่อแชร์บนโซเชียลมีเดีย
  * [Cronhooks](https://cronhooks.io/) - กำหนดเวลาทำงาน webhook แบบครั้งเดียวหรือเป็นประจำ แผนฟรีให้ตั้งเวลาแบบ ad-hoc ได้ 5 ครั้ง
  * [cron-job.org](https://cron-job.org) - บริการ cronjobs ออนไลน์ ตั้งงานได้ไม่จำกัด ฟรี
  * [datelist.io](https://datelist.io) - ระบบนัดหมาย/จองออนไลน์ ฟรีสูงสุด 5 การจองต่อเดือน รวม 1 ปฏิทิน
  * [Domain Forward](https://domain-forward.com/) - เครื่องมือส่งต่อ URL หรือโดเมนอย่างง่าย ฟรีสูงสุด 5 โดเมนและ 200,000 คำขอต่อเดือน
  * [Elementor](https://elementor.com) — เครื่องมือสร้างเว็บไซต์ WordPress มีแผนฟรีพร้อมวิดเจ็ตพื้นฐานกว่า 40 รายการ
  * [Exif Editor](https://exifeditor.io/) — ดู แก้ไข ลบ วิเคราะห์ข้อมูลเมตาของรูปภาพ/ภาพถ่ายได้ทันทีผ่านเบราว์เซอร์ รวมถึงตำแหน่ง GPS และเมตาดาต้า
  * [Format Express](https://www.format-express.dev) - จัดรูปแบบ JSON / XML / SQL ออนไลน์ได้ทันที
  * [FOSSA](https://fossa.com/) - การจัดการโค้ดบุคคลที่สาม การปฏิบัติตามใบอนุญาต และช่องโหว่แบบ end-to-end ที่ขยายได้
  * [Hook Relay](https://www.hookrelay.dev/) - เพิ่ม webhook ให้แอปของคุณโดยไม่ยุ่งยาก: มีระบบคิว รีทรายแบบ backoff และล็อก แผนฟรีมี 100 รายการต่อวัน เก็บข้อมูล 14 วัน และ 3 endpoint
  * [Hosting Checker](https://hostingchecker.co) - ตรวจสอบข้อมูลโฮสติ้ง เช่น ASN, ISP, ตำแหน่ง และอื่นๆ สำหรับโดเมน เว็บไซต์ หรือ IP ใดๆ พร้อมเครื่องมือโฮสติ้งและ DNS หลายแบบ
  * [http2.pro](https://http2.pro) — ทดสอบความพร้อมใช้งานของโปรโตคอล HTTP/2 และ API ตรวจจับการรองรับ HTTP/2 ของไคลเอนต์
  * [kandi](https://kandi.openweaver.com/) — เร่งการพัฒนาแอปพลิเคชัน: สร้างฟังก์ชันกรณีการใช้งาน และแอปพลิเคชันได้เร็วขึ้นผ่านตัวอย่างโค้ดและการนำไลบรารีโอเพ่นซอร์สกลับมาใช้ใหม่
  * [Base64 decoder/encoder](https://devpal.co/base64-decode/) — เครื่องมือออนไลน์ฟรีสำหรับถอดรหัส & เข้ารหัสข้อมูล
  * [newreleases.io](https://newreleases.io/) - รับการแจ้งเตือนทางอีเมล, Slack, Telegram, Discord และ webhook เมื่อมีเวอร์ชันใหม่จาก GitHub, GitLab, Bitbucket, Python PyPI, Java Maven, Node.js NPM, Node.js Yarn, Ruby Gems, PHP Packagist, .NET NuGet, Rust Cargo และ Docker Hub
  * [OnlineExifViewer](https://onlineexifviewer.com/) — ดูข้อมูล EXIF ออนไลน์ทันทีสำหรับภาพถ่าย รวมถึงตำแหน่ง GPS และเมตาดาต้า
  * [PDFMonkey](https://www.pdfmonkey.io/) — จัดการเทมเพลต PDF ในแดชบอร์ด เรียก API ด้วยข้อมูลไดนามิก และดาวน์โหลด PDF ของคุณ ให้ใช้ฟรี 300 เอกสารต่อเดือน
  * [Pika Code Screenshots](https://pika.style/templates/code-image) — สร้างภาพหน้าจอสุดสวย ปรับแต่งได้ จากโค้ดและ VSCode ด้วยส่วนขยาย
  * [QuickType.io](https://quicktype.io/) - สร้างโมเดล/คลาส/ไทป์/อินเตอร์เฟซและ serializer อัตโนมัติจาก JSON, schema, GraphQL ได้อย่างรวดเร็ว รองรับหลายภาษา แปลง JSON เป็นโค้ด type-safe สวยงามในทุกภาษา
  * [RandomKeygen](https://randomkeygen.com/) - เครื่องมือฟรีสำหรับสร้างคีย์และรหัสผ่านแบบสุ่มหลากหลายชนิดเพื่อความปลอดภัยของแอป บริการ หรืออุปกรณ์
  * [ray.so](https://ray.so/) - สร้างภาพสวยงามจากโค้ดของคุณ
  * [readme.com](https://readme.com/) — สร้างเอกสารประกอบที่สวยงามได้ง่ายๆ ฟรีสำหรับโอเพ่นซอร์ส
  * [redirection.io](https://redirection.io/) — SaaS สำหรับจัดการการเปลี่ยนเส้นทาง HTTP สำหรับธุรกิจ การตลาด และ SEO
  * [redirect.ing](https://redirect.ing/) - ส่งต่อโดเมนอย่างรวดเร็วและปลอดภัยโดยไม่ต้องจัดการเซิร์ฟเวอร์หรือ SSL แผนฟรีรองรับ 10 โฮสต์เนม และ 100,000 คำขอต่อเดือน
  * [redirect.pizza](https://redirect.pizza/) - จัดการ redirect ได้ง่ายพร้อมรองรับ HTTPS แผนฟรีมี 10 แหล่งที่มา และ 100,000 hit ต่อเดือน
  * [ReqBin](https://reqbin.com/) — ส่ง HTTP Request ออนไลน์ รองรับ GET, POST, PUT, DELETE, HEAD และรองรับ Header, Token Authentication มีระบบล็อกอินพื้นฐานเพื่อบันทึก request
  * [Smartcar API](https://smartcar.com) - API สำหรับรถยนต์ เช่น ตำแหน่ง ระดับน้ำมัน แบตเตอรี่ ระยะทาง เปิด/ล็อกประตู ฯลฯ
  * [snappify](https://snappify.com) - ช่วยให้นักพัฒนาสร้างภาพนำเสนอเทคนิคสวยงาม ตั้งแต่โค้ดสแนปช็อตไปจนถึงพรีเซนเทชันขั้นสูง แผนฟรีสร้าง snap ได้ 3 อันพร้อมดาวน์โหลดไม่จำกัด และ AI อธิบายโค้ด 5 ครั้งต่อเดือน
  * [Sunrise and Sunset](https://sunrisesunset.io/api/) - รับเวลาพระอาทิตย์ขึ้นและตกตามลองจิจูดและละติจูดที่กำหนด
  * [superfeedr.com](https://superfeedr.com/) — ฟีดแบบ Real-time รองรับ PubSubHubbub, ส่งออก, วิเคราะห์ ฟรีแต่ปรับแต่งได้น้อย
  * [SurveyMonkey.com](https://www.surveymonkey.com) — สร้างแบบสอบถามออนไลน์ วิเคราะห์ผลลัพธ์ออนไลน์ แผนฟรีจำกัด 10 คำถามและ 100 คำตอบต่อแบบสอบถาม
  * [Tiledesk](https://tiledesk.com) - สร้าง chatbot และแอปสนทนา นำไปใช้หลายช่องทางทั้งในเว็บไซต์ (live chat) และ WhatsApp แผนฟรีรองรับ chatbot ไม่จำกัด
  * [Versionfeeds](https://versionfeeds.com) — ฟีด RSS สำหรับอัปเดตซอฟต์แวร์ที่คุณชื่นชอบ (3 ฟีดแรกใช้ฟรี)
  * [videoinu](https://videoinu.com) — สร้างและแก้ไขวิดีโอบันทึกหน้าจอและวิดีโออื่นๆ ออนไลน์
  * [Webacus](https://webacus.dev) — เข้าถึงเครื่องมือสำหรับนักพัฒนาฟรีมากมายสำหรับเข้ารหัส ถอดรหัส และจัดการข้อมูล

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## เครื่องมือเดสก์ท็อประยะไกล

  * [Getscreen.me](https://getscreen.me) — ฟรีสำหรับ 2 อุปกรณ์ ไม่จำกัดจำนวนและระยะเวลาของแต่ละเซสชัน
  * [Apache Guacamole™](https://guacamole.apache.org/) — เกตเวย์เดสก์ท็อประยะไกลแบบไคลเอนต์เลสโอเพ่นซอร์ส
  * [RemSupp](https://remsupp.com) — ให้การสนับสนุนตามคำขอและเข้าถึงอุปกรณ์ถาวร (ใช้ฟรี 2 เซสชัน/วัน)
  * [RustDesk](https://rustdesk.com/) - โครงสร้างพื้นฐานเดสก์ท็อประยะไกล/เสมือนแบบโอเพ่นซอร์สสำหรับทุกคน
  * [AnyDesk](https://anydesk.com) — ฟรีสำหรับ 3 อุปกรณ์ ไม่จำกัดจำนวนและระยะเวลาของแต่ละเซสชัน

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## การพัฒนาเกม

  * [itch.io](https://itch.io/game-assets) — แอสเซ็ตฟรี/เสียเงิน เช่น sprite, tile set, character pack
  * [Gamefresco.com](https://gamefresco.com/) — ค้นหา รวบรวม และแชร์แอสเซ็ตเกมฟรีจากศิลปินทั่วโลก
  * [GameDevMarket](https://gamedevmarket.net) — แอสเซ็ตฟรี/เสียเงิน เช่น 2D, 3D, เสียง, GUI
  * [OpenGameArt](https://opengameart.org) — แอสเซ็ตเกมโอเพ่นซอร์ส เช่น เพลง เสียง sprite และ gif
  * [CraftPix](https://craftpix.net) — แอสเซ็ตฟรี/เสียเงิน เช่น 2D, 3D, เสียง, GUI, พื้นหลัง, ไอคอน, tile set, ชุดเกม
  * [Game Icons](https://game-icons.net/) - ไอคอน SVG/PNG ปรับแต่งได้ฟรี ภายใต้ไลเซนส์ CC-BY
  * [LoSpec](https://lospec.com/) — เครื่องมือออนไลน์สำหรับสร้าง pixel art และงานศิลป์ดิจิทัลแบบจำกัดสี มีบทเรียนและพาเลตรายการให้เลือกมากมายสำหรับเกมของคุณ
  * [ArtStation](https://www.artstation.com/) - ตลาดซื้อขายแอสเซ็ต 2D, 3D, เสียง, ไอคอน, tile set, ชุดเกม ทั้งฟรี/เสียเงิน นอกจากนี้ยังใช้โชว์ผลงานศิลปะของคุณได้ด้วย
  * [Rive](https://rive.app/community/) - แอสเซ็ตชุมชนรวมถึงสร้างแอสเซ็ตเกมของคุณเองได้ในแผนฟรี
  * [Poly Pizza](https://poly.pizza/) - แอสเซ็ต 3D low poly ฟรี
  * [3Dassets.one](https://3dassets.one/) - โมเดล 3D และวัสดุ PBR ฟรี/เสียเงินมากกว่า 8,000 รายการสำหรับสร้างพื้นผิว
  * [Kenney](https://www.kenney.nl/assets/) - แอสเซ็ต 2D, 3D, เสียง และ UI สำหรับเกม (CC0 1.0 Universal license) ฟรี
  * [Poliigon](https://www.poliigon.com/) - พื้นผิว โมเดล HDRI และแปรงฟรีและเสียเงิน (ความละเอียดหลากหลาย) มีปลั๊กอินฟรีสำหรับส่งออกไปยังซอฟต์แวร์เช่น Blender
  * [Freesound](https://freesound.org/) - ห้องสมุดเสียงแบบร่วมมือฟรี มีไลเซนส์ CC หลายแบบ

**[⬆️ กลับสู่ด้านบน](#table-of-contents)**

## ทรัพยากรฟรีอื่น ๆ

  * [Wikimint Developer](https://developer.wikimint.com/p/tools.html) - เครื่องมือฟรีสำหรับนักพัฒนาเว็บ เช่น ย่อ/ขยาย CSS, ปรับภาพ, แปลงตัวพิมพ์, ตรวจสอบ CSS, คอมไพล์ JavaScript, แก้ไข HTML ฯลฯ
  * [ElevateAI](https://www.elevateai.com) - รับชั่วโมงถอดเสียงเสียงฟรีสูงสุด 200 ชั่วโมงต่อเดือน
  * [get.localhost.direct](https://get.localhost.direct) — Wildcard SSL cert สำหรับ localhost development พร้อมรองรับ sub-domain จาก CA สาธารณะ ฟรี
  * [Framacloud](https://degooglisons-internet.org/en/) — รายการ Free/Libre Open Source Software และ SaaS โดยองค์กรไม่แสวงหากำไร [Framasoft](https://framasoft.org/en/) จากฝรั่งเศส
  * [github.com — FOSS for Dev](https://github.com/tvvocold/FOSS-for-Dev) — ศูนย์รวมซอฟต์แวร์ฟรีและโอเพ่นซอร์สสำหรับนักพัฒนา
  * [GitHub Education](https://education.github.com/pack) — รวมบริการฟรีสำหรับนักศึกษา ต้องลงทะเบียน
  * [Markdown Tools](https://markdowntools.com) - เครื่องมือแปลง HTML, CSV, PDF, JSON, และไฟล์ Excel เป็น Markdown และกลับกัน
  * [Microsoft 365 Developer Program](https://developer.microsoft.com/microsoft-365/dev-program) — รับ sandbox ฟรี เครื่องมือ และทรัพยากรสำหรับสร้างโซลูชันบน Microsoft 365 โดยเป็นสมาชิก [Microsoft 365 E5 Subscription](https://www.microsoft.com/microsoft-365/enterprise/e5) (ไม่รวม Windows) ระยะเวลา 90 วัน ต่ออายุได้ถ้าคุณมีการพัฒนาอย่างต่อเนื่อง (ตรวจวัดด้วย telemetry & อัลกอริทึม)
  * [Pyrexp](https://pythonium.net/regex) — เครื่องมือทดสอบและแสดงผล regex บนเว็บ ฟรี
  * [RedHat for Developers](https://developers.redhat.com) — เข้าถึงผลิตภัณฑ์ Red Hat ฟรี เช่น RHEL, OpenShift, CodeReady ฯลฯ สำหรับนักพัฒนาโดยเฉพาะ มีอีบุ๊กฟรีด้วย
  * [smsreceivefree.com](https://smsreceivefree.com/) — ให้หมายเลขโทรศัพท์ชั่วคราวและใช้แล้วทิ้งฟรี
  * [sandbox.httpsms.com](https://sandbox.httpsms.com) — ส่งและรับ SMS ทดสอบฟรี
  * [SimpleBackups.com](https://simplebackups.com/) — บริการแบ็กอัพอัตโนมัติสำหรับเซิร์ฟเวอร์และฐานข้อมูล (MySQL, PostgreSQL, MongoDB) ไปยัง cloud storage โดยตรง (AWS, DigitalOcean, Backblaze) แผนฟรีสำหรับ 1 แบ็กอัพ
  * [SnapShooter](https://snapshooter.com/) — โซลูชันแบ็กอัพสำหรับ DigitalOcean, AWS, LightSail, Hetzner และ Exoscale รองรับการแบ็กอัพฐานข้อมูล ระบบไฟล์ และแอปโดยตรงไป s3 แผนฟรีแบ็กอัพรายวันสำหรับ 1 ทรัพยากร
  * [Themeselection](https://themeselection.com/) — เทมเพลตแดชบอร์ดผู้ดูแลระบบ HTML ธีม และ UI Kit ฟรี คุณภาพสูง ทันสมัย ใช้งานง่าย เพื่อสร้างแอปของคุณได้เร็วขึ้น!
  * [Web.Dev](https://web.dev/measure/) — เครื่องมือฟรีสำหรับวัดประสิทธิภาพเว็บไซต์และแนะนำการปรับปรุง SEO เพื่ออันดับที่ดีขึ้นในเครื่องมือค้นหา
  * [SmallDev.tools](https://smalldev.tools/) — เครื่องมือฟรีสำหรับนักพัฒนาที่ให้คุณเข้ารหัส/ถอดรหัสหลากหลายรูปแบบ, ย่อ HTML/CSS/Javascript, จัดรูปแบบสวยงาม, สร้างชุดข้อมูลปลอม/ทดสอบในรูปแบบ JSON/CSV และรูปแบบอื่น ๆ อีกมากมาย พร้อมอินเทอร์เฟซที่ใช้งานง่ายและน่าประทับใจ
  * [UseCSV by Layercode](https://layercode.com/usecsv) — เพิ่มการนำเข้าไฟล์ CSV และ Excel ให้กับเว็บแอปของคุณได้ในไม่กี่นาที มอบประสบการณ์การนำเข้าข้อมูลที่ดีเยี่ยมและเสถียรให้กับผู้ใช้ของคุณ เริ่มใช้ฟรีโดยไม่ต้องใช้ข้อมูลบัตรเครดิต และเริ่มใช้งาน UseCSV ได้ทันที คุณสามารถสร้างผู้นำเข้าได้ไม่จำกัดและอัปโหลดไฟล์ได้สูงสุด 100Mb
  * [Buttons Generator](https://markodenic.com/tools/buttons-generator/) — มีปุ่มให้เลือกใช้งานมากกว่า 100 แบบในโปรเจกต์ของคุณ
  * [WrapPixel](https://www.wrappixel.com/) — ดาวน์โหลดเทมเพลตแดชบอร์ดผู้ดูแลระบบคุณภาพสูงทั้งแบบฟรีและพรีเมียมที่สร้างด้วย Angular, React, VueJs, NextJS และ NuxtJS!
  * [Utils.fun](https://utils.fun/en) — รวมเครื่องมือออฟไลน์สำหรับงานประจำวันและงานพัฒนาที่ใช้พลังการประมวลผลของเบราว์เซอร์ เช่น การสร้างลายน้ำ บันทึกหน้าจอ เข้ารหัส/ถอดรหัส เข้ารหัส/ถอดรหัสข้อมูล และจัดรูปแบบโค้ด ทั้งหมดนี้ฟรีและไม่มีการอัปโหลดข้อมูลใด ๆ ไปยังคลาวด์
  * [It tools](it-tools.tech) - เครื่องมือที่มีประโยชน์สำหรับนักพัฒนาและผู้ทำงานด้าน IT
  * [Free Code Tools](https://freecodetools.org/) — เครื่องมือโค้ดที่มีประสิทธิภาพและฟรี 100% เช่น ตัวแก้ไข Markdown, ย่อ/จัดรูปแบบโค้ด, สร้าง QR code, สร้าง Open Graph, สร้าง Twitter card และอื่น ๆ
  * [regex101](https://regex101.com/) — เว็บไซต์ฟรีที่ให้คุณทดสอบและดีบัก regular expression (regex) พร้อมทั้งมีตัวแก้ไข regex, ตัวทดสอบ รวมถึงเอกสารและแหล่งเรียนรู้ regex ที่เป็นประโยชน์
  * [Kody Tools](https://www.kodytools.com/dev-tools) — รวมเครื่องมือสำหรับนักพัฒนากว่า 100 รายการ เช่น ตัวจัดรูปแบบ ตัวลดขนาด และตัวแปลงไฟล์
  * [AdminMart](https://adminmart.com/) — เทมเพลตแดชบอร์ดผู้ดูแลระบบและเว็บไซต์คุณภาพสูงทั้งแบบฟรีและพรีเมียมที่สร้างด้วย Angular, Bootstrap, React, VueJs, NextJS และ NuxtJS!
  * [Glob tester](https://globster.xyz/) — เว็บไซต์สำหรับออกแบบและทดสอบ glob patterns พร้อมแหล่งเรียนรู้ glob patterns
  * [SimpleRestore](https://simplerestore.io) - กู้คืนข้อมูลสำรอง MySQL ได้อย่างง่ายดาย คืนค่าข้อมูลสำรอง MySQL ไปยังฐานข้อมูลระยะไกลใด ๆ โดยไม่ต้องใช้โค้ดหรือเซิร์ฟเวอร์
  * [360Converter](https://www.360converter.com/) - เว็บไซต์ฟรีสำหรับแปลง: วิดีโอเป็นข้อความ, เสียงเป็นข้อความ, คำพูดเป็นข้อความ, เสียงแบบเรียลไทม์เป็นข้อความ, วิดีโอ YouTube เป็นข้อความ และเพิ่มคำบรรยายวิดีโอ อาจเป็นประโยชน์สำหรับการแปลงวิดีโอสั้นหรือบทแนะนำ YouTube สั้น ๆ :)
  * [QRCodeBest](https://qrcode.best/) - สร้าง QR code ที่ปรับแต่งได้พร้อม 13 เทมเพลต ความเป็นส่วนตัวสูง และแบรนด์ส่วนตัว มีฟีเจอร์ติดตามพิกเซล แยกโปรเจกต์ และรองรับทีมไม่จำกัดที่ QRCode.Best
  * [PostPulse](https://PostPulseAI.com) - เพิ่มการมองเห็นออนไลน์ของคุณและปรับปรุง SEO กับโพสต์ที่สร้างโดย AI รายเดือนไปยังโดเมนที่ปรับแต่ง SEO แผนฟรีให้โพสต์บนเว็บไซต์ของเราได้ 1 ครั้งต่อเดือนแบบแมนนวล
  * [PageTools](https://pagetools.co/) - ชุดเครื่องมือ AI ฟรีตลอดชีพสำหรับสร้างนโยบายเว็บไซต์ที่จำเป็น, สร้างโปรไฟล์/โพสต์โซเชียลมีเดีย และเว็บเพจได้ง่าย ๆ เพียงคลิกเดียว
  * [MySQL Visual Explain](https://mysqlexplain.com) - เครื่องมือแสดงผล MySQL EXPLAIN ฟรีที่เข้าใจง่าย ช่วยให้คุณปรับแต่ง query ที่ทำงานช้าได้
  * [Killer Coda](https://killercoda.com/)  - สนามทดลองแบบอินเทอร์แอคทีฟในเบราว์เซอร์สำหรับเรียนรู้ Linux, Kubernetes, Containers, Programming, DevOps, Networking
  * [Axonomy App](https://axonomy-app.com/) - เครื่องมือฟรีสำหรับสร้าง จัดการ และแบ่งปันใบแจ้งหนี้กับลูกค้า ได้ฟรี 10 ใบต่อเดือน
  * [Table Format Converter](https://www.tableformatconverter.com) - เครื่องมือฟรีสำหรับแปลงข้อมูลตารางไปยังรูปแบบต่าง ๆ เช่น CSV, HTML, JSON, Markdown และอื่น ๆ


**[⬆️ กลับไปด้านบน](#table-of-contents)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---