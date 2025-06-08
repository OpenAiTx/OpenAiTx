# Mamba: O Gerenciador de Pacotes Rápido e Multiplataforma

![mamba header image](https://raw.githubusercontent.com/mamba-org/mamba/main/docs/assets/mamba_header.png)

<!-- markdownlint-disable-file MD033 -->

<table>
<thead align="center" cellspacing="10">
  <tr>
    <th colspan="3" align="center" border="">parte do mamba-org</th>
  </tr>
</thead>
<tbody>
  <tr background="#FFF">
    <td align="center">Gerenciador de Pacotes <a href="https://github.com/mamba-org/mamba">mamba</a></td>
    <td align="center">Servidor de Pacotes <a href="https://github.com/mamba-org/quetz">quetz</a></td>
  </tr>
</tbody>
</table>

## mamba

[![Build Status](https://github.com/mamba-org/mamba/actions/workflows/tests.yml/badge.svg)](https://github.com/mamba-org/mamba/actions/workflows/tests.yml?query=branch%3Amain)
[![Join the Gitter Chat](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/mamba-org/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![docs](https://readthedocs.org/projects/mamba/badge/?version=latest&style=flat)](https://mamba.readthedocs.io/en/latest)
[![Gurubase](https://img.shields.io/badge/Gurubase-Ask%20mamba%20Guru-006BFF)](https://gurubase.io/g/mamba)

`mamba` é uma reimplementação do gerenciador de pacotes conda em C++.

- download paralelo de dados de repositório e arquivos de pacotes usando multithreading
- libsolv para uma resolução de dependências muito mais rápida, uma biblioteca de última geração usada no gerenciador de pacotes RPM do Red Hat, Fedora e OpenSUSE
- partes centrais do `mamba` são implementadas em C++ para máxima eficiência

Ao mesmo tempo, o `mamba` utiliza o mesmo analisador de linha de comando, código de instalação e desinstalação de pacotes e rotinas de verificação de transações do `conda` para manter a máxima compatibilidade possível.

`mamba` faz parte do ecossistema [conda-forge](https://conda-forge.org/), que também inclui o `quetz`, um servidor de pacotes `conda` de código aberto.

Você pode ler nosso [post de anúncio no blog](https://medium.com/@QuantStack/open-software-packaging-for-science-61cecee7fc23).

## micromamba

`micromamba` é a versão estaticamente vinculada do `mamba`.

Pode ser instalado como um executável independente sem quaisquer dependências, tornando-o ideal para pipelines de CI/CD e ambientes conteinerizados.

Consulte a [documentação sobre `micromamba`](https://mamba.readthedocs.io/en/latest/user_guide/micromamba.html) para mais detalhes.

## `mamba` vs. `micromamba`

Deve-se preferir o `mamba` quando:

- `libmambapy` ou `libmamba` são usados por outros softwares no mesmo ambiente.
- Cenários onde atualizações regulares de bibliotecas são necessárias (especialmente por segurança).
- Os ambientes focam em reduzir o uso de espaço em disco para dependências.

Deve-se preferir o `micromamba` quando:

- É necessário depender de um único executável autocontido.
- Uma distribuição miniforge não está presente.
- O uso exige tempo de execução mínimo.

## Instalação

Consulte o guia de instalação do [mamba](https://mamba.readthedocs.io/en/latest/installation/mamba-installation.html)
e do [micromamba](https://mamba.readthedocs.io/en/latest/installation/micromamba-installation.html) na documentação.

## Funcionalidades adicionais no Mamba e Micromamba

`mamba` e `micromamba` vêm com recursos além do `conda` padrão.

### `repoquery`

Para consultar repositórios e dependências de pacotes de forma eficiente, você pode usar `mamba repoquery` ou `micromamba repoquery`.

Veja a [documentação do repoquery](https://mamba.readthedocs.io/en/latest/user_guide/mamba.html#repoquery) para detalhes.

### Instalando arquivos de lock

O `micromamba` pode ser usado para instalar arquivos de lock gerados pelo [conda-lock](https://conda.github.io/conda-lock/) sem precisar instalar o `conda-lock`.

Basta executar `micromamba create` com a opção `-f`, fornecendo um arquivo de lock de ambiente cujo nome termina com
`-lock.yml` ou `-lock.yaml`; por exemplo:

```bash
micromamba create -n my-env -f conda-lock.yml
```

### setup-micromamba (substituto do setup-miniconda)

[setup-micromamba](https://github.com/marketplace/actions/setup-micromamba) é um substituto para o [setup-miniconda](https://github.com/marketplace/actions/setup-miniconda) que usa o `micromamba`.

Ele pode reduzir significativamente o tempo de configuração do seu CI:

- Usando o `micromamba`, que leva cerca de 1 s para instalar.
- Fazendo cache dos downloads de pacotes.
- Fazendo cache de ambientes `conda` inteiros.

## Diferenças em relação ao `conda`

Embora `mamba` e `micromamba` geralmente sejam substitutos diretos do `conda`, existem algumas diferenças:

- `mamba` e `micromamba` não suportam revisões (para discussões, veja <https://github.com/mamba-org/mamba/issues/803>)
- `mamba` e `micromamba` normalizam strings `MatchSpec` para a forma mais simples, enquanto o `conda` usa uma forma mais verbosa.
  Isso pode levar a pequenas diferenças na saída de `conda env export` e `mamba env export`.

## Instalação para desenvolvimento

Consulte as instruções fornecidas pela [documentação oficial](https://mamba.readthedocs.io/en/latest/developer_zone/dev_environment.html).

## Estabilidade de API e ABI

O projeto Mamba usa [versionamento semântico](https://semver.org/) no formato `MAJOR.MINOR.PATCH`.
Embora tentemos manter as coisas estáveis para os usuários, também precisamos fazer mudanças incompatíveis para melhorar
o Mamba e reduzir a dívida técnica.
Futuras versões do Mamba podem oferecer garantias mais fortes.

### `libmamba` (C++)

Não temos conhecimento de consumidores da API C++, então nos damos liberdade para melhorias.
Para o `libmamba`, o termo _compatível com versões anteriores_ é entendido da seguinte forma:

- _Compatível com ABI_ significa que você pode substituir os arquivos binários da biblioteca sem recompilar
  seu código com os headers atualizados.
  O comportamento observado será o mesmo, exceto por bugs (desaparecendo, esperamos) e desempenho.
- _Compatível com API_ significa que você deve recompilar seu código com o novo código da biblioteca,
  mas não precisará alterar seu código, apenas reconstruí-lo.
  Isso se aplica desde que você não tenha usado nenhuma declaração considerada privada, por exemplo,
  nos sub-namespaces `detail`.
  O comportamento observado será o mesmo, exceto por bugs (desaparecendo, esperamos) e desempenho.
  Quando declarações são depreciadas mas não removidas e ainda funcionais, também consideramos
  compatível com versões anteriores, já que apenas o comportamento observado durante a compilação muda.

Com isso em mente, o `libmamba` oferece as seguintes garantias:

- Lançamentos `PATCH` são compatíveis com API e ABI;
- Lançamentos `MINOR` são compatíveis com API para declarações em `mamba/api`,
  podendo quebrar API em outros locais e ABI em qualquer lugar;
- Lançamentos `MAJOR` não oferecem garantias.

### `libmambapy` (Python)

Para o `libmambapy`, o termo _compatível com API_ implica que seu código Python funcionará da
mesma forma para uma versão mais recente do `libmambapy`, desde que você não tenha usado nenhuma declaração considerada
privada, por exemplo, acessada com um nome iniciando com `_`.
O comportamento observado será o mesmo, exceto por bugs (desaparecendo, esperamos) e desempenho.
Quando declarações são depreciadas mas não removidas e ainda funcionais, também consideramos
compatível com versões anteriores, pois o comportamento só é observável ao ativar o Python
`DeprecationWarning`, geralmente ativado apenas em desenvolvimento.

Com isso em mente, o `libmambapy` oferece as seguintes garantias:

- Lançamentos `PATCH` são compatíveis com API;
- Lançamentos `MINOR` são compatíveis com API;
- Lançamentos `MAJOR` não oferecem garantias.

### `mamba` e `micromamba` (executáveis)

Para executáveis, o termo _compatível com versões anteriores_ aplica-se a entradas e saídas programáveis e significa
que seu código (incluindo scripts de shell) funcionará com versões mais recentes do executável sem
modificações.
Entradas/saídas programáveis incluem nome do executável, argumentos de linha de comando, arquivos de configuração,
variáveis de ambiente, saídas em JSON de linha de comando e arquivos criados.
Ele _exclui_ saída legível por humanos e mensagens de erro, e portanto avisos de depreciação escritos
na saída legível por humanos.

Com isso em mente, `mamba` e `micromamba` oferecem as seguintes garantias:

- Lançamentos `PATCH` são compatíveis com versões anteriores;
- Lançamentos `MINOR` são compatíveis com versões anteriores;
- Lançamentos `MAJOR` não oferecem garantias.

## Apoie-nos

Apenas o `mamba` e o `micromamba` 2.0 e posteriores são suportados e estão em desenvolvimento ativo.

O branch `1.x` é mantido apenas para tratamento de questões de segurança, como CVEs.

Para perguntas, você também pode nos encontrar no [Chat da QuantStack](https://gitter.im/QuantStack/Lobby)
ou no [canal Conda](https://gitter.im/conda/conda) (note que este projeto não tem afiliação oficial com `conda` ou Anaconda Inc.).

## Licença

Usamos um modelo de copyright compartilhado que permite a todos os contribuidores manter o copyright de suas contribuições.

Este software é licenciado sob a licença BSD-3-Clause. Veja o arquivo [LICENSE](https://raw.githubusercontent.com/mamba-org/mamba/main/LICENSE) para detalhes.

---

### Reunião de Desenvolvimento Quinzenal

Temos reuniões por videoconferência a cada duas semanas, onde discutimos no que estamos trabalhando e recebemos feedback uns dos outros.

Qualquer pessoa é bem-vinda para participar, caso queira discutir algum tópico ou apenas ouvir.

- Quando: Terça-feira [16:00 CET (Europa)](https://calendar.google.com/calendar/u/0/embed?src=ab3jrfpede0kq0ubsroe82cd00@group.calendar.google.com&ctz=Europe/Paris)
- Onde: [Mamba jitsi](https://meet.jit.si/mamba-org)
- O quê: [Notas da reunião](https://hackmd.io/@guj2k_aBSSyr1YHBG9raWw/HyHt-Ekzj)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---