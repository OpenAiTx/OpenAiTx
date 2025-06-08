<h1>
  <img src="https://raw.githubusercontent.com/OrionBench/OrionBench/main/logo.png" alt="Logo" width="80" style="vertical-align: middle; margin-right: 10px;"/>
  OrionBench: इन्फोग्राफिक्स में चार्ट और मानव-पहचाने जा सकने वाले ऑब्जेक्ट डिटेक्शन के लिए एक बेंचमार्क
</h1>

## डेटासेट

यह रिपॉजिटरी पेपर "OrionBench: इन्फोग्राफिक्स में चार्ट और मानव-पहचाने जा सकने वाले ऑब्जेक्ट डिटेक्शन के लिए एक बेंचमार्क" के लिए कोड शामिल करती है। संबंधित डेटा [Huggingface](https://huggingface.co/datasets/OrionBench/OrionBench) पर उपलब्ध है।

![TEASER](https://raw.githubusercontent.com/OrionBench/OrionBench/main/teaser.png)

## ऑब्जेक्ट डिटेक्शन मॉडल का मूल्यांकन
कृपया पहले [MMDetection](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection) में दिए गए निर्देशों के अनुसार पर्यावरण सेटअप करें।  

हम MMDetection का उपयोग करके चार ऑब्जेक्ट डिटेक्शन मॉडल का प्रशिक्षण और परीक्षण करते हैं: [Faster-Rcnn](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/faster_rcnn/faster-rcnn_my_full.py), [YOLOv3](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/yolo/yolov3_my_full.py), [RTMDet](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/rtmdet/rtmdet_my_full.py), और [Co-DETR](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/projects/CO-DETR/configs/codino/co_dino_my_full.py)।

संबंधित चारों कॉन्फ़िगरेशन में "YOUR ROOT" और "YOUR DATASET" को संशोधित करें।

मॉडल को प्रशिक्षित करने के लिए निम्नलिखित कमांड निष्पादित करें:
```
cd mmdetection
bash tools/dist_train.sh configs/faster_rcnn/faster-rcnn_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/faster-rcnn_my_full
bash tools/dist_train.sh configs/yolo/yolov3_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/yolov3_my_full
bash tools/dist_train.sh configs/rtmdet/rtmdet_my_full_new.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/rtmdet_my_full
bash tools/dist_train.sh projects/CO-DETR/configs/codino/co_dino_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/codetr_my_full
```

निम्नलिखित चित्र में मूल्यांकित ऑब्जेक्ट डिटेक्शन मॉडलों के डिटेक्शन परिणाम दिखाए गए हैं: (a) DINO-X के साथ जीरो-शॉट प्रम्प्टिंग; (b) T-Rex2 के साथ 4-शॉट प्रम्प्टिंग; (c) Co-DETR के साथ 4-शॉट फाइन-ट्यूनिंग; (d) Co-DETR के साथ OrionBench पर फाइन-ट्यूनिंग। रंगीन बॉक्स चार्ट और HROs के लिए पूर्वानुमान हैं।

![det_qual](https://raw.githubusercontent.com/OrionBench/OrionBench/main/det_qual.png)

इसके अतिरिक्त, बेंचमार्क के साथ सह-विकसित InternImage आधारित मॉडल [Huggingface](https://huggingface.co/OrionBench/InternImage_L_DINO) पर उपलब्ध है।

## पेपर लिंक

### मुख्य पेपर (यह रिपॉजिटरी)

- **[OrionBench: इन्फोग्राफिक्स में चार्ट और मानव-पहचाने जा सकने वाले ऑब्जेक्ट डिटेक्शन के लिए एक बेंचमार्क](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

### संबंधित पेपर

- **[ChartGalaxy: इन्फोग्राफिक चार्ट समझ और जनरेशन के लिए एक डेटासेट](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

- **[InfoChartQA: इन्फोग्राफिक चार्ट्स पर मल्टीमॉडल प्रश्नोत्तर के लिए एक बेंचमार्क](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  


## संदर्भ

यदि आप अपने शोध में हमारे मॉडल या डेटासेट का उपयोग करते हैं तो कृपया हमारे पेपर का हवाला दें

```
@misc{zhu2025orionbench,
      title={OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics}, 
      author={Jiangning Zhu and Yuxing Zhou and Zheng Wang and Juntao Yao and Yima Gu and Yuhui Yuan and Shixia Liu},
      year={2025},
      eprint={2505.17473},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2505.17473}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---