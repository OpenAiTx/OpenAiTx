<p align="center">
<h1 align="center"><strong>TrackVLA: 자연 환경에서의 실체화된 시각 추적</strong></h1>
  <p align="center">
    <!--   	<strong>CoRL 2025</strong><br> -->
    <a href='https://wsakobe.github.io/' target='_blank'>Shaoan Wang</a>&emsp;
	<a href='https://jzhzhang.github.io/' target='_blank'>Jiazhao Zhang</a>&emsp;
    Minghan Li&emsp;
    Jiahang Liu&emsp;
    Anqi Li&emsp; <br>
    Kui Wu&emsp;
    <a href='https://fangweizhong.xyz/' target='_blank'>Fangwei Zhong</a>&emsp;
    <a href='https://www.coe.pku.edu.cn/teaching/manufacturing/9993.html' target='_blank'>Junzhi Yu</a>&emsp;
	<a href='https://scholar.google.com/citations?user=X7M0I8kAAAAJ&hl=zh-CN' target='_blank'>Zhizheng Zhang</a>&emsp;
  <a href='https://hughw19.github.io/' target='_blank'>He Wang</a>&emsp;
    <br>
    베이징대학교&emsp; 
    Galbot&emsp; <br>
    북경항공항천대학교&emsp;
    베이징사범대학교&emsp;
    베이징인공지능아카데미&emsp;
    <br>
  </p>
</p>

<div id="top" align="center">

[![Project](https://img.shields.io/badge/Project-%239c403d?style=flat&logoColor=%23FA7F6F
)](https://pku-epic.github.io/TrackVLA-web/)
[![arXiv](https://img.shields.io/badge/Arxiv-%233b6291?style=flat&logoColor=%23FA7F6F
)](http://arxiv.org/abs/2505.23189)
[![Video](https://img.shields.io/badge/Video-%23c97937?style=flat&logoColor=%23FA7F6F
)](https://youtu.be/v51U3Nk-SK4?si=foz3zbYD8hLHSybC)

</div>

## 🏡 소개
<strong><em>TrackVLA</em></strong>는 170만 개 샘플로 학습된, 객체 인식과 시각 추적을 동시에 수행할 수 있는 비전-언어-행동 모델입니다. 이 모델은 다양한 도전적인 환경에서 강인한 추적, 장기 추적, 그리고 도메인 간 일반화 성능을 보여줍니다.
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/wsakobe/TrackVLA/main/assets/teaser.png" alt="Dialogue_Teaser" width=100% >
</div>

## 📢 소식

* [25/07/02]: EVT-Bench가 이제 공개되었습니다.

## 💡 설치
1. **conda 환경 준비**

   먼저 [conda](https://docs.conda.io/projects/conda/en/latest/user-guide/install/)를 설치해야 합니다. conda 설치 후, 새로운 환경을 생성하세요:
   ```bash
   conda create -n evt_bench python=3.9 cmake=3.14.0
   conda activate evt_bench
   ```

2. **Conda를 이용한 habitat-sim 설치**
   
   habitat-sim v0.3.1을 설치해야 합니다.
      ```
      conda install habitat-sim==0.3.1 withbullet -c conda-forge -c aihabitat
      ```

3. **habitat-lab 소스에서 설치**
      ```
      cd habitat-lab
      pip install -e habitat-lab
      ```

4. **데이터셋 준비**

    Habitat Matterport 3D (HM3D) 데이터셋을 [여기](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#habitat-matterport-3d-research-dataset-hm3d)에서, Matterport3D (MP3D)는 [여기](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#matterport3d-mp3d-dataset)에서 다운로드하세요.

    다운로드한 데이터셋을 `data/scene_datasets`로 이동합니다. 데이터셋의 구조는 다음과 같습니다:
    ```
    data/
     └── scene_datasets/
        ├── hm3d/
        │ ├── train/
        │ │   └── ...
        │ ├── val/
        │ │   └── ...
        │ └── minival
        │     └── ...
        └── mp3d/
          ├── 1LXtFkjw3qL
          │   └── ...
          └── ...
    ```

    다음으로, 휴머노이드 아바타 데이터를 얻기 위해 아래 코드를 실행하세요:
      ```
      python download_humanoid_data.py
      ```


## 🧪 평가
  다음 스크립트를 실행하세요:

    bash eval.sh

  결과는 지정한 SAVE_PATH에 저장되며, 여기에는 로그 디렉토리와 비디오 디렉토리가 포함됩니다. 평가 진행 중 결과를 모니터링하려면, 다음을 실행하세요:
    watch -n 1 python analyze_results.py --path YOUR_RESULTS_PATH

  평가를 중지하려면 다음을 사용하세요:

    bash kill_eval.sh


## 📝 TODO 리스트
- [x] 2025년 5월 arXiv 논문 공개.
- [x] EVT-Bench (Embodied Visual Tracking Benchmark) 공개.
- [ ] 대규모 embodied visual tracking 데이터셋 공개.
- [ ] TrackVLA의 체크포인트와 코드 공개.

## ✉️ 문의
질문이 있으시면 언제든지 wangshaoan@stu.pku.edu.cn 으로 이메일을 보내주세요. 최대한 빠르게 답변드리겠습니다.


## 🔗 인용
저희 연구가 도움이 되었다면, 아래와 같이 인용해 주시기 바랍니다:

```bibtex
@article{wang2025trackvla,
  title={Trackvla: Embodied visual tracking in the wild},
  author={Wang, Shaoan and Zhang, Jiazhao and Li, Minghan and Liu, Jiahang and Li, Anqi and Wu, Kui and Zhong, Fangwei and Yu, Junzhi and Zhang, Zhizheng and Wang, He},
  journal={arXiv preprint arXiv:2505.23189},
  year={2025}
}
```

## 📄 라이선스
<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/80x15.png" /></a>
<br />
이 저작물은 <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">크리에이티브 커먼즈 저작자표시-비영리-동일조건변경허락 4.0 국제 라이선스</a>에 따라 이용할 수 있습니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---