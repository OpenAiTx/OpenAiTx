# ./dops - 더 나은 `docker ps` 
기본 docker-ps를 대체하는 도구로, 터미널 너비에 최대한 맞추려고 노력합니다.

![](https://raw.githubusercontent.com/Mikescher/better-docker-ps/master/readme.d/main.png)

## 이유

기본적으로, 제 `docker ps` 출력은 매우 넓어서 각 줄이 세 줄로 감싸집니다.
이것은 (분명히) 표 형식의 표시를 깨뜨리고 모든 것을 혼란스럽게 만듭니다.  
*(특히 하나의 컨테이너에 여러 포트 매핑이 있을 때, 모두 한 줄에 표시되면 더 심각해집니다)*
앞으로 개선된 출력이 나올 것 같지 않아서 ([moby#7477](https://github.com/moby/moby/issues/7477) 참고), 직접 대체 도구를 만들기로 했습니다.  

## 기능

 - docker-ps의 모든 일반 명령줄 플래그/옵션이 *(거의)* 동일하게 작동합니다.
 - 여러 값 데이터(예: 여러 포트 매핑, 여러 네트워크 등)를 연결하지 않고 여러 줄로 작성합니다.
 - STATE 및 STATUS 열에 색상을 추가합니다 (녹색 / 노란색 / 빨간색).
 - 현재 터미널 너비에 맞을 때까지 출력에서 열을 자동으로 제거합니다.
 - `--sort` 인수로 출력을 정렬합니다.
 - `--watch` 인수로 감시 모드에 진입합니다.

기본 docker-ps와 다른 점:  
 - 기본적으로 인수 없이 컨테이너 명령어를 표시합니다.
 - 기본적으로 레지스트리 접두어 없이 이미지 이름을 표시하고, 이미지 이름과 태그를 두 개의 열로 분리합니다.
 - 기본 열 집합에 IP 및 NETWORK 열을 추가했습니다(만약 공간이 있으면).
 - 몇 가지 새 열을 지원합니다(--format 사용):  
   `{{.ImageName}`, `{{.ImageTag}`, `{{.Tag}`, `{{.ImageRegistry}`, `{{.Registry}`, `{{.ShortCommand}`, `{{.LabelKeys}`, `{{.IP}`                         
 - 색상 출력, 사용 소켓, 시간대 및 시간 형식 등을 제어하는 옵션을 추가했습니다(`./dops --help` 참조).

## 시작하기

### 일반 리눅스 (예: Debian/Fedora/...)
 - [릴리스 페이지](https://github.com/Mikescher/better-docker-ps/releases)에서 최신 바이너리를 다운로드하여 PATH(예: /usr/local/bin)에 넣으세요.
 - 다음 원라이너를 사용할 수도 있습니다(이후 어디서든 `dops` 명령을 사용할 수 있습니다):
```
$> sudo wget "https://github.com/Mikescher/better-docker-ps/releases/latest/download/dops_linux-amd64-static" -O "/usr/local/bin/dops" && sudo chmod +x "/usr/local/bin/dops"
```
### ArchLinux
 - 또는 AUR 패키지 중 하나를 사용할 수 있습니다 (Arch Linux에서):
    * https://aur.archlinux.org/packages/dops-bin (`dops`를 PATH에 설치)
    * https://aur.archlinux.org/packages/dops-git (`dops`를 PATH에 설치)
 - 또는 homebrew 패키지:
    * `brew tap mikescher/tap && brew install dops`

### 선택적 단계
 - docker ps 명령어를 `dops`로 별칭 설정 (아래 [섹션](#usage-as-drop-in-replacement) 참고)

## 스크린샷

![](https://raw.githubusercontent.com/Mikescher/better-docker-ps/master/readme.d/fullsize.png)  
모든 (기본) 열 표시

&nbsp;

![](https://raw.githubusercontent.com/Mikescher/better-docker-ps/master/readme.d/default.png)  
중간 크기 터미널 출력

&nbsp;

![](https://raw.githubusercontent.com/Mikescher/better-docker-ps/master/readme.d/small.png)  
작은 터미널 출력

&nbsp;

## 대체 명령어로 사용하기

`.bashrc` / `.zshrc`에 셸 함수를 생성하여 docker ps를 완전히 대체할 수 있습니다...

~~~sh
docker() {
  case $1 in
    ps)
      shift
      command dops "$@"
      ;;
    *)

      command docker "$@";;
  esac
}
~~~

이것은 `docker ps ...` 호출을 모두 `dops ...`로 별칭 지정합니다 (dops 바이너리가 PATH에 있어야 합니다).

fish-shell을 사용하는 경우 (유사한) 함수를 만들어야 합니다:

~~~fish
function docker
    if test -n "$argv[1]"
        switch $argv[1]
            case ps
                dops $argv[2..-1]
            case '*'
                command docker $argv[1..-1]
        end
    end
end
~~~

## 출력 형식 변경

기본적으로 dops는 "지능적"으로 터미널 너비에 맞는 최적의 출력 형식을 찾습니다.
현재 출력 형식(= 테이블 열)은 [options.go](https://github.com/Mikescher/better-docker-ps/blob/master/cli/options.go)에 정의되어 있습니다.
터미널 너비에 맞는 첫 번째 형식이 사용됩니다.

하지만 `--format` 매개변수를 제공하여 이를 재정의할 수도 있습니다. 여러 `--format` 매개변수를 제공하면 터미널에 맞는 첫 번째 형식이 사용됩니다(기본 형식과 동일한 로직).

일반적으로는 단순 열(예: `{{.Status}}`)만 지원됩니다.  
하지만 전체 golang 템플릿 구문(예: `{{ printf "%.15s" .Command }}`)도 사용할 수 있습니다.
이 경우 열 헤더를 콜론으로 접두사하여 지정하는 것이 유용할 수 있습니다 (`SHORTENED NAME:{{ printf "%.10s" (join .Names ";") }}`).

다음 함수들이 이 템플릿들 내에서 정의되어 있습니다 ([기본 go 함수](https://pkg.go.dev/text/template)도 포함):
 - `join`: strings.Join
 - `array_last`: v\[-1\]
 - `array_slice`: v\[a..b\] 
 - `in_array`: v1.contains(v2)
 - `json`: json.Marshal(v)
 - `json_indent`: json.MarshalIndent(v, "", "  ")
 - `json_pretty`:  json.Indent(v, "", "  ")
 - `coalesce`: v1 ?? v2
 - `to_string`: fmt.Sprintf("%v", v)
 - `deref`: *v
 - `now`: time.Now()
 - `uniqid`: UUID

Examples:
~~~~
$ ./dops --format "table {{.ID}}"
$ ./dops --format "table {{.ID}}\\t{{.Names}}\\t{{.State}}"

$ ./dops --format "idlist"

$ ./dops --format "table {{.ID}}\\t{{.Names}}\\t{{.State}}"  --format "table {{.ID}}\\t{{.Names}}" --format "table {{.ID}}"

$ ./dops --format "ID: {{.ID}}; Name: {{.Names}}"

$ ./dops -aq

$ ./dops --sort "IP" --sort-direction "ASC"

$ ./dops --format "table {{.ID}}\\tCMD:{{ printf \"%.15s\" .Command }}"
$ ./dops --format "table {{.ID}}\\tNAME:{{ printf \"%.10s\" (join .Names \";\") }}"

~~~~

## 지속 구성

일부 또는 대부분의 옵션을 구성 파일을 통해 설정할 수도 있습니다.  
TOML 형식의 파일을 `$HOME/.config/dops.conf` 또는 `$XDG_CONFIG_HOME/dops.conf`에 배치하세요.

지원되는 키는 다음과 같습니다:
 - verbose
 - silent
 - timezone
 - timeformat
 - timeformat-header
 - color
 - 소켓
 - 모두
 - 크기
 - 필터 (= 문자열 배열)
 - 포맷 (= 문자열 배열)
 - 마지막
 - 최신
 - 잘라내기
 - 헤더 (= true / false / simple)
 - 정렬 (= 문자열 배열)
 - 정렬-방향 (= 문자열 배열)

예시:
```toml
verbose = 0

timezone = "Europe/Berlin"

format = [
   "table {{.ID}}\t{{.Names}}\t{{.State}}\t{{.Status}}",
   "table {{.ID}}\t{{.Names}}\t{{.State}}",
   "table {{.ID}}\t{{.Names}}",
   "table {{.ID}}",
]

header = "simple"
```
## 매뉴얼

`./dops --help` 출력:

~~~~~~
better-docker-ps

사용법:
  dops [옵션]                     도커 컨테이너 목록 출력

기본 옵션:
  -h, --help                         도움말 출력.
  --version                          버전 정보 출력.
  --all , -a                         모든 컨테이너 출력 (기본은 실행 중인 컨테이너만)
  --filter <ftr>, -f <ftr>           조건에 따른 출력 필터링
  --format <fmt>                     Go 템플릿을 사용한 컨테이너 출력 포맷 지정
  --last , -n                        최근 생성된 n개의 컨테이너 출력 (모든 상태 포함)
  --latest , -l                      가장 최근 생성된 컨테이너 출력 (모든 상태 포함)
  --no-trunc                         출력 내용 잘림 방지 (예: 컨테이너 ID, Sha256 이미지 참조, 명령줄)
  --quiet , -q                       컨테이너 ID만 출력
  --size , -s                        총 파일 크기 출력

추가 옵션 (`docker ps`에는 없는 옵션):
  --silent                           출력하지 않음
  --timezone                         날짜 출력에 사용할 시간대 지정
  --color <true|false>               터미널 컬러 출력 활성화/비활성화
  --no-color                         터미널 컬러 출력 비활성화
  --socket <filepath>                도커 소켓 경로 지정 (기본값: `auto` - 도커 CLI 호출로 소켓 결정)
  --timeformat <go-time-fmt>         날짜시간 출력 형식 지정 (golang 문법)
  --no-header                        테이블 헤더 출력하지 않음
  --simple-header                    헤더 아래 선 출력하지 않음
  --format <fmt>                     여러 포맷 지정 가능, 터미널 너비에 맞는 첫 번째 포맷 사용
  --sort <col>                       특정 열 기준 정렬, --format과 동일한 식별자 사용, 테이블 포맷과 함께 사용 시 유용
  --sort-direction <ASC|DESC>        정렬 방향, --sort와 함께 사용 시 유용
  --watch <interval>, -w <interval>  자동 주기적 출력 갱신 (간격은 선택 사항, 기본: 2초)

사용 가능한 --format 키 (기본값):
  {{.ID}}                            컨테이너 ID
  {{.Image}}                         이미지 ID

  {{.Command}}                       인용된 명령어
  {{.CreatedAt}}                     컨테이너가 생성된 시간.
  {{.RunningFor}}                    컨테이너가 시작된 이후 경과 시간.
  {{.Ports}}                         공개된 포트. ([!] docker CLI와 다르며, 여기서는 공개된 포트만 표시)
  {{.State}}                         컨테이너 상태
  {{.Status}}                        자세한 컨테이너 상태
  {{.Size}}                          컨테이너 디스크 크기.
  {{.Names}}                         컨테이너 이름들.
  {{.Labels}}                        컨테이너에 할당된 모든 라벨.
  {{.Label}}                         [!] 지원되지 않음
  {{.Mounts}}                        이 컨테이너에 마운트된 볼륨 이름들.
  {{.Networks}}                      이 컨테이너에 연결된 네트워크 이름들.

사용 가능한 --format 키 (추가 | `docker ps`에 없음):
  {{.ImageName}}                     이미지 ID (태그 및 레지스트리 제외)
  {{.ImageTag}}, {{.Tag}}            이미지 태그
  {{.ImageRegistry}}, {{.Registry}}  이미지 레지스트리
  {{.ShortCommand}}                  인수 없는 명령어
  {{.LabelKeys}}                     컨테이너에 할당된 모든 라벨 (키만)
  {{.ShortPublishedPorts}}           공개된 포트, {{.Ports}}보다 간략한 출력
  {{.LongPublishedPorts}}            공개된 포트, IP 포함 전체 출력
  {{.ExposedPorts}}                  노출된 포트
  {{.PublishedPorts}}                공개된 포트
  {{.NotPublishedPorts}}             노출되었지만 공개되지 않은 포트
  {{.PublicPorts}}                   공개된 포트 중 공개 부분만
  {{.IP}}                            내부 IP 주소
~~~~~~


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-16

---