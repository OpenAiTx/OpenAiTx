# PSFree versão 1.5.1

PSFree é uma coleção de exploits para o console PS4. O foco principal do repositório é o PS4, mas tentamos tornar as coisas portáveis para o PS5.

## Funcionalidades

- **Auto-detecção:** Detecta automaticamente o tipo de console e a versão do firmware (via [`src/config.mjs`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/src/config.mjs)).
- **Exploit WebKit (PSFree):** Ponto de entrada via o navegador web do console.
- **Exploit de Kernel (Lapse):** Eleva privilégios ao nível de kernel.
- **Carregador de Payload:** Após a exploração bem-sucedida do kernel, escuta por um payload na porta 9020.

## Escopo da Vulnerabilidade

|               | PSFree    | Lapse      |
| :------------ | :-------- | :--------- |
| PlayStation 4 | 6.00-9.60 | 1.01-12.02 |
| PlayStation 5 | 1.00-5.50 | 1.00-10.01 |

## Suporte deste Repositório

Esta tabela indica as versões de firmware para as quais a _versão atual_ deste repositório fornece uma cadeia de exploit funcional e testada.

|               | PSFree    | Lapse     |
| :------------ | :-------- | :-------- |
| PlayStation 4 | 7.00-9.60 | 7.00-9.60 |
| PlayStation 5 | N/A       | N/A       |

_Nota: O suporte para outros firmwares listados na tabela "Escopo da Vulnerabilidade" pode, ou não, estar sendo ativamente desenvolvido ou pode ter sido suportado em versões anteriores deste repositório. Por favor, verifique o [`CHANGELOG.md`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/CHANGELOG.md) para suporte histórico._

## Lista de Tarefas (TODO)

- [ ] Problema de tela preta/salvamento com certos jogos
- [ ] `lapse.mjs`: Apenas definir os bits para privilégios JIT
- [ ] `view.mjs`: Assume PS4, adicionar suporte ao PS5 também
- [ ] Adicionar suporte ao PS5

## Direitos Autorais e Autores:

AGPL-3.0-ou-posterior (veja [LICENSE](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/LICENSE)). Este repositório pertence ao grupo `anonymous`. Referimo-nos a colaboradores anônimos também como "anonymous".

## Créditos:

- anonymous pelos dumps de kernel de firmware do PS4
- Verifique os arquivos apropriados para quaisquer **contribuidores extras**. Salvo indicação em contrário, tudo aqui também pode ser creditado a nós.

## Doações

(Monero/XMR): **86Fk3X9AE94EGKidzRbvyiVgGNYD3qZnuKNq1ZbsomFWXHYm6TtAgz9GNGitPWadkS3Wr9uXoT29U1SfdMtJ7QNKQpW1CVS**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---