# Visual Studio Code - Açık Kaynak ("Code - OSS")

[![Özellik İstekleri](https://img.shields.io/github/issues/microsoft/vscode/feature-request.svg)](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
[![Hatalar](https://img.shields.io/github/issues/microsoft/vscode/bug.svg)](https://github.com/microsoft/vscode/issues?utf8=✓&q=is%3Aissue+is%3Aopen+label%3Abug)
[![Gitter](https://img.shields.io/badge/chat-on%20gitter-yellow.svg)](https://gitter.im/Microsoft/vscode)

## Depo

Bu depo ("`Code - OSS`"), [Visual Studio Code](https://code.visualstudio.com) ürününü topluluk ile birlikte geliştirdiğimiz yerdir (Microsoft olarak). Burada sadece kod ve sorunlar üzerinde çalışmakla kalmayıp, aynı zamanda [yol haritamızı](https://github.com/microsoft/vscode/wiki/Roadmap), [aylık iterasyon planlarımızı](https://github.com/microsoft/vscode/wiki/Iteration-Plans) ve [endgame planlarımızı](https://github.com/microsoft/vscode/wiki/Running-the-Endgame) da yayımlıyoruz. Bu kaynak kodu, standart [MIT lisansı](https://github.com/microsoft/vscode/blob/main/LICENSE.txt) kapsamında herkesin kullanımına açıktır.

## Visual Studio Code

<p align="center">
  <img alt="VS Code in action" src="https://user-images.githubusercontent.com/35271042/118224532-3842c400-b438-11eb-923d-a5f66fa6785a.png">
</p>

[Visual Studio Code](https://code.visualstudio.com), Microsoft'a özgü özelleştirmelerle birlikte gelen, geleneksel bir [Microsoft ürün lisansı](https://code.visualstudio.com/License/) altında yayımlanan `Code - OSS` deposunun bir dağıtımıdır.

[Visual Studio Code](https://code.visualstudio.com), bir kod editörünün sadeliğini, geliştiricilerin temel düzenleme-derleme-hata ayıklama döngüsü için ihtiyaç duyduğu her şeyle birleştirir. Kapsamlı kod düzenleme, gezinme ve anlama desteğiyle birlikte hafif hata ayıklama, zengin bir genişletilebilirlik modeli ve mevcut araçlarla hafif entegrasyon sunar.

Visual Studio Code, her ay yeni özellikler ve hata düzeltmeleriyle güncellenir. [Visual Studio Code'un web sitesinden](https://code.visualstudio.com/Download) Windows, macOS ve Linux için indirebilirsiniz. En son sürümleri her gün almak için [Insiders sürümünü](https://code.visualstudio.com/insiders) yükleyin.

## Katkıda Bulunma

Bu projeye katılabileceğiniz birçok yol vardır, örneğin:

* [Hata ve özellik istekleri gönderin](https://github.com/microsoft/vscode/issues) ve eklenenleri doğrulamamıza yardımcı olun
* [Kaynak kod değişikliklerini inceleyin](https://github.com/microsoft/vscode/pulls)
* [Dokümantasyonu](https://github.com/microsoft/vscode-docs) gözden geçirin ve yazım hatalarından yeni içerik eklemeye kadar her konuda pull request gönderin

Sorunları düzeltmek ve doğrudan kod tabanına katkı sağlamak istiyorsanız,
lütfen aşağıdaki konuları içeren [Nasıl Katkıda Bulunulur](https://github.com/microsoft/vscode/wiki/How-to-Contribute) belgesine göz atın:

* [Kaynak koddan nasıl derlenir ve çalıştırılır](https://github.com/microsoft/vscode/wiki/How-to-Contribute)
* [Geliştirme iş akışı, hata ayıklama ve test çalıştırma dahil](https://github.com/microsoft/vscode/wiki/How-to-Contribute#debugging)
* [Kodlama yönergeleri](https://github.com/microsoft/vscode/wiki/Coding-Guidelines)
* [Pull request gönderme](https://github.com/microsoft/vscode/wiki/How-to-Contribute#pull-requests)
* [Üzerinde çalışılacak bir sorun bulma](https://github.com/microsoft/vscode/wiki/How-to-Contribute#where-to-contribute)
* [Çevirilere katkıda bulunma](https://aka.ms/vscodeloc)

## Geri Bildirim

* [Stack Overflow](https://stackoverflow.com/questions/tagged/vscode)'da bir soru sorun
* [Yeni bir özellik isteği gönderin](CONTRIBUTING.md)
* [Popüler özellik isteklerine oy verin](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
* [Bir sorun bildirin](https://github.com/microsoft/vscode/issues)
* [GitHub Discussions](https://github.com/microsoft/vscode-discussions/discussions) veya [Slack](https://aka.ms/vscode-dev-community) üzerinden eklenti geliştirici topluluğu ile bağlantı kurun
* [@code](https://twitter.com/code) hesabını takip edin ve görüşlerinizi bizimle paylaşın!

Bu kanalların her birinin açıklaması ve diğer topluluk odaklı kanallar hakkında bilgi için [wiki'mize](https://github.com/microsoft/vscode/wiki/Feedback-Channels) göz atın.

## İlgili Projeler

VS Code'un temel bileşenlerinin ve uzantılarının birçoğu GitHub'da kendi depolarında bulunmaktadır. Örneğin, [node debug adapter](https://github.com/microsoft/vscode-node-debug) ve [mono debug adapter](https://github.com/microsoft/vscode-mono-debug) depoları birbirinden ayrıdır. Tüm listenin tamamı için [wiki](https://github.com/microsoft/vscode/wiki) üzerindeki [İlgili Projeler](https://github.com/microsoft/vscode/wiki/Related-Projects) sayfasını ziyaret edin.

## Dahili Uzantılar

VS Code, birçok dil için dilbilgisi ve snippet içeren [extensions](extensions) klasöründe bulunan bir dizi yerleşik uzantı ile birlikte gelir. Bir dil için zengin dil desteği (kod tamamlama, Tanıma Git) sağlayan uzantılar `language-features` ekiyle adlandırılır. Örneğin, `json` uzantısı `JSON` için renklendirme sağlarken, `json-language-features` uzantısı `JSON` için zengin dil desteği sunar.

## Geliştirme Konteyneri

Bu depo, Visual Studio Code Dev Containers / GitHub Codespaces geliştirme konteynerini içerir.

* [Dev Containers](https://aka.ms/vscode-remote/download/containers) için, **Dev Containers: Clone Repository in Container Volume...** komutunu kullanarak macOS ve Windows'ta daha iyi disk G/Ç için bir Docker volume oluşturabilirsiniz.
  * Zaten VS Code ve Docker kuruluysa, başlamak için [buraya tıklayabilirsiniz](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/microsoft/vscode). Bu, gerekirse Dev Containers uzantısının otomatik olarak yüklenmesini, kaynak kodun bir konteyner volume'una klonlanmasını ve kullanıma hazır bir geliştirme konteynerinin başlatılmasını sağlar.

* Codespaces için, VS Code'da [GitHub Codespaces](https://marketplace.visualstudio.com/items?itemName=GitHub.codespaces) uzantısını kurun ve **Codespaces: Create New Codespace** komutunu kullanın.

Docker / Codespace'in tam derleme için en az **4 Çekirdek ve 6 GB RAM (8 GB önerilir)** olması gerekmektedir. Daha fazla bilgi için [geliştirme konteyneri README](.devcontainer/README.md) dosyasına bakınız.

## Davranış Kuralları

Bu proje, [Microsoft Açık Kaynak Davranış Kuralları'nı](https://opensource.microsoft.com/codeofconduct/) benimsemiştir. Daha fazla bilgi için [Davranış Kuralları SSS](https://opensource.microsoft.com/codeofconduct/faq/) sayfasına bakabilir veya ek sorularınız ya da yorumlarınız için [opencode@microsoft.com](mailto:opencode@microsoft.com) adresiyle iletişime geçebilirsiniz.

## Lisans

Telif Hakkı (c) Microsoft Corporation. Tüm hakları saklıdır.

[MIT](LICENSE.txt) lisansı kapsamında lisanslanmıştır.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---