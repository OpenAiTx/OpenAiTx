# Epyon

Epyon is a swiss army knife tool for pentesting DevOps ecosystems.

Available modules:

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

# Build

Clone the repository and build the project with Golang:

```
$ git clone https://github.com/pasknel/epyon.git
$ cd epyon
$ go build
```

Make sure the "config.yaml" file is in the same folder as the main binary (use "config-example.yaml" as template).

Check the binary:

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

# Examples

See the project's wiki for documentation and usage examples

# To do

[Check the TODO file](https://raw.githubusercontent.com/pasknel/epyon/main/TODO.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---