<p align="center" margin="20 0"><a href="https://horusec.io/">
    <img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec_logo.png" alt="logo_header" width="65%" style="max-width:100%;"/></a></p>

<p align="center">
    <a href="https://github.com/ZupIT/horusec/releases" alt="version">
        <img src="https://img.shields.io/github/v/release/ZupIT/horusec?label=version"/></a>
    <a href="https://github.com/ZupIT/horusec/pulse" alt="activity">
        <img src="https://img.shields.io/github/commit-activity/m/ZupIT/horusec?label=activity"/></a>
    <a href="https://github.com/ZupIT/horusec/graphs/contributors" alt="contributors">
        <img src="https://img.shields.io/github/contributors/ZupIT/horusec?label=contributors"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/lint.yml" alt="lint">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Lint?label=lint"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/test.yml" alt="test">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Test?label=test"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/security.yml" alt="security">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Security?label=security"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/coverage.yml" alt="coverage">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Coverage?label=coverage"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/e2e.yml" alt="e2e">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/e2e?label=e2e"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/build.yaml" alt="build">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Build?label=build"/></a>
    <a href="https://opensource.org/licenses/Apache-2.0" alt="license">
        <img src="https://img.shields.io/badge/license-Apache%202-blue"/></a>
    <a href="https://bestpractices.coreinfrastructure.org/projects/5146"><img src="https://bestpractices.coreinfrastructure.org/projects/5146/badge"></a>
</p>

## **विषयसूची**
### 1. [**परिचय**](#about)
### 2. [**शुरुआत करें**](#getting-started)
>#### 2.1.   [**आवश्यकताएँ**](#requirements)
>#### 2.2.  [**इंस्टॉलेशन**](#installing-horusec)
### 3. [**उपयोग**](#usage)
>#### 3.1. [**CLI उपयोग**](#cli-usage)
>#### 3.2. [**Docker का उपयोग**](#using-docker)
>#### 3.3. [**पुराने संस्करण**](#older-versions)
>#### 3.4. [**Horusec-Web एप्लिकेशन का उपयोग**](#using-horusec-web-application)
>#### 3.5.  [**Visual Studio Code का उपयोग**](#using-visual-studio-code)
>#### 3.6. [**Pipeline का उपयोग**](#using-the-pipeline)
### 4. [**प्रलेखन**](#documentation)       
### 5. [**रोडमैप**](#roadmap)
### 6. [**योगदान**](#contributing)
### 7. [**आचार संहिता**](#code-of-conduct)
### 8. [**लाइसेंस**](#license)
### 9. [**समुदाय**](#community)



<br>
<br>
<br>

# **परिचय**
Horusec एक ओपन सोर्स टूल है जो विकास प्रक्रिया के दौरान सुरक्षा खामियों की पहचान के लिए स्थैतिक कोड विश्लेषण करता है। वर्तमान में, जिन भाषाओं का विश्लेषण किया जा सकता है, वे हैं: C#, Java, Kotlin, Python, Ruby, Golang, Terraform, Javascript, Typescript, Kubernetes, PHP, C, HTML, JSON, Dart, Elixir, Shell, Nginx।
यह टूल आपके प्रोजेक्ट की सभी फाइलों में और Git इतिहास में भी की-लीक्स और सुरक्षा खामियों की खोज करने के विकल्प प्रदान करता है। Horusec को डेवलपर CLI के माध्यम से और DevSecOps टीम द्वारा CI/CD मैट्रिक्स पर उपयोग किया जा सकता है।

