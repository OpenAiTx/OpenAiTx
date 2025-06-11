<div align="center" id="madewithlua">
  <img
    src="https://astronvim.com/logo/astronvim.svg"
    width="110"
    ,
    height="100"
  />
</div>
<h1 align="center">AstroNvim समुदाय भंडार</h1>

AstroNvim का समुदाय भंडार प्लगइन कॉन्फ़िगरेशन विनिर्देशों को शामिल करता है — AstroNvim के लिए समुदाय द्वारा योगदान किए गए प्लगइनों का एक संग्रह, जो कि NeoVim कॉन्फ़िगरेशन है। ये विनिर्देश AstroNvim में उपयोग किए जाने वाले विभिन्न प्लगइनों का प्रबंधन करने में मदद करते हैं।

## 📦 सेटअप

समुदाय प्लगइनों को एकीकृत करने के लिए, प्रदान किए गए कॉन्फ़िगरेशन को अपनी `plugins` सेटअप में जोड़ें, यह सुनिश्चित करने के लिए कि सभी AstroCommunity परिवर्तन आपके अपने ओवरराइड्स से पहले लोड हो जाएं। यदि आप [AstroNvim टेम्पलेट](https://github.com/AstroNvim/template) का उपयोग कर रहे हैं, तो यह आपकी `lua/community.lua` फ़ाइल में किया जा सकता है। यदि आप प्लगइनों को कॉन्फ़िगर करने में अपरिचित हैं, तो हम [AstroNvim दस्तावेज़](https://docs.astronvim.com/configuration/customizing_plugins/) देखने की सलाह देते हैं।

### AstroCommunity प्लगइनों को इम्पोर्ट करना

अपने `lua/community.lua` फ़ाइल के भीतर निम्नलिखित सामग्री को एकीकृत करें:

```lua
return {
  "AstroNvim/astrocommunity",
  { import = "https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/colorscheme/catppuccin" },
  -- ... यहाँ किसी भी समुदाय द्वारा योगदान किए गए प्लगइनों को इम्पोर्ट करें
}
```

### AstroCommunity इंस्टॉलेशनों को कस्टमाइज़ करना

एक बार जब आपने `lua/community.lua` में AstroCommunity इम्पोर्ट्स को परिभाषित कर लिया, तो आप अपनी स्वयं की प्लगइन परिभाषाओं में (आमतौर पर `lua/plugins/` डायरेक्टरी में) इंस्टॉलेशनों को और कस्टमाइज़ कर सकते हैं। यहाँ एक उदाहरण है जिसमें ऊपर दिखाए अनुसार Catppuccin स्थापित है।

```lua
return {
  { -- समुदाय द्वारा सेट किए गए विकल्पों को और कस्टमाइज़ करें
    "catppuccin",
    opts = {
      integrations = {
        sandwich = false,
        noice = true,
        mini = true,
        leap = true,
        markdown = true,
        neotest = true,
        cmp = true,
        overseer = true,
        lsp_trouble = true,
        rainbow_delimiters = true,
      },
    },
  },
}
```

**नोट्स:**

- इम्पोर्ट्स को अक्षम करने के लिए, `enabled` विकल्प को `false` पर सेट करें। मौजूदा प्लगइन को संशोधित करने के दो तरीके हैं: पूरा रिपॉजिटरी नाम उपयोग करें (जैसे "m4xshen/smartcolumn.nvim") या मॉड्यूल नाम (जैसे "catppuccin")। ध्यान दें कि मॉड्यूल नाम फ़ोल्डर नाम से अलग हो सकता है।
- किसी प्लगइन को कस्टमाइज़ करते समय पूरा इम्पोर्ट पथ उपयोग करने की सलाह दी जाती है, न कि केवल रिपॉजिटरी नाम का शॉर्टहैंड।
- आप समुदाय प्लगइनों के कई पहलुओं को ओवरराइड कर सकते हैं, जिनमें सेटिंग्स, निर्भरताएँ, और संस्करण शामिल हैं। उपलब्ध विकल्पों के लिए, कृपया [lazy.nvim दस्तावेज़](https://lazy.folke.io/) देखें।

## योगदान

यदि आपने कोई प्लगइन कॉन्फ़िगरेशन लिखा है और उसे AstroCommunity भंडार में जोड़ना चाहते हैं, तो कृपया हमारे [योगदान दिशानिर्देश](https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/CONTRIBUTING.md) का पालन करें और पुल रिक्वेस्ट सबमिट करें। सबमिशन से पहले सुनिश्चित करें कि आपने अपने परिवर्तनों का कड़ाई से परीक्षण किया है। यह आधिकारिक भंडार नहीं है, इसलिए इसकी स्थिरता समुदाय योगदानों पर निर्भर करती है। हमें इस परियोजना के विकास और विस्तार को देखने की उत्सुकता है!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---