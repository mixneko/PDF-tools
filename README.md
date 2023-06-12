[![.NET](https://github.com/mixneko/PDF-tools/actions/workflows/dotnet.yml/badge.svg)](https://github.com/mixneko/PDF-tools/actions/workflows/dotnet.yml)
# PDF tools
這是一個整合了 GhostScript 和 ImageMagick，專為處理 PDF 檔案所製作的實用工具。

PDF Tools 可以幫助你輕鬆地轉換、合併、分割 PDF 文件，以及將圖片轉換回 PDF。不管你是需要處理大量的 PDF 文件，還是只是偶爾需要轉換幾個文件，PDF Tools 都能讓你的工作變得更輕鬆。

## 目錄
- [硬體需求](#硬體需求)
- [安裝依賴](#安裝依賴)
- [使用](#使用)
    - [設定環境變數](#設定環境變數)
    - [將 PDF 轉換成圖片](#將-PDF-轉換成圖片)
    - [合併 PDF](#合併-PDF)
    - [分割 PDF](#分割-PDF)
    - [將圖片轉回 PDF](#將圖片轉回-PDF)
- [截圖](#截圖)
- [捐獻](#捐獻)
- [授權](#授權)

## 硬體需求
本工具需要 64 位元的 Windows 系統。建議有至少 4 GB 的 RAM 以確保順暢運作。

## 安裝依賴
使用此程式前您必須先安裝 [GhostScript](https://github.com/ArtifexSoftware/ghostpdl-downloads/releases) 以及包含 convert 之 [ImageMagick](https://imagemagick.org/script/download.php#windows) 套件
然後記住你安裝的位置，在檔案執行時需指定至該位置

## 使用
第一次使用通常會需要先指定環境變數以進行後續的步驟
此程式中包括
1. 將 PDF 轉換成圖片：你可以將 PDF 轉換成圖片(jpg、png)，其中 png 也可指定底色為透明或白色
2. 合併 PDF：直覺化的介面讓您依序合併您想要合併的PDF
3. 分割 PDF：指定您想要分割的PDF，然後輸入開始頁面及結束葉面後即可分割
4. 將圖片轉回 PDF：你可以將圖片(jpg、png)轉換回個別的PDF，你也可以指定至某個資料夾，輸入後直接將該資料夾的內容選入合併 PDF 功能中

## 截圖
![環境變數](https://github.com/mixneko/PDF-tools/assets/12106753/c62f4f6e-5ebf-4b0a-945f-6c5c55914198)
![PDF 轉圖片](https://github.com/mixneko/PDF-tools/assets/12106753/007949b1-b903-40c5-bc3a-ef030d1da184)
![PDF 合併](https://github.com/mixneko/PDF-tools/assets/12106753/116a24d6-4988-464d-9b31-b96718ade71b)
![PDF 分割](https://github.com/mixneko/PDF-tools/assets/12106753/f4ad58f3-9ef7-49a8-a1b5-9e91ecf65746)
![圖片轉 PDF](https://github.com/mixneko/PDF-tools/assets/12106753/871085a8-a86e-4b8f-89b5-1e0624497e3d)

## 捐獻
如果你發現這個專案有幫助，歡迎你透過以下方式贊助，你的支持會讓這個專案能持續維護和改善。

- BTC-BSC：0x974F80a64289b13C4735b9c4c441abDdd03b445e
- ETH-BSC：0x974F80a64289b13C4735b9c4c441abDdd03b445e
- USDT-TRC20：TD4wFGZMVwQDZA3VUj6X3XBgDJjBEPSQyi

## 授權
本程式依據 GNU 的精神進行開源，使用的條款為 AGPL。請見 [LICENSE](./LICENSE.txt) 文件以獲得更多資訊。
