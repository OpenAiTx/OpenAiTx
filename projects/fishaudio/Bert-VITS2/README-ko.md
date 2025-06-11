<div align="center">

<img alt="LOGO" src="https://raw.githubusercontent.com/fishaudio/Bert-VITS2/master/avatars.githubusercontent.com/u/122017386" width="256" height="256" />

# Bert-VITS2

다국어 bert를 사용한 VITS2 백본

빠른 가이드는 `webui_preprocess.py`를 참조하세요.

简易教程请参见 `webui_preprocess.py`。

## 【프로젝트 소개】
# FishAudio의 새로운 자기회귀 TTS [Fish-Speech](https://github.com/fishaudio/fish-speech)가 현재 사용 가능하며, 오픈 소스 SOTA 수준의 성능을 제공하고 지속적으로 유지 관리되고 있습니다. 이 프로젝트는 BV2/GSV의 대체로 사용하기를 권장합니다. 본 프로젝트는 단기간 내에 더 이상 유지 관리하지 않습니다.
## 데모 영상: https://www.bilibili.com/video/BV18E421371Q
## 기술 슬라이드 영상: https://www.bilibili.com/video/BV1zJ4m1K7cj
## 본 프로젝트의 핵심 아이디어는 [anyvoiceai/MassTTS](https://github.com/anyvoiceai/MassTTS)에서 유래했으며, 매우 훌륭한 TTS 프로젝트입니다.
## MassTTS 데모는 [ai판 봉哥 날카로운 평가와 금삼각지대에서 잃어버린 신장을 찾다](https://www.bilibili.com/video/BV1w24y1c7z9) 입니다.

[//]: # (## 본 프로젝트는 [PlayVoice/vits_chinese](https://github.com/PlayVoice/vits_chinese)와 관련이 없습니다)

[//]: # ()
[//]: # (본 저장소는 이전에 친구가 AI 봉哥 영상을 공유해 주었고, 그 효과에 감탄하여 직접 MassTTS를 시도해 본 결과 fs가 음질 면에서 vits보다 다소 차이가 있고, 트레이닝 파이프라인이 vits보다 더 복잡함을 발견하여 그 아이디어를 따라 bert를 구현한 것입니다)

## 숙련된 여행자/개척자/선장/박사/센세이/헌터/냥냥루/V는 코드를 참고하여 직접 학습하시기 바랍니다.

### 본 프로젝트를 《중화인민공화국 헌법》, 《중화인민공화국 형법》, 《중화인민공화국 치안관리처벌법》 및 《중화인민공화국 민법전》에 위반되는 모든 용도로 사용하는 것을 엄격히 금지합니다.
### 정치 관련 용도로 사용하는 것을 엄격히 금지합니다.
#### 영상: https://www.bilibili.com/video/BV1hp4y1K78E
#### 데모: https://www.bilibili.com/video/BV1TF411k78w
## 참고 문헌
+ [anyvoiceai/MassTTS](https://github.com/anyvoiceai/MassTTS)
+ [jaywalnut310/vits](https://github.com/jaywalnut310/vits)
+ [p0p4k/vits2_pytorch](https://github.com/p0p4k/vits2_pytorch)
+ [svc-develop-team/so-vits-svc](https://github.com/svc-develop-team/so-vits-svc)
+ [PaddlePaddle/PaddleSpeech](https://github.com/PaddlePaddle/PaddleSpeech)
+ [emotional-vits](https://github.com/innnky/emotional-vits)
+ [fish-speech](https://github.com/fishaudio/fish-speech)
+ [Bert-VITS2-UI](https://github.com/jiangyuxiaoxiao/Bert-VITS2-UI)
## 모든 기여자분들의 노력에 감사드립니다
<a href="https://github.com/fishaudio/Bert-VITS2/graphs/contributors" target="_blank">
  <img src="https://contrib.rocks/image?repo=fishaudio/Bert-VITS2"/>
</a>

[//]: # (# 본 프로젝트의 모든 코드는 출처를 명확히 했으며, bert 부분의 코드 아이디어는 [AI봉哥](https://www.bilibili.com/video/BV1w24y1c7z9)에서 유래했으며, [vits_chinese](https://github.com/PlayVoice/vits_chinese)와는 관련이 없습니다. 코드 열람을 환영합니다. 동시에 해당 개발자의 [모방 및 오픈박스 개발자 행위](https://www.bilibili.com/read/cv27101514/)에 대해 강력히 규탄합니다.)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---