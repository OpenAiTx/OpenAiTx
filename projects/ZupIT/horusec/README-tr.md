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

## **İçindekiler**
### 1. [**Hakkında**](#about)
### 2. [**Başlarken**](#getting-started)
>#### 2.1.   [**Gereksinimler**](#requirements)
>#### 2.2.  [**Kurulum**](#installing-horusec)
### 3. [**Kullanım**](#usage)
>#### 3.1. [**CLI Kullanımı**](#cli-usage)
>#### 3.2. [**Docker Kullanımı**](#using-docker)
>#### 3.3. [**Eski Sürümler**](#older-versions)
>#### 3.4. [**Horusec-Web Uygulaması Kullanımı**](#using-horusec-web-application)
>#### 3.5.  [**Visual Studio Code Kullanımı**](#using-visual-studio-code)
>#### 3.6. [**Pipeline Kullanımı**](#using-the-pipeline)
### 4. [**Dokümantasyon**](#documentation)       
### 5. [**Yol Haritası**](#roadmap)
### 6. [**Katkıda Bulunma**](#contributing)
### 7. [**Davranış Kuralları**](#code-of-conduct)
### 8. [**Lisans**](#license)
### 9. [**Topluluk**](#community)



<br>
<br>
<br>

# **Hakkında**
Horusec, geliştirme sürecinde güvenlik açıklarını tespit etmek için statik kod analizi gerçekleştiren açık kaynaklı bir araçtır. Şu anda analiz için desteklenen diller: C#, Java, Kotlin, Python, Ruby, Golang, Terraform, Javascript, Typescript, Kubernetes, PHP, C, HTML, JSON, Dart, Elixir, Shell, Nginx.
Araç, projenizdeki tüm dosyalarda ve Git geçmişinde anahtar sızıntılarını ve güvenlik açıklarını arama seçeneklerine sahiptir. Horusec, geliştirici tarafından CLI üzerinden ve DevSecOps ekibi tarafından CI/CD ortamlarında kullanılabilir.

