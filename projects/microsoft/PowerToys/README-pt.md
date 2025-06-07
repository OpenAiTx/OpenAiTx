# Microsoft PowerToys

![Imagem principal do Microsoft PowerToys](doc/images/overview/PT_hero_image.png)

[Como usar o PowerToys][usingPowerToys-docs-link] | [Downloads & Notas de versão][github-release-link] | [Contribuindo para o PowerToys](#contributing) | [O que está acontecendo](#whats-happening) | [Roteiro](#powertoys-roadmap)

## Sobre

O Microsoft PowerToys é um conjunto de utilitários para usuários avançados ajustarem e otimizarem sua experiência no Windows para maior produtividade. Para mais informações sobre [visão geral do PowerToys e como usar os utilitários][usingPowerToys-docs-link], ou outras ferramentas e recursos para [ambientes de desenvolvimento Windows](https://learn.microsoft.com/windows/dev-environment/overview), acesse [learn.microsoft.com][usingPowerToys-docs-link]!

|              | Utilitários atuais: |              |
|--------------|--------------------|--------------|
| [Colagem Avançada](https://aka.ms/PowerToysOverview_AdvancedPaste) | [Sempre no Topo](https://aka.ms/PowerToysOverview_AoT) | [PowerToys Awake](https://aka.ms/PowerToysOverview_Awake) |
| [Seletor de Cores](https://aka.ms/PowerToysOverview_ColorPicker) | [Comando Não Encontrado](https://aka.ms/PowerToysOverview_CmdNotFound) | [Paleta de Comandos](https://aka.ms/PowerToysOverview_CmdPal) |
| [Recortar e Bloquear](https://aka.ms/PowerToysOverview_CropAndLock) | [Variáveis de Ambiente](https://aka.ms/PowerToysOverview_EnvironmentVariables) | [FancyZones](https://aka.ms/PowerToysOverview_FancyZones) |
| [Complementos do Explorador de Arquivos](https://aka.ms/PowerToysOverview_FileExplorerAddOns) | [File Locksmith](https://aka.ms/PowerToysOverview_FileLocksmith) | [Editor de Arquivo Hosts](https://aka.ms/PowerToysOverview_HostsFileEditor) |
| [Redimensionador de Imagens](https://aka.ms/PowerToysOverview_ImageResizer) | [Gerenciador de Teclado](https://aka.ms/PowerToysOverview_KeyboardManager) | [Utilitários do Mouse](https://aka.ms/PowerToysOverview_MouseUtilities) |
| [Mouse Sem Fronteiras](https://aka.ms/PowerToysOverview_MouseWithoutBorders) | [Novo+](https://aka.ms/PowerToysOverview_NewPlus) | [Colar como Texto Sem Formatação](https://aka.ms/PowerToysOverview_PastePlain) |
| [Peek](https://aka.ms/PowerToysOverview_Peek) | [PowerRename](https://aka.ms/PowerToysOverview_PowerRename) | [PowerToys Run](https://aka.ms/PowerToysOverview_PowerToysRun) |
| [Acento Rápido](https://aka.ms/PowerToysOverview_QuickAccent) | [Pré-visualização do Registro](https://aka.ms/PowerToysOverview_RegistryPreview) | [Régua de Tela](https://aka.ms/PowerToysOverview_ScreenRuler) |
| [Guia de Atalhos](https://aka.ms/PowerToysOverview_ShortcutGuide) | [Extrator de Texto](https://aka.ms/PowerToysOverview_TextExtractor) | [Workspaces](https://aka.ms/PowerToysOverview_Workspaces) |
| [ZoomIt](https://aka.ms/PowerToysOverview_ZoomIt) |

## Instalando e executando o Microsoft PowerToys

### Requisitos

- Windows 11 ou Windows 10 versão 2004 (codinome 20H1 / build 19041) ou mais recente.
- Processador x64 ou ARM64
- Nosso instalador instalará os seguintes itens:
   - Bootstrapper do [Microsoft Edge WebView2 Runtime](https://go.microsoft.com/fwlink/p/?LinkId=2124703). Isso instalará a versão mais recente.

### Via GitHub com EXE [Recomendado]

Acesse a [página de lançamentos do Microsoft PowerToys no GitHub][github-release-link] e clique em `Assets` no final para exibir os arquivos disponíveis no lançamento. Utilize o instalador do PowerToys apropriado para a arquitetura e escopo de instalação da sua máquina. Para a maioria, é `x64` e por usuário.

<!-- itens que precisam ser atualizados de release para release -->
[github-next-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.92%22
[github-current-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.91%22
[ptUserX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-x64.exe 
[ptUserArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-arm64.exe 
[ptMachineX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-x64.exe 
[ptMachineArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-arm64.exe
 
|  Descrição   | Nome do arquivo | hash sha256 |
|--------------|-----------------|-------------|
| Por usuário - x64       | [PowerToysUserSetup-0.91.1-x64.exe][ptUserX64] | 42EA4A3E8C79A5456476D19E72B3E2AB9393A89C4DC7442EB7EE5A1E3490D38A |
| Por usuário - ARM64     | [PowerToysUserSetup-0.91.1-arm64.exe][ptUserArm64] | F3F433FE04049F9197411D792AADEBF34E3BE7FE16327BD8B73D2A046ED8BAF6 |
| Para todos - x64        | [PowerToysSetup-0.91.1-x64.exe][ptMachineX64] | EC4BC3A8625775866B0ED4577CCF83E6EC7B1A0AD267379DDBAF4FE49C7B5BDD |
| Para todos - ARM64      | [PowerToysSetup-0.91.1-arm64.exe][ptMachineArm64] | 9CB8911008420D0E446AE3D5CE365E447FA4DF9DCF9337F3A80F933C00FC3689 |

Este é o nosso método preferido.

### Via Microsoft Store

Instale pela [página do PowerToys na Microsoft Store][microsoft-store-link]. Você deve estar usando a [nova Microsoft Store](https://blogs.windows.com/windowsExperience/2021/06/24/building-a-new-open-microsoft-store-on-windows-11/), disponível tanto para Windows 11 quanto para Windows 10.

### Via WinGet
Baixe o PowerToys pelo [WinGet][winget-link]. Atualizar o PowerToys via winget irá respeitar o escopo atual da instalação do PowerToys. Para instalar o PowerToys, execute o seguinte comando no prompt de comando / PowerShell:

#### Instalador no escopo do usuário [padrão]
```powershell
winget install Microsoft.PowerToys -s winget
```

#### Instalador no escopo da máquina

```powershell
winget install --scope machine Microsoft.PowerToys -s winget
```

### Outros métodos de instalação

Existem [métodos de instalação conduzidos pela comunidade](./doc/unofficialInstallMethods.md), como Chocolatey e Scoop. Se estas forem suas soluções de instalação preferidas, você pode encontrar as instruções lá.

## Plugins de Terceiros para Run

Há uma coleção de [plugins de terceiros](./doc/thirdPartyRunPlugins.md) criados pela comunidade que não são distribuídos com o PowerToys.

## Contribuindo

Este projeto aceita contribuições de todos os tipos. Além de desenvolvimento de funcionalidades/correções de bugs, outras formas de ajudar incluem escrita de especificações, design, documentação e identificação de bugs. Estamos empolgados em trabalhar com a comunidade de usuários avançados para construir um conjunto de ferramentas que ajude você a tirar o máximo do Windows.

Pedimos que **antes de iniciar o trabalho em uma funcionalidade que gostaria de contribuir**, leia nosso [Guia do Contribuidor](CONTRIBUTING.md). Ficaremos felizes em trabalhar com você para definir a melhor abordagem, fornecer orientação e mentoria durante o desenvolvimento e ajudar a evitar esforços duplicados ou desperdiçados.

A maioria das contribuições exige que você concorde com um [Acordo de Licença de Contribuidor (CLA)][oss-CLA] declarando que você nos concede os direitos para usar sua contribuição e que você tem permissão para fazê-lo.

Para orientações sobre desenvolvimento no PowerToys, leia a [documentação para desenvolvedores](/doc/devdocs) para um detalhamento detalhado. Isso inclui como configurar seu computador para compilar.

## O que está acontecendo

### Roteiro do PowerToys

Nosso [roteiro priorizado][roadmap] de funcionalidades e utilitários nos quais a equipe principal está focando.

### 0.91 - Atualização de Maio de 2025

Nesta versão, focamos em novos recursos, estabilidade e automação.

**✨Destaques**

 - Focamos em melhorar muito o desempenho da Paleta de Comandos e corrigir uma grande quantidade de bugs. Alguns novos recursos adicionados:
 - Adicionada a capacidade da Paleta de Comandos buscar qualquer arquivo usando um comando de fallback.
 - Adicionada a opção de tornar o atalho global da Paleta de Comandos um hook de teclado de baixo nível.
 - Adicionado comando de fallback para abrir URLs na extensão WebSearch, permitindo que usuários abram URLs diretamente no navegador pela Paleta de Comandos.
 - Agora é possível definir formatos personalizados nos plugins de Data e Hora do PT Run e da Paleta de Comandos. Obrigado [@htcfreek](https://github.com/htcfreek)!

### Colagem Avançada

 - Corrigido um problema onde a Colagem Avançada falhava ao criar o mecanismo OCR para certos idiomas em inglês (ex: en-CA), inicializando o OCR com o idioma do perfil do usuário. Obrigado [@cryolithic](https://github.com/cryolithic)!

### Seletor de Cores

 - Corrigido um problema de vazamento de recursos que causava travamentos ou congelamentos ao liberar corretamente o objeto Graphics. Obrigado [@dcog989](https://github.com/dcog989)!
 - Corrigido um problema onde o Seletor de Cores fechava ao pressionar Backspace, garantindo que só feche quando estiver focado e alinhando o comportamento das teclas Escape/Backspace. Obrigado [@PesBandi](https://github.com/PesBandi)!
 - Adicionado suporte aos formatos de cor Oklab e Oklch no Seletor de Cores. Obrigado [@lemonyte](https://github.com/lemonyte)!

### Comando Não Encontrado

 - Atualizado o script do WinGet Command Not Found para habilitar apenas recursos experimentais que realmente existam.

### Paleta de Comandos

 - Atualizado o modelo de bug para incluir o módulo Paleta de Comandos.
 - Corrigido um problema onde a janela de notificação não era dimensionada para DPI, causando problemas de layout com escalonamento de exibição.
 - Corrigido um problema onde a navegação com as teclas Cima/Baixo não movia a seleção quando o cursor estava na posição 0, e adicionada navegação contínua semelhante ao PT Run v1. Obrigado [@davidegiacometti](https://github.com/davidegiacometti)!
 - Código da extensão de Data e Hora simplificado e aprimorado.
 - Corrigido um problema onde a capitalização no comando causava falha ao tentar ir para o ponteiro do mouse, ajustando o comando para minúsculas.
 - Adicionado comando de fallback para abrir URLs na extensão WebSearch, permitindo abrir URLs diretamente no navegador pela Paleta de Comandos. Obrigado [@htcfreek](https://github.com/htcfreek)!
 - Adicionada configuração para ativar/desativar o ícone na bandeja do sistema no CmdPal e alinhado a terminologia com o Windows 11. Obrigado [@davidegiacometti](https://github.com/davidegiacometti)!
 - Corrigido problema de atualização de alias ao remover o antigo quando um novo é definido.
 - Resolvido conflito de diferenciação de maiúsculas/minúsculas no GitHub migrando Exts e exts para um novo diretório ext, garantindo estrutura consistente entre plataformas e evitando fragmentação de caminhos.
 - Corrigido problema onde o comando 'Criar Nova Extensão' gerava nomes de arquivo vazios.
 - Adicionada a opção de tornar o atalho global um hook de teclado de baixo nível.
 - Adicionado suporte para miniaturas JUMBO, permitindo acesso a ícones em alta resolução.
 - Corrigidos travamentos quando o CmdPal se autoocultava enquanto um diálogo MSAL estava aberto, impedindo o CmdPal de se ocultar se estiver desativado.
 - Adicionado suporte para seleção imediata do texto de busca ao carregar uma página.
 - Corrigido bug onde páginas de configurações de extensões não eram recarregadas ao reabrir, atualizando o formulário de configurações ao salvar as configurações da extensão.
 - Corrigido problema onde a Paleta de Comandos não era iniciada pelo runner.
 - Refatorada e portada a lógica da calculadora do PowerToys Run v1 para a Paleta de Comandos, adicionando suporte a configurações e melhorando o comportamento de fallback.
 - Re-adicionado suporte a atalhos de teclado em itens de lista.
 - Melhorada acessibilidade na Paleta de Comandos, adicionando rótulos apropriados, refinando animações, melhorando a localização e corrigindo problemas relacionados a a11y.
 - Portado suporte a formatos personalizados para o plugin de Data e Hora, reordenando e limpando as configurações, melhorando mensagens de erro e corrigindo travamentos em casos extremos para um comportamento mais robusto e amigável. Obrigado [@htcfreek](https://github.com/htcfreek)!
 - Adicionado item de fallback para comando do sistema.
 - Corrigido bug no Comando do Sistema Windows onde o prompt da tecla exibia "Vazio" para a ação "Abrir Lixeira". Obrigado [@jironemo](https://github.com/jironemo)!
 - Corrigido problema onde a lista de 'mais comandos' mostrava comandos que não deveriam estar visíveis. Obrigado [@davidegiacometti](https://github.com/davidegiacometti)!
 - Corrigido problema onde a visualização detalhada na Paleta de Comandos exibia ícone superdimensionado e texto desalinhado, alinhando com o comportamento da Busca do Windows.
 - Corrigido bug onde conteúdo de tela vazio e comandos da barra de comandos eram cortados ao usar rótulos longos, garantindo layout e visibilidade adequados.
 - Melhorada integração do CmdPal com o WinGet corrigindo exibição de versão para pacotes instalados, permitindo atualizações com ícones e migrando a API preview do winget para versão estável.
 - Corrigido bug onde comandos para ContentPage não eram atualizados até após a saída, inicializando totalmente menus de contexto ao alterar.
 - Adicionado suporte de fallback à extensão TimeDate, permitindo consultas diretas de data/hora sem selecionar comando previamente.
 - Importado Common.Dotnet.AotCompatibility.props em vários arquivos de projeto CmdPal para melhorar suporte à compilação AOT.
 - Corrigido travamento nas configurações do CmdPal causado por HotKey nulo quando settings.json está ausente ou sem hotkey definida. Obrigado [@davidegiacometti](https://github.com/davidegiacometti)!
 - Adicionado suporte a menus de contexto filtráveis e aninhados no CmdPal, incluindo caixa de busca para manter comportamento de foco.
 - Refatoradas classes CmdPal para melhorar a serialização JSON e introduzidos novos contextos de serialização para melhor desempenho e manutenção.
 - Adicionado suporte à compilação ahead-of-time (AoT).
 - Adicionado mecanismo de repetição para lançamento do CmdPal.
 - Removidos alguns arquivos não utilizados do CmdPal.Common para simplificar base de código e facilitar marcação como compatível com AoT.
 - Corrigido bug de condição de corrida ao atualizar SearchText causando salto automático do cursor para o final da linha, garantindo atualização apenas após mudança real.
 - Adicionado suporte para buscar qualquer arquivo em comando de fallback.
 - Limpeza de código relacionado ao AoT para evitar operações duplicadas durante testes.
 - Reduzido tempo de carregamento do CmdPal paralelizando inicialização das extensões e adicionando timeouts para evitar que extensões com mau comportamento bloqueiem as demais.
 - Melhorado comportamento da UI ao dispensar o painel de detalhes quando a lista fica vazia, evitando estados visuais inconsistentes.
 - Adicionado suporte para desabilitar comando de fallback no CmdPal quando nenhum comando correspondente é encontrado, garantindo recarregamento mais limpo.
 - Corrigido vazamento no template de extensão CmdPal ao tratar uso impróprio do ComServer.
 - Prevenido maximização da janela CmdPal ao dar duplo clique na barra de título, mantendo o comportamento pretendido da janela. Obrigado [@davidegiacometti](https://github.com/davidegiacometti)!
 - Corrigido problema onde a UI de Configurações era lançada muito pequena tornando dimensões da janela sensíveis ao DPI e impondo largura e altura mínimas usando WinUIEx.
 - Corrigido flash branco e problemas de animação única no CmdPal ocultando a janela ao invés de escondê-la.
 - Corrigido bug onde todas as configurações de extensões eram buscadas na inicialização ao carregar configurações sob demanda, reduzindo sobrecarga de inicialização.
 - Adicionado suporte à proteção do CmdPal contra travamentos em falhas de parsing de Adaptive Card.
 - Substituída shell:AppsFolder por ativação URI no CmdPal para melhorar confiabilidade.
 - Adicionada a capacidade de abrir configurações do CmdPal a partir das Configurações do PowerToys.
 - Adicionada a capacidade do CmdPal observar e atualizar dinamicamente detalhes de extensões rastreando mudanças de propriedades no item selecionado.
 - Atualizada a versão do toolkit usado no template de extensão CmdPal para 0.2.0.

### Redimensionador de Imagens

 - Corrigido problema onde ao excluir um preset do Redimensionador de Imagens, o preset errado era removido.

### Gerenciador de Teclado

 - Corrigido problema onde uma tecla modificadora, ao ser definida sem especificar esquerda ou direita, ficava travada devido ao tratamento incorreto, passando a rastrear teclas pressionadas e enviar a correta. Obrigado [@mantaionut](https://github.com/mantaionut)!

### PowerRename

 - Ampliadas as capacidades de formatação de hora do PowerRename adicionando padrões de formato de hora de 12 horas com suporte AM/PM. Obrigado [@bitmap4](https://github.com/bitmap4)!

### PowerToys Run

 - Adicionado suporte a formatos personalizados no plugin "Data e Hora" e aprimoradas mensagens de erro para formatos inválidos. Obrigado [@htcfreek](https://github.com/htcfreek)!
 - Corrigidos dois travamentos: um para WFT em datas muito antigas e outro ao calcular a semana do mês em datas muito futuras (ex: 31.12.9999), além de reordenar configurações da UI. Obrigado [@htcfreek](https://github.com/htcfreek)!
 - Corrigido problema onde a capitalização no comando causava falha ao tentar ir para o ponteiro do mouse, ajustando para minúsculas.
 - Adicionados detalhes da versão às mensagens de erro do plugin para 'Erro de carregamento' e 'Erro de inicialização'. Obrigado [@htcfreek](https://github.com/htcfreek)!
 - Aprimorado modelo de resultados adicionando suporte para prevenir ordenação baseada em uso, dando aos desenvolvedores de plugins maior controle sobre o comportamento de ordenação. Obrigado [@CoreyHayward](https://github.com/CoreyHayward) e [@htcfreek](https://github.com/htcfreek)!

### Acento Rápido

 - Atualizado mapeamento de letras em GetDefaultLetterKeyEPO, substituindo "ǔ" por "ŭ" para a tecla VK_U, refletindo com precisão a fonética do Esperanto. Obrigado [@OlegKharchevkin](https://github.com/OlegKharchevkin)!
 - Corrigido problema onde o Acento Rápido não funcionava corretamente ao usar o teclado virtual. Obrigado [@davidegiacometti](https://github.com/davidegiacometti)!

### Pré-visualização do Registro

 - Aprimorada a Pré-visualização do Registro para suportar colagem de chaves e valores do registro sem escrever manualmente o cabeçalho do arquivo e adicionado novo botão para redefinir o aplicativo. Obrigado [@htcfreek](https://github.com/htcfreek)!

### Configurações

 - Corrigido problema onde o app de Configurações mostrava ocasionalmente um ícone em branco na barra de tarefas ao adiar a atribuição do ícone até a ativação da janela.
 - Adicionada a capacidade de maximizar a janela "Novidades" para uma experiência de leitura mais confortável.

### Workspaces

 - Corrigidos bugs onde jogos da Steam não eram capturados ou lançados corretamente ao atualizar o filtro de janelas e integrar o protocolo de URL da Steam.

### Documentação

 - Adicionado QuickNotes à documentação de plugins de terceiros para o PowerToys Run. Obrigado [@ruslanlap](https://github.com/ruslanlap)!
 - Adicionados os plugins Weather e Pomodoro à documentação de plugins de terceiros do PowerToys Run. Obrigado [@ruslanlap](https://github.com/ruslanlap)!
 - Adicionado o plugin Linear à documentação de plugins de terceiros do PowerToys Run. Obrigado [@vednig](https://github.com/vednig)!
 - Corrigidos problemas de formatação em arquivos de documentação e atualizadas informações de contribuidores e membros da equipe. Obrigado [@DanielEScherzer](https://github.com/DanielEScherzer) e [@RokyZevon](https://github.com/RokyZevon)!

### Desenvolvimento

 - Atualizada Action do GitHub para instalar o .NET 9 para suporte ao lançamento MSStore.
 - Atualizado placeholder de versão em bug_report.yml para evitar versionamento incorreto v0.70.0 em relatórios de problemas.
 - Atualizada Action do GitHub para atualizar actions/setup-dotnet da versão 3 para 4 para lançamento MSStore.
 - Adicionado securityContext aos arquivos de configuração do WinGet, permitindo invocação pelo contexto do usuário e solicitando um único UAC para recursos elevados em processo separado. Obrigado [@mdanish-kh](https://github.com/mdanish-kh)!
 - Alteradas extensões de arquivos de log de .txt para .log para suportar associações e compatibilidade de ferramentas, e adicionados logs para Workspace. Obrigado [@benwa](https://github.com/benwa)!
 - Atualizadas dependências do framework de testes e alinhadas versões de pacotes entre componentes.
 - Atualizadas dependências para corrigir vulnerabilidades.
 - Aprimorada segurança do repositório fixando Actions do GitHub e tags do Docker em commits imutáveis e integrando varredura automática de vulnerabilidades de dependências via Dependency Review Workflow. Obrigado [@Nick2bad4u](https://github.com/Nick2bad4u)!
 - Atualizadas dependências Boost para versão mais recente.
 - Atualizado toolkit para última versão, suprimindo avisos relacionados ao AoT.
 - Corrigido problema onde ausência de assinatura em novos arquivos causava falhas de build.
 - Atualizado pipeline de lançamento para impedir publicação de símbolos privados por 100 anos.
 - Introduzido fuzzing para PowerRename para melhorar confiabilidade e adicionadas orientações de configuração para expandir fuzzing a outros módulos C++.
 - Adicionada criação centralizada de pastas geradas para todos os projetos .csproj para prevenir falhas de build.
 - Atualizado WinAppSDK para a versão mais recente 1.7.
 - Atualizadas dependências Boost para a versão mais recente no projeto PowerRename Fuzzing.
 - Atualizado o caminho da área do ADO em tsa.json para resolver erros de pipeline TSA causados por caminho obsoleto.
 - Iniciado suporte AoT para CmdPal com trabalho fundamental em andamento.
  
### Ferramenta/Geral

 - Adicionado suporte à automação da criação de relatórios de bug gerando URL de issue do GitHub pré-preenchida com informações do sistema e diagnóstico. Obrigado [@donlaci](https://github.com/donlaci)!
 - Adicionados scripts para build local do instalador, garantindo que o CmdPal também possa ser iniciado localmente.
 - Removida lógica de exportação PFX para eliminar uso de senha hardcoded e resolver alerta de segurança do PSScriptAnalyzer.
 - Adicionado script PowerShell e integração CI para reforçar uso consistente do Common.Dotnet.CsWinRT.props em todos os projetos C# sob a pasta src.
   
### O que está sendo planejado para a versão 0.92

Para [v0.92][github-next-release-work], trabalharemos nos itens abaixo:

 - Polimento contínuo da Paleta de Comandos
 - Novos testes de Automação de UI
 - Trabalhando em atualizações do instalador
 - Atualização da interface do editor do Gerenciador de Teclado
 - Estabilidade / correções de bugs

## Comunidade PowerToys

A equipe do PowerToys é extremamente grata pelo [apoio de uma comunidade ativa incrível][community-link]. O trabalho que você faz é extremamente importante. O PowerToys não seria nem de longe o que é hoje sem sua ajuda relatando bugs, atualizando documentação, orientando o design ou desenvolvendo funcionalidades. Queremos agradecer e dedicar tempo para reconhecer seu trabalho. Mês a mês, você ajuda diretamente a tornar o PowerToys um software melhor.

## Código de Conduta

Este projeto adotou o [Código de Conduta de Código Aberto da Microsoft][oss-conduct-code].

## Política de Privacidade

O aplicativo registra dados básicos de diagnóstico (telemetria). Para mais informações sobre privacidade e o que coletamos, consulte nossa [documentação de Dados e Privacidade do PowerToys](https://aka.ms/powertoys-data-and-privacy-documentation).

[oss-CLA]: https://cla.opensource.microsoft.com
[oss-conduct-code]: CODE_OF_CONDUCT.md
[community-link]: COMMUNITY.md
[github-release-link]: https://aka.ms/installPowerToys
[microsoft-store-link]: https://aka.ms/getPowertoys
[winget-link]: https://github.com/microsoft/winget-cli#installing-the-client
[roadmap]: https://github.com/microsoft/PowerToys/wiki/Roadmap
[privacy-link]: http://go.microsoft.com/fwlink/?LinkId=521839
[loc-bug]: https://github.com/microsoft/PowerToys/issues/new?assignees=&labels=&template=translation_issue.md&title=
[usingPowerToys-docs-link]: https://aka.ms/powertoys-docs

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---