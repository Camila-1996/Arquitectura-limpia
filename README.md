# 📌 Sistema de Facturación - ASP.NET Core Clean Architecture

Este proyecto es un sistema de facturación.
## 🚀 Características
- Arquitectura **Clean Architecture**
- Uso de **Entity Framework ** para acceso a datos
- **Inyección de dependencias** para servicios y repositorios
- **API RESTful** con ASP.NET Core
- **Persistencia en SQL Server**
- -Arquitectura limpia
- CQRS con la biblioteca MediatR
- Entity Framework 
- Patrón de repositorio - Genérico
- Serilog
- Interfaz de usuario de Swagger
- Comprobaciones de estado
- Paginación
- Identidad de Microsoft con autenticación JWT
- Middlewares de control de excepciones personalizadas
- Control de versiones de API
- Localización ( fa - en )
- Auditoría de usuarios
- TestProjects ( FunctionalTests - UnitTests - IntegrationTests )

## 📂 Estructura del Proyecto
```
📦 
├── 📁 Application         # Capa de Aplicación (Casos de uso, DTOs, Interfaces)
├── 📁 Domain              # Capa de Dominio (Entidades y lógica empresarial)
├── 📁 Infrastructure      # Capa de Infraestructura (Persistencia y Repositorios)
├── 📁 Presentation        # Capa de Presentación (API Controllers)
└── 📄 README.md          # Documentación del proyecto
```

## 🔧 Configuración
1. **Clona el repositorio:**
   

2. **Configura la conexión a la base de datos** en `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=TU_SERVIDOR;Database=LabDev;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False"
   }
   ```

3. **Aplica las migraciones de la base de datos:**
   ```sh
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

4. **Ejecuta el proyecto:**
   ```sh
   dotnet run --project Presentation
   ```

## 📌 Endpoints Principales

### 📦 Facturas
- `GET /api/factura/{id}` → Obtiene una factura por ID


