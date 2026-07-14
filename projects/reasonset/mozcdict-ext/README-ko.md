# mozcdict-ext

외부 단어를 Mozc 시스템 사전으로 변환

# 개요

본 도구군은 당초 Mozc-UT (Mozcdic-UT)를 잃은 것에 따른 손실을 보완하기 위한 "긴급 대피" 용도로 만들어졌다.  
현재는 Mozc-UT와는 다른 접근법으로 보다 쾌적한 변환 환경을 구축하는 것을 목표로 하고 있다.

본 도구군은 Mozc 외부의 리소스에서 Mozc 시스템 사전을 구축한다.  
이를 Mozc에 통합하여 빌드함으로써 Mozc의 어휘력을 증가시킬 수 있다.

본 소프트웨어에는 그렇게 생성된 사전은 *포함하지 않는다*.  
또한, *Mozc 본체도 포함하지 않는다*.

원래는 긴급 회피적인 "임시방편"으로 만들어진 소프트웨어였으나,  
현재는 Mozc-UT와는 약간 다른 방침 하에 개발되고 있다.

Mozcdic-UT와의 큰 차이는 다음과 같다.

* 오픈 프로젝트이며, 라이선스는 GPL v3이다  
* 소프트웨어는 사전 생성을 위한 도구이며, 생성된 사전 자체는 아니다  
* Mozcdic-UT는 일반 명사만을 대상으로 하지만, Mozcdict-EXT는 품사를 제한하지 않는다  
* 웹 사전 변환기 외에 사람이 손수 편찬한 ByHand 사전을 가진다

# 사용법

## 생성의 기본

각 디렉토리의 `mkdict.zsh` 또는 `mkdict.rb`는 변환된 사전을 생성하여 표준 출력으로 내보낸다.

이때 다음 전제를 충족할 필요가 있다.

* 스크립트 실행은 스크립트가 있는 디렉토리를 현재 디렉토리로 하여 실행한다  
* 환경 변수 `$MOZC_ID_FILE`에 Mozc의 `id.def` 파일 경로를 설정해 두어야 한다

`id.def` 파일은 Mozc의 `src/data/dictionary_oss/id.def`에 존재한다.  
이 파일은 *본 소프트웨어에 포함되어 있지 않다.*  
빌드에는 어차피 Mozc가 필요하므로, 미리 Mozc 리포지토리를 입수·갱신해 두는 것이 바람직하다.

이와 같이 표준 출력에 내보낸 내용은 Mozc 시스템 사전으로서 취급할 수 있으며,  
시스템 사전에 통합하여 빌드하면 포함시킬 수 있다.
추천은 `src/data/dictionary_oss/dictionary09.txt` 에 덧붙이는 것이다.

## 마지막 정리

여러 개의 사전을 생성한 경우, 여러 사전에 걸친 정리 작업을 더하면 더 좋다.

`.dev.utils/uniqword.rb` 는 `ARGF`에서 사전을 읽고, 품사를 포함해 동일한 단어가 있으면 제외하고 STDOUT에 출력한다.
중복된 단어는 STDERR에 출력된다.

```bash
ruby uniqword.rb ~/dict/neologd.txt ~/dict/sudachi.txt > ~/dict/unified.txt
```
Mozcdic-UT와 달리 고유명사의 생성을 수행하므로, 이 작업은 하는 편이 좋다.

## Archlinux의 경우

본 프로젝트와는 별도로 `fcitx5-mozc-ext-neologd`라는 AUR 패키지를 준비하고 있다.

AUR에서 이 패키지를 설치함으로써 외부 사전을 포함한 형태로 Mozc를 빌드하여 설치할 수 있다.

단, 해당 패키지는 본 프로젝트와는 별개의 것이다.

# 환경 변수

## `$MOZC_ID_FILE`

필수. MOZC의 `id.def`의 위치를 나타낸다.

## `$WORDCLASS_ROUND`

엄밀히 일치하는 품사가 없을 경우 보다 대략적인 품사로 반올림한다.
`no`를 지정하면 이 처리를 하지 않는다.
다음 사전 도구에서 동작한다.

* sudachi

## `$ERROR_ON_UNEXPECTED_CLASS`

품사가 불명한 단어가 있을 경우 에러를 발생시킨다.
기본값은 발생시키지 않으며, `yes`를 지정했을 때 발생시킨다.
다음 사전 도구에서 동작한다.

* sudachi

# 실행 옵션

## -e / --english

통상 이 도구는 ‘영어로의 변환’을 제외한다.
`-e` 또는 `--english` 옵션을 붙이면 영어 변환 결과를 허용한다.


## --english-proper

`--english`를 붙이지 않고 `--english-proper`를 붙인 경우, 영어는 고유명사인 경우에만 허용한다.

## -P / --no-proper

고유명사를 제외한다.

## -w / --fullwidth-english (neologd, sudachi)

전각 영숫자와 반각 가나로의 변환을 제외하지 않는다.

