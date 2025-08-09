# Kitten TTS 😻

Kitten TTS는 1,500만 개의 매개변수만 가진 오픈 소스 현실적인 텍스트-음성 변환 모델로, 경량 배포와 고품질 음성 합성을 위해 설계되었습니다.

*현재 개발자 미리보기 중*

[우리 디스코드에 참여하세요](https://discord.gg/upcyF5s6)


## ✨ 특징

- **초경량**: 모델 크기 25MB 미만
- **CPU 최적화**: GPU 없이 모든 장치에서 실행 가능
- **고품질 음성**: 여러 프리미엄 음성 옵션 제공
- **빠른 추론**: 실시간 음성 합성에 최적화



## 🚀 빠른 시작

### 설치

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
## 💻 시스템 요구사항

사실상 모든 환경에서 작동



## 체크리스트

- [x] 미리보기 모델 출시
- [ ] 완전 학습된 모델 가중치 출시
- [ ] 모바일 SDK 출시
- [ ] 웹 버전 출시








---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---