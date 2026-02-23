
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Chocolatey-for-wine

Instalador automático do gerenciador de pacotes Chocolatey no wine, útil para instalar rapidamente programas no wine (e, consequentemente, encontrar bugs no wine ;) )  
Para alguns bugs, foram adicionadas soluções alternativas como para o Visual Studio Community 2022 e nodejs, veja mais adiante.  

Como estava entediado durante o lockdown, escrevi um winetricks(.ps1) personalizado com verbos que considero úteis. Basta digitar 'winetricks' para vê-los.
Para alguns verbos, é necessário reiniciar completamente o wine (devido a mudanças recentes no wine). Você verá uma caixa de mensagem e a sessão será encerrada. Basta iniciar o powershell novamente e tentar o verbo. Feito isso uma vez, não será mais necessário para nenhum verbo.  

Exemplo:  

'winetricks vs22_interactiveinstaller'  ( --> a sessão será encerrada)  

faça 'wine powershell'  

faça 'winetricks vs22_interactiveinstaller'  


(A propósito, através do 'winetricks vs22_interactive_installer' você pode escolher o que instalar via o instalador do Visual Studio 2022; 'winetricks vs22_interactive_installer' agora me levou em dez minutos ao programa principal (selecionado Desenvolvimento para Desktop com C++)).

Instalar :
- Baixe e descompacte o arquivo zip de lançamento e execute 'wine ChoCinstaller_0.5c.751.exe' (leva cerca de um minuto para completar)

Opcional:
- Execute o instalador como 'wine ChoCinstaller_0.5a.751.exe /s' , então os arquivos de instalação (como Powershell*.msi e dotnet48) são salvos em 
  Meus Documentos e não precisam ser baixados novamente se você criar um novo prefixo)
Opcional:
- Execute o instalador como 'wine ChoCinstaller_0.5a.751.exe /q' para evitar o lançamento automático da janela do powershell (instalação apenas). 

Opcional:
- Verifique se tudo correu bem: "choco install chromium" e  "start chrome.exe (--no-sandbox não é mais necessário a partir do wine-8,4)" 

![Screenshot from 2022-08-26 12-31-18](https://user-images.githubusercontent.com/26839562/186885380-d5a617c4-9cf4-4831-a475-2bd85a3b5784.png)
Sobre o PowerShell:

Dica: O Chocolatey geralmente instala a versão mais recente de um programa, o que pode revelar novos bugs no wine. Você pode ter mais sucesso com uma versão mais antiga do software.  
Exemplo:  

choco search --exact microsoft-edge --all (--> lista todas as versões)  

choco install microsoft-edge --version --version='135.0.3179.98'

Informações gerais:

- 'wine powershell.exe' inicia o console PowerShell-Core.

 
Sobre o ConEmu:

O console ConEmu sofre com alguns bugs do wine:
  - Ctrl^C para sair de um programa que não retorna ao console não funciona. Use Shift^Ctrl^C em vez disso.
  - Selecionar texto na janela do ConEmu (para copiar/colar) não destaca a seleção. Foi incluído um hack muito triste para versões recentes do wine que contorna isso, então o destaque deve funcionar agora.
   
Sobre o winetricks(.ps1):

- Se você não o executar ('winetricks' no console do powershell), nada é baixado, portanto, sem sobrecarga.
- Muitos verbos (como powershell 5.1) precisam de alguns arquivos essenciais para extrair conteúdo de pacotes msu. Instalar esses arquivos essenciais exige primeiro grandes downloads e leva bastante tempo na primeira utilização. Mas depois de armazenado em cache vai rápido. Por exemplo, se quiser tentar 'winetricks ps51' primeiro, levará cerca de 15 minutos. Alguns outros verbos podem levar 5 minutos na primeira utilização. Mas depois que você executa um verbo uma vez esse incômodo some.
- Os arquivos são armazenados em cache no diretório Meus Documentos. Se você executar todos os verbos, ocupará cerca de 800 MB lá.
- Esperançosamente, haverá melhor suporte para 64 bits em vários verbos.
- Possibilidade de extrair um arquivo e (tentar) instalar a partir de um arquivo msu. Faça 'winetricks install_dll_from_msu' para ver como.
- Um Powershell 5.1 rudimentar.
- Instalação experimental do dotnet481, e dotnet35 (pode ser necessário para apps que não se satisfazem com a instalação atual do dotnet48).
- Autocompletar com tabulação. Nota: ao usar múltiplos verbos na linha de comando, agora eles devem ser separados por vírgula (é assim que o powershell trata múltiplos argumentos)
  Assim, 'winetricks riched20 gdiplus' não funcionará mais, use 'winetricks riched20,gdiplus'
- Alguns programas falham ao instalar/executar quando você tenta via Chocolatey devido a bugs do wine. Adicionei algumas soluções alternativas no winetricks para eles, veja abaixo.
- Verbos especiais (winetricks vs19, vs22 e vs22_interactive_installer) para instalar Visual Studio Community 2019 e 2022 funcionais (veja screenshot, >10 min para instalar e requer aprox. 10GB!, após instalar, inicie devenv.exe do diretório c:\Program\ Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE/)
  ![screenshot](https://github.com/PietJankbal/Chocolatey-for-wine/assets/26839562/d576a619-c752-4eb1-81c2-6f6b66b50ff6)
- Verbo especial para acessar vários comandos unix como grep, sed, file, less, curl, etc. (winetricks git.portable, Aviso: alguns comandos ainda não funcionam devido a bugs do wine)
- Também incluídos alguns scripts powershell adaptados de trechos de código encontrados na internet:
    - Como embutir um exe em um script powershell via Invoke-ReflectivePEInjection (o exe não aparece no tasklist).
    - Como criar messageboxes sofisticadas
    - Converter um script powershell (ps1) em um exe.
    - E alguns outros
 
     
Sobre programas de sistema:

Foi adicionada a funcionalidade de substituir programas de sistema simples como, por exemplo, setx.exe por uma função em
c:\\Program Files\Powershell\7\profile.ps1. Ou adicionar programas de sistema ausentes como getmac.exe.
Se programas falharem por falta de maturidade ou ausência de programas de sistema, pode-se escrever uma 
função para retornar o que o programa espera.
Como no profile.ps1 adicionei (entre outros) um wmic.exe que suporta mais opções,
e um setx.exe básico.
Ou você pode apenas manipular os argumentos passados ao programa de sistema. Veja profile.ps1 e choc_install.ps1.
Não há garantia de que funcione para programas mais complexos também...
 
Notas:


  - NÃO use em um wineprefix existente, apenas em um prefixo recém-criado! O instalador apenas instala o dotnet48 de forma simples e altera chaves do registro.
    Se você já tiver alguma versão do dotnet instalada com o winetricks.sh normal, provavelmente irá falhar, e mesmo que funcione, você provavelmente ficará com um prefixo corrompido.
    Se precisar instalar algo com o winetricks.sh normal para programas, NÃO use nenhum dos verbos dotnet*.
    Aliás, os verbos 'Arial' e 'd3dcompiler_47' já são instalados por padrão.
  - WINEARCH=win32 _não_ é suportado!
  - Atualização de uma versão anterior não é suportada por enquanto, talvez no futuro

Compilar:
  - Se quiser compilar você mesmo ao invés de baixar os binários: veja as instruções de compilação em mainv1.c e installer.c
  - Depois copie choc_install.ps1 para o mesmo diretório
  - Depois execute 'wine ChoCinstaller_0.5a.735.exe'
  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---