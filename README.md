# Hotelier - Otel Rezervasyon Sistemi

Hotelier, modern bir otel rezervasyon sistemi olarak tasarlanmış ve geliştirilmiş bir projedir. Bu proje, otel yöneticilerinin rezervasyonları kolayca yönetebileceği, kullanıcıların otel rezervasyonlarını yapabileceği ve yönetebileceği bir sistem sunmaktadır. Proje, **ASP.Net Core API**, **MSSQL**, **JWT Token** ile güvenlik ve **Rapid API** ile dış API entegrasyonlarını içermektedir.

## Özellikler

- **Admin Paneli**: Yöneticiler için otel rezervasyonlarını ve kullanıcı bilgilerini yönetebilecekleri bir admin paneli.
- **Dashboard**: Rezervasyon ve kullanıcı verileri gibi önemli bilgilerin görselleştirildiği bir dashboard ekranı.
- **JWT Token ile Güvenlik**: Kullanıcı ve admin erişimleri güvenli bir şekilde yönetilmekte.
- **API Consume İşlemleri**: Farklı servislerle API üzerinden veri alışverişi yapılabilmektedir.
- **Rapid API Entegrasyonu**: Harici API servisleriyle otel bilgileri veya rezervasyon verileri güncellenebilir.
- **MSSQL Veri Tabanı**: Rezervasyonlar, kullanıcılar ve otel verilerinin saklandığı veri tabanı.

## Teknolojiler

- **ASP.Net Core API**: Projenin temel API yapısını oluşturur.
- **MSSQL**: Veri tabanı yönetim sistemi olarak kullanılmıştır.
- **Swagger**: API dökümantasyonunu ve test işlemlerini kolaylaştırmak için kullanılmıştır.
- **JWT Token**: Kullanıcı doğrulama ve yetkilendirme işlemleri için kullanılmıştır.
- **Rapid API**: Dış API entegrasyonları için kullanılmaktadır.

## Kurulum

1. **Klonlama**: Projeyi yerel makinenize klonlayın.
    ```bash
    git clone https://github.com/kullanici/hotelier.git
    ```

2. **Bağımlılıkları Yükleme**: Projeyi açtıktan sonra tüm bağımlılıkları yükleyin.
    ```bash
    dotnet restore
    ```

3. **Veri Tabanı Bağlantısı**: `appsettings.json` dosyasında MSSQL veri tabanınızın bağlantı dizesini yapılandırın.
    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=your_server_name;Database=hotelier_db;User Id=your_user;Password=your_password;"
    }
    ```

4. **Veri Tabanı Migrasyonları**: Veri tabanını oluşturmak ve güncellemek için aşağıdaki komutu çalıştırın.
    ```bash
    dotnet ef database update
    ```

5. **Çalıştırma**: Projeyi aşağıdaki komut ile başlatın.
    ```bash
    dotnet run
    ```

## Kullanım

- **Swagger** üzerinden API'yi test etmek için tarayıcınızda aşağıdaki URL'yi açın:
    ```
    https://localhost:5001/swagger
    ```

- JWT Token almak için `/api/auth/login` üzerinden giriş işlemini yapın ve dönen token'ı kullanarak diğer API işlemlerini gerçekleştirin.

## Güvenlik

Projede güvenlik için **JWT Token** kullanılmıştır. Her kullanıcının giriş yaptıktan sonra alacağı token, API taleplerine eklenerek yetkilendirme yapılmaktadır.

## API Dokümantasyonu

API uç noktalarını ve parametrelerini görmek için **Swagger** kullanılabilir. Proje çalıştırıldığında `https://localhost:5001/swagger` adresine gidilerek API uç noktaları test edilebilir.

## Katkıda Bulunma

1. Projeyi forklayın.
2. Yeni bir özellik veya düzeltme için bir dal oluşturun.
3. Değişikliklerinizi yapın.
4. Bir pull request gönderin.


---

# Hotelier - Hotel Reservation System

Hotelier is a modern hotel reservation system designed and developed to simplify hotel management and reservations. This project includes an **ASP.Net Core API**, **MSSQL** database, **JWT Token** based security, and external API integration through **Rapid API**.

## Features

- **Admin Panel**: Allows hotel administrators to manage reservations and user information.
- **Dashboard**: Visualizes important data such as reservations and user statistics.
- **JWT Token Security**: Secure user and admin access with JSON Web Tokens.
- **API Consumption**: Interacts with external services to exchange data via APIs.
- **Rapid API Integration**: Updates hotel or reservation data through external APIs.
- **MSSQL Database**: Stores reservation, user, and hotel information.

## Technologies

- **ASP.Net Core API**: Backend architecture of the project.
- **MSSQL**: Database management system used for data storage.
- **Swagger**: Facilitates API documentation and testing.
- **JWT Token**: Used for authentication and authorization.
- **Rapid API**: For external API integrations.

## Setup

1. **Clone the Repository**: Clone the project to your local machine.
    ```bash
    git clone https://github.com/username/hotelier.git
    ```

2. **Install Dependencies**: After opening the project, install all required dependencies.
    ```bash
    dotnet restore
    ```

3. **Configure Database Connection**: In the `appsettings.json`, set up your MSSQL database connection string.
    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=your_server_name;Database=hotelier_db;User Id=your_user;Password=your_password;"
    }
    ```

4. **Run Database Migrations**: Apply database migrations to set up your database schema.
    ```bash
    dotnet ef database update
    ```

5. **Run the Project**: Start the project with the following command.
    ```bash
    dotnet run
    ```

## Usage

- To test the API using **Swagger**, navigate to the following URL in your browser:
    ```
    https://localhost:5001/swagger
    ```

- To get a JWT Token, use the `/api/auth/login` endpoint and use the returned token for making authorized API requests.

## Security

Security is implemented using **JWT Token**. After logging in, each user receives a token that must be included in subsequent API requests to authorize access.

## API Documentation

Use **Swagger** for API documentation. Once the project is running, visit `https://localhost:5001/swagger` to see all available API endpoints and their details.

## Contributing

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes.
4. Submit a pull request.

