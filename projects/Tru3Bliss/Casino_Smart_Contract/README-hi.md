# 🎯 प्रोजेक्ट सेटअप गाइड

प्रोजेक्ट में आपका स्वागत है! यह गाइड आवश्यक टूल्स इंस्टॉल करने और अपने लोकल एनवायरनमेंट को कॉन्फ़िगर करने में आपकी सहायता करेगा ताकि आप जल्दी से शुरू कर सकें।

---

## 🛠️ आवश्यकताएँ

सुनिश्चित करें कि निम्नलिखित टूल्स आपके सिस्टम पर इंस्टॉल हैं:

- [Rust](https://www.rust-lang.org/tools/install)
- [Solana CLI](https://docs.solana.com/cli/install-solana-cli-tools)
- [Anchor](https://anchor-lang.com/docs/installation)

> ℹ️ **अनुशंसित Anchor वर्शन:** `0.30.1`

---

## ✅ वर्शन जांचें और कॉन्फ़िग सेट करें

सुनिश्चित करें कि सबकुछ सही से इंस्टॉल और कॉन्फ़िग किया गया है:

```bash
rustc --version             # Rust वर्शन जांचें
solana --version            # Solana CLI वर्शन जांचें
anchor --version            # Anchor वर्शन जांचें

solana config get           # वर्तमान Solana कॉन्फ़िग देखें
solana config set --url devnet  # नेटवर्क devnet पर सेट करें
```
---

## 🔐 वॉलेट सेटअप

अपनी वॉलेट कुंजियाँ जनरेट और प्रबंधित करें:

```bash
solana-keygen new -o ./keys/admin.json     # नई कीपेयर जनरेट करें
solana-keygen pubkey ./keys/admin.json     # सार्वजनिक कुंजी प्राप्त करें
solana balance ./keys/admin.json           # वॉलेट बैलेंस जांचें
solana airdrop 5 YOUR_WALLET_ADDRESS -u devnet   # अपने वॉलेट में 5 SOL एयरड्रॉप करें
```

---

## 📦 प्रोजेक्ट इंस्टॉलेशन

प्रोजेक्ट क्लोन करें और डिपेंडेंसीज़ इंस्टॉल करें:

```bash
git clone https://github.com/project-repo.git
cd project-folder
yarn
```
---

## ⚡ त्वरित प्रारंभ

### 🏗️ प्रोग्राम का निर्माण करें

Anchor स्मार्ट अनुबंध को संकलित करें:

```bash
# Nightly टूलचेन का उपयोग करके Anchor प्रोग्राम बनाएं
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build

# सभी प्रोग्राम सार्वजनिक कुंजियाँ सिंक करें
anchor keys sync

# यदि lib.rs में प्रोग्राम पता बदल गया है तो फिर से निर्माण करें
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build
```

---
### 🧪 Devnet पर परीक्षण करें

सुनिश्चित करें कि आपका `Anchor.toml` Devnet का उपयोग कर रहा है:

```toml
[provider]
cluster = "https://api.devnet.solana.com"
```

---

### 🚀 प्रोग्राम को डिप्लॉय करें

```bash
anchor deploy
```

---

## 🧪 प्रोग्राम के साथ इंटरैक्ट करने के लिए CLI का उपयोग करें
इन CLI स्क्रिप्ट्स का उपयोग अपने स्मार्ट कॉन्ट्रैक्ट के साथ लोकली इंटरैक्ट करने के लिए करें।

---

### 🔹 प्रोग्राम को इनिशियलाइज़ करें

```bash
yarn script config
```

कॉन्ट्रैक्ट कॉन्फ़िगरेशन को इनिशियलाइज़ करता है।

---

### 🔹 एक राउंड बनाएं

```bash
yarn script create -t <ROUND_TIME> -d <MIN_DEPOSIT_AMOUNT> -j <MAX_JOINER_COUNT>
```
# उदाहरण:
yarn script create -t 60 -d 100000000 -j 100
```

**पैरामीटर:**

- `<ROUND_TIME>`: राउंड की अवधि सेकंड में (जैसे, `60` = 60 सेकंड)।
- `<MIN_DEPOSIT_AMOUNT>`: न्यूनतम जमा राशि लैमपोर्ट्स में (1 SOL = 1_000_000_000)। यह `config.TEST_INITIAL_MIN_DEPOSIT_AMOUNT` से अधिक होनी चाहिए।
- `<MAX_JOINER_COUNT>`: प्रतिभागियों की अधिकतम संख्या। यह `config.TEST_INITIAL_MAX_JOINER_COUNT` से कम होनी चाहिए।

---

### 🔹 राउंड में शामिल हों

```bash
yarn script join -a <DEPOSIT_SOL_AMOUNT> -g <ROUND_NUMBER>

# उदाहरण:
yarn script join -a 100000000 -g 2
```
**पैरामीटर:**

- `<DEPOSIT_SOL_AMOUNT>`: जमा राशि लैम्पोर्ट्स में (उदाहरण: 0.1 SOL = 100_000_000)।
- `<ROUND_NUMBER>`: शामिल होने वाले राउंड का इंडेक्स। यह `0` से शुरू होता है। `total_round` से कम होना चाहिए।

> 🕒 नोट: राउंड की उलटी गिनती तब शुरू होती है जब दूसरा प्रतिभागी शामिल होता है।

---

### 🔹 विजेता चुनें

```bash
yarn script winner -g <ROUND_NUMBER>

# उदाहरण:
yarn script winner -g 2
```

**नोट:** इसे केवल तब कॉल करें जब राउंड का समय पूरी तरह समाप्त हो चुका हो।

---
### 🔹 जीत की राशि प्राप्त करें

```bash
yarn script claim -g <ROUND_NUMBER>

# उदाहरण:
yarn script claim -g 2
```

**नोट:** विजेता चुने जाने के बाद यह कमांड जीतने वाले वॉलेट द्वारा चलानी चाहिए।

---

## संपर्क करें

यदि आपके पास Solana स्मार्ट कॉन्ट्रैक्ट डेवलपमेंट, DeFi इम्प्लीमेंटेशन, या DEX इंटीग्रेशन से संबंधित कोई प्रश्न या पूछताछ है, तो कृपया प्रोजेक्ट मेंटेनर्स से संपर्क करें।

**Telegram**: [@Tru3B1iss](https://t.me/Tru3B1iss)
**X (Twitter)**: [@XTruebliss](https://x.com/XTruebliss)
**Discord**: [@trueb1iss](https://discord.com/users/1274339638668038187)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---