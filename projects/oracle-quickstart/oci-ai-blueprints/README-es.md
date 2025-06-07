# OCI AI Blueprints

**Implemente, escale y monitorice cargas de trabajo de IA con la plataforma OCI AI Blueprints, y reduzca su tiempo de incorporación de GPU de semanas a minutos.**

OCI AI Blueprints es una solución simplificada y sin código para implementar y gestionar cargas de trabajo de IA generativa en Kubernetes Engine (OKE). Al proporcionar recomendaciones de hardware opinadas, pilas de software preempaquetadas y herramientas de observabilidad listas para usar, OCI AI Blueprints le ayuda a poner en marcha sus aplicaciones de IA de manera rápida y eficiente, sin tener que lidiar con la complejidad de las decisiones de infraestructura, la compatibilidad de software y las mejores prácticas de MLOps.

[![Instalar OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## Tabla de Contenidos

**Primeros Pasos**

- [Instalar AI Blueprints](./GETTING_STARTED_README.md)
- [Acceso al Portal y API de AI Blueprints](docs/usage_guide.md)

**Acerca de OCI AI Blueprints**

- [¿Qué es OCI AI Blueprints?](docs/about.md)
- [¿Por qué usar OCI AI Blueprints?](docs/about.md)
- [Características](docs/about.md)
- [Lista de Blueprints](#blueprints)
- [Preguntas Frecuentes (FAQ)](docs/about.md)
- [Soporte y Contacto](https://github.com/oracle-quickstart/oci-ai-blueprints/blob/vkammari/doc_improvements/docs/about/README.md#frequently-asked-questions-faq)

**Referencia de API**

- [Documentación de Referencia de API](docs/api_documentation.md)

**Recursos Adicionales**

- [Publicar Blueprints Personalizados](./docs/custom_blueprints)
- [Instalación de Actualizaciones](docs/installing_new_updates.md)
- [Políticas IAM](docs/iam_policies.md)
- [Contenido del Repositorio](docs/about.md)
- [Problemas Conocidos](docs/known_issues.md)

## Primeros Pasos

Instale OCI AI Blueprints haciendo clic en el botón de abajo:

[![Instalar OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## Blueprints

Los blueprints van más allá de las plantillas básicas de Terraform. Cada blueprint:

- Ofrece sugerencias de hardware validadas (por ejemplo, formas óptimas, configuraciones de CPU/GPU),
- Incluye pilas de aplicaciones de extremo a extremo personalizadas para diferentes casos de uso de GenAI, y
- Viene con monitoreo, registro y autoescalado configurados listos para usar.

Después de instalar OCI AI Blueprints en un clúster OKE en su tenencia, puede implementar estos blueprints preconstruidos:

| Blueprint                                                                                        | Descripción                                                                                                                           |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------- |
| [**LLM y VLM Inferencia con vLLM**](docs/sample_blueprints/llm_inference_with_vllm/README.md)    | Implemente modelos Llama 2/3/3.1 7B/8B usando formas de GPU NVIDIA y el motor de inferencia vLLM con autoescalado.                   |
| [**Benchmarking de Fine-Tuning**](./docs/sample_blueprints/lora-benchmarking)                    | Ejecute fine-tuning cuantizado de Llama-2 70B LoRA de MLCommons en A100 para benchmarking de rendimiento.                             |
| [**Fine-Tuning LoRA**](./docs/sample_blueprints/lora-fine-tuning)                                | Fine-tuning LoRA de modelos personalizados o de HuggingFace usando cualquier conjunto de datos. Incluye ajuste flexible de hiperparámetros. |
| [**Health Check**](./docs/sample_blueprints/gpu-health-check)                                    | Evaluación integral del rendimiento de la GPU para garantizar la preparación óptima del hardware antes de iniciar cualquier carga de trabajo computacional intensiva. |
| [**Inferencia en CPU**](./docs/sample_blueprints/cpu-inference)                                  | Aproveche Ollama para probar la inferencia basada en CPU con modelos como Mistral, Gemma y más.                                       |
| [**Inferencia multinodo con RDMA y vLLM**](./docs/sample_blueprints/multi-node-inference/)       | Implemente LLMs del tamaño Llama-405B en múltiples nodos con RDMA usando nodos H100 con vLLM y LeaderWorkerSet.                      |
| [**Inferencia con Autoescalado y vLLM**](./docs/sample_blueprints/auto_scaling/)                 | Sirva LLMs con autoescalado usando KEDA, que escala a múltiples GPUs y nodos utilizando métricas de aplicación como la latencia de inferencia. |
| [**Inferencia LLM con MIG**](./docs/sample_blueprints/mig_multi_instance_gpu/)                   | Implemente LLMs en una fracción de una GPU con GPUs multi-instancia de Nvidia y sírvalos con vLLM.                                   |
| [**Job Queuing**](./docs/sample_blueprints/teams)                                                | Aproveche la cola de trabajos y aplique cuotas de recursos y reparto justo entre equipos.                                             |

## Soporte y Contacto

Si tiene preguntas, problemas o comentarios, contacte a [vishnu.kammari@oracle.com](mailto:vishnu.kammari@oracle.com) o [grant.neuman@oracle.com](mailto:grant.neuman@oracle.com).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---