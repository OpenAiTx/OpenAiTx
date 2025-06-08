# Node HL7 Client

> Um cliente HL7 puro em TypeScript para Node.js, permitindo comunicação perfeita com servidores HL7.

`node-hl7-client` é uma biblioteca leve e sem dependências externas, construída para comunicação de alto desempenho com brokers/servidores HL7. Suporta o envio de mensagens HL7 devidamente formatadas, tratamento de respostas e trabalha tanto com formatos de mensagens HL7 individuais quanto em lote (MSH, BHS e FHS).

## ✨ Funcionalidades

* ⚡ **Zero Dependências Externas** – Desempenho ultrarrápido sem inchaço.
* 🔁 **Reconexão e Retentativa Automáticas** – Gerencia automaticamente interrupções de conexão.
* 🧠 **TypeScript + Tipagens** – Totalmente tipado para ambientes de desenvolvimento modernos.
* 🤝 **Pacote Companheiro Disponível** – Use juntamente com [`node-hl7-server`](https://www.npmjs.com/package/node-hl7-server) para uma solução HL7 completa.
* 💻 **Suporte Multiplataforma** – Funciona no Windows, macOS e Linux.
* 🧭 **Baseado em Padrões** – Construtores tipados garantem que os segmentos MSH, BHS e FHS sigam as especificações do HL7.org.

## 📦 Instalação

```bash
npm install node-hl7-client
```

## 📚 O que está incluído?

* **Cliente HL7** – Conecta-se a um servidor HL7 remoto, envia mensagens e processa respostas.
* **Parser HL7** – Analisa strings de mensagens HL7 brutas em segmentos acessíveis.
* **Builder HL7** – Constrói mensagens HL7 válidas, lotes ou arquivos completos de lote HL7.

## 🧾 Índice

1. [Definições de Palavras-Chave](#keyword-definitions)
2. [Documentação](#documentation)
3. [Agradecimentos](#acknowledgements)
4. [Licença](#license)

## Definições de Palavras-Chave

Este pacote NPM foi projetado para suportar aplicações médicas com potencial impacto no cuidado e diagnóstico de pacientes. Esta documentação, juntamente com seu pacote complementar [node-hl7-server](https://www.npmjs.com/package/node-hl7-server), utiliza as seguintes definições padronizadas para clareza e interoperabilidade:

Palavras-chave como **"DEVE"**, **"NÃO DEVE"**, **"OBRIGATÓRIO"**, **"SERÁ"**, **"NÃO SERÁ"**, **"DEVERIA"**, **"NÃO DEVERIA"**, **"RECOMENDADO"**, **"PODE"** e **"OPCIONAL"** são usadas de forma consistente ao longo da documentação. Estes termos mantêm seu significado mesmo quando não estão em letras maiúsculas.

* **DEVE** – Esta palavra, ou os termos **"OBRIGATÓRIO"** ou **"SERÁ"**, indica um requisito absoluto da especificação.
* **NÃO DEVE** – Esta expressão, ou a expressão **"NÃO SERÁ"**, indica uma proibição absoluta da especificação.
* **DEVERIA** – Esta palavra, ou o adjetivo **"RECOMENDADO"**, significa que pode haver razões válidas em circunstâncias particulares para ignorar um determinado item, mas todas as implicações devem ser compreendidas e cuidadosamente avaliadas antes de fazê-lo.
* **NÃO DEVERIA** – Esta expressão, ou a expressão **"NÃO RECOMENDADO"**, significa que pode haver razões válidas em circunstâncias particulares onde o comportamento é aceitável ou até mesmo útil. Todas as implicações devem ser compreendidas e o caso cuidadosamente avaliado antes da implementação.
* **PODE** – Esta palavra, ou o adjetivo **"OPCIONAL"**, significa que o item é realmente opcional. Implementações que não incluam uma determinada opção DEVEM ainda interoperar com aquelas que incluam, embora possivelmente com funcionalidade reduzida. Da mesma forma, implementações que incluam uma opção DEVEM interoperar com aquelas que não incluam (exceto, é claro, para o recurso específico fornecido pela opção).

## 📖 Documentação

Documentação completa da API, exemplos de uso e configurações avançadas estão disponíveis no site do projeto:
🔗 [https://bugs5382.github.io/node-hl7-client/](https://bugs5382.github.io/node-hl7-client/)

## 🙏 Agradecimentos

* [`node-rabbitmq-client`](https://github.com/cody-greene/node-rabbitmq-client) – Inspiração para a lógica de conexão.
* [`artifacthealth/hl7parser`](https://github.com/artifacthealth/hl7parser) – Referência de design para parser e builder.
* Minha esposa e minha filhinha – por seu amor, paciência e inspiração.


## 📄 Licença

MIT © [LICENSE](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---