![โลโก้ Envoy](https://github.com/envoyproxy/artwork/blob/main/PNG/Envoy_Logo_Final_PANTONE.png)

[พร็อกซี่สำหรับ edge/middle/service ประสิทธิภาพสูงแบบ Cloud-native](https://www.envoyproxy.io/)

Envoy ได้รับการดูแลโดย [Cloud Native Computing Foundation](https://cncf.io) (CNCF) หากคุณเป็นบริษัทที่ต้องการมีส่วนร่วมในการพัฒนาเทคโนโลยีที่บรรจุในคอนเทนเนอร์, ถูกจัดการแบบไดนามิก และเน้นไมโครเซอร์วิส โปรดพิจารณาเข้าร่วม CNCF สำหรับรายละเอียดเกี่ยวกับผู้ที่มีส่วนร่วมและบทบาทของ Envoy โปรดอ่าน
[ประกาศ](https://www.cncf.io/blog/2017/09/13/cncf-hosts-envoy/) ของ CNCF

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/1266/badge)](https://bestpractices.coreinfrastructure.org/projects/1266)
[![OpenSSF Scorecard](https://api.securityscorecards.dev/projects/github.com/envoyproxy/envoy/badge)](https://securityscorecards.dev/viewer/?uri=github.com/envoyproxy/envoy)
[![CLOMonitor](https://img.shields.io/endpoint?url=https://clomonitor.io/api/projects/cncf/envoy/badge)](https://clomonitor.io/projects/cncf/envoy)
[![Azure Pipelines](https://dev.azure.com/cncf/envoy/_apis/build/status/11?branchName=main)](https://dev.azure.com/cncf/envoy/_build/latest?definitionId=11&branchName=main)
[![Fuzzing Status](https://oss-fuzz-build-logs.storage.googleapis.com/badges/envoy.svg)](https://bugs.chromium.org/p/oss-fuzz/issues/list?sort=-opened&can=1&q=proj:envoy)
[![Jenkins](https://powerci.osuosl.org/buildStatus/icon?job=build-envoy-static-master&subject=ppc64le%20build)](https://powerci.osuosl.org/job/build-envoy-static-master/)
[![Jenkins](https://ibmz-ci.osuosl.org/buildStatus/icon?job=Envoy_IBMZ_CI&subject=s390x%20build)](https://ibmz-ci.osuosl.org/job/Envoy_IBMZ_CI/)

## เอกสาร

* [เอกสารทางการ](https://www.envoyproxy.io/)
* [FAQ](https://www.envoyproxy.io/docs/envoy/latest/faq/overview)
* [ตัวอย่างเอกสาร](https://github.com/envoyproxy/examples/)
* [บล็อก](https://medium.com/@mattklein123/envoy-threading-model-a8d44b922310) เกี่ยวกับรูปแบบ threading
* [บล็อก](https://medium.com/@mattklein123/envoy-hot-restart-1d16b14555b5) เกี่ยวกับ hot restart
* [บล็อก](https://medium.com/@mattklein123/envoy-stats-b65c7f363342) เกี่ยวกับสถาปัตยกรรมสถิติ
* [บล็อก](https://medium.com/@mattklein123/the-universal-data-plane-api-d15cec7a) เกี่ยวกับ universal data plane API
* [บล็อก](https://medium.com/@mattklein123/lyfts-envoy-dashboards-5c91738816b1) เกี่ยวกับแดชบอร์ด Envoy ของ Lyft

## ที่เกี่ยวข้อง

* [data-plane-api](https://github.com/envoyproxy/data-plane-api): คำนิยาม API v2 แบบแยก repository นี่คือ mirror แบบอ่านอย่างเดียวของ [api](https://raw.githubusercontent.com/envoyproxy/envoy/main/api/).
* [envoy-perf](https://github.com/envoyproxy/envoy-perf): เฟรมเวิร์คสำหรับทดสอบประสิทธิภาพ
* [envoy-filter-example](https://github.com/envoyproxy/envoy-filter-example): ตัวอย่างการเพิ่มฟิลเตอร์ใหม่และลิงก์ไปยัง repository หลัก

## ติดต่อ

* [envoy-announce](https://groups.google.com/forum/#!forum/envoy-announce): รายชื่อเมลสำหรับประกาศข่าวสารเท่านั้น
* [envoy-security-announce](https://groups.google.com/forum/#!forum/envoy-security-announce): รายชื่อเมลสำหรับประกาศด้านความปลอดภัยเท่านั้น
* [envoy-users](https://groups.google.com/forum/#!forum/envoy-users): พูดคุยสำหรับผู้ใช้ทั่วไป
* [envoy-dev](https://groups.google.com/forum/#!forum/envoy-dev): พูดคุยสำหรับนักพัฒนา Envoy (API, การออกแบบฟีเจอร์ ฯลฯ)
* [envoy-maintainers](https://groups.google.com/forum/#!forum/envoy-maintainers): ใช้รายชื่อนี้เพื่อติดต่อผู้ดูแลหลักของ Envoy ทั้งหมด
* [Twitter](https://twitter.com/EnvoyProxy/): ติดตามข่าวสารบน Twitter!
* [Slack](https://envoyproxy.slack.com/): Slack, เพื่อรับคำเชิญเข้าร่วม [ที่นี่](https://communityinviter.com/apps/envoyproxy/envoy)
  * หมายเหตุ: การตอบคำถามผู้ใช้ใน Slack จะเป็นไปตามความสามารถ สำหรับการรับประกันว่าจะได้รับคำตอบ โปรดส่งอีเมลไปที่ envoy-users@ ตามคำแนะนำในเธรดที่แนบมา

โปรดดู [อีเมลเธรดนี้](https://groups.google.com/forum/#!topic/envoy-announce/l9zjYsnS3TY) สำหรับข้อมูลการใช้งานรายชื่ออีเมล

## การมีส่วนร่วม

การมีส่วนร่วมกับ Envoy นั้นสนุกและ C++ สมัยใหม่ก็ไม่ได้ยากอย่างที่คิด แม้ไม่มีประสบการณ์มาก่อน ในการเริ่มต้น:

* [คู่มือการมีส่วนร่วม](https://raw.githubusercontent.com/envoyproxy/envoy/main/CONTRIBUTING.md)
* [ปัญหาสำหรับผู้เริ่มต้น](https://github.com/envoyproxy/envoy/issues?q=is%3Aopen+is%3Aissue+label%3Abeginner)
* [เริ่มต้น build/test อย่างรวดเร็วโดยใช้ docker](https://raw.githubusercontent.com/envoyproxy/envoy/main/ci#building-and-running-tests-as-a-developer)
* [คู่มือนักพัฒนา](https://raw.githubusercontent.com/envoyproxy/envoy/main/DEVELOPER.md)
* พิจารณาติดตั้ง [development support toolchain ของ Envoy](https://github.com/envoyproxy/envoy/blob/main/support/README.md) ซึ่งช่วยอัตโนมัติบางส่วนของกระบวนการพัฒนา โดยเฉพาะอย่างยิ่งที่เกี่ยวกับการรีวิวโค้ด
* โปรดแจ้งให้เราทราบหากคุณกำลังทำงานกับปัญหาใด เพื่อป้องกันการทำงานซ้ำซ้อน!

## การประชุมชุมชน

ทีม Envoy มีกำหนดประชุมเดือนละสองครั้งในวันอังคาร เวลา 9am PT ปฏิทิน Google สาธารณะดูได้ [ที่นี่](https://goo.gl/PkDijT) การประชุมจะจัดขึ้นเฉพาะเมื่อมีหัวข้อใน [บันทึกการประชุม](https://goo.gl/5Cergb) สมาชิกชุมชนสามารถเสนอหัวข้อวาระได้โดยเพิ่มในบันทึกการประชุม ผู้ดูแลจะยืนยันหัวข้อ หรือยกเลิกการประชุมภายใน 24 ชั่วโมงก่อนเวลานัด หากไม่มีหัวข้อที่ได้รับการยืนยัน

## ความปลอดภัย

### การตรวจสอบความปลอดภัย

มีการว่าจ้างบุคคลที่สามเพื่อตรวจสอบความปลอดภัยของ Envoy หลายครั้ง:
* ในปี 2018 Cure53 ได้ทำการตรวจสอบความปลอดภัย, [รายงานฉบับเต็ม](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_cure53_2018.pdf)
* ในปี 2021 Ada Logics ได้ตรวจสอบโครงสร้าง fuzzing พร้อมข้อเสนอแนะปรับปรุง, [รายงานฉบับเต็ม](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_fuzzer_adalogics_2021.pdf)

### การรายงานช่องโหว่ด้านความปลอดภัย

หากคุณพบช่องโหว่หรืออาจเป็นช่องโหว่ใน Envoy โปรดแจ้งเราที่ [envoy-security](mailto:envoy-security@googlegroups.com) เราจะส่งอีเมลยืนยันการรับรายงาน และจะส่งอีเมลเพิ่มเติมเมื่อเราตรวจสอบประเด็นดังกล่าวแล้ว

ดูรายละเอียดเพิ่มเติมได้ที่ [กระบวนการออกประกาศด้านความปลอดภัยฉบับเต็ม](https://raw.githubusercontent.com/envoyproxy/envoy/main/SECURITY.md)

### การ build สำหรับ ppc64le

การ build สำหรับสถาปัตยกรรม ppc64le หรือการใช้ aws-lc ไม่อยู่ภายใต้นโยบายความปลอดภัยของ envoy สถาปัตยกรรม ppc64le ขณะนี้อยู่ในขั้นทดสอบและไม่ได้รับการดูแลโดยทีม Envoy

## การออกเวอร์ชัน

สำหรับรายละเอียดเพิ่มเติม โปรดดู [กระบวนการออกเวอร์ชัน](https://github.com/envoyproxy/envoy/blob/main/RELEASES.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---