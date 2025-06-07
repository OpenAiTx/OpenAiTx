# डिस्कॉर्ड GNOME थीम

डिस्कॉर्ड के लिए एक GNOME थीम, जो Adwaita शैली और GNOME ह्यूमन इंटरफेस गाइडलाइन्स का पालन करती है (जितना भी डिस्कॉर्ड का CSS अनुमति देता है उतना ही)।

## आवश्यकताएँ

1. Vesktop

   विंडोज टाइटलबार को सक्षम करने के लिए।

2. सेटिंग्स > भाषा > "English (US)" चुनें

   यह कस्टम आइकॉन्स की अनुमति देता है क्योंकि डिस्कॉर्ड में उन्हें इसी तरह पहचाना जाता है। आप थीम को [स्थानीयकृत](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/src/global/icons.scss) कर सकते हैं, लेकिन स्थानीयकरण नोट अवश्य पढ़ें।

3. सेटिंग्स > प्लगइन्स > "ThemeAttributes" सक्षम करें

   यह सेटिंग्स डायलॉग में आइकॉन्स की अनुमति देता है।

4. सेटिंग्स > Vesktop सेटिंग्स > "Discord Titlebar" सक्षम करें

   वैकल्पिक, लेकिन यदि आपके पास टाइटलबार हैं तो अनुशंसित।

### वैकल्पिक जोड़

1. Nitro संदर्भ हटाएँ: https://github.com/CroissantDuNord/discord-adblock

## थीमिंग दर्शन

### ह्यूमन इंटरफेस गाइडलाइन्स

थीम पूरी तरह से HIG का पालन नहीं कर सकती क्योंकि डिस्कॉर्ड के CSS या डिज़ाइन सीमाओं या मेरे अपने चुनावों के कारण।

### समर्थन

इनका समर्थन नहीं किया जाता:

- डिस्कॉर्ड एक्सपेरिमेंट्स

  मैं डिस्कॉर्ड के लिए कार्य नहीं करता, इसलिए मुझे पता नहीं हो सकता कि ये एक्सपेरिमेंट्स बदल रहे हैं, बंद हो रहे हैं आदि, यानी रखरखाव का बोझ — मैं कई अन्य प्रोजेक्ट भी मेंटेन करता हूँ।

- Nitro

  अपवाद — जो भी FakeNitro प्लगइन के साथ उपलब्ध है।

आप इन सभी के बारे में कोई इश्यू खोल सकते हैं, लेकिन इसे केवल तभी ठीक किया जाएगा जब यह आसान फिक्स हो, जैसे कि कोई आइकॉन गायब हो।

## इंस्टॉलेशन

### कोई कॉन्फ़िगरेशन नहीं

सेटिंग्स > थीम्स > ऑनलाइन थीम्स में स्थित टेक्स्ट बॉक्स में निम्नलिखित कॉपी करें:

```
https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css
```

### कॉन्फ़िगरेशन सहित

[gnome.theme.css](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css) को ~/.config/vesktop/themes में रखें। यह फिर भी स्वचालित रूप से अपडेट होता रहेगा।

## पूर्वावलोकन

![first](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2011-55-58.png)
![cozy second](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-31-42.png)
![third](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-24-16.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---