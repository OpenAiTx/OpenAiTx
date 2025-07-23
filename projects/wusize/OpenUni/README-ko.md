
# OpenUni: 통합 멀티모달 이해 및 생성의 간단한 기준선

![](https://raw.githubusercontent.com/wusize/OpenUni/main/figures/teaser.png)

> **[OpenUni: 통합 멀티모달 이해 및 생성의 간단한 기준선](https://arxiv.org/abs/2505.23661)**
>
> Size Wu, Zhonghua Wu, Zerui Gong, Qingyi Tao, Sheng Jin, Qinyue Li, Wei Li, Chen Change Loy
>
> [![report](https://img.shields.io/badge/arXiv-2505.23661-b31b1b.svg)](docs/report.pdf)
> [![Bibtex](https://img.shields.io/badge/Cite-BibTeX-blue)](https://github.com/wusize/OpenUni?tab=readme-ov-file#-citation)

## 소개

이 저장소는 MetaQuery의 오픈 소스 버전인 OpenUni라는 이름으로, 멀티모달 이해 및 생성을 통합하기 위해 개발 중입니다. 최소한의 아키텍처 선택을 통해 OpenUni가 1) 고품질이고 지시문에 부합하는 이미지를 생성하고, 2) 1.1B 및 3.1B 활성화된 매개변수만으로 GenEval, DPG-Bench, WISE와 같은 표준 벤치마크에서 탁월한 성능을 달성할 수 있음을 보여줍니다. 현재 OpenUni-B-512, OpenUni-L-512, OpenUni-L-1024의 세 가지 모델 변형을 제공합니다. 사전 학습과 미세 조정 모두에 대한 체크포인트가 제공됩니다.


## 🔥 모델 동물원

| 모델 이름 | 이미지 크기 | MLMM 모델 | 확산 모델 | 사전 학습 | 미세 조정 |
|------------|------------|------------|-----------------|-------------|------------|
| OpenUni-B-512 | 512×512 | [InternVL3-1B](https://huggingface.co/OpenGVLab/InternVL3-1B) | [SANA-0.6B-512px](https://huggingface.co/Efficient-Large-Model/Sana_600M_512px_diffusers) | [링크](https://huggingface.co/wusize/openuni/blob/main/openuni_b_internvl3_1b_sana_0_6b_512_hf_text2image23m.pth) | [링크](https://huggingface.co/wusize/openuni/blob/main/openuni_b_internvl3_1b_sana_0_6b_512_hf_blip3o60k.pth) |
| OpenUni-L-512 | 512×512 | [InternVL3-2B](https://huggingface.co/OpenGVLab/InternVL3-2B) | [SANA-1.6B-512px](https://huggingface.co/Efficient-Large-Model/Sana_1600M_512px_diffusers) | [링크](https://huggingface.co/wusize/openuni/blob/main/openuni_l_internvl3_2b_sana_1_6b_512_hf_text2image23m.pth) | [링크](https://huggingface.co/wusize/openuni/blob/main/openuni_l_internvl3_2b_sana_1_6b_512_hf_blip3o60k.pth) |
| OpenUni-L-1024 | 1024×1024 | [InternVL3-2B](https://huggingface.co/OpenGVLab/InternVL3-2B) | [SANA1.5-1.6B-1024px](https://huggingface.co/Efficient-Large-Model/SANA1.5_1.6B_1024px_diffusers) | [링크](https://huggingface.co/wusize/openuni/blob/main/openuni_l_internvl3_2b_sana_1_6b_512_hf_text2image23m.pth) | [링크](https://huggingface.co/wusize/openuni/blob/main/openuni_l_internvl3_2b_sana_1_6b_1024_hf_blip3o60k.pth) |





## 환경

```
mmengine
xtuner
transformers
torch
flash_attn
```
## 텍스트-투-이미지

🤗[wusize/openuni](https://huggingface.co/wusize/openuni)에서 공개된 모델 가중치를 다운로드해 주세요. 체크포인트를 다운로드할 때는 다음 명령어를 사용하는 것이 권장됩니다.



```bash
# pip install -U "huggingface_hub[cli]"
huggingface-cli download wusize/openuni  --local-dir checkpoints --repo-type model
```

```text
OpenUni/
├── checkpoints
    ├── openuni_b_internvl3_1b_sana_0_6b_512_hf_blip3o60k.pth
    ├── openuni_b_internvl3_1b_sana_0_6b_512_hf_text2image23m.pth
    ├── openuni_l_internvl3_2b_sana_1_6b_1024_hf_blip3o60k.pth
    ├── openuni_l_internvl3_2b_sana_1_6b_1024_hf_text2image23m.pth
    ├── openuni_l_internvl3_2b_sana_1_6b_512_hf_blip3o60k.pth
    ├── openuni_l_internvl3_2b_sana_1_6b_512_hf_text2image23m.pth
```
### 추론  
자세한 내용은 [docs/INFERENCE.md](https://raw.githubusercontent.com/wusize/OpenUni/main/docs/INFERENCE.md)를 참조하십시오.  

### 평가  
자세한 내용은 [docs/EVALUATION.md](https://raw.githubusercontent.com/wusize/OpenUni/main/docs/EVALUATION.md)를 참조하십시오.  

### 학습  

데이터셋 준비를 위해 [docs/DATASETS.md](https://raw.githubusercontent.com/wusize/OpenUni/main/docs/DATASETS.md)와 [docs/datasets](docs/datasets)를 참조하십시오. 데이터셋 준비 후,  
[docs/TRAIN.md](https://raw.githubusercontent.com/wusize/OpenUni/main/docs/TRAIN.md)의 지침을 따라 학습 스크립트를 실행하십시오.  

## 📚 인용  

OpenUni가 연구나 응용에 유용하다면, 다음의 BibTeX를 사용하여 논문을 인용해 주십시오:


```bibtex
@article{wu2025openuni,
      title={OpenUni: A Simple Baseline for Unified Multimodal Understanding and Generation}, 
      author={Size Wu and Zhonghua Wu and Zerui Gong and Qingyi Tao and Sheng Jin and Qinyue Li and Wei Li and Chen Change Loy},
      year={2025},
      eprint={2505.23661},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2505.23661}, 
}
```
## 📜 라이선스
이 프로젝트는 [NTU S-Lab License 1.0](LICENSE) 하에 라이선스가 부여되었습니다.


## 🙏 감사의 말
이 프로젝트는 다음의 선구적인 작업들을 기반으로 합니다:
- [SANA](https://github.com/NVlabs/Sana): 효율성과 뛰어난 성능을 고려하여 확산 모듈로 SANA를 사용합니다.
- [InternVL3](https://github.com/OpenGVLab/InternVL): 최신 InternVL3를 기본 멀티모달 LLM으로 사용합니다.
- [MetaQuery](https://xichenpan.com/metaquery): OpenUni는 MetaQuery에서 영감을 받았으며 이 작업의 오픈 소스 구현체입니다.
- [BLIP3-o](https://github.com/JiuhaiChen/BLIP3o): 귀중한 고품질 튜닝 데이터셋을 공개해 주신 BLIP3-o 팀에 감사드립니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---