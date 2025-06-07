# helm-chartsnap 📸 
[![Go Reference](https://pkg.go.dev/badge/github.com/jlandowner/helm-chartsnap.svg)](https://pkg.go.dev/github.com/jlandowner/helm-chartsnap)
[![Go Report Card](https://goreportcard.com/badge/github.com/jlandowner/helm-chartsnap)](https://goreportcard.com/report/github.com/jlandowner/helm-chartsnap)
[![codecov](https://codecov.io/gh/jlandowner/helm-chartsnap/graph/badge.svg?token=8ARG53CRL7)](https://codecov.io/gh/jlandowner/helm-chartsnap)
[![Workflow Status](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml)
[![CI](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml)
[![GitHub Marketplace](https://img.shields.io/badge/Marketplace-Helm%20chartsnap%20action-blue.svg?colorA=24292e&colorB=0366d6&style=flat&longCache=true&logo=github)](https://github.com/marketplace/actions/helm-chartsnap-action)

เครื่องมือทดสอบ Snapshot สำหรับ Helm charts

นำความสามารถการทดสอบ UI อันทรงพลังมาใช้กับ Helm chart ด้วยการตั้งค่าขั้นต่ำ เพียงแค่ภายในไฟล์ `values.yaml`

![screenshot](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/docs/screenshot.png)

## ภาพรวม
- [คุณสมบัติ 🔑](#คุณสมบัติ-)
- [ทำไมต้อง Snapshot Testing? 📸](#ทำไมต้อง-snapshot-testing-)
  - [แรงจูงใจ](#แรงจูงใจ)
- [การติดตั้ง 🚀](#การติดตั้ง-)
- [การใช้งาน](#การใช้งาน)
  - [การจัดการค่าที่เปลี่ยนแปลงแบบไดนามิก 💪](#การจัดการค่าที่เปลี่ยนแปลงแบบไดนามิก-)
- [ตัวอย่าง & ผู้ใช้งาน ✨](#ตัวอย่าง--ผู้ใช้งาน-)


## คุณสมบัติ 🔑

* **การทดสอบ Snapshot ที่ง่ายและเข้าใจง่ายสำหรับนักพัฒนา Helm**
  
  - **ไม่ต้องใช้รูปแบบไฟล์ TestSuite เฉพาะของเครื่องมือ**: แตกต่างจากเครื่องมือบางตัวที่ต้องสร้าง TestSuite แยกต่างหากด้วยรูปแบบไฟล์เฉพาะ เครื่องมือนี้ไม่ต้องการรูปแบบไฟล์เพิ่มเติมใด ๆ แค่เตรียมไฟล์ `values.yaml` มาตรฐานในแต่ละกรณีทดสอบ ลดภาระในการเรียนรู้รูปแบบใหม่และทำให้การทดสอบง่ายขึ้น

* **ปรับแต่งมาเพื่อ Helm chart โดยเฉพาะ**

  - **จัดการ output แบบไดนามิกที่สร้างโดย helm functions**: สามารถระบุ property เพิ่มเติมในไฟล์ values.yaml สำหรับแต่ละกรณีทดสอบ เพื่อความยืดหยุ่นในการปรับพฤติกรรมการทดสอบ เช่น ควบคุม output ที่สร้างแบบไดนามิกโดย helm functions เช่น [randAlphaNum](https://helm.sh/docs/chart_template_guide/function_list/)

* **ทดสอบ Snapshot อย่างต่อเนื่อง**

  - **[GitHub Action](https://github.com/jlandowner/helm-chartsnap-action) พร้อมใช้งาน**: มี GitHub action สำหรับทดสอบ snapshot ของ Helm charts ทั้งในเครื่องหรือรีโมทใน CI ได้อย่างต่อเนื่อง 🚀 -> [`helm-chart-action`](https://github.com/jlandowner/helm-chartsnap-action)

## ทำไมต้อง Snapshot Testing? 📸

เชื่อว่าการทดสอบแบบ snapshot ซึ่งเป็นแนวทางยอดนิยมใน Web หรือ UI testing ด้วยเครื่องมืออย่าง Jest คือวิธีที่ดีที่สุดในการทดสอบ Helm charts โดย Snapshot testing มีข้อดีหลายประการ:

- **เปรียบเทียบภาพรวมได้ง่าย:** การทดสอบ snapshot สร้าง baseline output แล้วเปรียบเทียบกับผลลัพธ์การทดสอบครั้งต่อไป ทำให้สามารถตรวจสอบการเปลี่ยนแปลงและ regression ในการ render ของ Helm chart ได้ง่าย

- **ดูแลรักษาง่ายขึ้น:** Snapshot testing ทำให้ขั้นตอนการตั้งค่าการทดสอบง่ายขึ้น เหมาะอย่างยิ่งเมื่อจัดการ Helm chart ที่ซับซ้อน อินพุตของ Helm chart คือการรวมค่าต่าง ๆ แค่ดูแลรักษาชุดค่าที่สมมติ(=values.yaml) และ snapshot ของพวกมัน

- **ทดสอบอย่างต่อเนื่อง:** การ snapshot Helm chart ในกระบวนการ CI ทำให้ตรวจพบการเปลี่ยนแปลงใน chart ทั้งหมดได้อย่างรวดเร็วและป้องกัน regression

ข้อดีเหล่านี้ไม่จำกัดแค่ Helm chart ที่คุณสร้างเอง แต่ยังรวมถึง chart ของ third-party ที่ติดตั้งบน Kubernetes ของคุณในฐานะผู้ดูแลระบบ Kubernetes เมื่ออัปเกรดคลัสเตอร์จะเห็นการเปลี่ยนแปลงใน manifest ที่สร้างจาก *values* ของคุณ ไม่ว่าจะเล็กน้อยแค่ไหนก็ตาม

### แรงจูงใจ

มีเครื่องมือสำหรับทดสอบ Helm ที่รองรับ snapshot tests อยู่แล้ว
- [helm-unittest](https://github.com/helm-unittest/helm-unittest) เป็น unit test ยอดนิยม มีตัวเลือกสำหรับ [snapshot testing](https://github.com/helm-unittest/helm-unittest#snapshot-testing)
- [terratest](https://terratest.gruntwork.io/) ทดสอบโค้ดโครงสร้างพื้นฐานแบบอัตโนมัติ เขียนเทสต์ด้วย Go และมีฟีเจอร์ทดสอบ output ของ Helm [blog post](https://blog.gruntwork.io/automated-testing-for-kubernetes-and-helm-charts-using-terratest-a4ddc4e67344)

> เครื่องมือทดสอบ Helm อย่างเป็นทางการ [`ct`](https://github.com/helm/chart-testing) ไม่ใช่สำหรับ unit test หรือ snapshot test แต่ใช้สำหรับ lint และ integration test

แม้เครื่องมือเหล่านี้จะมีประโยชน์สำหรับการทดสอบ Helm charts แต่ก็มีข้อจำกัดบางประการสำหรับ snapshot testing

- ต้องเรียนรู้และเตรียมไฟล์ Test Suite ของเครื่องมือ แม้จะต้องการแค่ snapshot testing

- ไม่ได้ snapshot ทั้ง chart โดยค่าเริ่มต้น แต่ถูกออกแบบให้ทดสอบเป็นรายไฟล์ภายใน Helm chart

- ไม่รองรับ output แบบไดนามิกของ Helm function

helm-unittest ถูกออกแบบให้ทดสอบเป็นรายไฟล์ภายใน Helm chart หมายความว่า เมื่อค่าใน Helm chart หรือเงื่อนไขนำไปสู่การมีหรือไม่มีไฟล์ทั้งไฟล์ จะส่งผลให้การทดสอบครอบคลุมไม่ครบในบางสถานการณ์สำคัญ

ตัวอย่างไฟล์สเปคสำหรับ snapshot testing ใน helm-unittest

> https://github.com/helm-unittest/helm-unittest#snapshot-testing
> 
> ```yaml
> templates:
>   - templates/deployment.yaml
> tests:
>   - it: pod spec should match snapshot
>     asserts:
>       - matchSnapshot:
>           path: spec.template.spec
>   # or you can snapshot the whole manifest
>   - it: manifest should match snapshot
>     asserts:
>       - matchSnapshot: {}
> ```

ตัวอย่างเช่น ในสถานการณ์ที่ Helm chart อาจสร้าง resource `Certificate` ของ `cert-manager` เมื่อทั้ง TLS และ cert-manager ถูกเปิดใช้งาน แต่หาก cert-manager ไม่เปิดใช้งานจะสร้าง TLS `Secret` แบบ self-signed ด้วย helm function [`genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#genselfsignedcert) และไม่ว่ามี TLS หรือไม่จะมีผลกับ property ต่าง ๆ ของ Ingress, Deployment เป็นต้น

ในกรณีนี้ helm-unittest อาจไม่สามารถทดสอบพฤติกรรมของ chart ได้ครบถ้วน เพราะ output ของไฟล์เงื่อนไขเหล่านี้อาจว่างเปล่า ทำให้ทดสอบไม่สมบูรณ์

แต่สำหรับ `helm-chartsnap` แค่เตรียมไฟล์ `values.yaml` ของ pattern ที่คาดหวังไว้ก็เพียงพอ 😊

## การติดตั้ง 🚀

สามารถติดตั้งเป็นปลั๊กอินของ Helm ได้

```sh
helm plugin install https://github.com/jlandowner/helm-chartsnap
```

ทางเลือกอื่น:

- ติดตั้งผ่าน Go

  ```sh
  go install github.com/jlandowner/helm-chartsnap@latest
  ```

- [ดาวน์โหลด release binary](https://github.com/jlandowner/helm-chartsnap/releases)

## การใช้งาน

เพียงส่ง chart ของคุณเพื่อเริ่มต้นอย่างรวดเร็ว

```
helm chartsnap -c YOUR_CHART
```

ไดเรกทอรี `__snapshot__` จะถูกสร้างขึ้นในไดเรกทอรีของ chart และไฟล์ `default.snap` จะถูกสร้างขึ้น

นอกจากนี้ยังสามารถสร้างกรณีทดสอบเป็น variation ของไฟล์ Values ใน chart ของคุณ

นี่คือตัวอย่างการใช้งานคำสั่งทั้งหมด

```sh
Usage:
  chartsnap -c CHART [flags]

Examples:

  # Snapshot ด้วยค่าเริ่มต้น:
  chartsnap -c YOUR_CHART
  
  # อัปเดต snapshot files:
  chartsnap -c YOUR_CHART -u

  # Snapshot ด้วยค่า values ทดสอบ:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE
  
  # Snapshot ทุกกรณีทดสอบ:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILES_DIRECTOY
  
  # ตั้งค่า args หรือ flags เพิ่มเติมให้คำสั่ง 'helm template':
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE -- --skip-tests

  # Snapshot chart รีโมทใน Helm repository:
  chartsnap -c CHART_NAME -f YOUR_VALUES_FILE -- --repo HELM_REPO_URL

  # Snapshot ingress-nginx (https://kubernetes.github.io/ingress-nginx/) helm chart สำหรับเวอร์ชันที่ต้องการด้วยไฟล์ value ของคุณ:
  chartsnap -c ingress-nginx -f YOUR_VALUES_FILE -- --repo https://kubernetes.github.io/ingress-nginx --namespace kube-system --version 4.8.3

  # Snapshot cilium (https://cilium.io) helm chart ด้วยค่าเริ่มต้นและตั้งค่า flags:
  chartsnap -c cilium -- --repo https://helm.cilium.io --namespace kube-system --set hubble.relay.enabled=true --set hubble.ui.enabled=true

  # Snapshot charts ใน OCI registry
  chartsnap -c oci://ghcr.io/nginxinc/charts/nginx-gateway-fabric -n nginx-gateway

  # แสดงผลลัพธ์แบบไม่มีสี:
  NO_COLOR=1 chartsnap -c YOUR_CHART

Flags:
  -c, --chart string              path ไปยังไดเรกทอรีของ chart. flag นี้จะถูกส่งไปยัง 'helm template RELEASE_NAME CHART --values VALUES' เป็น 'CHART'
      --config-file string        ชื่อหรือ path ของ config file ที่กำหนดพฤติกรรม snapshot เช่น dynamic fields (ค่าดีฟอลต์ ".chartsnap.yaml")
  -N, --ctx-lines int             จำนวนบรรทัดที่จะแสดงในผล diff. 0 เพื่อแสดงทั้งหมด (ค่าดีฟอลต์ 3)
      --debug                     โหมดดีบัก
      --fail-helm-error           ล้มเหลวหากคำสั่ง 'helm template' ผิดพลาด
      --failfast                  หยุดทันทีหากกรณีทดสอบใดล้มเหลว
  -h, --help                      แสดงความช่วยเหลือสำหรับ chartsnap
  -n, --namespace string          namespace. flag นี้จะถูกส่งไปยัง 'helm template RELEASE_NAME CHART --values VALUES --namespace NAMESPACE' เป็น 'NAMESPACE' (ค่าดีฟอลต์ "default")
  -o, --output-dir string         ไดเรกทอรีที่สร้างไดเรกทอรี __snapshot__. (ค่าดีฟอลต์: ไดเรกทอรีของ values file หากตั้งค่า --values; ไดเรกทอรีของ chart หากเป็น local; มิฉะนั้นคือไดเรกทอรีปัจจุบัน)
      --parallelism int           จำนวนเทสต์พร้อมกันหาก snapshot หลายไฟล์จากไดเรกทอรี values. ดีฟอลต์ไม่จำกัด (ค่าดีฟอลต์ -1)
      --release-name string       release name. flag นี้จะถูกส่งไปยัง 'helm template RELEASE_NAME CHART --values VALUES' เป็น 'RELEASE_NAME' (ค่าดีฟอลต์ "chartsnap")
      --snapshot-version string   ใช้ snapshot format version ที่ระบุ v1, v2, v3 รองรับ (ค่าดีฟอลต์: ล่าสุด)
  -u, --update-snapshot           โหมดอัปเดต snapshot
  -f, --values string             path ไปยังไฟล์ values ทดสอบหรือไดเรกทอรี. หากเป็นไดเรกทอรีจะทดสอบทุกไฟล์. ถ้าว่างจะใช้ค่าเริ่มต้น flag นี้จะถูกส่งไปยัง 'helm template RELEASE_NAME CHART --values VALUES' เป็น 'VALUES'
  -v, --version                   แสดงเวอร์ชันของ chartsnap

```

### การจัดการค่าที่เปลี่ยนแปลงแบบไดนามิก 💪

Helm มีฟีเจอร์ "Helm functions" ที่สร้างค่าที่สุ่มหรือใบรับรอง self-signed เช่น [`randAlphaNum`](https://helm.sh/docs/chart_template_guide/function_list/#randalphanum-randalpha-randnumeric-and-randascii) และ [`genCA`, `genPrivateKey`, `genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#cryptographic-and-security-functions)

เมื่อใช้ฟังก์ชันเหล่านี้ output จะเปลี่ยนทุกครั้งที่ Helm ทำงาน
สำหรับกรณีนี้ chartsnap มีฟีเจอร์ที่ป้องกัน snapshot mismatch โดยแทนค่าด้วยค่า fix คือ `###DYNAMIC_FIELD###`

สามารถระบุ path ของค่าที่เปลี่ยนแปลงใน YAML ที่สร้างขึ้นโดยใช้ [JSONPath](https://datatracker.ietf.org/doc/html/rfc6901)

```yaml:.chartsnap.yaml
dynamicFields:
  - apiVersion: v1
    kind: Secret
    name: cosmo-auth-env
    jsonPath:
      - /data/COOKIE_HASHKEY
      - /data/COOKIE_BLOCKKEY
      - /data/COOKIE_HASHKEY
      - /data/COOKIE_SESSION_NAME
    base64: true
```

> หมายเหตุ:
> ใน JSONPath การ escape อักขระ / ถูกอธิบายไว้ใน [RFC6901, section 3](https://datatracker.ietf.org/doc/html/rfc6901#section-3)
> ```
>    เพราะอักขระ '~' (%x7E) และ '/' (%x2F) มีความหมายพิเศษใน JSON Pointer
>    '~' ต้องถูกเข้ารหัสเป็น '~0' และ '/' เป็น '~1' เมื่อปรากฏใน reference token
> ```
>
> ดังนั้นหากต้องจัดการ manifest เช่นด้านล่าง ต้องระบุ json path เป็น `/metadata/annotaions/checksum~1values`
> 
> ```yaml
> metadata:
>   annotations:
>     checksum/values: RANDOM_VALUES
> ```

หากมีไดเรกทอรีของไฟล์ values ทดสอบ ให้วาง `.chartsnap.yaml` ในไดเรกทอรีนั้น จะส่งผลกับ snapshot test ทั้งหมดในไดเรกทอรี

ดูตัวอย่างเพิ่มเติมที่ [example/app1](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1)

หรือสามารถเพิ่ม config ตรงในไฟล์ values ทดสอบ ด้วย property `testSpec`
ในกรณีนี้ไม่ต้องเตรียม `.chartsnap.yaml` เหมาะสำหรับ snapshot ของ remote หรือ third-party chart ด้วยไฟล์ values เดียว

ไฟล์ values ของคุณอาจมีลักษณะดังนี้:

```yaml
# เพิ่ม property นี้ใน values ของคุณ
testSpec:
  dynamicFields:
    - apiVersion: v1
      kind: Secret
      name: cilium-ca
      jsonPath:
        - /data/ca.crt
        - /data/ca.key
      base64: true
    - apiVersion: v1
      kind: Secret
      name: hubble-server-certs
      jsonPath:
        - /data/ca.crt
        - /data/tls.crt
        - /data/tls.key
      base64: true
    - apiVersion: v1
      kind: Secret
      name: hubble-relay-client-certs
      jsonPath:
        - /data/ca.crt
        - /data/tls.crt
        - /data/tls.key
      base64: true

# อื่น ๆ คือค่า values ปกติของ chart คุณ
# ...
```

ดูตัวอย่างเพิ่มเติมที่ [example/remote](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote)

## ตัวอย่าง & ผู้ใช้งาน ✨

| Users / Projects | คำอธิบาย | URL |
|:---|:---|:---|
| Example | ตัวอย่าง chart ที่สร้างโดยคำสั่ง `helm create` | [`example/app1`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1) |
| Example | ตัวอย่าง snapshot chart ใน remote Helm repositories | [`example/remote`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote) |
| [helm-chartsnap-action](https://github.com/jlandowner/helm-chartsnap-action) | GitHub action สำหรับใช้ helm chartsnap ใน CI | https://github.com/jlandowner/helm-chartsnap-action |
| [cosmo-workspace](https://github.com/cosmo-workspace/cosmo) | แพลตฟอร์ม WebIDE & DevEnvironment แบบ open source บน Kubernetes | https://github.com/cosmo-workspace/cosmo/tree/main/charts/cosmo/test |
| [Kong](https://github.com/Kong/kong) | 🦍 เกตเวย์ API และ AI แบบ Cloud-Native | https://github.com/Kong/charts |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---