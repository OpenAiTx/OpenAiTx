## MCP-Zero: स्वायत्त LLM एजेंट्स के लिए सक्रिय टूल खोज

<div style="display: flex; align-items: center; gap: 10px; margin-bottom: 10px;">
  <!-- <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/robot.png" alt="MCP-Zero Robot" width="24" height="24"> -->
  <a href="https://arxiv.org/abs/2506.01056">
    <img src="https://img.shields.io/badge/Paper-arXiv-red">
  </a>
  <a href="https://arxiv.org/abs/2506.01056">
    https://arxiv.org/abs/2506.01056
  </a>
</div>


MCP-Zero के लिए आपके ध्यान के लिए धन्यवाद! 🤗

हमने अब पेपर में शामिल कोड को ओपन-सोर्स कर दिया है। हम अपने कार्य को अपडेट करना जारी रखेंगे, इसके औद्योगिक अनुप्रयोग की खोज करेंगे, और इस परियोजना का विस्तार करते रहेंगे।


<div align="center">
  <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/fig1.png" alt="MCP-Zero workflow">
  <p> "एक शानदार भोजन बनाना" के लिए MCP-Zero का उपयोग करके टूलचेन को सक्रिय रूप से बनाना</p>
</div>


### विधि: MCP-Zero

```
MCP-zero/
├── experiment_apibank.py       # प्रयोग: APIBank
├── experiment_mcptools.py      # प्रयोग: mcp_tools (needle test)
├── matcher.py                  # समानता मिलान के लिए कोड
├── prompt_guide/               # हमारी विधि के लिए प्रॉम्प्ट्स
├── reformatter.py              # टूल विवरण के लिए json प्रारूपक
├── sampler.py                  # लक्षित टूल के चयन के लिए सैंपलर
├── test_cases.jsonl            # मैचर के लिए टेस्ट केस
├── test_matcher.py             # मैचर के लिए यूनिट टेस्ट
└── utils.py                    # यूटिल्स: grid_search
```

हमने अब अपने पेपर के लिए कोड जारी कर दिया है। पेपर में दिए गए कोड में पुनर्प्राप्ति क्षमताओं को लागू किया गया है और प्रयोगों में ठोस परिणाम प्राप्त किए गए हैं।

अपने भविष्य के कार्य में, हम MCP-zero को उद्योग में लागू करने के लिए प्रतिबद्ध हैं, इसलिए अन्य मॉड्यूल को भी शामिल करना आवश्यक है, जैसे MCP सर्वर की डायनामिक तैनाती, GAIA टेस्ट के लिए परिवेश तैनाती आदि। हम अपने कार्य को बेहतर बनाते रहेंगे, और इस कार्य में आपकी रुचि के लिए धन्यवाद। एक स्टार🌟 छोड़ें ताकि मुझे पता चले कि आप अपडेट रह रहे हैं :D



### डेटासेट: MCP-tools

- **Google Drive**: [डाउनलोड लिंक](https://drive.google.com/file/d/1RjBGU-AGdHdhUABoeYSztbfQlD0hjUBn/view?usp=sharing)
- **Huggingface लिंक**: जल्द ही आ रहा है
- **फ़ाइल रखें**: `./MCP-tools/mcp_tools_with_embedding.json`


**परिचय**: MCP आधिकारिक रेपो से सभी फ़िल्टर किए गए टूल्स (कुल 308 सर्वर और 2,797 टूल्स) का एक डेटासेट।

**डेटा संरचना**:
```
{
  "server_name": string, // MCP सर्वर का नाम, README से निकाला या अनुमानित
  "server_summary": string, // सर्वर के उद्देश्य और क्षमताओं का सारांश, README के सभी संबंधित हिस्सों के आधार पर।
  "server_description": string, // मेटाडेटा से विवरण।
  "description_embedding": float[3072], // server description का एम्बेडिंग, text-embedding-3-large से
  "summary_embedding": float[3072], // server summary का एम्बेडिंग, text-embedding-3-large से
  "tools": [
    {
      "name": string, // फंक्शन/टूल का नाम
      "description": string, // टूल क्या करता है इसका संक्षिप्त विवरण
      "description_embedding": float[3072], // टूल विवरण का एम्बेडिंग, text-embedding-3-large से
      "parameter": { // इनपुट पैरामीटर की डिक्शनरी, यदि स्पष्ट रूप से परिभाषित है तो शामिल
        "param1": "(type) विवरण1",
        "param2": "(Optional, type) विवरण2"
      }
    }
  ]
}
```

**अपना खुद का डेटासेट बनाएं**: यदि आप MCP सर्वर के लिए कस्टम डेटासेट बनाना चाहते हैं, तो आप `MCP-tools/build_data` फोल्डर के अंतर्गत कोड का पालन कर सकते हैं।

```
MCP-tools/
├── build_data
│   ├── get_server_summary.py       # MCP सर्वर के ReadMe फ़ाइल के लिए संरचनात्मक डेटा निकालने का कोड
│   ├── run_vllm.sh                 # Qwen2.5-72B-Instruct मॉडल को VLLM के साथ डिप्लॉय करें
│   └── server_summary.prompt       # डेटासेट निकालने के लिए प्रॉम्प्ट
└── download_data.md
```


### उद्धरण

> उद्धरण मुझे खुश करता है।
> 
>   --शेक्सपियर
>   ~~(सिर्फ मज़े के लिए :D)~~

```bibtex
@article{fei2025mcp,
  title={MCP-Zero: Active Tool Discovery for Autonomous LLM Agents},
  author={Fei, Xiang and Zheng, Xiawu and Feng, Hao},
  journal={arXiv preprint arXiv:2506.01056},
```
  year={2025}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-06

---