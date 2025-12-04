# index-tts-lora

[中文版本](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [English Version](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

이 프로젝트는 Bilibili의 [index-tts](https://github.com/index-tts/index-tts)를 기반으로 하여, **단일 화자 및 다중 화자** 설정 모두에 대해 **LoRA 미세 조정** 솔루션을 제공합니다. 고품질 화자 음성 합성에서 **운율과 자연스러움**을 향상시키는 것을 목표로 합니다.

### 학습 및 추론

#### 1. 오디오 토큰 및 화자 조건 추출

```shell
# Extract tokens and speaker conditions
python tools/extract_codec.py --audio_list ${audio_list} --extract_condition

# audio_list format: audio_path + transcript, separated by \t
/path/to/audio.wav 小朋友们，大家好，我是凯叔，今天我们讲一个龟兔赛跑的故事。
```
추출 후, 처리된 파일들과 `speaker_info.json` 파일이 `finetune_data/processed_data/` 디렉토리 아래에 생성됩니다. 예를 들어:


```json
[
    {
        "speaker": "kaishu_30min",
        "avg_duration": 6.6729,
        "sample_num": 270,
        "total_duration_in_seconds": 1801.696,
        "total_duration_in_minutes": 30.028,
        "total_duration_in_hours": 0.500,
        "train_jsonl": "/path/to/kaishu_30min/metadata_train.jsonl",
        "valid_jsonl": "/path/to/kaishu_30min/metadata_valid.jsonl",
        "medoid_condition": "/path/to/kaishu_30min/medoid_condition.npy"
    }
]
```

#### 2. 교육

```shell
python train.py
```

#### 3. 추론

```shell
python indextts/infer.py
```
### 미세 조정 결과

이 실험은 *Kai Shu Tells Stories*의 **중국어 음성 데이터**를 사용하며, 총 길이는 **약 30분**이고 **270개의 오디오 클립**이 포함되어 있습니다.  
데이터셋은 **244개의 학습 샘플**과 **26개의 검증 샘플**로 분할됩니다.  
참고: 대본은 ASR 및 구두점 모델을 통해 자동 생성되었으며, 수동 교정이 없으므로 일부 오류가 있을 수 있습니다.

학습 샘플 예시, `他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### 1. 음성 합성 예시


| 텍스트                                                        | 오디오                                                        |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| 오래된 집의 시계가 자정 3시에 멈췄고, 먼지 속에 낯선 발자국이 나타났다. 탐정은 쭈그리고 앉아 바닥 틈새에 피 묻은 반지를 발견했다. | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| 달빛 아래 호박이 갑자기 웃는 얼굴을 내고 덩굴이 꿈틀거리며 정원 울타리를 밀어냈다. 여자아이는 발끝으로 서서 버섯이 오래된 자장가를 흥얼거리는 것을 들었다. | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| 그래서 Java 중급도 배워야 하고, M 및 외부 프론트엔드 응용 시스템 개발도 배워야 하며, Java Script 데이터베이스도 배우고, 동적인 웹사이트를 만드는 법을 배워야 한다. | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| 이 financial report는 회사의 지난 분기 revenue performance와 expenditure trends를 상세히 분석했다. | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| 산을 오르고 내리며 한 산, 다음 산, 3리 3미 3을 달리고 큰 고산에 올랐다. 산 높이는 해발 333이다. 산에 올라 크게 외쳤다: 나는 산보다 3척 3 더 높다. | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| 한 마른 남자가 셔츠와 신발을 벗은 채 거리 옆에 누워 있고 가방들이 근처에 있다. | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| 연구가 계속되면서 불소가 치아 부식 방지에 보호 효과가 있음이 입증되었다. | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### 2. 모델 평가  
평가 세트에 대한 자세한 내용은 다음을 참조하세요: [2025년 주류 TTS 모델 벤치마크: 최고의 음성 합성 솔루션은?](https://mp.weixin.qq.com/s/5z_aRKQG3OIv7fnSdxegqQ)  
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### 감사의 글

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-04

---