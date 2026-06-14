# ARLib 
추천 시스템에 대한 데이터 중독 공격을 수행하기 위한 오픈 소스 프레임워크로, 연구자와 실무자를 지원하기 위해 설계되었습니다. 이 저장소는 추천 시스템에 대한 중독 공격에 관한 우리의 [설문 논문](https://arxiv.org/abs/2406.01022)과 함께 공개되었습니다. <br>

**멤버:** <br>
Wei Yuan, 퀸즐랜드 대학교, 호주, warrenyuan97@gmail.com <br>
Hao Ma, 충칭 대학교, 중국, ma_hao@cqu.edu.cn <br>
Zeao Chen, 충칭 대학교, 중국, zeao_chen@stu.cqu.edu.cn<br>
Chenyu Li, 충칭 대학교, 중국, chenyu_li@stu.cqu.edu.cn

**창립자:** <br>
Zongwei Wang, 충칭 대학교, 중국, zongwei@cqu.edu.cn <br>

**지원:** <br>
Prof. Min Gao, 충칭 대학교, 중국, gaomin@cqu.edu.cn <br>
퀸즐랜드 대학교 ARC 정보 복원력 훈련 센터(CIRES), 호주

<h2>프레임워크</h2>

<img src="https://github.com/CoderWZW/ARLib/blob/main/img/framework.png" alt="Alt text" width="80%" /><br><br>

<h2>사용법</h2>

1. 두 개의 구성 파일 **attack_parser.py** 와 **recommend_parser.py** 는 conf라는 디렉토리에 있으며, 구성 파일을 수정하여 추천 모델과 공격 모델을 선택하고 구성할 수 있습니다. <br>
2. main.py를 실행하세요.


<h2>구현된 모델들</h2>

| **추천 모델** | **논문** |
| --- | --- |
| GMF | Yehuda 등. 추천 시스템을 위한 행렬 분해 기법, IEEE Computer'09.|
| WRMF | Hu 등. 암묵적 피드백 데이터셋을 위한 협업 필터링, KDD'09. |
| NCF | He 등. 신경망 협업 필터링, WWW'17. |
| NGCF | Wang 등. 신경 그래프 협업 필터링, SIGIR'19. |
| LightGCN | He 등. LightGCN: 추천을 위한 그래프 컨볼루션 네트워크 단순화 및 강화, SIGIR'2020. |
| SSL4Rec | Yao 등. 대규모 아이템 추천을 위한 자기 지도 학습, CIKM'2021. |
| NCL | Lin 등. 이웃 강화 대조 학습을 통한 그래프 협업 필터링 개선, WWW'2022. |
| SGL | Wu 등. 추천을 위한 자기 지도 그래프 학습, SIGIR'21. |
| SimGCL | Yu 등. 그래프 증강이 필요한가? 추천을 위한 간단한 그래프 대조 학습, SIGIR'22. |
| XSimGCL | Yu 등. XSimGCL: 추천을 위한 극도로 간단한 그래프 대조 학습, TKDE'23. |
| **공격 모델** | **논문** | **사례** |
| --- | --- | --- |
| NoneAttack | 해당 없음 | 블랙 |
| RandomAttack | Lam et al. 재미와 이익을 위한 추천 시스템 셸링 공격. WWW'2004 | 블랙 |
| BandwagonAttack | Gunes et al. 추천 시스템에 대한 셸링 공격: 종합 조사. Artif.Intell.Rev.'2014 | 블랙 |
| AUSH | Lin C et al. 증강 사용자 프로필을 이용한 추천 시스템 공격. CIKM'2020. | 그레이 |
| LegUP | Lin C et al. 가짜 사용자 프로필 생성 학습을 통한 블랙박스 추천 시스템 셸링. IEEE Transactions on Neural Networks and Learning Systems'2022. | 그레이 |
| GOAT | Wu et al. 추천 시스템에 대한 신종 위협 대비? 그래프 컨볼루션 기반 생성 셸링 공격. Information Sciences'2021. | 그레이 |
| FedRecAttack | Rong et al. Fedrecattack: 연합 추천에서 모델 중독 공격. ICDE'2022. | 그레이 |
| A_ra | Rong et al. 연합 학습 시나리오에서 딥러닝 기반 추천 모델 중독. IJCAI'2022. | 그레이 |
| PGA | Li et al. 행렬 분해 기반 협업 필터링 데이터 중독 공격. NIPS'2016. | 화이트 |
| DL_Attack | Huang et al. 딥러닝 기반 추천 시스템 데이터 중독 공격. arXiv'2021 | 화이트 |
| PipAttack | Zhang et al. Pipattack: 아이템 프로모션 조작을 위한 연합 추천 시스템 중독. WSDM'2022. | 그레이 |
| RAPU | Zhang et al. 불완전 및 왜곡된 데이터를 이용한 추천 시스템 데이터 중독 공격. KDD'2021. | 화이트 |
| PoisonRec | Song et al. Poisonrec: 블랙박스 추천 시스템 공격을 위한 적응형 데이터 중독 프레임워크. ICDE'2021. | 블랙 |
| CLeaR | Wang et al. 대비 학습 추천 시스템에 대한 중독 공격. arXiv'2023 | 화이트 |
| GTA | Wang et al. 딥러닝 기반 추천 시스템 데이터 중독 공격 재검토. ISCC 2023 | 블랙 |

<h2>모델 구현하기</h2>


공격 모델을 구현할지 추천 모델을 구현할지 결정한 후 해당 디렉토리에 파일을 추가하세요. <br>

공격 방법이 있다면, 다음을 확인하세요：<br>
1. 추천 모델 정보를 필요로 하는지, 그렇다면 **self.recommenderGradientRequired=True**로 설정하세요. <br>
2. 학습 중인 추천 모델 정보를 필요로 하는지, 그렇다면 **self.recommenderModelRequired=True**로 설정하세요. <br>
3. 함수 **posionDataAttack()** 를 재구현하세요.

추천 방법이 있다면, 다음 함수들을 재구현하세요：<br>
  * init()
  * posionDataAttack()  
  * save()
  * predict()  
  * evaluate()  
  * test()


<h2>데이터셋 다운로드</h2>


```
BAIDU DISK
Link: https://pan.baidu.com/s/1Gw0SI_GZsykPQEngiMvZgA?pwd=akgm
key: akgm

Google Drive
Link: https://drive.google.com/drive/folders/1QLDickAMEuhi8mUOyAa66dicCTd40CG5?usp=sharing
```
<h2>요구 사항</h2>


```
base==1.0.4
numba==0.53.1
numpy==1.18.0
scipy==1.4.1
torch==1.7.1
```
<h2>참고문헌</h2>

이 저장소가 귀하의 연구에 도움이 되었다면, 저희 논문을 인용해 주시기 바랍니다.


```bibtex
@article{wang2024poisoning,
  title={추천 시스템에서의 중독 공격 및 방어: 설문 조사},
  author={왕, 종웨이 and 유, 준량 and 가오, 민 and 위안, 웨이 and 예, 관화 and 사디크, 샤지아 and 인, 홍즈},
  journal={arXiv preprint arXiv:2406.01022},
  year={2024}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-14

---