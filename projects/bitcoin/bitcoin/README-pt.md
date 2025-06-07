Árvore de integração/staging do Bitcoin Core
============================================

https://bitcoincore.org

Para uma versão binária do software Bitcoin Core pronta para uso imediato, veja
https://bitcoincore.org/en/download/.

O que é o Bitcoin Core?
-----------------------

O Bitcoin Core conecta-se à rede peer-to-peer do Bitcoin para baixar e validar completamente blocos e transações. Ele também inclui uma carteira e uma interface gráfica de usuário, que podem ser compiladas opcionalmente.

Mais informações sobre o Bitcoin Core estão disponíveis na [pasta doc](/doc).

Licença
-------

O Bitcoin Core é lançado sob os termos da licença MIT. Veja [COPYING](COPYING) para mais
informações ou acesse https://opensource.org/license/MIT.

Processo de Desenvolvimento
---------------------------

O branch `master` é compilado regularmente (veja `doc/build-*.md` para instruções) e testado, mas não há garantia de que seja
completamente estável. [Tags](https://github.com/bitcoin/bitcoin/tags) são criadas
regularmente a partir dos branches de lançamento para indicar novas versões oficiais e estáveis do Bitcoin Core.

O repositório https://github.com/bitcoin-core/gui é usado exclusivamente para o
desenvolvimento da GUI. Seu branch master é idêntico em todos os repositórios monotree.
Branches de lançamento e tags não existem, portanto, por favor, não faça fork
desse repositório a menos que seja para fins de desenvolvimento.

O fluxo de contribuição é descrito em [CONTRIBUTING.md](CONTRIBUTING.md)
e dicas úteis para desenvolvedores podem ser encontradas em [doc/developer-notes.md](doc/developer-notes.md).

Testes
------

Testes e revisão de código são o gargalo do desenvolvimento; recebemos mais pull
requests do que podemos revisar e testar em curto prazo. Por favor, tenha paciência e ajude testando
pull requests de outras pessoas, e lembre-se de que este é um projeto crítico para segurança, onde qualquer erro pode custar muito dinheiro às pessoas.

### Testes Automatizados

Os desenvolvedores são fortemente encorajados a escrever [testes unitários](src/test/README.md) para novos códigos e a
submeter novos testes unitários para códigos antigos. Testes unitários podem ser compilados e executados
(assumindo que não foram desabilitados durante a geração do sistema de build) com: `ctest`. Mais detalhes sobre como executar
e estender testes unitários podem ser encontrados em [/src/test/README.md](/src/test/README.md).

Há também [testes de regressão e integração](/test), escritos
em Python.
Esses testes podem ser executados (se as [dependências de teste](/test) estiverem instaladas) com: `build/test/functional/test_runner.py`
(assumindo que `build` é seu diretório de build).

Os sistemas de CI (Integração Contínua) garantem que todo pull request seja compilado para Windows, Linux e macOS,
e que testes unitários/de sanidade sejam executados automaticamente.

### Testes Manuais de Garantia de Qualidade (QA)

As alterações devem ser testadas por alguém que não seja o desenvolvedor que escreveu o
código. Isso é especialmente importante para mudanças grandes ou de alto risco. É útil
adicionar um plano de teste à descrição do pull request se testar as alterações não for algo trivial.

Traduções
---------

Alterações em traduções, bem como novas traduções, podem ser submetidas à
[página do Bitcoin Core no Transifex](https://www.transifex.com/bitcoin/bitcoin/).

As traduções são periodicamente puxadas do Transifex e mescladas ao repositório git. Veja o
[processo de tradução](doc/translation_process.md) para detalhes de como isso funciona.

**Importante**: Não aceitamos alterações de tradução como pull requests no GitHub porque a próxima
sincronização com o Transifex as sobrescreveria automaticamente.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---