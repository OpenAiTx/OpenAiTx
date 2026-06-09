# ESPHome用ホーネットネストアラームパネル

このリポジトリは、**Technology Automation Consulting LLC**によって開発された**ホーネットネストアラームパネル**の公式サポートされた**ESPHome**ファームウェア設定ファイルを収めています。ホーネットネストアラームパネルは、従来の有線警報システムを**Home Assistant**を用いてスマートホームに統合するために設計された、拡張性とカスタマイズ性に優れたIoTソリューションです。42のオプトアイソレートゾーン、3つのリレー出力、柔軟なPoEまたは12V電源オプションを備え、柔軟性と信頼性を追求しています。

<div style="display: flex; justify-content: space-between;">
  <img src="https://raw.githubusercontent.com/taconsultingllc/hornet-nest-alarm-panel/main/images/3D_AlarmPanel_2024-10-06.png" alt="3D Model" width="400"/>
  <img src="https://raw.githubusercontent.com/taconsultingllc/hornet-nest-alarm-panel/main/images/hornet-nest-operational.jpg" alt="Installed" width="400"/>
</div>

## クイックスタート

最新のESPHomeファームウェアでホーネットネストアラームパネルを採用し、フラッシュしてすぐに始めましょう：

1. PoE給電のイーサネットケーブルをホーネットネストアラームパネルに接続します。
2. **ESPHomeダッシュボード**を開き、デバイス「hornet-nest-XXXXXX」（XXXXXXは一意の16進識別子）を探します。
3. デバイスの**Adopt**オプションをクリックします。
4. **Adopt Device**ダイアログが開きます。必要に応じてデバイス名を変更し、再度**Adopt**をクリックします。
5. **Configuration Created**ダイアログが開き、新しい設定をデバイスにインストールする必要があることを示します。**Install**ボタンをクリックします。
6. ESPHomeが新しいファームウェアのコンパイルを開始します。**"INFO Sucessfully uploaded program."**という行が表示されたら、**STOP**をクリックしてウィンドウを閉じます。
4. **Home Assistant** > **Settings** > **Devices & Services**でホーネットネストアラームパネルを検出します。
5. 新しいデバイスの**Configure**をクリックしてHome Assistantに追加します。

## 変更履歴とリリースノート

リリースノートとダウンロード可能な事前ビルドファームウェアイメージについては**Releases**をご覧ください。

## ESPHome専用設計

**ホーネットネストアラームパネル**は、**wESP32 PoE**マイクロコントローラーを使用し、**ESPHome**ファームウェアと完全に互換性があります。オープンソース製品であり、ユーザーが簡単にカスタマイズできるよう設計されているため、拡張性と柔軟性を必要とするHome Assistantユーザーに最適です。付属の**ESPHome YAML設定ファイル**は完全にドキュメント化されており、上級ユーザーが簡単な修正でデバイスをカスタマイズ、構築、更新できます。

## Home Assistant対応

これらの**ESPHome**ファームウェア設定により、**Home Assistant**内で簡単なプラグアンドプレイ設定が可能です。統合はローカルで高速かつ完全にカスタマイズ可能であり、ユーザーに自宅のセキュリティシステムを完全に制御する自由を提供します。
<img src="https://raw.githubusercontent.com/taconsultingllc/hornet-nest-alarm-panel/main/images/esphome-integrated.png" alt="ESPHome Device" width="600">

## このリポジトリについて

このリポジトリには、**ホーネットネストアラームパネル**用の**完全なファームウェア設定YAMLテンプレート**がトップレベルに含まれています。これらのテンプレートは**ESPHomeダッシュボード**でインポートし、カスタマイズおよびデプロイが可能です。

## ユーザーマニュアル
詳細な手順については、公式ユーザーマニュアル[こちら](https://raw.githubusercontent.com/taconsultingllc/hornet-nest-alarm-panel/main/hnap-user-manual.pdf)をご参照ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-09

---