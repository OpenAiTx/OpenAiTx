<a name="readme-top"></a>
<h1 align="center">
    <img src="https://img.alicdn.com/imgextra/i2/O1CN01NwxLDd20nxfGBjxmZ_!!6000000006895-2-tps-960-290.png" alt="Higress" width="240" height="72.5">
  <br>
  เกตเวย์ AI
</h1>
<h4 align="center"> เกตเวย์ API ที่สร้างมาเพื่อ AI โดยเฉพาะ </h4>

<div align="center">
    
[![Build Status](https://github.com/alibaba/higress/actions/workflows/build-and-test.yaml/badge.svg?branch=main)](https://github.com/alibaba/higress/actions)
[![license](https://img.shields.io/github/license/alibaba/higress.svg)](https://www.apache.org/licenses/LICENSE-2.0.html)
[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=flat-square)](https://discord.gg/tSbww9VDaM)

<a href="https://trendshift.io/repositories/10918" target="_blank"><img src="https://trendshift.io/api/badge/repositories/10918" alt="alibaba%2Fhigress | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a> <a href="https://www.producthunt.com/posts/higress?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-higress" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=951287&theme=light&t=1745492822283" alt="Higress - Global&#0032;APIs&#0032;as&#0032;MCP&#0032;powered&#0032;by&#0032;AI&#0032;Gateway | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

</div>

[**เว็บไซต์ทางการ**](https://higress.ai/en/) &nbsp; |
&nbsp; [**MCP Server QuickStart**](https://higress.cn/en/ai/mcp-quick-start/) &nbsp; |
&nbsp; [**Wasm Plugin Hub**](https://higress.cn/en/plugin/) &nbsp; |

<p>
   English | <a href="README_ZH.md">中文<a/> | <a href="README_JP.md">日本語<a/>
</p>

## Higress คืออะไร?

Higress คือ เกตเวย์ API แบบคลาวด์เนทีฟ พัฒนาบน Istio และ Envoy ซึ่งสามารถขยายความสามารถด้วย Wasm plugins ที่เขียนด้วย Go/Rust/JS ได้ มีปลั๊กอินใช้งานทั่วไปพร้อมใช้หลายสิบรายการและคอนโซลแบบพร้อมใช้งาน (ทดลอง [เดโมที่นี่](http://demo.higress.io/)).

### กรณีการใช้งานหลัก

ความสามารถของเกตเวย์ AI ของ Higress รองรับ [ผู้ให้บริการโมเดลหลัก](https://raw.githubusercontent.com/alibaba/higress/main/plugins/wasm-go/extensions/ai-proxy/provider) ทั้งในประเทศและต่างประเทศ และยังรองรับการโฮสต์ MCP (Model Context Protocol) Servers ผ่านกลไกปลั๊กอิน ช่วยให้ AI Agents เรียกใช้งานเครื่องมือและบริการต่าง ๆ ได้อย่างง่ายดาย ด้วย [openapi-to-mcp tool](https://github.com/higress-group/openapi-to-mcpserver) คุณสามารถแปลง OpenAPI specification เป็น remote MCP server ได้อย่างรวดเร็ว Higress มอบการจัดการแบบรวมศูนย์สำหรับทั้ง LLM API และ MCP API

**🌟 ทดลองใช้งานได้ทันทีที่ [https://mcp.higress.ai/](https://mcp.higress.ai/)** เพื่อสัมผัสประสบการณ์ Remote MCP Servers ที่โฮสต์โดย Higress ด้วยตนเอง:

![Higress MCP Server Platform](https://img.alicdn.com/imgextra/i2/O1CN01nmVa0a1aChgpyyWOX_!!6000000003294-0-tps-3430-1742.jpg)

### การใช้งานในองค์กร

Higress เกิดขึ้นภายใน Alibaba เพื่อแก้ไขปัญหา reload ของ Tengine ที่ส่งผลต่อบริการที่ใช้การเชื่อมต่อระยะยาว และความสามารถในการบาลานซ์โหลดที่ไม่เพียงพอสำหรับ gRPC/Dubbo ใน Alibaba Cloud ความสามารถของเกตเวย์ AI ของ Higress รองรับแอปพลิเคชัน AI หลัก เช่น Tongyi Bailian model studio, แพลตฟอร์ม Machine Learning PAI และบริการ AI สำคัญอื่น ๆ Alibaba Cloud ได้สร้างผลิตภัณฑ์ API Gateway แบบคลาวด์เนทีฟโดยใช้ Higress มอบบริการความพร้อมใช้งานสูงของเกตเวย์ 99.99% ให้กับลูกค้าองค์กรจำนวนมาก

## สารบัญ

- [**เริ่มต้นอย่างรวดเร็ว**](#quick-start)    
- [**แสดงคุณสมบัติ**](#feature-showcase)
- [**กรณีการใช้งาน**](#use-cases)
- [**จุดเด่นหลัก**](#core-advantages)
- [**ชุมชน**](#community)

## เริ่มต้นอย่างรวดเร็ว

Higress สามารถเริ่มต้นใช้งานด้วย Docker เท่านั้น เหมาะสำหรับนักพัฒนารายบุคคลในการเรียนรู้หรือสร้างเว็บไซต์ขนาดเล็กได้อย่างสะดวก:

```bash
# สร้างไดเรกทอรีสำหรับทำงาน
mkdir higress; cd higress
# เริ่มต้น higress ไฟล์คอนฟิกจะถูกเขียนลงในไดเรกทอรีที่ทำงาน
docker run -d --rm --name higress-ai -v ${PWD}:/data \
        -p 8001:8001 -p 8080:8080 -p 8443:8443  \
        higress-registry.cn-hangzhou.cr.aliyuncs.com/higress/all-in-one:latest
```

รายละเอียดพอร์ต:

- พอร์ต 8001: ทางเข้า Higress UI console
- พอร์ต 8080: ทางเข้า Gateway HTTP protocol
- พอร์ต 8443: ทางเข้า Gateway HTTPS protocol

> Docker image ของ Higress ทั้งหมดใช้ repository ของตัวเองและไม่ได้รับผลกระทบจากข้อจำกัดอัตราของ Docker Hub
> นอกจากนี้ การอัปโหลดและอัปเดต image ได้รับการปกป้องด้วยกลไกการสแกนความปลอดภัย (ขับเคลื่อนโดย Alibaba Cloud ACR) ทำให้มั่นใจในความปลอดภัยสำหรับการใช้งานจริง
> 
> หากคุณพบปัญหา timeout ขณะดึง image จาก `higress-registry.cn-hangzhou.cr.aliyuncs.com` สามารถลองเปลี่ยนเป็นแหล่ง docker registry mirror ดังนี้:
> 
> **เอเชียตะวันออกเฉียงใต้**: `higress-registry.ap-southeast-7.cr.aliyuncs.com`

สำหรับวิธีติดตั้งอื่น ๆ เช่นการติดตั้งด้วย Helm บน K8s กรุณาดูที่ [คู่มือเริ่มต้นอย่างรวดเร็ว](https://higress.io/en-us/docs/user/quickstart) อย่างเป็นทางการ

## กรณีการใช้งาน

- **การโฮสต์ MCP Server**:

  Higress โฮสต์ MCP Servers ผ่านกลไกปลั๊กอิน ช่วยให้ AI Agents เรียกใช้งานเครื่องมือและบริการต่าง ๆ ได้ง่ายดาย ด้วย [openapi-to-mcp tool](https://github.com/higress-group/openapi-to-mcpserver) คุณสามารถแปลง OpenAPI specification เป็น remote MCP server ได้อย่างรวดเร็ว

  ![](https://img.alicdn.com/imgextra/i1/O1CN01wv8H4g1mS4MUzC1QC_!!6000000004952-2-tps-1764-597.png)

  ข้อดีสำคัญของการโฮสต์ MCP Server ด้วย Higress:
  - กลไกการยืนยันตัวตนและอนุญาตแบบรวมศูนย์
  - จำกัดอัตราการเข้าใช้งานอย่างละเอียดเพื่อป้องกันการใช้งานเกินขอบเขต
  - บันทึกการ audit log อย่างสมบูรณ์สำหรับการเรียกใช้งานเครื่องมือทุกชนิด
  - ความสามารถในการสังเกตการณ์ที่สมบูรณ์สำหรับตรวจสอบประสิทธิภาพ
  - ดีพลอยง่ายผ่านกลไกปลั๊กอินของ Higress
  - อัปเดตได้แบบไดนามิกโดยไม่หยุดชะงักหรือหลุดการเชื่อมต่อ

     [ดูรายละเอียดเพิ่มเติม...](https://higress.cn/en/ai/mcp-quick-start/?spm=36971b57.7beea2de.0.0.d85f20a94jsWGm)

- **AI Gateway**:

  Higress เชื่อมต่อกับผู้ให้บริการ LLM model ทุกรายด้วยโปรโตคอลเดียวกัน พร้อมความสามารถในการสังเกตการณ์ AI, บาลานซ์โหลดแบบหลายโมเดล, จำกัดอัตรา token และแคช:

  ![](https://img.alicdn.com/imgextra/i2/O1CN01izmBNX1jbHT7lP3Yr_!!6000000004566-0-tps-1920-1080.jpg)

- **Kubernetes ingress controller**:

  Higress สามารถทำหน้าที่เป็น ingress controller ที่มีฟีเจอร์ครบครัน และรองรับ annotation ของ nginx ingress controller บน K8s ได้เป็นอย่างดี

  [Gateway API](https://gateway-api.sigs.k8s.io/) จะรองรับในเร็ว ๆ นี้ และจะสามารถย้ายจาก Ingress API ไป Gateway API ได้อย่างราบรื่น

- **Microservice gateway**:

  Higress สามารถทำหน้าที่เป็น microservice gateway ซึ่งสามารถค้นหา microservices จาก service registry หลายประเภท เช่น Nacos, ZooKeeper, Consul, Eureka ฯลฯ

  ผสานการทำงานกับ [Dubbo](https://github.com/apache/dubbo), [Nacos](https://github.com/alibaba/nacos), [Sentinel](https://github.com/alibaba/Sentinel) และเทคโนโลยี microservice อื่น ๆ ได้อย่างลึกซึ้ง

- **Security gateway**:

  Higress สามารถใช้เป็น security gateway รองรับ WAF และกลยุทธ์การยืนยันตัวตนหลากหลาย เช่น key-auth, hmac-auth, jwt-auth, basic-auth, oidc ฯลฯ

## จุดเด่นหลัก

- **ระดับการใช้งานจริง (Production Grade)**

  พัฒนาจากผลิตภัณฑ์ภายใน Alibaba ผ่านการใช้งานจริงมากกว่า 2 ปี รองรับสถานการณ์ขนาดใหญ่ที่มี request หลักแสนต่อวินาที

  กำจัดปัญหา traffic jitter จาก Nginx reload ได้หมดสิ้น การเปลี่ยนแปลงคอนฟิกมีผลในระดับมิลลิวินาทีและไม่กระทบธุรกิจ เหมาะอย่างยิ่งกับการใช้งานแบบเชื่อมต่อระยะยาวเช่น AI

- **การประมวลผลแบบสตรีมมิ่ง**

  รองรับการประมวลผล streaming ของ request/response body อย่างแท้จริง Wasm plugin สามารถปรับแต่งการจัดการ streaming protocol เช่น SSE (Server-Sent Events) ได้ง่าย

  ในสถานการณ์ที่ใช้แบนด์วิธสูงเช่น AI ช่วยลดการใช้หน่วยความจำอย่างมีนัยสำคัญ
    
- **ขยายความสามารถได้ง่าย**
  
  มีคลังปลั๊กอินทางการที่ครอบคลุม AI, การจัดการทราฟฟิก, การป้องกันความปลอดภัย และฟังก์ชันทั่วไปอื่น ๆ ตอบโจทย์กว่า 90% ของกรณีธุรกิจ

  เน้นการขยายผ่าน Wasm plugin รับประกันความปลอดภัยของหน่วยความจำด้วย sandbox isolation รองรับหลายภาษา อัปเกรดเวอร์ชันปลั๊กอินแยกได้ อัปเดต logic gateway แบบ hot update โดยไม่สูญเสียทราฟฟิก

- **ปลอดภัยและใช้งานง่าย**
  
  พัฒนาตามมาตรฐาน Ingress API และ Gateway API มี UI console พร้อมใช้, WAF, ปลั๊กอินป้องกัน IP/Cookie CC พร้อมใช้งาน

  รองรับการเชื่อมต่อ Let's Encrypt เพื่อออกและต่ออายุใบรับรองฟรีอัตโนมัติ สามารถใช้งานนอก K8s ได้ เริ่มต้นด้วยคำสั่ง Docker เดียว เหมาะกับนักพัฒนาแต่ละบุคคล

## ชุมชน

เข้าร่วมชุมชน Discord ของเรา! ที่นี่คุณจะได้พูดคุยกับนักพัฒนาและผู้ใช้งาน Higress ที่มีความกระตือรือร้น

[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=for-the-badge)](https://discord.gg/tSbww9VDaM)


### ขอบคุณ

Higress จะเกิดขึ้นไม่ได้หากปราศจากซอฟต์แวร์โอเพ่นซอร์สอันมีค่าจากโครงการในชุมชนนี้ ขอขอบคุณ Envoy และ Istio เป็นพิเศษ

### โครงการที่เกี่ยวข้อง

- Higress Console: https://github.com/higress-group/higress-console
- Higress Standalone: https://github.com/higress-group/higress-standalone

### ผู้ร่วมพัฒนา

<a href="https://github.com/alibaba/higress/graphs/contributors">
  <img alt="contributors" src="https://contrib.rocks/image?repo=alibaba/higress"/>
</a>

### ประวัติการให้ดาว

[![Star History Chart](https://api.star-history.com/svg?repos=alibaba/higress&type=Date)](https://star-history.com/#alibaba/higress&Date)

<p align="right" style="font-size: 14px; color: #555; margin-top: 20px;">
    <a href="#readme-top" style="text-decoration: none; color: #007bff; font-weight: bold;">
        ↑ กลับสู่ด้านบน ↑
    </a>
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---