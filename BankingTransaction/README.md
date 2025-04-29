# Aplicación de Procesamiento de Transacciones Bancarias

## Introducción

Este proyecto es una aplicación de consola desarrollada con C# que permite procesar transacciones bancarias a partir de un archivo CSV. La aplicación ofrece un menú interactivo para visualizar el balance final, identificar la transacción de mayor valor, contar las transacciones por tipo y generar un reporte general.

El objetivo es crear una aplicación CLI sencilla, en la que hacemos uso de la Programación Orientada a Objetos, a través del uso de clases, métodos, principio DRY y también operaciones con LINQ en .NET, siguiendo buenas prácticas de diseño y organización.


## Instrucciones de Ejecución
1. Clonar el repositorio.
2. Abrir la solución `interbank-academy-25.sln` en Visual Studio o ejecutar desde terminal.
3. Asegurarse de tener instalado el SDK de .NET (versión 8 o superior); que se puede descargar de [.NET](https://dotnet.microsoft.com/en-us/download)
4. Restaurar dependencias con el comando:
   ```bash
   dotnet restore
5. Ejecutar el proyecto desde la terminal con:
   ```bash
   dotnet run --project BankingTransaction

## Enfoque y Solución
### Lógica Implementada:
1. Lectura del archivo CSV: Se utiliza la biblioteca CsvHelper para deserializar automáticamente los registros en una lista de objetos Transaction.

2. Cálculo del balance final: Se suman por separado los montos de tipo Crédito y los de tipo Débito, luego se resta Total Tipo Crédito - Total Tipo Débito.

3. Detección de transacción de mayor valor: Se ordenan los registros por monto descendente y se toma el primero.

4. Conteo de transacciones: Se filtra por tipo de transacción (Crédito o Débito) y se cuenta la cantidad de transacciones de cada una.

5. Reporte general: Se muestran en consola todos los indicadores anteriores de forma clara.

### Decisiones de diseño:
1. Separación de responsabilidades en capas lógicas y clases:
   - Models/: Contiene el modelo de datos Transaction.
   - Services/: Contiene la lógica de negocio en una clase de servicio 
     reutilizable TransactioService.cs
   - Program.cs: Punto de entrada con la interfaz de usuario por consola.

2. Uso de métodos estáticos para simplificar llamadas en esta aplicación sencilla.
3. Uso de LINQ y métodos reutilizables para mantener el código limpio y expresivo.
4. Uso de CultureInfo.InvariantCulture para asegurar la correcta lectura de decimales.

## Estructura del Proyecto
```text
INTERBANK-ACADEMY-25/
│
├── BankingTransaction/
│   ├── bin/                         # Archivos binarios compilados
│   ├── obj/                         # Archivos de compilación intermedios
│   ├── Models/
│   │   └── Transaction.cs           # Modelo de datos
│   ├── Services/
│   │   └── TransactionService.cs    # Lógica de negocio (balance, conteo, etc.)
│   ├── BankingTransaction.csproj    # Proyecto de C#
│   ├── Program.cs                   # Punto de entrada con el menú de consola
│   └── README.md                    # Documentación del proyecto
│
├── data.csv                         # Archivo con transacciones de entrada
│── interbank-academy-25.sln         # Referencia a la solución del proyecto
└── README.md                        # Instrucciones para desarrollar el proyecto
```