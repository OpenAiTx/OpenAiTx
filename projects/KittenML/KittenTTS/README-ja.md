# Kitten TTS 😻

Kitten TTSは、わずか1500万パラメータのオープンソースのリアルなテキスト読み上げモデルで、軽量なデプロイと高品質な音声合成を目的としています。

*現在は開発者プレビュー版です*

[Discordに参加する](https://discord.gg/upcyF5s6)


## ✨ 特徴

- **超軽量**：モデルサイズ25MB未満
- **CPU最適化**：どのデバイスでもGPUなしで動作
- **高品質な音声**：複数のプレミアム音声オプションを提供
- **高速推論**：リアルタイム音声合成に最適化



## 🚀 クイックスタート

### インストール

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
## 💻 システム要件

文字通りどこでも動作します



## チェックリスト

- [x] プレビューモデルをリリースする
- [ ] 完全に訓練されたモデルの重みをリリースする
- [ ] モバイルSDKをリリースする
- [ ] ウェブバージョンをリリースする








---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---