보다 정확히는 보통 Onigmo의 정규식 `/^[\p{Symbol}\p{In_CJK_Symbols_and_Punctuation}\p{Punctuation}\p{White_Space}\p{In_Halfwidth_and_Fullwidth_Forms}]+$/`에 매치되는 경우 제외되지만, 이로 인한 제외를 중지한다.

## -W / --exclude-containing-fullwidth-english (byhand)

전각 영숫자 또는 반각 가나가 포함된 경우 제외한다.

## --fullwidth-english-proper (neologd, sudachi)

`--fullwidth-english`를 붙이지 않은 경우에 고유명사만 허용한다.

## -s / --symbol

통상 이 도구는 변환 시에 문제를 일으키는 '기호'를 변환 기호에서 제외하지만,  
`-s` 혹은 `--symbol` 옵션을 붙이면 강제로 생성에 포함한다.

# 옵션의 기본값

커맨드라인 옵션을 사용하지 않고 기본 옵션을 변경하고 싶을 경우, 설정 디렉터리(`${XDG_CONFIG_HOME:-$HOME/.config}/mozcdict-ext`)의 `config.yaml`을 통해 기본 옵션을 지정할 수 있다.

예를 들어 `--fullwidth-english`를 항상 활성화하고 싶을 경우 다음과 같이 한다.

```yaml
fullwidth-english: true
```

# 제외

설정 디렉터리의 `exclude.txt` 파일을 사용하여 사전에 추가를 회피하고 싶은 패턴을 지정할 수 있다.

제외 리스트는 1줄에 1패턴으로, 읽기 패턴과 원형 패턴을 1개 이상의 연속된 공백 문자로 구분한 것이다.

패턴은 각각 `File.fnmatch`에 의해 체크된다.

예를 들어 `ゃ`로 시작하는 읽기로 변환되는 모든 후보를 제외하고 싶을 경우는

```
ゃ*    *
```
とする。

# IssueとPR

何か問題があれば、Issueに書くか、Pull Requestを生成してほしい。

ただ、私は既にかなり手出ししている中で善意で本ソフトウェアを作っていることを理解してほしい。
つまり、IssueやPull Requestにまで手が回るかは分からない。
(少なくとも、なるべく対応したいとは思っている。)

# ByHand辞書への語彙追加と欠如している語彙の報告

最新のMozcと、本ソフトウェアのすべての辞書を有効にした状態で変換できない語があれば、[Mozcdict Ext 語彙欠如報告](https://mozc.chienomi.org)にて申請してほしい。

同ページから申請できないものについてはissueにて報告して欲しい。
また、具体的なMozc品詞を指定できる場合も、同ページではなくissueを立てて欲しい。

# ライセンスとパッケージング

このソフトウェアはGPL v3でライセンスされている。
ソフトウェアは「自由に」コピーして使って良い。

一方、このソフトウェアに何か問題があったり、あるいは不足があったりしたとしても私は一切の責任を負うことはできない。
誰もがよく知っている通り、ABSOLUTELY NO WARRANTYである。

本ソフトウェアが提供するのはあくまでも辞書生成ツールである。
しかし、恐らくディストリビューションとして配布したいとすれば、それによってビルドされたMozcだろう。
このようにしてビルドされたMozcは本ツールのライセンスとは全く関係がない。
なぜならば、そのMozcに本ツールは含まれないからだ。
そのようなパッケージは、Mozcと、外部辞書として使われたリソースのライセンス・規約に従うことになるだろう。
そのようにして配布が可能であることもまた、本ソフトウェアおよび私は保証しない。

# 現在の進捗

* NEologd - 機能する
* Sudachi - 一部の品詞についてのみ生成される (実験的・開発中)

# 注意事項


* 본 소프트웨어에 의해 생성되는 사전의 라이선스 및 정당성에 대해서 본 소프트웨어는 일절 관여하지 않는다

# 특히 기여를 요구하는 것

sudachi의 `clsmap.yaml` (Sudachi의 품사 분류에서 Mozc의 품사 분류로의 변환)

`utils/dev-by-cls.rb`를 사용하면 품사별 구체적인 단어로 분류하여 `.dev.reference/sudachi-cls` 이하에 출력한다(`.gitignore`에 지정되어 있음). 이를 참고하여 품사 분류를 확정하는 작업이 진행 중이다.

# Dependency

* Ruby >= 3.0
* Zsh
* xz(1)
* curl(1)
* Git (Submodules)

# 사전에 대하여

## neologd

mecab-ipadic-NEologd를 기반으로 한 사전이다.

## sudachi

형태소 분석 소프트웨어 Sudachi의 사전을 재활용한 것이다.

명사 이외에도 사용할 예정이나 현재 정체 상태이다.

## byhand

neologd, sudachi를 사용해도 변환할 수 없거나 변환이 어려운 단어를 수동으로 편찬한 사전이다.

원칙적으로 국어 소사전에 실릴 만한 일반어만 수록하며 고유명사는 수록하지 않는다.

## Mozc Common User Dict

[Mozc Common User Dict](https://github.com/reasonset/mozc-common-user-dict)는 본 프로젝트를 보완하는 일반어 사용자 사전이다.

byhand에 수록이 어떤 이유로 어려운 것은 여기에 수록된다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-14

---