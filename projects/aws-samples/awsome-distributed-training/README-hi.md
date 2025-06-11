# ML प्रशिक्षण संदर्भ वास्तुकला और परीक्षण <!-- omit from toc -->

> **चेतावनी**
> हम वर्तमान में इस रिपॉजिटरी का एक बड़ा पुनर्गठन कर रहे हैं, विशेष रूप से परीक्षण मामलों के अनुभाग पर ध्यान केंद्रित करते हुए। यदि आप पिछली निर्देशिका संरचना और अव्यवस्थित परीक्षण मामलों का उपयोग करना पसंद करते हैं, तो कृपया [v1.1.0](https://github.com/aws-samples/awsome-distributed-training/releases/tag/v1.1.0) देखें।


यह रिपॉजिटरी [Amazon SageMaker Hyperpod](https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html), [AWS ParallelCluster](https://docs.aws.amazon.com/parallelcluster/latest/ug/what-is-aws-parallelcluster.html), [AWS Batch](https://docs.aws.amazon.com/batch/latest/userguide/what-is-batch.html), और [Amazon EKS](https://docs.aws.amazon.com/eks/latest/userguide/getting-started-console.html) के साथ वितरित मॉडल प्रशिक्षण के लिए संदर्भ वास्तुकला और परीक्षण मामलों को शामिल करता है। परीक्षण मामले विभिन्न प्रकार और आकार के मॉडलों के साथ-साथ विभिन्न फ्रेमवर्क और समानांतर अनुकूलन (Pytorch DDP/FSDP, MegatronLM, NemoMegatron...) को कवर करते हैं।

इस निर्देशिका के प्रमुख घटक हैं:

```bash
reference-architectures/
|-- 1.architectures/               # संदर्भ वास्तुकला के लिए क्लाउडफॉर्मेशन टेम्प्लेट्स
|-- 2.ami_and_containers/          # AMI और कंटेनर इमेज बनाने के लिए स्क्रिप्ट्स
|-- 3.test_cases/                  # संदर्भ परीक्षण मामले और/या बेंचमार्क स्क्रिप्ट्स
|-- 4.validation_observability/    # प्रदर्शन मापन या समस्या निवारण के लिए उपकरण
`-- ...
```

**ध्यान दें**: वास्तुकला को S3 बकेट और VPC के साथ काम करने के लिए डिज़ाइन किया गया है जो संदर्भ टेम्प्लेट `1.architectures/0.s3/` और `1.architectures/1.vpc_network/` का उपयोग करके बनाए गए हैं। _आपको दृढ़ता से सलाह दी जाती है कि इन दोनों टेम्प्लेट्स को किसी भी संदर्भ वास्तुकला को तैनात करने से **पहले** तैनात करें।_

## 0. कार्यशालाएँ

आप नीचे दी गई कार्यशाला का पालन करके AWS पर मॉडल प्रशिक्षण कर सकते हैं। प्रत्येक में कई परीक्षण मामलों के उदाहरण और LLM प्रशिक्षण के लिए क्लस्टर संचालित करने की जानकारी के टुकड़े शामिल हैं।

| नाम                                                                           | टिप्पणियां
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------- |
| [Amazon SageMaker HyperPod](https://catalog.workshops.aws/sagemaker-hyperpod/en-US)   | SageMaker HyperPod के लिए कार्यशाला, यह दिखाता है कि इसे कैसे तैनात और मॉनिटर करें |
| [AWS ParallelCluster](https://catalog.workshops.aws/ml-on-aws-parallelcluster) | HyperPod के समान कार्यशाला लेकिन ParallelCluster पर                 |
| [Amazon SageMaker HyperPod EKS](https://catalog.workshops.aws/sagemaker-hyperpod-eks)   | SageMaker HyperPod EKS के लिए कार्यशाला, यह दिखाता है कि इसे कैसे तैनात और मॉनिटर करें |

## 1. वास्तुकला

वास्तुकला `1.architectures` में स्थित हैं और उपयोगिताओं और सेवा संबंधित वास्तुकला से मिलकर बनी हैं।

| नाम                                                               | श्रेणी | उपयोग                                               |
| ------------------------------------------------------------------ | -------- | --------------------------------------------------- |
| [`0.s3`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/0.s3)                                   | संग्रहण  | एक S3 बकेट बनाएँ                                 |
| [`1.vpc_network`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/1.vpc_network)                 | नेटवर्क  | आवश्यक संसाधनों के साथ एक VPC और सबनेट बनाएँ        |
| [`2.aws-parallelcluster`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/2.aws-parallelcluster) | कंप्यूट  | GPU और कस्टम सिलिकॉन प्रशिक्षण के लिए क्लस्टर टेम्प्लेट्स |
| [`3.aws-batch`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/3.aws-batch)                     | कंप्यूट  | वितरित प्रशिक्षण के लिए AWS बैच टेम्प्लेट         |
| [`4.amazon-eks`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/4.amazon-eks)                   | कंप्यूट  | Amazon EKS के साथ प्रशिक्षण के लिए मैनिफेस्ट फ़ाइलें             |
| [`5.sagemaker-hyperpod`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/5.sagemaker-hyperpod)   | कंप्यूट  | वितरित प्रशिक्षण के लिए SageMaker HyperPod टेम्प्लेट|

और भी आएंगे, नए जोड़ने के लिए स्वतंत्र महसूस करें (उदा. Ray?)। आपको EFA और अनुशंसित पर्यावरण चर के लिए [दस्तावेज़](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-cheatsheet.md) भी मिलेंगे।

## 2. कस्टम अमेज़न मशीन इमेजेज़

AWS ParallelCluster, Amazon EKS और सामान्य EC2 के लिए [Packer](www.packer.io) का उपयोग करके कस्टम मशीन इमेज बनाई जा सकती हैं। ये इमेज Ansible रोल्स और प्लेबुक्स पर आधारित हैं।

## 3. परीक्षण मामले

परीक्षण मामले फ्रेमवर्क द्वारा व्यवस्थित हैं और विभिन्न वितरित प्रशिक्षण परिदृश्यों को कवर करते हैं। प्रत्येक परीक्षण मामले में वितरित प्रशिक्षण नौकरियां चलाने के लिए आवश्यक स्क्रिप्ट और कॉन्फ़िगरेशन शामिल हैं।

### PyTorch परीक्षण मामले
- [`FSDP/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/FSDP) - पूर्ण रूप से शार्डेड डेटा समानांतर प्रशिक्षण उदाहरण
- [`megatron-lm/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/megatron-lm) - Megatron-LM वितरित प्रशिक्षण उदाहरण
- [`nemo-launcher/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-launcher) - वितरित प्रशिक्षण के लिए NeMo लॉन्चर उदाहरण। यह परीक्षण मामला केवल NeMo संस्करण 1.0 के लिए है।
- [`nemo-run/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-run) - NeMo फ्रेमवर्क वितरित प्रशिक्षण उदाहरण। यह परीक्षण मामला NeMo संस्करण 2.0+ के लिए है।
- [`neuronx-distributed/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/neuronx-distributed) - AWS Trainium वितरित प्रशिक्षण उदाहरण
- [`mosaicml-composer/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/mosaicml-composer) - MosaicML Composer उदाहरण
- [`picotron/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/picotron) - PicoTron वितरित प्रशिक्षण उदाहरण
- [`torchtitan/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/torchtitan) - TorchTitan उदाहरण
- [`cpu-ddp/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/cpu-ddp) - CPU आधारित वितरित डेटा समानांतर उदाहरण
- [`bionemo/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/bionemo) - BioNeMo वितरित प्रशिक्षण उदाहरण

### JAX परीक्षण मामले
- [`jax/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/jax) - PaxML का उपयोग करके JAX आधारित वितरित प्रशिक्षण उदाहरण

प्रत्येक परीक्षण मामले में शामिल हैं:
- प्रशिक्षण स्क्रिप्ट और कॉन्फ़िगरेशन
- कंटेनर परिभाषाएँ (जहाँ लागू हो)
- विभिन्न क्लस्टर प्रकारों के लिए लॉन्च स्क्रिप्ट
- प्रदर्शन निगरानी और सत्यापन उपकरण

## 4. सत्यापन स्क्रिप्ट

उपयोगिता स्क्रिप्ट और माइक्रो-बेंचमार्क उदाहरण `4.validation_scripts/` के अंतर्गत सेट हैं। EFA Prometheus एक्सपोर्टर इस [निर्देशिका](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter) में पाया जा सकता है। 


| नाम                                                                                    | टिप्पणियां                                                        |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------- |
| [`1.pytorch-env-validation`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/1.pytorch-env-validation) | आपके PyTorch पर्यावरण को मान्य करता है                              |
| [`3.efa-node-exporter`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter)           | Amazon EFA मॉनिटरिंग मॉड्यूल के साथ नोड एक्सपोर्टर                |
| [`4.prometheus-grafana`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/4.prometheus-grafana)         | SageMaker Hyperpod क्लस्टर की निगरानी के लिए डिप्लॉयमेंट एसेट्स        |
| [`5.nsight`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/5.nsight)                                 | आपका वर्कलोड प्रोफाइल करने के लिए Nvidia Nsight Systems चलाने का तरीका दिखाता है |
| [`efa-versions.py`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-versions.py)                                  | Nvidia लाइब्रेरी, ड्राइवर और EFA ड्राइवर के संस्करण प्राप्त करें   |


## 5. CI

इंटीग्रेशन टेस्ट [pytest](https://docs.pytest.org) में लिखे गए हैं। बस चलाएं:

```bash
pytest .
```

वैकल्पिक रूप से आप stdout कैप्चर किए बिना और सभी डॉकर इमेज और अन्य आर्टिफैक्ट्स को रखते हुए परीक्षण चला सकते हैं।

```bash
pytest -s --keep-artifacts=t
```

## 6. योगदानकर्ता

निर्माण, समीक्षा और परीक्षण के लिए सभी योगदानकर्ताओं का धन्यवाद।

[![Contributors](https://contrib.rocks/image?repo=aws-samples/awsome-distributed-training)](https://github.com/aws-samples/awsome-distributed-training/graphs/contributors)

## 7. स्टार इतिहास

[![Star History Chart](https://api.star-history.com/svg?repos=aws-samples/awsome-distributed-training&type=Date)](https://star-history.com/#aws-samples/awsome-distributed-training&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---