# ChimpStackr

![GitHub all releases](https://img.shields.io/github/downloads/noah-peeters/ChimpStackr/total) ![GitHub release (latest by date)](https://img.shields.io/github/downloads/noah-peeters/ChimpStackr/latest/total) ![GitHub](https://img.shields.io/github/license/noah-peeters/ChimpStackr) ![GitHub commits since latest release (by date)](https://img.shields.io/github/commits-since/noah-peeters/ChimpStackr/latest)

<p align="center">
  <img src="https://raw.githubusercontent.com/noah-peeters/ChimpStackr/master/packaging/icons/chimpstackr_icon.png" width="200"/>
</p>

Windows, macOS, Linux용 오픈 소스 포커스 스태킹 애플리케이션입니다.

## 특징

- **4가지 스태킹 알고리즘:** 라플라시안 피라미드, 가중 평균, 깊이 맵, 노출 퓨전 (HDR)
- **자동 정렬:** 이동만 또는 회전 + 스케일 보정 (포커스 브리딩)
- **16비트 파이프라인:** RAW부터 출력까지 전체 비트 깊이 보존
- **자동 크롭:** 정렬 이동으로 인한 검은 가장자리 제거
- **자동 조정:** 이미지 해상도에서 매개변수 자동 감지
- **GUI + CLI:** 완전한 그래픽 인터페이스 및 헤드리스 커맨드라인 도구
- **크로스 플랫폼:** Windows, macOS, Linux용 네이티브 빌드
- **일시정지/재개/취소:** 장시간 실행되는 스택 제어
- **전후 비교:** 입력과 출력 비교를 위한 슬라이더 뷰어
- **드래그 앤 드롭:** 이미지 파일이나 폴더를 앱에 직접 드롭

## 다운로드

사전 빌드된 패키지는 [릴리즈](https://github.com/noah-peeters/ChimpStackr/releases) 페이지에서 이용 가능합니다:

| 플랫폼 | 다운로드 | 비고 |
|---|---|---|
| **Windows** | `ChimpStackr-Windows.zip` | 압축 해제 후 `chimpstackr.exe` 실행 |
| **macOS** | `ChimpStackr-macOS.dmg` | DMG 열고 응용 프로그램으로 드래그 |
| **Linux** | `ChimpStackr-Linux-x86_64.AppImage` | `chmod +x` 후 실행 |

## CLI 사용법

CLI는 GUI 없이 헤드리스 포커스 스태킹을 지원합니다:

```bash
# Basic stack
chimpstackr-cli --input images/*.jpg --output result.tif

# Align + stack with auto parameters
chimpstackr-cli -i images/*.jpg -o result.tif --align --auto --auto-crop

# Full options
chimpstackr-cli -i images/*.jpg -o result.png \
  --align \
  --method laplacian \
  --rotation-scale \
  --kernel-size 6 \
  --pyramid-levels 8 \
  --auto-crop \
  --quality-report
```
**사용 가능한 방법:** `laplacian` (기본값), `weighted_average`, `depth_map`

## 스태킹 알고리즘

| 방법 | 적합 대상 | 작동 방식 |
|---|---|---|
| **피라미드** | 미세한 디테일(머리카락, 솔기, 가장자리) | 라플라시안 피라미드 분해, 주파수 대역별 최대 대비 선택, 로컬 톤 매핑 |
| **가중치** | 부드러운 피사체, 우수한 색상 | 적절한 누적을 통한 픽셀별 대비 가중치 |
| **깊이 맵** | 불투명 표면, 최고의 색상 충실도 | 가장자리 인식 양방향 평활화를 포함한 다중 스케일 선명도 |
| **HDR** | 다양한 노출/조명 | Mertens 노출 융합 (포커스 스태킹용 아님) |

## 소스에서 빌드

Python 3.9-3.13 필요.


```bash
git clone https://github.com/noah-peeters/ChimpStackr.git
cd ChimpStackr
python -m venv .venv
source .venv/bin/activate  # or .venv\Scripts\activate on Windows
pip install -r requirements.txt

# Run GUI
python src/run.py

# Run CLI
python -m src.cli --help

# Run tests
pip install pytest
pytest tests/ -v
```
## 패키징

빌드는 플랫폼별 후처리가 포함된 PyInstaller를 사용합니다. 현재 플랫폼에서만 빌드할 수 있습니다.


```bash
# Install build tools
pip install pyinstaller

# Build (creates dist/chimpstackr/ and dist/ChimpStackr.app on macOS)
pyinstaller chimpstackr.spec --noconfirm

# Or use the platform scripts:
./scripts/build_macos.sh        # macOS → .dmg
./scripts/build_linux.sh        # Linux → .AppImage
.\scripts\build_windows.ps1     # Windows → .zip or installer
```
CI/CD는 GitHub Actions를 통해 태그된 릴리스에서 모든 플랫폼을 자동으로 빌드합니다.

## 갤러리

다음 스택들은 약 4배 확대된 상태에서 약간 흔들리는 장비(~150장 이미지 각각)로 촬영되었으며, ChimpStackr로 스택되고 [darktable](https://www.darktable.org/)에서 후처리되었습니다.

![Bij_TranslationAlignment](https://user-images.githubusercontent.com/17707805/196990942-413ea35c-2abb-4bce-9807-3f3d6b3de3c5.jpg)
![Edited](https://user-images.githubusercontent.com/17707805/196991117-dc4f1c76-cc87-4ef1-92ee-9a7484c7ff07.jpg)
![Bewerkt](https://user-images.githubusercontent.com/17707805/196996295-9fb6c365-ef10-4ef5-b451-1a7269156e53.jpg)

## 출처

- 초점 스태킹 알고리즘 기반: Wang, W., & Chang, F. (2011). A Multi-focus Image Fusion Method Based on Laplacian Pyramid. *Journal of Computers*, 6(12).
- DFT 이미지 정렬은 다음을 참고함: [imreg_dft](https://github.com/matejak/imreg_dft)
- Mertens 노출 합성: Mertens, T., Kautz, J., & Van Reeth, F. (2007). Exposure Fusion.
- Sum Modified Laplacian 초점 측정법: Nayar, S.K., & Nakagawa, Y. (1994).

## 라이선스

GPL-3.0 - 자세한 내용은 [LICENSE](LICENSE)를 참조하세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---