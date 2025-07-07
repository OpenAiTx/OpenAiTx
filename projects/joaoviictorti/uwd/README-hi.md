# uwd 🦀

![Rust](https://img.shields.io/badge/made%20with-Rust-red)
![crate](https://img.shields.io/crates/v/uwd.svg)
![docs](https://docs.rs/uwd/badge.svg)
[![build](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml/badge.svg)](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml)
![Forks](https://img.shields.io/github/forks/joaoviictorti/uwd)
![Stars](https://img.shields.io/github/stars/joaoviictorti/uwd)
![License](https://img.shields.io/github/license/joaoviictorti/uwd)

`uwd` विंडोज़ पर कॉल स्टैक स्पूफिंग के लिए एक रस्ट लाइब्रेरी है, जो आपको एक नकली कॉल स्टैक के साथ मनमाने फंक्शन को निष्पादित करने की अनुमति देती है, जिससे यह विश्लेषण, लॉगिंग, या स्टैक अनवाइंडिंग के दौरान डिटेक्शन से बच जाता है।

[SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk) से प्रेरित, यह क्रेट निम्न-स्तरीय स्पूफिंग क्षमताओं को एक स्वच्छ, आदर्श रस्ट इंटरफ़ेस में लाता है जिसमें `#[no_std]`, `MSVC` और `GNU` टूलचेन के लिए पूर्ण समर्थन और स्वचालित गैजेट रेज़ोल्यूशन शामिल है।

## विशेषताएँ

- ✅ `Synthetic` और `Desync` के माध्यम से कॉल स्टैक स्पूफिंग।
- ✅ दोनों `MSVC` और `GNU` टूलचेन (**x64**) के साथ संगत।
- ✅ इनलाइन मैक्रोज़: `spoof!`, `spoof_synthetic!`, `syscall!`, `syscall_synthetic!`।
- ✅ `#[no_std]` परिवेशों का समर्थन करता है (यदि `alloc` उपलब्ध है)।

## शुरू करना

अपने प्रोजेक्ट में `uwd` जोड़ने के लिए अपने `Cargo.toml` को अपडेट करें:
```bash
cargo add uwd
```

## उपयोग

`uwd` आपको रस्ट में या तो मानक विंडोज़ API या अप्रत्यक्ष सिस्टम कॉल करते समय कॉल स्टैक स्पूफ करने की अनुमति देता है। लाइब्रेरी नकली फ्रेम, गैजेट चेन और रजिस्टर की तैयारी की पूरी सेटअप को संभालती है जिससे निष्पादन ऐसा प्रतीत होता है जैसे वह एक वैध स्रोत से आया हो।

आप निम्न को स्पूफ कर सकते हैं:

* सामान्य फंक्शन (जैसे `VirtualAlloc`, `WinExec` आदि)
* स्वचालित SSN और स्टब रेज़ोल्यूशन के साथ नेटिव सिस्टम कॉल (जैसे `NtAllocateVirtualMemory`)

मैक्रोज़ `spoof!` / `spoof_synthetic!` और `syscall!` / `syscall_synthetic!` सारी जटिलता को अमूर्त कर देते हैं।

### WinExec को स्पूफ करना

यह उदाहरण दिखाता है कि कैसे एक स्पूफ किए गए कॉल स्टैक का उपयोग करके `calc.exe` को शुरू किया जाता है। हम `WinExec` को दो बार कॉल करते हैं — एक बार Desync तकनीक का उपयोग करके, और फिर Synthetic तकनीक का उपयोग करके।

```rs
use dinvk::{GetModuleHandle, GetProcAddress};
use uwd::{spoof, spoof_synthetic};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // इस्तेमाल किए जाने वाले WinAPI फंक्शन के पते को रेज़ॉल्व करता है
    let kernel32 = GetModuleHandle("kernel32.dll", None);
    let win_exec = GetProcAddress(kernel32, "WinExec", None);
    
    // `WinExec` के साथ कमांड निष्पादित करें
    // कॉल स्टैक स्पूफिंग (Desync)
    let cmd = c"calc.exe";
    let mut result = spoof!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec असफल हुआ");
        return Ok(());
    }

    // कॉल स्टैक स्पूफिंग (Synthetic)
    result = spoof_synthetic!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec असफल हुआ [2]");
        return Ok(());
    }

    Ok(())
}
```

### एक अप्रत्यक्ष सिस्टम कॉल को स्पूफ करना

यह उदाहरण एक स्पूफ किए गए कॉल स्टैक के साथ `NtAllocateVirtualMemory` के लिए अप्रत्यक्ष सिस्टम कॉल करता है।

```rs
use std::{ffi::c_void, ptr::null_mut};
use dinvk::NT_SUCCESS;
use uwd::{syscall, syscall_synthetic, AsUwd};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // कॉल स्टैक स्पूफिंग (Desync) के साथ अप्रत्यक्ष सिस्टम कॉल चलाना
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    let mut status = syscall!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCCESS(status) {
        eprintln!("NtAllocateVirtualMemory असफल रहा, स्थिति: {status:#X}");
        return Ok(())
    }

    println!("[+] पता आवंटित किया गया: {:?}", addr);

    // कॉल स्टैक स्पूफिंग (Synthetic) के साथ अप्रत्यक्ष सिस्टम कॉल चलाना
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    status = syscall_synthetic!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCESS(status) {
        eprintln!("NtAllocateVirtualMemory असफल रहा [2], स्थिति: {status:#X}");
        return Ok(())
```
}

println!("[+] पता आवंटित किया गया: {:?}", addr);

Ok(())
}
```

## अतिरिक्त संसाधन

अधिक उदाहरणों के लिए, रिपोजिटरी में [examples](/examples) फ़ोल्डर देखें।

## संदर्भ

मैं उन प्रोजेक्ट्स का आभार व्यक्त करना चाहता हूँ, जिन्होंने मुझे `uwd` बनाने के लिए प्रेरित किया और कुछ फीचर्स में योगदान दिया:

- [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)

विशेष धन्यवाद:

- [Kudaes](https://x.com/_Kudaes_)
- [Klez](https://x.com/KlezVirus)
- [Waldo-IRC](https://x.com/waldoirc)
- [Trickster0](https://x.com/trickster012)
- [namazso](https://x.com/namazso)

## लाइसेंस

यह प्रोजेक्ट MIT लाइसेंस के तहत लाइसेंस प्राप्त है। विवरण के लिए [LICENSE](/LICENSE) फ़ाइल देखें।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---