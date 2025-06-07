## FanImeTsf

यह [FanImeServer](https://github.com/fanlumaster/FanImeServer) का TSF अंत है।

नोटिस: अभी केवल 64-बिट ऐप्स को ही समर्थन है।

## कैसे बिल्ड करें

### आवश्यकताएँ

- Visual Studio 2022
- CMake
- vcpkg
- Python3
- gsudo

सुनिश्चित करें कि vcpkg और gsudo **Scoop** द्वारा इंस्टॉल किए गए हैं।

## बिल्ड के चरण

### बिल्ड

सबसे पहले, रिपॉजिटरी क्लोन करें,

```powershell
git clone --recursive https://github.com/fanlumaster/FanImeTsf.git
```

फिर, वातावरण तैयार करें,

```powershell
cd FanImeTsf
python .\scripts\prepare_env.py
```

फिर, बिल्ड करें,

```powershell
.\scripts\lcompile.ps1
```

### इंस्टॉल करें

पावरशेल को व्यवस्थापक के रूप में शुरू करें, सुनिश्चित करें कि आपने सिस्टम का `Enable sudo` विकल्प चालू किया है।

![](https://i.postimg.cc/zJCn9Cnn/image.png)

फिर, `C:\Program Files\` में `FanImeTsf` नामक एक फ़ोल्डर बनाएं, और `FanImeTsf.dll` को उसमें कॉपी करें,

```powershell
gsudo
Copy-Item -Path ".\FanImeTsf\build64\Debug\FanImeTsf.dll" -Destination "C:\Program Files\FanImeTsf"
```

फिर, इसे इंस्टॉल करें,

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 .\FanImeTsf.dll
```

### अनइंस्टॉल

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 /u .\FanImeTsf.dll
```

## स्क्रीनशॉट्स

![](https://i.postimg.cc/v8Bpx6Gf/image.png)

![](https://i.postimg.cc/ssBgtM5M/image.png)

![](https://i.postimg.cc/ryDqXH0B/image.png)

![](https://i.postimg.cc/2m9WJTgR/image.png)

![](https://i.postimg.cc/L96qQZT8/image.png)

![](https://i.postimg.cc/FNcz9QTv/image.png)

## रोडमैप

वर्तमान में केवल Xiaohe Shuangpin का समर्थन है।

### चीनी

- Xiaohe Shuangpin
- Quanpin
- Hanzi Components के उपयोग में सहायता कोड
- अनुकूलित की जा सकने वाली शब्दकोश
- अनुकूलन योग्य IME इंजन
- अनुकूलन योग्य स्किन्स
- सरलीकृत चीनी और पारंपरिक चीनी के बीच टॉगल करें
- अंग्रेजी स्वतःपूर्णता (autocomplete)
- ओपन-सोर्स क्लाउड IME एपीआई
- उम्मीदवार विंडो UI को वर्टिकल और होरिज़ॉन्टल मोड के बीच टॉगल करें
- फीचर स्विच: अधिकांश फीचर्स को यूजर्स स्वतंत्र रूप से टॉगल या कस्टमाइज़ कर सकते हैं

### जापानी समर्थन

संभवत: एक अन्य परियोजना।

और संभवतः कुछ अन्य भाषाओं का भी समर्थन।

### संदर्भ

- [MS-TSF-IME-Demo](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/IME/cpp/SampleIME)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---