हमारे [**प्रलेखन**](https://docs.horusec.io/docs/overview/) देखें, इसमें उन सभी टूल्स और भाषाओं की पूरी सूची मिलेगी जिनका Horusec विश्लेषण करता है।

<p align="center" margin="20 0"><img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec-complete-architecture.png" alt="architecture" width="100%" style="max-width:100%;"/></p>

### **आउटपुट उदाहरण देखें:**

<img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/usage_horusec.gif" alt="usage_gif" width="100%" style="max-width:100%;"/>

# **शुरुआत करें**

## **आवश्यकताएँ**

- Docker

Horusec को चलाने के लिए आपके सिस्टम में Docker इंस्टॉल होना आवश्यक है ताकि हम जिन सभी टूल्स का उपयोग करते हैं, वे चल सकें।
यदि आपके पास Docker नहीं है, तो हमारे पास एक [**flag**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags) `-D true` है, जो इस निर्भरता को अक्षम कर देगा, लेकिन इससे विश्लेषण की शक्ति कम हो जाएगी।
हम Docker के साथ उपयोग करने की सलाह देते हैं।

यदि आप commit authors `-G true` सक्षम करते हैं, तो एक `git` निर्भरता भी आवश्यक है।

## **Horusec इंस्टॉल करना**
### **Mac या Linux**
```
make install
```

या

```sh
curl -fsSL https://raw.githubusercontent.com/ZupIT/horusec/master/deployments/scripts/install.sh | bash -s latest
```

#### **इंस्टॉलेशन जांचें**
```bash
horusec version
```

### **Windows**
- **amd64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_amd64.exe" -o "./horusec.exe" -L
    ```

- **arm64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_arm64.exe" -o "./horusec.exe" -L
    ```

#### **इंस्टॉलेशन जांचें**
```bash
./horusec.exe version
```

### **और भी विकल्प**

- आप हमारे [**रिलीज पेज**](https://github.com/ZupIT/horusec/releases) पर सभी बाइनरी और उनके वर्शन पा सकते हैं।

- इंस्टॉल करने के अधिक विवरण के लिए [**प्रलेखन**](https://docs.horusec.io/docs/cli/installation) देखें। 


## **उपयोग**
### **CLI उपयोग**
horusec-cli का उपयोग करने और एप्लिकेशन की कमजोरियों की जांच करने के लिए निम्नलिखित कमांड का उपयोग करें:
```bash
horusec start -p .
```
> जब horusec कोई विश्लेषण शुरू करता है, तो यह **`.horusec`** नामक एक फ़ोल्डर बनाता है। यह फ़ोल्डर आपके कोड को न बदलने का आधार है। हम अनुशंसा करते हैं कि आप अपनी **`.gitignore`** फ़ाइल में **`.horusec`** लाइन जोड़ें ताकि यह फ़ोल्डर आपके git सर्वर पर भेजने की आवश्यकता न हो।

### **Docker का उपयोग**
Horusec को docker इमेज **`horuszup/horusec-cli:latest`** के माध्यम से भी उपयोग किया जा सकता है।

इसे चलाने के लिए निम्नलिखित कमांड चलाएँ:
```sh
docker run -v /var/run/docker.sock:/var/run/docker.sock -v $(pwd):/src horuszup/horusec-cli:latest horusec start -p /src -P $(pwd)
```

- हमने एक वॉल्यूम बनाया है जिसमें प्रोजेक्ट है `-v $(pwd):/src`।

docker इमेज के साथ हमारे पास दो पथ हो सकते हैं जहाँ प्रोजेक्ट मिल सकता है।

`-p` फ्लैग कंटेनर के अंदर प्रोजेक्ट पथ को दर्शाता है, हमारे उदाहरण में `/src`।
`-P` फ्लैग कंटेनर के बाहर प्रोजेक्ट पथ को दर्शाता है, हमारे उदाहरण में `$(pwd)` है,
यह वॉल्यूम माउंट करने के लिए प्रोजेक्ट पथ पास करना भी आवश्यक होगा `-v $(pwd):/src`।

### **पुराने संस्करण**

Horusec का v1 अभी भी उपलब्ध है।

**चेतावनी:** v1 के साथ endpoint को बंद किया जाएगा, कृपया अपने CLI को v2 में अपग्रेड करें। अधिक विवरण के लिए [**प्रलेखन**](https://docs.horusec.io/docs/migrate-v1-to-v2/) देखें।

### **Mac या Linux**
``` sh
curl -fsSL https://horusec.io/bin/install.sh | bash -s latest
```

### **Windows**
```sh
curl "https://horusec.io/bin/latest/win_x64/horusec.exe" -o "./horusec.exe" && ./horusec.exe version
```

- पुराने बाइनरी इस endpoint पर मिल सकते हैं, जिसमें v1 का नवीनतम संस्करण **`v1.10.3`** शामिल है।
- v2 से, बाइनरी अब इस endpoint द्वारा वितरित नहीं किए जाएंगे, आप उन्हें [**रिलीज पेज**](https://github.com/ZupIT/horusec/releases) पर पा सकते हैं।

### **Horusec-Web एप्लिकेशन का उपयोग**
हमारे वेब इंटरफ़ेस के माध्यम से अपनी कमजोरियों का प्रबंधन करें। आप अपनी कमजोरियों के बारे में मेट्रिक्स का डैशबोर्ड, false positives का नियंत्रण, अनुमति टोकन, कमजोरियों का अद्यतन और बहुत कुछ प्राप्त कर सकते हैं।
[**वेब एप्लिकेशन**](https://github.com/ZupIT/horusec-platform) अनुभाग देखें और इसके बारे में पढ़ना जारी रखें।

नीचे दिए गए उदाहरण को देखें, यह Horusec वेब सेवाओं को विश्लेषण भेज रहा है:
```bash
horusec start -p <PATH_TO_YOUR_PROJECT> -a <YOUR_AUTHORIZATION_TOKEN>
```

[**Horusec Manager Web Service के माध्यम से अनुमति टोकन कैसे बनाएं, इसका ट्यूटोरियल देखें**](https://docs.horusec.io/docs/tutorials/how-to-create-an-authorization-token)।

**चेतावनी:** हमारी वेब सेवाएँ [**नए रिपोजिटरी**](https://github.com/ZupIT/horusec-platform) में स्थानांतरित कर दी गई हैं। आपको v2 में अपग्रेड करने की आवश्यकता है, देखें [**v1 से v2 में कैसे माइग्रेट करें**](https://docs.horusec.io/docs/migrate-v1-to-v2)।

### **Visual Studio Code का उपयोग**
आप Horusec के Visual Studio Code एक्सटेंशन का उपयोग करके अपने प्रोजेक्ट का विश्लेषण कर सकते हैं।
अधिक जानकारी के लिए, [**प्रलेखन देखें**](https://docs.horusec.io/docs/extensions/visual-studio-code/)।

### **Pipeline का उपयोग**
आप अपने प्रोजेक्ट का विश्लेषण तैनाती से पहले कर सकते हैं ताकि आपकी संस्था में अधिकतम सुरक्षा सुनिश्चित हो सके।
अधिक जानकारी के लिए, [**प्रलेखन देखें**](https://docs.horusec.io/docs/cli/installation/#installation-via-pipeline):

### **विशेषताएँ**
नीचे देखें: 
- 18 भाषाओं का एक साथ 20 अलग-अलग सुरक्षा टूल्स के साथ विश्लेषण करता है, जिससे सटीकता बढ़ती है;
- उनके ऐतिहासिक git में secrets और अन्य उजागर सामग्रियों की खोज करता है;
- आपका विश्लेषण पूरी तरह से कॉन्फ़िगर किया जा सकता है, [**सभी CLI उपलब्ध संसाधन देखें**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags)।

## **प्रलेखन**
आप Horusec का प्रलेखन हमारे [**वेबसाइट**](https://docs.horusec.io/docs/overview/) पर पा सकते हैं।

## **रोडमैप**
हमारे पास एक प्रोजेक्ट [**रोडमैप**](ROADMAP.md) है, आप इसमें योगदान दे सकते हैं!

Horusec के अन्य रिपोजिटरी भी हैं, उन्हें देखें:

- [**Horusec Platform**](https://github.com/ZupIT/horusec-platform)
- [**Horusec DevKit**](https://github.com/ZupIT/horusec-devkit)
- [**Horusec Engine**](https://github.com/ZupIT/horusec-engine)
- [**Horusec Operator**](https://github.com/ZupIT/horusec-operator)
- [**Horusec VsCode**](https://github.com/ZupIT/horusec-vscode-plugin)

## **योगदान**

बेझिझक उपयोग करें, सुधारों की सिफारिश करें, या नई कार्यान्वयन में योगदान करें।

हमारी [**योगदान गाइड**](https://raw.githubusercontent.com/ZupIT/horusec/main/CONTRIBUTING.md) देखें ताकि आप हमारे विकास प्रक्रिया, बगफिक्स और सुधार सुझाने के तरीके के बारे में जान सकें।

### **डेवलपर सर्टिफिकेट ऑफ ओरिजिन - DCO**

यह परियोजना और डेवलपर्स के लिए एक सुरक्षा परत है। यह अनिवार्य है।

DCO को अपनी कमिट्स में जोड़ने के लिए नीचे दिए गए दो तरीकों में से किसी एक का पालन करें:

**1. कमांड लाइन**  
निम्नलिखित कदमों का पालन करें:  
**कदम 1:** अपने स्थानीय git वातावरण में वही नाम और ईमेल जोड़ें जो आपके GitHub अकाउंट में दर्ज है। यह समीक्षाओं और सुझावों के दौरान कमिट्स को मैन्युअली साइन करने में मदद करता है।

```
git config --global user.name “Name”
git config --global user.email “email@domain.com.br”
```
**कदम 2:** git commit कमांड में `'-s'` फ्लैग के साथ Signed-off-by लाइन जोड़ें:

```
$ git commit -s -m "This is my commit message"
```
**2. GitHub वेबसाइट**

आप GitHub समीक्षाओं और सुझावों के दौरान भी अपने कमिट्स को मैन्युअली साइन कर सकते हैं, नीचे दिए गए चरणों का पालन करें:

**कदम 1:** जब कमिट चेंजेज बॉक्स खुले, तो कमेंट बॉक्स में मैन्युअली अपना सिग्नेचर टाइप करें या पेस्ट करें, उदाहरण देखें:

```
Signed-off-by: Name < e-mail address >
```

इस विधि के लिए, आपका नाम और ईमेल वही होना चाहिए जो आपके GitHub खाते में पंजीकृत है।

## **आचार संहिता**
कृपया हमारे प्रोजेक्ट के साथ अपनी सभी इंटरैक्शन में [**आचार संहिता**](https://github.com/ZupIT/horusec/blob/main/CODE_OF_CONDUCT.md) का पालन करें।

## **लाइसेंस**
[**Apache License 2.0**](https://raw.githubusercontent.com/ZupIT/horusec/main/LICENSE)।

## **समुदाय**

हमसे बेझिझक संपर्क करें:

- [**GitHub Issues**](https://github.com/ZupIT/horusec/issues)
- यदि आपके कोई प्रश्न या विचार हैं, तो हमारे [**Zup Open Source Forum**](https://forum.zup.com.br) में बातचीत करें।

यह परियोजना सभी योगदानकर्ताओं की वजह से अस्तित्व में है। आप शानदार हैं! ❤️ 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---