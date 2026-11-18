# Concesionario de Vehículos

## Tema y problema asignado
**Grupo 6:** Un concesionario necesita su inventario de vehículos.

Una organización registra su información en hojas de cálculo que cualquier persona puede abrir y modificar: se borran registros por error, nadie sabe quién cambió qué y los datos no coinciden entre tablas. Esta aplicación web con base de datos resuelve el problema validando los datos, relacionando cada vehículo con su marca, exigiendo inicio de sesión para modificar y separando los permisos por rol.

## Integrantes y aportes
Este trabajo fue realizado de forma individual.

| Integrante | Turno | Fases realizadas |
|---|---|---|
| Pablo Guber Camacho Bravo | Único | Fases 1 a 5 y componente autónomo |

**Aporte por fase:**
- Fase 1: Proyecto MVC con .NET 10, entidad `Vehiculo`, CRUD y migración `InitialCreate`.
- Fase 2: Validaciones con DataAnnotations y migración `ValidacionesVehiculo`.
- Fase 3: Entidad `Marca`, relación uno a muchos y migración `RelacionMarcaVehiculo`.
- Fase 4: Identity y migración `AgregarIdentity`.
- Fase 5: Roles `Vendedor` y `Comprador`, y usuarios de prueba.
- Componente autónomo: restricción por rol en ambos controladores y en las vistas.

## Entidades
- **Marca:** Id, Nombre, PaisOrigen (opcional)
- **Vehiculo:** Id, Modelo, Anio, Precio, MarcaId

Relación: una `Marca` tiene muchos `Vehiculo`.

## Roles
- **Vendedor** (gestión): crea, edita y elimina marcas y vehículos.
- **Comprador** (consulta): solo ve la lista y el detalle.

## Usuarios de prueba
| Correo | Contraseña | Rol |
|---|---|---|
| vendedor@concesionario.com | Vendedor123* | Vendedor |
| comprador@concesionario.com | Comprador123* | Comprador |

Los roles y usuarios se crean automáticamente al iniciar la aplicación.

## Cómo ejecutar el proyecto
1. Clonar el repositorio: `git clone [URL del repositorio]`
2. Abrir la solución en Visual Studio con .NET 10 instalado.
3. Ajustar la cadena de conexión en `appsettings.json` si tu servidor es distinto:
   `Server=localhost\\SQLEXPRESS;Database=ConcesionarioDb;Trusted_Connection=True;TrustServerCertificate=True;`
4. En la Consola del Administrador de paquetes, ejecutar `Update-Database`.
5. Ejecutar la aplicación (F5).