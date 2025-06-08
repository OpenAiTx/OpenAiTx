# Node HL7 Client

> HL7 서버와의 원활한 통신을 가능하게 하는 순수 TypeScript 기반 Node.js HL7 클라이언트입니다.

`node-hl7-client`는 HL7 브로커/서버와의 고성능 통신을 위해 구축된 경량의 의존성 없는 라이브러리입니다. 적절히 포맷된 HL7 메시지 전송, 응답 처리, 단일 및 일괄 HL7 메시지 포맷(MSH, BHS, FHS) 지원을 제공합니다.

## ✨ 특징

* ⚡ **외부 의존성 제로** – 불필요한 요소 없이 초고속 성능.
* 🔁 **자동 재연결 및 재시도** – 연결 중단 시 자동으로 처리.
* 🧠 **TypeScript + 타입 정의** – 최신 개발 환경에 맞춘 완전한 타입 지원.
* 🤝 **동반 패키지 제공** – [`node-hl7-server`](https://www.npmjs.com/package/node-hl7-server)와 함께 사용하여 완벽한 HL7 솔루션 구축 가능.
* 💻 **크로스 플랫폼 지원** – Windows, macOS, Linux 모두에서 작동.
* 🧭 **표준 기반** – 타입 빌더로 MSH, BHS, FHS 세그먼트가 HL7.org 사양을 준수하도록 보장.

## 📦 설치

```bash
npm install node-hl7-client
```

## 📚 포함 내용

* **HL7 클라이언트** – 원격 HL7 서버에 연결, 메시지 전송, 응답 처리.
* **HL7 파서** – 원시 HL7 메시지 문자열을 접근 가능한 세그먼트로 파싱.
* **HL7 빌더** – 유효한 HL7 메시지, 배치, 전체 HL7 배치 파일 생성.

## 🧾 목차

1. [용어 정의](#keyword-definitions)
2. [문서](#documentation)
3. [감사의 말](#acknowledgements)
4. [라이선스](#license)

## 용어 정의

이 NPM 패키지는 환자 치료 및 진단에 영향을 줄 수 있는 의료 애플리케이션을 지원하도록 설계되었습니다. 본 문서와 동반 패키지 [node-hl7-server](https://www.npmjs.com/package/node-hl7-server)에서는 명확성과 상호운용성을 위해 다음과 같은 표준화된 정의를 사용합니다:

**"MUST"**, **"MUST NOT"**, **"REQUIRED"**, **"SHALL"**, **"SHALL NOT"**, **"SHOULD"**, **"SHOULD NOT"**, **"RECOMMENDED"**, **"MAY"**, **"OPTIONAL"** 등의 키워드는 문서 전반에 걸쳐 일관되게 사용됩니다. 이 용어들은 대문자가 아니어도 동일한 의미를 가집니다.

* **MUST** – 이 단어나 **"REQUIRED"**, **"SHALL"**은 명세의 절대적 요구사항임을 의미합니다.
* **MUST NOT** – 이 문구나 **"SHALL NOT"**은 명세상 절대적으로 금지함을 의미합니다.
* **SHOULD** – 이 단어나 **"RECOMMENDED"**는 특정 상황에서 예외가 있을 수 있으나, 그 결과를 충분히 이해하고 신중히 고려해야 함을 의미합니다.
* **SHOULD NOT** – 이 문구나 **"NOT RECOMMENDED"**는 특정 상황에서 허용되거나 유용할 수 있으나, 충분한 이해와 신중한 검토가 필요함을 의미합니다.
* **MAY** – 이 단어나 **"OPTIONAL"**은 해당 항목이 진정으로 선택 사항임을 의미합니다. 특정 옵션을 포함하지 않는 구현도 포함하는 구현과 상호운용해야 하며(기능은 제한될 수 있음), 반대로 옵션을 포함하는 구현도 포함하지 않는 구현과 상호운용해야 합니다(물론 해당 옵션이 제공하는 특정 기능은 예외임).

## 📖 문서

전체 API 문서, 사용 예제, 고급 설정 등은 프로젝트 사이트에서 확인할 수 있습니다:  
🔗 [https://bugs5382.github.io/node-hl7-client/](https://bugs5382.github.io/node-hl7-client/)

## 🙏 감사의 말

* [`node-rabbitmq-client`](https://github.com/cody-greene/node-rabbitmq-client) – 연결 로직 영감 제공.
* [`artifacthealth/hl7parser`](https://github.com/artifacthealth/hl7parser) – 파서 및 빌더 설계 참고.
* 사랑과 인내, 영감을 준 아내와 딸에게.

## 📄 라이선스

MIT © [LICENSE](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---