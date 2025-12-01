# AlphaEarth Foundations

Google DeepMind의 AlphaEarth 지리공간 기초 모델을 PyTorch로 구현한 것으로, 전 지구 환경 모니터링 및 분석을 위한 지구 임베딩을 생성합니다.  
논문과 함께 2017년부터 2024년까지의 임베딩 글로벌 데이터셋이 Earth Engine을 통해 제공됩니다. 이 임베딩의 목표는 재학습 없이도 방대한 다운스트림 응용 프로그램에 매우 일반적인 지리공간 표현을 제공하는 것입니다.

> [!NOTE]  
> 이 모델은 진행 중인 작업이며 전체 데이터셋으로 실제 학습된 것은 아니며, 논문의 아키텍처를 위한 일반적인 기반을 제공하는 프레임워크일 뿐입니다. 코드는 DeepMind의 실제 구현(JAX)과 비교하여 간소화되어 있습니다.

### 방법론의 핵심 부분

- **연속 시간 지원**: 연속 시간을 지원하는 최초의 EO 특징화 접근법으로, 시간적 보간 및 외삽을 허용합니다.  
- **시공간 정밀도(STP) 아키텍처**: 공간(1/16L), 시간(1/8L), 정밀도(1/2L) 연산자가 있는 다중 해상도 인코더 - 지역화된 표현을 유지하면서도 시공간에 걸친 장거리 관계를 모델링하도록 설계되었습니다.  
- **폰 미제스-피셔 임베딩**: 단위 구 S^63 위에 분포하는 64바이트 임베딩으로 매우 컴팩트한 표현입니다.

## 아키텍처

### 시공간 정밀도(STP) 인코더

STP 인코더는 세 가지 동시 연산자를 통해 다중 시간, 다중 소스 데이터를 처리합니다:  
- **공간 연산자**: ViT 유사 공간 자기 주의 (1/16L 해상도)  
- **시간 연산자**: 시간 축 자기 주의 (1/8L 해상도)  
- **정밀도 연산자**: 3x3 합성곱 (1/2L 해상도)

### 교사-학생-텍스트 프레임워크

1. **교사 비디오 임베딩 모델**: 암묵적 디코더가 있는 주요 모델  
2. **학생 비디오 임베딩 모델**: 대조 학습을 위해 교사와 매개변수를 공유  
3. **텍스트 정렬 모델**: 텍스트-이미지 대조 학습 가능

## 데이터 소스

이 모델은 다음을 포함한 여러 데이터 소스에서 학습됩니다:  
- **광학**: Sentinel-2, Landsat 8/9. *참고: 단순화를 위해 제 구현은 Sentinel-2만 지원하지만, 학습에 새로운 데이터셋을 추가하는 것은 비교적 간단해야 합니다*  
- **레이더**: Sentinel-1, PALSAR2  
- **라이다**: GEDI  
- **환경**: GLO-30, ERA5-Land, GRACE  
- **주석/텍스트**: NLCD, Wikipedia



## 설치

```bash
# Clone the repository
git clone https://github.com/brayden-zhang/alphaearth-foundations.git
cd alphaearth-foundations

# Install dependencies
uv pip install -r requirements.txt

# Install the package 
uv pip install -e .
```

학습 단계를 실행하는 방법:
```
python -m alphaearth.run_train
```

## 논문 인용

```bibtex
@misc{brown2025alphaearthfoundationsembeddingfield,
      title={AlphaEarth Foundations: An embedding field model for accurate and efficient global mapping from sparse label data}, 
      author={Christopher F. Brown and Michal R. Kazmierski and Valerie J. Pasquarella and William J. Rucklidge and Masha Samsikova and Chenhui Zhang and Evan Shelhamer and Estefania Lahera and Olivia Wiles and Simon Ilyushchenko and Noel Gorelick and Lihui Lydia Zhang and Sophia Alj and Emily Schechter and Sean Askay and Oliver Guinan and Rebecca Moore and Alexis Boukouvalas and Pushmeet Kohli},
      year={2025},
      eprint={2507.22291},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2507.22291}, 
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-01

---