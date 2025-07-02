# 🚀 MCP AI विकास सहायक

> AI डेवलपर्स को बुद्धिमान आवश्यकताओं के विश्लेषण और आर्किटेक्चर डिज़ाइन में सहायता करने वाला MCP टूल

## ✨ मुख्य विशेषताएँ

- **स्मार्ट आवश्यकता स्पष्टता**: प्रोजेक्ट प्रकार की स्वतः पहचान, लक्षित प्रश्न उत्पन्न करना
- **ब्रांच-अवेयर मैनेजमेंट**: प्रोजेक्ट के लक्ष्य, फंक्शनल डिज़ाइन, तकनीकी प्राथमिकता, UI डिज़ाइन आदि आयामों को ट्रैक करना
- **आर्किटेक्चर ऑटो-जनरेशन**: पूर्ण आवश्यकताओं के आधार पर तकनीकी आर्किटेक्चर समाधान तैयार करना
- **पर्सिस्टेंट स्टोरेज**: विश्लेषण परिणामों को स्वतः सेव करना, डॉक्युमेंट एक्सपोर्ट का समर्थन

## 📁 त्वरित कॉन्फ़िगरेशन

### पुराना संस्करण कॉन्फ़िगरेशन
1. **कोड क्लोन करें**
   ```bash
   git clone https://github.com/jiemobasixiangcai/ai-develop-assistant.git
   ```
2. **अनुशंसित वर्चुअल एनवायरनमेंट**
   ```bash
   python -m venv venv
   source venv/bin/activate  # Unix/Linux/MacOS
   venv\Scripts\activate  # Windows
   ```
3. **डिपेंडेंसी इंस्टॉल करें**
   ```bash
   pip install -r requirements.txt
   ```

4. **कॉन्फ़िगरेशन फाइल का स्थान**
   ```
   Windows: %APPDATA%\Claude\claude_desktop_config.json
   macOS: ~/Library/Application Support/Claude/claude_desktop_config.json
   ```

5. **कॉन्फ़िगरेशन जोड़ें**
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "python",
         "args": ["path/to/AIDevlopStudy.py"],
         "env": {
           "MCP_STORAGE_DIR": "./mcp_data"
         }
       }
     }
   }
   ```

3. **Claude Desktop रीस्टार्ट करें**

### नया संस्करण कॉन्फ़िगरेशन
#### 🔧 मुख्य टूल्स
1. **start_new_project** - नया प्रोजेक्ट प्रारंभ करें
2. **create_requirement_blueprint** - आवश्यकता ब्लूप्रिंट बनाएँ
3. **requirement_clarifier** - आवश्यकता स्पष्टता संकेत प्राप्त करें
4. **save_clarification_tasks** - स्पष्टता कार्य सहेजें
5. **update_branch_status** - ब्रांच स्थिति अपडेट करें
6. **requirement_manager** - आवश्यकता डॉक्युमेंट मैनेजर
7. **check_architecture_prerequisites** - आर्किटेक्चर पूर्व आवश्यकताएँ जांचें
8. **get_architecture_design_prompt** - आर्किटेक्चर डिज़ाइन संकेत प्राप्त करें
9. **save_generated_architecture** - उत्पन्न आर्किटेक्चर डिज़ाइन सहेजें
10. **export_final_document** - पूर्ण डॉक्युमेंट एक्सपोर्ट करें
11. **view_requirements_status** - आवश्यकता स्थिति देखें

#### कॉन्फ़िगरेशन (रिमोट डायरेक्ट कनेक्शन के लिए, इसे अपने टूल में कॉपी करें, MCP_STORAGE_DIR को अपनी लोकल डायरेक्टरी से बदलें)
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "uvx",
         "args": ["ai-develop-assistant@latest"],
         "env": {
           "MCP_STORAGE_DIR": "/path/to/your/storage"
         }
       }
     }
   }
   ```

## 🎯 उपयोग प्रक्रिया

### मूलभूत चरण

1. **आवश्यकता स्पष्टता**
   ```
   requirement_clarifier("मुझे एक ऑनलाइन शिक्षा प्लेटफॉर्म बनाना है")
   ```

2. **आवश्यकता प्रबंधन**
   ```
   requirement_manager("लक्ष्य उपयोगकर्ता: छात्र और शिक्षक", "प्रोजेक्ट सारांश")
   ```

3. **स्थिति देखें**
   ```
   view_requirements_status()
   ```
4. **आर्किटेक्चर डिज़ाइन**
   ```
   architecture_designer("ऑनलाइन शिक्षा प्लेटफ़ॉर्म आर्किटेक्चर")
   ```

5. **दस्तावेज़ निर्यात करें**
   ```
   export_final_document()
   ```

## 🚀 शुरू करें

### त्वरित प्रारंभ
1. **Claude Desktop कॉन्फ़िगर करें** (ऊपर दिए गए कॉन्फ़िगरेशन तरीके देखें)
2. **Claude Desktop को पुनः प्रारंभ करें**
3. **स्मार्ट आवश्यकता विश्लेषण शुरू करें**:
   ```
   requirement_clarifier("अपने प्रोजेक्ट विचार का वर्णन करें")
   ```
4. **AI की स्मार्ट गाइडेंस का अनुसरण करें**, एक-एक करके सभी आवश्यकताओं की शाखाओं को पूरा करें
5. **संपूर्ण दस्तावेज़ निर्यात करें**:
   ```
   export_final_document()
   ```

### सर्वोत्तम अभ्यास
- 💬 **AI की शाखा प्रबंधन पर भरोसा करें**: AI को सभी आवश्यकता शाखाओं को पूरा करने के लिए मार्गदर्शन करने दें
- 🎯 **पसंद स्पष्ट रूप से व्यक्त करें**: तकनीकी विकल्प, UI शैली आदि के लिए अपनी पसंद स्पष्ट रूप से बताएं
- 📊 **नियमित रूप से स्थिति देखें**: प्रगति जानने के लिए `view_requirements_status` का उपयोग करें
- 🤖 **AI को उपयुक्त रूप से अधिकृत करें**: जिन हिस्सों को लेकर असमंजस हो, वहाँ "सामान्य समाधान अपनाएं" कह सकते हैं

---

**🎯 अब आपके पास एक वास्तव में स्मार्ट AI डेवलपमेंट असिस्टेंट है, जो हर विवरण को याद रखता है और आपको संपूर्ण आवश्यकता विश्लेषण पूरा करने के लिए मार्गदर्शन करता है!**

## 💬 चर्चा समूह

<div align="center">
<img src="https://raw.githubusercontent.com/jiemobasixiangcai/ai-develop-assistant/main/./assets/qr-code.jpg" width="200" alt="चर्चा समूह">
<br>
चर्चा समूह
</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---