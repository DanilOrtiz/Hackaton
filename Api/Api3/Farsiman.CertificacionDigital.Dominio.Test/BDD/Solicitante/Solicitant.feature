#language: es-ES

Característica: Solicitante
	Verificación de parámetros para crear un solicitante 

@Solicitante
Escenario: Agregando Solicitante
	Dado el departamento con su estado <EstadoDepartamento>
	Y el correo del solicitante <Correo>
	Cuando se registra un solicitante 
	Entonces la respuesta es <Respuesta>
	Y el mensaje es <Mensaje>
	Ejemplos: 
	| EstadoDepartamento | Correo         | Respuesta | Mensaje                                 |
	| false              |				  | false     | El departamento se encuentra desativado |
	| true               | maynor.fuentes | true      | El correo no tiene un formato valido.   |
