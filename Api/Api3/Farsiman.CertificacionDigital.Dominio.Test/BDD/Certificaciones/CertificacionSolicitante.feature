#language: es-ES

Característica: CertificacionSolicitante
	Criterios para crear agregar una
	cita de certificación para un solicitante determinado

@CertificacionSolicitant
Esquema del escenario: Agrengando una certificación a un Solicitante
	Dado el estado del solicitante es  '<EstadoSolicitante>'
	Y el estado de la certificacion
	Y la fecha de certificacion
    Cuando se agenda una certificación 
	Entonces el resultado es
	Y el mensaje es 

	Ejemplos: 
	| EstadoSolicitante | EstadoCertificacion | FechaCertificacion | Respuesta | Mensaje                                                         |
	| false             | false               |                    | false     | El solicitante se encuentra desactivado                         |
	| true              | false               |                    | false     | La certificación se encuentra desactivado                       |
	| true              | true                | 2017-11-03         | false     | La fecha de la certificacion debe ser mayor que la fecha actual |
