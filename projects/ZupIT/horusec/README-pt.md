<p align="center" margin="20 0"><a href="https://horusec.io/">
    <img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec_logo.png" alt="logo_header" width="65%" style="max-width:100%;"/></a></p>

<p align="center">
    <a href="https://github.com/ZupIT/horusec/releases" alt="version">
        <img src="https://img.shields.io/github/v/release/ZupIT/horusec?label=version"/></a>
    <a href="https://github.com/ZupIT/horusec/pulse" alt="activity">
        <img src="https://img.shields.io/github/commit-activity/m/ZupIT/horusec?label=activity"/></a>
    <a href="https://github.com/ZupIT/horusec/graphs/contributors" alt="contributors">
        <img src="https://img.shields.io/github/contributors/ZupIT/horusec?label=contributors"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/lint.yml" alt="lint">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Lint?label=lint"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/test.yml" alt="test">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Test?label=test"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/security.yml" alt="security">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Security?label=security"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/coverage.yml" alt="coverage">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Coverage?label=coverage"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/e2e.yml" alt="e2e">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/e2e?label=e2e"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/build.yaml" alt="build">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Build?label=build"/></a>
    <a href="https://opensource.org/licenses/Apache-2.0" alt="license">
        <img src="https://img.shields.io/badge/license-Apache%202-blue"/></a>
    <a href="https://bestpractices.coreinfrastructure.org/projects/5146"><img src="https://bestpractices.coreinfrastructure.org/projects/5146/badge"></a>
</p>

## **Tabela de Conteúdos**
### 1. [**Sobre**](#about)
### 2. [**Primeiros passos**](#getting-started)
>#### 2.1.   [**Requisitos**](#requirements)
>#### 2.2.  [**Instalação**](#installing-horusec)
### 3. [**Uso**](#usage)
>#### 3.1. [**Uso via CLI**](#cli-usage)
>#### 3.2. [**Usando Docker**](#using-docker)
>#### 3.3. [**Versões antigas**](#older-versions)
>#### 3.4. [**Usando a aplicação Horusec-Web**](#using-horusec-web-application)
>#### 3.5.  [**Usando Visual Studio Code**](#using-visual-studio-code)
>#### 3.6. [**Usando no Pipeline**](#using-the-pipeline)
### 4. [**Documentação**](#documentation)       
### 5. [**Roadmap**](#roadmap)
### 6. [**Contribuindo**](#contributing)
### 7. [**Código de Conduta**](#code-of-conduct)
### 8. [**Licença**](#license)
### 9. [**Comunidade**](#community)



<br>
<br>
<br>

# **Sobre**
Horusec é uma ferramenta open source que realiza análise estática de código para identificar falhas de segurança durante o processo de desenvolvimento. Atualmente, as linguagens suportadas para análise são: C#, Java, Kotlin, Python, Ruby, Golang, Terraform, Javascript, Typescript, Kubernetes, PHP, C, HTML, JSON, Dart, Elixir, Shell, Nginx. 
A ferramenta possui opções para buscar vazamentos de chaves e falhas de segurança em todos os arquivos do seu projeto, assim como no histórico do Git. O Horusec pode ser utilizado pelo desenvolvedor através do CLI e pela equipe de DevSecOps nos ambientes de CI/CD.

