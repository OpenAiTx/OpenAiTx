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

## **Spis treści**
### 1. [**O projekcie**](#o-projekcie)
### 2. [**Szybki start**](#szybki-start)
>#### 2.1.   [**Wymagania**](#wymagania)
>#### 2.2.  [**Instalacja**](#instalacja-horusec)
### 3. [**Użytkowanie**](#uzytkowanie)
>#### 3.1. [**Użycie CLI**](#uzycie-cli)
>#### 3.2. [**Użycie Dockera**](#uzycie-dockera)
>#### 3.3. [**Starsze wersje**](#starsze-wersje)
>#### 3.4. [**Użycie aplikacji Horusec-Web**](#uzycie-aplikacji-horusec-web)
>#### 3.5.  [**Użycie Visual Studio Code**](#uzycie-visual-studio-code)
>#### 3.6. [**Użycie w Pipeline**](#uzycie-w-pipeline)
### 4. [**Dokumentacja**](#dokumentacja)       
### 5. [**Roadmap**](#roadmap)
### 6. [**Współtworzenie**](#wspoltworzenie)
### 7. [**Kodeks postępowania**](#kodeks-postepowania)
### 8. [**Licencja**](#licencja)
### 9. [**Społeczność**](#spolecznosc)



<br>
<br>
<br>

# **O projekcie**
Horusec to narzędzie open source, które wykonuje statyczną analizę kodu w celu identyfikacji błędów bezpieczeństwa podczas procesu tworzenia oprogramowania. Aktualnie obsługiwane języki to: C#, Java, Kotlin, Python, Ruby, Golang, Terraform, Javascript, Typescript, Kubernetes, PHP, C, HTML, JSON, Dart, Elixir, Shell, Nginx. 
Narzędzie umożliwia wyszukiwanie wycieków kluczy i podatności we wszystkich plikach projektu, jak również w historii Git. Horusec może być używany przez programistę z poziomu CLI oraz przez zespół DevSecOps na macierzach CI/CD.

