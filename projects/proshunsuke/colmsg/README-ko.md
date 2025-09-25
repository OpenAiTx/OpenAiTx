> [!WARNING]
> 현재 iOS에서 `refresh_token`을 얻을 수 없는 문제가 발생하고 있습니다. 이는 `colmsg`의 문제가 아니라 메시지 앱 쪽의 업데이트 영향입니다. 현재 이 문제에 대한 완전한 해결책은 없습니다. Android의 경우 계속해서 [여기](https://github.com/proshunsuke/colmsg/blob/main/doc/how_to_get_refresh_token.md#android%E3%82%A2%E3%83%97%E3%83%AA%E3%81%AE%E5%A0%B4%E5%90%88)를 참고해 주세요.

<div align="center">
  <h1><strong>colmsg</strong></h1>
  <img src="https://user-images.githubusercontent.com/3148511/158018437-09822a33-8767-4e03-ba90-e0f69594c493.jpeg" width="32px" alt="사쿠라자카46 메시지 로고"><img src="https://user-images.githubusercontent.com/3148511/158018441-dd7cb9eb-bf31-4938-830d-1ef293a2afba.jpg" width="32px" alt="히나타자카46 메시지 로고"><img src="https://user-images.githubusercontent.com/3148511/158018442-ae54e926-760d-4b47-b0a0-7255485e1f28.jpg" width="32px" alt="노기자카46 메시지 로고">

  「사쿠라자카46 메시지」「히나타자카46 메시지」「노기자카46 메시지」「사이토 아스카 메시지」「시라이시 마이 메시지」「yodel」앱의 메시지를 PC에 저장합니다.

  ![demo](https://user-images.githubusercontent.com/3148511/158026220-90735546-2401-40ca-a9e6-89d2176ad3b4.gif)
</div>

## 개요

`colmsg` 설치 방법은 [여기](#インストール)를 참조해 주세요.

**먼저** refresh_token을 획득해 주세요. 획득 방법은 [여기](https://raw.githubusercontent.com/proshunsuke/colmsg/main/doc/how_to_get_refresh_token.md)를 참조해 주세요.

획득했다면 아래를 실행해 주세요.  
`<s_refresh_token>` , `<h_refresh_token>` , `<n_refresh_token>` , `<a_refresh_token>` , `<m_refresh_token>` , `<y_refresh_token>` 에 각각 「사쿠라자카46 메시지」「히나타자카46 메시지」「노기자카46 메시지」「사이토 아스카 메시지」「시라이시 마이 메시지」「yodel」에서 획득한 refresh_token을 넣어 주세요.  
※ 지정하는 것은 구독 중인 앱만으로 문제없습니다.  

구독 중인 멤버 전원의 전체 기간 메시지가 저장됩니다.  

```shell script
colmsg --s_refresh_token <s_refresh_token> --h_refresh_token <h_refresh_token> --n_refresh_token <n_refresh_token> --a_refresh_token <a_refresh_token> --m_refresh_token <m_refresh_token> --y_refresh_token <y_refresh_token>
```
Windowsの場合는 실행 파일 이름을 `colmsg.exe`로 바꾸어 사용하십시오.

## 특징

* ✅ 단말기의 루팅이 필요하지 않습니다
* ✅ Android, iOS 앱 모두에 대응하고 있습니다
* ✅ Windows, macOS, Linux에서 실행할 수 있습니다
* ✅ 다양한 저장 방식을 선택할 수 있습니다
* ✅ 다음 앱 버전에 대응하고 있습니다
  * 「櫻坂46メッセージ」: 버전 1.12.01.169
  * 「日向坂46メッセージ」: 버전 2.13.01.169
  * 「乃木坂46メッセージ」: 버전 1.8.01.169
  * 「齋藤飛鳥メッセージ」: 버전 1.1.01.169
  * 「白石麻衣メッセージ」: 버전 3.4.3.426
  * 「yodel」: 버전 4.1.1.455

## 사용법

개요에서 기본적인 사용법을 설명했습니다.  
하지만, refresh_token은 민감한 정보이므로 터미널에서 직접 입력하는 것은 그다지 좋지 않습니다.  
따라서, config 파일에 기본 옵션을 설정해 두는 것을 추천합니다.  
config 파일에 대해서는 [여기](#config파일)를 참조하십시오.  
이후는 config 파일에 refresh_token이 설정되어 있다고 가정합니다.

`colmsg`에는 여러 옵션이 있으며, 다양한 저장 방식을 선택할 수 있습니다.

특정 멤버의 메시지를 저장하고 싶은 경우


```shell script
colmsg -n 菅井友香 -n 佐々木久美
```
특정 그룹의 메시지를 저장하고 싶을 경우


```shell script
colmsg -g sakurazaka
```
특정 종류의 메시지를 저장하고 싶을 경우


```shell script
colmsg -k picture -k video
```
특정 일시 이후의 메시지를 저장하고 싶은 경우


```shell script
colmsg -F '2020/01/01 00:00:00'
```
옵션은 조합하여 사용할 수 있습니다. 보다 자세한 설명은 아래를 실행하여 확인하십시오.


```shell script
colmsg --help
```
## 상세 사양

* 이미 몇 개의 메시지가 저장되어 있는 경우 명령을 실행하면 마지막으로 저장한 메시지 이후의 메시지를 가져와 저장합니다  
* 저장되는 메시지는 다음 디렉터리 구조로 저장됩니다
  * ```shell script
    colmsg/
    ├── 히나타자카46 1기생
    │   └── 사사키 쿠미
    │       └── 1_0_20191231235959.txt
    ├── 노기자카46
    │   └── 아키모토 마나츠
    │       └── 2_1_20200101000000.jpg
    └── 사쿠라자카46 1기생
        └── 스가이 유카
            ├── 3_2_20200101000001.mp4
            └── 4_3_20200101000002.mp4

    ```
* ファイル名の形式は `<シーケンス番号>_<種類>_<日付>.<拡張子>` となっています
  * シーケンス番号はメッセージの時系列を表す番号になっています。若い数字程昔のメッセージです。ファイルブラウザで辞書順に並べると保存したメッセージが時系列通りに並びます
  * 種類の数字は以下のように対応しています
    * 0: テキストメッセージ
    * 1: 画像
    * 2: 動画
    * 3: ボイス
    * 4: リンク
* 各環境毎のデフォルトの保存先は以下を実行することで確認することが出来ます
  * ```shell script
    colmsg --download-dir
    ```
* 이미 저장된 메시지는 덮어쓰지 않습니다

## config 파일

`colmsg`는 설정 파일에서 미리 옵션을 지정할 수 있습니다.  
기본 경로는 다음을 실행하여 확인할 수 있습니다.

```shell script
colmsg --config-dir
```
또한, 환경 변수 `COLMSG_CONFIG_PATH`에 설정 파일의 위치를 명확히 지정할 수도 있습니다.

```shell script
export COLMSG_CONFIG_PATH="/path/to/colmsg.conf"
```
### 포맷

이 설정 파일은 명령줄 인수의 단순한 목록입니다. `colmsg --help`를 사용하면 사용 가능한 옵션과 그 값을 볼 수 있습니다. 또한 `#`으로 주석을 추가할 수 있습니다.

설정 파일 예:


```bash
# s_refresh_tokenを指定
--s_refresh_token s_refresh_token

# h_refresh_tokenを指定
--h_refresh_token h_refresh_token

# n_refresh_tokenを指定
--n_refresh_token n_refresh_token

# a_refresh_tokenを指定
--a_refresh_token a_refresh_token

# m_refresh_tokenを指定
--m_refresh_token m_refresh_token

# y_refresh_tokenを指定
--y_refresh_token y_refresh_token

# メディアファイルだけ保存するように設定
-k picture -k video -k voice
```

## 설치

### Windows

Windows용 빌드된 실행 파일을 zip으로 압축하여 [릴리스 페이지](https://github.com/proshunsuke/colmsg/releases)에 배치하고 있습니다.  
다운로드하여 [7-Zip](https://sevenzip.osdn.jp/) 등의 압축 해제 소프트웨어로 해제하세요.  
해제 후 실행 파일 `colmsg.exe`를 얻을 수 있습니다.  
[PowerShell](https://docs.microsoft.com/ja-jp/powershell/) 등에서 실행하세요.

### macOS

Homebrew로 설치할 수 있습니다.

```shell script
brew tap proshunsuke/colmsg
brew install colmsg
```

### Arch Linux

[AUR](https://aur.archlinux.org/packages/colmsg/)에서 설치할 수 있습니다.

```bash
yay -S colmsg
```
### 바이너리

다른 아키텍처용으로 빌드된 실행 파일을 [릴리즈 페이지](https://github.com/proshunsuke/colmsg/releases)에 배치했습니다.

## 개발

`colmsg`는 외부 API를 호출합니다. 개발 시에는 OpenApi를 이용한 모의 서버를 구축할 수 있습니다.


```shell
make server/kh
make server/n46
```
환경 변수 `S_BASE_URL` , `H_BASE_URL` , `N_BASE_URL` 를 지정함으로써 모의 서버에 요청할 수 있습니다.


```shell script
S_BASE_URL=http://localhost:8003 H_BASE_URL=http://localhost:8003 N_BASE_URL=http://localhost:8006 cargo run -- -d ~/Downloads/temp/ --help
```
## TODO

* [ ] CI에 의한 자동 테스트
* [ ] examples 준비
* [ ] 메시지 저장 처리의 병렬화
* [ ] api client의 crate화

## 라이선스

`colmsg`는 MIT License 조건 하에 배포되고 있습니다.

라이선스의 자세한 내용은 [LICENSE](https://raw.githubusercontent.com/proshunsuke/colmsg/main/LICENSE.txt) 파일을 참조해 주십시오.

## 주의사항

앱 이용 약관 제8조(금지 사항)에 다음 항목이 있으니 주의해 주십시오.

* (16) 당사가 지정한 접근 방법 이외의 수단으로 본 서비스에 접근하거나 접근을 시도하는 행위
* (17) 자동화된 수단(크롤러 및 유사 기술을 포함)으로 본 서비스에 접근하거나 접근을 시도하는 행위 



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---