# BlazorSample

1. Blazorの仕組み
2. 開発環境
3. 最初のBlazorアプリ
4. コンポーネント
5. データバインディング
6. イベント処理
7. Razor記法
8. フォームと検証
9. データベースアクセス
10. WebAPIの活用
11. SVGの活用
12. JavaScriptとの連携


## 2. 開発環境
Webサーバー(HTTPサーバー)とブラウザが必要
Webサーバー Blazor WebAssembly Appであればサーバーの種類や動作環境はなんでもOK

Blazorサーバーアプリ サーバーであるASP.NET Coreと連携して動作するBlazorアプリ
Blazor WebAssembly App クライアントのみで動作するBlazorアプリ

### Blazorプロジェクトの作成

```bash
# Blazor WebAssemblyの作成
$ dotnet --name [プロジェクト名] new blazorwasm

# Blazor Server Appの作成
$ dotnet --name [プロジェクト名] new blazorserver
```

# 6までやる