# [React](https://react.dev/) &middot; [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/facebook/react/blob/main/LICENSE) [![npm version](https://img.shields.io/npm/v/react.svg?style=flat)](https://www.npmjs.com/package/react) [![(Runtime) Build and Test](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml/badge.svg)](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml) [![(Compiler) TypeScript](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml/badge.svg?branch=main)](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](https://legacy.reactjs.org/docs/how-to-contribute.html#your-first-pull-request)

React एक जावास्क्रिप्ट लाइब्रेरी है जो यूजर इंटरफेस बनाने के लिए उपयोग की जाती है।

* **डिक्लेरेटिव:** React इंटरएक्टिव यूआई बनाना आसान बनाता है। अपने एप्लिकेशन की प्रत्येक स्थिति के लिए सरल दृश्य डिज़ाइन करें, और जब आपके डेटा में बदलाव हो, तो React कुशलतापूर्वक केवल सही कंपोनेंट्स को अपडेट और रेंडर करेगा। डिक्लेरेटिव व्यूज़ आपके कोड को अधिक पूर्वानुमानित, समझने में आसान और डिबग करने में सरल बनाते हैं।
* **कंपोनेंट-आधारित:** इनकैप्सुलेटेड कंपोनेंट्स बनाएं जो अपनी खुद की स्थिति प्रबंधित करते हैं, फिर उन्हें जोड़कर जटिल यूआई बनाएं। चूँकि कंपोनेंट लॉजिक टेम्पलेट्स की बजाय जावास्क्रिप्ट में लिखा जाता है, इसलिए आप आसानी से समृद्ध डेटा अपने ऐप के माध्यम से पास कर सकते हैं और स्थिति को DOM से बाहर रख सकते हैं।
* **एक बार सीखें, कहीं भी लिखें:** हम आपके तकनीकी स्टैक के बाकी हिस्सों के बारे में कोई पूर्वानुमान नहीं लगाते, इसलिए आप React में नई सुविधाएँ विकसित कर सकते हैं बिना मौजूदा कोड को दोबारा लिखे। React सर्वर पर [Node](https://nodejs.org/en) का उपयोग करके भी रेंडर कर सकता है और [React Native](https://reactnative.dev/) के ज़रिए मोबाइल ऐप्स को भी शक्ति दे सकता है।

[जानें कि अपनी परियोजना में React का उपयोग कैसे करें](https://react.dev/learn)।

## इंस्टॉलेशन

React को शुरू से ही क्रमिक रूप से अपनाने के लिए डिज़ाइन किया गया है, और **आप जितना चाहें उतना या जितना ज़रूरत हो उतना React इस्तेमाल कर सकते हैं**:

* [त्वरित प्रारंभ](https://react.dev/learn) का उपयोग करके React का अनुभव लें।
* [मौजूदा परियोजना में React जोड़ें](https://react.dev/learn/add-react-to-an-existing-project) ताकि आप जितना चाहें उतना React इस्तेमाल कर सकें।
* [नया React ऐप बनाएं](https://react.dev/learn/start-a-new-react-project) अगर आप एक शक्तिशाली जावास्क्रिप्ट टूलचेन खोज रहे हैं।

## डाक्यूमेंटेशन

आप React का डाक्यूमेंटेशन [वेबसाइट पर](https://react.dev/) देख सकते हैं।

त्वरित अवलोकन के लिए [Getting Started](https://react.dev/learn) पृष्ठ देखें।

डाक्यूमेंटेशन कई भागों में विभाजित है:

* [त्वरित प्रारंभ](https://react.dev/learn)
* [ट्यूटोरियल](https://react.dev/learn/tutorial-tic-tac-toe)
* [React में सोचना](https://react.dev/learn/thinking-in-react)
* [इंस्टॉलेशन](https://react.dev/learn/installation)
* [यूआई का वर्णन करना](https://react.dev/learn/describing-the-ui)
* [इंटरएक्टिविटी जोड़ना](https://react.dev/learn/adding-interactivity)
* [स्टेट प्रबंधन](https://react.dev/learn/managing-state)
* [एडवांस्ड गाइड्स](https://react.dev/learn/escape-hatches)
* [API संदर्भ](https://react.dev/reference/react)
* [सहायता कहाँ प्राप्त करें](https://react.dev/community)
* [योगदान गाइड](https://legacy.reactjs.org/docs/how-to-contribute.html)

आप [इस रिपॉजिटरी](https://github.com/reactjs/react.dev) में पुल रिक्वेस्ट भेजकर इसे बेहतर बना सकते हैं।

## उदाहरण

हमारे पास कई उदाहरण [वेबसाइट पर](https://react.dev/) उपलब्ध हैं। यहाँ पहला उदाहरण है जिससे आप शुरुआत कर सकते हैं:

```jsx
import { createRoot } from 'react-dom/client';

function HelloMessage({ name }) {
  return <div>Hello {name}</div>;
}

const root = createRoot(document.getElementById('container'));
root.render(<HelloMessage name="Taylor" />);
```

यह उदाहरण पेज पर एक कंटेनर में "Hello Taylor" को रेंडर करेगा।

आप देखेंगे कि हमने एक HTML-जैसी सिंटैक्स का उपयोग किया है; [इसे हम JSX कहते हैं](https://react.dev/learn#writing-markup-with-jsx)। React का उपयोग करने के लिए JSX आवश्यक नहीं है, लेकिन इससे कोड अधिक पठनीय हो जाता है, और इसे लिखना HTML जैसा महसूस होता है।

## योगदान

इस रिपॉजिटरी का मुख्य उद्देश्य React कोर का सतत विकास करना है, जिससे यह तेज और उपयोग में आसान बन सके। React का विकास ओपनली GitHub पर होता है, और हम बग फिक्स और सुधारों में योगदान के लिए समुदाय के आभारी हैं। नीचे पढ़ें कि आप React को बेहतर बनाने में कैसे भाग ले सकते हैं।

### [आचार संहिता](https://code.fb.com/codeofconduct)

Facebook ने एक आचार संहिता अपनाई है, जिसकी हम अपेक्षा करते हैं कि परियोजना प्रतिभागी उसका पालन करें। कृपया [पूरा पाठ](https://code.fb.com/codeofconduct) पढ़ें ताकि आप समझ सकें कि कौन से कार्य स्वीकार्य हैं और कौन से नहीं।

### [योगदान गाइड](https://legacy.reactjs.org/docs/how-to-contribute.html)

हमारी [योगदान गाइड](https://legacy.reactjs.org/docs/how-to-contribute.html) पढ़ें ताकि आप हमारे विकास प्रक्रिया, बग फिक्स और सुधार प्रस्तावित करने, तथा React में अपने परिवर्तनों को बिल्ड और टेस्ट करने के बारे में जान सकें।

### [शुरुआती-अनुकूल समस्याएँ](https://github.com/facebook/react/labels/good%20first%20issue)

आपकी सहायता के लिए और आपको हमारे योगदान प्रक्रिया से परिचित कराने के लिए, हमारे पास [शुरुआती-अनुकूल समस्याएँ](https://github.com/facebook/react/labels/good%20first%20issue) की सूची है जिनका दायरा सीमित है। यह शुरू करने के लिए शानदार जगह है।

### लाइसेंस

React [MIT लाइसेंस](./LICENSE) के तहत उपलब्ध है।

---

[Powered By DeepAiTx](https://github.com/DeepAiTx)

---