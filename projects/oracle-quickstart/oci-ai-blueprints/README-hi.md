# OCI AI ब्लूप्रिंट्स

**OCI AI ब्लूप्रिंट्स प्लेटफ़ॉर्म के साथ AI वर्कलोड को डिप्लॉय, स्केल और मॉनिटर करें, और अपने GPU ऑनबोर्डिंग समय को हफ्तों से मिनटों में कम करें।**

OCI AI ब्लूप्रिंट्स एक सुव्यवस्थित, नो-कोड समाधान है जो Kubernetes Engine (OKE) पर जनरेटिव AI वर्कलोड को डिप्लॉय और प्रबंधित करने के लिए बनाया गया है। यह हार्डवेयर की सुझाई गई सिफारिशें, प्री-पैकेज्ड सॉफ़्टवेयर स्टैक्स, और आउट-ऑफ-द-बॉक्स ऑब्ज़र्वेबिलिटी टूलिंग प्रदान करता है, जिससे आप अपने AI एप्लिकेशन को जल्दी और कुशलता से चला सकते हैं—बिना इंफ्रास्ट्रक्चर निर्णयों, सॉफ़्टवेयर संगतता, और MLOps सर्वोत्तम प्रथाओं की जटिलताओं से जूझे।

[![OCI AI ब्लूप्रिंट्स इंस्टॉल करें](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)

## विषय सूची

**शुरुआत करें**

- [AI ब्लूप्रिंट्स इंस्टॉल करें](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)
- [AI ब्लूप्रिंट्स पोर्टल और API एक्सेस करें](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/usage_guide.md)

**OCI AI ब्लूप्रिंट्स के बारे में**

- [OCI AI ब्लूप्रिंट्स क्या है?](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [OCI AI ब्लूप्रिंट्स क्यों उपयोग करें?](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [विशेषताएँ](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [ब्लूप्रिंट्स की सूची](#blueprints)
- [FAQ](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [सहायता और संपर्क](https://github.com/oracle-quickstart/oci-ai-blueprints/blob/vkammari/doc_improvements/docs/about/README.md#frequently-asked-questions-faq)

**API संदर्भ**

- [API संदर्भ दस्तावेज़](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/api_documentation.md)

**अतिरिक्त संसाधन**

- [कस्टम ब्लूप्रिंट्स प्रकाशित करें](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/custom_blueprints)
- [अपडेट्स इंस्टॉल करना](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/installing_new_updates.md)
- [IAM नीतियाँ](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/iam_policies.md)
- [रिपॉजिटरी सामग्री](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [ज्ञात समस्याएँ](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/known_issues.md)

## शुरुआत करें

नीचे दिए गए बटन पर क्लिक करके OCI AI ब्लूप्रिंट्स इंस्टॉल करें:

[![OCI AI ब्लूप्रिंट्स इंस्टॉल करें](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)

## ब्लूप्रिंट्स

ब्लूप्रिंट्स साधारण टेराफ़ॉर्म टेम्प्लेट्स से कहीं आगे जाते हैं। प्रत्येक ब्लूप्रिंट:

- प्रमाणित हार्डवेयर सुझाव प्रदान करता है (जैसे, उपयुक्त शेप्स, CPU/GPU कॉन्फ़िगरेशन),
- विभिन्न जनरेटिव AI उपयोग मामलों के लिए कस्टमाइज्ड एंड-टू-एंड एप्लिकेशन स्टैक्स शामिल करता है, और
- मॉनिटरिंग, लॉगिंग, और ऑटो-स्केलिंग पहले से ही कॉन्फ़िगर की हुई आती है।

जब आप OCI AI ब्लूप्रिंट्स को अपनी टेनेंसी के OKE क्लस्टर में इंस्टॉल कर लेते हैं, तो आप इन प्री-बिल्ट ब्लूप्रिंट्स को डिप्लॉय कर सकते हैं:

| ब्लूप्रिंट                                                                                      | विवरण                                                                                                                                           |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------- |
| [**LLM & VLM Inference with vLLM**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/llm_inference_with_vllm/README.md) | NVIDIA GPU शेप्स और vLLM इंफरेंस इंजन के साथ Llama 2/3/3.1 7B/8B मॉडल्स को ऑटो-स्केलिंग के साथ डिप्लॉय करें।               |
| [**Fine-Tuning Benchmarking**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/lora-benchmarking) | MLCommons क्वांटाइज़्ड Llama-2 70B LoRA फाइनट्यूनिंग को A100 पर प्रदर्शन बेंचमार्किंग के लिए चलाएँ।                            |
| [**LoRA Fine-Tuning**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/lora-fine-tuning) | किसी भी डाटासेट के साथ कस्टम या HuggingFace मॉडल्स की LoRA फाइन-ट्यूनिंग। इसमें लचीला हाइपरपैरामीटर ट्यूनिंग शामिल है।       |
| [**Health Check**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/gpu-health-check) | GPU प्रदर्शन का व्यापक मूल्यांकन ताकि किसी भी भारी कंप्यूटेशनल वर्कलोड शुरू करने से पहले हार्डवेयर की तैयारियों की पुष्टि हो सके। |
| [**CPU Inference**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/cpu-inference) | Ollama का उपयोग करके Mistral, Gemma आदि जैसे मॉडल्स के साथ CPU-आधारित इंफरेंस का परीक्षण करें।                                 |
| [**Multi-node Inference with RDMA and vLLM**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/multi-node-inference/) | H100 नोड्स के साथ vLLM और LeaderWorkerSet का उपयोग करके RDMA के साथ कई नोड्स पर Llama-405B आकार के LLMs को डिप्लॉय करें।     |
| [**Autoscaling Inference with vLLM**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/auto_scaling/) | KEDA का उपयोग करके LLMs को ऑटो-स्केलिंग के साथ सर्व करें, जो इंफरेंस लेटेंसी जैसी एप्लिकेशन मेट्रिक्स के आधार पर कई GPUs और नोड्स तक स्केल करता है। |
| [**LLM Inference with MIG**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/mig_multi_instance_gpu/) | Nvidia के मल्टी-इंस्टेंस GPUs के साथ LLMs को GPU के एक अंश में डिप्लॉय करें और उन्हें vLLM के साथ सर्व करें।                  |
| [**Job Queuing**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/teams) | जॉब कतार का लाभ उठाएँ और टीमों के बीच संसाधन कोटा और उचित शेयरिंग लागू करें।                                                    |

## सहायता और संपर्क

यदि आपके पास कोई प्रश्न, समस्या या प्रतिक्रिया है, तो संपर्क करें [vishnu.kammari@oracle.com](mailto:vishnu.kammari@oracle.com) या [grant.neuman@oracle.com](mailto:grant.neuman@oracle.com)।

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---