# Kitten TTS 😻

Kitten TTS 是一个开源的逼真文本转语音模型，参数仅有1500万，旨在实现轻量级部署和高质量语音合成。

*当前处于开发者预览阶段*

[加入我们的 Discord](https://discord.gg/upcyF5s6)


## ✨ 特性

- **超轻量**：模型大小小于25MB
- **CPU 优化**：无需 GPU 即可在任何设备上运行
- **高质量声音**：提供多种优质语音选项
- **快速推理**：针对实时语音合成进行优化



## 🚀 快速开始

### 安装

```
pip install https://github.com/KittenML/KittenTTS/releases/download/0.1/kittentts-0.1.0-py3-none-any.whl
```



 ### Basic Usage 

```
from kittentts import KittenTTS
m = KittenTTS("KittenML/kitten-tts-nano-0.1")

audio = m.generate("This high quality TTS model works without a GPU", voice='expr-voice-2-f' )

# available_voices : [  'expr-voice-2-m', 'expr-voice-2-f', 'expr-voice-3-m', 'expr-voice-3-f',  'expr-voice-4-m', 'expr-voice-4-f', 'expr-voice-5-m', 'expr-voice-5-f' ]

# Save the audio
import soundfile as sf
sf.write('output.wav', audio, 24000)

```
## 💻 系统要求

几乎可以在任何地方运行



## 清单

- [x] 发布预览模型
- [ ] 发布完全训练好的模型权重
- [ ] 发布移动端 SDK
- [ ] 发布网页版








---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---