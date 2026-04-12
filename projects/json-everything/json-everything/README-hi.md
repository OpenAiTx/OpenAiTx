> [!IMPORTANT]
> इस प्रोजेक्ट की दीर्घकालिक स्थिरता सुनिश्चित करने के लिए, एक मासिक अनुरक्षण शुल्क लागू किया गया है। यह शुल्क उन सभी संगठनों या उपयोगकर्ताओं द्वारा भुगतान किया जाना आवश्यक है, जो इस प्रोजेक्ट की किसी भी लाइब्रेरी का उपयोग करते हुए राजस्व उत्पन्न करते हैं। आप यह शुल्क [GitHub Sponsors](https://github.com/sponsors/gregsdennis) के माध्यम से चुका सकते हैं।
>
> इसे लागू करने के लिए, बाइनरी रिलीज़ पर EULA को रिपॉजिटरी और Nuget पैकेज में जोड़ा गया है, जिसमें अनुरक्षण शुल्क का भुगतान आवश्यक है।
>
> किसे शुल्क देना अनिवार्य है और अन्य सामान्य प्रश्नों के लिए कृपया [Open Source Maintenance Fee](https://opensourcemaintenancefee.org/consumers/) संगठन पृष्ठ देखें।

<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=json-everything&project=json-everything&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

[![Build & Test](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml/badge.svg?branch=master&event=push)](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml)
[![Test results](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/gregsdennis/28607f2d276032f4d9a7f2c807e44df7/raw/test-results-badge.json)](https://github.com/json-everything/json-everything/actions?query=workflow%3A%22Build+%26+Test%22)
[![Percentage of issues still open](http://isitmaintained.com/badge/open/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Percentage of issues still open")
[![किसी समस्या को हल करने का औसत समय](http://isitmaintained.com/badge/resolution/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "किसी समस्या को हल करने का औसत समय")
[![लाइसेंस](https://img.shields.io/github/license/json-everything/json-everything)](https://github.com/json-everything/json-everything/blob/master/LICENSE)

## `json-everything` क्या है?

`json-everything` के पीछे मुख्य दर्शन यह सुनिश्चित करना है कि सामान्य JSON कार्यक्षमता को _System.Text.Json_ क्षेत्र में अच्छा समर्थन मिले।

पहला कदम यह है कि जांचा जाए कि क्या कोई अन्य परियोजनाएँ हैं जो किसी दिए गए फंक्शन का समर्थन करती हैं।

यदि ऐसा है, तो संभवतः उस प्रयास को यहाँ दोहराया नहीं जाएगा। थोड़ा नीचे आपको अन्य परियोजनाओं की एक सूची मिलेगी जो JSON के साथ कुछ शानदार कार्य कर रही हैं।

अन्यथा, इसे इस परियोजना के लिए विचार किया जा सकता है।

<table>
<thead>
<tr>
<th width="207">प्लेग्राउंड</th>
<th width="207">प्रलेखन</th>
<th width="207">ब्लॉग</th>
<th width="207">इंटरएक्टिव लर्निंग</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/json-animated.webp" alt="ऑनलाइन आज़माएँ" title="ऑनलाइन आज़माएँ" height="50"><br>json-everything.net</a></td>
<td align="center"><a href="https://docs.json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/docs-icon.png" alt="प्रलेखन" title="प्रलेखन" height="50"><br>docs.json-everything.net</a></td>
<td align="center"><a href="https://blog.json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/blog-icon.png" alt="ब्लॉग" title="ब्लॉग" height="50"><br>blog.json-everything.net</a></td>
<td align="center"><a href="https://learn.json-everything.net"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/learn-icon.png" alt="सीखें" title="सीखें" height="50"><br>learn.json-everything.net</a></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr>
<th width="276">चर्चा करें</th>
<th width="276">पूछें</th>
<th width="276">इसके साथ बनाया गया</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://join.slack.com/t/json-everything/shared_invite/zt-3cfmgde04-o09VBqj6YfpudxTuI3aRhA"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/Slack.png" alt="Slack" title="Slack" height="50"></a></td>
<td align="center"><a href="https://stackoverflow.com/questions/tagged/json-everything"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/stackoverflow.png" alt="StackOverflow" title="StackOverflow" height="50"></a></td>
<td align="center"><a href="http://www.jetbrains.com/resharper"><img src="https://raw.githubusercontent.com/json-everything/json-everything/master/Resources/Resharper.svg" alt="Made with Jetbrains Resharper" title="Made with Jetbrains Resharper" height="50"></a></td>
</tr>
</tbody>
</table>

## बॉक्स में क्या है?

असल में कई बॉक्स हैं। प्रत्येक कार्यक्षमता को इसकी अपनी लाइब्रेरी में विभाजित किया गया है, ताकि आप अपनी आवश्यकता अनुसार एक या अधिक का चयन कर सकें।

सभी लाइब्रेरी .Net Standard 2.0 और .Net 8 के लिए बनाई गई हैं।

<table>
<tbody>
<tr>
<td>JsonSchema.Net<br><a href="https://www.nuget.org/packages/JsonSchema.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.svg?svg=true"></img></a></td>
<td><a href="https://json-schema.org">JSON Schema</a>, ड्राफ्ट 6 और उससे ऊपर</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.svg?svg=true"></img></a></td>
<td>.Net टाइप्स से स्कीमा जनरेशन</td>
</tr>
<tr>
<td>JsonSchema.Net.Api<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Api/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Api.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Api.svg?svg=true"></img></a></td>
<td>ASP.Net API के लिए JSON Schema वेलिडेशन</td>
</tr>
<tr>
<tr>
<td>JsonSchema.Net.Generation.DataAnnotations<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation.DataAnnotations/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img></a></td>
<td><em>System.ComponentModel.DataAnnotations</em> के लिए स्कीमा जनरेशन सपोर्ट।</td>
</tr>
<tr>
<td>JsonSchema.Net.DataGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.DataGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.DataGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.DataGeneration.svg?svg=true"></img></a></td>
<td>रैंडम इंस्टेंस डेटा जनरेशन (<a href="https://github.com/bchavez/Bogus">Bogus</a> द्वारा संचालित)</td>
</tr>
<tr>
<td>JsonSchema.Net.Data<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Data/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Data.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Data.svg?svg=true"></img></a></td>
<td>इंस्टेंस और बाहरी डेटा एक्सेस करने के लिए शब्दावली</td>
</tr>
<tr>
<td>JsonSchema.Net.ArrayExt<br><a href="https://www.nuget.org/packages/JsonSchema.Net.ArrayExt/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.ArrayExt.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.ArrayExt.svg?svg=true"></img></a></td>
<td>ऐरे वेलिडेशन को बढ़ाने के लिए शब्दावली</td>
</tr>
<tr>
<td>JsonSchema.Net.OpenApi<br><a href="https://www.nuget.org/packages/JsonSchema.Net.OpenApi/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.OpenApi.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.OpenApi.svg?svg=true"></img></a></td>
<td><a href="https://www.openapis.org/">OpenApi 3.1</a> शब्दावली विस्तार (जिसका उपयोग <a href="https://github.com/gregsdennis/Graeae">Graeae</a> द्वारा किया जाता है)</td>
</tr>
<tr>
<td>JsonPath.Net<br><a href="https://www.nuget.org/packages/JsonPath.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonPath.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonPath.Net.svg?svg=true"></img></a></td>
<td>JSON पाथ (<a href="https://tools.ietf.org/html/rfc9535">RFC 9535</a>)</td>
</tr>
<tr>
<td>JsonPatch.Net<br><a href="https://www.nuget.org/packages/JsonPatch.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonPatch.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonPatch.Net.svg?svg=true"></img></a></td>
<td>JSON पैच (<a href="https://tools.ietf.org/html/rfc6902">RFC 6902</a>)</td>
</tr>
<tr>
<td>JsonPointer.Net<br><a href="https://www.nuget.org/packages/JsonPointer.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonPointer.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonPointer.Net.svg?svg=true"></img></a></td>
<td>JSON पॉइंटर (<a href="https://tools.ietf.org/html/rfc6901">RFC 6901</a>) और रिलेटिव JSON पॉइंटर (<a href="https://tools.ietf.org/id/draft-handrews-relative-json-pointer-00.html">स्पेसिफिकेशन</a>)</td>
</tr>
<tr>
<td>JsonLogic<br><a href="https://www.nuget.org/packages/JsonLogic/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonLogic.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonLogic.svg?svg=true"></img></a></td>
<td>JsonLogic (<a href="https://jsonlogic.com">वेबसाइट</a>)</td>
</tr>
<tr>
<td>JsonE.Net<br><a href="https://www.nuget.org/packages/JsonE.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonE.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonE.Net.svg?svg=true"></img></a></td>
<td>JSON-e (<a href="https://json-e.js.org/">वेबसाइट</a>)</td>
</tr>
<tr>
<td>Json.More.Net<br><a href="https://www.nuget.org/packages/Json.More.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Json.More.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Json.More.Net.svg?svg=true"></img></a></td>
<td>सामान्य उपयोग एक्सटेंशन, जो शायद <em>System.Text.Json[.Nodes]</em> में शामिल होने चाहिए थे लेकिन नहीं हुए</td>
</tr>
<tr>
<td>Yaml2JsonNode<br><a href="https://www.nuget.org/packages/Yaml2JsonNode/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Yaml2JsonNode.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Yaml2JsonNode.svg?svg=true"></img></a></td>
<td><a href="https://github.com/aaubry/YamlDotNet">YamlDotNet</a> में YAML दस्तावेज़ मॉडल और <code>JsonNode</code> के बीच रूपांतरण (दोनों दिशाओं में)।</td>
</tr>
</tbody>
</table>
ऊपर दी गई सभी लाइब्रेरीज़ अपने संबंधित विनिर्देशों के लिए पूर्ण समर्थन प्रदान करती हैं।

_JsonSchema.Net_ के लिए त्रुटि संदेश अनुवाद इन भाषाओं में उपलब्ध हैं:

- इतालवी `it`
- नॉर्वेजियन `nb-NO`
- पोलिश `pl-PL`
- पुर्तगाली `pt`
- रूसी `ru`
- स्पेनिश `es`
- स्वीडिश `sv-SE`
- तुर्की `tr-TR`

***नोट** प्रत्येक भाषा पैक स्वयं के Nuget पैकेज के रूप में उपलब्ध है।*

आप [Bowtie](https://bowtie-json-schema.github.io/bowtie) पर JSON Schema Test Suite के परिणाम भी देख सकते हैं, जो विभिन्न प्लेटफार्मों पर कई इम्प्लीमेंटेशन के साथ टेस्ट सूट चलाता है।

***अस्वीकरण** मेरी लाइब्रेरी, _JsonSchema.Net_, का वेबसाइट https://jsonschema.net से कोई संबंध या जुड़ाव नहीं है, सिवाय इसके कि दोनों उत्कृष्ट JSON Schema टूल्स हैं।*

### अप्रचलित पैकेज

ये पैकेज भी इस सूट का हिस्सा रहे हैं लेकिन अब समर्थित नहीं हैं।

<table>
<tbody>
<tr>
<td>JsonSchema.Net.CodeGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.CodeGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.CodeGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.CodeGeneration.svg?svg=true"></img></a></td>
<td>स्कीमा से C# कोड का जनरेशन</td>
<td><a href="https://github.com/corvus-dotnet/Corvus.JsonSchema">Corvus.JsonSchema</a> के पक्ष में अप्रचलित</td>
</tr>
</tbody>
</table>


## अन्य प्रोजेक्ट्स द्वारा _System.Text.Json_ समर्थन

यदि आपको यहां वह नहीं मिलता जो आप खोज रहे हैं, तो कृपया इन उत्कृष्ट प्रोजेक्ट्स में से किसी एक को आज़माएं:

- [JsonCons.Net](https://github.com/danielaparker/JsonCons.Net) [@danielaparker](https://github.com/danielaparker) द्वारा

  - JSON पॉइंटर
  - JSON पैच
  - JSON मर्ज पैच
  - JSON पाथ
  - JMES पाथ
- [Corvus.JsonSchema](https://github.com/corvus-dotnet/Corvus.JsonSchema) द्वारा [@mwadams](https://github.com/mwadams)
  - C# कोड जनरेशन केंद्रित JSON स्कीमा मान्यकरण
- (अधिक जल्द ही आएगा)

यदि आप JSON का उपयोग किसी ऐसे कार्य के लिए करते हैं जो इस सूट में या ऊपर दिए गए प्रोजेक्ट्स में किसी लाइब्रेरी द्वारा कवर नहीं किया गया है, तो [फीचर इश्यू बनाएं](https://github.com/json-everything/json-everything/issues/new?assignees=&labels=feature&projects=&template=New_function.yml)।

यदि आप _System.Text.Json_ को बढ़ाने वाले किसी अन्य प्रोजेक्ट को जानते हैं या उसका रखरखाव करते हैं, जिसे यहां सूचीबद्ध किया जाना चाहिए, तो कृपया [जनरल इश्यू बनाएं](https://github.com/json-everything/json-everything/issues/new) और मुझे सूचित करें।

## योगदान

कृपया अधिक जानकारी के लिए [कोड ऑफ कंडक्ट](https://raw.githubusercontent.com/json-everything/json-everything/master/./CODE_OF_CONDUCT.md) और [CONTRIBUTING](https://raw.githubusercontent.com/json-everything/json-everything/master/./CONTRIBUTING.md) फ़ाइल देखें।

## प्रायोजन

यदि आपको ये लाइब्रेरीज़ उपयोगी लगी हैं और आप निरंतर विकास को बढ़ावा देना चाहते हैं, तो कृपया [मेंटेनर्स को स्पॉन्सर करें](https://github.com/sponsors/gregsdennis)।

## .NET फाउंडेशन

यह परियोजना [.NET फाउंडेशन](https://dotnetfoundation.org) द्वारा समर्थित है।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-12

---