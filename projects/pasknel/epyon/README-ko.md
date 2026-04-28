# Epyon

Epyon은 DevOps 생태계 펜테스팅을 위한 만능 도구입니다.

사용 가능한 모듈:

1. Gitlab
2. Github
3. Jenkins
4. Azure DevOps
5. Sonatype Nexus
6. Docker Registry
7. Sonarqube
8. Gitea
9. Artifactory
10. Terraform Cloud/Enterprise
11. Harbor

# 빌드

저장소를 클론하고 Golang으로 프로젝트를 빌드하세요:

```
$ git clone https://github.com/pasknel/epyon.git
$ cd epyon
$ go build
```

"config.yaml" 파일이 메인 바이너리와 동일한 폴더에 있는지 확인하세요 ("config-example.yaml"을 템플릿으로 사용).

바이너리를 확인하세요:

```
$ ./epyon -h

Epyon: Swiss army knife for pentesting DevOps ecosystems

Usage:
  epyon [flags]
  epyon [command]

Available Commands:
  artifactory Interact with JFrog Artifactory
  azure       Interact with Azure DevOps
  completion  Generate the autocompletion script for the specified shell
  gitea       Interact with Gitea server
  github      Interact with Github (Enterprise and Actions)
  gitlab      Interact with Gitlab Server
  gitleaks    Scan projects folders with Gitleaks
  harbor      Interact with Harbor Server
  help        Help about any command
  horusec     Static source code analysis with Horusec
  jenkins     Interact with Jenkins Server
  nexus       Interact with Nexus Repository
  registry    Interact with Docker Registry
  sonarqube   Interact with Sonarqube API
  terraform   Interact with Terraform Cloud/Enterprise
  trufflehog  Find leaked credentials with TruffleHog

Flags:
  -h, --help                  help for epyon
  -P, --proxy-pass string     Proxy Password
  -X, --proxy-server string   Proxy Server
  -U, --proxy-user string     Proxy User
  -S, --socks-server string   SOCKS5 Server (ip:port)
  -K, --ssl-insecure          SSL Insecure (default true)
  -V, --verbose               Verbose

Use "epyon [command] --help" for more information about a command.
```
# 예제

프로젝트의 위키에서 문서와 사용 예제를 확인하세요

# 할 일

[TODO 파일 확인하기](https://raw.githubusercontent.com/pasknel/epyon/main/TODO.md)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---