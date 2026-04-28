# Epyon

Epyon 是一款用于渗透测试 DevOps 生态系统的瑞士军刀工具。

可用模块：

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

# 构建

克隆仓库并使用 Golang 构建项目：

```
$ git clone https://github.com/pasknel/epyon.git
$ cd epyon
$ go build
```
确保“config.yaml”文件与主二进制文件位于同一文件夹中（使用“config-example.yaml”作为模板）。

检查二进制文件：


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

# 示例

请参阅项目的维基以获取文档和使用示例

# 待办事项

[查看TODO文件](https://raw.githubusercontent.com/pasknel/epyon/main/TODO.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---