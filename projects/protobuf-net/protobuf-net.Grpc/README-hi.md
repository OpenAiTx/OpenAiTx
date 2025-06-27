# <img src="https://protogen.marcgravell.com/images/protobuf-net.svg" alt="protobuf-net logo" width="45" height="45"> protobuf-net.Grpc

[![Build status](https://ci.appveyor.com/api/projects/status/en9i5mp471ci6ip3/branch/main?svg=true)](https://ci.appveyor.com/project/StackExchange/protobuf-net-grpc/branch/main)

`protobuf-net.Grpc` gRPC पर सेवाओं के लिए कोड-फर्स्ट सपोर्ट जोड़ता है, चाहे वह नेटिव `Grpc.Core` API हो या पूरी तरह से मैनेज्ड `Grpc.Net.Client` / `Grpc.AspNetCore.Server` API।

यह उन सभी .NET भाषाओं पर काम करना चाहिए जो कुछ हद तक सामान्य .NET टाइप मॉडल उत्पन्न कर सकती हैं।

- [शुरुआत करें](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)
- [संपूर्ण प्रलेखन](https://protobuf-net.github.io/protobuf-net.Grpc/)
- [निर्माण/उपयोग `protobuf-net.BuildTools` के माध्यम से उपलब्ध](https://protobuf-net.github.io/protobuf-net/build_tools)

इस्तेमाल करना उतना ही सरल है जितना कि अपनी सेवा-संविदा के लिए एक इंटरफ़ेस घोषित करना:

``` c#
[ServiceContract]
public interface IMyAmazingService {
    ValueTask<SearchResponse> SearchAsync(SearchRequest request);
    // ...
}
```

फिर या तो उस इंटरफ़ेस को सर्वर के लिए लागू करें:

``` c#
public class MyServer : IMyAmazingService {
    // ...
}
```

या सिस्टम से क्लाइंट के लिए पूछें:

``` c#
var client = http.CreateGrpcService<IMyAmazingService>();
var results = await client.SearchAsync(request);
```

यह .proto में सेवा के समकक्ष होगा:

``` proto
service MyAmazingService {
    rpc Search (SearchRequest) returns (SearchResponse) {}
	// ...
}
```

स्पष्ट रूप से आपको इसे uri आदि बताना होगा - देखें [शुरुआत करें](https://protobuf-net.github.io/protobuf-net.Grpc/gettingstarted)। आमतौर पर कॉन्फ़िगरेशन कन्वेंशन-आधारित होती है, लेकिन
अगर आप चाहें: [विभिन्न कॉन्फ़िगरेशन विकल्प](https://protobuf-net.github.io/protobuf-net.Grpc/configuration) उपलब्ध हैं।

## इसे प्राप्त करना

सभी चीजें nuget पर प्री-बिल्ट पैकेज के रूप में उपलब्ध हैं; विशेष रूप से, शायद आप इनमें से एक चाहेंगे:

- [`protobuf-net.Grpc.AspNetCore`](https://www.nuget.org/packages/protobuf-net.Grpc.AspNetCore) उन सर्वरों के लिए जो ASP.NET Core 3.1 का उपयोग करते हैं
- [`protobuf-net.Grpc.Native`](https://www.nuget.org/packages/protobuf-net.Grpc.Native) उन क्लाइंट या सर्वरों के लिए जो नेटिव/अनमैनेज्ड API का उपयोग करते हैं
- [`protobuf-net.Grpc`](https://www.nuget.org/packages/protobuf-net.Grpc) और [`Grpc.Net.Client`](https://www.nuget.org/packages/Grpc.Net.Client/) उन क्लाइंट के लिए जो .NET Core 3.1 पर `HttpClient` का उपयोग करते हैं

[उदाहरण C#, VB और F# में उपलब्ध हैं](https://github.com/protobuf-net/protobuf-net.Grpc/tree/main/examples/pb-net-grpc)।

## और कुछ?

`protobuf-net.Grpc` [Marc Gravell](https://github.com/mgravell) ([@marcgravell](https://twitter.com/marcgravell)) द्वारा बनाया और अनुरक्षित किया गया है, जो `protobuf-net` के लेखक हैं।

यह [grpc](https://github.com/grpc/) के टूल्स का उपयोग करता है, लेकिन उस प्रोजेक्ट के साथ औपचारिक रूप से संबद्ध, सम्बद्ध या अनुमोदित नहीं है।

मैं आपकी प्रतिक्रिया की प्रतीक्षा कर रहा हूँ, और यदि यह आपके बहुत समय की बचत कर सकता है, तो आप हमेशा स्वागत हैं [![मुझे कॉफी खरीदें](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/marcgravell)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---