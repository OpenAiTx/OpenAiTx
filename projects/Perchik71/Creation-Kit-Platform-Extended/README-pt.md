<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

<p align="center">
  <img src="https://github.com/Perchik71/Creation-Kit-Platform-Extended/blob/master/Resources/logo.png" alt="Creation Kit Platform Extended" border="0" width="400px">
</p>
<p align="center">
  Uma coleção de modificações, melhorias e recursos de engenharia reversa para o Creation Kit da Bethesda.
</p>


# Descrição
**CKPE** é uma poderosa plataforma de código compartilhado que realiza várias correções e melhorias no editor Creation Kit da **Bethesda**, incluindo suporte ao editor para jogos como **Skyrim Special Edition**, **Fallout 4**, **Starfield**. É um sucessor dos projetos [SSE CKFixes](https://github.com/Nukem9/skyrimse-test), [SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest), [FO4 CKFixes](https://github.com/Perchik71/Fallout4Test), além do [Unicode patch for SSE CK 1.5.73](https://github.com/Perchik71/usse_test), que iniciou tudo para o autor **perchik71**.  

Página [Wiki](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki)  

# Dependências
[toml11](https://github.com/ToruNiina/toml11) por `ToruNiina` e outros  
[Zydis](https://github.com/zyantific/zydis.git) por `zyantifi` e outros  
[zipper](https://github.com/kuba--/zip.git) por `kuba--`  
[libdeflate](https://github.com/ebiggers/libdeflate.git) por `ebiggers` e outros  
[xbyak](https://github.com/herumi/xbyak.git) por `herumi` e outros  
[DirectXTex](https://github.com/microsoft/DirectXTex.git) por `microsoft`  
[jDialogs](https://github.com/Perchik71/jDialogs.git) por `perchik71` *(recursivo)*

# Instalação
>[!IMPORTANTE]
>Lançamento regular ou noavx2?  
>Verifique com a Steam se seu processador suporta avx2. Abra a Steam, no canto esquerdo passe o mouse sobre o menu ajuda, selecione Informações do Sistema e procure por AVX2.  
>Se suportar, use o lançamento regular  
>Se não suportar, use o lançamento noavx2  
### Instalação Nova
Baixe qualquer [jogo suportado](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief) e instale o Creation Kit.  
Baixe a [última versão](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) do **CKPE** para seu jogo.  
Extraia todo o conteúdo no diretório do jogo, para que **ckpe_loader.exe** fique na mesma pasta que **CreationKit.exe**.
### Atualização
Baixe a [última versão](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) do **CKPE** para seu jogo.  
Extraia todo o conteúdo no diretório do jogo, para que **ckpe_loader.exe** fique na mesma pasta que **CreationKit.exe**.  
Concorde em substituir todos os arquivos.
### Compilação
Usuários comuns só precisam deste método para acessar recursos mais novos ainda não lançados.  
Abra o projeto no **`Visual Studio 2022`** ou superior. Compile o projeto em modo **`Release`** ou **`Release-NoAVX2`**.  
Depois mova o resultado da compilação para o diretório do jogo, para que **ckpe_loader.exe** fique na mesma pasta que **CreationKit.exe**.  
Se for solicitado a substituir arquivos antigos, concorde em substituir todos.
### Automatizar builds (Beta)
Baixe o [build do último commit](https://github.com/Perchik71/Creation-Kit-Platform-Extended/actions) do **CKPE** para seu jogo.  
Extraia todo o conteúdo no diretório do jogo, para que **ckpe_loader.exe** fique na mesma pasta que **CreationKit.exe**.  
Possíveis erros.

# Créditos
[Nukem9](https://github.com/Nukem9) (por funções experimentais, hash e assim por diante, muito útil)  
[adzm](https://github.com/adzm) (Agradeço muito seu trabalho, você [fez](https://github.com/adzm/win32-custom-menubar-aero-theme) o que eu há muito tempo queria fazer eu mesmo)  
[yak3d](https://github.com/yak3d) (Pela contribuição e desenvolvimento do workflow e suporte ao mais novo Starfield)  
[DioKyrie-Git](https://github.com/DioKyrie-Git) (Pelo design do readme)  

# Licença
A partir da v0.6 (commit [9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)) o projeto está licenciado sob [LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html). <br />
Versões anteriores estão licenciadas sob [GPLv3](https://www.gnu.org/licenses/gpl-3.0.html) <br />
Copyright © 2023-2025 aka perchik71. Todos os direitos reservados. <br />
O arquivo `Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak` contém arquivos proprietários e não licenciados; o mesmo se aplica aos arquivos em `d3dcompiler\*.*`. <br />
Dependências estão sob suas respectivas licenças. 



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---