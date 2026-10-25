# SistemaGestionEscolar

## Nombre del sistema
Sistema de Gestión Escolar

## Nombre de los integrantes
Joustin Damián Grijalva Mármol
William Oswaldo Villasis Sanango
Cristina Alexandra Guamán Ortega
Wendy Nayeli Bazan Aguayo


## Entidades desarrolladas
Estudiante -> Joustin Grijalva
Maestro -> William Oswaldo Villasis Sanango
Aula -> Cristina Alexandra Guamán Ortega
Libro -> Wendy Nayeli Bazan Aguayo

## Pasos de ejecución
La cadena de conexión es la siguiente:
1. Clonar el repositorio
2. Confirmar que la configuracion de sqlserver sea compatible con la cadena de conexión que ve a continuación:
"ConnectionStrings": {
  "SistemaGestionEscolarContext": "Server=localhost\\SQLEXPRESS;Database=SistemaGestionEscolarContext;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
}
3. Se debe escribir los siguientes comandos: add-migration (nombre de la migración) y update-database para evitar problemas al momento de crear la base de datos y usar las funciones CRUD