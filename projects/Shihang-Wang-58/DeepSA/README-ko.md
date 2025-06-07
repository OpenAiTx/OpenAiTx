[![License: MIT](https://img.shields.io/badge/License-MIT-yellow)](https://github.com/Shihang-Wang-58/DeepSA)
[![PyPI](https://img.shields.io/badge/PyPI-cyan)](https://pypi.org/project/deepsa)

# DeepSA: 딥러닝 기반 화합물 합성 접근성 예측기

인공지능 기술의 지속적인 발전과 함께, 점점 더 많은 딥러닝 생성 모델이 분자 생성에 사용되고 있습니다. 하지만, 생성 모델이 생성한 대부분의 신규 분자들은 합성 접근성 측면에서 큰 도전에 직면하는 경우가 많습니다.

DeepSA는 화합물의 합성 접근성을 예측하기 위해 제안되었으며, 합성이 어려운 분자를 구별하는 데 있어 훨씬 더 높은 초기 선별율을 보입니다. 이를 통해 사용자는 합성 비용이 적게 드는 분자를 선택할 수 있어 신약 발견 및 개발에 소요되는 시간을 줄일 수 있습니다. DeepSA는 https://bailab.siais.shanghaitech.edu.cn/deepsa 웹 서버에서 사용할 수 있습니다.<br/>

## 요구 사항
다음 명령어를 사용하여 필요한 종속성을 설치할 수 있습니다:
```bash
conda create -n DeepSA python=3.12
conda activate DeepSA
# gpu 버전용
pip3 install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu118
pip3 install autogluon==1.2
pip3 install rdkit
```
### 뉴스 🔔 

* 2024-12, [AutoGluon이 2024년 10월부터 python 3.8 버전 지원을 중단](https://github.com/autogluon/autogluon/pull/4512)함에 따라, DeepSA는 Python 3.12 버전으로 업데이트되었으며, 최신 AutoGluon 버전에 적합하도록 학습 및 추론 스크립트가 업데이트되었습니다. DeepSA에 관심 가져주셔서 감사합니다!

* 2023-7, DeepSA_v1.0이 출시되었습니다. 이슈를 통해 피드백을 환영합니다!

## 데이터
확장된 학습 및 테스트 데이터셋은 https://drive.google.com/drive/folders/1iup6T3Bqyy-uvpdFyP0Of_WQqn-9l62h?usp=sharing 에서 손쉽게 다운로드할 수 있습니다.
## 연구자를 위한 사용법
자체 모델을 학습하고자 한다면, 커맨드 라인에서 다음과 같이 실행할 수 있습니다.

실행:
```
    python DeepSA_training.py <dataset.csv/training.csv:test.csv> DeepSA_model ./data/test_set.list
```
제안된 모델을 사용하고자 한다면,

실행:
```
    python DeepSA_predict.py <input_data.csv> DeepSA_model
```

## 온라인 서버

사전 학습된 모델을 전용 서버에 배포하여, https://bailab.siais.shanghaitech.edu.cn/deepsa 에서 바이오메디컬 연구자들이 DeepSA를 쉽게 활용할 수 있도록 공개하였습니다.

사용자는 SMILES 또는 csv 파일을 서버에 업로드하면, 예측 결과를 빠르게 얻을 수 있습니다.

## <span id="citelink">인용</span>
이 저장소가 귀하의 연구에 유용하다면, 아래 논문을 인용해 주시기 바랍니다:

Wang, S., Wang, L., Li, F. et al. DeepSA: a deep-learning driven predictor of compound synthesis accessibility. J Cheminform 15, 103 (2023). https://doi.org/10.1186/s13321-023-00771-3

## 연락처
문의사항이 있으시면 언제든지 Shihang Wang(이메일: wangshh12022@shanghaitech.edu.cn) 또는 Lin Wang(이메일: wanglin3@shanghaitech.edu.cn)에게 연락해 주시기 바랍니다.

Pull request를 적극적으로 환영합니다!

## 감사의 글
상하이테크대학교 HPC 플랫폼의 지원에 감사드립니다.<br/>
이 연구에 관심을 가져주신 모든 분들께 감사드립니다.

![Star History Chart](https://api.star-history.com/svg?repos=Shihang-Wang-58/DeepSA&type=Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---