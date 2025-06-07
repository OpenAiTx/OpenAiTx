<div class="header" align="center">
<img alt="Frontier Station" height="300" src="https://github.com/new-frontiers-14/frontier-station-14/blob/master/Resources/Textures/_NF/Logo/logo.png?raw=true" />
</div>

Frontier Station, [Space Station 14](https://github.com/space-wizards/space-station-14) projesinin [Robust Toolbox](https://github.com/space-wizards/RobustToolbox) motoru üzerinde C# ile çalışan bir çatallamasıdır (fork).

Bu, Frontier Station için ana depodur.

Frontier Station'ı barındırmak veya içerik oluşturmak istiyorsanız, ihtiyacınız olan depo budur. Hem RobustToolbox'u hem de yeni içerik paketlerinin geliştirilmesi için içerik paketini içerir.

## Bağlantılar

<div class="header" align="center">  
[Discord](https://discord.gg/tpuAT7d3zm/) | [Steam](https://store.steampowered.com/app/1255460/Space_Station_14/) | [Patreon](https://www.patreon.com/frontierstation14) | [Wiki](https://frontierstation.wiki.gg/)
</div>

## Dokümantasyon/Wiki

[wiki](https://frontierstation.wiki.gg/)'miz Frontier Station içeriği hakkında dokümantasyon içerir.

## Katkıda Bulunma

Herkesten katkı almaktan memnuniyet duyarız. Yardım etmek istiyorsanız Discord'a gelin. Herkesin alıp yapabileceği bir [fikir listemiz](https://discord.com/channels/1123826877245694004/1127017858833068114) var. Yardım istemekten çekinmeyin!

Şu anda ana depomuzda oyunun çevirilerini kabul etmiyoruz. Oyunu başka bir dile çevirmek isterseniz, bir fork oluşturmayı veya mevcut bir fork'a katkıda bulunmayı düşünebilirsiniz.

Herhangi bir katkıda bulunursanız, lütfen [MARKERS.md](https://github.com/new-frontiers-14/frontier-station-14/blob/master/MARKERS.md) içindeki işaretleyiciler bölümünü okuyun.
Üst akışımıza (upstream) ait dosyalarda yapılan tüm değişiklikler, orada belirtilen kurallara uygun şekilde düzgünce işaretlenmelidir.

## Derleme

1. Bu repoyu klonlayın:
```shell
git clone https://github.com/new-frontiers-14/frontier-station-14.git
```
2. Proje klasörüne gidin ve alt modülleri başlatmak ve motoru yüklemek için `RUN_THIS.py` dosyasını çalıştırın:
```shell
cd frontier-station-14
python RUN_THIS.py
```
3. Çözümü derleyin:  

Sunucuyu `dotnet build` komutuyla derleyin.

[Projeyi derleme hakkında daha ayrıntılı talimatlar.](https://docs.spacestation14.com/en/general-development/setup.html)

## Lisans

Bu depoya 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 commitinden sonra eklenen içerikler, aksi belirtilmedikçe (aşağıdaki Atıflara bakınız) GNU Affero General Public License sürüm 3.0 ile lisanslanmıştır. Bkz. `LICENSE-AGPLv3.txt`.
Bu depoya 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 commitinden önce eklenen içerikler, aksi belirtilmedikçe MIT lisansı ile lisanslanmıştır. Bkz. `LICENSE-MIT.txt`.

[2fca06eaba205ae6fe3aceb8ae2a0594f0effee0](https://github.com/new-frontiers-14/frontier-station-14/commit/2fca06eaba205ae6fe3aceb8ae2a0594f0effee0) commit'i 1 Temmuz 2024, 16:04 UTC'de gönderildi.

Çoğu varlık, aksi belirtilmedikçe [CC-BY-SA 3.0](https://creativecommons.org/licenses/by-sa/3.0/) ile lisanslanmıştır. Varlıkların lisansları ve telif hakları metadata dosyasında belirtilmiştir. Örneğin, [bir levyenin metadatası](https://raw.githubusercontent.com/new-frontiers-14/frontier-station-14/master/Resources/Textures/Objects/Tools/crowbar.rsi/meta.json).  

Bazı varlıkların ticari olmayan [CC-BY-NC-SA 3.0](https://creativecommons.org/licenses/by-nc-sa/3.0/) veya benzeri ticari olmayan lisanslarla lisanslandığını ve bu projeyi ticari olarak kullanmak isterseniz kaldırılması gerektiğini unutmayın.

## Atıflar

Başka çatallardan içerik aldığımızda, atıf takibini kolaylaştırmak ve birleştirme çakışmalarını sınırlamak için içeriklerini depo-özel alt klasörlere yerleştiriyoruz.

Bu alt dizinler altındaki içerikler, ilgili çatallarından gelmektedir ve değişiklikler içerebilir. Bu değişiklikler, değiştirilen satırların etrafındaki yorumlarla belirtilmiştir.

| Alt Dizin | Çatal Adı | Çatal Deposu | Lisans |
|--------------|-----------|-----------------|---------|
| `_NF` | Frontier Station | https://github.com/new-frontiers-14/frontier-station-14 | AGPL 3.0 |
| `_CD` | Cosmatic Drift | https://github.com/cosmatic-drift-14/cosmatic-drift | MIT |
| `_Corvax` | Corvax | https://github.com/space-syndicate/space-station-14 | MIT |
| `_Corvax` | Corvax Frontier | https://github.com/Corvax-Frontier/Frontier | AGPL 3.0 |
| `_DV` | Delta-V | https://github.com/DeltaV-Station/Delta-v | AGPL 3.0 |
| `_EE` | Einstein Engines | https://github.com/Simple-Station/Einstein-Engines | AGPL 3.0 |
| `_Emberfall` | Emberfall | https://github.com/emberfall-14/emberfall | MPL 2.0 |
| `_EstacaoPirata` | Estacao Pirata | https://github.com/Day-OS/estacao-pirata-14 | AGPL 3.0 |
| `_Goobstation` | Goob Station | https://github.com/Goob-Station/Goob-Station | AGPL 3.0 |
| `_Impstation` | Impstation | https://github.com/impstation/imp-station-14 | AGPL 3.0 |
| `_NC14` | Nuclear 14 | https://github.com/Vault-Overseers/nuclear-14 | AGPL 3.0 |
| `Nyanotrasen` | Nyanotrasen | https://github.com/Nyanotrasen/Nyanotrasen | MIT |

Alt dizin olmadan özellik aldığımız ek depolar aşağıda listelenmiştir.

| Çatal Adı | Çatal Deposu | Lisans |
|-----------|-----------------|---------|
| Monolith | https://github.com/Monolith-Station/Monolith | AGPL 3.0 |
| Space Station 14 | https://github.com/space-wizards/space-station-14 | MIT |
| White Dream | https://github.com/WWhiteDreamProject/wwdpublic | AGPL 3.0 |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---