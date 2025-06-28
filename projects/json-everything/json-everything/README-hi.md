[![Build & Test](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml/badge.svg?branch=master&event=push)](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml)
[![Test results](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/gregsdennis/28607f2d276032f4d9a7f2c807e44df7/raw/test-results-badge.json)](https://github.com/json-everything/json-everything/actions?query=workflow%3A%22Build+%26+Test%22)
[![Percentage of issues still open](http://isitmaintained.com/badge/open/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Percentage of issues still open")
[![Average time to resolve an issue](http://isitmaintained.com/badge/resolution/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Average time to resolve an issue")
[![License](https://img.shields.io/github/license/json-everything/json-everything)](https://github.com/json-everything/json-everything/blob/master/LICENSE)

## `json-everything` क्या है?

`json-everything` के पीछे मुख्य दर्शन यह है कि सामान्य JSON कार्यक्षमता को _System.Text.Json_ क्षेत्र में अच्छा समर्थन मिले।

पहला कदम यह देखना है कि क्या किसी दिए गए फंक्शन को सपोर्ट करने वाले अन्य प्रोजेक्ट्स पहले से मौजूद हैं।

अगर हाँ, तो वह प्रयास शायद यहाँ डुप्लिकेट नहीं होगा। नीचे आपको कुछ अन्य प्रोजेक्ट्स की सूची मिलेगी जो JSON के साथ कुछ शानदार काम कर रहे हैं।

अन्यथा, इस प्रोजेक्ट के लिए उस पर विचार किया जा सकता है।

<table>
<thead>
<tr>
<th width="207">प्लेयग्राउंड</th>
<th width="207">डॉक्युमेंटेशन</th>
<th width="207">ब्लॉग</th>
<th width="207">इंटरएक्टिव लर्निंग</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://json-everything.net"><img src="Resources/json-animated.webp" alt="Try it online" title="Try it online" height="50"><br>json-everything.net</a></td>
<td align="center"><a href="https://docs.json-everything.net"><img src="Resources/docs-icon.png" alt="Documentation" title="Documentation" height="50"><br>docs.json-everything.net</a></td>
<td align="center"><a href="https://blog.json-everything.net"><img src="Resources/blog-icon.png" alt="Blog" title="Blog" height="50"><br>blog.json-everything.net</a></td>
<td align="center"><a href="https://learn.json-everything.net"><img src="Resources/learn-icon.png" alt="Learn" title="Learn" height="50"><br>learn.json-everything.net</a></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr>
<th width="276">चर्चा करें</th>
<th width="276">पूछें</th>
<th width="276">निर्मित है</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://join.slack.com/t/json-everything/shared_invite/zt-4klcm69x-_MA8Z2ZSZ4JNu_d3lQOVPg"><img src="Resources/Slack.png" alt="Slack" title="Slack" height="50"></a></td>
<td align="center"><a href="https://stackoverflow.com/questions/tagged/json-everything"><img src="Resources/stackoverflow.png" alt="StackOverflow" title="StackOverflow" height="50"></a></td>
<td align="center"><a href="http://www.jetbrains.com/resharper"><img src="Resources/Resharper.svg" alt="Made with Jetbrains Resharper" title="Made with Jetbrains Resharper" height="50"></a></td>
</tr>
</tbody>
</table>

## बॉक्स में क्या है?

असल में कई बॉक्स हैं। हर एक कार्यक्षमता को अपनी खुद की लाइब्रेरी में विभाजित किया गया है, ताकि आप अपनी जरूरत के अनुसार चुन सकें।

सभी लाइब्रेरी .Net Standard 2.0 और .Net 8 पर बनाई गई हैं।

<table>
<tbody>
<tr>
<td>JsonSchema.Net<br><a href="https://www.nuget.org/packages/JsonSchema.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.svg?svg=true"></img></a></td>
<td><a href="https://json-schema.org">JSON Schema</a>, ड्राफ्ट 6 और उच्च</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.svg?svg=true"></img></a></td>
<td>.Net टाइप्स से स्कीमा का निर्माण</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation.DataAnnotations<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation.DataAnnotations/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img></a></td>
<td><em>System.ComponentModel.DataAnnotations</em> के लिए स्कीमा निर्माण समर्थन।</td>
</tr>
<tr>
<td>JsonSchema.Net.DataGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.DataGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.DataGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.DataGeneration.svg?svg=true"></img></a></td>
<td>रैंडम इंस्टेंस डेटा जेनरेशन (<a href="https://github.com/bchavez/Bogus">Bogus</a> द्वारा संचालित)</td>
</tr>
<tr>
<td>JsonSchema.Net.Data<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Data/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Data.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Data.svg?svg=true"></img></a></td>
<td>इंस्टेंस और बाहरी डेटा एक्सेस के लिए एक शब्दावली</td>
</tr>
<tr>
<td>JsonSchema.Net.ArrayExt<br><a href="https://www.nuget.org/packages/JsonSchema.Net.ArrayExt/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.ArrayExt.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.ArrayExt.svg?svg=true"></img></a></td>
<td>एरे वेलिडेशन का विस्तार करने के लिए एक शब्दावली</td>
</tr>
<tr>
<td>JsonSchema.Net.OpenApi<br><a href="https://www.nuget.org/packages/JsonSchema.Net.OpenApi/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.OpenApi.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.OpenApi.svg?svg=true"></img></a></td>
<td><a href="https://www.openapis.org/">OpenApi 3.1</a> शब्दावली विस्तार (<a href="https://github.com/gregsdennis/Graeae">Graeae</a> द्वारा उपयोग किया गया)</td>
</tr>
<tr>
<td>JsonPath.Net<br><a href="https://www.nuget.org/packages/JsonPath.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonPath.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonPath.Net.svg?svg=true"></img></a></td>
<td>JSON Path (<a href="https://tools.ietf.org/html/rfc9535">RFC 9535</a>)</td>
</tr>
<tr>
<td>JsonPatch.Net<br><a href="https://www.nuget.org/packages/JsonPatch.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonPatch.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonPatch.Net.svg?svg=true"></img></a></td>
<td>JSON Patch (<a href="https://tools.ietf.org/html/rfc6902">RFC 6902</a>)</td>
</tr>
<tr>
<td>JsonPointer.Net<br><a href="https://www.nuget.org/packages/JsonPointer.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonPointer.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonPointer.Net.svg?svg=true"></img></a></td>
<td>JSON Pointer (<a href="https://tools.ietf.org/html/rfc6901">RFC 6901</a>) और Relative JSON Pointer (<a href="https://tools.ietf.org/id/draft-handrews-relative-json-pointer-00.html">स्पेसिफिकेशन</a>)</td>
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
<td>सामान्य उपयोग के एक्सटेंशन जो शायद <em>System.Text.Json[.Nodes]</em> में शामिल होने चाहिए थे लेकिन नहीं हुए</td>
</tr>
<tr>
<td>Yaml2JsonNode<br><a href="https://www.nuget.org/packages/Yaml2JsonNode/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Yaml2JsonNode.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Yaml2JsonNode.svg?svg=true"></img></a></td>
<td><a href="https://github.com/aaubry/YamlDotNet">YamlDotNet</a> में YAML डॉक्युमेंट मॉडल और <code>JsonNode</code> के बीच (दोनों दिशाओं में) रूपांतरण।</td>
</tr>
</tbody>
</table>

ऊपर दी गई सभी लाइब्रेरीज़ अपनी संबंधित स्पेसिफिकेशन के लिए पूर्ण समर्थन प्रदान करती हैं।

_JsonSchema.Net_ के लिए एरर मैसेज अनुवाद इन भाषाओं में उपलब्ध हैं:

- इटालियन `it`
- नॉर्वेजियन `nb-NO`
- पोलिश `pl-PL`
- रूसी `ru`
- स्पैनिश `es`
- स्वीडिश `sv-SE`
- तुर्की `tr-TR`

***नोट** प्रत्येक भाषा पैक अपनी खुद की Nuget पैकेज के रूप में आता है।*

आप [Bowtie](https://bowtie-json-schema.github.io/bowtie) पर JSON Schema Test Suite के परिणाम भी देख सकते हैं, जो विभिन्न प्लेटफार्मों पर कई इम्प्लीमेंटेशन के खिलाफ टेस्ट सूट चलाता है।

***अस्वीकरण** मेरी लाइब्रेरी, _JsonSchema.Net_, वेबसाइट https://jsonschema.net से संबंधित या संबद्ध नहीं है, सिवाय इसके कि दोनों ही बेहतरीन JSON Schema टूल्स हैं।*

### डिप्रिकेटेड पैकेज

ये पैकेज भी कभी इस सूट का हिस्सा रहे हैं, लेकिन अब समर्थित नहीं हैं।

<table>
<tbody>
<tr>
<td>JsonSchema.Net.CodeGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.CodeGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.CodeGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.CodeGeneration.svg?svg=true"></img></a></td>
<td>स्कीमा से C# कोड का निर्माण</td>
<td><a href="https://github.com/corvus-dotnet/Corvus.JsonSchema">Corvus.JsonSchema</a> के पक्ष में डिप्रिकेटेड</td>
</tr>
</tbody>
</table>


## _System.Text.Json_ का समर्थन करने वाले अन्य प्रोजेक्ट्स

अगर आपको यहां वह नहीं मिलता जिसकी तलाश है, तो कृपया इन उत्कृष्ट प्रोजेक्ट्स में से किसी एक को आज़माएं:

- [JsonCons.Net](https://github.com/danielaparker/JsonCons.Net) द्वारा [@danielaparker](https://github.com/danielaparker)
  - JSON Pointer
  - JSON Patch
  - JSON Merge Patch
  - JSON Path
  - JMES Path
- [Corvus.JsonSchema](https://github.com/corvus-dotnet/Corvus.JsonSchema) द्वारा [@mwadams](https://github.com/mwadams)
  - C# कोड जेनरेशन पर केंद्रित JSON Schema वैलिडेशन
- (आगे और भी आएंगे)

यदि आप JSON का उपयोग किसी ऐसे कार्य के लिए करते हैं जो इस सूट या ऊपर दिए गए प्रोजेक्ट्स में शामिल किसी लाइब्रेरी द्वारा कवर नहीं किया गया है, तो [फीचर इश्यू बनाएं](https://github.com/json-everything/json-everything/issues/new?assignees=&labels=feature&projects=&template=New_function.yml)।

यदि आप कोई और प्रोजेक्ट मेंटेन करते हैं या जानते हैं जो _System.Text.Json_ को एक्सटेंड करता है, तो मैं उसे यहां सूचीबद्ध करना चाहूंगा, कृपया [जनरल इश्यू बनाएं](https://github.com/json-everything/json-everything/issues/new) और मुझे इसके बारे में बताएं।

## योगदान

कृपया अधिक जानकारी के लिए [आचार संहिता](./CODE_OF_CONDUCT.md) और [CONTRIBUTING](./CONTRIBUTING.md) फ़ाइल देखें।

## प्रायोजन

यदि ये लाइब्रेरीज़ आपके लिए उपयोगी रहीं और आप निरंतर विकास को बढ़ावा देना चाहते हैं, तो कृपया [मेंटेनर को प्रायोजित करने](https://github.com/sponsors/gregsdennis) पर विचार करें।

## .NET फाउंडेशन

यह प्रोजेक्ट [.NET Foundation](https://dotnetfoundation.org) द्वारा समर्थित है।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---