# Flatito: YAML 및 JSON 파일용 grep

YAML 및 JSON 파일용 grep의 일종입니다. 키를 검색하고 해당 값과 위치한 라인 번호를 얻을 수 있습니다.

![예제](https://raw.githubusercontent.com/ceritium/flatito/master/docs/screenshot.png)

## 의미

[에스페란토](https://en.wiktionary.org/wiki/flatito): flati('아첨하다')의 단수 과거 명사 수동 분사.

## 설치

다음을 실행하여 gem을 설치하고 애플리케이션의 Gemfile에 추가하세요:

    $ bundle add flatito

번들러로 의존성을 관리하지 않는 경우, 다음을 실행하여 gem을 설치하세요:

    $ gem install flatito

### Nixpkgs 패키지

[@Rucadi](https://github.com/Rucadi) 덕분에 [nixpkgs](https://search.nixos.org/packages?channel=unstable&show=flatito)로도 이용할 수 있습니다.

    $ nix run nixpkgs#flatito


## 사용법

```sh
Usage:    flatito PATH [options]
Example:  flatito . -k "search string" -e "json,yaml"
Example:  cat file.yaml | flatito -k "search string"

    -h, --help                       Prints this help
    -V, --version                    Show version
    -k, --search-key=SEARCH          Search string
        --no-color                   Disable color output
    -e, --extensions=EXTENSIONS      File extensions to search, separated by comma, default: (json,yaml,yaml)
        --no-skipping                Do not skip hidden files
```
## 개발

레포를 클론한 후, `bin/setup`을 실행하여 의존성을 설치하세요. 그런 다음, `rake test`를 실행하여 테스트를 진행할 수 있습니다. 또한, `bin/console`을 실행하면 실험할 수 있는 인터랙티브 프롬프트를 사용할 수 있습니다.

이 젬을 로컬 머신에 설치하려면 `bundle exec rake install`을 실행하세요. 새 버전을 릴리즈하려면 `version.rb`에서 버전 번호를 업데이트한 후, `bundle exec rake release`를 실행하세요. 이 명령은 버전용 git 태그를 생성하고, git 커밋과 태그를 푸시하며, `.gem` 파일을 [rubygems.org](https://rubygems.org)로 푸시합니다.

## 기여

버그 리포트와 풀 리퀘스트는 https://github.com/ceritium/flatito 의 GitHub에서 환영합니다. 이 프로젝트는 협업을 위한 안전하고 환영받는 공간이 되도록 의도되었으며, 기여자들은 [행동 강령](https://github.com/ceritium/flatito/blob/master/CODE_OF_CONDUCT.md)을 준수해야 합니다.

## 라이선스

이 젬은 [MIT 라이선스](https://opensource.org/licenses/MIT) 조건에 따라 오픈 소스로 제공됩니다.

## 행동 강령

Flatito 프로젝트의 코드베이스, 이슈 트래커, 채팅룸 및 메일링 리스트에서 상호작용하는 모든 사람은 [행동 강령](https://github.com/ceritium/flatito/blob/master/CODE_OF_CONDUCT.md)을 준수해야 합니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---