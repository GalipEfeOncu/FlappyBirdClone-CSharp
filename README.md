# Flappy Bird - WinForms

**Bu proje bir okul ödevidir.** Amaç, C# ve WinForms kullanarak basit bir oyun geliştirmeyi öğrenmektir.

## Proje Hakkında

Bu proje, klasik Flappy Bird oyununu temel alan bir WinForms uygulamasıdır. Oyuncu bir kuşu yukarı-aşağı hareket ettirerek borular arasından geçirmeye çalışır. Puanlama ve basit zorluk artışı içerir.

### Özellikler

- **Space** tuşu ile kuşu zıplatma  
- Boruların rastgele yükseklik ve aralıklarla oluşturulması  
- **Puanlama sistemi:** her boru geçişi +1 puan  
- **Zorluk artışı:** Puan arttıkça boruların kayma hızı artar  
- Game Over durumunda yeniden başlatma (**R** tuşu)  
- Başlangıç ve ölüm ekranı için **label** gösterimi  

### Kullanım

1. Projeyi Visual Studio’da açın.  
2. **Build → Build Solution** ile derleyin.  
3. `bin\Release` klasöründen `FlappyBird.exe`’yi çalıştırın.  

Oyunu başlatmak için **Space** tuşuna basın.  
Kuş yere veya boruya çarptığında oyun durur ve **R** tuşu ile yeniden başlatabilirsiniz.

### Gereksinimler

- .NET Framework (WinForms destekli)  
- Visual Studio 2022 veya üstü (kaynak kodu ile çalıştırmak için)  
