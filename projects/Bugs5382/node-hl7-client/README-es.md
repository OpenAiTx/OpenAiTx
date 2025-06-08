# Node HL7 Client

> Un cliente HL7 puro en TypeScript para Node.js que permite una comunicación fluida con servidores HL7.

`node-hl7-client` es una biblioteca ligera y sin dependencias externas, creada para comunicación de alto rendimiento con brokers/servidores HL7. Soporta el envío de mensajes HL7 correctamente formateados, el manejo de respuestas y el trabajo con formatos de mensajes HL7 individuales y por lotes (MSH, BHS y FHS).

## ✨ Características

* ⚡ **Sin Dependencias Externas** – Rendimiento ultrarrápido sin sobrecarga.
* 🔁 **Reconexión y Reintentos Automáticos** – Gestiona automáticamente las interrupciones de conexión.
* 🧠 **TypeScript + Definiciones Tipadas** – Totalmente tipado para entornos de desarrollo modernos.
* 🤝 **Paquete Complementario Disponible** – Úsalo junto con [`node-hl7-server`](https://www.npmjs.com/package/node-hl7-server) para una solución HL7 completa.
* 💻 **Compatibilidad Multiplataforma** – Funciona en Windows, macOS y Linux.
* 🧭 **Basado en Estándares** – Los constructores tipados aseguran que los segmentos MSH, BHS y FHS sigan las especificaciones de HL7.org.

## 📦 Instalación

```bash
npm install node-hl7-client
```

## 📚 ¿Qué incluye?

* **Cliente HL7** – Se conecta a un servidor HL7 remoto, envía mensajes y procesa respuestas.
* **Analizador HL7** – Analiza cadenas de mensajes HL7 en segmentos accesibles.
* **Constructor HL7** – Construye mensajes HL7 válidos, lotes o archivos completos de lotes HL7.

## 🧾 Tabla de Contenidos

1. [Definiciones de Palabras Clave](#keyword-definitions)
2. [Documentación](#documentation)
3. [Agradecimientos](#acknowledgements)
4. [Licencia](#license)

## Definiciones de Palabras Clave

Este paquete NPM está diseñado para soportar aplicaciones médicas con impacto potencial en la atención y diagnóstico de pacientes. Esta documentación, junto con su paquete complementario [node-hl7-server](https://www.npmjs.com/package/node-hl7-server), utiliza las siguientes definiciones estandarizadas para claridad e interoperabilidad:

Palabras clave como **"DEBE"**, **"NO DEBE"**, **"REQUERIDO"**, **"TENDRÁ"**, **"NO TENDRÁ"**, **"DEBERÍA"**, **"NO DEBERÍA"**, **"RECOMENDADO"**, **"PUEDE"** y **"OPCIONAL"** se utilizan de manera consistente a lo largo de la documentación. Estos términos mantienen su significado incluso cuando no están en mayúsculas.

* **DEBE** – Esta palabra, o los términos **"REQUERIDO"** o **"TENDRÁ"**, indica un requisito absoluto de la especificación.
* **NO DEBE** – Esta frase, o la frase **"NO TENDRÁ"**, indica una prohibición absoluta de la especificación.
* **DEBERÍA** – Esta palabra, o el adjetivo **"RECOMENDADO"**, significa que puede haber razones válidas en circunstancias particulares para ignorar un elemento específico, pero se deben comprender y sopesar cuidadosamente todas las implicaciones antes de hacerlo.
* **NO DEBERÍA** – Esta frase, o la frase **"NO RECOMENDADO"**, significa que puede haber razones válidas en circunstancias particulares en las que el comportamiento sea aceptable o incluso útil. Se deben comprender las implicaciones completas y sopesar cuidadosamente el caso antes de su implementación.
* **PUEDE** – Esta palabra, o el adjetivo **"OPCIONAL"**, significa que el elemento es realmente opcional. Las implementaciones que no incluyan una opción en particular DEBEN seguir interoperando con aquellas que sí lo hacen, aunque posiblemente con funcionalidad reducida. Asimismo, las implementaciones que incluyan una opción DEBEN interoperar con aquellas que no la incluyen (excepto, por supuesto, por la característica específica que proporciona la opción).

## 📖 Documentación

La documentación completa de la API, ejemplos de uso y configuraciones avanzadas están disponibles en el sitio del proyecto:
🔗 [https://bugs5382.github.io/node-hl7-client/](https://bugs5382.github.io/node-hl7-client/)

## 🙏 Agradecimientos

* [`node-rabbitmq-client`](https://github.com/cody-greene/node-rabbitmq-client) – Inspiración para la lógica de conexión.
* [`artifacthealth/hl7parser`](https://github.com/artifacthealth/hl7parser) – Referencia de diseño para el analizador y el constructor.
* Mi esposa y mi hija – por su amor, paciencia e inspiración.

## 📄 Licencia

MIT © [LICENSE](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---