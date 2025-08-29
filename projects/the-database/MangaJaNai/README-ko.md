# MangaJaNai

[![Discord](https://img.shields.io/discord/1121653618173546546?label=Discord&logo=Discord&logoColor=white)](https://discord.gg/EeFfZUBvxj)

<a href="./mangajanaiv1demo.webp?raw=1"><img src="https://raw.githubusercontent.com/the-database/MangaJaNai/main/mangajanaiv1demo.webp"/></a>
<p align="center"><sup>(이미지를 클릭하면 확대됩니다)</sup></p>

## 개요

MangaJaNai는 만화를 위한 업스케일링 모델 모음입니다. 이 모델들은 주로 높이가 약 1200px에서 2048px 사이인 일본어 또는 영어 텍스트의 디지털 만화 이미지를 업스케일링하도록 최적화되어 있습니다.

최신 소식, 사전 배포 및 실험 모델 다운로드, 지원 및 질문, 업스케일 공유, 피드백 공유를 위해 [**JaNai Discord 서버**](https://discord.gg/EeFfZUBvxj)에 참여하세요. 日本語も大丈夫です。

## 사용 방법

### MangaJaNaiConverterGui로 업스케일링하기

간단한 즉시 사용 경험을 위해 [MangaJaNaiConverterGui](https://github.com/the-database/MangaJaNaiConverterGui)를 사용하여 MangaJaNai 모델로 만화를 업스케일하세요.

## MangaJaNai 모델
만화는 매우 높은 해상도(10000px 이상)로 제작되고 물리적 책 출판 시 뛰어난 품질로 인쇄되지만, 공식 디지털 만화는 종종 해상도가 낮고 JPEG 및 모아레 아티팩트가 많습니다. MangaJaNai 모델의 목표는 저품질 흑백 디지털 만화를 업스케일링하여 JPEG 및 모아레 아티팩트를 정리하고 인쇄된 책 버전에 가까운 결과를 제공하는 것입니다.

대부분의 만화는 하프톤 도트로 제작되지만, 일부 디지털 배포본은 너무 열화되어 하프톤 도트가 더 이상 보이지 않습니다. MangaJaNai 모델은 원본 이미지에 없던 도트를 생성하는 것처럼 보일 수 있지만, 대부분의 경우 모델은 저품질 원본 이미지에서 더 이상 보이지 않던 도트를 올바르게 복원합니다. 하프톤이 올바른 크기와 빈도로 생성되도록 하기 위해 일곱 가지 다른 이미지 높이 중 하나에 최적화된 여러 MangaJaNai 모델이 훈련되었습니다. 이 높이들은 일본에서 디지털로 배포된 만화의 가장 일반적인 이미지 크기인 1200p, 1300p, 1400p, 1500p, 1600p, 1920p, 2048p에 해당합니다. [MangaJaNaiConverterGui](https://github.com/the-database/MangaJaNaiConverterGui)는 입력 이미지 해상도에 따라 최적의 모델을 자동으로 선택합니다.

## IllustrationJaNai 모델
MangaJaNai 모델은 흑백 만화 페이지에만 적합하기 때문에, 만화의 컬러 이미지(예: 표지 및 컬러 페이지)에 사용하기 위해 보조 IllustrationJaNai 모델이 훈련되었습니다. 이 모델들은 JPEG 아티팩트와 저해상도 인쇄 하프톤 도트 같은 일반적인 이미지 아티팩트를 제거하도록 훈련되었으며, 디지털 아트의 일반적인 업스케일링 모델로도 잘 작동합니다. [MangaJaNaiConverterGui](https://github.com/the-database/MangaJaNaiConverterGui)는 컬러 이미지에 대해 IllustrationJaNai 모델을 자동으로 선택합니다.

## 관련 프로젝트

- [mpv-upscale-2x_animejanai](https://github.com/the-database/mpv-upscale-2x_animejanai): Real-ESRGAN 컴팩트 모델로 mpv에서 실시간 4k 애니메이션 업스케일링
- [MangaJaNaiConverterGui](https://github.com/the-database/MangaJaNaiConverterGui): MangaJaNai 모델을 이용한 만화 업스케일링용 Windows GUI
- [traiNNer-redux](https://github.com/the-database/traiNNer-redux): 업스케일링 모델 훈련용 소프트웨어

## 감사의 글
- [422415](https://github.com/422415) V1 모델 개발 중 데이터셋 준비 및 지속적 피드백에 큰 도움을 준 분
- JaNai Discord 서버 멤버분들, 만화 자료 지원:
    - Alexandros
    - umzi
    - M7MedOo
    - Gnathonic
- 베타 모델에 대한 지속적인 피드백을 제공하는 JaNai Discord 서버 멤버:
    - junmittens
    - SOUNDSPHERE BEST GAME
    - marv
    - Big_herooooo
    - avc1657
    - risho
- [traiNNer-redux](https://github.com/joeyballentine/traiNNer-redux)
- [Dataset Destroyer](https://github.com/Kim2091/helpful-scripts/tree/main/Dataset%20Destroyer)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---