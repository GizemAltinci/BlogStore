**📝 BlogStore -- MVC Blog Yönetim Sistemi**

**Bu proje, ASP.NET Core MVC, Entity Framework Core, Identity ve N-tier
Architecture kullanılarak geliştirilmiş çok katmanlı bir blog yönetim
uygulamasıdır.\
Yazarlar (Authors) kendi panelleri üzerinden makale oluşturabilir,
profillerini görüntüleyebilir; yöneticiler ise kategorileri
yönetebilir.**

**🚀 Özellikler**

**✔ Kullanıcı Yönetimi (Identity)**

-   **Kullanıcı kayıt / login işlemleri**

-   **Aktif yazarın profil bilgilerini gösterme**

-   **User profile verilerinin UserManager üzerinden çekilmesi**

**✔ Makale (Article) Yönetimi**

-   **Makale listeleme**

-   **Yeni makale oluşturma**

-   **Kategori seçimi**

-   **Makale detay sayfası**

-   **Makale -- kategori eşleştirmesi**

**✔ Kategori Yönetimi**

-   **Kategori ekleme / listeleme**

-   **Dropdown için dinamik kategori doldurma**

**✔ Çok Katmanlı Mimari (N-Layer Architecture)**

-   **Entity Layer**

-   **Data Access Layer**

-   **Business Layer**

-   **Presentation Layer (UI/MVC)**

**✔ Rol Bazlı Yapı**

-   **Author (Yazar) arayüzü**

-   **Admin paneli altyapısı (kategori yönetimi vs.)**

**🧱 Proje Mimarisi**

**Proje, SOLID prensiplerine uygun olarak katmanlı mimari ile
geliştirilmiştir:**

-   **Presentation Layer: Kullanıcı arayüzü (UI) katmanıdır. MVC
    mimarisiyle sayfaların görüntülenmesini sağlar.**

-   **Entity Layer: Veritabanı tablolarını temsil eden sınıfları
    içerir.**

-   **Data Access Layer: Entity Framework Core kullanarak veri
    işlemlerini gerçekleştiren katmandır. Repository desenine uygun
    şekilde yapılandırılmıştır.**

-   **Business Layer: Uygulamanın iş mantığını barındırır. Validasyon ve
    iş kuralları burada tanımlanır.**

**🔧 Kullanılan Teknolojiler**


| -   **ASP.NET Core MVC** 
| -   **Entity Framework Core** 
| -   **MSSQL**  
| -   **Identity**
| -   **N-Layer Architecture**
| -   **Bootstrap** 
| -   **LINQ**

**🗂 Projenin Amacı**

**Bu proje, gerçek bir blog yönetim sisteminin:**

-   **kullanıcı kimlik doğrulamanın nasıl yapıldığını,**

-   **çok katmanlı mimarinin nasıl uygulanacağını,**

-   **yazar panelinin nasıl oluşturulacağını,**

-   **makale süreçlerinin nasıl yönetileceğini\
    öğretmek için geliştirilmiştir.**
