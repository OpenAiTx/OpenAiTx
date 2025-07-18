<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# AlphaEvolve Writing

![AlphaEvolve Writing Process](https://raw.githubusercontent.com/tamassimonds/AlphaEvolveWriting/main/assets/AlphaWriteProcess.png)

आप पूरी व्याख्या [यहाँ](https://tobysimonds.com/research/2025/06/06/LLM-Self-Rewarding-copy.html) पा सकते हैं

आप एक प्रतियोगिता में प्रस्तुत की गई कहानी का उदाहरण [यहाँ](https://blog.reedsy.com/short-story/wo9iuy/#comments) पा सकते हैं

एक आधुनिक, विकासवादी लेखन प्रणाली जो रचनात्मक कहानियाँ या सामान्य लेखन टुकड़े उत्पन्न, मूल्यांकन और विकसित करने के लिए एआई मॉडल का उपयोग करती है, जो पुनरावृत्त प्रतियोगिताओं के माध्यम से कार्य करती है। इसे आधुनिक डिजाइन सिद्धांतों का पालन करते हुए स्वच्छ, मॉड्यूलर Python आर्किटेक्चर के साथ बनाया गया है।



## ✨ विशेषताएँ

- 🧬 **विकासवादी एल्गोरिदम**: कहानियाँ एआई-शक्ति वाले टूर्नामेंट्स के माध्यम से विकसित होती हैं
- 🎯 **दोहरी लेखन विधियाँ**: रचनात्मक कहानी लेखन और सामान्य लेखन अनुकूलन
- 🏆 **ELO टूर्नामेंट सिस्टम**: जोड़ीवार तुलना द्वारा परिष्कृत रैंकिंग
- 🌐 **वेब इंटरफेस**: मानव सत्यापन और कहानी तुलना उपकरण
- 🔧 **कॉन्फ़िगर करने योग्य**: JSON कॉन्फ़िगरेशन के माध्यम से व्यापक अनुकूलन

## 🚀 त्वरित शुरुआत

### स्थापना



```bash
# Clone the repository
git clone https://github.com/your-org/alphaevolve-writing
cd alphaevolve-writing

# Install with uv (recommended)
uv sync

# Or install with pip
pip install -e .

# Configure your API keys (see Configuration section below)
```
### विकास चलाएं


```bash
# Run 5 evolution iterations
python evolve.py 5

# Fresh start with 3 iterations
python evolve.py 3 --fresh

# Use general writing mode
python evolve.py 5 --general

# Show help
python evolve.py --help
```
## 🏗️ वास्तुकला

सिस्टम आधुनिक पायथन डिज़ाइन सिद्धांतों का पालन करता है जिसमें जिम्मेदारियों का स्पष्ट विभाजन है:


```
├── src/
│   ├── core/           # Pipeline orchestration
│   │   └── pipeline.py # Main EvolutionPipeline class
│   ├── generators/     # Story generation logic
│   │   ├── story_generator.py      # Initial & next batch generators
│   │   ├── generate_response.py    # Creative writing generation
│   │   ├── generate_response_general.py # General writing generation
│   │   └── judge_response.py       # AI judging system
│   ├── rankers/        # ELO ranking system
│   │   ├── elo_rank.py            # Core ELO algorithm
│   │   └── tournament_runner.py    # Tournament management
│   └── utils/          # Utility functions
│       └── inference.py           # Multi-provider LLM interface
├── evolve.py           # Clean CLI entry point
├── pyproject.toml      # Modern Python packaging
├── config.json         # Configuration
└── web_interface/      # Web UI for validation
```
### मुख्य घटक

- **`EvolutionPipeline`**: मुख्य संयोजक जो संपूर्ण विकास चक्र का प्रबंधन करता है
- **`InitialStoryGenerator`**: प्रॉम्प्ट से कहानियों की पहली पीढ़ी बनाता है
- **`NextBatchGenerator`**: शीर्ष प्रदर्शनकर्ताओं को बेहतर संस्करणों में विकसित करता है
- **`TournamentRunner`**: कहानी रैंकिंग के लिए ELO टूर्नामेंट का प्रबंधन करता है
- **`EloRankingSystem`**: उन्नत रैंकिंग एल्गोरिदम को लागू करता है

## 📖 यह कैसे काम करता है

सिस्टम तीन-चरणीय विकास चक्र का अनुसरण करता है:

### 1. **प्रारंभिक बैच बनाएं**
- आपके प्रॉम्प्ट से कई कहानियां बनाता है
- कॉन्फ़िगर करने योग्य एआई मॉडल (GPT, Claude, Llama, आदि) का उपयोग करता है
- प्रारंभिक ELO रेटिंग असाइन करता है

### 2. **ELO टूर्नामेंट चलाएं**
- कहानियां जोड़ी में प्रतिस्पर्धा करती हैं
- एआई जज आपके मापदंड के आधार पर मूल्यांकन करते हैं
- जीत/हार के आधार पर ELO रेटिंग अपडेट होती है

### 3. **अगला बैच बनाएं**
- शीर्ष प्रदर्शन करने वाली कहानियों का चयन किया जाता है
- सुधार के साथ वैरिएंट्स उत्पन्न किए जाते हैं
- प्रक्रिया कई पीढ़ियों तक दोहराई जाती है

यह पुनरावृत्त प्रक्रिया समय के साथ लगातार बेहतर लेखन विकसित करती है।

## ⚙️ कॉन्फ़िगरेशन

### बेसिक सेटअप

इन मुख्य फाइलों को संपादित करें:

- **`prompt.txt`** - आपकी लेखन प्रॉम्प्ट/थीम
- **`rubric.txt`** - मूल्यांकन के लिए निर्णायक मानदंड
- **`config.json`** - सिस्टम कॉन्फ़िगरेशन

### API Keys सेटअप

सिस्टम कई एआई प्रदाताओं का समर्थन करता है जिन्हें `config.json` के माध्यम से कॉन्फ़िगर किया जाता है। कॉन्फ़िगरेशन मॉडल को प्रदाताओं से जोड़ता है और यह निर्दिष्ट करता है कि कौन से एनवायरनमेंट वेरिएबल्स में API Keys हैं:


```json
{
  "llm_providers": {
    "openai": {
      "type": "openai",
      "base_url": "https://api.openai.com/v1",
      "api_key_env": "OPENAI_API_KEY"
    },
    "anthropic": {
      "type": "anthropic", 
      "api_key_env": "ANTHROPIC_API_KEY"
    },
    "deepinfra": {
      "type": "openai_compatible",
      "base_url": "https://api.deepinfra.com/v1/openai",
      "api_key_env": "DEEPINFRA_API_KEY"
    },
    "deepseek": {
      "type": "openai_compatible",
      "base_url": "https://api.deepseek.com/v1",
      "api_key_env": "DEEPSEEK_API_KEY"
    },
    "gemini": {
      "type": "openai_compatible",
      "api_key_env": "GEMINI_API_KEY",
      "base_url": "https://generativelanguage.googleapis.com/v1beta/openai/"
    }
  },
  "model_provider_mapping": {
    "gpt-4": "openai",
    "gpt-3.5-turbo": "openai", 
    "claude-3-sonnet-20240229": "anthropic",
    "meta-llama/Meta-Llama-3-70B-Instruct": "deepinfra",
    "deepseek-chat": "deepseek",
    "gemini-2.5-flash": "gemini"
  }
}
```
फिर अपनी API कुंजी को पर्यावरण वेरिएबल्स के रूप में सेट करें:


```bash
export OPENAI_API_KEY="your-openai-key"        # For GPT models
export ANTHROPIC_API_KEY="your-anthropic-key"  # For Claude models  
export DEEPINFRA_API_KEY="your-deepinfra-key"  # For Llama models
export DEEPSEEK_API_KEY="your-deepseek-key"    # For DeepSeek models
export GEMINI_API_KEY="your-gemini-key"          # For Gemini models
```
आपको केवल उन प्रदाताओं के लिए कुंजी सेट करने की आवश्यकता है जिन्हें आप उपयोग करने की योजना बना रहे हैं। सिस्टम स्वचालित रूप से कॉन्फ़िगरेशन के आधार पर मॉडल अनुरोधों को सही प्रदाता तक भेजता है।

### कॉन्फ़िगरेशन विकल्प

`config.json` फ़ाइल संपूर्ण सिस्टम व्यवहार को नियंत्रित करती है:


```json
{
  "batch_generation": {
    "num_stories": 10,
    "model": "gpt-4",
    "initial_elo": 1500
  },
  "elo_ranking": {
    "tournament_rounds": 50,
    "judge_model": "claude-3-sonnet-20240229",
    "k_factor": 32
  },
  "next_batch_generation": {
    "top_stories_to_select": 3,
    "variants_per_story": 2,
    "include_original_stories": true
  },
  "evolution_pipeline": {
    "max_iterations": 5,
    "auto_continue_from_existing": true
  }
}
```
## 🎭 लेखन मोड

### क्रिएटिव राइटिंग मोड (डिफ़ॉल्ट)
- कहानी कहने, चरित्र विकास, और नैरेटिव तकनीकों पर केंद्रित
- मिशन-आधारित जनरेशन रणनीतियाँ उपयोग करता है
- रचनात्मकता और आकर्षण के लिए अनुकूलित

### सामान्य लेखन मोड (`--general`)
- शैक्षणिक पत्रों, निबंधों, रिपोर्टों, और पेशेवर लेखन पर केंद्रित
- विश्लेषणात्मक और संरचित दृष्टिकोण का उपयोग करता है
- स्पष्टता और प्रभावशीलता के लिए अनुकूलित

## 🔧 उन्नत कॉन्फ़िगरेशन

### जनरेशन रणनीतियों को अनुकूलित करना

उन्नत उपयोगकर्ताओं के लिए, आप `src/generators/` निर्देशिका में फ़ाइलों को संपादित कर जनरेशन प्रॉम्प्ट, लेखक शैलियाँ और मिशन सेट कस्टमाइज़ कर सकते हैं:

#### क्रिएटिव राइटिंग कस्टमाइज़ेशन (`src/generators/generate_response.py`)

**मिशन सेट** - रचनात्मक दृष्टिकोण और लक्ष्यों को परिभाषित करें:

```python
mission_sets = {
    "emotional_depth": [
        "Focus on the psychological depth of characters",
        "Explore complex emotional landscapes", 
        "Create moments of genuine human connection"
    ],
    "narrative_craft": [
        "Experiment with unique narrative structures",
        "Use vivid, sensory descriptions",
        "Create compelling story arcs"
    ],
    "dialogue_mastery": [
        "Write authentic, character-specific dialogue",
        "Use subtext and implied meaning",
        "Balance dialogue with action and description"
    ]
}
```
**लेखक शैलियाँ** - विभिन्न लेखन दृष्टिकोणों की नकल करें:

```python
author_styles = [
    "Write with the psychological insight of Virginia Woolf",
    "Adopt the sparse, powerful prose of Ernest Hemingway", 
    "Use the magical realism style of Gabriel García Márquez",
    "Employ the detailed world-building of Tolkien"
]
```
#### सामान्य लेखन अनुकूलन (`src/generators/generate_response_general.py`)

**शैक्षणिक फोकस क्षेत्र** - विशिष्ट लेखन डोमेन को लक्षित करें:

```python
academic_focuses = [
    "Rigorous analytical argument development",
    "Clear thesis statement and supporting evidence",
    "Proper academic citation and source integration",
    "Logical flow and coherent structure"
]
```
**लेखन दृष्टिकोण** - विश्लेषणात्मक रणनीतियों को परिभाषित करें:

```python
writing_approaches = [
    "Comparative analysis with multiple perspectives",
    "Problem-solution framework with evidence",
    "Cause-and-effect reasoning with examples",
    "Critical evaluation with balanced arguments"
]
```
### जज मानदंड को अनुकूलित करना (`src/generators/judge_response.py`)

आप लेखन की गुणवत्ता के विशिष्ट पहलुओं पर ध्यान केंद्रित करने के लिए जजिंग मानदंड और मूल्यांकन प्रॉम्प्ट्स को संशोधित कर सकते हैं:


```python
# Edit the judge_responses function to customize evaluation criteria
evaluation_criteria = [
    "Technical writing proficiency",
    "Creative originality and innovation", 
    "Emotional impact and reader engagement",
    "Structural coherence and flow",
    "Character development and authenticity"
]
```
### उन्नत कॉन्फ़िगरेशन के लिए सुझाव

1. **मूल फ़ाइलों का बैकअप लें**: बदलाव करने से पहले हमेशा मूल जेनरेटर फ़ाइलों की प्रतियां रखें
2. **क्रमिक रूप से परीक्षण करें**: छोटे बदलाव करें और पूरे विकास चक्र चलाने से पहले कुछ पुनरावृत्तियों के साथ परीक्षण करें
3. **परिणामों की निगरानी करें**: वेब इंटरफ़ेस का उपयोग करके सुनिश्चित करें कि आपके अनुकूलन से कहानी की गुणवत्ता में सुधार हुआ है
4. **मिलाएँ और मिलान करें**: अद्वितीय जेनरेशन रणनीतियों के लिए विभिन्न मिशन सेट और लेखक शैलियों को मिलाएँ
5. **वर्शन नियंत्रण**: अपनी कस्टमाइज़ेशन को git के साथ ट्रैक करें ताकि जरूरत पड़ने पर वापस लौट सकें

यह मॉड्यूलर दृष्टिकोण आपको अपने विशिष्ट लेखन लक्ष्यों और क्षेत्रों के लिए विकास प्रक्रिया को सूक्ष्मता से नियंत्रित करने की सुविधा देता है।

## 🌐 वेब इंटरफ़ेस

बिल्ट-इन वेब इंटरफ़ेस से अपने विकास परिणामों को मान्य करें:


```bash
cd web_interface
pip install -r requirements.txt
python app.py
```
http://localhost:5000 खोलें और एक्सेस करें:

- **कहानी तुलना**: साथ-साथ पढ़ना और पसंदीदा चयन करना
- **ELO रैंकिंग्स**: वर्तमान स्थिति और आंकड़े देखें
- **विकास ट्रैकिंग**: सत्यापित करें कि बाद की पीढ़ियाँ बेहतर होती हैं
- **डेटा निर्यात**: विश्लेषण के लिए परिणाम डाउनलोड करें


```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---