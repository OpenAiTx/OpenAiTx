# .NET Aspire

[![Tests](https://github.com/dotnet/aspire/actions/workflows/tests.yml/badge.svg?branch=main&event=push)](https://github.com/dotnet/aspire/actions/workflows/tests.yml)
[![Build Status](https://dev.azure.com/dnceng-public/public/_apis/build/status%2Fdotnet%2Faspire%2Fdotnet.aspire?branchName=main)](https://dev.azure.com/dnceng-public/public/_build/latest?definitionId=274&branchName=main)
[![Help Wanted](https://img.shields.io/github/issues/dotnet/aspire/help%20wanted?style=flat&color=%24EC820&label=help%20wanted)](https://github.com/dotnet/aspire/labels/help%20wanted)
[![Good First Issue](https://img.shields.io/github/issues/dotnet/aspire/good%20first%20issue?style=flat&color=%24EC820&label=good%20first%20issue)](https://github.com/dotnet/aspire/labels/good%20first%20issue)
[![Discord](https://img.shields.io/discord/732297728826277939?style=flat&logo=discord&logoColor=white&label=Join%20our%20Discord&labelColor=512bd4&color=cyan)](https://discord.com/invite/h87kDAHQgJ)

## .NET Aspire क्या है?

.NET Aspire एक अभिमत, क्लाउड के लिए तैयार स्टैक है जो ऑब्ज़र्वेबल, प्रोडक्शन के लिए तैयार, वितरित अनुप्रयोगों के निर्माण के लिए है। .NET Aspire एक संग्रह के रूप में NuGet पैकेजों द्वारा उपलब्ध कराया जाता है, जो विशिष्ट क्लाउड-नेटिव आवश्यकताओं को संभालते हैं। क्लाउड-नेटिव ऐप्स आमतौर पर छोटे, आपस में जुड़े हुए हिस्सों या माइक्रोसर्विसेज़ से मिलकर बनते हैं, न कि एकल, मोनोलिथिक कोड बेस से। क्लाउड-नेटिव ऐप्स आमतौर पर बड़ी संख्या में सेवाओं का उपभोग करते हैं, जैसे कि डेटाबेस, मैसेजिंग और कैशिंग।

.NET Aspire निम्न में मदद करता है:

[Orchestration](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#orchestration): .NET Aspire मल्टी-प्रोजेक्ट एप्लिकेशनों और उनकी निर्भरताओं को चलाने और जोड़ने के लिए सुविधाएँ प्रदान करता है।

[Integrations](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#net-aspire-integrations): .NET Aspire इंटीग्रेशन सामान्यतः उपयोग की जाने वाली सेवाओं के लिए NuGet पैकेज हैं, जैसे कि Redis या Postgres, जिनमें मानकीकृत इंटरफेस होते हैं जो यह सुनिश्चित करते हैं कि वे आपके ऐप के साथ लगातार और निर्बाध रूप से जुड़ें।

[Tooling](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#project-templates-and-tooling): .NET Aspire प्रोजेक्ट टेम्पलेट्स और टूलिंग अनुभवों के साथ आता है, जो Visual Studio और dotnet CLI के लिए हैं, जो आपको .NET Aspire ऐप्स बनाने और उनके साथ इंटरैक्ट करने में मदद करते हैं।

और अधिक जानने के लिए, पूरी [.NET Aspire ओवरव्यू और डाक्यूमेंटेशन](https://learn.microsoft.com/dotnet/aspire/) पढ़ें। सैंपल्स [.NET Aspire सैंपल्स रिपॉज़िटरी](https://github.com/dotnet/aspire-samples) में उपलब्ध हैं। आप [eShop सैंपल यहाँ](https://github.com/dotnet/eshop) और [Azure वर्शन यहाँ](https://github.com/Azure-Samples/eShopOnAzure) देख सकते हैं।

## इस रिपॉज़िटरी में क्या है?

.NET Aspire एप्लिकेशन होस्ट, डैशबोर्ड, सर्विस डिस्कवरी इंफ्रास्ट्रक्चर, और सभी .NET Aspire इंटीग्रेशन। इसमें प्रोजेक्ट टेम्पलेट्स भी शामिल हैं।

## नवीनतम डेली बिल्ड्स का उपयोग करना

.NET Aspire को नवीनतम डेली बिल्ड के साथ उपयोग करने के लिए [docs/using-latest-daily.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/using-latest-daily.md) में निर्देशों का पालन करें।

## मैं योगदान कैसे कर सकता/सकती हूँ?

हम योगदान का स्वागत करते हैं! दुनिया भर के कई लोगों ने .NET को बेहतर बनाने में मदद की है।

रिपॉज़िटरी में कोड के साथ काम करने के लिए [docs/contributing.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/contributing.md) में दिए गए निर्देशों का पालन करें।

## सुरक्षा मुद्दों और सुरक्षा बग्स की रिपोर्टिंग

सुरक्षा मुद्दों और बग्स की रिपोर्ट निजी रूप से, ईमेल के माध्यम से, Microsoft Security Response Center (MSRC) <secure@microsoft.com> को करनी चाहिए। आपको 24 घंटे के भीतर उत्तर मिल जाना चाहिए। यदि किसी कारण से आपको उत्तर नहीं मिलता है, तो कृपया सुनिश्चित करने के लिए दोबारा ईमेल करें कि हमें आपका मूल संदेश प्राप्त हुआ है। आगे की जानकारी, जिसमें MSRC PGP कुंजी भी शामिल है, [Security TechCenter](https://www.microsoft.com/msrc/faqs-report-an-issue) में पाई जा सकती है। आप इन निर्देशों को इस रिपॉज़िटरी की [Security doc](https://raw.githubusercontent.com/dotnet/aspire/main/SECURITY.md) में भी देख सकते हैं।

संबंधित [Microsoft .NET Core और ASP.NET Core बग बाउंटी प्रोग्राम](https://www.microsoft.com/msrc/bounty-dot-net-core) के बारे में भी जानकारी देखें।

### .NET Aspire संसाधन और क्लाइंट इंटीग्रेशन द्वारा प्रयुक्त कंटेनरों पर नोट

.NET टीम उन तृतीय-पक्ष कंटेनरों के लिए, जिनके लिए हमारे पास API समर्थन है, विशिष्ट ग्राहक आवश्यकताओं के लिए उनकी उपयुक्तता का मूल्यांकन नहीं कर सकती।

आपको अपने, अपने नियोक्ता या अपनी सरकार की सुरक्षा और सुरक्षा आवश्यकताओं के साथ-साथ क्रिप्टोग्राफिक विनियमों और अन्य किसी भी नियामक या कॉर्पोरेट मानकों के अनुपालन के लिए Aspire के साथ उपयोग किए जाने वाले कंटेनरों का स्वयं मूल्यांकन करना चाहिए।

## .NET Foundation

.NET Aspire एक [.NET Foundation](https://www.dotnetfoundation.org/projects) प्रोजेक्ट है।

GitHub पर कई .NET संबंधित प्रोजेक्ट्स हैं।

* [.NET home repo](https://github.com/Microsoft/dotnet) - 100 से अधिक .NET प्रोजेक्ट्स के लिए लिंक, Microsoft और समुदाय दोनों से।
* [ASP.NET Core home](https://docs.microsoft.com/aspnet/core) - ASP.NET Core के बारे में सीखना शुरू करने के लिए सबसे अच्छी जगह।

इस प्रोजेक्ट ने समुदाय में अपेक्षित व्यवहार को स्पष्ट करने के लिए [Contributor Covenant](https://contributor-covenant.org) द्वारा परिभाषित आचार संहिता को अपनाया है। अधिक जानकारी के लिए, [.NET Foundation Code of Conduct](https://www.dotnetfoundation.org/code-of-conduct) देखें।

## लाइसेंस

इस रिपॉज़िटरी के कोड को [MIT](https://raw.githubusercontent.com/dotnet/aspire/main/LICENSE.TXT) लाइसेंस के अंतर्गत लाइसेंस प्राप्त है।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---