
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

﻿# Elucidate

- [Descrição do Projeto](#project-description)
- [Requisitos do Sistema:](#os-requirements)
- [Perguntas Frequentes](#faqs)
- [Roteiro](#roadmap)
- [Capturas de Tela](#screenshots)

## Descrição do Projeto

Elucidate é uma interface gráfica para Windows para o aplicativo SnapRAID de linha de comando.

*Este projeto continua a fusão do excelente trabalho realizado por mim e outros colaboradores.

## Requisitos do Sistema

- Sistema Operacional Windows
- Runtime .Net 4.8.0
- SnapRaid Versão 11.5 ou inferior
- 10MB de espaço livre na unidade de destino

## Perguntas Frequentes

**Q**: O que é SnapRAID?<br/>
**A**: SnapRAID é um mecanismo de paridade por snapshot definido por software para sistemas operacionais Windows e Linux. Em seu nível mais básico, oferece proteção ao conteúdo de um sistema de arquivos sob sua gestão, calculando os hashes dos arquivos componentes e armazenando os resultados em um arquivo de paridade. Em caso de falha total de um disco rígido, esse arquivo de paridade pode ser usado para reconstruir os dados perdidos. Para detalhes completos, visite a [comparação oficial de mecanismos de proteção de arquivos do SnapRAID.](http://snapraid.sourceforge.net/compare.html)

**Q**: Por que uma interface gráfica, a linha de comando funciona!<br/>
**A**: O objetivo maior é criar uma interface gráfica completa com recursos adicionais de gerenciamento para auxiliar o usuário na manutenção de um ambiente SnapRAID funcional. Às vezes, ‘apontar e clicar’ é mais fácil para iniciantes começarem. A documentação técnica e a profunda configurabilidade do SnapRAID podem tornar sua adoção desanimadora para quem deseja experimentá-lo!

**Q**: Ainda estou incerto, há mais informações?<br/>
**A**: Sim, Veja a [documentação](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./docs/Documentation.md) para imagens etc.

**Q**: Então quais são os "Grandes Objetivos"?<br/>
**A**: Veja o __Roadmap__ abaixo para uma descrição completa.

## Roadmap

- [x] Fase I
  - [x] Tentar acompanhar o suporte mínimo da versão mais recente do SnapRAID. - __Em andamento.__
  - [x] Facilidade de uso
  - [x] SnapRAID tem três comandos, então vamos torná-los simples de acessar para um iniciante 
  - [x] Indicador(es) de progresso 
  - [x] Registro "Interativo" e direto para o log. 
  - [x] Inicialização automática ao login do usuário 
  - [x] Dicas de ferramentas para orientar •

- [x] Fase II Solicitações de recursos da Fase II
  - [x] Pausar, alterar prioridade, abortar.
  - [x] Extensão de Comando - "Permitir parâmetros extras aos padrões usados."
  - [x] Agendamento 
    - Removido, use o CommandLine
  - [x] Visualização gráfica dos dados protegidos.

- [ ] Fase III (Reinício para 2017-03 em diante)
  - [x] Novo Compilador e .Net 4.7.x	
  - [x] Interface de Linha de Comando
  - [ ] Novo Layout via Krypton Toolkit / Navigator / etc. 
    - Em andamento
  - [ ] Traduções 
  - [x] Novos Comandos
  - [ ] Enviador de e-mails com relatórios de status
  - [ ] Documentar passos de teste
    - Em andamento
  - [ ] Adicionar à documentação / Atualizar imagens
    - Em andamento
  - [ ] Adicionar relatório de erros no _Windows EventLog_
  - [x] Adicionar _ExceptionLess_ para relatório online de exceções
  - [x] Exibir o que pode ser recuperado. 

- [ ] Fase IV (novos Comandos SnapRAID ?) 
  - [ ] Ajuda estendida com recuperação de disco - guias interativos etc.
  - [ ] Notificar o usuário se a versão do SnapRAID estiver desatualizada
  - [ ] Interpretar os logs do SnapRAID (usado pelas mudanças abaixo)
  - [ ] Fornecer o status do array após execução de comando
  - [ ] Modificar o comando sync para incluir um diff inicial
  - [ ] Modificar o comando sync para lançar um alerta se o diff reportar problemas acima de um limite
  - [ ] Adicionar configurações de requisitos de limite de sync pelo usuário


## Capturas de Tela

![Tela Inicial](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/starting_view.png)

![Formulário de Configurações](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/Settings_Form.PNG)


## Você pode ajudar?
- Procurando testadores (Todas as plataformas .Net)
- Pode ajudar a traduzir 
- Ajuda / Guias de interface do usuário 
- Qualquer outra ideia :-) 
- Desenvolvedores para as ideias 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---