Confira nossa [**Documentação**](https://docs.horusec.io/docs/overview/), onde você verá a lista completa de ferramentas e linguagens que o Horusec realiza análise.

<p align="center" margin="20 0"><img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec-complete-architecture.png" alt="architecture" width="100%" style="max-width:100%;"/></p>

### **Veja um exemplo de saída:**

<img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/usage_horusec.gif" alt="usage_gif" width="100%" style="max-width:100%;"/>

# **Primeiros passos**

## **Requisitos**

- Docker

Você precisa ter o Docker instalado em sua máquina para rodar o Horusec com todas as ferramentas que utilizamos.
Caso não tenha o Docker, temos uma [**flag**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags) `-D true` que desabilita a dependência, mas também perde grande parte do poder de análise.
Recomendamos utilizar com Docker.

Se você habilitar autores do commit `-G true`, também há a dependência do `git`.

## **Instalando o Horusec**
### **Mac ou Linux**
```
make install
```

ou

```sh
curl -fsSL https://raw.githubusercontent.com/ZupIT/horusec/master/deployments/scripts/install.sh | bash -s latest
```

#### **Verifique a instalação**
```bash
horusec version
```

### **Windows**
- **amd64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_amd64.exe" -o "./horusec.exe" -L
    ```

- **arm64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_arm64.exe" -o "./horusec.exe" -L
    ```

#### **Verifique a instalação**
```bash
./horusec.exe version
```

### **E mais**

- Você pode encontrar todos os binários com versões na nossa [**página de releases**](https://github.com/ZupIT/horusec/releases).

- Para mais detalhes de instalação, consulte a [**documentação**](https://docs.horusec.io/docs/cli/installation) 


## **Uso**
### **Uso via CLI**
Para utilizar o horusec-cli e verificar as vulnerabilidades da aplicação, use o comando abaixo:
```bash
horusec start -p .
```
> Quando o horusec inicia uma análise, ele cria uma pasta chamada **`.horusec`**. Essa pasta serve como base para não alterar seu código. Recomendamos que você adicione a linha **`.horusec`** em seu arquivo **`.gitignore`** para que esta pasta não precise ser enviada ao seu servidor git.

### **Usando Docker**
É possível utilizar o Horusec através de uma imagem docker **`horuszup/horusec-cli:latest`**.

Execute o comando abaixo para isso:
```sh
docker run -v /var/run/docker.sock:/var/run/docker.sock -v $(pwd):/src horuszup/horusec-cli:latest horusec start -p /src -P $(pwd)
```

- Criamos um volume contendo o projeto `-v $(pwd):/src`.

Com a imagem docker, acabamos tendo dois caminhos onde o projeto pode ser encontrado.

O parâmetro `-p` representa o caminho do projeto dentro do container, em nosso exemplo `/src`.
O parâmetro `-P` representa o projeto fora do container, em nosso exemplo é representado por `$(pwd)`,
também sendo necessário para passar o caminho do projeto ao montar o volume `-v $(pwd):/src`.

### **Versões antigas**

A versão v1 do Horusec ainda está disponível.

**ATENÇÃO:** O endpoint com a v1 será descontinuado, por favor atualize seu CLI para a v2. Veja mais detalhes na [**documentação**](https://docs.horusec.io/docs/migrate-v1-to-v2/). 

### **Mac ou Linux**
``` sh
curl -fsSL https://horusec.io/bin/install.sh | bash -s latest
```

### **Windows**
```sh
curl "https://horusec.io/bin/latest/win_x64/horusec.exe" -o "./horusec.exe" && ./horusec.exe version
```

- Os binários antigos podem ser encontrados neste endpoint, incluindo a última versão da v1 **`v1.10.3`**. 
- A partir da v2, os binários não serão mais distribuídos por este endpoint, e você pode encontrar na [**página de releases**](https://github.com/ZupIT/horusec/releases).

### **Usando a aplicação Horusec-Web**
Gerencie suas vulnerabilidades através de nossa interface web. Você pode ter um dashboard com métricas sobre suas vulnerabilidades, controle de falsos positivos, token de autorização, atualização de vulnerabilidades e muito mais.
Veja a seção da [**aplicação web**](https://github.com/ZupIT/horusec-platform) para continuar lendo sobre isso.

Confira o exemplo abaixo, ele está enviando uma análise para os serviços web do Horusec:
```bash
horusec start -p <PATH_TO_YOUR_PROJECT> -a <YOUR_AUTHORIZATION_TOKEN>
```

Veja [**o tutorial de como criar um token de autorização pelo Horusec Manager Web Service**](https://docs.horusec.io/docs/tutorials/how-to-create-an-authorization-token).

**ATENÇÃO:** Nossos serviços web foram movidos para um [**novo repositório**](https://github.com/ZupIT/horusec-platform). Você precisa atualizar para a v2, veja [**como migrar da v1 para v2**](https://docs.horusec.io/docs/migrate-v1-to-v2).

### **Usando Visual Studio Code**
Você pode analisar seu projeto utilizando a extensão do Horusec para Visual Studio Code.
Para mais informações, [**consulte a documentação**](https://docs.horusec.io/docs/extensions/visual-studio-code/).

### **Usando no Pipeline**
Você pode realizar uma análise do seu projeto antes de liberar o deploy no seu ambiente, garantindo máxima segurança na sua organização.
Para mais informações, [**consulte a documentação**](https://docs.horusec.io/docs/cli/installation/#installation-via-pipeline):

### **Funcionalidades**
Veja abaixo: 
- Analisa simultaneamente 18 linguagens com 20 diferentes ferramentas de segurança para aumentar a precisão;
- Busca no histórico do git por segredos e outros conteúdos expostos;
- Sua análise pode ser totalmente configurável, [**veja todos os recursos disponíveis no CLI**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags).

## **Documentação**
Você pode encontrar a documentação do Horusec em nosso [**site**](https://docs.horusec.io/docs/overview/).

## **Roadmap**
Temos um [**roadmap**](ROADMAP.md) do projeto, você pode contribuir conosco!

O Horusec possui outros repositórios, confira:

- [**Horusec Platform**](https://github.com/ZupIT/horusec-platform)
- [**Horusec DevKit**](https://github.com/ZupIT/horusec-devkit)
- [**Horusec Engine**](https://github.com/ZupIT/horusec-engine)
- [**Horusec Operator**](https://github.com/ZupIT/horusec-operator)
- [**Horusec VsCode**](https://github.com/ZupIT/horusec-vscode-plugin)

## **Contribuindo**

Sinta-se à vontade para usar, sugerir melhorias ou contribuir com novas implementações.

Confira nosso [**guia de contribuição**](https://raw.githubusercontent.com/ZupIT/horusec/main/CONTRIBUTING.md) para saber mais sobre nosso processo de desenvolvimento, como sugerir correções de bugs e melhorias.

### **Certificado de Origem do Desenvolvedor - DCO**

Esta é uma camada de segurança para o projeto e para os desenvolvedores. É obrigatório.

Siga um destes dois métodos para adicionar o DCO aos seus commits:

**1. Linha de comando**
Siga os passos:
**Passo 1:** Configure seu ambiente git local adicionando o mesmo nome e e-mail configurados na sua conta do GitHub. Isso ajuda a assinar commits manualmente durante revisões e sugestões.

```
git config --global user.name “Nome”
git config --global user.email “email@dominio.com.br”
```
**Passo 2:** Adicione a linha Signed-off-by com a flag `'-s'` no comando git commit:

```
$ git commit -s -m "Esta é minha mensagem de commit"
```
**2. Site do GitHub**

Você também pode assinar manualmente seus commits durante revisões e sugestões no GitHub, siga os passos abaixo:

**Passo 1:** Quando a caixa de alteração de commit abrir, digite ou cole manualmente sua assinatura na caixa de comentários, veja o exemplo:

```
Signed-off-by: Nome < endereço de e-mail >
```

Para este método, seu nome e e-mail devem ser os mesmos cadastrados na sua conta do GitHub.

## **Código de Conduta**
Por favor, siga o [**Código de Conduta**](https://github.com/ZupIT/horusec/blob/main/CODE_OF_CONDUCT.md) em todas as suas interações com nosso projeto.

## **Licença**
[**Licença Apache 2.0**](https://raw.githubusercontent.com/ZupIT/horusec/main/LICENSE).

## **Comunidade**

Sinta-se à vontade para entrar em contato conosco em:

- [**GitHub Issues**](https://github.com/ZupIT/horusec/issues)
- Se você tiver dúvidas ou ideias, vamos conversar em nosso [**Fórum Zup Open Source**](https://forum.zup.com.br).

Este projeto existe graças a todos os colaboradores. Vocês são incríveis! ❤️ 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---