Zapoznaj się z naszą [**dokumentacją**](https://docs.horusec.io/docs/overview/), gdzie znajdziesz kompletną listę narzędzi i języków, które analizuje Horusec.

<p align="center" margin="20 0"><img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec-complete-architecture.png" alt="architecture" width="100%" style="max-width:100%;"/></p>

### **Przykład wyniku działania:**

<img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/usage_horusec.gif" alt="usage_gif" width="100%" style="max-width:100%;"/>

# **Szybki start**

## **Wymagania**

- Docker

Musisz mieć zainstalowanego Dockera na swoim komputerze, aby uruchomić Horusec ze wszystkimi narzędziami, z których korzystamy.
Jeśli nie masz Dockera, mamy [**flagę**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags) `-D true`, która wyłącza tę zależność, jednak ogranicza to możliwości analizy.
Zalecamy używanie z Dockerem.

Jeśli włączysz autorów commitów `-G true`, potrzebna będzie także zależność `git`.

## **Instalacja Horusec**
### **Mac lub Linux**
```
make install
```

lub

```sh
curl -fsSL https://raw.githubusercontent.com/ZupIT/horusec/master/deployments/scripts/install.sh | bash -s latest
```

#### **Sprawdzenie instalacji**
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

#### **Sprawdzenie instalacji**
```bash
./horusec.exe version
```

### **I więcej**

- Wszystkie pliki binarne wraz z wersjami znajdziesz na naszej [**stronie wydań**](https://github.com/ZupIT/horusec/releases).

- Szczegółowe informacje o instalacji znajdziesz w [**dokumentacji**](https://docs.horusec.io/docs/cli/installation) 


## **Użytkowanie**
### **Użycie CLI**
Aby użyć horusec-cli i sprawdzić podatności aplikacji, użyj poniższego polecenia:
```bash
horusec start -p .
```
> Gdy horusec rozpoczyna analizę, tworzy folder o nazwie **`.horusec`**. Ten folder służy do tego, by nie modyfikować Twojego kodu. Zalecamy dodanie linii **`.horusec`** do pliku **`.gitignore`**, aby folder ten nie był wysyłany na serwer git.

### **Użycie Dockera**
Możliwe jest użycie Horusec przez obraz dockera **`horuszup/horusec-cli:latest`**.

Wykonaj poniższe polecenie:
```sh
docker run -v /var/run/docker.sock:/var/run/docker.sock -v $(pwd):/src horuszup/horusec-cli:latest horusec start -p /src -P $(pwd)
```

- Utworzyliśmy wolumen zawierający projekt `-v $(pwd):/src`.

Przy użyciu obrazu dockera mamy dwie ścieżki, w których można znaleźć projekt.

Flaga `-p` oznacza ścieżkę projektu wewnątrz kontenera, w naszym przykładzie `/src`.
Flaga `-P` oznacza ścieżkę projektu na zewnątrz kontenera, w naszym przykładzie jest to `$(pwd)`,
należy również podać tę ścieżkę przy montowaniu wolumenu `-v $(pwd):/src`.

### **Starsze wersje**

Horusec w wersji v1 jest nadal dostępny.

**UWAGA:** Endpoint z v1 będzie wycofany, zalecamy aktualizację CLI do v2. Szczegóły w [**dokumentacji**](https://docs.horusec.io/docs/migrate-v1-to-v2/). 

### **Mac lub Linux**
``` sh
curl -fsSL https://horusec.io/bin/install.sh | bash -s latest
```

### **Windows**
```sh
curl "https://horusec.io/bin/latest/win_x64/horusec.exe" -o "./horusec.exe" && ./horusec.exe version
```

- Starsze pliki binarne znajdziesz pod tym adresem, w tym najnowszą wersję v1 **`v1.10.3`**. 
- Od wersji v2 pliki binarne nie będą już dystrybuowane pod tym adresem, znajdziesz je na [**stronie wydań**](https://github.com/ZupIT/horusec/releases).

### **Użycie aplikacji Horusec-Web**
Zarządzaj swoimi podatnościami przez nasz interfejs webowy. Możesz mieć dashboard z metrykami dotyczącymi podatności, kontrolą fałszywie pozytywnych wyników, tokenami autoryzacyjnymi, aktualizacją podatności i wieloma innymi.
Zobacz sekcję [**web application**](https://github.com/ZupIT/horusec-platform), aby czytać dalej.

Sprawdź poniższy przykład, przesyła on analizę do usług webowych Horusec:
```bash
horusec start -p <ŚCIEŻKA_DO_TWOJEGO_PROJEKTU> -a <TWÓJ_TOKEN_AUTORYZACYJNY>
```

Zobacz [**tutorial jak utworzyć token autoryzacyjny przez Horusec Manager Web Service**](https://docs.horusec.io/docs/tutorials/how-to-create-an-authorization-token).

**UWAGA:** Nasze usługi webowe zostały przeniesione do [**nowego repozytorium**](https://github.com/ZupIT/horusec-platform). Musisz zaktualizować do v2, zobacz [**jak przejść z v1 do v2**](https://docs.horusec.io/docs/migrate-v1-to-v2).

### **Użycie Visual Studio Code**
Możesz analizować swój projekt za pomocą rozszerzenia Horusec do Visual Studio Code.
Więcej informacji znajdziesz w [**dokumentacji**](https://docs.horusec.io/docs/extensions/visual-studio-code/).

### **Użycie w Pipeline**
Możesz przeprowadzić analizę projektu zanim wdrożysz go w swoim środowisku, zapewniając maksymalne bezpieczeństwo w organizacji.
Więcej informacji znajdziesz w [**dokumentacji**](https://docs.horusec.io/docs/cli/installation/#installation-via-pipeline):

### **Funkcje**
Zobacz poniżej: 
- Analizuje jednocześnie 18 języków przy użyciu 20 różnych narzędzi bezpieczeństwa, zwiększając dokładność;
- Przeszukuje historię git pod kątem sekretów i innych ujawnionych treści;
- Analiza jest w pełni konfigurowalna, [**zobacz wszystkie dostępne opcje CLI**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags).

## **Dokumentacja**
Dokumentację Horusec znajdziesz na naszej [**stronie**](https://docs.horusec.io/docs/overview/).

## **Roadmap**
Posiadamy projektowy [**roadmap**](ROADMAP.md), możesz do niego dołączyć!

Horusec posiada inne repozytoria, sprawdź je:

- [**Horusec Platform**](https://github.com/ZupIT/horusec-platform)
- [**Horusec DevKit**](https://github.com/ZupIT/horusec-devkit)
- [**Horusec Engine**](https://github.com/ZupIT/horusec-engine)
- [**Horusec Operator**](https://github.com/ZupIT/horusec-operator)
- [**Horusec VsCode**](https://github.com/ZupIT/horusec-vscode-plugin)

## **Wkład w rozwój projektu**

Zapraszamy do korzystania, sugerowania ulepszeń lub współtworzenia nowych implementacji.

Sprawdź nasz [**przewodnik dla współtwórców**](https://raw.githubusercontent.com/ZupIT/horusec/main/CONTRIBUTING.md), aby dowiedzieć się więcej o naszym procesie rozwoju oraz o tym, jak zgłaszać poprawki błędów i ulepszenia.

### **Certyfikat pochodzenia programisty - DCO**

To jest warstwa bezpieczeństwa dla projektu i programistów. Jest obowiązkowa.

Wykonaj jedną z poniższych metod, aby dodać DCO do swoich commitów:

**1. Wiersz poleceń**  
Wykonaj następujące kroki:  
**Krok 1:** Skonfiguruj lokalne środowisko git, dodając to samo imię i adres e-mail, które są skonfigurowane na Twoim koncie GitHub. Pomaga to podpisywać commity ręcznie podczas przeglądów i sugestii.

```
git config --global user.name “Imię”
git config --global user.email “email@domena.com”
```
**Krok 2:** Dodaj linię Signed-off-by używając flagi `'-s'` w poleceniu git commit:

```
$ git commit -s -m "To jest moja wiadomość commita"
```
**2. Strona internetowa GitHub**

Możesz również ręcznie podpisać swoje commity podczas przeglądów i sugestii na GitHubie, wykonaj poniższe kroki: 

**Krok 1:** Gdy pojawi się okno zmian commita, ręcznie wpisz lub wklej swój podpis w polu komentarza, zobacz przykład:

```
Signed-off-by: Imię < adres e-mail >
```

W tej metodzie Twoje imię i adres e-mail muszą być takie same jak te zarejestrowane na Twoim koncie GitHub.

## **Kodeks postępowania**
Prosimy o przestrzeganie [**Kodeksu postępowania**](https://github.com/ZupIT/horusec/blob/main/CODE_OF_CONDUCT.md) we wszystkich interakcjach z naszym projektem.

## **Licencja**
[**Apache License 2.0**](https://raw.githubusercontent.com/ZupIT/horusec/main/LICENSE).

## **Społeczność**

Zapraszamy do kontaktu z nami poprzez:

- [**GitHub Issues**](https://github.com/ZupIT/horusec/issues)
- Jeśli masz pytania lub pomysły, porozmawiajmy na naszym [**Forum Open Source Zup**](https://forum.zup.com.br).

Ten projekt istnieje dzięki wszystkim współtwórcom. Jesteście niesamowici! ❤️ 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---