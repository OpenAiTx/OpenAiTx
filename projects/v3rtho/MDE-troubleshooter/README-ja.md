# MDE-troubleshooter
# 情報

このツールは、ローカルエンドポイント上のDefender for Endpointに関連する問題の分析を支援するために設計されています。セキュリティ構成、ログファイル、更新の集中ビューを提供し、パフォーマンスアナライザーへのアクセスも可能です。

これはツールの初期バージョンであることにご注意ください。バグを見つけた場合や改善の提案がある場合は、ぜひ私のGitHubページに投稿してください。皆様のフィードバックと報告を心より感謝いたします。

<img width="1482" height="1041" alt="2026-03-09 10_40_30-MDE Troubleshooter v3 0" src="https://github.com/user-attachments/assets/34d80bab-525d-4bf2-ae10-ae8b0c62358d" />



# 前提条件

スクリプトはすべての設定を表示するために管理者として実行する必要があります。

# 免責事項

スクリプトは現状のまま提供されます。使用は自己責任で行ってください。保証や保証は提供されません。

# 連絡先
linkedin: https://www.linkedin.com/in/thomasvrhydn/
twitter:  @thomasvrhydn

# 機能  

Defender AV  
バージョン情報 — AMエンジン、AMプロダクト、AMサービス、NISエンジンのバージョン、AM実行モード、コンピュータ状態  
サービス状態 — AMサービス、アンチウイルス、アンチスパイウェア、NIS有効状態、仮想マシン検出、コンピュータID  
リアルタイム保護 — リアルタイム保護、オンアクセス保護、動作モニター、IOAV保護、改ざん防止の状態とソース  
スキャン情報 — フルおよびクイックスキャンの経過時間、開始/終了時刻  
保護設定 — クラウドブロックレベル、初回検出時ブロック、クラウドタイムアウト、隔離削除日数、ファイルハッシュ計算、デバイスコントロール状態  
追加情報 — シグネチャフォールバック順序、NISシグネチャ最終更新日、最後のクイックスキャンのソース   

攻撃面削減  
ASRルール状態 — 19のASRルールすべてと現在の状態（有効 / 監査 / 警告 / 無効）を表示し、状態でフィルター可能な並べ替え可能なDataGridポップアップで表示  
ASRルール別除外 — レジストリ（HKLM:\...\Windows Defender Exploit Guard\ASR）から読み取ったルール別およびグローバルASR除外を表示し、ルール名でフィルター可能  
エクスプロイト保護 — エクスプロイト保護のXML構成をエクスポートおよび開く  

除外設定  
Defender AV除外 — 設定されたすべての除外（パス、拡張子、プロセス、IPアドレス）を検索およびタイプでフィルター可能なポップアップDataGridで表示  
レジストリキー情報 — ManagedDefenderProductType、EnrollmentStatus、HideExclusionsFromLocalAdmins、DisableLocalAdminMergeを表示し、改ざん防止の検証を行って管理状態を判定（Intune専用、ConfigMgr、共同管理シナリオ）  

更新  
現在のシグネチャ情報 — AVシグネチャのバージョン/経過日数/最終更新日、アンチスパイウェアシグネチャのバージョン/経過日数、NISシグネチャのバージョン  
最新のMicrosoftバージョン — Microsoftのウェブサイトから最新のエンジン、プラットフォーム、シグネチャバージョンを取得して比較  
更新操作 — UIから直接MpCmdRun.exeを使用してシグネチャの更新をトリガー  

ログ  
SENSEログ — テキストおよびレベル（情報/警告/エラー）によるフィルタリング付きでEDRセンサーイベントログ（Microsoft-Windows-SENSE/Operational）を表示、選択エントリの詳細ペイン付き  
Defender AVログ — 同様のフィルタリングと詳細機能を備えたアンチウイルスイベントログ（Microsoft-Windows-Windows Defender/Operational）を表示  

パフォーマンス  
パフォーマンス記録 — Defender AVのパフォーマンス記録セッション（New-MpPerformanceRecording）を開始し、スキャン活動をETLファイルにキャプチャ  
パフォーマンスレポート — ETL記録からレポートを生成、選択可能なレポートタイプ：概要、トップ10ファイル、トップ10拡張子、トップ10プロセス、トップ10スキャン（複数レポートを別ウィンドウで同時に開くことが可能）  
推定影響（MPlog） — 最新のMPlogファイルを解析しEstimatedImpactエントリを影響値順にソート、高影響のスキャン対象を特定  
クライアントアナライザーのダウンロード — 公式Microsoft Defender Client Analyzerツール（MDEClientAnalyzer.zip）を任意のフォルダーにダウンロード  

プロキシ  
プロキシ設定 — Defenderに構成されている現在のプロキシURLおよびプロキシPACを表示  

ファイアウォール  
プロファイル状態 — ドメイン、プライベート、パブリックのファイアウォールプロファイル設定（有効/無効、デフォルトの受信/送信アクション、許可ログ）を表示  
ファイアウォールルールブラウザー — 検索、方向、アクション、有効状態、プロファイルフィルター付きのフィルタ可能なDataGridでWindowsファイアウォールのすべてのルールを表示。ルール名、ポート、プロトコル、プログラムパスを表示  


# 参考文献

https://github.com/ugurkocde/Intune/blob/main/Defender%20for%20Endpoint/MDE%20-%20Update%20Tool/MDE_Update_Tool.ps1

https://github.com/directorcia/Office365/blob/master/win10-asr-get.ps1

https://docs.microsoft.com/en-us/windows/security/threat-protection/microsoft-defender-atp/overview-attack-surface-reduction

https://docs.microsoft.com/en-us/windows/security/threat-protection/microsoft-defender-atp/attack-surface-reduction

https://docs.microsoft.com/en-us/windows/security/threat-protection/microsoft-defender-atp/attack-surface-reduction-faq





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-11

---