[**Dokümantasyonumuzu**](https://docs.horusec.io/docs/overview/) inceleyin, Horusec’in analiz gerçekleştirdiği tüm araçlar ve dillerin tam listesini görebilirsiniz.

<p align="center" margin="20 0"><img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec-complete-architecture.png" alt="architecture" width="100%" style="max-width:100%;"/></p>

### **Çıktı Örneği:**

<img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/usage_horusec.gif" alt="usage_gif" width="100%" style="max-width:100%;"/>

# **Başlarken**

## **Gereksinimler**

- Docker

Horusec’i kullandığımız tüm araçlarla birlikte çalıştırmak için makinenizde Docker kurulu olmalıdır.
Eğer Docker yüklü değilse, bağımlılığı devre dışı bırakacak bir [**bayrak**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags) olan `-D true` seçeneğimiz var, ancak bu durumda analiz gücünün büyük bir kısmı kaybolur.
Docker ile kullanılmasını tavsiye ederiz.

Commit yazarlarını etkinleştirirseniz `-G true`, ayrıca bir `git` bağımlılığı da gereklidir.

## **Horusec Kurulumu**
### **Mac veya Linux**
```
make install
```

veya

```sh
curl -fsSL https://raw.githubusercontent.com/ZupIT/horusec/master/deployments/scripts/install.sh | bash -s latest
```

#### **Kurulumu Kontrol Et**
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

#### **Kurulumu Kontrol Et**
```bash
./horusec.exe version
```

### **Ve Daha Fazlası**

- Tüm ikili dosyaları ve sürümlerini [**sürümler sayfamızda**](https://github.com/ZupIT/horusec/releases) bulabilirsiniz.

- Kurulumun nasıl yapılacağına dair daha fazla ayrıntı için [**dokümantasyonu**](https://docs.horusec.io/docs/cli/installation) inceleyin.


## **Kullanım**
### **CLI Kullanımı**
horusec-cli’ı kullanarak uygulamanın güvenlik açıklarını kontrol etmek için aşağıdaki komutu kullanın:
```bash
horusec start -p .
```
> Horusec bir analiz başlattığında **`.horusec`** adlı bir klasör oluşturur. Bu klasör kodunuzu değiştirmemek için temeldir. **`.horusec`** satırını **`.gitignore`** dosyanıza eklemenizi öneririz, böylece bu klasör git sunucunuza gönderilmez.

### **Docker Kullanımı**
Horusec’i **`horuszup/horusec-cli:latest`** docker imajı ile kullanabilirsiniz.

Bunu yapmak için aşağıdaki komutu çalıştırın:
```sh
docker run -v /var/run/docker.sock:/var/run/docker.sock -v $(pwd):/src horuszup/horusec-cli:latest horusec start -p /src -P $(pwd)
```

- Projeyi içeren bir volume oluşturduk `-v $(pwd):/src`.

Docker imajı ile projenin bulunabileceği iki yol oluşur.

`-p` bayrağı, konteyner içindeki proje yolunu temsil eder, örneğimizde `/src`.
`-P` bayrağı, konteyner dışındaki proje yolunu temsil eder, örneğimizde `$(pwd)`,
ve volume’u bağlamak için proje yolunu da iletmeniz gerekir `-v $(pwd):/src`.

### **Eski Sürümler**

Horusec’in v1 sürümü hâlâ kullanılabilir.

**UYARI:** v1 ile olan endpoint kullanım dışı bırakılacaktır, lütfen CLI’nizi v2’ye yükseltin. Daha fazla detay için [**dokümantasyonu**](https://docs.horusec.io/docs/migrate-v1-to-v2/) inceleyin.

### **Mac veya Linux**
``` sh
curl -fsSL https://horusec.io/bin/install.sh | bash -s latest
```

### **Windows**
```sh
curl "https://horusec.io/bin/latest/win_x64/horusec.exe" -o "./horusec.exe" && ./horusec.exe version
```

- Eski ikili dosyalar bu endpoint’te bulunabilir, v1’in en son sürümü de dahil **`v1.10.3`**.
- v2 itibariyle ikili dosyalar artık bu endpoint’te dağıtılmayacak, [**sürümler sayfasında**](https://github.com/ZupIT/horusec/releases) bulabilirsiniz.

### **Horusec-Web Uygulaması Kullanımı**
Zafiyetlerinizi web arayüzümüz üzerinden yönetin. Güvenlik açıklarınıza dair metriklerin bulunduğu bir gösterge paneliniz olabilir, yanlış pozitiflerin kontrolü, yetkilendirme anahtarı, zafiyet güncellemesi ve çok daha fazlası mevcut.
Daha fazla bilgi için [**web uygulaması**](https://github.com/ZupIT/horusec-platform) bölümüne göz atın.

Aşağıdaki örnekte, bir analiz Horusec web servislerine gönderiliyor:
```bash
horusec start -p <PATH_TO_YOUR_PROJECT> -a <YOUR_AUTHORIZATION_TOKEN>
```

[**Horusec Manager Web Servisi ile yetkilendirme anahtarı oluşturma eğitimi**](https://docs.horusec.io/docs/tutorials/how-to-create-an-authorization-token) dokümanına göz atın.

**UYARI:** Web servislerimiz [**yeni bir depoya**](https://github.com/ZupIT/horusec-platform) taşındı. v2’ye yükseltmeniz gerekmektedir, [**v1’den v2’ye nasıl geçileceği**](https://docs.horusec.io/docs/migrate-v1-to-v2) dokümanını inceleyin.

### **Visual Studio Code Kullanımı**
Projenizi Horusec’in Visual Studio Code eklentisi ile analiz edebilirsiniz.
Daha fazla bilgi için [**dokümantasyona göz atın**](https://docs.horusec.io/docs/extensions/visual-studio-code/).

### **Pipeline Kullanımı**
Kurulumdan önce projenizin analizini yapabilir, organizasyonunuzda maksimum güvenliği sağlayabilirsiniz.
Daha fazla bilgi için [**dokümantasyona göz atın**](https://docs.horusec.io/docs/cli/installation/#installation-via-pipeline):

### **Özellikler**
Aşağıda görebilirsiniz: 
- 18 dili 20 farklı güvenlik aracı ile eşzamanlı analiz ederek doğruluğu artırır;
- Git geçmişinde sırlar ve diğer açık içerikleri arar;
- Analiziniz tamamen yapılandırılabilir, [**tüm CLI kaynaklarını inceleyin**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags).

## **Dokümantasyon**
Horusec’in dokümantasyonunu [**web sitemizde**](https://docs.horusec.io/docs/overview/) bulabilirsiniz.

## **Yol Haritası**
Bir proje [**yol haritamız**](ROADMAP.md) var, katkıda bulunabilirsiniz!

Horusec’in başka depoları da var, göz atın:

- [**Horusec Platform**](https://github.com/ZupIT/horusec-platform)
- [**Horusec DevKit**](https://github.com/ZupIT/horusec-devkit)
- [**Horusec Engine**](https://github.com/ZupIT/horusec-engine)
- [**Horusec Operator**](https://github.com/ZupIT/horusec-operator)
- [**Horusec VsCode**](https://github.com/ZupIT/horusec-vscode-plugin)

## **Katkıda Bulunma**

Kullanmakta, geliştirmeler önermekte veya yeni uygulamalara katkıda bulunmakta özgürsünüz.

Geliştirme sürecimiz, hata düzeltmeleri ve iyileştirmeler önermek hakkında bilgi edinmek için [**katkıda bulunma rehberimize**](https://raw.githubusercontent.com/ZupIT/horusec/main/CONTRIBUTING.md) göz atın.

### **Geliştirici Menşe Belgesi - DCO**

Bu, proje ve geliştiriciler için bir güvenlik katmanıdır. Zorunludur.

DCO'yu commit'lerinize eklemek için bu iki yöntemden birini izleyin:

**1. Komut satırı**
Adımları takip edin:
**Adım 1:** Yerel git ortamınızı, GitHub hesabınızda yapılandırdığınızla aynı isim ve e-posta adresiyle yapılandırın. Bu, inceleme ve öneriler sırasında commit'leri manuel olarak imzalamaya yardımcı olur.

```
git config --global user.name “İsim”
git config --global user.email “email@domain.com.br”
```
**Adım 2:** Git commit komutunda `'-s'` bayrağı ile Signed-off-by satırını ekleyin:

```
$ git commit -s -m "Bu benim commit mesajım"
```
**2. GitHub web sitesi**

Commit'lerinizi GitHub incelemeleri ve önerileri sırasında manuel olarak da imzalayabilirsiniz, aşağıdaki adımları izleyin:

**Adım 1:** Commit değişiklikleri kutusu açıldığında, imzanızı manuel olarak yorum kutusuna yazın veya yapıştırın, örneğe bakın:

```
Signed-off-by: İsim < e-posta adresi >
```

Bu yöntem için, adınız ve e-posta adresiniz GitHub hesabınızda kayıtlı olanla aynı olmalıdır.

## **Davranış Kuralları**
Lütfen projemizle tüm etkileşimlerinizde [**Davranış Kuralları**](https://github.com/ZupIT/horusec/blob/main/CODE_OF_CONDUCT.md)'na uyun.

## **Lisans**
 [**Apache Lisansı 2.0**](https://raw.githubusercontent.com/ZupIT/horusec/main/LICENSE).

## **Topluluk**

Bizimle iletişime geçmekten çekinmeyin:

- [**GitHub Issues**](https://github.com/ZupIT/horusec/issues)
- Sorularınız veya fikirleriniz varsa, [**Zup Açık Kaynak Forumu**](https://forum.zup.com.br)'nda sohbet edelim.


Bu proje, tüm katkıda bulunanlar sayesinde var. Harikasınız! ❤️ 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---