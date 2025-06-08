# Node HL7 Client

> A pure TypeScript HL7 client for Node.js enabling seamless communication with HL7 servers.

`node-hl7-client` is a lightweight, dependency-free library built for high-performance communication with HL7 brokers/servers. It supports sending properly formatted HL7 messages, handling responses, and working with both single and batched HL7 message formats (MSH, BHS, and FHS).

## ✨ Features

* ⚡ **Zero External Dependencies** – Ultra-fast performance with no bloat.
* 🔁 **Auto Reconnect & Retry** – Automatically handles connection interruptions.
* 🧠 **TypeScript + Typed Definitions** – Fully typed for modern development environments.
* 🤝 **Companion Package Available** – Use alongside [`node-hl7-server`](https://www.npmjs.com/package/node-hl7-server) for a complete HL7 solution.
* 💻 **Cross-Platform Support** – Works on Windows, macOS, and Linux.
* 🧭 **Standards-Based** – Typed builders ensure MSH, BHS, and FHS segments follow HL7.org specifications.

## 📦 Install

```bash
npm install node-hl7-client
```

## 📚 What's Included?

* **HL7 Client** – Connects to a remote HL7 server, sends messages, and processes responses.
* **HL7 Parser** – Parses raw HL7 message strings into accessible segments.
* **HL7 Builder** – Builds valid HL7 messages, batches, or complete HL7 batch files.

## 🧾 Table of Contents

1. [Keyword Definitions](#keyword-definitions)
2. [Documentation](#documentation)
3. [Acknowledgements](#acknowledgements)
4. [License](#license)

## Keyword Definitions

This NPM package is designed to support medical applications with potential impact on patient care and diagnoses. This documentation, along with its peer package [node-hl7-server](https://www.npmjs.com/package/node-hl7-server), uses the following standardized definitions for clarity and interoperability:

Keywords such as **"MUST"**, **"MUST NOT"**, **"REQUIRED"**, **"SHALL"**, **"SHALL NOT"**, **"SHOULD"**, **"SHOULD NOT"**, **"RECOMMENDED"**, **"MAY"**, and **"OPTIONAL"** are used consistently throughout the documentation. These terms retain their meaning even when not capitalized.

* **MUST** – This word, or the terms **"REQUIRED"** or **"SHALL"**, indicates an absolute requirement of the specification.
* **MUST NOT** – This phrase, or the phrase **"SHALL NOT"**, indicates an absolute prohibition of the specification.
* **SHOULD** – This word, or the adjective **"RECOMMENDED"**, means that there may be valid reasons in particular circumstances to ignore a particular item, but the full implications must be understood and carefully weighed before doing so.
* **SHOULD NOT** – This phrase, or the phrase **"NOT RECOMMENDED"**, means that there may be valid reasons in particular circumstances when the behavior is acceptable or even useful. The full implications should be understood and the case carefully weighed before implementation.
* **MAY** – This word, or the adjective **"OPTIONAL"**, means that the item is truly optional. Implementations that do not include a particular option MUST still interoperate with those that do, though possibly with reduced functionality. Likewise, implementations that include an option MUST interoperate with those that do not (except, of course, for the specific feature provided by the option).

## 📖 Documentation

Full API documentation, usage examples, and advanced configurations are available on the project site:
🔗 [https://bugs5382.github.io/node-hl7-client/](https://bugs5382.github.io/node-hl7-client/)

## 🙏 Acknowledgements

* [`node-rabbitmq-client`](https://github.com/cody-greene/node-rabbitmq-client) – Connection logic inspiration.
* [`artifacthealth/hl7parser`](https://github.com/artifacthealth/hl7parser) – Design reference for parser and builder.
* My wife and baby girl – for their love, patience, and inspiration.


## 📄 License

MIT © [LICENSE](https://raw.githubusercontent.com/Bugs5382/node-hl7-client/main/LICENSE)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---